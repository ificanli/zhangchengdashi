__int64 __fastcall GameFramework_Resources_ResourcesInfo__Instantiate(__int64 a1, __int64 a2, char a3)
{
  __int64 v6; // x0
  _QWORD *Asset; // x20
  __int64 v8; // x21
  __int64 v9; // x0
  __int64 name; // x0
  __int64 v11; // x0

  if ( (byte_900A0F9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34FB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF230);
    byte_900A0F9 = 1;
  }
  v6 = *(_QWORD *)(a1 + 40);
  if ( v6 == 0 )
    goto LABEL_17;
  Asset = (_QWORD *)UnityEngine_AssetBundle__LoadAsset(v6, a2, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v8 = 0;
  if ( (UnityEngine_Object__op_Inequality(Asset, 0, 0) & 1) != 0 )
  {
    if ( Asset == nullptr || *Asset != qword_8CE7B80 )
      return 0;
    if ( *((_DWORD *)off_8CEF230 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEF230);
    GameFramework_Utils__ResetShader(Asset, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v9 = UnityEngine_Object__Instantiate_object_(Asset, qword_8D34FB0);
    if ( v9 != 0 )
    {
      v8 = v9;
      UnityEngine_GameObject__SetActive(v9, a3 & 1, 0);
      name = UnityEngine_Object__get_name(Asset, 0);
      v11 = UnityEngine_Object__set_name(v8, name, 0);
      GameFramework_Resources_ResourcesInfo____E_g_(v11, v8);
      return v8;
    }
LABEL_17:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return v8;
}
