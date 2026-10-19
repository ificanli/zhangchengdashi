void *stage41_GameFramework_ConfigRead__readCustomConfigAsync_object_(void *a0, void *a1, int a2, void *a3)
{
  __int128 v9; // [xsp+8h] [xbp-88h] BYREF
  __int64 v10; // [xsp+18h] [xbp-78h]
  _QWORD v11[4]; // [xsp+20h] [xbp-70h] BYREF
  __int128 v12; // [xsp+40h] [xbp-50h]
  __int128 v13; // [xsp+50h] [xbp-40h]

  if ( *((_QWORD *)a3 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    if ( *((_QWORD *)a3 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a3);
  }
  v12 = 0u;
  v13 = 0u;
  memset(v11, 0, sizeof(v11));
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Create(&v9, 0);
  *((_QWORD *)&v12 + 1) = a0;
  *(_QWORD *)&v13 = a1;
  LODWORD(v12) = a2;
  *(_OWORD *)&v11[1] = v9;
  v11[3] = v10;
  LODWORD(v11[0]) = -1;
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Start_ConfigRead___slS__object__(
    &v11[1],
    v11,
    *(_QWORD *)(*((_QWORD *)a3 + 7) + 16LL));
  return System_Runtime_CompilerServices_AsyncTaskMethodBuilder__get_Task(&v11[1], 0);
}
