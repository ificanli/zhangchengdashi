void ljzs_lt_Procedure_ProcedureStarGame__StarGame(void *self, const MethodInfo *method)
{
  _QWORD v2[3]; // [xsp+8h] [xbp-38h] BYREF

  if ( (byte_90008CF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D581F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87640);
    byte_90008CF = 1;
  }
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(qword_8D87640, 0);
  if ( *((_DWORD *)off_8CE3D98 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE3D98);
  UnityEngine_AddressableAssets_Addressables__LoadSceneAsync(v2, qword_8D581F0, 0, 1, 100, 0);
}
