unsigned __int8 ToolModule_ListExtend__IsNullOrEmpty_byte_(void *input, const MethodInfo *method)
{
  __int64 v4; // x1
  __int64 v5; // x8
  __int64 v6; // x9
  int *v7; // x10
  __int64 v8; // x0

  if ( *((_QWORD *)method + 7) == 0 )
  {
    ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
    if ( input != nullptr )
      goto LABEL_3;
    return 1;
  }
  if ( input == nullptr )
    return 1;
LABEL_3:
  v4 = *(_QWORD *)(*((_QWORD *)method + 7) + 8LL);
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*((_QWORD *)method + 7) + 8LL));
  v5 = *(_QWORD *)input;
  v6 = *(unsigned __int16 *)(*(_QWORD *)input + 302LL);
  if ( *(_WORD *)(*(_QWORD *)input + 302LL) != 0 )
  {
    v7 = (int *)(*(_QWORD *)(v5 + 176) + 8LL);
    while ( *((_QWORD *)v7 - 1) != v4 )
    {
      --v6;
      v7 += 4;
      if ( v6 == 0 )
        goto LABEL_9;
    }
    v8 = v5 + 16LL * *v7 + 312;
  }
  else
  {
LABEL_9:
    v8 = ((__int64 (__fastcall *)(void *, __int64, _QWORD))unk_3C504A4)(input, v4, 0);
  }
  return (*(unsigned int (__fastcall **)(void *, _QWORD))v8)(input, *(_QWORD *)(v8 + 8)) == 0;
}
