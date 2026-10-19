void YooAsset_OperationHandleBase___ctor(void *self, void *operation, const MethodInfo *method)
{
  __int64 v5; // x8

  System_Object___ctor(self, 0);
  *((_QWORD *)self + 3) = operation;
  if ( operation != nullptr )
    v5 = *((_QWORD *)operation + 4);
  else
    v5 = 0;
  *((_QWORD *)self + 2) = v5;
}
