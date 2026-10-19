void DataModule_PlayerGuideData__InitFromDefaults(void *self, const MethodInfo *method)
{
  ServerBaseData__InitFromDefaults(self, 0);
  *((_BYTE *)self + 16) = 1;
}
