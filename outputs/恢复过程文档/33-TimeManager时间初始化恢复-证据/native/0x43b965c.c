__int64 L_Tools_ServerTimeMgr__GetServerTime(const MethodInfo *method)
{
  _QWORD *v1; // x0
  __int64 v2; // x20
  float realtimeSinceStartup; // s0
  __int64 v4; // x8
  unsigned __int64 v5; // x9
  int v6; // w10
  __int64 v7; // x8

  if ( (byte_90009BC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_90009BC = 1;
  }
  v1 = off_8CED280;
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CED280);
    v1 = off_8CED280;
  }
  v2 = *(_QWORD *)(v1[23] + 8LL);
  realtimeSinceStartup = UnityEngine_Time__get_realtimeSinceStartup(0);
  v4 = *((_QWORD *)off_8CED280 + 23);
  v5 = (int)realtimeSinceStartup;
  v6 = *(_DWORD *)(v4 + 28);
  v7 = *(_QWORD *)(v4 + 16);
  if ( realtimeSinceStartup == INFINITY )
    v5 = 0xFFFFFFFF80000000LL;
  return v2 - v7 + v5 + 3600 * v6;
}
