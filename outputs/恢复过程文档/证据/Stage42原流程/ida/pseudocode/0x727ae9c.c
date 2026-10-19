void GameFramework_Procedure_ProcedureManager__StartProcedure_727ae9c(
        void *this,
        void *procedureType,
        const MethodInfo *method)
{
  __int64 *v5; // x20
  _QWORD *v6; // x21
  __int64 v7; // x8
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x8
  __int64 v11; // x21
  __int64 v12; // x9
  _DWORD *v13; // x10
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x19
  __int64 v17; // x0
  __int64 v18; // x0

  if ( (byte_9009C36 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDC610);
    byte_9009C36 = 1;
  }
  v5 = *((__int64 **)this + 5);
  if ( v5 == nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *, void *, const MethodInfo *))unk_3C3D294)(&unk_8CE7B50, procedureType, method);
    v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v15);
    v17 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D78218);
    GameFramework_GameFrameworkException___ctor(v16, v17, 0);
    v18 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D36028);
    ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v16, v18);
    JUMPOUT(0x727AFFC);
  }
  v6 = off_8D1D5E8;
  v7 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v7 == 0 )
  {
    ((void (__fastcall *)(void *, void *, const MethodInfo *))unk_3C503FC)(off_8D1D5E8, procedureType, method);
    v7 = v6[7];
  }
  v8 = *(_QWORD *)(v7 + 16);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v8 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v8);
  v9 = *(_QWORD *)(v6[7] + 16LL);
  if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
    v9 = ((__int64 (*)(void))unk_3C503A0)();
  v10 = *v5;
  v11 = **(_QWORD **)(v9 + 184);
  v12 = *(unsigned __int16 *)(*v5 + 302);
  if ( *(_WORD *)(*v5 + 302) != 0 )
  {
    v13 = (_DWORD *)(*(_QWORD *)(v10 + 176) + 8LL);
    while ( *((_QWORD *)v13 - 1) != qword_8CDC610 )
    {
      --v12;
      v13 += 4;
      if ( v12 == 0 )
        goto LABEL_16;
    }
    v14 = v10 + 16LL * (*v13 + 9) + 312;
  }
  else
  {
LABEL_16:
    v14 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v5, qword_8CDC610, 9);
  }
  (*(void (__fastcall **)(__int64 *, void *, __int64, _QWORD))v14)(v5, procedureType, v11, *(_QWORD *)(v14 + 8));
}
