void GameFramework_AudioSequence___ctor(void *self, void *arg0, int arg1, void *arg2, const MethodInfo *method)
{
  __int64 v9; // x20

  if ( (byte_900906F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D168F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF460);
    byte_900906F = 1;
  }
  GameFramework_AudioCompositeBase___ctor(self, arg0, (unsigned int)arg1, arg2, method);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF460);
  System_Collections_Generic_Queue_object____ctor(v9, qword_8D168F0);
  *((_QWORD *)self + 4) = v9;
}
