void GameFramework_Fsm_Fsm_object___SetData_object__4732acc(
        void *this,
        void *name,
        void *data,
        const MethodInfo *method)
{
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x20
  __int64 v11; // x0

  if ( (byte_9002221 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF778);
    byte_9002221 = 1;
  }
  if ( (System_String__IsNullOrEmpty(name, 0) & 1) != 0 )
  {
    v9 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v9);
    v11 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5DB58);
    GameFramework_GameFrameworkException___ctor(v10, v11, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v10, method);
LABEL_7:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v8 = *((_QWORD *)this + 6);
  if ( v8 == 0 )
    goto LABEL_7;
  System_Collections_Generic_Dictionary_object__object___set_Item(v8, name, data, qword_8CFF778);
}
