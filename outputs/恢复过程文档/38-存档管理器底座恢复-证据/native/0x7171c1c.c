unsigned __int8 Oke____j_g__O(void *key, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x0
  __int64 v5; // x21
  __int64 v6; // x0
  unsigned int Chars; // w0
  unsigned int v8; // w21
  int v9; // w20
  char IsLetter; // w0
  unsigned int v11; // w8
  unsigned __int8 result; // w0
  unsigned int v13; // w21
  __int64 v14; // x0
  void *v15; // x0
  void *v16; // x1
  const MethodInfo *v17; // x2

  if ( (byte_90091A5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5500);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87940);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EA0);
    byte_90091A5 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v4 = sub_750A330(qword_8D87940, key, qword_8D78EA0, 0);
  if ( v3 == 0 )
    goto LABEL_29;
  v5 = v4;
  if ( v4 == 0
    || (v6 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v4, *(_QWORD *)(*(_QWORD *)v3 + 64LL))) != 0 )
  {
    if ( *(_DWORD *)(v3 + 24) != 0 )
    {
      *(_QWORD *)(v3 + 32) = v5;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__Log(v3, 0);
      if ( (System_String__IsNullOrEmpty(key, 0) & 1) != 0 )
        goto LABEL_20;
      if ( key != nullptr )
      {
        if ( *((int *)key + 4) <= 511 )
        {
          Chars = System_String__get_Chars(key, 0, 0);
          if ( (unsigned __int16)Chars == 64 )
          {
            if ( *((_DWORD *)key + 4) == 1 )
              goto LABEL_20;
            v8 = System_String__get_Chars(key, 1, 0);
            v9 = 2;
          }
          else
          {
            v8 = Chars;
            v9 = 1;
          }
          if ( *((_DWORD *)off_8CE5500 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5500);
          IsLetter = System_Char__IsLetter(v8, 0);
          if ( (unsigned __int16)v8 == 95 || (IsLetter & 1) != 0 )
          {
            if ( v9 >= *((_DWORD *)key + 4) )
            {
              LOBYTE(v11) = 1;
            }
            else
            {
              do
              {
                v13 = System_String__get_Chars(key, (unsigned int)v9, 0);
                if ( *((_DWORD *)off_8CE5500 + 56) == 0 )
                  il2cpp_codegen_runtime_class_init(off_8CE5500);
                v11 = ((unsigned __int16)v13 == 95) | (unsigned int)System_Char__IsLetterOrDigit(v13, 0);
                if ( (v11 & 1) == 0 )
                  break;
                ++v9;
              }
              while ( v9 < *((_DWORD *)key + 4) );
            }
            return v11 & 1;
          }
        }
LABEL_20:
        LOBYTE(v11) = 0;
        return v11 & 1;
      }
LABEL_29:
      il2cpp_codegen_raise_null_reference_exception();
    }
    v6 = ((__int64 (*)(void))unk_3C3D4D4)();
  }
  v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v6);
  v15 = (void *)((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v14, 0);
  GameFramework_DataManagerBase__SaveLocalData(v15, v16, v17);
  return result;
}
