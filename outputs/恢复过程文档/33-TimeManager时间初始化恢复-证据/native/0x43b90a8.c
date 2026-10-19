void L_Tools_ServerTimeMgr__InitAfterLogin(void *self, const MethodInfo *method)
{
  __int64 UtcNow; // x0
  __int64 v4; // x20
  _QWORD *v5; // x8
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 Instance; // x20
  __int64 v9; // x21
  __int64 v10; // x20

  if ( (byte_90009B9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D38A00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D38A18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D38A20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17818);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF66C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60F50);
    byte_90009B9 = 1;
  }
  if ( *((_BYTE *)self + 25) == 0 )
  {
    if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
    UtcNow = System_DateTime__get_UtcNow(0, method);
    v4 = L_Tools_DateExtention__ToTimestampLong_UTC(UtcNow, 0);
    v5 = off_8CED280;
    if ( *((_DWORD *)off_8CED280 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CED280);
      v5 = off_8CED280;
    }
    *(_QWORD *)(v5[23] + 8LL) = v4;
    *((_DWORD *)self + 15) = *((_DWORD *)self + 14);
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF66C8);
    UpdateManager_UpdateHandle___ctor(v6, self, qword_8D38A20, 0);
    *((_DWORD *)self + 16) = UpdateManager__AddHandle(v6, 0);
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
    GameFramework_MsgDispatcher_EventHandler___ctor(v7, self, qword_8D38A00, 0);
    GameFramework_MsgDispatcher__AddEventListener(qword_8D60F50, v7, 0);
    if ( *((_DWORD *)off_8CE1920 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1920);
    Instance = L_Tools_SingletonComponent_object___get_Instance(qword_8D17818);
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8378);
    System_Action_bool____ctor(v9, self, qword_8D38A18, 0);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityAgencyManager__AddEvent(Instance, 1, v9, 0);
    L_Tools_ServerTimeMgr__CheatCode(self);
    v10 = *(_QWORD *)(*((_QWORD *)off_8CED280 + 23) + 8LL);
    if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64C0);
    L_Tools_DateTools__UpdateTime(v10, nullptr);
    *((_BYTE *)self + 25) = 1;
  }
}
