void GameModule_GameManager__Init(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v3; // x3
  __int64 v4; // x4
  __int64 v5; // x5
  _DWORD v7[6]; // [xsp+0h] [xbp-50h] BYREF
  void *v8; // [xsp+18h] [xbp-38h]
  __int128 v9; // [xsp+20h] [xbp-30h]

  if ( (byte_8FFD890 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D203B0);
    byte_8FFD890 = 1;
  }
  memset(v7, 0, sizeof(v7));
  v9 = 0u;
  v8 = self;
  v7[0] = -1;
  if ( *((_QWORD *)off_8D203B0 + 7) == 0 )
    ((void (__fastcall *)(void *, const MethodInfo *, __int64, __int64, __int64, __int64))unk_3C503FC)(
      off_8D203B0,
      method,
      v2,
      v3,
      v4,
      v5);
  GameModule_GameManager__Init_d__9__MoveNext(v7, method);
  ((void (__fastcall *)(_DWORD *, _QWORD))unk_3D17780)(&v7[2], 0);
}
