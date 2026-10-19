__int64 __fastcall GameModule_BattleGameSceneManager__TryGetNearestRoleTarget(
        __int64 a1,
        __int64 a2,
        char a3,
        _QWORD *a4)
{
  long double position; // q0

  if ( (byte_8FFD791 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD791 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
  {
    *a4 = 0;
    return 0;
  }
  else
  {
    if ( a2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(a2, 0);
    return sub_3DF06BC(a1, a3 & 1, a4, position);
  }
}
