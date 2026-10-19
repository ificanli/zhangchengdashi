// local variable allocation has failed, the output may be wrong!
void Oke____A____U(void *key, void *data, unsigned __int8 useServer, const MethodInfo *method)
{
  __int64 Instance; // x0
  _QWORD *v8; // x8
  __int64 v9; // x0
  __int64 v10; // x20
  __int64 v11; // x21
  __int64 v12; // x0
  unsigned int v13; // w8
  __int64 v14; // x0
  __int64 v15; // x22
  __int64 Default; // x0
  __int64 v17; // x0
  __int64 v18; // x19
  __int64 v19; // x0
  __int64 v20; // x0

  if ( (byte_90091C0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7D7B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66678);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EA0);
    byte_90091C0 = 1;
  }
  if ( (useServer & 1) != 0 )
  {
    Instance = GamePath__get_Instance(0, data, useServer);
    if ( Instance == 0 )
      goto LABEL_34;
    v8 = (_QWORD *)(Instance + 64);
  }
  else
  {
    v9 = GamePath__get_Instance(0, data, useServer);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v8 = (_QWORD *)(v9 + 72);
  }
  v10 = sub_750A330(*v8, key, qword_8D52E08, 0);
  v11 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v12 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 5);
  if ( v12 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v13 = *(_DWORD *)(v12 + 24);
  if ( v13 == 0 )
  {
    v12 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_25;
  }
  *(_QWORD *)(v12 + 32) = qword_8D66678;
  if ( v13 == 1 )
  {
LABEL_25:
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v12);
    goto LABEL_26;
  }
  *(_QWORD *)(v12 + 40) = v10;
  if ( v13 <= 2 )
  {
LABEL_26:
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v12);
    goto LABEL_27;
  }
  *(_QWORD *)(v12 + 48) = qword_8D78EC8;
  if ( v13 == 3 )
  {
LABEL_27:
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v12);
    goto LABEL_28;
  }
  *(_QWORD *)(v12 + 56) = data;
  if ( v13 <= 4 )
  {
LABEL_28:
    ((void (__fastcall *)(__int64))unk_3C3D4D4)(v12);
LABEL_29:
    il2cpp_codegen_raise_null_reference_exception();
  }
  *(_QWORD *)(v12 + 64) = qword_8D78EA0;
  v14 = System_String__Concat();
  if ( v11 == 0 )
    goto LABEL_29;
  v15 = v14;
  if ( v14 != 0 && ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v14, *(_QWORD *)(*(_QWORD *)v11 + 64LL)) == 0 )
  {
    v20 = ((__int64 (*)(void))unk_3C3D4F0)();
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v20, 0);
LABEL_34:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( *(_DWORD *)(v11 + 24) == 0 )
  {
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_31;
  }
  *(_QWORD *)(v11 + 32) = v15;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog___y_Eo_(v11, 0);
  Default = System_Text_Encoding__get_Default(0);
  if ( Default == 0 )
LABEL_31:
    il2cpp_codegen_raise_null_reference_exception();
  v17 = (*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)Default + 600LL))(
          Default,
          data,
          *(_QWORD *)(*(_QWORD *)Default + 608LL));
  v18 = GameFramework_Tools_UIGradientBlender__BlendColors(v17, qword_8D7D7B0, 0);
  v19 = GameFramework_Tools_FileManager__get_Instance(0);
  if ( v19 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameFramework_Tools_FileManager_______t(v19, v10, v18, 0);
}
