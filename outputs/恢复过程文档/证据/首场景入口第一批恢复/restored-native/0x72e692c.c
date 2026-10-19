void GameFramework_Base_GameStartEntry__f_____(void *self, const MethodInfo *method)
{
  const MethodInfo *v2; // x2
  __int64 v4; // x0
  _QWORD *v5; // x0
  int v6; // w21
  __int64 Module_object; // x19
  __int64 v8; // x0
  __int64 v9; // x2
  __int64 v10; // x21
  _QWORD *v11; // x20
  __int64 v12; // x8
  __int64 v13; // x0
  __int64 v14; // x0

  if ( (byte_900A03D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E1C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E1D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D890D0);
    byte_900A03D = 1;
  }
  v4 = *((_QWORD *)self + 10);
  if ( v4 != 0 )
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v4 + 520LL))(v4, *(_QWORD *)(*(_QWORD *)v4 + 528LL));
  GameFramework_Base_GameStartEntry____M_a_(self, (void *)qword_8D890D0, v2);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v5 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v5 = off_8CE40C8;
  }
  v6 = *(unsigned __int8 *)(v5[23] + 56LL);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  if ( v6 != 0 )
  {
    Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D190);
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
    v9 = qword_8D2E1C0;
  }
  else
  {
    Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D180);
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
    v9 = qword_8D2E1D8;
  }
  v10 = v8;
  System_Action___ctor(v8, self, v9, 0);
  v11 = off_8D1D5E8;
  v12 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v12 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v12 = v11[7];
  }
  v13 = *(_QWORD *)(v12 + 16);
  if ( (*(_BYTE *)(v13 + 309) & 1) == 0 )
    v13 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v13 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v13);
  v14 = *(_QWORD *)(v11[7] + 16LL);
  if ( (*(_BYTE *)(v14 + 309) & 1) == 0 )
    v14 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(Module_object, v10, **(_QWORD **)(v14 + 184), 0);
}
