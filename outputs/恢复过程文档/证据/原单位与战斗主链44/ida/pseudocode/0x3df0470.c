__int64 __fastcall GameModule_BattleGameSceneManager__GetRoleTargetsSync(
        __int64 a1,
        __int64 a2,
        char a3,
        int a4,
        long double a5)
{
  __int64 v10; // x19
  long double position; // q0
  long double v12; // q1
  long double v13; // q2
  long double v14; // q11
  long double v15; // q10
  long double v16; // q9
  __int64 v17; // x1
  __int64 v18; // x8
  _QWORD *v19; // x9
  __int64 v20; // x10
  __int64 v22; // [xsp+28h] [xbp-38h] BYREF

  if ( (byte_8FFD78F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0DD80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DD68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDFF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD78F = 1;
  }
  v22 = 0;
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFF0);
  System_Collections_Generic_List_object____ctor(v10, qword_8D0DD68);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) == 0 )
  {
    if ( a2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(a2, 0);
    v14 = position;
    v15 = v12;
    v16 = v13;
    if ( a4 <= 1 )
    {
      if ( (((__int64 (__fastcall *)(__int64, _QWORD, __int64 *, long double, long double, long double, long double))sub_3DF06BC)(
              a1,
              a3 & 1,
              &v22,
              position,
              v12,
              v13,
              a5)
          & 1) != 0 )
      {
        if ( v10 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v17 = v22;
        v18 = *(_QWORD *)(v10 + 16);
        v19 = off_8D0DD80;
        ++*(_DWORD *)(v10 + 28);
        if ( v18 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v20 = *(int *)(v10 + 24);
        if ( (unsigned int)v20 >= *(_DWORD *)(v18 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v10,
            v17,
            *(_QWORD *)(*(_QWORD *)(v19[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v10 + 24) = v20 + 1;
          *(_QWORD *)(v18 + 8 * v20 + 32) = v17;
        }
      }
    }
    else
    {
      ((void (__fastcall *)(__int64, _QWORD, __int64, long double, long double, long double, long double))sub_3DF08A8)(
        a1,
        a3 & 1,
        v10,
        position,
        v12,
        v13,
        a5);
      if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4A38);
      ((void (__fastcall *)(__int64, _QWORD, long double, long double, long double))GameModule_BattleGameSceneManager__SortNearestRoleTargetsInPlace)(
        v10,
        (unsigned int)a4,
        v14,
        v15,
        v16);
    }
  }
  return v10;
}
