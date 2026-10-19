__int64 __fastcall GameModule_BattleGameSceneManager__CollectRoleTargetsInRange(
        __int64 a1,
        __int64 a2,
        char a3,
        __int64 a4)
{
  int v8; // w2
  int v9; // w8
  long double position; // q0

  if ( (byte_8FFD793 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0DD90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD793 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
  {
    if ( a4 != 0 )
    {
      v8 = *(_DWORD *)(a4 + 24);
      v9 = *(_DWORD *)(a4 + 28) + 1;
      *(_DWORD *)(a4 + 24) = 0;
      *(_DWORD *)(a4 + 28) = v9;
      if ( v8 >= 1 )
        System_Array__Clear(*(_QWORD *)(a4 + 16), 0);
    }
    return 0;
  }
  else
  {
    if ( a2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(a2, 0);
    return sub_3DF08A8(a1, a3 & 1, a4, position);
  }
}
