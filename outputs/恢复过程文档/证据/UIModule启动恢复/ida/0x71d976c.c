unsigned __int8 GameFramework_UIModule__wait2Fram_d__19__MoveNext(void *self, const MethodInfo *method)
{
  int v2; // w8
  __int64 v3; // x8

  v2 = *((_DWORD *)self + 4);
  if ( v2 == 2 )
  {
    v3 = *((_QWORD *)self + 4);
    *((_DWORD *)self + 4) = -1;
    if ( v3 == 0 )
      return v3;
    (*(void (__fastcall **)(_QWORD, _QWORD))(v3 + 24))(*(_QWORD *)(v3 + 64), *(_QWORD *)(v3 + 40));
LABEL_7:
    LOBYTE(v3) = 0;
    return v3;
  }
  if ( v2 == 1 )
  {
    *((_QWORD *)self + 3) = 0;
    *((_DWORD *)self + 4) = 2;
    LOBYTE(v3) = 1;
    return v3;
  }
  if ( v2 != 0 )
    goto LABEL_7;
  LOBYTE(v3) = 1;
  *((_QWORD *)self + 3) = 0;
  *((_DWORD *)self + 4) = 1;
  return v3;
}
