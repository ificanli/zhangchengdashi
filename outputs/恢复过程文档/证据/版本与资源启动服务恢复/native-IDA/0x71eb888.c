__int64 __fastcall GameFramework_VersionMondule__SetAssetBundleURL(__int64 a1)
{
  _QWORD *v2; // x0
  _QWORD *Module_object; // x0
  __int64 v4; // x0
  __int64 v5; // x20
  __int64 v6; // x0
  __int64 result; // x0
  __int64 v8; // x8
  __int64 v9; // x0

  if ( (byte_90096E8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D865F8);
    byte_90096E8 = 1;
  }
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v2 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v2 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v2[23] + 56LL) == 0 )
  {
    if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7B30);
    Module_object = GameFramework_GameFrameEntry__GetModule_object_((const MethodInfo *)qword_8D2D180);
    if ( Module_object == nullptr )
LABEL_23:
      il2cpp_codegen_raise_null_reference_exception();
    Module_object[14] = *(_QWORD *)(a1 + 48);
  }
  *(_BYTE *)(a1 + 16) = 1;
  v4 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( v4 == 0 )
    goto LABEL_23;
  v5 = v4;
  if ( qword_8D865F8 != 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D865F8, *(_QWORD *)(*(_QWORD *)v4 + 64LL));
    if ( v6 == 0 )
    {
LABEL_25:
      v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v6);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v9, 0);
      JUMPOUT(0x71EBA34);
    }
  }
  if ( *(_DWORD *)(v5 + 24) == 0 )
  {
    v6 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_25;
  }
  *(_QWORD *)(v5 + 32) = qword_8D865F8;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  result = GameFramework_CLog__d_e___(v5, 0);
  v8 = *(_QWORD *)(a1 + 24);
  if ( v8 != 0 )
    return (*(__int64 (__fastcall **)(_QWORD, _QWORD))(v8 + 24))(*(_QWORD *)(v8 + 64), *(_QWORD *)(v8 + 40));
  return result;
}
