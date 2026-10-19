from pathlib import Path
p=Path('work/stage38-savebase/make_plan.py');s=p.read_text(encoding='utf-8')
old='    LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);'
new='    if (_007C_007Ev_00A8G_00BB && DataManagerPool.CanSaveLocalData && (int)GameFramework.Login.ILoginProcedure.accountType >= 10)\n        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);'
s=s.replace(old,new,1);p.write_text(s,encoding='utf-8')
p=Path('work/stage38-savebase/Rewrite.cs');s=p.read_text(encoding='utf-8').replace('addedOriginalCctor=file.addHelper!=null','addedHelper=file.addHelper!=null');p.write_text(s,encoding='utf-8')
p=Path('work/stage38-savebase/prepare_registration_tail.py');s=p.read_text(encoding='utf-8').replace("'0x6005874'","'0x6005877'").replace("'void PoolCctor(const MethodInfo* method);',None","'void PoolCctor(const MethodInfo* method);','0x600587E'");p.write_text(s,encoding='utf-8')
p=Path('work/stage38-savebase/inspect_report_scalars.py');s=p.read_text(encoding='utf-8').replace('   for op in ops:\n','   for op in ops:\n    if op==0xD65F03C0:break\n');p.write_text(s,encoding='utf-8')
