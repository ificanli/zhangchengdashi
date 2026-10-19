_QWORD *__fastcall GameFramework_AppSetting__set_MineGameName(__int64 a1)
{
  _QWORD *result; // x0

  if ( (byte_9008DEE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_9008DEE = 1;
  }
  result = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    result = off_8CE40C8;
  }
  *(_QWORD *)(result[23] + 40LL) = a1;
  return result;
}
