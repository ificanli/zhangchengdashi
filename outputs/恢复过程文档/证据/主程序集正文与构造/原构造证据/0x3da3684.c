// local variable allocation has failed, the output may be wrong!
void GameModule_HouQinZhiYuanTalent___ctor(void *self, void *arg0, int arg1, float arg2, const MethodInfo *method)
{
  __int64 v9; // x22

  if ( (byte_8FFD545 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DD68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDFF0);
    byte_8FFD545 = 1;
  }
  v9 = ((__int64 (__fastcall *)(__int64, void *, _QWORD, const MethodInfo *))unk_3C3D4C4)(
         qword_8CDDFF0,
         arg0,
         *(_QWORD *)&arg1,
         method);
  System_Collections_Generic_List_object____ctor(v9, qword_8D0DD68);
  *((_QWORD *)self + 6) = v9;
  GameModule_TalentBase___ctor(self, arg0, (unsigned int)arg1, 0, arg2);
}
