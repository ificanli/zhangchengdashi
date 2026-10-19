void L_Tools_ServerTimeMgr__UpdateCheck(void *self, const MethodInfo *method)
{
  float v3; // s8
  __int64 v4; // x1
  float unscaledDeltaTime; // s0
  float v6; // s1
  float v7; // s0
  __int64 ServerTime; // x20
  float v9; // s8
  __int64 v10; // x0
  float v11; // s0
  float v12; // s1
  float v13; // s0

  if ( (byte_90009BB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_90009BB = 1;
  }
  v3 = *((float *)self + 18);
  unscaledDeltaTime = UnityEngine_Time__get_unscaledDeltaTime(0, method);
  v6 = *((float *)self + 17);
  v7 = v3 + unscaledDeltaTime;
  *((float *)self + 18) = v7;
  if ( v7 >= v6 )
  {
    *((float *)self + 18) = v7 + -1.0;
    if ( *((_DWORD *)off_8CED280 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CED280);
    ServerTime = L_Tools_ServerTimeMgr__GetServerTime();
    if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64C0);
    L_Tools_DateTools__UpdateTime(ServerTime, nullptr);
  }
  v9 = *((float *)self + 15);
  v11 = UnityEngine_Time__get_unscaledDeltaTime(0, v4);
  v12 = *((float *)self + 14);
  v13 = v9 + v11;
  *((float *)self + 15) = v13;
  if ( v13 >= v12 )
  {
    L_Tools_ServerTimeMgr__GetCurrentServerTime(v10);
    *((_DWORD *)self + 15) = 0;
  }
}
