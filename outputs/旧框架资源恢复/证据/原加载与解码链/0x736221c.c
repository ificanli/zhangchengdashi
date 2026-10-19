unsigned __int8 W_______IsDone(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 downloadHandler; // x0
  __int64 data; // x0
  char *v9; // x19
  __int64 v10; // t1
  __int64 v11; // x20
  char IsNullOrEmpty; // w0
  _QWORD *v13; // x8
  __int64 v14; // x0

  if ( (byte_900A6C1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D77EF0);
    byte_900A6C1 = 1;
  }
  v3 = *((_QWORD *)self + 3);
  if ( v3 == 0 )
    goto LABEL_16;
  if ( (UnityEngine_Networking_UnityWebRequest__get_isNetworkError(v3, 0) & 1) != 0 )
    return 1;
  v4 = *((_QWORD *)self + 3);
  if ( v4 == 0 )
    goto LABEL_16;
  if ( (UnityEngine_Networking_UnityWebRequest__get_isHttpError(v4, 0) & 1) != 0 )
    return 1;
  v5 = *((_QWORD *)self + 3);
  if ( v5 == 0 )
LABEL_16:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (UnityEngine_Networking_UnityWebRequest__get_isDone(v5, 0) & 1) != 0 )
  {
    v6 = *((_QWORD *)self + 3);
    if ( v6 != 0 )
    {
      downloadHandler = UnityEngine_Networking_UnityWebRequest__get_downloadHandler(v6, 0);
      if ( downloadHandler != 0 )
      {
        data = UnityEngine_Networking_DownloadHandler__get_data(downloadHandler, 0);
        v10 = *((_QWORD *)self + 4);
        v9 = (char *)self + 32;
        v11 = data;
        IsNullOrEmpty = System_String__IsNullOrEmpty(v10, 0);
        v13 = &unk_8D77EF0;
        if ( (IsNullOrEmpty & 1) == 0 )
          v13 = v9;
        v14 = Oke______dZ_x(v11, *v13, 0);
        *((_QWORD *)v9 - 2) = UnityEngine_AssetBundle__LoadFromMemory(v14, 0);
        return 1;
      }
    }
    goto LABEL_16;
  }
  return 0;
}
