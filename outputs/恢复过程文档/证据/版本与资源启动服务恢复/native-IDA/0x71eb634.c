void __fastcall GameFramework_VersionMondule__Initialize(__int64 a1)
{
  __int64 v2; // x8
  _QWORD *v3; // x0
  __int64 Instance; // x20
  __int64 v5; // x0

  if ( (byte_90096E5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_90096E5 = 1;
  }
  if ( *(_BYTE *)(a1 + 16) != 0 )
  {
    v2 = *(_QWORD *)(a1 + 24);
    if ( v2 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD))(v2 + 24))(*(_QWORD *)(v2 + 64), *(_QWORD *)(v2 + 40));
  }
  else
  {
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    if ( byte_900876D == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
      byte_900876D = 1;
    }
    v3 = off_8CE40C8;
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v3 = off_8CE40C8;
    }
    if ( *(_BYTE *)(v3[23] + 56LL) != 0 )
    {
      GameFramework_VersionMondule__InitForNewRes(a1);
    }
    else
    {
      Instance = UpdateManager__get_Instance(0);
      v5 = GameFramework_VersionMondule__Init(a1);
      if ( Instance == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_MonoBehaviour__StartCoroutine(Instance, v5, 0);
    }
  }
}
