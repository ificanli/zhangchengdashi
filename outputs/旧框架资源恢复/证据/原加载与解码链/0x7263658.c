void *GameFramework_Tools_UIGradientBlender___xy___(void *data, unsigned __int8 flag, const MethodInfo *method)
{
  unsigned int v5; // w21
  void *result; // x0
  int v7; // w12
  unsigned int v8; // w10
  int v9; // w8
  unsigned __int64 v10; // x9
  char *v11; // x14
  int v12; // w15
  int v13; // w15

  if ( (byte_9009ADB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE36B0);
    byte_9009ADB = 1;
  }
  if ( data == nullptr )
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (*((_QWORD *)data + 3) & 3LL) != 0 )
    v5 = ((int)*((_QWORD *)data + 3) >> 2) + 1;
  else
    v5 = (int)*((_QWORD *)data + 3) >> 2;
  if ( (flag & 1) != 0 )
  {
    result = (void *)((__int64 (__fastcall *)(__int64, _QWORD, const MethodInfo *))unk_3C3D320)(
                       qword_8CE36B0,
                       v5 + 1,
                       method);
    if ( result == nullptr )
      goto LABEL_20;
    if ( v5 >= *((_DWORD *)result + 6) )
    {
LABEL_19:
      ((void (*)(void))unk_3C3D4D4)();
      goto LABEL_20;
    }
    v7 = *((_DWORD *)data + 6);
    *((_DWORD *)result + (int)v5 + 8) = v7;
  }
  else
  {
    result = (void *)((__int64 (__fastcall *)(__int64, _QWORD, const MethodInfo *))unk_3C3D320)(
                       qword_8CE36B0,
                       v5,
                       method);
    v7 = *((_DWORD *)data + 6);
  }
  if ( v7 >= 1 )
  {
    if ( result == nullptr )
      goto LABEL_20;
    v8 = *((_DWORD *)result + 6);
    v9 = 0;
    v10 = 0;
    while ( (int)v10 >> 2 < v8 && v10 < (unsigned int)v7 )
    {
      v11 = (char *)result + 4 * ((int)v10 >> 2);
      v12 = *((unsigned __int8 *)data + v10++ + 32);
      v13 = (v12 << (v9 & 0x18)) | *((_DWORD *)v11 + 8);
      v9 += 8;
      *((_DWORD *)v11 + 8) = v13;
      if ( (__int64)v10 >= v7 )
        return result;
    }
    goto LABEL_19;
  }
  return result;
}
