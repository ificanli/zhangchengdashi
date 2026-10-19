unsigned __int8 UIFramework_UIManager__IsPanelShowing(void *self, void *path, void **panel, const MethodInfo *method)
{
  __int64 v7; // x0
  void *v8; // x0
  __int64 gameObject; // x0
  char activeInHierarchy; // w0
  void *v12; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFFFD3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF550);
    byte_8FFFFD3 = 1;
  }
  v12 = nullptr;
  v7 = *((_QWORD *)self + 5);
  if ( v7 != 0 )
  {
    if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, path, &v12, qword_8CFF550) & 1) == 0 )
    {
      activeInHierarchy = 0;
      *panel = nullptr;
      return activeInHierarchy & 1;
    }
    v8 = v12;
    *panel = v12;
    if ( v8 != nullptr )
    {
      gameObject = UnityEngine_Component__get_gameObject(v8, 0);
      if ( gameObject != 0 )
      {
        activeInHierarchy = UnityEngine_GameObject__get_activeInHierarchy(gameObject, 0);
        return activeInHierarchy & 1;
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
