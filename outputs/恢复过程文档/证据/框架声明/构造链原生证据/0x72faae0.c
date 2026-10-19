void GameFramework_SDK_AndroidCallback___ctor(void *self, void *arg0, const MethodInfo *method)
{
  if ( (byte_900A16A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3F28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C8B8);
    byte_900A16A = 1;
  }
  if ( *((_DWORD *)off_8CE3F28 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE3F28);
  UnityEngine_AndroidJavaProxy___ctor(self, qword_8D7C8B8, 0);
  *((_QWORD *)self + 4) = arg0;
}
