__int64 __fastcall GameModule_RoleBehaviour__Awake(__int64 a1)
{
  __int64 transform; // x0
  __int64 ComponentsInChildren_object; // x0
  int v4; // w8
  __int64 v5; // x20
  unsigned int v6; // w21
  __int64 v7; // x0
  __int64 Component_object; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x0
  int v12; // s0
  __int64 v13; // x2
  _QWORD *Instance; // x0
  __int64 v15; // x8
  int v16; // w21
  _QWORD *v17; // x0
  __int64 v18; // x8
  __int64 v19; // x0
  int v20; // s0
  __int64 v21; // x2
  __int64 v23; // x0

  if ( (byte_8FFD453 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25FB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D26780);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD453 = 1;
  }
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform == 0 )
    goto LABEL_25;
  ComponentsInChildren_object = UnityEngine_Component__GetComponentsInChildren_object_(transform, qword_8D26780);
  if ( ComponentsInChildren_object == 0 )
    goto LABEL_25;
  v4 = *(_DWORD *)(ComponentsInChildren_object + 24);
  v5 = ComponentsInChildren_object;
  if ( v4 < 1 )
  {
LABEL_10:
    Component_object = UnityEngine_Component__GetComponent_object_(a1, qword_8D25FB0);
    *(_QWORD *)(a1 + 128) = Component_object;
    *(_BYTE *)(a1 + 464) = 1;
    v9 = Component_object;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v9, 0, 0) & 1) != 0 && *(float *)(a1 + 144) < 0.0 )
    {
      v10 = UnityEngine_Component__get_transform(a1, 0);
      if ( v10 == 0 )
        goto LABEL_25;
      UnityEngine_Transform__get_localScale(v10, 0);
      v11 = *(_QWORD *)(a1 + 128);
      if ( v11 == 0 )
        goto LABEL_25;
      *(float *)(a1 + 144) = Pathfinding_FollowerEntity__get_radius(v11, 0);
      GameModule_RoleBehaviour__GetScaledRadius(a1);
      *(_DWORD *)(a1 + 448) = v12;
    }
    if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
      GameModule_RoleBehaviour__SetPathfindingEnabled(a1, 1, v13);
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( Instance != nullptr )
    {
      v15 = Instance[25];
      if ( v15 != 0 )
      {
        v16 = *(_DWORD *)(v15 + 24);
        v17 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
        if ( v17 != nullptr )
        {
          v18 = v17[24];
          if ( v18 != 0 )
          {
            GameModule_RoleBehaviour__ApplyDefaultLocalAvoidancePolicy(a1, (unsigned int)(*(_DWORD *)(v18 + 24) + v16));
            *(_QWORD *)(a1 + 320) = GameModule_RoleBehaviour__ResolveAnimationBehaviour(a1);
            v19 = UnityEngine_Component__get_transform(a1, 0);
            if ( v19 != 0 )
            {
              UnityEngine_Transform__get_localScale(v19, 0);
              *(_DWORD *)(a1 + 184) = v20;
              *(_BYTE *)(a1 + 440) = 1;
              return GameModule_RoleBehaviour__SetAiCanMove(a1, 0, v21);
            }
          }
        }
      }
    }
LABEL_25:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v6 = 0;
  while ( v6 < v4 )
  {
    v7 = *(_QWORD *)(v5 + 8LL * (int)v6 + 32);
    if ( v7 == 0 )
      goto LABEL_25;
    UnityEngine_Renderer__set_shadowCastingMode(v7, 0, 0);
    v4 = *(_DWORD *)(v5 + 24);
    if ( (int)++v6 >= v4 )
      goto LABEL_10;
  }
  v23 = ((__int64 (*)(void))unk_3C3D4D4)();
  return GameModule_RoleBehaviour__GetScaledRadius(v23);
}
