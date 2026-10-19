__int64 __fastcall GameModule_RoleBehaviour__IsPathClear(
        __int64 a1,
        __int64 a2,
        long double a3,
        long double a4,
        long double a5)
{
  __int64 HexesFromPathPoints; // x0
  int v11; // w8
  __int64 v12; // x20
  __int64 result; // x0
  bool v14; // cf
  int v15; // w8
  unsigned int v16; // w21
  __int64 Item; // x0
  __int64 *v18; // x22
  __int64 *v19; // x0
  __int64 WallBetweenAdjacentHexes; // x22
  __int64 gameObject; // x0

  if ( (byte_8FFD494 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F830);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B530);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD494 = 1;
  }
  if ( a2 == 0 || *(_DWORD *)(a2 + 24) == 0 )
    return 1;
  HexesFromPathPoints = GameModule_RoleBehaviour__GetHexesFromPathPoints(a3, a4, a5, a1, a2);
  if ( HexesFromPathPoints == 0 )
LABEL_22:
    il2cpp_codegen_raise_null_reference_exception();
  v11 = *(_DWORD *)(HexesFromPathPoints + 24);
  v12 = HexesFromPathPoints;
  result = 1;
  v14 = v11 != 0;
  v15 = v11 - 1;
  if ( v14 && v15 >= 1 )
  {
    v16 = 0;
    while ( 1 )
    {
      Item = System_Collections_Generic_List_object___get_Item(v12, v16++, qword_8D0B530);
      v18 = (__int64 *)Item;
      v19 = (__int64 *)System_Collections_Generic_List_object___get_Item(v12, v16, qword_8D0B530);
      WallBetweenAdjacentHexes = GameModule_RoleBehaviour__GetWallBetweenAdjacentHexes((__int64)v19, v18, v19);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(WallBetweenAdjacentHexes, 0, 0) & 1) != 0 )
      {
        if ( WallBetweenAdjacentHexes == 0 )
          goto LABEL_22;
        if ( *(_BYTE *)(WallBetweenAdjacentHexes + 33) == 0 )
        {
          gameObject = UnityEngine_Component__get_gameObject(WallBetweenAdjacentHexes, 0);
          if ( gameObject == 0 )
            goto LABEL_22;
          if ( (UnityEngine_GameObject__get_activeSelf(gameObject, 0) & 1) != 0
            && *(unsigned __int8 *)(WallBetweenAdjacentHexes + 32) != *(unsigned __int8 *)(a1 + 32) )
          {
            return 0;
          }
        }
      }
      if ( (int)v16 >= *(_DWORD *)(v12 + 24) - 1 )
        return 1;
    }
  }
  return result;
}
