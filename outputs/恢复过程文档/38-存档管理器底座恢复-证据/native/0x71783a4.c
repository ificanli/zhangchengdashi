void GameFramework_DataManagerPool__OnInit(void *self, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x0
  __int64 v7; // x19
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x0

  if ( (byte_90091D7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA2D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF0B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D865D0);
    byte_90091D7 = 1;
  }
  v3 = off_8CE6178;
  if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6178);
    v3 = off_8CE6178;
  }
  *(_BYTE *)(v3[23] + 8LL) = 0;
  v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDA2D0, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8D00168);
  *((_QWORD *)self + 2) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF0B80);
  _____d____ctor(v5, 0);
  *((_QWORD *)self + 3) = v5;
  if ( v5 == 0 )
    goto LABEL_15;
  _____d____ye__a(v5, 0);
  if ( *((_BYTE *)self + 32) != 0 )
    GameFramework_DataManagerPool____Fe_p(self);
  v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( v6 == 0 )
LABEL_15:
    il2cpp_codegen_raise_null_reference_exception();
  v7 = v6;
  if ( qword_8D865D0 != 0 )
  {
    v8 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D865D0, *(_QWORD *)(*(_QWORD *)v6 + 64LL));
    if ( v8 == 0 )
      goto LABEL_17;
  }
  if ( *(_DWORD *)(v7 + 24) == 0 )
  {
    v8 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_17:
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v8);
    v10 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v9, 0);
    GameFramework_DataManagerPool____Fe_p(v10);
    return;
  }
  *(_QWORD *)(v7 + 32) = qword_8D865D0;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog___y_Eo_(v7, 0);
}
