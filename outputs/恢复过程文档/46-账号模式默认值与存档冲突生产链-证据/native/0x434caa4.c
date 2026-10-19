void DataModule_SaveConflictCanvas___c__DisplayClass16_0___OnChoice_b__0(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x8
  __int64 gameObject; // x0

  v3 = *((_QWORD *)self + 2);
  if ( v3 == 0
    || (v4 = *(_QWORD *)(v3 + 80)) != 0
    && ((*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))(v4 + 24))(
          *(_QWORD *)(v4 + 64),
          *((unsigned __int8 *)self + 24),
          *(_QWORD *)(v4 + 40)),
        (v3 = *((_QWORD *)self + 2)) == 0)
    || (gameObject = UnityEngine_Component__get_gameObject(v3, 0)) == 0 )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  UnityEngine_GameObject__SetActive(gameObject, 0, 0);
}
