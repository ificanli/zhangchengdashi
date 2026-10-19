void *L_Tools_DataCompressTools__EncryptString(void *value, const MethodInfo *method)
{
  __int64 UTF8; // x0
  __int64 v5; // x0
  __int64 v6; // x8
  __int64 v7; // x19
  unsigned __int64 v8; // x20
  __int64 v9; // x21
  char v10; // w23
  __int64 v11; // x19
  _QWORD **v12; // x8

  if ( (byte_9000A2C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_9000A2C = 1;
  }
  if ( (System_String__IsNullOrEmpty(value, 0) & 1) != 0 )
    return (void *)qword_8D4ECC0;
  UTF8 = System_Text_Encoding__get_UTF8(0);
  if ( UTF8 == 0
    || (v5 = (*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)UTF8 + 600LL))(
               UTF8,
               value,
               *(_QWORD *)(*(_QWORD *)UTF8 + 608LL))) == 0 )
  {
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v6 = *(_QWORD *)(v5 + 24);
  v7 = v5;
  if ( (int)v6 >= 1 )
  {
    v8 = 0;
    v9 = v5 + 32;
    while ( v8 < (unsigned int)v6 )
    {
      v10 = *(_BYTE *)(v9 + v8);
      if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE6138);
        LODWORD(v6) = *(_DWORD *)(v7 + 24);
      }
      if ( v8 >= (unsigned int)v6 )
        break;
      *(_BYTE *)(v9 + v8++) = v10 ^ ~*(_BYTE *)(*((_QWORD *)off_8CE6138 + 23) + 8LL);
      if ( (__int64)v8 >= (int)v6 )
        goto LABEL_14;
    }
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_20;
  }
LABEL_14:
  if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5DB0);
  v11 = System_Convert__ToBase64String(v7, 0);
  v12 = (_QWORD **)off_8CE6138;
  if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6138);
    v12 = (_QWORD **)off_8CE6138;
  }
  return (void *)sub_74FE7A4(v11, *v12[23], 0);
}
