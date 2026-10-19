void GameFramework_UIModule___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20

  if ( (byte_90095E6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF4A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE140);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA028);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF660);
    byte_90095E6 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDA028, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFF4A8);
  *((_QWORD *)self + 8) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF650);
  UnityEngine_WaitForEndOfFrame___ctor(v4, 0);
  *((_QWORD *)self + 9) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF660);
  UnityEngine_WaitForSeconds___ctor(v5, 0, 0.5);
  *((_QWORD *)self + 10) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF660);
  UnityEngine_WaitForSeconds___ctor(v6, 0, 0.3);
  *((_QWORD *)self + 11) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C50);
  System_Collections_Generic_Dictionary_object__object____ctor(v7, qword_8CFE140);
  *((_QWORD *)self + 12) = v7;
  GameFramework_GameFrameModule___ctor(self, 0);
}
