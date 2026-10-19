void __fastcall GameModule_RoleBehaviour__SetAiCanMove(__int64 a1, char a2)
{
  int v4; // w21
  __int64 v5; // x21
  __int64 v6; // x0

  v4 = a2 & 1;
  if ( (byte_8FFD472 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD472 = 1;
  }
  if ( *(unsigned __int8 *)(a1 + 440) != v4 )
  {
    *(_BYTE *)(a1 + 440) = v4;
    if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    {
      if ( (a2 & 1) != 0 )
        GameModule_WebGLNavigationManager__TryRegisterRole(a1, 0);
    }
    else
    {
      v5 = *(_QWORD *)(a1 + 128);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v5, 0, 0) & 1) != 0 )
      {
        v6 = *(_QWORD *)(a1 + 128);
        if ( v6 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        Pathfinding_FollowerEntity__set_canMove(v6, a2 & 1, 0);
      }
    }
  }
}
