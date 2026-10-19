void __fastcall GameModule_RoleBehaviour__InitSkill(__int64 a1)
{
  __int64 v2; // x8
  __int64 v3; // x0
  int v4; // w26
  __int64 v5; // x20
  __int64 v6; // x0
  _QWORD *Instance; // x0
  __int64 v8; // x8
  __int64 v9; // x20
  __int64 v10; // x1
  __int64 Item; // x0
  __int64 v12; // x20
  long double v13; // q0
  _QWORD v14[5]; // [xsp+8h] [xbp-A8h] BYREF
  _QWORD v15[6]; // [xsp+30h] [xbp-80h] BYREF
  int v16; // [xsp+6Ch] [xbp-44h] BYREF

  if ( (byte_8FFD45E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC5C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE720);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D043D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D043D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D043E0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D073C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D073D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    byte_8FFD45E = 1;
  }
  memset(v15, 0, 40);
  v16 = 0;
  v2 = *(_QWORD *)(a1 + 344);
  if ( v2 != 0 )
  {
    v3 = *(_QWORD *)(v2 + 16);
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_int__object___GetEnumerator(v14, v3, qword_8CFC5C8);
    qmemcpy(v15, v14, 40);
    while ( (System_Collections_Generic_Dictionary_Enumerator_int__object___MoveNext(v15, qword_8D043D8) & 1) != 0 )
    {
      v4 = v15[2];
      v5 = v15[3];
      v16 = v15[2];
      v6 = System_Int32__ToString(&v16, 0);
      if ( v6 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (unsigned __int16)System_String__get_Chars(v6, 0, 0) == 52 )
      {
        if ( v5 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( *(_BYTE *)(v5 + 20) != 0 )
        {
          Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
          if ( Instance == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          v8 = Instance[5];
          if ( v8 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v9 = *(_QWORD *)(v8 + 456);
          v16 = v4;
          v10 = System_Int32__ToString(&v16, 0);
          if ( v9 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          Item = System_Collections_Generic_Dictionary_object__object___get_Item(v9, v10, qword_8CFE720);
          v12 = Item;
          if ( Item == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          if ( (unsigned int)DataModule_GlobalCardTalentInfo__GetTriggerType(Item, 0) == 6 )
            *(_DWORD *)(a1 + 316) = 6;
          v13 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v12 + 56), 0);
          *(_DWORD *)(a1 + 312) = LODWORD(v13);
        }
      }
    }
    System_Collections_Generic_Dictionary_Enumerator_int__object___Dispose(v15, qword_8D043D0);
  }
  if ( *(_DWORD *)(a1 + 316) == 6 )
    ((void (__fastcall *)(__int64))GameModule_RoleBehaviour__InitSkillInfo)(a1);
}
