// local variable allocation has failed, the output may be wrong!
void DataModule_SaveConflictCanvas__OnChoice(void *self, unsigned __int8 useLocal, const MethodInfo *method)
{
  __int64 v5; // x20
  __int64 v6; // x0
  __int64 v7; // x21
  __int64 v8; // x21
  _QWORD *v9; // x8
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 v12; // x0
  __int64 v13; // x8
  __int64 v14; // x19
  __int64 v15; // x21

  if ( (byte_90005F5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49DA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF52B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEEE50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87638);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86D38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D87860);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D88180);
    byte_90005F5 = 1;
  }
  v5 = ((__int64 (__fastcall *)(__int64, _QWORD, const MethodInfo *))unk_3C3D4C4)(qword_8CF52B0, useLocal, method);
  System_Object___ctor(v5, 0);
  if ( v5 == 0 )
    goto LABEL_18;
  *(_QWORD *)(v5 + 16) = self;
  *(_BYTE *)(v5 + 24) = useLocal & 1;
  v6 = *((_QWORD *)self + 7);
  if ( v6 == 0 )
    goto LABEL_18;
  UnityEngine_GameObject__SetActive(v6, 1, 0);
  v7 = *((_QWORD *)self + 9);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) != 0 )
  {
    v8 = *((_QWORD *)self + 9);
    if ( *(_BYTE *)(v5 + 24) != 0 )
      v9 = &unk_8D87860;
    else
      v9 = &unk_8D88180;
    v10 = sub_750A330(qword_8D87638, *v9, qword_8D86D38, 0);
    if ( v8 != 0 )
    {
      (*(void (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)v8 + 1368LL))(
        v8,
        v10,
        *(_QWORD *)(*(_QWORD *)v8 + 1376LL));
      goto LABEL_13;
    }
LABEL_18:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_13:
  v11 = *((_QWORD *)self + 8);
  if ( v11 == 0 )
    goto LABEL_18;
  v12 = *(_QWORD *)(v11 + 256);
  if ( v12 == 0 )
    goto LABEL_18;
  UnityEngine_Events_UnityEventBase__RemoveAllListeners(v12, 0);
  v13 = *((_QWORD *)self + 8);
  if ( v13 == 0 )
    goto LABEL_18;
  v14 = *(_QWORD *)(v13 + 256);
  v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEEE50);
  UnityEngine_Events_UnityAction___ctor(v15, v5, qword_8D49DA0, 0);
  if ( v14 == 0 )
    goto LABEL_18;
  UnityEngine_Events_UnityEvent__AddListener(v14, v15, 0);
}
