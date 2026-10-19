void UIFramework_UIManager__ShowPanel(void *self, void *path, void *args, const MethodInfo *method)
{
  __int64 v4; // x4
  __int64 v5; // x5
  __int64 v6; // x6
  __int64 v7; // x7
  __int128 v11; // [xsp+0h] [xbp-90h] BYREF
  __int64 v12; // [xsp+10h] [xbp-80h]
  void *v13; // [xsp+18h] [xbp-78h]
  void *v14; // [xsp+20h] [xbp-70h]
  void *v15; // [xsp+28h] [xbp-68h]
  __int128 v16; // [xsp+30h] [xbp-60h]
  __int128 v17; // [xsp+40h] [xbp-50h]
  __int64 v18; // [xsp+50h] [xbp-40h]

  if ( (byte_8FFFFD7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D21050);
    byte_8FFFFD7 = 1;
  }
  v18 = 0;
  v11 = 0u;
  v12 = 0;
  v16 = 0u;
  v17 = 0u;
  v13 = path;
  v14 = self;
  v15 = args;
  LODWORD(v11) = -1;
  if ( *((_QWORD *)off_8D21050 + 7) == 0 )
    ((void (__fastcall *)(void *, void *, void *, const MethodInfo *, __int64, __int64, __int64, __int64, _QWORD, _QWORD, __int64))unk_3C503FC)(
      off_8D21050,
      path,
      args,
      method,
      v4,
      v5,
      v6,
      v7,
      v11,
      *((_QWORD *)&v11 + 1),
      v12);
  UIFramework_UIManager__ShowPanel_d__12__MoveNext(&v11, (const MethodInfo *)path);
  ((void (__fastcall *)(char *, _QWORD))unk_3D17780)((char *)&v11 + 8, 0);
}
