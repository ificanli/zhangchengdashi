void LoadingModule_LoadingManager__StartLoading(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 Component_object; // x0
  __int64 v5; // x10
  __int64 v6; // x20
  __int64 v7; // x20
  _QWORD *v8; // x21
  __int64 v9; // x8
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x1

  if ( (byte_8FFEDC5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DCA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9FE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66480);
    byte_8FFEDC5 = 1;
  }
  v3 = UnityEngine_GameObject__Find(qword_8D66480, 0);
  if ( v3 == 0 )
    goto LABEL_26;
  Component_object = UnityEngine_GameObject__GetComponent_object_(v3, qword_8D2DCA0);
  *((_QWORD *)self + 4) = Component_object;
  if ( Component_object != 0
    && (v5 = *((unsigned __int8 *)off_8CE9FE0 + 304),
        *(unsigned __int8 *)(*(_QWORD *)Component_object + 304LL) >= (unsigned int)v5) )
  {
    if ( *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)Component_object + 200LL) + 8 * v5 - 8) == off_8CE9FE0 )
      v6 = Component_object;
    else
      v6 = 0;
  }
  else
  {
    v6 = 0;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
  {
    if ( v6 != 0 )
    {
      UIModuleO_LoadingPanel__SetProgressBarActive(v6, 1, 0);
      goto LABEL_15;
    }
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_15:
  v7 = *((_QWORD *)self + 4);
  if ( v7 != 0 )
  {
    v8 = off_8D1D5E8;
    v9 = *((_QWORD *)off_8D1D5E8 + 7);
    if ( v9 == 0 )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
      v9 = v8[7];
    }
    v10 = *(_QWORD *)(v9 + 16);
    if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
      v10 = ((__int64 (*)(void))unk_3C503A0)();
    if ( *(_DWORD *)(v10 + 224) == 0 )
      il2cpp_codegen_runtime_class_init((void *)v10);
    v11 = *(_QWORD *)(v8[7] + 16LL);
    if ( (*(_BYTE *)(v11 + 309) & 1) == 0 )
      v11 = ((__int64 (*)(void))unk_3C503A0)();
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v7 + 392LL))(
      v7,
      **(_QWORD **)(v11 + 184),
      *(_QWORD *)(*(_QWORD *)v7 + 400LL));
  }
  v12 = LoadingModule_LoadingManager__LoadingScene(self);
  UnityEngine_MonoBehaviour__StartCoroutine(self, v12, 0);
}
