void GameModule_BattleGameSceneManager__DestroyRoleList(
        GameModule_BattleGameSceneManager_o *this,
        System_Collections_Generic_List_RoleBehaviour__o *roleList,
        const MethodInfo *method)
{
  int i; // w20
  __int64 Item; // x21
  void *Instance; // x0
  void *v7; // x22
  __int64 gameObject; // x0
  __int64 name; // x0
  __int64 v10; // x21
  __int64 v11; // [xsp+8h] [xbp-48h] BYREF

  if ( (byte_8FFD7B1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D26940);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7B1 = 1;
  }
  v11 = 0;
  if ( roleList == nullptr )
LABEL_19:
    il2cpp_codegen_raise_null_reference_exception();
  for ( i = *((_DWORD *)roleList + 6) - 1; i >= 0; --i )
  {
    Item = System_Collections_Generic_List_object___get_Item(roleList, (unsigned int)i, qword_8D0DDC8);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(Item, 0, 0) & 1) != 0 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12338);
      if ( Item == 0 )
        goto LABEL_19;
      v7 = Instance;
      gameObject = UnityEngine_Component__get_gameObject(Item, 0);
      if ( gameObject == 0 )
        goto LABEL_19;
      name = UnityEngine_Object__get_name(gameObject, 0);
      if ( v7 == nullptr )
        goto LABEL_19;
      if ( (AssetsModule_ObjPoolManager__IsBattlePersistentPool(v7, name, 0) & 1) != 0
        && (UnityEngine_Component__TryGetComponent_object_(Item, &v11, qword_8D26940) & 1) != 0 )
      {
        GameModule_RoleBehaviour__RecycleOnBattleEnd(Item, 0);
      }
      else
      {
        v10 = UnityEngine_Component__get_gameObject(Item, 0);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        UnityEngine_Object__Destroy(v10, 0);
      }
    }
  }
}
