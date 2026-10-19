void TimeModuleO_TimeManager__InitializeTimeSource(void *self, void *method)
{
  _QWORD *v3; // x20
  __int64 v4; // x8
  _DWORD v5[6]; // [xsp+0h] [xbp-50h] BYREF
  void *v6; // [xsp+18h] [xbp-38h]
  __int128 v7; // [xsp+20h] [xbp-30h]

  if ( (byte_8FFD9EC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D20F70);
    byte_8FFD9EC = 1;
  }
  v3 = off_8D20F70;
  memset(v5, 0, sizeof(v5));
  v7 = 0u;
  v6 = self;
  v5[0] = -1;
  v4 = *((_QWORD *)off_8D20F70 + 7);
  if ( v4 == 0 )
  {
    ((void (__fastcall *)(void *, void *))unk_3C503FC)(off_8D20F70, method);
    v4 = v3[7];
  }
  TimeModuleO_TimeManager__InitializeTimeSource_d__31__MoveNext(v5, *(_QWORD *)(v4 + 16));
  ((void (__fastcall *)(_DWORD *, _QWORD))unk_3D17780)(&v5[2], 0);
}
