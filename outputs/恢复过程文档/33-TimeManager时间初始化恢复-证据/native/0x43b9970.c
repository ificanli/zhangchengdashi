void L_Tools_ServerTimeMgr__ReceiveServerTime(void *self, void *args, const MethodInfo *method)
{
  _DWORD *v3; // x19
  __int64 v4; // x19
  float realtimeSinceStartup; // s0
  __int64 v6; // x8
  __int64 v7; // x9

  v3 = args;
  if ( (byte_90009C3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE95D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_90009C3 = 1;
  }
  if ( v3 == nullptr )
    goto LABEL_14;
  if ( v3[6] == 0 )
  {
    ((void (__fastcall *)(void *, void *, const MethodInfo *))unk_3C3D4D4)(self, args, method);
    goto LABEL_16;
  }
  v3 = *((_DWORD **)v3 + 4);
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CED280);
  if ( v3 == nullptr )
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_QWORD *)(*(_QWORD *)v3 + 64LL) != *((_QWORD *)off_8CE95D0 + 8) )
  {
LABEL_16:
    ((void (__fastcall *)(_DWORD *))unk_3C3D868)(v3);
    JUMPOUT(0x43B9AAC);
  }
  v4 = *(_QWORD *)((__int64 (__fastcall *)(_DWORD *))unk_3C3D3BC)(v3) / 1000LL;
  *(_QWORD *)(*((_QWORD *)off_8CED280 + 23) + 8LL) = v4;
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
  L_Tools_DateTools__UpdateTime(v4, nullptr);
  realtimeSinceStartup = UnityEngine_Time__get_realtimeSinceStartup(0);
  v6 = *((_QWORD *)off_8CED280 + 23);
  v7 = (__int64)realtimeSinceStartup;
  if ( realtimeSinceStartup == INFINITY )
    v7 = 0x8000000000000000LL;
  *(_QWORD *)(v6 + 16) = v7;
  *(_DWORD *)(v6 + 24) = 0;
  *(_BYTE *)v6 = 1;
}
