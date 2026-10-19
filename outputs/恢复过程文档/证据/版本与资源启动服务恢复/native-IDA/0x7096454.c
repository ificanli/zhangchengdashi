__int64 __fastcall UpdateManager___ctor(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x20
  __int64 v4; // x20

  if ( (byte_9008924 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFCD30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD97B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11AE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDEB20);
    byte_9008924 = 1;
  }
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
  System_Collections_Generic_List_int____ctor(v2, qword_8D0BE60);
  *(_QWORD *)(a1 + 80) = v2;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDEB20);
  System_Collections_Generic_List_object____ctor(v3, qword_8D11AE0);
  *(_QWORD *)(a1 + 88) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD97B0);
  System_Collections_Generic_Dictionary_int__object____ctor(v4, qword_8CFCD30);
  *(_QWORD *)(a1 + 96) = v4;
  *(_DWORD *)(a1 + 104) = 16;
  return UnityEngine_MonoBehaviour___ctor(a1, 0);
}
