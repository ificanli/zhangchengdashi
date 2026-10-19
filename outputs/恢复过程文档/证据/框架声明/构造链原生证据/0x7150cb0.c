void GameFramework_AudioParallel___ctor(void *self, void *arg0, int arg1, void *arg2, const MethodInfo *method)
{
  __int64 v9; // x20

  if ( (byte_9009025 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC430);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD95E0);
    byte_9009025 = 1;
  }
  GameFramework_AudioCompositeBase___ctor(self, arg0, (unsigned int)arg1, arg2, method);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD95E0);
  System_Collections_Generic_Dictionary_int__object____ctor(v9, qword_8CFC430);
  *((_QWORD *)self + 4) = v9;
}
