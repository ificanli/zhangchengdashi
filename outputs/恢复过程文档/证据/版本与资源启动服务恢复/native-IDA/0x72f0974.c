__int64 __fastcall GameFramework_Resources_PatchManifest___neB__(__int64 a1, __int64 a2)
{
  __int64 result; // x0
  __int64 v5; // x21
  __int64 v6; // x20
  __int64 v7; // x0
  unsigned int v8; // w8
  __int64 v9; // x22
  __int64 v10; // x21
  int v11; // w0
  __int64 v12; // x0

  if ( (byte_900A0AF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEEF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEB818);
    byte_900A0AF = 1;
  }
  if ( a2 == 0 )
    goto LABEL_21;
  result = System_String__Split(a2, 124, 0, 0);
  if ( result == 0 )
    goto LABEL_21;
  v5 = result;
  if ( *(int *)(result + 24) >= 4 )
  {
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEB818);
    v7 = System_Object___ctor(v6, 0);
    v8 = *(_DWORD *)(v5 + 24);
    if ( v8 != 0 )
    {
      if ( v6 == 0 )
        goto LABEL_21;
      *(_QWORD *)(v6 + 16) = *(_QWORD *)(v5 + 32);
      if ( v8 > 1 )
      {
        *(_QWORD *)(v6 + 24) = *(_QWORD *)(v5 + 40);
        if ( v8 != 2 )
        {
          *(_QWORD *)(v6 + 32) = *(_QWORD *)(v5 + 48);
          if ( v8 > 3 )
          {
            v9 = *(_QWORD *)(v5 + 56);
            if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5DB0);
            *(_QWORD *)(v6 + 40) = System_Convert__ToUInt64(v9, 0);
            if ( *(_DWORD *)(v5 + 24) == 5 )
            {
              v10 = *(_QWORD *)(v5 + 64);
              if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE5DB0);
              v11 = System_Convert__ToInt32(v10, 0);
            }
            else
            {
              v11 = *(_DWORD *)(a1 + 32);
            }
            *(_DWORD *)(v6 + 48) = v11;
            v12 = *(_QWORD *)(a1 + 48);
            if ( v12 != 0 )
              return System_Collections_Generic_Dictionary_object__object___Add(
                       v12,
                       *(_QWORD *)(v6 + 16),
                       v6,
                       qword_8CFEEF0);
LABEL_21:
            il2cpp_codegen_raise_null_reference_exception();
          }
        }
      }
    }
    ((void (__fastcall *)(__int64))unk_3C3D4D4)(v7);
    JUMPOUT(0x72F0AEC);
  }
  return result;
}
