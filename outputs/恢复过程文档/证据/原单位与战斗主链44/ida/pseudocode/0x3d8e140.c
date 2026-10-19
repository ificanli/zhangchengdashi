__int64 __fastcall GameModule_RoleBehaviour__Charm(__int64 a1, __int64 a2)
{
  char v2; // w20
  _QWORD v5[4]; // [xsp+0h] [xbp-A0h] BYREF
  _QWORD v6[6]; // [xsp+20h] [xbp-80h] BYREF
  __int128 v7; // [xsp+50h] [xbp-50h]
  __int128 v8; // [xsp+60h] [xbp-40h]

  v2 = a2;
  if ( (byte_8FFD4B2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D232D8);
    byte_8FFD4B2 = 1;
  }
  v7 = 0u;
  v8 = 0u;
  memset(v6, 0, sizeof(v6));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v5, 0, a2);
  v6[5] = a1;
  LOBYTE(v7) = v2 & 1;
  qmemcpy(&v6[1], v5, 32);
  LODWORD(v6[0]) = -1;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RoleBehaviour__Charm_d__289_(
           &v6[1],
           v6,
           qword_8D232D8);
}
