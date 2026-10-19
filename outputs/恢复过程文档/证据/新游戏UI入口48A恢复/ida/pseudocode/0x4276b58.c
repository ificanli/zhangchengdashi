void UIFramework_UIManager__HidePanel_d__13__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v4; // x0
  __int128 v5; // q0
  __int128 v6; // q0
  __int64 *v7; // x20
  unsigned int v8; // w21
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 v11; // x8
  __int64 v12; // x9
  int *v13; // x10
  __int64 v14; // x0
  __int64 v15; // x8
  __int64 *v16; // x19
  __int64 v17; // x8
  __int64 v18; // x9
  _DWORD *v19; // x10
  __int64 v20; // x0
  __int128 v21; // [xsp+8h] [xbp-78h] BYREF
  __int64 v22; // [xsp+18h] [xbp-68h]
  __int128 v23; // [xsp+20h] [xbp-60h]
  __int64 v24; // [xsp+30h] [xbp-50h]
  __int128 v25; // [xsp+40h] [xbp-40h] BYREF
  __int64 v26; // [xsp+50h] [xbp-30h]

  if ( (byte_8FFFFDF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF9A30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF9A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19A48);
    byte_8FFFFDF = 1;
  }
  v25 = 0u;
  v26 = 0;
  if ( *(_DWORD *)self != 0 )
  {
    v4 = *((_QWORD *)self + 3);
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UIFramework_UIManager__GetPanel(&v21, v4, *((_QWORD *)self + 4), v2);
    v23 = v21;
    v24 = v22;
    if ( (*(_BYTE *)(*((_QWORD *)off_8D19A48 + 4) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    v25 = v23;
    v26 = v24;
    if ( (((__int64 (__fastcall *)(__int128 *, __int64))unk_3D31494)(&v25, qword_8CF9A38) & 1) == 0 )
    {
      *(_DWORD *)self = 0;
      v5 = v25;
      *((_QWORD *)self + 7) = v26;
      *(_OWORD *)((char *)self + 40) = v5;
      ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_4289304)(
        (char *)self + 8,
        &v25,
        self,
        qword_8D1F170);
      return;
    }
  }
  else
  {
    v6 = *(_OWORD *)((char *)self + 40);
    v26 = *((_QWORD *)self + 7);
    v25 = v6;
    *((_QWORD *)self + 6) = 0;
    *((_QWORD *)self + 7) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
  }
  v7 = (__int64 *)v25;
  if ( (_QWORD)v25 != 0 )
  {
    v8 = (unsigned __int16)v26;
    v9 = *((_QWORD *)off_8CF9A30 + 4);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (*)(void))unk_3C503A0)();
    v10 = *(_QWORD *)(*(_QWORD *)(v9 + 192) + 40LL);
    if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
      v10 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v9 + 192) + 40LL));
    v11 = *v7;
    v12 = *(unsigned __int16 *)(*v7 + 302);
    if ( *(_WORD *)(*v7 + 302) != 0 )
    {
      v13 = (int *)(*(_QWORD *)(v11 + 176) + 8LL);
      while ( *((_QWORD *)v13 - 1) != v10 )
      {
        --v12;
        v13 += 4;
        if ( v12 == 0 )
          goto LABEL_19;
      }
      v14 = v11 + 16LL * *v13 + 312;
    }
    else
    {
LABEL_19:
      v14 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v7, v10, 0);
    }
    v15 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v14)(v7, v8, *(_QWORD *)(v14 + 8));
    if ( v15 == 0 )
      goto LABEL_25;
    goto LABEL_24;
  }
  v15 = *((_QWORD *)&v25 + 1);
  if ( *((_QWORD *)&v25 + 1) != 0 )
LABEL_24:
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v15 + 408LL))(v15, *(_QWORD *)(*(_QWORD *)v15 + 416LL));
LABEL_25:
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v16 = *((__int64 **)self + 1);
  if ( v16 != nullptr )
  {
    v17 = *v16;
    v18 = *(unsigned __int16 *)(*v16 + 302);
    if ( *(_WORD *)(*v16 + 302) != 0 )
    {
      v19 = (_DWORD *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != qword_8CE9038 )
      {
        --v18;
        v19 += 4;
        if ( v18 == 0 )
          goto LABEL_32;
      }
      v20 = v17 + 16LL * (*v19 + 2) + 312;
    }
    else
    {
LABEL_32:
      v20 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v16, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v20)(v16, *(_QWORD *)(v20 + 8));
  }
}
