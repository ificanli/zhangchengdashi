void *GameFramework_Tools_UIGradientBlender__hG_j______M_Y(void *data, void *key, const MethodInfo *method)
{
  int v5; // w22
  unsigned int v6; // w21
  __int64 v7; // x0
  int v8; // w8
  unsigned int v9; // w9
  unsigned int v10; // w13
  unsigned __int64 v11; // x10
  int v12; // w14
  unsigned int *v13; // x15
  __int64 v14; // x17
  __int64 v15; // x16
  __int64 v16; // x17
  unsigned int v17; // w14

  if ( (byte_9009AE8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4B250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF6340);
    byte_9009AE8 = 1;
  }
  if ( data == nullptr )
LABEL_19:
    il2cpp_codegen_raise_null_reference_exception();
  v5 = *((_DWORD *)data + 6);
  v6 = v5 - 1;
  if ( v5 - 1 >= 1 )
  {
    if ( *((_DWORD *)off_8CF6340 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CF6340);
    v7 = GameFramework_Tools_UIGradientBlender__hG_j_________(key, key, method);
    if ( v6 >= (unsigned int)*((_QWORD *)data + 3) )
    {
LABEL_18:
      ((void (__fastcall *)(__int64))unk_3C3D4D4)(v7);
      goto LABEL_19;
    }
    v8 = **((_DWORD **)off_8CF6340 + 23);
    v9 = (52 / v5 + 6) * v8;
    if ( v9 != 0 )
    {
      v10 = *((_DWORD *)data + 8);
      v11 = (unsigned int)*((_QWORD *)data + 3);
      while ( 1 )
      {
        v12 = (v9 >> 2) & 3;
        v13 = (unsigned int *)((char *)data + 4 * v6 + 32);
        v14 = v6;
        do
        {
          v15 = v14 - 1;
          if ( v14 - 1 >= v11 )
            goto LABEL_18;
          if ( v7 == 0 )
            goto LABEL_19;
          v16 = v14 & 3 ^ (unsigned int)v12;
          if ( (unsigned int)v16 >= *(_DWORD *)(v7 + 24) )
            goto LABEL_18;
          v10 = *v13
              - (((*(_DWORD *)(v7 + 4 * v16 + 32) ^ *(v13 - 1)) + (v10 ^ v9))
               ^ (((16 * *(v13 - 1)) ^ (v10 >> 3)) + ((*(v13 - 1) >> 5) ^ (4 * v10))));
          *v13-- = v10;
          v14 = v15;
        }
        while ( v15 + 1 > 1 );
        v17 = v15 & 3 ^ v12;
        if ( v17 >= *(_DWORD *)(v7 + 24) )
          goto LABEL_18;
        v10 = *((_DWORD *)data + 8)
            - (((*(_DWORD *)(v7 + 4LL * v17 + 32) ^ *((_DWORD *)data + v6 + 8)) + (v10 ^ v9))
             ^ (((16 * *((_DWORD *)data + v6 + 8)) ^ (v10 >> 3)) + ((*((_DWORD *)data + v6 + 8) >> 5) ^ (4 * v10))));
        v9 -= v8;
        *((_DWORD *)data + 8) = v10;
        if ( v9 == 0 )
          return data;
      }
    }
  }
  return data;
}
