void GameFramework_Procedure_ProcedureManager__StartProcedure_object__4e5d578(void *this, const MethodInfo *method)
{
  __int64 *v4; // x19
  _QWORD *v5; // x21
  __int64 v6; // x8
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x8
  __int64 v10; // x21
  __int64 v11; // x20
  __int64 v12; // x9
  __int64 v13; // x1
  __int64 v14; // x2
  _DWORD *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x2
  __int64 v18; // x0
  __int64 v19; // x19
  __int64 v20; // x0

  if ( *((_QWORD *)method + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    if ( *((_QWORD *)method + 7) == 0 )
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  }
  v4 = *((__int64 **)this + 5);
  if ( v4 == nullptr )
  {
    v18 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v18);
    v20 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D78218);
    GameFramework_GameFrameworkException___ctor(v19, v20, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v19, method);
    JUMPOUT(0x4E5D6C8);
  }
  v5 = off_8D1D5E8;
  v6 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v6 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v6 = v5[7];
  }
  v7 = *(_QWORD *)(v6 + 16);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v7 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v7);
  v8 = *(_QWORD *)(v5[7] + 16LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  v9 = *v4;
  v10 = **((_QWORD **)method + 7);
  v11 = **(_QWORD **)(v8 + 184);
  v12 = *(unsigned __int16 *)(*v4 + 302);
  v13 = *(_QWORD *)(v10 + 32);
  v14 = *(unsigned __int16 *)(v10 + 80);
  if ( *(_WORD *)(*v4 + 302) != 0 )
  {
    v15 = (_DWORD *)(*(_QWORD *)(v9 + 176) + 8LL);
    while ( *((_QWORD *)v15 - 1) != v13 )
    {
      --v12;
      v15 += 4;
      if ( v12 == 0 )
        goto LABEL_17;
    }
    v16 = v9 + 16LL * (*v15 + (int)v14) + 312;
  }
  else
  {
LABEL_17:
    v16 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v4, v13, v14);
  }
  v17 = ((__int64 (__fastcall *)(_QWORD, __int64))unk_3C3D3AC)(*(_QWORD *)(v16 + 8), v10);
  (*(void (__fastcall **)(__int64 *, __int64, __int64))(v17 + 8))(v4, v11, v17);
}
