void *ToolModule_ManagerBase_object___CreateSubController_object_(void *self, const MethodInfo *method)
{
  __int64 *v2; // x8
  __int64 v5; // x21
  __int64 TypeFromHandle; // x0
  __int64 v7; // x22
  __int64 v8; // x21
  __int64 v9; // x0
  void *v10; // x20
  __int64 transform; // x0
  __int64 v12; // x21
  __int64 v13; // x0

  v2 = *((__int64 **)method + 7);
  if ( v2 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    v2 = *((__int64 **)method + 7);
    if ( v2 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v2 = *((__int64 **)method + 7);
    }
  }
  v5 = *v2;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  if ( TypeFromHandle != 0 )
  {
    v7 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 440LL))(
           TypeFromHandle,
           *(_QWORD *)(*(_QWORD *)TypeFromHandle + 448LL));
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
    UnityEngine_GameObject___ctor(v8, v7, 0);
    if ( v8 != 0 )
    {
      v9 = UnityEngine_GameObject__AddComponent_object_(v8, *(_QWORD *)(*((_QWORD *)method + 7) + 8LL));
      if ( v9 != 0 )
      {
        v10 = (void *)v9;
        transform = UnityEngine_Component__get_transform(v9, 0);
        if ( self != nullptr )
        {
          v12 = transform;
          v13 = UnityEngine_Component__get_transform(self, 0);
          if ( v12 != 0 )
          {
            UnityEngine_Transform__SetParent(v12, v13, 0);
            return v10;
          }
        }
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
