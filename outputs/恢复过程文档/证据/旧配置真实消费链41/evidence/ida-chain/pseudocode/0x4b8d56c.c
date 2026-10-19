void stage41_GameFramework_ConfigRead__readCustomConfig_object_(void *a0, void *a1, int a2, void *a3)
{
  __int64 v8; // x0
  __int64 v9; // x19
  __int64 v10; // x0
  __int64 v11; // x0

  if ( *((_QWORD *)a3 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7CBA0);
    if ( *((_QWORD *)a3 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a3);
  }
  if ( a2 != 2 )
  {
    if ( a2 == 1 )
    {
      if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5BB8);
      GameFramework_ConfigRead__readCustomConfigByUnityJson_object_(a0, a1, *(void **)(*((_QWORD *)a3 + 7) + 8LL));
      return;
    }
    v8 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    if ( v8 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v9 = v8;
    if ( qword_8D7CBA0 == 0
      || (v10 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D7CBA0, *(_QWORD *)(*(_QWORD *)v8 + 64LL))) != 0 )
    {
      if ( *(_DWORD *)(v9 + 24) != 0 )
      {
        *(_QWORD *)(v9 + 32) = qword_8D7CBA0;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v9, 0);
        return;
      }
      v10 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v10);
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v11, 0);
    JUMPOUT(0x4B8D6E0);
  }
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  GameFramework_ConfigRead__readCustomConfigByMemoryPack_object_(a0, a1, *(_QWORD *)(*((_QWORD *)a3 + 7) + 16LL));
}
