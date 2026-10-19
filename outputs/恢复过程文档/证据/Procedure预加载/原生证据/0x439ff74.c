void ljzs_lt_Procedure_ProcedurePreLoad___c__DisplayClass4_0___PreLoadAsync_b__1(
        void *self,
        unsigned __int8 result,
        const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 Translation; // x20
  __int64 v10; // x21
  __int64 v11; // x22
  __int64 v12; // x0

  if ( (byte_90008CB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA0B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D497F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D667A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66798);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D892F0);
    byte_90008CB = 1;
  }
  if ( (result & 1) != 0 )
  {
    v5 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D320)(qword_8CE3258, 1, method);
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v6 = v5;
    if ( qword_8D66620 == 0
      || (v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D66620, *(_QWORD *)(*(_QWORD *)v5 + 64LL))) != 0 )
    {
      if ( *(_DWORD *)(v6 + 24) != 0 )
      {
        *(_QWORD *)(v6 + 32) = qword_8D66620;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Log(v6, 0);
        v8 = *((_QWORD *)self + 3);
        if ( v8 != 0 )
          (*(void (__fastcall **)(_QWORD, _QWORD))(v8 + 24))(*(_QWORD *)(v8 + 64), *(_QWORD *)(v8 + 40));
        return;
      }
      v7 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v7);
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v12, 0);
    JUMPOUT(0x43A01BC);
  }
  if ( *((_DWORD *)off_8CEA0B8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA0B8);
  Translation = I2_Loc_LocalizationManager__GetTranslation(qword_8D66798, 1, 0, 1, 0, 0, 0, 1, 0);
  v10 = I2_Loc_LocalizationManager__GetTranslation(qword_8D667A0, 1, 0, 1, 0, 0, 0, 1, 0);
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
  System_Action___ctor(v11, self, qword_8D497F0, 0);
  AccountMsgCanvas__SetContent(Translation, v10, qword_8D892F0, v11, 0, 0, 0);
}
