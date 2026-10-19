void UIFramework_UIPanel__Show_d__13__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x8
  void *Instance; // x21
  __int64 transform; // x0
  __int64 name; // x1
  __int64 gameObject; // x0
  __int64 Canvas; // x21
  __int64 v10; // x0
  __int64 v11; // x21
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x21
  __int64 v15; // x22
  __int64 *v16; // x19
  __int64 v17; // x8
  __int64 v18; // x9
  _DWORD *v19; // x10
  __int64 v20; // x0

  if ( (byte_8FFFFCF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEEA18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3BAF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3BC78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3C4C8);
    byte_8FFFFCF = 1;
  }
  v3 = *((_QWORD *)self + 3);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(v3 + 40) == 0 )
  {
    v4 = *(_QWORD *)(v3 + 56);
    if ( v4 != 0 && *(_BYTE *)(v4 + 56) != 0 )
    {
      if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1930);
      Instance = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D178A0);
      transform = UnityEngine_Component__get_transform(v3, 0);
      if ( transform == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      name = UnityEngine_Object__get_name(transform, 0);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      QuickTutor_TutorialManager__AddOneBlockTutorialTriggerKey(Instance, name, 0);
    }
    gameObject = UnityEngine_Component__get_gameObject(v3, 0);
    if ( gameObject == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_GameObject__SetActive(gameObject, 1, 0);
    Canvas = UIFramework_UIPanel__get_Canvas(v3);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(Canvas, 0, 0) & 1) != 0 )
    {
      v10 = UIFramework_UIPanel__get_Canvas(v3);
      if ( v10 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Behaviour__set_enabled(v10, 1, 0);
    }
    v11 = *(_QWORD *)(v3 + 32);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v11, 0, 0) & 1) != 0 )
    {
      v12 = *(_QWORD *)(v3 + 32);
      *(_BYTE *)(v3 + 40) = 1;
      v13 = DG_Tweening_ShortcutExtensions__DOScale(v12, 0, 1.0, 0.3);
      v14 = DG_Tweening_TweenSettingsExtensions__SetEase_object_(v13, 27, qword_8D3BC78);
      v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEEA18);
      DG_Tweening_TweenCallback___ctor(v15, v3, qword_8D3C4C8, 0);
      DG_Tweening_TweenSettingsExtensions__OnComplete_object_(v14, v15, qword_8D3BAF8);
    }
  }
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v16 = *((__int64 **)self + 1);
  if ( v16 != nullptr )
  {
    v17 = *v16;
    v18 = *(unsigned __int16 *)(*v16 + 302);
    if ( *(_WORD *)(*v16 + 302) != 0 )
    {
      v19 = (_DWORD *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != qword_8CE9038 )
      {
        --v18;
        v19 += 4;
        if ( v18 == 0 )
          goto LABEL_29;
      }
      v20 = v17 + 16LL * (*v19 + 2) + 312;
    }
    else
    {
LABEL_29:
      v20 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v16, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v20)(v16, *(_QWORD *)(v20 + 8));
  }
}
