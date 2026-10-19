void GameModule_BattleGameSceneManager__EnsureWebGLNavigationManager(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 transform; // x21
  __int64 v6; // x0
  __int64 v7; // x0

  if ( (byte_8FFD770 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D6E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D77950);
    byte_8FFD770 = 1;
  }
  if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4A38);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v3 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[304];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v3, 0, 0) & 1) != 0 )
    {
      v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
      UnityEngine_GameObject___ctor(v4, qword_8D77950, 0);
      if ( v4 == 0 )
        goto LABEL_16;
      transform = UnityEngine_GameObject__get_transform(v4, 0);
      v6 = UnityEngine_Component__get_transform(this, 0);
      if ( transform == 0 )
        goto LABEL_16;
      sub_82F9798(transform, v6, 0, 0);
      v7 = UnityEngine_GameObject__AddComponent_object_(v4, qword_8D2D6E8);
      *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[304] = v7;
    }
    else
    {
      v7 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[304];
    }
    if ( v7 != 0 )
    {
      GameModule_WebGLNavigationManager__Initialize(v7, this, 0);
      return;
    }
LABEL_16:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
