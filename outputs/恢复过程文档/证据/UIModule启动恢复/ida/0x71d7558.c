void GameFramework_UIModule__Initialize(void *self, void *args, const MethodInfo *method)
{
  __int64 v4; // x8
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 GameObjectWithTag; // x0
  __int64 v9; // x20
  __int64 v10; // x20
  char v11; // w0
  __int64 gameObject; // x20
  __int64 v13; // x0
  __int64 transform; // x0
  __int64 v15; // x0
  __int64 Component_object; // x0
  __int64 v17; // x20
  _QWORD *v18; // x0
  __int64 v19; // x20
  _QWORD *v20; // x19
  __int64 v21; // x8
  __int64 v22; // x0
  __int64 v23; // x0
  void *Module_object; // x20
  __int64 v25; // x21
  void *v26; // x0
  __int64 v27; // x0

  if ( (byte_90095D5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF5080);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3C490);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3C498);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87030);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D758A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60E60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D75880);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D747D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D747C8);
    byte_90095D5 = 1;
  }
  if ( *((_BYTE *)self + 16) != 0 )
  {
    v4 = *((_QWORD *)self + 3);
    if ( v4 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD))(v4 + 24))(*(_QWORD *)(v4 + 64), *(_QWORD *)(v4 + 40));
    return;
  }
  v5 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D320)(qword_8CE3258, 1, method);
  if ( v5 == 0 )
LABEL_58:
    il2cpp_codegen_raise_null_reference_exception();
  v6 = v5;
  if ( qword_8D87030 != 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D87030, *(_QWORD *)(*(_QWORD *)v5 + 64LL));
    if ( v7 == 0 )
    {
LABEL_60:
      v27 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v7);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v27, 0);
      JUMPOUT(0x71D7A38);
    }
  }
  if ( *(_DWORD *)(v6 + 24) == 0 )
  {
    v7 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_60;
  }
  *(_QWORD *)(v6 + 32) = qword_8D87030;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__ReleaseLog(v6, 0);
  GameObjectWithTag = UnityEngine_GameObject__FindGameObjectWithTag(qword_8D60E60, 0);
  *((_QWORD *)self + 4) = GameObjectWithTag;
  v9 = GameObjectWithTag;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v9, 0, 0) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(qword_8D75880, 0);
  }
  v10 = *((_QWORD *)self + 4);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v11 = UnityEngine_Object__op_Inequality(v10, 0, 0);
  gameObject = 0;
  if ( (v11 & 1) != 0 )
  {
    v13 = *((_QWORD *)self + 4);
    if ( v13 == 0 )
      goto LABEL_58;
    transform = UnityEngine_GameObject__get_transform(v13, 0);
    if ( transform == 0 )
      goto LABEL_58;
    v15 = UnityEngine_Transform__Find(transform, qword_8D747D8, 0);
    if ( v15 == 0 )
      goto LABEL_58;
    gameObject = UnityEngine_Component__get_gameObject(v15, 0);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(gameObject, 0, 0) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(qword_8D758A8, 0);
  }
  if ( gameObject != 0 )
    Component_object = UnityEngine_GameObject__GetComponent_object_(gameObject, qword_8D2D838);
  else
    Component_object = 0;
  *((_QWORD *)self + 6) = Component_object;
  v17 = *((_QWORD *)self + 4);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  UnityEngine_Object__DontDestroyOnLoad(v17, 0);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v18 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v18 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v18[23] + 56LL) == 0 )
  {
    if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7B30);
    Module_object = GameFramework_GameFrameEntry__GetModule_object_((const MethodInfo *)qword_8D2D180);
    v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF5080);
    GameFramework_Resources_ResourcesModule_LoadAssetCompleteHandler___ctor(v25, self, qword_8D3C498, 0);
    if ( Module_object != nullptr )
    {
      GameFramework_Resources_ResourcesModule__LoadPrefab(Module_object, qword_8D747C8, v25, 0, 0);
      v26 = GameFramework_GameFrameEntry__GetModule_object_((const MethodInfo *)qword_8D2D180);
      if ( v26 != nullptr )
      {
        (*(void (__fastcall **)(void *, _QWORD, float, float))(*(_QWORD *)v26 + 424LL))(
          v26,
          *(_QWORD *)(*(_QWORD *)v26 + 432LL),
          0.0,
          0.0);
        return;
      }
    }
    goto LABEL_58;
  }
  v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8338);
  System_Action_object____ctor(v19, self, qword_8D3C490, 0);
  v20 = off_8D1D5E8;
  v21 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v21 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v21 = v20[7];
  }
  v22 = *(_QWORD *)(v21 + 16);
  if ( (*(_BYTE *)(v22 + 309) & 1) == 0 )
    v22 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v22 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v22);
  v23 = *(_QWORD *)(v20[7] + 16LL);
  if ( (*(_BYTE *)(v23 + 309) & 1) == 0 )
    v23 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_NewResLoadHelper__LoadPrefabOri(qword_8D747C8, v19, **(_QWORD **)(v23 + 184), 0);
}
