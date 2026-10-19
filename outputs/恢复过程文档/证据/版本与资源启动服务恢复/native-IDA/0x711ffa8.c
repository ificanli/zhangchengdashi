__int64 GameFramework_AppSetting__get_MineGameName()
{
  _QWORD *v0; // x0
  __int64 dataPath; // x0
  __int64 v2; // x0
  __int64 v3; // x9
  __int64 v4; // x8
  _QWORD *v5; // x0
  __int64 v6; // x20

  if ( (byte_9008DEB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    byte_9008DEB = 1;
  }
  v0 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v0 = off_8CE40C8;
  }
  if ( (System_String__IsNullOrEmpty(*(_QWORD *)(v0[23] + 40LL), 0) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40D8);
    dataPath = UnityEngine_Application__get_dataPath(0);
    if ( dataPath == 0 || (v2 = System_String__Split(dataPath, 47, 0, 0)) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v3 = *(_QWORD *)(v2 + 24);
    v4 = v2;
    if ( (unsigned int)v3 <= 1 )
    {
      ((void (*)(void))unk_3C3D4D4)();
      JUMPOUT(0x71200B4);
    }
    v5 = off_8CE40C8;
    v6 = *(_QWORD *)(v4 + (((v3 << 32) - 0x200000000LL) >> 29) + 32);
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v5 = off_8CE40C8;
    }
    *(_QWORD *)(v5[23] + 40LL) = v6;
  }
  else
  {
    v5 = off_8CE40C8;
  }
  if ( *((_DWORD *)v5 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(v5);
    v5 = off_8CE40C8;
  }
  return *(_QWORD *)(v5[23] + 40LL);
}
