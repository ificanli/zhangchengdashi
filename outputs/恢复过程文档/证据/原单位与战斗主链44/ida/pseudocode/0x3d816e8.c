__int64 __fastcall GameModule_RoleBehaviour__InitAnimationAsync(__int64 a1)
{
  __int128 v3; // [xsp+0h] [xbp-40h] BYREF
  __int64 v4; // [xsp+10h] [xbp-30h]
  __int64 v5; // [xsp+18h] [xbp-28h]

  if ( (byte_8FFD457 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D217A0);
    byte_8FFD457 = 1;
  }
  v3 = 0u;
  v5 = 0;
  v4 = a1;
  LODWORD(v3) = -1;
  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_RoleBehaviour__InitAnimationAsync_d__70_(
    (char *)&v3 + 8,
    &v3,
    qword_8D217A0);
  return 0;
}
