void __fastcall GameFramework_AssetbundleModule__Initialize(__int64 a1)
{
  __int64 v2; // x8
  _DWORD **v3; // x0
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 Instance; // x20
  __int64 Manifest; // x0

  if ( (byte_9008F3C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF418);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF270);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA010);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9FD0);
    byte_9008F3C = 1;
  }
  if ( *(_BYTE *)(a1 + 16) != 0 )
  {
    v2 = *(_QWORD *)(a1 + 24);
    if ( v2 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD))(v2 + 24))(*(_QWORD *)(v2 + 64), *(_QWORD *)(v2 + 40));
  }
  else
  {
    if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4408);
    if ( byte_900900F == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
      byte_900900F = 1;
    }
    v3 = (_DWORD **)off_8CE4408;
    if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE4408);
      v3 = (_DWORD **)off_8CE4408;
    }
    *v3[23] = 1;
    AssetBundles_AssetBundleManager__Initialize(0);
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9FD0);
    System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFF270);
    *(_QWORD *)(a1 + 32) = v4;
    v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA010);
    System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFF418);
    *(_QWORD *)(a1 + 40) = v5;
    Instance = UpdateManager__get_Instance();
    Manifest = GameFramework_AssetbundleModule__LoadManifest(a1);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_MonoBehaviour__StartCoroutine(Instance, Manifest, 0);
  }
}
