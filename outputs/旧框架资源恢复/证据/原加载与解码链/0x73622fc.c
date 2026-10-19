void W________ctor(void *self, void *path, void *extra, const MethodInfo *method)
{
  __int64 v7; // x0
  __int64 v8; // x20
  __int64 v9; // x21
  __int64 v10; // x0

  if ( (byte_900A6C2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE6B50);
    byte_900A6C2 = 1;
  }
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 4) = extra;
  v7 = UnityEngine_Networking_UnityWebRequest__Get(path, 0);
  *((_QWORD *)self + 3) = v7;
  v8 = v7;
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE6B50);
  UnityEngine_Networking_DownloadHandlerBuffer___ctor(v9, 0);
  if ( v8 == 0
    || (UnityEngine_Networking_UnityWebRequest__set_downloadHandler(v8, v9, 0), (v10 = *((_QWORD *)self + 3)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  UnityEngine_Networking_UnityWebRequest__SendWebRequest(v10, 0);
}
