"""Compile HLSL extracted from actual stage50 shader candidates; never launches Unity.

Only include directives in copied dependencies are remapped. Shader functions and
entrypoints are taken directly from candidate HLSLINCLUDE and HLSLPROGRAM blocks.
FXC validates D3D11 HLSL/bytecode, not Unity ShaderLab import or GPU rendering.
"""
import argparse
import hashlib
import json
from pathlib import Path
import re
import subprocess
import sys

ROOT = Path(__file__).resolve().parents[3]
AUDIT = Path(__file__).resolve().parent
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
DEFAULT_FXC = Path(r'C:\Program Files (x86)\Windows Kits\10\bin\10.0.26100.0\x64\fxc.exe')
INCLUDE = re.compile(r'^\s*#\s*(include(?:_with_pragmas)?)\s*["<]([^">]+)[">]', re.M)


def sha(path):
    return hashlib.sha256(path.read_bytes()).hexdigest()


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--candidate-root', type=Path, default=ROOT/'work/parallel-50-render/candidate')
    parser.add_argument('--fxc', type=Path, default=DEFAULT_FXC)
    parser.add_argument('--result-name', default='fxc-candidate-results.json')
    parser.add_argument('--source-before-root', type=Path, default=ROOT/'work/parallel-50-render/before')
    parser.add_argument('--smoke', action='store_true', help='Only first base vertex/fragment for harness setup')
    args = parser.parse_args()
    work = AUDIT / ('fxc-smoke' if args.smoke else 'fxc-output')
    work.mkdir(parents=True, exist_ok=True)
    deps = work/'includes'
    deps.mkdir(exist_ok=True)
    package_roots = {p.name.split('@')[0]: p for p in (PROJECT/'Library/PackageCache').iterdir() if p.is_dir()}
    cg = Path(r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\CGIncludes')
    remapped = {}
    missing = set()

    def resolve(name, origin):
        if name.startswith('Packages/'):
            _, package, suffix = name.split('/', 2)
            return package_roots.get(package, PROJECT/'Packages'/package)/suffix
        local = origin.parent/name
        if local.exists():
            return local
        return cg/name

    def remap_source(source, origin):
        def repl(match):
            target = resolve(match.group(2), origin)
            if not target.is_file():
                missing.add(str(target))
                # Preserve inactive platform branches; an active missing include
                # must remain a real compile failure, never stubbed out.
                return match.group(0)
            new = copy_dependency(target)
            return '#include "' + new.as_posix() + '"'
        return INCLUDE.sub(repl, source)

    def copy_dependency(original):
        original = original.resolve()
        if original in remapped:
            return remapped[original]['copy']
        key = hashlib.sha256(str(original).encode('utf-8')).hexdigest()[:16]
        new = deps/(key+'_'+original.name)
        remapped[original] = {'copy':new, 'sha256':sha(original)}
        new.write_text(remap_source(original.read_text(encoding='utf-8-sig'), original), encoding='utf-8')
        return new

    version = subprocess.run([str(args.fxc), '/?'], capture_output=True, text=True)
    (AUDIT/'fxc-help.txt').write_text(version.stdout+version.stderr, encoding='utf-8')
    macros = ['SHADER_API_D3D11=1', 'UNITY_COMPILER_HLSL=1', 'SHADER_TARGET=20', 'UNITY_VERSION=202230']
    result = {'tool':str(args.fxc), 'tool_sha256':sha(args.fxc), 'tool_header':version.stdout.splitlines()[:2],
              'macros':macros, 'profiles':['vs_5_0','ps_5_0'], 'fxc_flags':['/Gec'],
              'flag_reason':'FXC legacy half globals in URP Deprecated.hlsl require /Gec; D3D11 half is represented as float. No HLSL body replacement.',
              'candidate_root':str(args.candidate_root),
              'limitation':'Independent D3D11 HLSL bytecode compilation; does not validate Unity ShaderLab import, pass selection, runtime shader keywordSpace, GLES/Vulkan/Metal or final pixels.',
              'shaders':[], 'compiles':[], 'all_pass':False}
    seen = {}
    names = ['Hidden_Universal_CoreBlit.shader', 'Hidden_Universal_CoreBlit_0.shader',
             'Hidden_Universal_CoreBlitColorAndDepth.shader', 'Hidden_Universal_CoreBlitColorAndDepth_0.shader']
    for name in names:
        candidate = args.candidate_root/'Assets/Shader'/name
        source = candidate.read_text(encoding='utf-8-sig')
        original = args.source_before_root/'Assets/Shader'/name
        programs = re.findall(r'\bHLSLPROGRAM\b(.*?)\bENDHLSL\b', source, re.S)
        includes = '\n'.join(re.findall(r'\bHLSLINCLUDE\b(.*?)\bENDHLSL\b', source, re.S))
        original_source = original.read_text(encoding='utf-8-sig')
        negative = {'sha256':sha(original), 'pass_count':len(re.findall(r'^\s*Pass\s*(?:\n\s*)?\{',original_source,re.M)),
                    'local_decode_hdr':bool(re.search(r'#pragma\s+multi_compile_local\s+_\s+BLIT_DECODE_HDR\b',original_source))}
        is_core = 'ColorAndDepth' not in name
        negative['required_pass1_missing'] = negative['pass_count'] <= 1
        negative['required_keyword_missing'] = is_core and not negative['local_decode_hdr']
        digest = sha(candidate)
        record = {'path':str(candidate), 'sha256':digest, 'pass_count':len(programs),
                  'local_decode_hdr':bool(re.search(r'#pragma\s+multi_compile_local\s+_\s+BLIT_DECODE_HDR\b',source)),
                  'source_before_negative_control':negative}
        official_name='CoreBlit.shader' if is_core else 'CoreBlitColorAndDepth.shader'
        official=package_roots['com.unity.render-pipelines.universal']/'Shaders/Utils'/official_name
        record['official_sha256']=sha(official)
        record['exact_official_bytes']=digest==record['official_sha256']
        record['candidate_contract_pass']=len(programs)==(25 if is_core else 2) and (not is_core or record['local_decode_hdr']) and record['exact_official_bytes']
        result['shaders'].append(record)
        if digest in seen:
            record['same_bytes_as_compiled_shader'] = seen[digest]
            continue
        seen[digest] = name
        for index, program in enumerate(programs):
            joined = includes+'\n'+program
            extracted = work/(candidate.stem+f'.pass{index:02d}.hlsl')
            extracted.write_text(remap_source(joined, candidate),encoding='utf-8')
            # The only transformations are remapped includes and standard
            # externally supplied Unity platform/stage/keyword definitions.
            keyword_sets = [()]
            if not args.smoke:
                if is_core and index in (21,22):
                    keyword_sets.append(('BLIT_DECODE_HDR=1',))
                if is_core and index in (23,24):
                    keyword_sets += [('_LINEAR_TO_SRGB_CONVERSION=1',),('DEBUG_DISPLAY=1',),('_LINEAR_TO_SRGB_CONVERSION=1','DEBUG_DISPLAY=1')]
                # Real single-slice and array-disable branches from shader
                # common pragmas. Array mode requires Unity stereo defines.
                keyword_sets += [('DISABLE_TEXTURE2D_X_ARRAY=1',),
                                 ('STEREO_INSTANCING_ON=1','BLIT_SINGLE_SLICE=1')]
                if is_core:
                    # Blit.hlsl's additional guard is not declared by this
                    # package's literal source. Define it explicitly only in
                    # this coverage case; it does not claim runtime XR usage.
                    keyword_sets += [('STEREO_INSTANCING_ON=1','BLIT_SINGLE_SLICE=1','USE_TEXTURE2D_X_AS_ARRAY=1')]
            for variant_no, keywords in enumerate(keyword_sets):
                for stage, profile in [('vertex','vs_5_0'),('fragment','ps_5_0')]:
                    entry_match = re.search(r'#pragma\s+'+stage+r'\s+(\w+)',program)
                    if not entry_match:
                        raise RuntimeError(f'Missing {stage} entry in {candidate} pass{index}')
                    entry = entry_match.group(1)
                    tag=f'{candidate.stem}.p{index:02d}.v{variant_no}.{stage}'
                    binary=work/(tag+'.dxbc')
                    log=work/(tag+'.log')
                    definitions=macros+[f'SHADER_STAGE_{stage.upper()}=1']+list(keywords)
                    command=[str(args.fxc),'/nologo','/Gec','/T',profile,'/E',entry,'/Fo',str(binary)]
                    for macro in definitions:
                        command+=['/D',macro]
                    command.append(str(extracted))
                    completed=subprocess.run(command,capture_output=True,text=True)
                    log.write_text(completed.stdout+completed.stderr,encoding='utf-8')
                    run={'shader':name,'pass':index,'stage':stage,'entry':entry,'keywords':keywords,
                         'command':command,'exit_code':completed.returncode,'log':str(log),
                         'binary':str(binary),'binary_bytes':binary.stat().st_size if binary.exists() else 0}
                    result['compiles'].append(run)
                    if completed.returncode:
                        print(f'FAIL {tag}: {completed.stdout}{completed.stderr}',flush=True)
                    else:
                        print(f'PASS {tag}',flush=True)
            if args.smoke:
                break
    result['include_dependencies']=[{'original':str(path),'sha256':entry['sha256'],'copy':str(entry['copy'])}
                                    for path,entry in remapped.items()]
    result['unresolved_inactive_includes']=sorted(missing)
    result['binary_contracts'] = []
    if not args.smoke:
        checks = [('Hidden_Universal_CoreBlitColorAndDepth.p01.v0.fragment', ['SV_Depth','oDepth','_InputDepthTexture','sample_l_indexable']),
                  ('Hidden_Universal_CoreBlit.p01.v0.fragment', ['_BlitTexture','sampler_LinearClamp','sample_l_indexable']),
                  ('Hidden_Universal_CoreBlit.p21.v1.fragment', ['_BlitDecodeInstructions','_BlitCubeTexture'])]
        for tag, required in checks:
            dump=subprocess.run([str(args.fxc),'/nologo','/dumpbin',str(work/(tag+'.dxbc'))],capture_output=True,text=True)
            dump_path=work/(tag+'.disassembly.txt')
            dump_path.write_text(dump.stdout+dump.stderr,encoding='utf-8')
            result['binary_contracts'].append({'tag':tag,'required':required,'present':{term:term in dump.stdout for term in required},'exit_code':dump.returncode,'dump':str(dump_path)})
    result['all_pass']=all(r['exit_code']==0 and r['binary_bytes']>0 for r in result['compiles']) and bool(result['compiles']) and all(c['exit_code']==0 and all(c['present'].values()) for c in result['binary_contracts']) and all(s['candidate_contract_pass'] and s['source_before_negative_control']['required_pass1_missing'] for s in result['shaders'])
    result['compile_count']=len(result['compiles'])
    result['failed_count']=sum(r['exit_code']!=0 for r in result['compiles'])
    out=AUDIT/args.result_name
    out.write_text(json.dumps(result,indent=2,ensure_ascii=False),encoding='utf-8')
    print(json.dumps({'all_pass':result['all_pass'],'compile_count':result['compile_count'], 'failed_count':result['failed_count'], 'result':str(out)},ensure_ascii=False))
    return 0 if result['all_pass'] else 1


if __name__=='__main__':
    sys.exit(main())
