__int64 __fastcall GameModule_RoleBehaviour__MeleeAtkCallBackLogic(__int64 a1, __int64 a2)
{
  int v2; // w19
  _QWORD v5[4]; // [xsp+0h] [xbp-B0h] BYREF
  _QWORD v6[6]; // [xsp+20h] [xbp-90h] BYREF
  __int128 v7; // [xsp+50h] [xbp-60h]
  __int128 v8; // [xsp+60h] [xbp-50h]
  __int64 v9; // [xsp+70h] [xbp-40h]

  v2 = a2;
  if ( (byte_8FFD4A1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D232F8);
    byte_8FFD4A1 = 1;
  }
  v9 = 0;
  v7 = 0u;
  v8 = 0u;
  memset(v6, 0, sizeof(v6));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v5, 0, a2);
  *(_QWORD *)&v7 = a1;
  LODWORD(v6[5]) = v2;
  qmemcpy(&v6[1], v5, 32);
  LODWORD(v6[0]) = -1;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RoleBehaviour__MeleeAtkCallBackLogic_d__248_(
           &v6[1],
           v6,
           qword_8D232F8);
}
