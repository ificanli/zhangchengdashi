__int64 __fastcall GameModule_RoleBehaviour__SetAnimation(__int64 a1, __int64 a2, int a3, char a4)
{
  int v6; // w20
  _QWORD v9[4]; // [xsp+0h] [xbp-B0h] BYREF
  _QWORD v10[6]; // [xsp+20h] [xbp-90h] BYREF
  __int128 v11; // [xsp+50h] [xbp-60h]
  __int128 v12; // [xsp+60h] [xbp-50h]

  v6 = a2;
  if ( (byte_8FFD488 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23308);
    byte_8FFD488 = 1;
  }
  v11 = 0u;
  v12 = 0u;
  memset(v10, 0, sizeof(v10));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v9, 0, a2);
  v10[5] = a1;
  LODWORD(v11) = v6;
  DWORD2(v11) = a3;
  BYTE4(v11) = a4 & 1;
  qmemcpy(&v10[1], v9, 32);
  LODWORD(v10[0]) = -1;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RoleBehaviour__SetAnimation_d__203_(
           &v10[1],
           v10,
           qword_8D23308);
}
