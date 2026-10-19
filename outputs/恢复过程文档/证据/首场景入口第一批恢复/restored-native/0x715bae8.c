void GameFramework_GameFrameEntry___cctor(const MethodInfo *method)
{
  __int64 v1; // x19
  __int64 v2; // x8

  if ( (byte_90090DA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D07D60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDCE10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_90090DA = 1;
  }
  v1 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDCE10);
  System_Collections_Generic_LinkedList_object____ctor(v1, qword_8D07D60);
  **((_QWORD **)off_8CE7B30 + 23) = v1;
  v2 = *((_QWORD *)off_8CE7B30 + 23);
  *(_QWORD *)(v2 + 24) = qword_8D4ECC0;
  *(_BYTE *)(v2 + 32) = 0;
}
