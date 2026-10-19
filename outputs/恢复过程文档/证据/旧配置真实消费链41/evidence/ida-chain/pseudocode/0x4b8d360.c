void *stage41_GameFramework_ConfigRead__readConfigVByUnityJson_object_(void *a0)
{
  __int64 *v1; // x8
  __int64 v3; // x20
  __int64 TypeFromHandle; // x0
  __int64 v5; // x20
  __int64 it_W; // x21
  __int64 text; // x0
  __int64 v8; // x20
  unsigned int v9; // w0
  __int64 v10; // x0
  void *result; // x0
  __int64 v12; // x19
  __int64 v13; // x0
  __int64 v14; // x20
  __int64 v15; // x0
  __int64 v16; // x0

  v1 = *((__int64 **)a0 + 7);
  if ( v1 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D85208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89250);
    v1 = *((__int64 **)a0 + 7);
    if ( v1 == nullptr )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(a0);
      v1 = *((__int64 **)a0 + 7);
    }
  }
  v3 = *v1;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v3, 0);
  if ( TypeFromHandle == 0 )
    goto LABEL_25;
  v5 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 440LL))(
         TypeFromHandle,
         *(_QWORD *)(*(_QWORD *)TypeFromHandle + 448LL));
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  it_W = GameFramework_ConfigRead____it_W(v5, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(it_W, 0, 0) & 1) != 0 )
  {
    if ( it_W != 0 )
    {
      text = UnityEngine_TextAsset__get_text(it_W, 0);
      if ( text != 0 )
      {
        v8 = text;
        v9 = System_String__IndexOf(text, qword_8D85208, 0);
        v10 = sub_750DE48(v8, v9, 0);
        result = (void *)UnityEngine_JsonUtility__FromJson_object_(v10, *(_QWORD *)(*((_QWORD *)a0 + 7) + 8LL));
        if ( result != nullptr )
          return result;
        return nullptr;
      }
    }
LABEL_25:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v12 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v13 = sub_74FE7A4(qword_8D89250, v5, 0);
  if ( v12 == 0 )
    goto LABEL_25;
  v14 = v13;
  if ( v13 != 0 )
  {
    v15 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v13, *(_QWORD *)(*(_QWORD *)v12 + 64LL));
    if ( v15 == 0 )
    {
LABEL_27:
      v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v15);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v16, 0);
      JUMPOUT(0x4B8D56C);
    }
  }
  if ( *(_DWORD *)(v12 + 24) == 0 )
  {
    v15 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_27;
  }
  *(_QWORD *)(v12 + 32) = v14;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Error(v12, 0);
  return nullptr;
}
