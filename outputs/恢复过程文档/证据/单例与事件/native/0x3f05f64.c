void EventModule_EventManager__TriggerEvent(void *self, void *eventName, void *parameter, const MethodInfo *method)
{
  __int64 v7; // x0
  int Value; // w0
  __int64 v9; // x0
  int v10; // w0
  __int64 v11; // [xsp+8h] [xbp-38h] BYREF
  __int64 v12; // [xsp+18h] [xbp-28h] BYREF

  if ( (byte_8FFE05F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB70);
    byte_8FFE05F = 1;
  }
  v12 = 0;
  v11 = 0;
  v7 = *((_QWORD *)self + 4);
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Value = System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, eventName, &v12, qword_8CFDB70);
  if ( v12 != 0 && ((Value ^ 1) & 1) == 0 )
    (*(void (__fastcall **)(_QWORD, void *, _QWORD))(v12 + 24))(*(_QWORD *)(v12 + 64), parameter, *(_QWORD *)(v12 + 40));
  v9 = *((_QWORD *)self + 5);
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v10 = System_Collections_Generic_Dictionary_object__object___TryGetValue(v9, eventName, &v11, qword_8CFDB70);
  if ( v11 != 0 && ((v10 ^ 1) & 1) == 0 )
  {
    if ( *((_QWORD *)self + 5) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___Remove();
    if ( v11 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(_QWORD, void *, _QWORD))(v11 + 24))(*(_QWORD *)(v11 + 64), parameter, *(_QWORD *)(v11 + 40));
  }
}
