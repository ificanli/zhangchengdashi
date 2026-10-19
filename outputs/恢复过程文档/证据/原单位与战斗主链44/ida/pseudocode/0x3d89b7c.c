__int64 __fastcall GameModule_RoleBehaviour__FindFirstEnemyWallInPath(
        __int64 a1,
        __int64 a2,
        long double a3,
        long double a4,
        long double a5,
        float a6)
{
  __int64 HexesFromPathPoints; // x0
  __int64 v13; // x20
  unsigned int v14; // w21
  __int64 Item; // x0
  __int64 v16; // x23
  __int64 v17; // x0
  __int64 WallBetweenAdjacentHexes; // x23
  __int64 gameObject; // x0
  __int64 transform; // x0
  float v21; // s11
  __int64 v22; // x0
  float v23; // s2
  float v24; // s12

  if ( (byte_8FFD48E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F830);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B530);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD48E = 1;
  }
  if ( a2 == 0 )
    return 0;
  if ( *(_DWORD *)(a2 + 24) == 0 )
    return 0;
  HexesFromPathPoints = GameModule_RoleBehaviour__GetHexesFromPathPoints(a1, a2, a3, a4, a5);
  if ( HexesFromPathPoints == 0 )
    return 0;
  v13 = HexesFromPathPoints;
  if ( *(int *)(HexesFromPathPoints + 24) < 2 )
    return 0;
  v14 = 0;
  while ( 1 )
  {
    Item = System_Collections_Generic_List_object___get_Item(v13, v14++, qword_8D0B530);
    v16 = Item;
    v17 = System_Collections_Generic_List_object___get_Item(v13, v14, qword_8D0B530);
    WallBetweenAdjacentHexes = GameModule_RoleBehaviour__GetWallBetweenAdjacentHexes(v17, v16, v17);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(WallBetweenAdjacentHexes, 0, 0) & 1) != 0 )
    {
      if ( WallBetweenAdjacentHexes == 0 )
        goto LABEL_26;
      if ( *(_BYTE *)(WallBetweenAdjacentHexes + 33) == 0 )
      {
        gameObject = UnityEngine_Component__get_gameObject(WallBetweenAdjacentHexes, 0);
        if ( gameObject == 0 )
          goto LABEL_26;
        if ( (UnityEngine_GameObject__get_activeSelf(gameObject, 0) & 1) != 0
          && *(unsigned __int8 *)(WallBetweenAdjacentHexes + 32) != *(unsigned __int8 *)(a1 + 32) )
        {
          transform = UnityEngine_Component__get_transform(WallBetweenAdjacentHexes, 0);
          if ( transform == 0
            || (LODWORD(v21) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0)),
                (v22 = UnityEngine_Component__get_transform(WallBetweenAdjacentHexes, 0)) == 0) )
          {
LABEL_26:
            il2cpp_codegen_raise_null_reference_exception();
          }
          UnityEngine_Transform__get_position(v22, 0);
          v24 = v23;
          if ( byte_8FFD4B7 == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
            byte_8FFD4B7 = 1;
          }
          if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEA738);
          if ( sqrtf(
                 (float)((float)(*(float *)&a3 - v21) * (float)(*(float *)&a3 - v21))
               + (float)((float)(*(float *)&a5 - v24) * (float)(*(float *)&a5 - v24))) <= a6 )
            return WallBetweenAdjacentHexes;
        }
      }
    }
    if ( (int)v14 >= *(_DWORD *)(v13 + 24) - 1 )
      return 0;
  }
}
