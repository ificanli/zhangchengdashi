void __fastcall GameModule_RoleBehaviour__SkillUpdate(__int64 a1)
{
  _BYTE **v2; // x0
  float v3; // s8

  if ( (byte_8FFD478 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    byte_8FFD478 = 1;
  }
  if ( *(_DWORD *)(a1 + 316) == 6 && *(float *)(a1 + 292) != 0.0 )
  {
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
    if ( byte_8FFD1AB == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
      byte_8FFD1AB = 1;
    }
    v2 = (_BYTE **)off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      v2 = (_BYTE **)off_8CE5E20;
    }
    if ( *v2[23] != 0 && *(_BYTE *)(a1 + 300) == 0 )
    {
      v3 = *(float *)(a1 + 296);
      if ( v3 < UnityEngine_Time__get_time(0) )
        *(_BYTE *)(a1 + 300) = 1;
    }
  }
}
