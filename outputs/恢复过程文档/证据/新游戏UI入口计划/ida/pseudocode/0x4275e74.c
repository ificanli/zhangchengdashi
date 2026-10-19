void UIFramework_UIManager__AddPanel(void *self, void *path, void *panel, const MethodInfo *method)
{
  __int64 name; // x0
  __int64 v8; // x0
  __int64 gameObject; // x0
  __int64 v10; // x0
  __int64 transform; // x0
  __int64 v12; // x19
  __int64 v13; // x1
  __int64 v14; // x2
  __int64 Instance; // x0
  __int64 UICamera; // x0
  __int64 v17; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFFFD5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D268C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF538);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12088);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D51FE8);
    byte_8FFFFD5 = 1;
  }
  v17 = 0;
  if ( panel == nullptr )
    goto LABEL_14;
  name = UnityEngine_Object__get_name(panel, 0);
  if ( name == 0 )
    goto LABEL_14;
  v8 = System_String__Replace(name, qword_8D51FE8, **((_QWORD **)off_8CEDAE8 + 23), 0);
  UnityEngine_Object__set_name(panel, v8, 0);
  gameObject = UnityEngine_Component__get_gameObject(panel, 0);
  if ( gameObject == 0 )
    goto LABEL_14;
  UnityEngine_GameObject__SetActive(gameObject, 0, 0);
  v10 = *((_QWORD *)self + 5);
  if ( v10 == 0 )
    goto LABEL_14;
  System_Collections_Generic_Dictionary_object__object___Add(v10, path, panel, qword_8CFF538);
  transform = UnityEngine_Component__get_transform(panel, 0);
  if ( transform == 0 )
    goto LABEL_14;
  if ( (UnityEngine_Component__TryGetComponent_object_(transform, &v17, qword_8D268C8) & 1) == 0 )
    return;
  if ( v17 == 0
    || (UnityEngine_Canvas__set_renderMode(v17, 1, 0),
        v12 = v17,
        (Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12088, v13, v14)) == 0)
    || (UICamera = CameraModule_CameraManager__get_UICamera(Instance, 0), v12 == 0) )
  {
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
  UnityEngine_Canvas__set_worldCamera(v12, UICamera, 0);
}
