__int64 __fastcall GameModule_BattleGameManager__ShowFoundEnemyPanel(__int64 a1, int a2)
{
  void *Instance; // x0
  __int64 result; // x0
  void *v5; // x20
  __int64 v6; // x21
  __int64 v7; // x0
  __int64 v8; // x19
  __int64 v9; // x0
  __int64 v10; // x0
  int v11; // [xsp+Ch] [xbp-34h] BYREF
  __int64 v12; // [xsp+18h] [xbp-28h] BYREF

  if ( (byte_8FFD731 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7C00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57448);
    byte_8FFD731 = 1;
  }
  v12 = 0;
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D124C8);
  if ( Instance == nullptr )
    goto LABEL_12;
  result = UIFramework_UIManager__IsPanelShowing(Instance, qword_8D57448, &v12, 0);
  if ( (result & 1) != 0 )
    return result;
  v5 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D124C8);
  v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v11 = a2;
  v7 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE7C00, &v11);
  if ( v6 == 0 )
LABEL_12:
    il2cpp_codegen_raise_null_reference_exception();
  v8 = v7;
  if ( v7 != 0 )
  {
    v9 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v7, *(_QWORD *)(*(_QWORD *)v6 + 64LL));
    if ( v9 == 0 )
    {
LABEL_14:
      v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v9);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v10, 0);
      JUMPOUT(0x3DE41CC);
    }
  }
  if ( *(_DWORD *)(v6 + 24) == 0 )
  {
    v9 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_14;
  }
  *(_QWORD *)(v6 + 32) = v8;
  if ( v5 == nullptr )
    goto LABEL_12;
  return UIFramework_UIManager__ShowPanel(v5, qword_8D57448, v6, 0);
}
