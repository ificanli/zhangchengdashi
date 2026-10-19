void *GameFramework_DataManagerPool__GetModel_object_(void *self, const MethodInfo *method)
{
  __int64 v2; // x8
  __int64 v5; // x21
  __int64 TypeFromHandle; // x21
  __int64 v7; // x0
  __int64 Item; // x20
  __int64 v9; // x1
  __int64 v10; // x20
  __int64 v11; // x19
  void *result; // x0
  __int64 v13; // x0
  __int64 v14; // x19
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x20
  __int64 v18; // x0
  __int64 v19; // x0

  v2 = *((_QWORD *)method + 7);
  if ( v2 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D79200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D877F8);
    v2 = *((_QWORD *)method + 7);
    if ( v2 == 0 )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v2 = *((_QWORD *)method + 7);
    }
  }
  v5 = *(_QWORD *)(v2 + 8);
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  if ( *((_QWORD *)self + 2) != 0
    && (System_Collections_Generic_Dictionary_object__object___ContainsKey(
          *((_QWORD *)self + 2),
          TypeFromHandle,
          qword_8D00178)
      & 1) != 0 )
  {
    v7 = *((_QWORD *)self + 2);
    if ( v7 == 0 )
      goto LABEL_26;
    Item = System_Collections_Generic_Dictionary_object__object___get_Item(v7, TypeFromHandle, qword_8D00188);
    v9 = **((_QWORD **)method + 7);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(**((_QWORD **)method + 7));
    v10 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(Item, v9);
    v11 = **((_QWORD **)method + 7);
    if ( (*(_BYTE *)(v11 + 309) & 1) == 0 )
      v11 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v11);
    if ( v10 == 0 )
      return nullptr;
    result = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v10, v11);
    if ( result != nullptr )
      return result;
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v10, v11);
  }
  v13 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( TypeFromHandle == 0
    || (v14 = v13,
        v15 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 776LL))(
                TypeFromHandle,
                *(_QWORD *)(*(_QWORD *)TypeFromHandle + 784LL)),
        v16 = sub_750A330(qword_8D877F8, v15, qword_8D79200, 0),
        v14 == 0) )
  {
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v17 = v16;
  if ( v16 != 0 )
  {
    v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
    if ( v18 == 0 )
    {
LABEL_28:
      v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v18);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v19, 0);
      JUMPOUT(0x4B987A4);
    }
  }
  if ( *(_DWORD *)(v14 + 24) == 0 )
  {
    v18 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_28;
  }
  *(_QWORD *)(v14 + 32) = v17;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Warning(v14, 0);
  return nullptr;
}
