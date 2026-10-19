__int64 __fastcall GameModule_BattleGameSceneManager__RemovePlayerRole(__int64 a1, __int64 a2, int a3)
{
  __int64 v6; // x0
  __int64 result; // x0
  __int64 Component_object; // x0
  __int64 v9; // x21
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x1
  __int64 v13; // x2
  __int64 Instance; // x0
  int v15; // w8
  void *v16; // x20
  void *v17; // x0
  int v18; // [xsp+Ch] [xbp-24h] BYREF

  if ( (byte_8FFD7C5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DBF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C1A0);
    byte_8FFD7C5 = 1;
  }
  v6 = *(_QWORD *)(a1 + 176);
  if ( v6 == 0 )
    goto LABEL_23;
  result = System_Collections_Generic_List_object___Contains(v6, a2, qword_8D0ACB0);
  if ( (result & 1) == 0 )
    return result;
  if ( a2 == 0 )
    goto LABEL_23;
  Component_object = UnityEngine_GameObject__GetComponent_object_(a2, qword_8D2DBF0);
  if ( *(_QWORD *)(a1 + 176) == 0 )
    goto LABEL_23;
  v9 = Component_object;
  System_Collections_Generic_List_object___Remove(*(_QWORD *)(a1 + 176), a2, qword_8D0ACC8);
  v10 = *(_QWORD *)(a1 + 200);
  if ( v10 == 0 )
    goto LABEL_23;
  System_Collections_Generic_List_object___Remove(v10, v9, qword_8D0DDA8);
  v11 = *(_QWORD *)(a1 + 208);
  if ( v11 == 0 )
    goto LABEL_23;
  System_Collections_Generic_List_object___Remove(v11, v9, qword_8D0DDA8);
  GameModule_WebGLNavigationManager__TryUnregisterRole(v9, 0);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v12, v13);
  if ( Instance == 0 )
    goto LABEL_23;
  result = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0);
  if ( (result & 1) == 0 )
    goto LABEL_18;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(v9, 0, 0);
  if ( (result & 1) != 0 )
  {
    if ( v9 == 0 )
      goto LABEL_23;
    v15 = *(unsigned __int8 *)(v9 + 60);
  }
  else
  {
LABEL_18:
    v15 = 0;
  }
  if ( (a3 & v15 & 1) == 0 )
    return result;
  *(_DWORD *)(a1 + 512) = (*(_DWORD *)(a1 + 512) - 1) & ~((*(_DWORD *)(a1 + 512) - 1) >> 31);
  v16 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v18 = *(_DWORD *)(a1 + 512);
  v17 = (void *)((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v18);
  if ( v16 == nullptr )
LABEL_23:
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__TriggerEvent(v16, (void *)qword_8D6C1A0, v17, nullptr);
  return GameModule_BattleGameSceneManager__TrySpawnFromWaitingBarracks(a1, 0);
}
