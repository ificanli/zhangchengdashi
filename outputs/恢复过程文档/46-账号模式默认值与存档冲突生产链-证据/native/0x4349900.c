void sub_4349900(void *self, const MethodInfo *method)
{
  __int64 Instance; // x20
  __int64 v4; // x21
  __int64 v5; // x0
  _QWORD *v6; // x8
  __int64 v7; // x19
  _QWORD *v8; // x0

  if ( (byte_90005E2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD86B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D27CC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9C48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    byte_90005E2 = 1;
  }
  if ( *((_DWORD *)off_8CE7B18 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B18);
  Instance = GameFramework_GameData_GameDataVersionMgr__get_Instance(0);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD86B0);
  System_Action_object__bool____ctor(v4, self, qword_8D27CC0, 0);
  v5 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 1);
  v6 = **((_QWORD ***)off_8CE9C48 + 23);
  if ( v6 == nullptr )
    goto LABEL_10;
  v7 = v5;
  v8 = (*(_QWORD *(__fastcall **)(_QWORD *__return_ptr, _QWORD, _QWORD))(*v6 + 376LL))(
         v6,
         **((_QWORD **)off_8CE9C48 + 23),
         *(_QWORD *)(*v6 + 384LL));
  if ( v7 == 0 )
    goto LABEL_10;
  if ( *(_DWORD *)(v7 + 24) == 0 )
  {
    ((void (__fastcall *)(_QWORD *))unk_3C3D4D4)(v8);
    JUMPOUT(0x4349A34);
  }
  *(_QWORD *)(v7 + 32) = v8;
  if ( Instance == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  GameFramework_GameData_GameDataVersionMgr__RequestGameDataOnly(Instance, v4, v7, 0, 5.0);
}
