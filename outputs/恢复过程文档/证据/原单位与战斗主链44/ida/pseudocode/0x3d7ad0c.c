__int64 __fastcall GameModule_RoleBehaviour__SyncPathfindingPosition(__int64 a1, char a2)
{
  __int64 result; // x0
  __int64 v5; // x21
  __int64 Component_object; // x21
  __int64 v7; // x0
  __int64 v8; // x21
  __int64 transform; // x0
  long double position; // q0

  if ( (byte_8FFD473 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25FB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD473 = 1;
  }
  if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40D8);
  result = UnityEngine_Application__get_isPlaying(0);
  if ( (result & 1) != 0 && *(_BYTE *)(a1 + 636) == 0 )
  {
    if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    {
      sub_3D847E4(a1);
      return GameModule_WebGLNavigationManager__TryRegisterRole(a1, 0);
    }
    v5 = *(_QWORD *)(a1 + 128);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v5, 0, 0) & 1) != 0 )
    {
      Component_object = UnityEngine_Component__GetComponent_object_(a1, qword_8D25FB0);
      *(_QWORD *)(a1 + 128) = Component_object;
    }
    else
    {
      Component_object = *(_QWORD *)(a1 + 128);
    }
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Equality(Component_object, 0, 0);
    if ( (result & 1) == 0 )
    {
      v7 = *(_QWORD *)(a1 + 128);
      if ( v7 == 0 )
        goto LABEL_23;
      result = UnityEngine_Behaviour__get_enabled(v7, 0);
      if ( (result & 1) != 0 )
      {
        v8 = *(_QWORD *)(a1 + 128);
        transform = UnityEngine_Component__get_transform(a1, 0);
        if ( transform != 0 )
        {
          position = UnityEngine_Transform__get_position(transform, 0);
          if ( v8 != 0 )
          {
            Pathfinding_FollowerEntity__Teleport(v8, a2 & 1, 0, position);
            return sub_3D847E4(a1);
          }
        }
LABEL_23:
        il2cpp_codegen_raise_null_reference_exception();
      }
    }
  }
  return result;
}
