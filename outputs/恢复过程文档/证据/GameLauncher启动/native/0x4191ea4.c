// local variable allocation has failed, the output may be wrong!
unsigned __int8 CoreModule_GameLauncher__TrySetRendererFeatureActive(
        void *self,
        void *asset,
        void *name,
        unsigned __int8 active,
        const MethodInfo *method)
{
  void *v8; // x23
  __int64 v9; // x0
  int v10; // w21
  __int64 Item; // x22
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x19
  void *v16; // [xsp+8h] [xbp-48h] BYREF

  if ( (byte_8FFF6B4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DFE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DFE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D877E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87580);
    byte_8FFF6B4 = 1;
  }
  v16 = nullptr;
  if ( (CoreModule_GameLauncher__TryGetDefaultRendererData(self, asset, &v16, (const MethodInfo *)active) & 1) != 0 )
  {
    v8 = v16;
    if ( v16 == nullptr || (v9 = *(__int64 *)((char *)&qword_28 + (_QWORD)v16)) == 0 )
LABEL_14:
      il2cpp_codegen_raise_null_reference_exception();
    v10 = 0;
    while ( v10 < *(_DWORD *)((char *)&off_18 + v9) )
    {
      Item = System_Collections_Generic_List_object___get_Item();
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(Item, 0, 0) & 1) == 0 )
      {
        if ( Item == 0 )
          goto LABEL_14;
        v12 = UnityEngine_Object__get_name(Item, 0);
        if ( (System_String__Equals(v12, name, 4, 0) & 1) != 0 )
        {
          *(_BYTE *)(Item + 24) = active & 1;
          return 1;
        }
      }
      v9 = *(__int64 *)((char *)&qword_28 + (_QWORD)v8);
      ++v10;
      if ( v9 == 0 )
        goto LABEL_14;
    }
    v14 = sub_74FE7A4(qword_8D877E8, name, 0);
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    v13 = v14;
  }
  else
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    v13 = qword_8D87580;
  }
  UnityEngine_Debug__LogWarning(v13, 0);
  return 0;
}
