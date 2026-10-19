__int64 __fastcall GameModule_RoleBehaviour__GetWallBetweenAdjacentHexes(__int64 a1, __int64 *a2, __int64 *a3)
{
  __int64 v5; // x21
  __int64 *v6; // x8
  __int64 *v7; // x9
  __int64 v8; // x21
  __int64 v9; // x21
  __int64 v10; // x21
  __int64 v11; // x21
  __int64 v12; // x21
  __int64 v13; // x21
  __int64 v14; // x20
  __int64 Component_object; // x19
  __int64 gameObject; // x0
  __int64 v18; // x0

  if ( (byte_8FFD491 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DC48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD491 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
    return 0;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a3, 0, 0) & 1) != 0 )
    return 0;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, a3, 0) & 1) != 0 )
    return 0;
  if ( a2 == nullptr )
    goto LABEL_72;
  v5 = a2[13];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a3, v5, 0) & 1) != 0 )
  {
    if ( a3 == nullptr )
      goto LABEL_72;
    v6 = a2 + 37;
    v7 = a3 + 41;
  }
  else
  {
    v8 = a2[15];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(a3, v8, 0) & 1) != 0 )
    {
      if ( a3 == nullptr )
        goto LABEL_72;
      v6 = a2 + 39;
      v7 = a3 + 42;
    }
    else
    {
      v9 = a2[14];
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(a3, v9, 0) & 1) != 0 )
      {
        if ( a3 == nullptr )
          goto LABEL_72;
        v6 = a2 + 38;
        v7 = a3 + 40;
      }
      else
      {
        v10 = a2[17];
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Equality(a3, v10, 0) & 1) != 0 )
        {
          if ( a3 == nullptr )
            goto LABEL_72;
          v6 = a2 + 40;
          v7 = a3 + 38;
        }
        else
        {
          v11 = a2[16];
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Equality(a3, v11, 0) & 1) != 0 )
          {
            if ( a3 == nullptr )
              goto LABEL_72;
            v6 = a2 + 42;
            v7 = a3 + 39;
          }
          else
          {
            v12 = a2[18];
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Equality(a3, v12, 0) & 1) == 0 )
              return 0;
            if ( a3 == nullptr )
              goto LABEL_72;
            v6 = a2 + 41;
            v7 = a3 + 37;
          }
        }
      }
    }
  }
  v13 = *v6;
  v14 = *v7;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  Component_object = 0;
  if ( (UnityEngine_Object__op_Inequality(v13, 0, 0) & 1) != 0 )
  {
    if ( v13 == 0 )
      goto LABEL_72;
    Component_object = 0;
    if ( (UnityEngine_GameObject__get_activeSelf(v13, 0) & 1) != 0 )
      Component_object = UnityEngine_GameObject__GetComponent_object_(v13, qword_8D2DC48);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(Component_object, 0, 0) & 1) != 0 )
    goto LABEL_58;
  if ( Component_object == 0 )
    goto LABEL_72;
  if ( *(_BYTE *)(Component_object + 33) != 0 )
    goto LABEL_58;
  gameObject = UnityEngine_Component__get_gameObject(Component_object, 0);
  if ( gameObject == 0 )
    goto LABEL_72;
  if ( (UnityEngine_GameObject__get_activeSelf(gameObject, 0) & 1) == 0 )
  {
LABEL_58:
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v14, 0, 0) & 1) != 0 )
    {
      if ( v14 == 0 )
        goto LABEL_72;
      if ( (UnityEngine_GameObject__get_activeSelf(v14, 0) & 1) != 0 )
        Component_object = UnityEngine_GameObject__GetComponent_object_(v14, qword_8D2DC48);
    }
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(Component_object, 0, 0) & 1) != 0 )
    return 0;
  if ( Component_object == 0 )
    goto LABEL_72;
  if ( *(_BYTE *)(Component_object + 33) != 0 )
    return 0;
  v18 = UnityEngine_Component__get_gameObject(Component_object, 0);
  if ( v18 == 0 )
LABEL_72:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (UnityEngine_GameObject__get_activeSelf(v18, 0) & 1) != 0 )
    return Component_object;
  else
    return 0;
}
