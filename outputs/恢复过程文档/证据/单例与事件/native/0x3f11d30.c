void EventModule_EventManager__Init_d__2__MoveNext(void *self, const MethodInfo *method)
{
  __int64 *v3; // x19
  __int64 v4; // x8
  __int64 v5; // x9
  _DWORD *v6; // x10
  __int64 v7; // x0

  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v3 = *((__int64 **)self + 1);
  if ( v3 != nullptr )
  {
    v4 = *v3;
    v5 = *(unsigned __int16 *)(*v3 + 302);
    if ( *(_WORD *)(*v3 + 302) != 0 )
    {
      v6 = (_DWORD *)(*(_QWORD *)(v4 + 176) + 8LL);
      while ( *((_QWORD *)v6 - 1) != qword_8CE9038 )
      {
        --v5;
        v6 += 4;
        if ( v5 == 0 )
          goto LABEL_8;
      }
      v7 = v4 + 16LL * (*v6 + 2) + 312;
    }
    else
    {
LABEL_8:
      v7 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v3, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v7)(v3, *(_QWORD *)(v7 + 8));
  }
}
