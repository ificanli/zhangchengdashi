__int64 __fastcall GameModule_RoleBehaviour__OnRecycle(int32x2_t *a1, __int64 a2, __int64 a3)
{
  long double v3; // q8
  __int64 Instance; // x0
  unsigned __int64 v6; // x20
  unsigned __int64 v7; // x0
  void *v8; // x0
  unsigned __int64 v9; // x20
  __int64 v10; // x8
  __int64 v11; // x9
  _DWORD *v12; // x10
  __int64 v13; // x0
  __int64 transform; // x0
  __int64 v15; // x0
  void *v16; // x20
  void *v17; // x21
  __int64 v18; // x1
  unsigned __int64 v19; // x20
  unsigned __int64 v20; // x8
  int v21; // w2
  int v22; // w9
  __int64 v23; // x1
  __int64 v24; // x2
  unsigned __int64 v25; // x0
  int v26; // w20
  __int64 Item; // x0
  int v28; // w8
  unsigned __int64 v29; // x0
  int32x2_t *v30; // x26
  int v31; // w20
  __int64 v32; // x0
  int v33; // w8
  __int64 v34; // x0
  unsigned __int64 v35; // x20
  __int64 v36; // x8
  __int64 v37; // x9
  int *v38; // x10
  __int64 v39; // x0
  unsigned __int64 v40; // x20
  __int64 result; // x0
  unsigned __int64 v42; // x20

  if ( (byte_8FFD4A4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8430);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0EBD0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DD90);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0EBD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0EBE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D624D8);
    byte_8FFD4A4 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    goto LABEL_65;
  if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(Instance, 0) & 1) != 0 )
    GameModule_RoleBehaviour__ApplyOccupancyPenalty((__int64)a1, 0);
  GameModule_RoleBehaviour__SetPathfindingEnabled(a1, 0);
  v6 = a1[80].n64_u64[0];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
  {
    v7 = a1[80].n64_u64[0];
    if ( v7 == 0 )
      goto LABEL_65;
    GameModule_HexBehaviour__RemoveRole(v7, a1[7].n64_u32[0]);
    a1[80].n64_u64[0] = 0;
  }
  v8 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12400);
  if ( v8 == nullptr )
    goto LABEL_65;
  GameModule_RoleShadowManager__Unbind(v8, a1, 0);
  v9 = a1[40].n64_u64[0];
  if ( v9 != 0 )
  {
    v10 = *(_QWORD *)v9;
    v11 = *(unsigned __int16 *)(*(_QWORD *)v9 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v9 + 302LL) != 0 )
    {
      v12 = (_DWORD *)(*(_QWORD *)(v10 + 176) + 8LL);
      while ( *((_QWORD *)v12 - 1) != qword_8CE8430 )
      {
        --v11;
        v12 += 4;
        if ( v11 == 0 )
          goto LABEL_19;
      }
      v13 = v10 + 16LL * (*v12 + 6) + 312;
    }
    else
    {
LABEL_19:
      v13 = ((__int64 (__fastcall *)(unsigned __int64, __int64, __int64))unk_3C504A4)(
              a1[40].n64_u64[0],
              qword_8CE8430,
              6);
    }
    (*(void (__fastcall **)(unsigned __int64, _QWORD))v13)(v9, *(_QWORD *)(v13 + 8));
  }
  transform = UnityEngine_Component__get_transform(a1, 0);
  DG_Tweening_ShortcutExtensions__DOKill(transform, 0, 0);
  v15 = UnityEngine_Component__get_transform(a1, 0);
  if ( v15 == 0 )
    goto LABEL_65;
  UnityEngine_Transform__set_localScale(v15, 0, a1[23].n64_f32[0], a1[23].n64_f32[0], a1[23].n64_f32[0]);
  a1[6].n64_u8[4] = 0;
  a1[18].n64_u32[1] = 0;
  a1[6].n64_u32[0] = 0;
  a1[37].n64_u32[0] = 0;
  a1[39].n64_u64[0] = 0;
  a1[47].n64_u8[0] = 0;
  a1[19].n64_u32[1] = 0;
  a1[20].n64_u32[0] = 0;
  a1[69].n64_u8[2] = 0;
  GameModule_RoleBehaviour__SetAiCanMove((__int64)a1, 0);
  v16 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v17 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v17, a1, *(_QWORD *)(a1->n64_u64[0] + 768), 0);
  if ( v16 == nullptr )
    goto LABEL_65;
  EventModule_EventManager__StopListening(v16, (void *)qword_8D624D8, v17, nullptr);
  a1[69].n64_u16[0] = 0;
  a1[79].n64_u8[4] = 1;
  GameModule_RoleBehaviour__RemoveHPUI((__int64)a1, v18);
  GameModule_RoleBehaviour__ClearDizzyState(a1);
  GameModule_RoleBehaviour__ClearFreezeState(a1);
  a1[81].n64_u8[0] = 0;
  v19 = a1[82].n64_u64[0];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  UnityEngine_Object__Destroy(v19, 0);
  UnityEngine_Object__Destroy(a1[84].n64_u64[0], 0);
  UnityEngine_Object__Destroy(a1[85].n64_u64[0], 0);
  UnityEngine_Object__Destroy(a1[89].n64_u64[0], 0);
  v20 = a1[48].n64_u64[0];
  a1[89].n64_u64[0] = 0;
  a1[86].n64_u8[0] = 0;
  if ( v20 == 0 )
    goto LABEL_65;
  v21 = *(_DWORD *)(v20 + 24);
  v22 = *(_DWORD *)(v20 + 28) + 1;
  *(_DWORD *)(v20 + 24) = 0;
  *(_DWORD *)(v20 + 28) = v22;
  if ( v21 >= 1 )
    System_Array__Clear(*(_QWORD *)(v20 + 16), 0);
  DG_Tweening_TweenExtensions__Kill(a1[87].n64_u64[0], 0, 0);
  v25 = a1[44].n64_u64[0];
  a1[49].n64_u32[0] = 0;
  a1[43].n64_u64[0] = 0;
  if ( v25 != 0 )
  {
    v26 = 0;
    while ( 1 )
    {
      v24 = *(unsigned int *)(v25 + 24);
      if ( v26 >= (int)v24 )
        break;
      Item = System_Collections_Generic_List_object___get_Item(v25, (unsigned int)v26, qword_8D0EBE0);
      if ( Item != 0 )
      {
        (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 424LL))(Item, *(_QWORD *)(*(_QWORD *)Item + 432LL));
        v25 = a1[44].n64_u64[0];
        ++v26;
        if ( v25 != 0 )
          continue;
      }
      goto LABEL_65;
    }
    v28 = *(_DWORD *)(v25 + 28) + 1;
    *(_DWORD *)(v25 + 24) = 0;
    *(_DWORD *)(v25 + 28) = v28;
    if ( (int)v24 >= 1 )
      System_Array__Clear(*(_QWORD *)(v25 + 16), 0);
  }
  v29 = a1[45].n64_u64[0];
  v30 = a1 + 45;
  a1[44].n64_u64[0] = 0;
  if ( v29 != 0 )
  {
    v31 = 0;
    while ( 1 )
    {
      v24 = *(unsigned int *)(v29 + 24);
      if ( v31 >= (int)v24 )
        break;
      v32 = System_Collections_Generic_List_object___get_Item(v29, (unsigned int)v31, qword_8D0EBE0);
      if ( v32 != 0 )
      {
        (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v32 + 424LL))(v32, *(_QWORD *)(*(_QWORD *)v32 + 432LL));
        v29 = v30->n64_u64[0];
        ++v31;
        if ( v30->n64_u64[0] != 0 )
          continue;
      }
      goto LABEL_65;
    }
    v33 = *(_DWORD *)(v29 + 28) + 1;
    *(_DWORD *)(v29 + 24) = 0;
    *(_DWORD *)(v29 + 28) = v33;
    if ( (int)v24 >= 1 )
      System_Array__Clear(*(_QWORD *)(v29 + 16), 0);
  }
  a1[49].n64_u8[4] = 0;
  a1[50].n64_u32[0] = 0;
  v30->n64_u64[0] = 0;
  a1[46].n64_u64[0] = 0;
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v34 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v23, v24);
  if ( v34 == 0 )
LABEL_65:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(v34, 0) & 1) != 0 )
  {
    v35 = a1[40].n64_u64[0];
    if ( v35 != 0 )
    {
      LODWORD(v3) = a1[41].n64_u32[1];
      if ( *(float *)&v3 > 0.0 )
      {
        v36 = *(_QWORD *)v35;
        v37 = *(unsigned __int16 *)(*(_QWORD *)v35 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v35 + 302LL) != 0 )
        {
          v38 = (int *)(*(_QWORD *)(v36 + 176) + 8LL);
          while ( *((_QWORD *)v38 - 1) != qword_8CE8430 )
          {
            --v37;
            v38 += 4;
            if ( v37 == 0 )
              goto LABEL_55;
          }
          v39 = v36 + 16LL * *v38 + 312;
        }
        else
        {
LABEL_55:
          v39 = ((__int64 (__fastcall *)(unsigned __int64, __int64, _QWORD))unk_3C504A4)(
                  a1[40].n64_u64[0],
                  qword_8CE8430,
                  0);
        }
        (*(void (__fastcall **)(unsigned __int64, __int64, _QWORD, long double))v39)(v35, 3, *(_QWORD *)(v39 + 8), v3);
        a1[41].n64_u32[1] = 0;
      }
    }
  }
  v40 = a1[17].n64_u64[0];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(v40, 0, 0);
  if ( (result & 1) != 0 )
  {
    v42 = a1[17].n64_u64[0];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__Destroy(v42, 0);
    a1[17].n64_u64[0] = 0;
  }
  return result;
}
