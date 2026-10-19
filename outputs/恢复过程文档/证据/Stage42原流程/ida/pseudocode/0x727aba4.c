void *GameFramework_Procedure_ProcedureManager__get_CurrentProcedure_727aba4(void *this, const MethodInfo *method)
{
  __int64 *v3; // x19
  __int64 v4; // x8
  __int64 v5; // x9
  _DWORD *v6; // x10
  __int64 v7; // x0
  void *result; // x0
  __int64 v9; // x9
  __int64 v10; // x0
  __int64 v11; // x19
  __int64 v12; // x0
  __int64 v13; // x0

  if ( (byte_9009C33 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDC610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBE70);
    byte_9009C33 = 1;
  }
  v3 = *((__int64 **)this + 5);
  if ( v3 == nullptr )
  {
LABEL_15:
    v10 = ((__int64 (__fastcall *)(void *, const MethodInfo *))unk_3C3D294)(&unk_8CE7B50, method);
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v10);
    v12 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D78218);
    GameFramework_GameFrameworkException___ctor(v11, v12, 0);
    v13 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D36030);
    ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v11, v13);
    JUMPOUT(0x727ACD8);
  }
  v4 = *v3;
  v5 = *(unsigned __int16 *)(*v3 + 302);
  if ( *(_WORD *)(*v3 + 302) != 0 )
  {
    v6 = (_DWORD *)(*(_QWORD *)(v4 + 176) + 8LL);
    while ( *((_QWORD *)v6 - 1) != qword_8CDC610 )
    {
      --v5;
      v6 += 4;
      if ( v5 == 0 )
        goto LABEL_8;
    }
    v7 = v4 + 16LL * (*v6 + 6) + 312;
  }
  else
  {
LABEL_8:
    v7 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v3, qword_8CDC610, 6);
  }
  result = (void *)(*(__int64 (__fastcall **)(__int64 *, _QWORD))v7)(v3, *(_QWORD *)(v7 + 8));
  if ( result != nullptr )
  {
    v9 = *((unsigned __int8 *)off_8CEBE70 + 304);
    if ( *(unsigned __int8 *)(*(_QWORD *)result + 304LL) < (unsigned int)v9
      || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)result + 200LL) + 8 * v9 - 8) != off_8CEBE70 )
    {
      ((void (*)(void))unk_3C3D868)();
      goto LABEL_15;
    }
  }
  return result;
}
