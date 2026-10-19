void GameFramework_Fsm_FsmManager___ctor_7296bd0(void *this, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20

  if ( (byte_9009D28 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9D08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0A810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD6C8);
    byte_9009D28 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDD6C8, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0A810);
  *((_QWORD *)this + 6) = v3;
  GameFramework_GameFrameModule___ctor(this, 0);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9D08);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFE4C0);
  *((_QWORD *)this + 4) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD6C8);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0A810);
  *((_QWORD *)this + 5) = v5;
}
