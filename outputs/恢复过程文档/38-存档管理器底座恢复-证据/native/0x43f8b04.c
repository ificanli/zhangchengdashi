void *L_Tools_DataCompressTools__DecryptString(void *value, const MethodInfo *method)
{
  _QWORD **v3; // x0
  int v4; // w20
  __int64 v5; // x8
  __int64 v6; // x20
  _QWORD *v7; // x0
  _QWORD *v8; // x19
  __int64 v9; // x8
  unsigned __int64 v10; // x22
  char *v11; // x23
  char v12; // w24
  __int64 UTF8; // x0

  if ( (byte_9000A2D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_9000A2D = 1;
  }
  if ( (System_String__IsNullOrEmpty(value, 0) & 1) != 0 )
    return (void *)qword_8D4ECC0;
  if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6138);
  if ( value == nullptr )
LABEL_27:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_String__EndsWith(value, **((_QWORD **)off_8CE6138 + 23), 0) & 1) == 0 )
    return value;
  v3 = (_QWORD **)off_8CE6138;
  v4 = *((_DWORD *)value + 4);
  if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6138);
    v3 = (_QWORD **)off_8CE6138;
  }
  v5 = *v3[23];
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v6 = System_String__Substring(value, 0, (unsigned int)(v4 - *(_DWORD *)(v5 + 16)), 0);
  if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5DB0);
  v7 = (_QWORD *)System_Convert__FromBase64String(v6, 0);
  v8 = v7;
  if ( v7 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v9 = v7[3];
  if ( (int)v9 >= 1 )
  {
    v10 = 0;
    v11 = (char *)(v7 + 4);
    while ( 1 )
    {
      if ( v10 >= (unsigned int)v9 )
        goto LABEL_26;
      v7 = off_8CE6138;
      v12 = v11[v10];
      if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE6138);
        LODWORD(v9) = *((_DWORD *)v8 + 6);
      }
      if ( v10 >= (unsigned int)v9 )
        break;
      v11[v10++] = v12 ^ ~*(_BYTE *)(*((_QWORD *)off_8CE6138 + 23) + 8LL);
      if ( (__int64)v10 >= (int)v9 )
        goto LABEL_22;
    }
    v7 = (_QWORD *)((__int64 (*)(void))unk_3C3D4D4)();
LABEL_26:
    ((void (__fastcall *)(_QWORD *))unk_3C3D4D4)(v7);
    goto LABEL_27;
  }
LABEL_22:
  UTF8 = System_Text_Encoding__get_UTF8(0);
  if ( UTF8 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (void *)(*(__int64 (__fastcall **)(__int64, _QWORD *, _QWORD))(*(_QWORD *)UTF8 + 888LL))(
                   UTF8,
                   v8,
                   *(_QWORD *)(*(_QWORD *)UTF8 + 896LL));
}
