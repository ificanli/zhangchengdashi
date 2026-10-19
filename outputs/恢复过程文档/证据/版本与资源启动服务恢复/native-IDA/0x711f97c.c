__int64 GameFramework_AppSetting___cctor()
{
  __int64 v0; // x19
  __int64 v1; // x8
  __int64 v2; // x9
  __int64 result; // x0
  unsigned int v4; // w8
  __int64 v5; // x8

  if ( (byte_9008DC9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF2C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9FE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C718);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68728);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66F70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D714E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D67950);
    byte_9008DC9 = 1;
  }
  *(_BYTE *)(*((_QWORD *)off_8CE40C8 + 23) + 8LL) = 1;
  v0 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9FE0);
  System_Collections_Generic_Dictionary_object__object____ctor(v0, qword_8CFF2C0);
  v1 = *((_QWORD *)off_8CE40C8 + 23);
  *(_QWORD *)(v1 + 32) = v0;
  *(_DWORD *)(v1 + 64) = 0;
  v2 = qword_8D68728;
  *(_WORD *)(v1 + 80) = 0;
  *(_QWORD *)(v1 + 72) = v2;
  result = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 4);
  if ( result == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  v4 = *(_DWORD *)(result + 24);
  if ( v4 == 0
    || (*(_QWORD *)(result + 32) = qword_8D714E0, v4 == 1)
    || (*(_QWORD *)(result + 40) = qword_8D6C718, v4 <= 2)
    || (*(_QWORD *)(result + 48) = qword_8D66F70, v4 == 3) )
  {
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_10;
  }
  *(_QWORD *)(result + 56) = qword_8D67950;
  v5 = *((_QWORD *)off_8CE40C8 + 23);
  *(_QWORD *)(v5 + 120) = result;
  *(_WORD *)(v5 + 128) = 0;
  *(_BYTE *)(v5 + 130) = 0;
  return result;
}
