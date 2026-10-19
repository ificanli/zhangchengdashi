__int64 __fastcall GameFramework_Resources_ResourcesModule___LoadAsset(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  __int64 v5; // x1

  if ( (byte_900A105 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E18);
    byte_900A105 = 1;
  }
  if ( *((_DWORD *)off_8CEC898 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEC898);
  GameFramework_ResLoadHelper__CheckUseRightResLoad(0);
  if ( a2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = System_String__ToLower(a2, 0);
  v5 = sub_74FE7A4(v4, qword_8D52E18, 0);
  return GameFramework_Resources_ResourcesModule__Load(a1, v5);
}
