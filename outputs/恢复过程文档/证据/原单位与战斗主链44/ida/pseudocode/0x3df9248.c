void GameModule_BattleGameSceneManager___ctor(GameModule_BattleGameSceneManager_o *this, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20
  __int64 v9; // x20
  __int64 v10; // x20
  __int64 v11; // x20
  __int64 v12; // x20

  if ( (byte_8FFD7DA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00A20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA4C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD92A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AC80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B498);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD780);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD880);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD2E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12050);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE36E0);
    byte_8FFD7DA = 1;
  }
  *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[40] = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(
                                                                qword_8CE36E0,
                                                                6);
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[48] = -1082130432;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA4C0);
  sub_6CB781C(v3, 128, qword_8D00A20);
  *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[64] = v3;
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[72] = -1;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD880);
  System_Collections_Generic_List_object____ctor(v4, qword_8D0B498);
  *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[224] = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD780);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0AC80);
  *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[256] = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD92A0);
  System_Collections_Generic_Dictionary_object__object____ctor(v6, qword_8CFB620);
  *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[368] = v6;
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[376] = 1000;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD2E0);
  System_Collections_Generic_List_object____ctor(v7, qword_8D093B0);
  *((_QWORD *)this + 66) = v7;
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD2E0);
  System_Collections_Generic_List_object____ctor(v8, qword_8D093B0);
  *((_QWORD *)this + 67) = v8;
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v9, qword_8CFEA38);
  *((_QWORD *)this + 68) = v9;
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v10, qword_8CFEA38);
  *((_QWORD *)this + 69) = v10;
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v11, qword_8CFEA38);
  *((_QWORD *)this + 70) = v11;
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v12, qword_8CFEA38);
  *((_QWORD *)this + 71) = v12;
  *((_DWORD *)this + 145) = 1017370378;
  *((_DWORD *)this + 148) = 1065353216;
  ToolModule_ManagerBase_object____ctor(this, (const MethodInfo *)qword_8D12050);
}
