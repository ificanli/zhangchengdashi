void *LocalizationModule_Runtime_CustomBundlesManager__get_Instance(const MethodInfo *method)
{
  __int64 v1; // x19
  __int64 v2; // x19
  __int64 v3; // x0
  __int64 gameObject; // x19

  if ( (byte_8FFEDBD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5F78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D2D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5D690);
    byte_8FFEDBD = 1;
  }
  v1 = **((_QWORD **)off_8CE5F78 + 23);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v1, 0, 0) & 1) != 0 )
  {
    v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
    UnityEngine_GameObject___ctor(v2, qword_8D5D690, 0);
    if ( v2 == 0
      || (**((_QWORD **)off_8CE5F78 + 23) = UnityEngine_GameObject__AddComponent_object_(v2, qword_8D2D2D8),
          (v3 = **((_QWORD **)off_8CE5F78 + 23)) == 0) )
    {
      il2cpp_codegen_raise_null_reference_exception();
    }
    gameObject = UnityEngine_Component__get_gameObject(v3, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__DontDestroyOnLoad(gameObject, 0);
  }
  return **((void ***)off_8CE5F78 + 23);
}
