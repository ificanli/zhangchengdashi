void GameModule_GameManager__ShowConfirmPanel(
        void *self,
        void *title,
        void *content,
        void *button,
        unsigned __int8 cancel,
        void *callback,
        const MethodInfo *method)
{
  __int64 Instance; // x20
  __int64 v13; // x0
  __int64 v14; // x21
  __int64 v15; // x0
  unsigned int v16; // w8
  __int64 v17; // x0
  __int64 v18; // x22
  unsigned int v19; // w8
  __int64 v20; // x0
  _BYTE v21[4]; // [xsp+Ch] [xbp-44h] BYREF

  if ( (byte_8FFD89B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4D90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57E60);
    byte_8FFD89B = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, title, content);
  v13 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 5);
  if ( v13 == 0 )
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  v14 = v13;
  if ( title != nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(title, *(_QWORD *)(*(_QWORD *)v13 + 64LL));
    if ( v15 == 0 )
      goto LABEL_25;
  }
  v16 = *(_DWORD *)(v14 + 24);
  if ( v16 == 0 )
    goto LABEL_24;
  *(_QWORD *)(v14 + 32) = title;
  if ( content != nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(content, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
    if ( v15 == 0 )
      goto LABEL_25;
    v16 = *(_DWORD *)(v14 + 24);
  }
  if ( v16 <= 1 )
  {
LABEL_24:
    v15 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_25;
  }
  *(_QWORD *)(v14 + 40) = content;
  if ( button != nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(button, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
    if ( v15 == 0 )
      goto LABEL_25;
    v16 = *(_DWORD *)(v14 + 24);
  }
  if ( v16 <= 2 )
    goto LABEL_24;
  *(_QWORD *)(v14 + 48) = button;
  v21[0] = cancel & 1;
  v17 = ((__int64 (__fastcall *)(void *, _BYTE *))unk_3C3D3B8)(off_8CE4D90, v21);
  v18 = v17;
  if ( v17 != 0 )
  {
    v15 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v17, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
    if ( v15 == 0 )
      goto LABEL_25;
  }
  v19 = *(_DWORD *)(v14 + 24);
  if ( v19 <= 3 )
    goto LABEL_24;
  *(_QWORD *)(v14 + 56) = v18;
  if ( callback != nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(callback, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
    if ( v15 != 0 )
    {
      v19 = *(_DWORD *)(v14 + 24);
      goto LABEL_21;
    }
LABEL_25:
    v20 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v15);
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v20, 0);
    goto LABEL_26;
  }
LABEL_21:
  if ( v19 <= 4 )
    goto LABEL_24;
  *(_QWORD *)(v14 + 64) = callback;
  if ( Instance == 0 )
    goto LABEL_26;
  UIFramework_UIManager__ShowPanel(Instance, qword_8D57E60, v14, 0);
}
