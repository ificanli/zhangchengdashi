void GameFramework_GameFrameEntry__W__C_____D__f(void *self, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x23
  __int64 v5; // x0
  _QWORD *v6; // x0
  _QWORD *v7; // x0
  __int64 v8; // x20

  if ( (byte_90090DD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3DC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7D40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECE50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6D0D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61448);
    byte_90090DD = 1;
  }
  if ( (System_String__IsNullOrEmpty(*((_QWORD *)self + 2), 0) & 1) == 0 )
  {
    v3 = off_8CE7B30;
    v4 = *((_QWORD *)self + 2);
    if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE7B30);
      v3 = off_8CE7B30;
    }
    *(_QWORD *)(v3[23] + 24LL) = v4;
  }
  sub_7185594(qword_8D6D0D0, 0);
  v5 = **((_QWORD **)off_8CE3DC0 + 23);
  if ( v5 != 0 )
    DBTSDK_AdsManager__HideBanner(v5, 0);
  v6 = off_8CE7B30;
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
    v6 = off_8CE7B30;
  }
  *(_BYTE *)(v6[23] + 32LL) = 0;
  v7 = off_8CE7D40;
  v8 = *((_QWORD *)self + 3);
  if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE7D40);
    v7 = off_8CE7D40;
  }
  *(_QWORD *)(v7[23] + 8LL) = v8;
  if ( *((_DWORD *)off_8CECE50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CECE50);
  UnityEngine_SceneManagement_SceneManager__LoadScene(qword_8D61448, 0);
}
