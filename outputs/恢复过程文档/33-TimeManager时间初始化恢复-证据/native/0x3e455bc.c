void TimeModuleO_TimeManager__HandleTimeToWeekCutDown(void *self, const MethodInfo *method)
{
  _QWORD v3[4]; // [xsp+0h] [xbp-80h] BYREF
  _QWORD v4[6]; // [xsp+20h] [xbp-60h] BYREF
  __int64 v5; // [xsp+50h] [xbp-30h]

  if ( (byte_8FFD9F1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D234C8);
    byte_8FFD9F1 = 1;
  }
  v5 = 0;
  memset(v4, 0, sizeof(v4));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v3, 0, method);
  v4[5] = self;
  qmemcpy(&v4[1], v3, 32);
  LODWORD(v4[0]) = -1;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_TimeManager__HandleTimeToWeekCutDown_d__36_(
    &v4[1],
    v4,
    qword_8D234C8);
}
