void GameFramework_Base_GameStartEntry__O_Jy__(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  _QWORD *v4; // x0
  __int64 v5; // x20
  _QWORD *v6; // x19
  __int64 v7; // x8
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x19

  if ( (byte_900A05D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E1D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF5080);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66490);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7D250);
    byte_900A05D = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D66490);
  v3 = **((_QWORD **)off_8CECCD8 + 23);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  DBTSDK_SDKToolManager__U3DGameStart_Override(v3, 0);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v4 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v4 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v4[23] + 56LL) != 0 )
  {
    GameFramework_Base_GameStartEntry__O____i(self);
  }
  else
  {
    v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF5080);
    GameFramework_Resources_ResourcesModule_LoadAssetCompleteHandler___ctor(v5, self, qword_8D2E1D0);
    v6 = off_8D1D5E8;
    v7 = *((_QWORD *)off_8D1D5E8 + 7);
    if ( v7 == 0 )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
      v7 = v6[7];
    }
    v8 = *(_QWORD *)(v7 + 16);
    if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
      v8 = ((__int64 (*)(void))unk_3C503A0)();
    if ( *(_DWORD *)(v8 + 224) == 0 )
      il2cpp_codegen_runtime_class_init((void *)v8);
    v9 = *(_QWORD *)(v6[7] + 16LL);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (*)(void))unk_3C503A0)();
    v10 = **(_QWORD **)(v9 + 184);
    if ( *((_DWORD *)off_8CEC898 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEC898);
    GameFramework_ResLoadHelper__LoadAsset(qword_8D7D250, v5, v10, 0);
  }
}
