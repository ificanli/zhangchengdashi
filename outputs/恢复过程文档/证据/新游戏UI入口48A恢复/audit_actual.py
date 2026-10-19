import difflib
import hashlib
import json
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/stage48-new-ui'
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()

def span(text, token):
    pos = text.index('[Token(Token = "' + token + '")]')
    begin = text.index('{', pos)
    end, depth = begin + 1, 1
    while depth:
        depth += (text[end] == '{') - (text[end] == '}')
        end += 1
    return pos, begin, end

def section(text, token):
    pos, begin, end = span(text, token)
    return text[pos:end]

def mask(text, tokens):
    for token in tokens:
        pos, begin, end = span(text, token)
        text = text[:pos] + '<ALLOWED_METHOD_' + token + '>' + text[end:]
    return text

files = []
for name, tokens in [('UIManager', ['0x6004C57', '0x6004C58', '0x6004C5C']), ('UIPanel', ['0x6004C4C'])]:
    source = PROJECT / ('Assets/Scripts/Assembly-CSharp/UIFramework/' + name + '.cs')
    before = OWN / ('source-before/' + name + '.cs')
    old = before.read_text(encoding='utf-8-sig')
    new = source.read_text(encoding='utf-8-sig')
    assert source.read_bytes() == (OWN / (name + '.candidate.cs')).read_bytes(), name
    assert source.with_suffix('.cs.meta').read_bytes() == before.with_suffix('.cs.meta').read_bytes(), name
    assert mask(before.read_bytes().decode('utf-8'), tokens) == mask(source.read_bytes().decode('utf-8'), tokens), 'out-of-scope raw byte/newline diff: ' + name
    assert re.findall(r'\[Token\(Token = "([^"]+)"\)\]', old) == re.findall(r'\[Token\(Token = "([^"]+)"\)\]', new), name
    assert mask(old, tokens) == mask(new, tokens), 'out-of-scope diff: ' + name
    patch = '\n'.join(difflib.unified_diff(old.splitlines(), new.splitlines(), fromfile='before/' + name + '.cs', tofile='after/' + name + '.cs', lineterm=''))
    (OWN / 'diff').mkdir(exist_ok=True)
    (OWN / 'diff' / (name + '.patch')).write_text(patch, encoding='utf-8')
    files.append(dict(path=source.relative_to(PROJECT).as_posix(), beforeSha256=sha(before), afterSha256=sha(source), metaSha256=sha(source.with_suffix('.cs.meta')), restoredTokens=tokens, allOtherTextByteEquivalent=True, originalTokenSequencePreserved=True))

manager = (PROJECT / files[0]['path']).read_text(encoding='utf-8-sig')
panel = (PROJECT / files[1]['path']).read_text(encoding='utf-8-sig')
before_manager = (OWN / 'source-before/UIManager.cs').read_text(encoding='utf-8-sig')
before_panel = (OWN / 'source-before/UIPanel.cs').read_text(encoding='utf-8-sig')
assert section(manager, '0x6004C59') == section(before_manager, '0x6004C59')
assert 'RECOVERY_UNIMPLEMENTED UIManager.IsPanelShowing' in section(manager, '0x6004C59')
assert section(panel, '0x6004C40') == section(before_panel, '0x6004C40')
assert 'return m_isPlayTween;' in section(panel, '0x6004C40')
init = section(manager, '0x6004C57')
get = section(manager, '0x6004C58')
load = section(manager, '0x6004C5C')
source_checks = {
    'Init_async_original_zero_await': 'async UniTask Init()' in init and 'await ' not in init,
    'Init_original_cache_root_own_flag_order': init.index('new Dictionary<string, UIPanel>') < init.index('new GameObject("UIPanelsRoot")') < init.index('initcomplete = true;'),
    'GetPanel_original_Task_await': get.count('await ') == 1 and 'return await LoadPanel(panelPath);' in get,
    'LoadPanel_original_typed_UniTask_await': load.count('await ') == 1 and 'await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(panelPath)' in load,
    'LoadPanel_after_await_recheck_before_instantiate': load.index('await AssetsModule') < load.index('_uiPanelsDict.TryGetValue') < load.index('UnityEngine.Object.Instantiate(prefab, _panelsParent)'),
    'LoadPanel_hide_cache_then_camera_config_leaf': load.index('SetActive(false)') < load.index('_uiPanelsDict.Add(panelPath, panel)') < load.index('canvas.worldCamera') < load.index('GlobalInfo.panelConfigs.Find') < load.index('panel.Init(config)'),
    'LoadPanel_exact_case_predicate': 'item.panelName == panel.name' in load,
    'UIPanel_original_single_field_store': section(panel, '0x6004C4C').count('this.panelConfig = panelConfig;') == 1,
    'protected_diagnostic_and_existing_getter_unchanged': True,
}
assert all(source_checks.values()), source_checks

build = json.loads((OWN / 'compile/actual/result.json').read_text(encoding='utf-8-sig'))
assert build['exitCode'] == 0 and build['errorCount'] == 0
test_results = {}
for mode, expected in [('baseline', (19, 19, 19)), ('candidate', (19, 92, 0)), ('actual', (19, 92, 0))]:
    text = (OWN / ('tests/' + mode + '-run.log')).read_text(encoding='utf-8-sig')
    found = re.search(r'RESULT scenarios=(\d+) checks=(\d+) failures=(\d+)', text)
    assert found and tuple(map(int, found.groups())) == expected, mode
    test_results[mode] = dict(zip(['scenarios', 'checks', 'failures'], expected))

full_il = OWN / 'compile/actual/Assembly-CSharp.all.il.txt'
all_text = full_il.read_text(encoding='utf-8-sig')
ils = {}
for name in ['UIManager', 'UIPanel']:
    end = re.search(r'\} // end of class UIFramework\.' + name + r'\s*\n', all_text)
    assert end, name
    begin = all_text.rfind('\n.class ', 0, end.start()) + 1
    selected = all_text[begin:end.end()]
    assert len(selected) < 200000, name
    (OWN / ('compile/actual/' + name + '.il.txt')).write_text(selected, encoding='utf-8')
    ils[name] = selected

def il_method(text, owner, member):
    end = text.index('} // end of method ' + owner + '::' + member + '\n')
    begin = text.rfind('.method ', 0, end)
    return text[begin:end]

def state_move(name):
    owner = re.search(r"\} // end of method ('<" + name + r">d__\d+')::MoveNext\n", ils['UIManager'])[1]
    return il_method(ils['UIManager'], owner, 'MoveNext')

ii, gi, li = [state_move(name) for name in ['Init', 'GetPanel', 'LoadPanel']]
leaf = il_method(ils['UIPanel'], 'UIPanel', 'Init')
getter = il_method(ils['UIPanel'], 'UIPanel', 'get_IsPlayTween')
diagnostic = il_method(ils['UIManager'], 'UIManager', 'IsPanelShowing')
predicate_owner = re.search(r"\} // end of method ('<>c__DisplayClass\d+_\d+')::'<LoadPanel>b__0'", ils['UIManager'])[1]
predicate = il_method(ils['UIManager'], predicate_owner, "'<LoadPanel>b__0'")
il_checks = {
    'Init_real_UniTask_builder_zero_await_exception_capture': 'AsyncUniTaskMethodBuilder::SetException' in ii and '::AwaitUnsafeOnCompleted' not in ii,
    'Init_dictionary_root_transform_then_own_completion': ii.index('::_uiPanelsDict') < ii.index('ldstr "UIPanelsRoot"') < ii.index('::_panelsParent') < ii.index('::initcomplete'),
    'GetPanel_one_Task_await_with_UniTask_builder': gi.count('::AwaitUnsafeOnCompleted') == 1 and 'System.Runtime.CompilerServices.TaskAwaiter`1<class UIFramework.UIPanel>' in gi and 'AsyncUniTaskMethodBuilder`1<class UIFramework.UIPanel>::AwaitUnsafeOnCompleted' in gi,
    'GetPanel_hot_exact_cache_lookup_before_load': gi.index('::ContainsKey(') < gi.index('::get_Item(') < gi.index('::LoadPanel(string)'),
    'LoadPanel_one_typed_UniTask_await_with_Task_builder': li.count('::AwaitUnsafeOnCompleted') == 1 and 'AssetsModule.AssetsManager::LoadAssetAsync<class [UnityEngine.CoreModule]UnityEngine.GameObject>' in li and 'AsyncTaskMethodBuilder`1<class UIFramework.UIPanel>::AwaitUnsafeOnCompleted' in li,
    'LoadPanel_after_GetResult_cache_recheck_before_Instantiate': li.index('::GetResult()') < li.index('::TryGetValue(') < li.index('UnityEngine.Object::Instantiate<'),
    'LoadPanel_original_Instantiate_parent_and_real_component': 'UnityEngine.Object::Instantiate<class [UnityEngine.CoreModule]UnityEngine.GameObject>(!!0, class [UnityEngine.CoreModule]UnityEngine.Transform)' in li and 'UnityEngine.GameObject::GetComponent<class UIFramework.UIPanel>()' in li,
    'LoadPanel_false_active_then_cache_before_camera_config_leaf': bool(re.search(r'ldc.i4.0\s+IL_[0-9a-f]+: callvirt instance void .*UnityEngine.GameObject::SetActive', li)) and li.index('::SetActive(bool)') < li.index('::Add(!0, !1)') < li.index('CameraManager::get_UICamera()') < li.index('GlobalInfo::panelConfigs') < li.index('UIPanel::Init(class DataModule.PanelConfig)'),
    'LoadPanel_optional_Canvas_layer_and_original_binding': '::TryGetComponent<class [UnityEngine.UIModule]UnityEngine.Canvas>' in li and 'Canvas::set_worldCamera' in li and 'PanelConfig::layer' in li and 'Canvas::set_sortingOrder' in li,
    'LoadPanel_case_sensitive_original_string_predicate': 'PanelConfig::panelName' in predicate and 'UnityEngine.Object::get_name()' in predicate and 'System.String::op_Equality(string, string)' in predicate and 'IgnoreCase' not in predicate,
    'UIPanel_Init_exact_single_original_field_store': leaf.count('stfld ') == 1 and 'stfld class DataModule.PanelConfig UIFramework.UIPanel::panelConfig' in leaf and not re.search(r'IL_[0-9a-f]+: call', leaf),
    'protected_getter_and_diagnostic_still_compiled': 'ldfld bool UIFramework.UIPanel::m_isPlayTween' in getter and 'RECOVERY_UNIMPLEMENTED UIManager.IsPanelShowing' in diagnostic and 'throw' in diagnostic,
}
assert all(il_checks.values()), il_checks

result = dict(stage=48, status='actual-four-method-source-applied-and-verified', files=files, restoredMethods=4, sourceChecks=source_checks, ILChecks=il_checks, tests=test_results, fullMainCompile=build, unityOperations=0, experimentDllInstalled=False, actualTypedUnityLoad=False, visibleUIAccepted=False, coreGameplayAccepted=False)
(OWN / 'final-audit.json').write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps({k: v for k, v in result.items() if k != 'fullMainCompile'}, ensure_ascii=True, indent=2))
