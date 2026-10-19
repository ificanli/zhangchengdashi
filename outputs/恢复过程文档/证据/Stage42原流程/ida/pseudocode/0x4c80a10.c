unsigned __int8 GameFramework_Fsm_FsmManager__DestroyFsm_object__4c80a10(
        void *this,
        void *name,
        const MethodInfo *method)
{
  _QWORD *v3; // x8
  __int64 FullName_object; // x0
  __int64 v8; // x21
  char Value; // w20
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v13; // [xsp+8h] [xbp-28h] BYREF

  v3 = *((_QWORD **)method + 7);
  if ( v3 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0A828);
    v3 = *((_QWORD **)method + 7);
    if ( v3 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v3 = *((_QWORD **)method + 7);
    }
  }
  v13 = 0;
  FullName_object = GameFramework_Utility_Text__GetFullName_object_(name, *v3);
  v13 = 0;
  if ( *((_QWORD *)this + 4) == 0 )
    goto LABEL_11;
  v8 = FullName_object;
  Value = System_Collections_Generic_Dictionary_object__object___TryGetValue(
            *((_QWORD *)this + 4),
            FullName_object,
            &v13,
            qword_8CFE4F0);
  if ( (Value & 1) != 0 )
  {
    if ( v13 != 0 )
    {
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v13 + 520LL))(v13, *(_QWORD *)(*(_QWORD *)v13 + 528LL));
      v10 = *((_QWORD *)this + 4);
      if ( v10 != 0 )
      {
        System_Collections_Generic_Dictionary_object__object___Remove(v10, v8, qword_8CFE4E8);
        v11 = *((_QWORD *)this + 5);
        if ( v11 != 0 )
        {
          System_Collections_Generic_List_object___Remove(v11, v13, qword_8D0A828);
          return Value & 1;
        }
      }
    }
LABEL_11:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return Value & 1;
}
