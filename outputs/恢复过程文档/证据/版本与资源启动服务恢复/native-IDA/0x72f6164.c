__int64 __fastcall GameFramework_Resources_ResourcesModule__LoadPrefab(__int64 a1, __int64 a2, __int64 a3, __int64 a4)
{
  __int64 v8; // x1

  if ( (byte_900A104 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52DA8);
    byte_900A104 = 1;
  }
  v8 = sub_74FE7A4(a2, qword_8D52DA8, 0);
  return GameFramework_Resources_ResourcesModule___LoadAsset(a1, v8, a3, a4);
}
