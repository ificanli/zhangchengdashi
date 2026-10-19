__int64 __fastcall GameModule_RoleBehaviour__FindTarget(__int64 a1, long double a2)
{
  _QWORD *v4; // x0
  void *Instance; // x20
  __int64 transform; // x1
  __int64 v7; // x20
  __int64 v8; // x20
  __int64 v9; // x0
  long double position; // q0
  float v11; // s1
  float v12; // s2
  float v13; // s12
  float v14; // s13
  __int64 v15; // x0
  long double v16; // q0
  float v17; // s1
  float v18; // s2
  __int64 v19; // x21
  __int64 v20; // x0
  long double v21; // q0
  float v22; // s1
  float v23; // s2
  int v24; // w8
  float v25; // s13
  float v26; // s14
  float v27; // s15
  float v28; // s8
  unsigned int v29; // w22
  float v30; // s12
  long double Item; // q0
  float v32; // s9
  float v33; // s1
  float v34; // s10
  float v35; // s2
  float v36; // s11
  long double v37; // q0
  float v38; // s1
  float v39; // s2
  __int64 v40; // x0
  long double v41; // q0
  float v42; // s1
  float v43; // s2
  __int64 v44; // x0
  float v45; // s8
  float v46; // s14
  float v47; // s15
  __int64 v48; // x0
  float v49; // s9
  float v50; // s1
  float v51; // s10
  float v52; // s2
  float v53; // s11
  __int64 v54; // x20
  long double v56; // q0
  float v57; // s1
  float v58; // s2
  __int64 v59; // x0
  float v60; // s8
  float v61; // s14
  float v62; // s15
  __int64 v63; // x0
  float v64; // s9
  float v65; // s1
  float v66; // s10
  float v67; // s2
  float v68; // s11
  float v69; // s0
  float v70; // [xsp+Ch] [xbp-A4h]
  float v71; // [xsp+10h] [xbp-A0h]
  float v72; // [xsp+14h] [xbp-9Ch]
  float v73; // [xsp+18h] [xbp-98h]
  float v74; // [xsp+1Ch] [xbp-94h]
  __int64 v75; // [xsp+68h] [xbp-48h] BYREF

  if ( (byte_8FFD458 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F830);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD458 = 1;
  }
  v75 = 0;
  if ( *(_BYTE *)(a1 + 52) != 0 )
  {
    v4 = off_8CEEDF8;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    {
LABEL_5:
      il2cpp_codegen_runtime_class_init(v4);
LABEL_53:
      v4 = off_8CEEDF8;
    }
  }
  else if ( (((__int64 (__fastcall *)(__int64, long double))GameModule_RoleBehaviour__ShouldSkipFindTarget)(a1, a2) & 1) != 0 )
  {
    v4 = off_8CEEDF8;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      goto LABEL_5;
  }
  else
  {
    GameModule_EntityBase__FindTarget(a1, 0, a2);
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_BattleGameSceneManager__TryGetNearestRoleTarget((__int64)Instance, transform, *(_BYTE *)(a1 + 32), &v75);
    if ( *(_DWORD *)(a1 + 72) != 0 )
      goto LABEL_45;
    v7 = *(_QWORD *)(a1 + 80);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) == 0 )
      goto LABEL_45;
    v8 = v75;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v8, 0, 0) & 1) == 0 )
      goto LABEL_45;
    v9 = UnityEngine_Component__get_transform(a1, 0);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(v9, 0);
    v74 = v12;
    if ( v75 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v13 = *(float *)&position;
    v14 = v11;
    v15 = UnityEngine_Component__get_transform(v75, 0);
    if ( v15 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v16 = UnityEngine_Transform__get_position(v15, 0);
    v72 = v17;
    v73 = *(float *)&v16;
    v71 = v18;
    if ( byte_8FFD020 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD020 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    v19 = *(_QWORD *)(a1 + 536);
    v70 = v14;
    if ( (GameModule_RoleBehaviour__TryGetAstarRemainingPath(a1, v19) & 1) == 0 )
      goto LABEL_36;
    if ( v19 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(int *)(v19 + 24) >= 1 )
    {
      v20 = UnityEngine_Component__get_transform(a1, 0);
      if ( v20 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v21 = UnityEngine_Transform__get_position(v20, 0);
      v24 = *(_DWORD *)(v19 + 24);
      v25 = v13;
      if ( v24 < 1 )
      {
        v30 = 0.0;
      }
      else
      {
        v26 = *(float *)&v21;
        v27 = v22;
        v28 = v23;
        v29 = 0;
        v30 = 0.0;
        do
        {
          Item = System_Collections_Generic_List_Vector3___get_Item(v19, v29, qword_8D0F838);
          v32 = *(float *)&Item;
          v34 = v33;
          v36 = v35;
          if ( byte_8FFD020 == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
            byte_8FFD020 = 1;
          }
          if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEA738);
          v37 = System_Collections_Generic_List_Vector3___get_Item(v19, v29, qword_8D0F838);
          v24 = *(_DWORD *)(v19 + 24);
          ++v29;
          v30 = v30
              + sqrtf(
                  (float)((float)(v28 - v36) * (float)(v28 - v36))
                + (float)((float)((float)(v26 - v32) * (float)(v26 - v32))
                        + (float)((float)(v27 - v34) * (float)(v27 - v34))));
          v26 = *(float *)&v37;
          v27 = v38;
          v28 = v39;
        }
        while ( (int)v29 < v24 );
      }
      v56 = System_Collections_Generic_List_Vector3___get_Item(v19, (unsigned int)(v24 - 1), qword_8D0F838);
      v59 = *(_QWORD *)(a1 + 80);
      if ( v59 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v60 = *(float *)&v56;
      v61 = v57;
      v62 = v58;
      v63 = UnityEngine_Component__get_transform(v59, 0);
      if ( v63 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      LODWORD(v64) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v63, 0));
      v66 = v65;
      v68 = v67;
      if ( byte_8FFD020 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD020 = 1;
      }
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v69 = sqrtf(
              (float)((float)(v62 - v68) * (float)(v62 - v68))
            + (float)((float)((float)(v60 - v64) * (float)(v60 - v64)) + (float)((float)(v61 - v66) * (float)(v61 - v66))));
      if ( v69 > 0.5 )
        v30 = v30 + v69;
    }
    else
    {
LABEL_36:
      v40 = UnityEngine_Component__get_transform(a1, 0);
      if ( v40 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v41 = UnityEngine_Transform__get_position(v40, 0);
      v44 = *(_QWORD *)(a1 + 80);
      if ( v44 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v45 = *(float *)&v41;
      v46 = v42;
      v47 = v43;
      v48 = UnityEngine_Component__get_transform(v44, 0);
      if ( v48 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      LODWORD(v49) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v48, 0));
      v51 = v50;
      v53 = v52;
      if ( byte_8FFD020 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD020 = 1;
      }
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v25 = v13;
      v30 = sqrtf(
              (float)((float)(v47 - v53) * (float)(v47 - v53))
            + (float)((float)((float)(v45 - v49) * (float)(v45 - v49)) + (float)((float)(v46 - v51) * (float)(v46 - v51))));
    }
    if ( sqrtf(
           (float)((float)(v74 - v71) * (float)(v74 - v71))
         + (float)((float)((float)(v25 - v73) * (float)(v25 - v73)) + (float)((float)(v70 - v72) * (float)(v70 - v72)))) >= v30 )
    {
      v54 = 0;
      *(_QWORD *)(a1 + 88) = 0;
    }
    else
    {
LABEL_45:
      v54 = v75;
      *(_QWORD *)(a1 + 88) = v75;
    }
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v54, a1, 0) & 1) != 0 )
    {
      *(_QWORD *)(a1 + 88) = 0;
      *(_QWORD *)(a1 + 280) = 0;
      *(_DWORD *)(a1 + 288) = -1;
    }
    else
    {
      GameModule_RoleBehaviour__RecordCurrentRoleTargetDistance(a1);
    }
    *(_BYTE *)(a1 + 52) = 0;
    v4 = off_8CEEDF8;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      goto LABEL_53;
    }
  }
  return *(_QWORD *)(v4[23] + 16LL);
}
