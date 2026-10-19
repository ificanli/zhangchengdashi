__int64 __fastcall GameModule_BattleGameSceneManager__AddPlayerRole(__int64 a1, __int64 a2, __int64 a3, char a4)
{
  char v5; // w22
  __int64 Instance; // x0
  __int64 v9; // x0
  __int64 v10; // x8
  _QWORD *v11; // x9
  __int64 v12; // x10
  __int64 Component_object; // x0
  __int64 v14; // x8
  __int64 v15; // x9
  _QWORD *v16; // x10
  __int64 v17; // x11
  __int64 v18; // x23
  __int64 v19; // x0
  __int64 v20; // x8
  _QWORD *v21; // x9
  __int64 v22; // x10
  __int64 result; // x0
  int v24; // w8
  void *v25; // x22
  __int64 v26; // x1
  __int64 v27; // x2
  void *v28; // x0
  __int64 v29; // x0
  int v30; // w8
  bool v31; // vf
  int v32; // w8
  int v33; // w8
  int v34; // w8
  void *v35; // x21
  void *v36; // x0
  void *v37; // x0
  __int64 transform; // x0
  __int64 v39; // x8
  __int64 v40; // x20
  __int64 v41; // x0
  void *v42; // x20
  void *v43; // x0
  __int64 v44; // x19
  __int64 v45; // x0
  __int64 v46; // x19
  int v47; // [xsp+4h] [xbp-5Ch] BYREF
  int v48; // [xsp+8h] [xbp-58h] BYREF
  int v49; // [xsp+Ch] [xbp-54h] BYREF

  v5 = a3;
  if ( (byte_8FFD7C3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DBF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0AC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0DD80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C1A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86E30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D624E8);
    byte_8FFD7C3 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    goto LABEL_56;
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) != 0
    && (a4 & 1) != 0
    && *(int *)(a1 + 512) >= 100 )
  {
    v49 = *(_DWORD *)(a1 + 512);
    v44 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v49);
    v48 = 100;
    v45 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v48);
    v46 = sub_750AA4C(qword_8D86E30, v44, v45, 0);
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    return UnityEngine_Debug__LogWarning(v46, 0);
  }
  else
  {
    v9 = *(_QWORD *)(a1 + 176);
    if ( v9 == 0 )
      goto LABEL_56;
    v10 = *(_QWORD *)(v9 + 16);
    v11 = off_8D0AC98;
    ++*(_DWORD *)(v9 + 28);
    if ( v10 == 0 )
      goto LABEL_56;
    v12 = *(int *)(v9 + 24);
    if ( (unsigned int)v12 >= *(_DWORD *)(v10 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v9, a2, *(_QWORD *)(*(_QWORD *)(v11[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v9 + 24) = v12 + 1;
      *(_QWORD *)(v10 + 8 * v12 + 32) = a2;
    }
    if ( a2 == 0 )
      goto LABEL_56;
    Component_object = UnityEngine_GameObject__GetComponent_object_(a2, qword_8D2DBF0);
    v14 = *(_QWORD *)(a1 + 200);
    if ( v14 == 0 )
      goto LABEL_56;
    v15 = *(_QWORD *)(v14 + 16);
    v16 = off_8D0DD80;
    ++*(_DWORD *)(v14 + 28);
    if ( v15 == 0 )
      goto LABEL_56;
    v17 = *(int *)(v14 + 24);
    v18 = Component_object;
    if ( (unsigned int)v17 >= *(_DWORD *)(v15 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v14,
        Component_object,
        *(_QWORD *)(*(_QWORD *)(v16[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v14 + 24) = v17 + 1;
      *(_QWORD *)(v15 + 8 * v17 + 32) = Component_object;
    }
    v19 = *(_QWORD *)(a1 + 208);
    if ( v19 == 0 )
      goto LABEL_56;
    v20 = *(_QWORD *)(v19 + 16);
    v21 = off_8D0DD80;
    ++*(_DWORD *)(v19 + 28);
    if ( v20 == 0 )
      goto LABEL_56;
    v22 = *(int *)(v19 + 24);
    if ( (unsigned int)v22 >= *(_DWORD *)(v20 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v19, v18, *(_QWORD *)(*(_QWORD *)(v21[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v19 + 24) = v22 + 1;
      *(_QWORD *)(v20 + 8 * v22 + 32) = v18;
    }
    result = GameModule_WebGLNavigationManager__TryRegisterRole(v18, 0);
    if ( (v5 & 1) == 0 )
    {
      v24 = *(_DWORD *)(a1 + 32) + 1;
      *(_DWORD *)(a1 + 32) = v24;
      if ( v18 == 0 )
        goto LABEL_56;
      *(_DWORD *)(v18 + 56) = v24;
      v25 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12400);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v25, 0, 0) & 1) != 0 )
      {
        v28 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12400);
        if ( v28 == nullptr )
          goto LABEL_56;
        GameModule_RoleShadowManager__Bind(v28, v18, 0);
      }
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v29 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v26, v27);
      if ( v29 == 0 )
LABEL_56:
        il2cpp_codegen_raise_null_reference_exception();
      if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(v29, 0) & 1) != 0 && (a4 & 1) != 0 )
      {
        v30 = *(_DWORD *)(a1 + 520);
        v31 = __OFSUB__(v30, 1);
        v32 = v30 - 1;
        if ( v32 < 0 == v31 )
          *(_DWORD *)(a1 + 520) = v32;
        v33 = *(_DWORD *)(a1 + 512);
        if ( v33 + 1 < 100 )
          v34 = v33 + 1;
        else
          v34 = 100;
        *(_DWORD *)(a1 + 512) = v34;
        v35 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
        v47 = *(_DWORD *)(a1 + 512);
        v36 = (void *)((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v47);
        if ( v35 == nullptr )
          goto LABEL_56;
        EventModule_EventManager__TriggerEvent(v35, (void *)qword_8D6C1A0, v36, nullptr);
        *(_BYTE *)(v18 + 60) = 1;
      }
      v37 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
      if ( v37 == nullptr )
        goto LABEL_56;
      EventModule_EventManager__TriggerEvent(v37, (void *)qword_8D624E8, (void *)v18, nullptr);
      transform = UnityEngine_GameObject__get_transform(a2, 0);
      v39 = *(_QWORD *)(a1 + 296);
      if ( v39 == 0 )
        goto LABEL_56;
      v40 = transform;
      v41 = UnityEngine_GameObject__get_transform(v39, 0);
      if ( v40 == 0 )
        goto LABEL_56;
      sub_82F9798(v40, v41, 0, 0);
      v42 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      result = UnityEngine_Object__op_Inequality(v42, 0, 0);
      if ( (result & 1) != 0 )
      {
        v43 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
        if ( v43 != nullptr )
          return GameModule_BattleGameManager__TryApplyPauseToNewRole(v43, a2);
        goto LABEL_56;
      }
    }
  }
  return result;
}
