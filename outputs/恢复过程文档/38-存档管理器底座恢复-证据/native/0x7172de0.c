void GameFramework_DataManagerBase__UpdataData(void *self, int flag, const MethodInfo *method)
{
  char v3; // w20
  __int64 v5; // x0
  __int64 Instance; // x20
  __int64 v7; // x21
  __int64 v8; // x0
  __int64 v9; // x0

  v3 = flag;
  if ( (byte_900919D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_900919D = 1;
  }
  if ( (v3 & 1) != 0 )
  {
    v5 = **((_QWORD **)off_8CE40D0 + 23);
    if ( v5 == 0 )
      goto LABEL_14;
    if ( (DBTSDK_AppUserManager__get_IsUseServer(v5, 0, method) & 1) != 0 && *((_BYTE *)self + 17) != 0 )
    {
      if ( *((_DWORD *)off_8CE7B18 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE7B18);
      Instance = GameFramework_GameData_GameDataVersionMgr__get_Instance(0);
      v7 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 1);
      v8 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(
             self,
             *(_QWORD *)(*(_QWORD *)self + 384LL));
      if ( v7 != 0 )
      {
        if ( *(_DWORD *)(v7 + 24) == 0 )
        {
          ((void (__fastcall *)(__int64))unk_3C3D4D4)(v8);
          JUMPOUT(0x7172F14);
        }
        *(_QWORD *)(v7 + 32) = v8;
        if ( Instance != 0 )
        {
          GameFramework_GameData_GameDataVersionMgr________(Instance, v7, 0);
          return;
        }
      }
LABEL_14:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
  v9 = (*(__int64 (__fastcall **)(void *, _QWORD, const MethodInfo *))(*(_QWORD *)self + 456LL))(
         self,
         *(_QWORD *)(*(_QWORD *)self + 464LL),
         method);
  (*(void (__fastcall **)(void *, __int64, _QWORD))(*(_QWORD *)self + 488LL))(
    self,
    v9,
    *(_QWORD *)(*(_QWORD *)self + 496LL));
}
