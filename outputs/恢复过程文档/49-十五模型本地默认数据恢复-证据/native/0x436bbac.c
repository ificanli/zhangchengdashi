void DataModule_PlayerAdData__InitFromDefaults(void *self, const MethodInfo *method)
{
  __int128 v3; // q0

  ServerBaseData__InitFromDefaults(self, 0);
  *(_QWORD *)&v3 = 0x500000005LL;
  *((_QWORD *)&v3 + 1) = 0x500000005LL;
  *(_OWORD *)((char *)self + 24) = v3;
  *((_DWORD *)self + 10) = 1;
}
