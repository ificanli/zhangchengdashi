__int64 __fastcall GameModule_BattleGameSceneManager__GetRoleTarget_d__207__MoveNext(__int64 a1)
{
  __int64 v2; // x19
  __int64 result; // x0
  __int64 *v4; // x21
  __int64 v5; // x0
  __int64 v6; // x1
  __int64 v7; // x8
  __int64 v8; // x9
  _DWORD *v9; // x10
  __int64 v10; // x0

  if ( (byte_8FFD7E7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF8EA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AC80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD780);
    byte_8FFD7E7 = 1;
  }
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD780);
  result = System_Collections_Generic_List_object____ctor(v2, qword_8D0AC80);
  v4 = *(__int64 **)(a1 + 8);
  *(_DWORD *)a1 = -2;
  if ( v4 != nullptr )
  {
    v5 = *((_QWORD *)off_8CF8EA0 + 4);
    if ( (*(_BYTE *)(v5 + 309) & 1) == 0 )
      v5 = ((__int64 (*)(void))unk_3C503A0)();
    v6 = *(_QWORD *)(*(_QWORD *)(v5 + 192) + 8LL);
    if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
      v6 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v5 + 192) + 8LL));
    v7 = *v4;
    v8 = *(unsigned __int16 *)(*v4 + 302);
    if ( *(_WORD *)(*v4 + 302) != 0 )
    {
      v9 = (_DWORD *)(*(_QWORD *)(v7 + 176) + 8LL);
      while ( *((_QWORD *)v9 - 1) != v6 )
      {
        --v8;
        v9 += 4;
        if ( v8 == 0 )
          goto LABEL_12;
      }
      v10 = v7 + 16LL * (*v9 + 2) + 312;
    }
    else
    {
LABEL_12:
      v10 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v4, v6, 2);
    }
    return (*(__int64 (__fastcall **)(__int64 *, __int64, _QWORD))v10)(v4, v2, *(_QWORD *)(v10 + 8));
  }
  else
  {
    *(_QWORD *)(a1 + 24) = v2;
  }
  return result;
}
