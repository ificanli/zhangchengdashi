void GameFramework_Resources_PatchManifest___ctor(void *self, void *text, const MethodInfo *method)
{
  __int64 v5; // x21
  __int64 v6; // x0
  __int64 v7; // x19
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x21
  __int64 v13; // x22
  int v14; // w8
  __int64 v15; // x8
  __int64 i; // x21
  __int64 v17; // x9
  __int64 v18; // x0

  if ( (byte_900A0B4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEEE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9F18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87CE8);
    byte_900A0B4 = 1;
  }
  v5 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CD9F18, text, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFEEE8);
  *((_QWORD *)self + 6) = v5;
  System_Object___ctor(self, 0);
  if ( (System_String__IsNullOrEmpty(text, 0) & 1) != 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    if ( v6 == 0 )
      goto LABEL_28;
    v7 = v6;
    if ( qword_8D87CE8 != 0
      && ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D87CE8, *(_QWORD *)(*(_QWORD *)v6 + 64LL)) == 0 )
    {
      v18 = ((__int64 (*)(void))unk_3C3D4F0)();
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v18, 0);
      JUMPOUT(0x72ED21C);
    }
    if ( *(_DWORD *)(v7 + 24) != 0 )
    {
      *(_QWORD *)(v7 + 32) = qword_8D87CE8;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__R__u_e(v7, 0);
      return;
    }
    goto LABEL_27;
  }
  if ( text == nullptr )
    goto LABEL_28;
  v8 = System_String__Split(text, 10, 0, 0);
  if ( v8 == 0 )
    goto LABEL_28;
  v9 = v8;
  if ( *(_DWORD *)(v8 + 24) == 0 )
  {
LABEL_27:
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_28;
  }
  v10 = *(_QWORD *)(v8 + 32);
  if ( v10 == 0 || (v11 = System_String__Split(v10, 124, 0, 0)) == 0 )
LABEL_28:
    il2cpp_codegen_raise_null_reference_exception();
  v12 = v11;
  if ( *(_DWORD *)(v11 + 24) == 0 )
    goto LABEL_27;
  v13 = *(_QWORD *)(v11 + 32);
  if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5DB0);
  *((_DWORD *)self + 8) = System_Convert__ToInt32(v13, 0);
  v14 = *(_DWORD *)(v12 + 24);
  if ( (unsigned int)v14 <= 2 )
    goto LABEL_27;
  *((_QWORD *)self + 7) = *(_QWORD *)(v12 + 48);
  if ( v14 >= 4 )
  {
    *((_BYTE *)self + 16) = 1;
    *((_QWORD *)self + 3) = *(_QWORD *)(v12 + 56);
  }
  *((_QWORD *)self + 5) = *(_QWORD *)(v12 + 40);
  v15 = *(_QWORD *)(v9 + 24);
  if ( (int)v15 >= 2 )
  {
    for ( i = 5; i - 4 < (unsigned __int64)(unsigned int)v15; ++i )
    {
      GameFramework_Resources_PatchManifest___neB__(self, *(_QWORD *)(v9 + 8 * i));
      LODWORD(v15) = *(_DWORD *)(v9 + 24);
      v17 = i - 3;
      if ( v17 >= (int)v15 )
        return;
    }
    goto LABEL_27;
  }
}
