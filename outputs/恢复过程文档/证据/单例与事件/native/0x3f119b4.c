void EventModule_EventManager__StartListeningOnce(
        void *self,
        void *eventName,
        void *listener,
        const MethodInfo *method)
{
  __int64 v7; // x0
  int Value; // w0
  __int64 v9; // x21
  __int64 Item; // x0
  void *v11; // x0
  __int64 v12; // x22
  __int64 v13; // x2
  __int64 v14; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFE05D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB80);
    byte_8FFE05D = 1;
  }
  v14 = 0;
  v7 = *((_QWORD *)self + 5);
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Value = System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, eventName, &v14, qword_8CFDB70);
  v9 = *((_QWORD *)self + 5);
  if ( v14 == 0 || ((Value ^ 1) & 1) != 0 )
    goto LABEL_10;
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Item = System_Collections_Generic_Dictionary_object__object___get_Item(v9, eventName, qword_8CFDB78);
  v11 = (void *)System_Delegate__Combine(Item, listener, 0);
  listener = v11;
  if ( v11 == nullptr )
  {
    v13 = 0;
    goto LABEL_13;
  }
  v12 = qword_8CD84E8;
  v13 = ((__int64 (__fastcall *)(void *, __int64))unk_3C3D3B4)(v11, qword_8CD84E8);
  if ( v13 != 0 )
  {
LABEL_13:
    System_Collections_Generic_Dictionary_object__object___set_Item(v9, eventName, v13, qword_8CFDB80);
    return;
  }
  ((void (__fastcall *)(void *, __int64))unk_3C3D868)(listener, v12);
LABEL_10:
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__object___set_Item(v9, eventName, listener, qword_8CFDB80);
}
