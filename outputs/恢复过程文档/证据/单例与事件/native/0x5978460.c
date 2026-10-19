void *ToolModule_ManagerBase_object___get_Instance(const MethodInfo *method)
{
  __int64 v2; // x0
  __int64 v3; // x0
  __int64 v4; // x20
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 TypeFromHandle; // x20
  __int64 ObjectOfType; // x0
  __int64 v9; // x8
  __int64 v10; // x20
  __int64 v11; // x22
  __int64 v12; // x21
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x21
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x20
  __int64 v22; // x0
  __int64 v23; // x21
  __int64 v24; // x20
  __int64 v25; // x0
  __int64 v26; // x0
  __int64 v27; // x8
  __int64 v28; // x21
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 ObjectOfType_object; // x21
  __int64 transform; // x0
  __int64 v33; // x20
  __int64 v34; // x0
  __int64 v35; // x0
  __int64 v36; // x0

  if ( (byte_9003161 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34F28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    byte_9003161 = 1;
  }
  v2 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v2 + 309) & 1) == 0 )
    v2 = ((__int64 (*)(void))unk_3C503A0)();
  v3 = *(_QWORD *)(*(_QWORD *)(v2 + 192) + 16LL);
  if ( (*(_BYTE *)(v3 + 309) & 1) == 0 )
    v3 = ((__int64 (*)(void))unk_3C503A0)();
  v4 = **(_QWORD **)(v3 + 184);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Implicit(v4, 0) & 1) != 0 )
    goto LABEL_65;
  v5 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v5 + 309) & 1) == 0 )
    v5 = ((__int64 (*)(void))unk_3C503A0)();
  v6 = *(_QWORD *)(*(_QWORD *)(v5 + 192) + 24LL);
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v6, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  ObjectOfType = UnityEngine_Object__FindObjectOfType(TypeFromHandle, 0);
  v9 = *((_QWORD *)method + 4);
  v10 = ObjectOfType;
  if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
    v9 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
  v11 = *(_QWORD *)(*(_QWORD *)(v9 + 192) + 8LL);
  if ( (*(_BYTE *)(v11 + 309) & 1) == 0 )
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v11);
  if ( v10 != 0 )
  {
    v12 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v10, v11);
    if ( v12 != 0 )
      goto LABEL_24;
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v10, v11);
  }
  v12 = 0;
LABEL_24:
  v13 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v13 + 309) & 1) == 0 )
    v13 = ((__int64 (*)(void))unk_3C503A0)();
  v14 = *(_QWORD *)(*(_QWORD *)(v13 + 192) + 16LL);
  if ( (*(_BYTE *)(v14 + 309) & 1) == 0 )
    v14 = ((__int64 (*)(void))unk_3C503A0)();
  **(_QWORD **)(v14 + 184) = v12;
  v15 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
    v15 = ((__int64 (*)(void))unk_3C503A0)();
  if ( (*(_BYTE *)(*(_QWORD *)(*(_QWORD *)(v15 + 192) + 16LL) + 309LL) & 1) == 0 )
    ((void (*)(void))unk_3C503A0)();
  v16 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
    v16 = ((__int64 (*)(void))unk_3C503A0)();
  v17 = *(_QWORD *)(*(_QWORD *)(v16 + 192) + 8LL);
  if ( (*(_BYTE *)(v17 + 309) & 1) == 0 )
    v17 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v16 + 192) + 8LL));
  if ( v10 != 0 && ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v10, v17) == 0 )
  {
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v10, v17);
    JUMPOUT(0x5978848);
  }
  v18 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v18 + 309) & 1) == 0 )
    v18 = ((__int64 (*)(void))unk_3C503A0)();
  v19 = *(_QWORD *)(*(_QWORD *)(v18 + 192) + 16LL);
  if ( (*(_BYTE *)(v19 + 309) & 1) == 0 )
    v19 = ((__int64 (*)(void))unk_3C503A0)();
  if ( (UnityEngine_Object__op_Equality(**(_QWORD **)(v19 + 184), 0, 0) & 1) != 0 )
  {
    v20 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v20 + 309) & 1) == 0 )
      v20 = ((__int64 (*)(void))unk_3C503A0)();
    v21 = *(_QWORD *)(*(_QWORD *)(v20 + 192) + 24LL);
    if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEA50);
    v22 = System_Type__GetTypeFromHandle(v21, 0);
    if ( v22 == 0 )
      goto LABEL_70;
    v23 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v22 + 440LL))(
            v22,
            *(_QWORD *)(*(_QWORD *)v22 + 448LL));
    v24 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
    UnityEngine_GameObject___ctor(v24, v23, 0);
    if ( v24 == 0 )
      goto LABEL_70;
    v25 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v25 + 309) & 1) == 0 )
      v25 = ((__int64 (*)(void))unk_3C503A0)();
    v26 = UnityEngine_GameObject__AddComponent_object_(v24, *(_QWORD *)(*(_QWORD *)(v25 + 192) + 32LL));
    v27 = *((_QWORD *)method + 4);
    v28 = v26;
    if ( (*(_BYTE *)(v27 + 309) & 1) == 0 )
      v27 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
    v29 = *(_QWORD *)(*(_QWORD *)(v27 + 192) + 16LL);
    if ( (*(_BYTE *)(v29 + 309) & 1) == 0 )
      v29 = ((__int64 (*)(void))unk_3C503A0)();
    **(_QWORD **)(v29 + 184) = v28;
    v30 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v30 + 309) & 1) == 0 )
      v30 = ((__int64 (*)(void))unk_3C503A0)();
    if ( (*(_BYTE *)(*(_QWORD *)(*(_QWORD *)(v30 + 192) + 16LL) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    ObjectOfType_object = UnityEngine_Object__FindObjectOfType_object_(qword_8D34F28);
    if ( (UnityEngine_Object__op_Inequality(ObjectOfType_object, 0, 0) & 1) != 0 )
    {
      transform = UnityEngine_GameObject__get_transform(v24, 0);
      if ( ObjectOfType_object != 0 )
      {
        v33 = transform;
        v34 = UnityEngine_Component__get_transform(ObjectOfType_object, 0);
        if ( v33 != 0 )
        {
          UnityEngine_Transform__SetParent(v33, v34, 0);
          goto LABEL_65;
        }
      }
LABEL_70:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
LABEL_65:
  v35 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v35 + 309) & 1) == 0 )
    v35 = ((__int64 (*)(void))unk_3C503A0)();
  v36 = *(_QWORD *)(*(_QWORD *)(v35 + 192) + 16LL);
  if ( (*(_BYTE *)(v36 + 309) & 1) == 0 )
    v36 = ((__int64 (*)(void))unk_3C503A0)();
  return **(void ***)(v36 + 184);
}
