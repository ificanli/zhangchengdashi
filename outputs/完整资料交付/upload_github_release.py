"""Upload verified recovery archive parts to the user-selected GitHub Release.

Uses the existing Git credential manager in memory; never prints credentials.
"""
from pathlib import Path
import argparse
import hashlib
import http.client
import json
import os
import subprocess
import time
import urllib.error
import urllib.parse
import urllib.request

BASE=Path(__file__).resolve().parent
ROOT=BASE.parents[1]
SCRATCH=ROOT/'work/git-delivery'
REPOSITORY='ificanli/zhangchengdashi'
TAG='recovery-checkpoint-2026-10-19'

def credential():
    result=subprocess.run(['git','credential','fill'],input='protocol=https\nhost=github.com\n\n',capture_output=True,text=True)
    if result.returncode:raise RuntimeError('Git credential lookup failed; no credential text emitted')
    values=dict(line.split('=',1) for line in result.stdout.splitlines() if '=' in line)
    if not values.get('password'):raise RuntimeError('GitHub credential manager returned no token')
    return values['password']

class Github:
    def __init__(self,token):self.token=token
    def api(self,path,data=None,method=None):
        headers={'Authorization':'Bearer '+self.token,'Accept':'application/vnd.github+json','User-Agent':'OccupyCityRecoveryDelivery'}
        raw=json.dumps(data,ensure_ascii=False).encode('utf-8') if data is not None else None
        if raw is not None:headers['Content-Type']='application/json'
        request=urllib.request.Request('https://api.github.com'+path,data=raw,headers=headers,method=method)
        with urllib.request.urlopen(request,timeout=120) as response:return json.load(response)
    def asset(self,url,path):
        parsed=urllib.parse.urlsplit(url)
        connection=http.client.HTTPSConnection(parsed.hostname,timeout=180)
        size=path.stat().st_size
        connection.putrequest('POST',parsed.path+'?'+urllib.parse.urlencode({'name':path.name}))
        connection.putheader('Authorization','Bearer '+self.token)
        connection.putheader('Accept','application/vnd.github+json')
        connection.putheader('User-Agent','OccupyCityRecoveryDelivery')
        connection.putheader('Content-Type','application/octet-stream')
        connection.putheader('Content-Length',str(size));connection.endheaders()
        sent=0;last=time.monotonic()
        with path.open('rb') as source:
            while block:=source.read(4*1024*1024):
                connection.send(block);sent+=len(block)
                now=time.monotonic()
                if now-last>12:
                    print(f'Uploading {path.name}: {sent}/{size} bytes',flush=True);last=now
                    (SCRATCH/'upload-progress.json').write_text(json.dumps(dict(stage='uploading',name=path.name,sentBytes=sent,totalBytes=size)),encoding='utf-8')
        response=connection.getresponse();body=response.read();status=response.status;connection.close()
        if status not in (200,201):
            try:message=json.loads(body).get('message','')
            except ValueError:message='Non-JSON response'
            raise RuntimeError(f'GitHub asset upload status {status}: {message}')
        return json.loads(body)

def sha(path):
    h=hashlib.sha256()
    with path.open('rb') as source:
        while block:=source.read(4*1024*1024):h.update(block)
    return h.hexdigest()

def main():
    parser=argparse.ArgumentParser();parser.add_argument('--publish',action='store_true');args=parser.parse_args()
    verified=json.loads((SCRATCH/'archive-verification.json').read_text())
    assert verified['status']=='all_parts_and_decompressed_blobs_verified' and verified['failures']==0
    parts=json.loads((BASE/'附件分卷清单.json').read_text())['parts']
    api=Github(credential())
    try:release=api.api(f'/repos/{REPOSITORY}/releases/tags/{TAG}')
    except urllib.error.HTTPError as error:
        if error.code!=404:raise
        release=api.api(f'/repos/{REPOSITORY}/releases',dict(tag_name=TAG,target_commitish='main',
            name='2026-10-19 恢复检查点与完整分析资料',draft=True,prerelease=True,
            body='保存Unity恢复工程对应的全部原始分析现场。工程/报告在main，原始APK、IL2CPP导出、全部IDA数据库、work工具/脚本/候选/备份/失败日志以SHA256去重分卷保存。仅git clone不会取得这些附件；请使用outputs/完整资料交付/restore_all_materials.py下载校验并按原路径恢复。当前恢复按用户要求暂停，原地图、开格/占领、兵堆战斗未验收。'))
    upload_url=release['upload_url'].split('{',1)[0]
    assets={asset['name']:asset for asset in release['assets']}
    uploads=[]
    targets=[(SCRATCH/'release-parts'/part['name'],part) for part in parts]
    targets += [(BASE/name,dict(name=name,bytes=(BASE/name).stat().st_size,sha256=sha(BASE/name)))
                for name in ['附件分卷清单.json','完整资料路径与哈希清单.json','排除项说明.json','README-下载与完整恢复.md','restore_all_materials.py','verify_delivery.py','requirements.txt']]
    targets += [(SCRATCH/'archive-verification.json',dict(name='archive-verification.json',bytes=(SCRATCH/'archive-verification.json').stat().st_size,sha256=sha(SCRATCH/'archive-verification.json')))]
    for path,item in targets:
        if sha(path)!=item['sha256']:raise RuntimeError('Local upload input changed: '+path.name)
        expected='sha256:'+item['sha256'];existing=assets.get(path.name)
        if existing:
            if existing.get('size')!=item['bytes'] or existing.get('digest')!=expected:
                raise RuntimeError('Existing Release asset differs; refuse replacement: '+path.name)
            value=existing;print('Verified existing upload:',path.name,flush=True)
        else:
            for attempt in range(3):
                try:value=api.asset(upload_url,path);break
                except (OSError,http.client.HTTPException) as error:
                    if attempt==2:raise
                    # Upload outcome can be ambiguous; refresh authoritative Release assets.
                    fresh=api.api(f'/repos/{REPOSITORY}/releases/{release["id"]}')
                    existing=next((asset for asset in fresh['assets'] if asset['name']==path.name),None)
                    if existing:
                        if existing.get('size')==item['bytes'] and existing.get('digest')==expected:value=existing;break
                        raise RuntimeError('Interrupted upload has an unverified existing asset; refusing overwrite')
                    time.sleep(2)
            if value.get('state')!='uploaded' or value.get('size')!=item['bytes'] or value.get('digest')!=expected:
                raise RuntimeError('GitHub stored asset digest/size did not match: '+path.name)
            print('Uploaded and server SHA verified:',path.name,flush=True)
        uploads.append(dict(name=path.name,bytes=item['bytes'],sha256=item['sha256'],assetId=value['id'],
                            serverDigest=value.get('digest'),url=value['browser_download_url']))
        (SCRATCH/'uploaded-assets.json').write_text(json.dumps(uploads,ensure_ascii=False,indent=2),encoding='utf-8')
    final=api.api(f'/repos/{REPOSITORY}/releases/{release["id"]}')
    live={asset['name']:asset for asset in final['assets']}
    for item in uploads:
        value=live.get(item['name']);assert value and value['size']==item['bytes'] and value.get('digest')=='sha256:'+item['sha256']
    if args.publish:final=api.api(f'/repos/{REPOSITORY}/releases/{release["id"]}',dict(draft=False,prerelease=True),method='PATCH')
    result=dict(status='release_uploaded_server_digest_verified',repository=REPOSITORY,releaseTag=TAG,
                releaseUrl=final['html_url'],releaseId=final['id'],draft=final['draft'],assets=uploads,
                uploadedFiles=len(uploads),uploadedBytes=sum(item['bytes'] for item in uploads),
                archiveLocalVerificationPassed=True,serverSha256AllMatched=True)
    (BASE/'上传验证结果.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
    print(json.dumps({key:value for key,value in result.items() if key!='assets'},ensure_ascii=False,indent=2))

if __name__=='__main__':main()
