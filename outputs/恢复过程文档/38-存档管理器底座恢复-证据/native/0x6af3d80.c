void DbtSaveDataManagerBase_object__object___OnInit(void *self, const MethodInfo *method)
{
  __int64 v4; // x1
  __int64 v5; // x23
  __int64 v6; // x22
  __int64 v7; // x21
  __int64 v8; // x8
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 v11; // x22
  __int64 v12; // x21
  __int64 v13; // x20
  __int64 TypeFromHandle; // x0
  __int64 v15; // x0
  __int64 v16; // x8
  __int64 v17; // x0
  __int64 v18; // x8

  if ( (byte_9007B6C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D69B90);
    byte_9007B6C = 1;
  }
  DbtSaveDataManagerBase_object__object___Log(self, 0, qword_8D69B90);
  v4 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL);
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL));
  v5 = ((__int64 (__fastcall *)(void *, __int64))unk_3C3D3B4)(self, v4);
  v6 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL);
  if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
    v6 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL));
  if ( v5 != 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v5, v6);
    if ( v7 != 0 )
      goto LABEL_11;
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v5, v6);
  }
  v7 = 0;
LABEL_11:
  v8 = *(_QWORD *)(*((_QWORD *)method + 4) + 192LL);
  v9 = *(_QWORD *)(v8 + 32);
  if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
  {
    v9 = ((__int64 (*)(void))unk_3C503A0)();
    v8 = *(_QWORD *)(*((_QWORD *)method + 4) + 192LL);
  }
  **(_QWORD **)(v9 + 184) = v7;
  if ( (*(_BYTE *)(*(_QWORD *)(v8 + 32) + 309LL) & 1) == 0 )
  {
    ((void (*)(void))unk_3C503A0)();
    v8 = *(_QWORD *)(*((_QWORD *)method + 4) + 192LL);
  }
  v10 = *(_QWORD *)(v8 + 24);
  if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v10);
  v11 = ((__int64 (__fastcall *)(void *, __int64))unk_3C3D3B4)(self, v10);
  v12 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL);
  if ( (*(_BYTE *)(v12 + 309) & 1) == 0 )
    v12 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL));
  if ( v11 != 0 && ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v11, v12) == 0 )
  {
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v11, v12);
    JUMPOUT(0x6AF3F6C);
  }
  v13 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL);
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v13, 0);
  if ( TypeFromHandle == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v15 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 440LL))(
          TypeFromHandle,
          *(_QWORD *)(*(_QWORD *)TypeFromHandle + 448LL));
  v16 = *(_QWORD *)self;
  *((_QWORD *)self + 5) = v15;
  v17 = (*(__int64 (__fastcall **)(void *, _QWORD))(v16 + 456))(self, *(_QWORD *)(v16 + 464));
  v18 = *(_QWORD *)self;
  *((_QWORD *)self + 7) = v17;
  (*(void (__fastcall **)(void *, _QWORD, _QWORD))(v18 + 472))(self, 0, *(_QWORD *)(v18 + 480));
}
