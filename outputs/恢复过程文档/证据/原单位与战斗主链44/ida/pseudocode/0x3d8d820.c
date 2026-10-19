__int64 __fastcall GameModule_RoleBehaviour__AddEffHead(__int64 a1, __int64 a2, __int64 *a3)
{
  __int64 v6; // x22
  __int64 gameObject; // x22
  __int64 result; // x0
  __int64 v9; // x22
  __int64 v10; // x22
  __int64 transform; // x0
  long double position; // q0
  float v13; // s8
  float v14; // s1
  float v15; // s9
  float v16; // s2
  float v17; // s10
  __int64 v18; // x0
  __int64 v19; // x0
  long double v20; // q0
  long double v21; // q2
  __int64 v22; // x20
  __int64 v23; // x0

  if ( (byte_8FFD4A9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34FB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD4A9 = 1;
  }
  v6 = *a3;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
  {
    if ( *a3 == 0 )
      goto LABEL_26;
    gameObject = UnityEngine_GameObject__get_gameObject(*a3, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Inequality(gameObject, 0, 0);
    if ( (result & 1) != 0 )
      return result;
  }
  v9 = *a3;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v9, 0, 0) & 1) != 0 )
  {
    if ( *a3 == 0 )
      goto LABEL_26;
    v10 = UnityEngine_GameObject__get_gameObject(*a3, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v10, 0, 0) & 1) != 0 )
      *a3 = 0;
  }
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform != 0 )
  {
    position = UnityEngine_Transform__get_position(transform, 0);
    v13 = *(float *)&position;
    v15 = v14;
    v17 = v16;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v18 = UnityEngine_Object__Instantiate_object_(a2, qword_8D34FB0);
    *a3 = v18;
    if ( v18 != 0 )
    {
      v19 = UnityEngine_GameObject__get_transform(v18, 0);
      if ( v19 != 0 )
      {
        *(float *)&v20 = v13 + 0.0;
        *(float *)&v21 = v17 + 0.0;
        UnityEngine_Transform__set_position(v19, 0, v20, v15 + 1.5, v21);
        if ( *a3 != 0 )
        {
          v22 = UnityEngine_GameObject__get_transform(*a3, 0);
          v23 = UnityEngine_Component__get_transform(a1, 0);
          if ( v22 != 0 )
            return UnityEngine_Transform__SetParent(v22, v23, 0);
        }
      }
    }
  }
LABEL_26:
  il2cpp_codegen_raise_null_reference_exception();
}
