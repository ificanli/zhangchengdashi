void stage41_GameFramework_ConfigRead__readCustomConfigByUnityJson_object_(void *a0, void *a1, void *a2)
{
  __int64 v3; // x8
  __int64 v7; // x22
  _QWORD *v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 v12; // x19
  _QWORD *v13; // x21
  __int64 v14; // x8
  __int64 v15; // x0
  __int64 v16; // x0

  v3 = *((_QWORD *)a2 + 7);
  if ( v3 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    v3 = *((_QWORD *)a2 + 7);
    if ( v3 == 0 )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(a2);
      v3 = *((_QWORD *)a2 + 7);
    }
  }
  if ( (*(_BYTE *)(*(_QWORD *)v3 + 309LL) & 1) == 0 )
    ((void (*)(void))unk_3C503A0)();
  v7 = ((__int64 (*)(void))unk_3C3D4C4)();
  GameFramework_ConfigRead__SM_yV_object____ctor(v7, *(_QWORD *)(*((_QWORD *)a2 + 7) + 8LL));
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v7 + 16) = a1;
  *(_QWORD *)(v7 + 24) = a0;
  v8 = off_8CE5BB8;
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v8 = off_8CE5BB8;
  }
  if ( *(_BYTE *)(v8[23] + 32LL) != 0 )
  {
    v9 = *(_QWORD *)(v7 + 24);
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8338);
    v11 = *((_QWORD *)a2 + 7);
    v12 = v10;
    System_Action_object____ctor(v10, v7, *(_QWORD *)(v11 + 24), 0);
    v13 = off_8D1D5E8;
    v14 = *((_QWORD *)off_8D1D5E8 + 7);
    if ( v14 == 0 )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
      v14 = v13[7];
    }
    v15 = *(_QWORD *)(v14 + 16);
    if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
      v15 = ((__int64 (*)(void))unk_3C503A0)();
    if ( *(_DWORD *)(v15 + 224) == 0 )
      il2cpp_codegen_runtime_class_init((void *)v15);
    v16 = *(_QWORD *)(v13[7] + 16LL);
    if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
      v16 = ((__int64 (*)(void))unk_3C503A0)();
    GameFramework_NewResLoadHelper__LoadAsset(v9, v12, **(_QWORD **)(v16 + 184), 0);
  }
}
