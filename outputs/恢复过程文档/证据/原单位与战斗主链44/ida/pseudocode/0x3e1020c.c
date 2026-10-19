void __fastcall GameModule_SynergyEffectManager__Init_d__1__MoveNext(__int64 a1)
{
  __int64 *v2; // x19
  __int64 v3; // x8
  __int64 v4; // x9
  _DWORD *v5; // x10
  __int64 v6; // x0

  *(_DWORD *)a1 = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v2 = *(__int64 **)(a1 + 8);
  if ( v2 != nullptr )
  {
    v3 = *v2;
    v4 = *(unsigned __int16 *)(*v2 + 302);
    if ( *(_WORD *)(*v2 + 302) != 0 )
    {
      v5 = (_DWORD *)(*(_QWORD *)(v3 + 176) + 8LL);
      while ( *((_QWORD *)v5 - 1) != qword_8CE9038 )
      {
        --v4;
        v5 += 4;
        if ( v4 == 0 )
          goto LABEL_8;
      }
      v6 = v3 + 16LL * (*v5 + 2) + 312;
    }
    else
    {
LABEL_8:
      v6 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v2, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v6)(v2, *(_QWORD *)(v6 + 8));
  }
}
