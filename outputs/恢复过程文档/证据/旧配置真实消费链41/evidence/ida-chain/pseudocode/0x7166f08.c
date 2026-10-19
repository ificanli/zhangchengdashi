void *stage41_GameFramework_ConfigRead__GetConfigDataForNewResWebgl(void *a0, void *a1)
{
  _QWORD *v3; // x0
  __int64 v4; // x8
  __int64 v6; // x0
  __int64 *v7; // x8
  __int64 v8; // x20
  __int64 v9; // x0
  __int64 v10; // x19
  __int64 v11; // x0
  __int64 v12; // x0
  void *v13; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_9009162 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEE20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D81128);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61C10);
    byte_9009162 = 1;
  }
  v3 = off_8CE5BB8;
  v13 = nullptr;
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v3 = off_8CE5BB8;
  }
  v4 = *(_QWORD *)(v3[23] + 24LL);
  if ( v4 != 0 )
  {
    if ( *((_DWORD *)v3 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v3);
      v4 = *(_QWORD *)(*((_QWORD *)off_8CE5BB8 + 23) + 24LL);
      if ( v4 == 0 )
LABEL_20:
        il2cpp_codegen_raise_null_reference_exception();
    }
    if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v4, a0, &v13, qword_8CFEE20) & 1) != 0 )
      return v13;
    v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v7 = &qword_8D61C10;
  }
  else
  {
    v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v7 = &qword_8D81128;
  }
  v8 = v6;
  v9 = sub_74FE7A4(*v7, a0, 0);
  if ( v8 == 0 )
    goto LABEL_20;
  v10 = v9;
  if ( v9 != 0 )
  {
    v11 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v9, *(_QWORD *)(*(_QWORD *)v8 + 64LL));
    if ( v11 == 0 )
    {
LABEL_22:
      v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v11);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v12, 0);
      JUMPOUT(0x71670B0);
    }
  }
  if ( *(_DWORD *)(v8 + 24) == 0 )
  {
    v11 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_22;
  }
  *(_QWORD *)(v8 + 32) = v10;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Error(v8, 0);
  return nullptr;
}
