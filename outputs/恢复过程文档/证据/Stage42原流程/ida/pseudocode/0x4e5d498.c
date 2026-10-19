unsigned __int8 GameFramework_Procedure_ProcedureManager__HasProcedure_object__4e5d498(
        void *this,
        const MethodInfo *method)
{
  __int64 *v4; // x19
  __int64 v5; // x8
  __int64 v6; // x20
  __int64 v7; // x9
  __int64 v8; // x1
  __int64 v9; // x2
  _DWORD *v10; // x10
  __int64 v11; // x0
  __int64 v12; // x1
  unsigned __int8 result; // w0
  __int64 v14; // x0
  __int64 v15; // x19
  __int64 v16; // x0
  void *v17; // x0
  const MethodInfo *v18; // x1

  if ( *((_QWORD *)method + 7) == 0 )
    ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  v4 = *((__int64 **)this + 5);
  if ( v4 != nullptr )
  {
    v5 = *v4;
    v6 = **((_QWORD **)method + 7);
    v7 = *(unsigned __int16 *)(*v4 + 302);
    v8 = *(_QWORD *)(v6 + 32);
    v9 = *(unsigned __int16 *)(v6 + 80);
    if ( *(_WORD *)(*v4 + 302) != 0 )
    {
      v10 = (_DWORD *)(*(_QWORD *)(v5 + 176) + 8LL);
      while ( *((_QWORD *)v10 - 1) != v8 )
      {
        --v7;
        v10 += 4;
        if ( v7 == 0 )
          goto LABEL_8;
      }
      v11 = v5 + 16LL * (*v10 + (int)v9) + 312;
    }
    else
    {
LABEL_8:
      v11 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v4, v8, v9);
    }
    v12 = ((__int64 (__fastcall *)(_QWORD, __int64))unk_3C3D3AC)(*(_QWORD *)(v11 + 8), v6);
    return (*(unsigned __int8 (__fastcall **)(__int64 *, __int64))(v12 + 8))(v4, v12);
  }
  else
  {
    v14 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v14);
    v16 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D78218);
    GameFramework_GameFrameworkException___ctor(v15, v16, 0);
    v17 = (void *)((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v15, method);
    GameFramework_Procedure_ProcedureManager__StartProcedure_object__4e5d578(v17, v18);
  }
  return result;
}
