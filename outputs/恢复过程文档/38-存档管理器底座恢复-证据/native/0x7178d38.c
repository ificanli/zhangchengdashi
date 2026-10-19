void *GameFramework_DataManagerPool__d____v(void *self, void *type, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x19
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v11; // x0
  __int64 v12; // x20
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x19
  __int64 v16; // x0

  if ( (byte_90091DA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7FF20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88630);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D77908);
    byte_90091DA = 1;
  }
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  if ( (System_Type__op_Equality(type, 0, 0) & 1) == 0 )
  {
    v8 = *((_QWORD *)self + 2);
    if ( v8 != 0
      && (System_Collections_Generic_Dictionary_object__object___ContainsKey(v8, type, qword_8D00178) & 1) != 0 )
    {
      v9 = *((_QWORD *)self + 2);
      if ( v9 != 0 )
        return (void *)System_Collections_Generic_Dictionary_object__object___get_Item(v9, type, qword_8D00188);
    }
    else
    {
      v11 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      if ( type != nullptr )
      {
        v12 = v11;
        v13 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)type + 776LL))(
                type,
                *(_QWORD *)(*(_QWORD *)type + 784LL));
        v14 = sub_750A330(qword_8D88630, v13, qword_8D7FF20, 0);
        if ( v12 != 0 )
        {
          v15 = v14;
          if ( v14 == 0
            || (v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v14, *(_QWORD *)(*(_QWORD *)v12 + 64LL))) != 0 )
          {
            if ( *(_DWORD *)(v12 + 24) > 1u )
            {
              *(_QWORD *)(v12 + 40) = v15;
              if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE5250);
              GameFramework_CLog___z___X(v12, 0);
              return nullptr;
            }
            goto LABEL_27;
          }
LABEL_28:
          v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v7);
          ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v16, 0);
          JUMPOUT(0x7178F80);
        }
      }
    }
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v5 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( v5 == 0 )
    goto LABEL_26;
  v6 = v5;
  if ( qword_8D77908 != 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D77908, *(_QWORD *)(*(_QWORD *)v5 + 64LL));
    if ( v7 == 0 )
      goto LABEL_28;
  }
  if ( *(_DWORD *)(v6 + 24) <= 1u )
  {
LABEL_27:
    v7 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_28;
  }
  *(_QWORD *)(v6 + 40) = qword_8D77908;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Error(v6, 0);
  return nullptr;
}
