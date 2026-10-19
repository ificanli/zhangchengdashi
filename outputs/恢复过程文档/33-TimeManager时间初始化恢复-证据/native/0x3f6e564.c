unsigned __int8 TimeModuleO_TimeManager__CheckTimerToZeroCoroutine_d__45__MoveNext(
        void *self,
        const MethodInfo *method)
{
  int v3; // w8
  void *v4; // x0
  int v5; // w21
  __int64 v6; // x20

  if ( (byte_8FFE38D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF660);
    byte_8FFE38D = 1;
  }
  v3 = *((_DWORD *)self + 4);
  if ( (unsigned int)(v3 - 1) < 2 )
  {
    v4 = *((void **)self + 4);
    *((_DWORD *)self + 4) = -1;
    if ( v4 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    TimeModuleO_TimeManager__CheckTimerToZero(v4, nullptr);
    v5 = 2;
    goto LABEL_8;
  }
  if ( v3 == 0 )
  {
    *((_DWORD *)self + 4) = -1;
    v5 = 1;
LABEL_8:
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF660);
    UnityEngine_WaitForSeconds___ctor(v6, 0, 1.0);
    *((_QWORD *)self + 3) = v6;
    *((_DWORD *)self + 4) = v5;
    return 1;
  }
  return 0;
}
