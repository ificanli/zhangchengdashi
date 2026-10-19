void QuickTutor_Singleton_object____cctor(const MethodInfo *method)
{
  __int64 v2; // x0
  __int64 v3; // x0
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x8
  __int64 v7; // x21
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x8
  __int64 v11; // x20
  __int16 v12; // w9
  __int64 v13; // x0
  __int64 v14; // x22
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x0
  __int64 v18; // x8
  __int64 v19; // x21
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 v22; // x0

  v2 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v2 + 309) & 1) == 0 )
    v2 = ((__int64 (*)(void))unk_3C503A0)();
  v3 = *(_QWORD *)(*(_QWORD *)(v2 + 192) + 72LL);
  if ( (*(_BYTE *)(v3 + 309) & 1) == 0 )
    v3 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v3 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v3);
  v4 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (*)(void))unk_3C503A0)();
  v5 = *(_QWORD *)(*(_QWORD *)(v4 + 192) + 72LL);
  if ( (*(_BYTE *)(v5 + 309) & 1) == 0 )
    v5 = ((__int64 (*)(void))unk_3C503A0)();
  v6 = *((_QWORD *)method + 4);
  v7 = **(_QWORD **)(v5 + 184);
  if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
    v6 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
  v8 = *(_QWORD *)(*(_QWORD *)(v6 + 192) + 88LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v8);
  v10 = *((_QWORD *)method + 4);
  v11 = v9;
  v12 = *(_WORD *)(v10 + 309);
  if ( (v12 & 1) != 0 )
  {
    v13 = *((_QWORD *)method + 4);
  }
  else
  {
    v13 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
    v10 = *((_QWORD *)method + 4);
    v12 = *(_WORD *)(v10 + 309);
  }
  v14 = *(_QWORD *)(*(_QWORD *)(v13 + 192) + 80LL);
  if ( (v12 & 1) == 0 )
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v10);
  System_Func_object____ctor(v11, v7, v14, *(_QWORD *)(*(_QWORD *)(v10 + 192) + 96LL));
  v15 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
    v15 = ((__int64 (*)(void))unk_3C503A0)();
  v16 = *(_QWORD *)(*(_QWORD *)(v15 + 192) + 8LL);
  if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
    v16 = ((__int64 (*)(void))unk_3C503A0)();
  v17 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v16);
  v18 = *((_QWORD *)method + 4);
  v19 = v17;
  if ( (*(_BYTE *)(v18 + 309) & 1) == 0 )
    v18 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
  System_Lazy_object____ctor(v19, v11, *(_QWORD *)(*(_QWORD *)(v18 + 192) + 104LL));
  v20 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v20 + 309) & 1) == 0 )
    v20 = ((__int64 (*)(void))unk_3C503A0)();
  v21 = *(_QWORD *)(*(_QWORD *)(v20 + 192) + 16LL);
  if ( (*(_BYTE *)(v21 + 309) & 1) == 0 )
    v21 = ((__int64 (*)(void))unk_3C503A0)();
  **(_QWORD **)(v21 + 184) = v19;
  v22 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v22 + 309) & 1) == 0 )
    v22 = ((__int64 (*)(void))unk_3C503A0)();
  if ( (*(_BYTE *)(*(_QWORD *)(*(_QWORD *)(v22 + 192) + 16LL) + 309LL) & 1) == 0 )
    JUMPOUT(0x3C503A0);
}
