void ljzs_lt_GameStart__RegisterProcedure(void *self, const MethodInfo *method)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x8
  _QWORD *v6; // x9
  __int64 v7; // x10
  __int64 v8; // x20
  __int64 v9; // x8
  _QWORD *v10; // x9
  __int64 v11; // x10
  __int64 v12; // x20
  __int64 v13; // x8
  _QWORD *v14; // x9
  __int64 v15; // x10
  __int64 Module_object; // x20
  __int64 v17; // x0

  if ( (byte_9000887 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0D548);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D550);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D540);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDE70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEBE78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEBE80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEBE88);
    byte_9000887 = 1;
  }
  GameFramework_Base_IGameStart__RegisterProcedure(self, 0);
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDE70);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0D540);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEBE80);
  GameFramework_Procedure_ProcedureBase___ctor(v4, 0);
  if ( v3 == 0 )
    goto LABEL_20;
  v5 = *(_QWORD *)(v3 + 16);
  v6 = off_8D0D548;
  ++*(_DWORD *)(v3 + 28);
  if ( v5 == 0 )
    goto LABEL_20;
  v7 = *(int *)(v3 + 24);
  if ( (unsigned int)v7 >= *(_DWORD *)(v5 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v4, *(_QWORD *)(*(_QWORD *)(v6[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v3 + 24) = v7 + 1;
    *(_QWORD *)(v5 + 8 * v7 + 32) = v4;
  }
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEBE88);
  GameFramework_Procedure_ProcedureBase___ctor(v8, 0);
  v9 = *(_QWORD *)(v3 + 16);
  v10 = off_8D0D548;
  ++*(_DWORD *)(v3 + 28);
  if ( v9 == 0 )
    goto LABEL_20;
  v11 = *(int *)(v3 + 24);
  if ( (unsigned int)v11 >= *(_DWORD *)(v9 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v8, *(_QWORD *)(*(_QWORD *)(v10[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v3 + 24) = v11 + 1;
    *(_QWORD *)(v9 + 8 * v11 + 32) = v8;
  }
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEBE78);
  GameFramework_Procedure_ProcedureBase___ctor(v12, 0);
  v13 = *(_QWORD *)(v3 + 16);
  v14 = off_8D0D548;
  ++*(_DWORD *)(v3 + 28);
  if ( v13 == 0 )
    goto LABEL_20;
  v15 = *(int *)(v3 + 24);
  if ( (unsigned int)v15 >= *(_DWORD *)(v13 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v12, *(_QWORD *)(*(_QWORD *)(v14[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v3 + 24) = v15 + 1;
    *(_QWORD *)(v13 + 8 * v15 + 32) = v12;
  }
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D170);
  v17 = System_Collections_Generic_List_object___ToArray(v3, qword_8D0D550);
  if ( Module_object == 0 )
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  GameFramework_Procedure_ProcedureManager__Register(Module_object, v17, 0);
}
