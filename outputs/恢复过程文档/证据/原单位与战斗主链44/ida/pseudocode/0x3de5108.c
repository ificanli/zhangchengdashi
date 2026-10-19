void __fastcall GameModule_BattleGameManager__Update(__int64 a1, __int64 a2)
{
  float v2; // s8

  if ( *(_BYTE *)(a1 + 80) != 0 && *(_BYTE *)(a1 + 100) != 0 )
  {
    v2 = *(float *)(a1 + 104);
    if ( v2 > 0.0 )
      *(float *)(a1 + 104) = v2 - UnityEngine_Time__get_deltaTime(0, a2);
  }
}
