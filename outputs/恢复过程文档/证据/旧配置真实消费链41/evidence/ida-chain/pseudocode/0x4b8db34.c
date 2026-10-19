void *stage41_GameFramework_ConfigRead__readCustomConfigByUnityJsonAsync_object_(void *a0, void *a1, void *a2)
{
  __int128 v7; // [xsp+8h] [xbp-78h] BYREF
  __int64 v8; // [xsp+18h] [xbp-68h]
  _QWORD v9[6]; // [xsp+20h] [xbp-60h] BYREF
  __int64 v10; // [xsp+50h] [xbp-30h]

  if ( *((_QWORD *)a2 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    if ( *((_QWORD *)a2 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a2);
  }
  v10 = 0;
  memset(v9, 0, sizeof(v9));
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Create(&v7, 0);
  v9[4] = a0;
  v9[5] = a1;
  *(_OWORD *)&v9[1] = v7;
  v9[3] = v8;
  LODWORD(v9[0]) = -1;
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Start_ConfigRead_f___mX_object__(
    &v9[1],
    v9,
    *(_QWORD *)(*((_QWORD *)a2 + 7) + 16LL));
  return System_Runtime_CompilerServices_AsyncTaskMethodBuilder__get_Task(&v9[1], 0);
}
