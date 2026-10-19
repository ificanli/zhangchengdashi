void GameFramework_Base_GameStartEntry____M_a_(void *self, void *args, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0

  if ( (byte_900A033 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    byte_900A033 = 1;
  }
  if ( *((_BYTE *)self + 32) != 0 )
  {
    v5 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D320)(qword_8CE3258, 1, method);
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v6 = v5;
    if ( args == nullptr
      || (v7 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(args, *(_QWORD *)(*(_QWORD *)v5 + 64LL))) != 0 )
    {
      if ( *(_DWORD *)(v6 + 24) != 0 )
      {
        *(_QWORD *)(v6 + 32) = args;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Log(v6, 0);
        return;
      }
      v7 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v7);
    v9 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v8, 0);
    GameFramework_Base_GameStartEntry____Ol_F(v9);
  }
}
