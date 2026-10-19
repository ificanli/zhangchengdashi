void *GameFramework_DataManagerPool__AddModel_object_(
        void *self,
        void *model,
        unsigned __int8 init,
        const MethodInfo *method)
{
  __int64 Type; // x0
  __int64 v8; // x22
  __int64 v9; // x20
  __int64 v10; // x21
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x21
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 CustomAttribute_object; // x0
  bool v17; // w8
  __int64 v18; // x0
  __int64 v20; // x0

  if ( (byte_9002258 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D27768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86EA0);
    byte_9002258 = 1;
  }
  if ( model == nullptr )
    goto LABEL_20;
  Type = System_Object__GetType(model, 0);
  if ( *((_QWORD *)self + 2) == 0 )
    goto LABEL_20;
  v8 = Type;
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(*((_QWORD *)self + 2), Type, qword_8D00178)
      & 1) != 0 )
  {
    v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v10 = qword_8D86EA0;
    v11 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)model + 360LL))(
            model,
            *(_QWORD *)(*(_QWORD *)model + 368LL));
    v12 = sub_74FE7A4(v10, v11, 0);
    if ( v9 != 0 )
    {
      v13 = v12;
      if ( v12 == 0
        || (v14 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v12, *(_QWORD *)(*(_QWORD *)v9 + 64LL))) != 0 )
      {
        if ( *(_DWORD *)(v9 + 24) != 0 )
        {
          *(_QWORD *)(v9 + 32) = v13;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__Error(v9, 0);
          return model;
        }
        v14 = ((__int64 (*)(void))unk_3C3D4D4)();
      }
      v20 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v14);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v20, 0);
      JUMPOUT(0x4B98584);
    }
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v15 = System_Object__GetType(model, 0);
  CustomAttribute_object = System_Reflection_CustomAttributeExtensions__GetCustomAttribute_object_(v15, qword_8D27768);
  v17 = CustomAttribute_object != 0 && *(_BYTE *)(CustomAttribute_object + 24) != 0;
  *((_BYTE *)model + 17) = v17;
  v18 = *((_QWORD *)self + 2);
  if ( v18 == 0 )
    goto LABEL_20;
  System_Collections_Generic_Dictionary_object__object___set_Item(v18, v8, model, qword_8D00198);
  if ( (init & 1) != 0 )
    (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)model + 392LL))(model, *(_QWORD *)(*(_QWORD *)model + 400LL));
  return model;
}
