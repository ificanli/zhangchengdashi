void UIFramework_UIManager__InitToCanvas(void *self, void *go, int layer, const MethodInfo *method)
{
  __int64 v6; // x21
  __int64 v7; // x21
  __int64 v8; // x22
  __int64 v9; // x1
  __int64 v10; // x2
  __int64 Instance; // x19
  __int64 v12; // x1
  __int64 v13; // x2
  __int64 v14; // x0
  __int64 UICamera; // x1

  if ( (byte_8FFFFDA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D2A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D290);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D3A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D590);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12088);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFFFDA = 1;
  }
  if ( go == nullptr )
    goto LABEL_25;
  UnityEngine_GameObject__set_layer(go, 5, 0, method);
  v6 = UnityEngine_GameObject__AddComponent_object_(go, qword_8D2D590);
  if ( byte_8FFCFFF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF390);
    byte_8FFCFFF = 1;
  }
  if ( v6 == 0 )
    goto LABEL_25;
  UnityEngine_RectTransform__set_anchorMin(
    v6,
    0,
    **((float **)off_8CEF390 + 23),
    *(float *)(*((_QWORD *)off_8CEF390 + 23) + 4LL));
  if ( byte_8FFD000 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF390);
    byte_8FFD000 = 1;
  }
  UnityEngine_RectTransform__set_anchorMax(
    v6,
    0,
    *(float *)(*((_QWORD *)off_8CEF390 + 23) + 8LL),
    *(float *)(*((_QWORD *)off_8CEF390 + 23) + 12LL));
  if ( byte_8FFCFFF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF390);
    byte_8FFCFFF = 1;
  }
  UnityEngine_RectTransform__set_anchoredPosition(
    v6,
    0,
    **((float **)off_8CEF390 + 23),
    *(float *)(*((_QWORD *)off_8CEF390 + 23) + 4LL));
  if ( byte_8FFCFFF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF390);
    byte_8FFCFFF = 1;
  }
  UnityEngine_RectTransform__set_sizeDelta(
    v6,
    0,
    **((float **)off_8CEF390 + 23),
    *(float *)(*((_QWORD *)off_8CEF390 + 23) + 4LL));
  if ( byte_8FFCFFD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFCFFD = 1;
  }
  UnityEngine_Transform__set_localPosition(
    v6,
    0,
    **((float **)off_8CEF3D8 + 23),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 4LL),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 8LL));
  if ( byte_8FFD01F == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFD01F = 1;
  }
  UnityEngine_Transform__set_localScale(
    v6,
    0,
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 12LL),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 16LL),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 20LL));
  v7 = UnityEngine_GameObject__AddComponent_object_(go, qword_8D2D290);
  v8 = UnityEngine_GameObject__AddComponent_object_(go, qword_8D2D2A8);
  UnityEngine_GameObject__AddComponent_object_(go, qword_8D2D3A0);
  if ( v7 == 0 )
    goto LABEL_25;
  UnityEngine_Canvas__set_renderMode(v7, 1, 0);
  UnityEngine_Canvas__set_sortingOrder(v7, (unsigned int)layer, 0);
  if ( v8 == 0 )
    goto LABEL_25;
  *(_DWORD *)(v8 + 32) = 1;
  UnityEngine_UI_CanvasScaler__set_referenceResolution(v8, 0, 1080.0, 2220.0);
  *(_DWORD *)(v8 + 52) = 1;
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12088, v9, v10);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Implicit(Instance, 0) & 1) != 0 )
  {
    v14 = ToolModule_ManagerBase_object___get_Instance(qword_8D12088, v12, v13);
    if ( v14 != 0 )
    {
      UICamera = CameraModule_CameraManager__get_UICamera(v14, 0);
      UnityEngine_Canvas__set_worldCamera(v7, UICamera, 0);
      return;
    }
LABEL_25:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
