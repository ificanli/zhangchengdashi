void *stage41_GameFramework_ConfigRead__waitLoadComplate(void *a0)
{
  __int128 v2; // [xsp+8h] [xbp-68h] BYREF
  __int64 v3; // [xsp+18h] [xbp-58h]
  _QWORD v4[4]; // [xsp+20h] [xbp-50h] BYREF
  __int64 v5; // [xsp+40h] [xbp-30h]

  if ( (byte_9009168 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E6D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    byte_9009168 = 1;
  }
  v5 = 0;
  memset(v4, 0, sizeof(v4));
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Create(&v2, 0);
  *(_OWORD *)&v4[1] = v2;
  v4[3] = v3;
  LODWORD(v4[0]) = -1;
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Start_ConfigRead_B____D_(&v4[1], v4, qword_8D1E6D0);
  return System_Runtime_CompilerServices_AsyncTaskMethodBuilder__get_Task(&v4[1], 0);
}
