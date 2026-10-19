bool GameModule_BattleGameManager__IsPayedPlayer()
{
  __int64 v0; // x8
  __int64 v1; // x8
  __int64 v2; // x19
  _QWORD *v3; // x0
  __int64 v4; // x20
  __int64 v5; // x21
  __int64 All; // x0

  if ( (byte_8FFD734 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B658);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0B668);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45060);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF1458);
    byte_8FFD734 = 1;
  }
  v0 = **((_QWORD **)off_8CD9250 + 23);
  if ( v0 != 0 )
  {
    v1 = *(_QWORD *)(v0 + 48);
    if ( v1 != 0 )
    {
      v2 = *(_QWORD *)(v1 + 160);
      v3 = off_8CF1458;
      if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CF1458);
        v3 = off_8CF1458;
      }
      v4 = *(_QWORD *)(v3[23] + 8LL);
      if ( v4 == 0 )
      {
        if ( *((_DWORD *)v3 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(v3);
          v3 = off_8CF1458;
        }
        v5 = *(_QWORD *)v3[23];
        v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF188);
        System_Predicate_object____ctor(v4, v5, qword_8D45060, 0);
        *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 8LL) = v4;
      }
      if ( v2 != 0 )
      {
        All = System_Collections_Generic_List_object___FindAll(v2, v4, qword_8D0B658);
        if ( All != 0 )
          return *(_DWORD *)(All + 24) < 1;
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
