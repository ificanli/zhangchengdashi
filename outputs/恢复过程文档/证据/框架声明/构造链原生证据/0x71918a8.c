void YooAsset_SubAssetsOperationHandle___ctor(void *self, void *arg0, const MethodInfo *method)
{
  __int64 v5; // x8

  System_Object___ctor(self, 0);
  *((_QWORD *)self + 3) = arg0;
  if ( arg0 != nullptr )
    v5 = *((_QWORD *)arg0 + 4);
  else
    v5 = 0;
  *((_QWORD *)self + 2) = v5;
}
