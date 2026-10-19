bool __fastcall GameModule_BattleGameSceneManager__TryCollectRoleTargetsInRangeFromHexRing(
        GameModule_BattleGameSceneManager_o *a1,
        char a2,
        __int64 a3,
        _BYTE *a4,
        long double a5,
        long double a6,
        long double a7,
        float a8,
        float a9)
{
  bool RoleTargetHexSearchRing; // w8
  _BOOL8 result; // x0
  __int64 v20; // x22
  int32_t v21; // w11
  int v22; // w9
  int v23; // w8
  int v24; // w10
  int32_t v25; // w9
  int v26; // w27
  int32_t v27; // w29
  __int64 HexBehaviour; // x22
  int RoleCountByCamp; // w0
  int v30; // w23
  unsigned int i; // w24
  __int64 RoleByCamp; // x25
  __int64 transform; // x0
  long double position; // q0
  float v35; // s1
  float v36; // s2
  __int64 v37; // x8
  _QWORD *v38; // x9
  __int64 v39; // x10
  int v40; // [xsp+0h] [xbp-B0h]
  int32_t v41; // [xsp+4h] [xbp-ACh]
  int v42; // [xsp+8h] [xbp-A8h]
  int v43; // [xsp+Ch] [xbp-A4h]
  __int64 v44; // [xsp+10h] [xbp-A0h] BYREF
  __int64 v45; // [xsp+18h] [xbp-98h] BYREF
  int v46; // [xsp+28h] [xbp-88h]
  int32_t searchRing; // [xsp+2Ch] [xbp-84h] BYREF

  if ( (byte_8FFD79D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0DD80);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD79D = 1;
  }
  searchRing = 0;
  v45 = 0;
  *a4 = 0;
  RoleTargetHexSearchRing = GameModule_BattleGameSceneManager__TryGetRoleTargetHexSearchRing(
                              a1,
                              a8,
                              &searchRing,
                              (const MethodInfo *)a3);
  result = false;
  if ( RoleTargetHexSearchRing )
  {
    if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE81E8);
    if ( (HexManager__TryGetHexAt(&v45, 0, a5, a6, a7) & 1) == 0 )
      return false;
    v20 = v45;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v20, 0, 0) & 1) == 0 )
    {
      *a4 = 1;
      if ( v45 == 0 )
        goto LABEL_46;
      v21 = searchRing;
      v42 = -searchRing;
      if ( ((searchRing & 0x40000000) != 0) == __OFSUB__(searchRing, -searchRing) )
      {
        v40 = *(_DWORD *)(v45 + 32);
        v46 = *(_DWORD *)(v45 + 36);
        v22 = -searchRing;
        v41 = searchRing;
        do
        {
          v23 = v22 + v21;
          v24 = -(v22 + v21);
          v43 = v22;
          v25 = v21 - v22;
          if ( v24 >= v42 )
            v26 = -v23;
          else
            v26 = v42;
          if ( v21 >= v25 )
            v27 = v25;
          else
            v27 = v21;
          for ( ; v26 <= v27; ++v26 )
          {
            v44 = 0;
            HexManager_HexCoord___ctor(&v44, (unsigned int)(v43 + v40), (unsigned int)(v26 + v46), 0);
            if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE81E8);
            HexBehaviour = HexManager__GetHexBehaviour(v44, 0);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Equality(HexBehaviour, 0, 0) & 1) == 0 )
            {
              if ( HexBehaviour == 0 )
                goto LABEL_46;
              RoleCountByCamp = GameModule_HexBehaviour__GetRoleCountByCamp(HexBehaviour, a2 & 1, 0);
              if ( RoleCountByCamp >= 1 )
              {
                v30 = RoleCountByCamp;
                for ( i = 0; v30 != i; ++i )
                {
                  RoleByCamp = GameModule_HexBehaviour__GetRoleByCamp(HexBehaviour, a2 & 1, i, 0);
                  if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE4A38);
                  if ( GameModule_BattleGameSceneManager__IsRoleTargetValid(RoleByCamp) )
                  {
                    if ( RoleByCamp == 0 )
                      goto LABEL_46;
                    transform = UnityEngine_Component__get_transform(RoleByCamp, 0);
                    if ( transform == 0 )
                      goto LABEL_46;
                    position = UnityEngine_Transform__get_position(transform, 0);
                    if ( (float)((float)((float)(*(float *)&a7 - v36) * (float)(*(float *)&a7 - v36))
                               + (float)((float)((float)(*(float *)&a5 - *(float *)&position)
                                               * (float)(*(float *)&a5 - *(float *)&position))
                                       + (float)((float)(*(float *)&a6 - v35) * (float)(*(float *)&a6 - v35)))) <= a9 )
                    {
                      if ( a3 == 0 )
                        goto LABEL_46;
                      v37 = *(_QWORD *)(a3 + 16);
                      v38 = off_8D0DD80;
                      ++*(_DWORD *)(a3 + 28);
                      if ( v37 == 0 )
                        goto LABEL_46;
                      v39 = *(int *)(a3 + 24);
                      if ( (unsigned int)v39 >= *(_DWORD *)(v37 + 24) )
                      {
                        System_Collections_Generic_List_object___AddWithResize(
                          a3,
                          RoleByCamp,
                          *(_QWORD *)(*(_QWORD *)(v38[4] + 192LL) + 112LL));
                      }
                      else
                      {
                        *(_DWORD *)(a3 + 24) = v39 + 1;
                        *(_QWORD *)(v37 + 8 * v39 + 32) = RoleByCamp;
                      }
                    }
                  }
                }
              }
            }
          }
          v21 = v41;
          v22 = v43 + 1;
        }
        while ( v41 >= v43 + 1 );
      }
      if ( a3 == 0 )
LABEL_46:
        il2cpp_codegen_raise_null_reference_exception();
      return *(_DWORD *)(a3 + 24) > 0;
    }
    else
    {
      return false;
    }
  }
  return result;
}
