__int64 __fastcall GameModule_BattleGameSceneManager__SetDestroyObjParent(__int64 a1, __int64 a2)
{
  __int64 transform; // x0
  __int64 v4; // x8
  __int64 v5; // x19
  __int64 v6; // x0

  if ( a2 == 0
    || (transform = UnityEngine_GameObject__get_transform(a2, 0), (v4 = *(_QWORD *)(a1 + 72)) == 0)
    || (v5 = transform, v6 = UnityEngine_GameObject__get_transform(v4, 0), v5 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  return sub_82F9798(v5, v6, 0, 0);
}
