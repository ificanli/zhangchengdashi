bool __fastcall GameModule_BattleGameSceneManager__IsRoleTargetValid(__int64 a1)
{
  if ( (byte_8FFD79B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD79B = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(a1, 0, 0) & 1) == 0 )
    return false;
  if ( a1 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return *(_BYTE *)(a1 + 33) == 0 && *(_BYTE *)(a1 + 396) == 0;
}
