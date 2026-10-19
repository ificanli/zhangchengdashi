__int64 __fastcall GameFramework_Resources_ResourcesModule___ctor(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20

  if ( (byte_900A11D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE270);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF088);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC5A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF130);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9F98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9F70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D06950);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDBC38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DB50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDF90);
    byte_900A11D = 1;
  }
  *(_DWORD *)(a1 + 60) = 100;
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDF90);
  System_Collections_Generic_List_object____ctor(v2, qword_8D0DB50);
  *(_QWORD *)(a1 + 72) = v2;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDBC38);
  System_Collections_Generic_HashSet_object____ctor(v3, qword_8D06950);
  *(_QWORD *)(a1 + 80) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDBC38);
  System_Collections_Generic_HashSet_object____ctor(v4, qword_8D06950);
  *(_QWORD *)(a1 + 88) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9F70);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFF088);
  *(_QWORD *)(a1 + 96) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9F98);
  System_Collections_Generic_Dictionary_object__object____ctor(v6, qword_8CFF130);
  *(_QWORD *)(a1 + 104) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9618);
  System_Collections_Generic_Dictionary_int__object____ctor(v7, qword_8CFC5A8);
  *(_QWORD *)(a1 + 120) = v7;
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C80);
  System_Collections_Generic_Dictionary_object__object____ctor(v8, qword_8CFE270);
  *(_QWORD *)(a1 + 128) = v8;
  return GameFramework_GameFrameModule___ctor(a1, 0);
}
