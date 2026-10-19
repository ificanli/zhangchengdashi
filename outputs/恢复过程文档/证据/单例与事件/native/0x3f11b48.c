void EventModule_EventManager__StopListeningOnce(void *self, void *eventName, void *listener, const MethodInfo *method)
{
  __int64 v6; // x0
  int Value; // w8
  __int64 v8; // x21
  __int64 v9; // x0
  __int64 v10; // x20
  __int64 v11; // x22
  __int64 v12; // x2
  __int64 v13; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFE05E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB80);
    byte_8FFE05E = 1;
  }
  v13 = 0;
  v6 = *((_QWORD *)self + 5);
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Value = System_Collections_Generic_Dictionary_object__object___TryGetValue(v6, eventName, &v13, qword_8CFDB70);
  if ( v13 != 0 && ((Value ^ 1) & 1) == 0 )
  {
    v8 = *((_QWORD *)self + 5);
    v9 = System_Delegate__Remove();
    if ( v8 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v10 = v9;
    if ( v9 != 0 )
    {
      v11 = qword_8CD84E8;
      v12 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v9, qword_8CD84E8);
      if ( v12 != 0 )
      {
LABEL_11:
        System_Collections_Generic_Dictionary_object__object___set_Item(v8, eventName, v12, qword_8CFDB80);
        return;
      }
      ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v10, v11);
    }
    v12 = 0;
    goto LABEL_11;
  }
}
