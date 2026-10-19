void *GameFramework_Fsm_FsmManager__GetAllFsms_7296f9c(void *this, const MethodInfo *method)
{
  __int64 v3; // x0
  unsigned int Count; // w0
  __int64 v5; // x0
  __int64 v6; // x9
  _DWORD *v7; // x19
  unsigned int v8; // w23
  __int64 v9; // x20
  __int64 v10; // x0
  _DWORD *v11; // x8
  __int64 v13; // x0
  __int128 v14; // [xsp+10h] [xbp-60h] BYREF
  __int128 v15; // [xsp+20h] [xbp-50h]
  __int64 v16; // [xsp+30h] [xbp-40h]

  if ( (byte_9009D2C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04BA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04BA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D04BB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2E98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07748);
    byte_9009D2C = 1;
  }
  v16 = 0;
  v14 = 0u;
  v15 = 0u;
  v3 = *((_QWORD *)this + 4);
  if ( v3 == 0 )
    goto LABEL_16;
  Count = System_Collections_Generic_Dictionary_object__object___get_Count(v3, qword_8CFE4F8);
  v5 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D320)(qword_8CE2E98, Count);
  v6 = *((_QWORD *)this + 4);
  if ( v6 == 0 )
    goto LABEL_16;
  v7 = (_DWORD *)v5;
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(&v14, v6, qword_8CFE4E0);
  v8 = 0;
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(&v14, qword_8D04BA8) & 1) != 0 )
  {
    if ( v7 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v9 = *((_QWORD *)&v15 + 1);
    if ( *((_QWORD *)&v15 + 1) != 0 )
    {
      v10 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
              *((_QWORD *)&v15 + 1),
              *(_QWORD *)(*(_QWORD *)v7 + 64LL));
      if ( v10 == 0 )
        goto LABEL_15;
    }
    if ( v8 >= v7[6] )
    {
      v10 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_15:
      v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v10);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v13, 0);
LABEL_16:
      il2cpp_codegen_raise_null_reference_exception();
    }
    v11 = &v7[2 * v8++];
    *((_QWORD *)v11 + 4) = v9;
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(&v14, qword_8D04BA0);
  return v7;
}
