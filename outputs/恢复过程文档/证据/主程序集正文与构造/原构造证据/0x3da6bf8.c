// local variable allocation has failed, the output may be wrong!
void GameModule_YingWuZheHaoZhaoTalent___ctor(void *self, void *arg0, int arg1, float arg2, const MethodInfo *method)
{
  __int64 v9; // x22

  if ( (byte_8FFD55B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFD9E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9AC8);
    byte_8FFD55B = 1;
  }
  v9 = ((__int64 (__fastcall *)(__int64, void *, _QWORD, const MethodInfo *))unk_3C3D4C4)(
         qword_8CD9AC8,
         arg0,
         *(_QWORD *)&arg1,
         method);
  System_Collections_Generic_Dictionary_object__float____ctor(v9, qword_8CFD9E8);
  *((_QWORD *)self + 6) = v9;
  GameModule_TalentBase___ctor(self, arg0, (unsigned int)arg1, 0, arg2);
}
