__int64 UpdateManager__get_Instance()
{
  __int64 v0; // x19
  __int64 v1; // x19
  __int64 v2; // x20

  if ( (byte_900891D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D6D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DCC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76D80);
    byte_900891D = 1;
  }
  v0 = **((_QWORD **)off_8CEF040 + 23);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v0, 0, 0) & 1) != 0 )
  {
    v1 = UnityEngine_GameObject__Find(qword_8D76D80, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v1, 0, 0) & 1) != 0 )
    {
      v1 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
      sub_82EC8E8(v1, 0);
      if ( v1 == 0 )
        goto LABEL_20;
      UnityEngine_Object__set_name(v1, qword_8D76D80, 0);
    }
    if ( v1 != 0 )
    {
      **((_QWORD **)off_8CEF040 + 23) = UnityEngine_GameObject__GetComponent_object_(v1, qword_8D2DCC8);
      v2 = **((_QWORD **)off_8CEF040 + 23);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(v2, 0, 0) & 1) != 0 )
        **((_QWORD **)off_8CEF040 + 23) = UnityEngine_GameObject__AddComponent_object_(v1, qword_8D2D6D0);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      UnityEngine_Object__DontDestroyOnLoad(v1, 0);
      return **((_QWORD **)off_8CEF040 + 23);
    }
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return **((_QWORD **)off_8CEF040 + 23);
}
