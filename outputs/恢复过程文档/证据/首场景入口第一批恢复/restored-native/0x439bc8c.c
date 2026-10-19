void ljzs_lt_GameStart__InitPatchManager(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x0
  __int64 started; // x1

  if ( (byte_9000888 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2F568);
    byte_9000888 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CE3CE0, method);
  v4 = System_Action___ctor(v3, self, qword_8D2F568, 0);
  started = ljzs_lt_GameStart__OpenLoadingUI(v4, v3);
  UnityEngine_MonoBehaviour__StartCoroutine(self, started, 0);
}
