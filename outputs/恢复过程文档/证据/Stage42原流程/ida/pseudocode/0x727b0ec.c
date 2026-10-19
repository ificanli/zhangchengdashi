void *GameFramework_Procedure_ProcedureManager__GetProcedure_727b0ec(
        void *this,
        void *procedureType,
        const MethodInfo *method)
{
  __int64 *v5; // x20
  __int64 v6; // x8
  __int64 v7; // x9
  _DWORD *v8; // x10
  __int64 v9; // x0
  void *result; // x0
  __int64 v11; // x9
  __int64 v12; // x0
  __int64 v13; // x19
  __int64 v14; // x0
  __int64 v15; // x0

  if ( (byte_9009C38 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDC610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBE70);
    byte_9009C38 = 1;
  }
  v5 = *((__int64 **)this + 5);
  if ( v5 == nullptr )
  {
LABEL_15:
    v12 = ((__int64 (__fastcall *)(void *, void *, const MethodInfo *))unk_3C3D294)(&unk_8CE7B50, procedureType, method);
    v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v12);
    v14 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D78218);
    GameFramework_GameFrameworkException___ctor(v13, v14, 0);
    v15 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D36010);
    ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v13, v15);
    JUMPOUT(0x727B228);
  }
  v6 = *v5;
  v7 = *(unsigned __int16 *)(*v5 + 302);
  if ( *(_WORD *)(*v5 + 302) != 0 )
  {
    v8 = (_DWORD *)(*(_QWORD *)(v6 + 176) + 8LL);
    while ( *((_QWORD *)v8 - 1) != qword_8CDC610 )
    {
      --v7;
      v8 += 4;
      if ( v7 == 0 )
        goto LABEL_8;
    }
    v9 = v6 + 16LL * (*v8 + 13) + 312;
  }
  else
  {
LABEL_8:
    v9 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v5, qword_8CDC610, 13);
  }
  result = (void *)(*(__int64 (__fastcall **)(__int64 *, void *, _QWORD))v9)(v5, procedureType, *(_QWORD *)(v9 + 8));
  if ( result != nullptr )
  {
    v11 = *((unsigned __int8 *)off_8CEBE70 + 304);
    if ( *(unsigned __int8 *)(*(_QWORD *)result + 304LL) < (unsigned int)v11
      || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)result + 200LL) + 8 * v11 - 8) != off_8CEBE70 )
    {
      ((void (*)(void))unk_3C3D868)();
      goto LABEL_15;
    }
  }
  return result;
}
