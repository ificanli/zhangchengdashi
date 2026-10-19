__int64 __fastcall GameModule_RoleBehaviour__HellFireDeadCallBack(__int64 a1, __int64 a2)
{
  _QWORD v4[4]; // [xsp+0h] [xbp-90h] BYREF
  _QWORD v5[8]; // [xsp+20h] [xbp-70h] BYREF
  __int64 v6; // [xsp+60h] [xbp-30h]

  if ( (byte_8FFD483 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D232F0);
    byte_8FFD483 = 1;
  }
  v6 = 0;
  memset(v5, 0, sizeof(v5));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v4, 0, a2);
  v5[5] = a1;
  qmemcpy(&v5[1], v4, 32);
  LODWORD(v5[0]) = -1;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RoleBehaviour__HellFireDeadCallBack_d__195_(
           &v5[1],
           v5,
           qword_8D232F0);
}
