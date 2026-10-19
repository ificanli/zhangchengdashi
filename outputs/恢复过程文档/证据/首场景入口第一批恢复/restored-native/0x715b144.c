// local variable allocation has failed, the output may be wrong!
void GameFramework_GameFrameEntry__ResourcesModuleUpdate(float elapsed, float realElapsed, const MethodInfo *method)
{
  long double v3; // q8
  long double v4; // q9
  _QWORD *v5; // x0
  void *v6; // x0
  __int64 Module_object; // x0

  v3 = *(long double *)&realElapsed;
  v4 = *(long double *)&elapsed;
  if ( (byte_90090D4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    byte_90090D4 = 1;
  }
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v5 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v5 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v5[23] + 56LL) == 0 )
  {
    v6 = off_8CE7B30;
    if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE7B30);
      v6 = off_8CE7B30;
    }
    if ( *(_BYTE *)(*((_QWORD *)v6 + 23) + 8LL) != 0 )
    {
      if ( *((_DWORD *)v6 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(v6);
      Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D180);
      if ( Module_object != 0 )
        (*(void (__fastcall **)(__int64, _QWORD, long double, long double))(*(_QWORD *)Module_object + 424LL))(
          Module_object,
          *(_QWORD *)(*(_QWORD *)Module_object + 432LL),
          v4,
          v3);
    }
  }
}
