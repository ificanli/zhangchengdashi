void *LoadingModule_LoadingManager__GetFilePath(void *self, void *fileName, const MethodInfo *method)
{
  _QWORD *v5; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  _QWORD *v8; // x8
  __int64 v9; // x20
  __int64 v10; // x19
  __int64 v11; // x20

  if ( (byte_8FFEDC8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9FD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78CE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D793A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E48);
    byte_8FFEDC8 = 1;
  }
  v5 = off_8CE9FD0;
  if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE9FD0);
    v5 = off_8CE9FD0;
  }
  if ( (ToolModule_StringTool__IsNullOrEmpty(*(_QWORD *)(v5[23] + 8LL), 1, 0) & 1) != 0 )
    (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(self, *(_QWORD *)(*(_QWORD *)self + 384LL));
  if ( fileName == nullptr || (v6 = sub_750BEDC(fileName, qword_8D52E48, qword_8D793A8, 0)) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v7 = sub_750BEDC(v6, qword_8D78CE8, qword_8D793A8, 0);
  v8 = off_8CE9FD0;
  v9 = v7;
  if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE9FD0);
    v8 = off_8CE9FD0;
  }
  v10 = *(_QWORD *)(v8[23] + 8LL);
  v11 = sub_74FE7A4(v9, qword_8D52E08, 0);
  if ( *((_DWORD *)off_8CEB838 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB838);
  return (void *)System_IO_Path__Combine(v10, v11, 0);
}
