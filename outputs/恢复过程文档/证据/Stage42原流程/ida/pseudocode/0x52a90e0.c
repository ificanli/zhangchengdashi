unsigned __int8 GameFramework_Fsm_Fsm_object___HasData_52a90e0(void *this, void *name, const MethodInfo *method)
{
  __int64 v6; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0

  if ( (byte_9002567 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF760);
    byte_9002567 = 1;
  }
  if ( (System_String__IsNullOrEmpty(name, 0) & 1) != 0 )
  {
    v8 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v8);
    v10 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5DB58);
    GameFramework_GameFrameworkException___ctor(v9, v10, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v9, method);
LABEL_7:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v6 = *((_QWORD *)this + 6);
  if ( v6 == 0 )
    goto LABEL_7;
  return System_Collections_Generic_Dictionary_object__object___ContainsKey(v6, name, qword_8CFF760);
}
