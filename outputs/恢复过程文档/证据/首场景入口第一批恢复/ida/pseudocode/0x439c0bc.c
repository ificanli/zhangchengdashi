unsigned __int8 ljzs_lt_GameStart__OpenLoadingUI_d__4__MoveNext(void *self, const MethodInfo *method)
{
  int v3; // w8
  __int64 v5; // x8
  int v6; // [xsp+Ch] [xbp-14h] BYREF

  if ( (byte_900088D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6AAC0);
    byte_900088D = 1;
  }
  v3 = *((_DWORD *)self + 4);
  if ( v3 == 1 )
  {
    v5 = *((_QWORD *)self + 4);
    *((_DWORD *)self + 4) = -1;
    if ( v5 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD))(v5 + 24))(*(_QWORD *)(v5 + 64), *(_QWORD *)(v5 + 40));
  }
  else if ( v3 == 0 )
  {
    *((_DWORD *)self + 4) = -1;
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__Log(qword_8D6AAC0, 0);
    v6 = 0;
    *((_QWORD *)self + 3) = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v6);
    *((_DWORD *)self + 4) = 1;
    return 1;
  }
  return 0;
}
