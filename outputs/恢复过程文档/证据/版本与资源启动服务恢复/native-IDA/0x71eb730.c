__int64 __fastcall GameFramework_VersionMondule__InitForNewRes(__int64 a1)
{
  __int64 Instance; // x19
  __int64 v3; // x0

  Instance = UpdateManager__get_Instance(0);
  v3 = GameFramework_VersionMondule__Init(a1);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return UnityEngine_MonoBehaviour__StartCoroutine(Instance, v3, 0);
}
