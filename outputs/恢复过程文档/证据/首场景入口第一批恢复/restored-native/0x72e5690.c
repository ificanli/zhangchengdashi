void GameFramework_Base_GameStartEntry______V_(void *self, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 Instance; // x0
  _QWORD *v9; // x0
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x0

  if ( (byte_900A031 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D160);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E1B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5FC08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87020);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87068);
    byte_900A031 = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D87020);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_9008D60 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_9008D60 = 1;
  }
  v3 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v3 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v3[23] + 89LL) != 0 )
    GameFramework_Base_GameStartEntry____Ol_F();
  v4 = *((_QWORD *)self + 10);
  if ( v4 == 0 )
    goto LABEL_24;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v4 + 488LL))(v4, *(_QWORD *)(*(_QWORD *)v4 + 496LL));
  v5 = *((_QWORD *)self + 10);
  if ( v5 == 0 )
    goto LABEL_24;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v5 + 440LL))(v5, *(_QWORD *)(*(_QWORD *)v5 + 448LL));
  v6 = *((_QWORD *)self + 10);
  if ( v6 == 0 )
    goto LABEL_24;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v6 + 456LL))(v6, *(_QWORD *)(*(_QWORD *)v6 + 464LL));
  v7 = *((_QWORD *)self + 10);
  if ( v7 == 0 )
    goto LABEL_24;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v7 + 472LL))(v7, *(_QWORD *)(*(_QWORD *)v7 + 480LL));
  Instance = GameFramework_AudioManager__get_Instance(0);
  if ( Instance == 0 )
    goto LABEL_24;
  GameFramework_AudioManager__InitAudioManager(Instance, 0);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  if ( GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D160) == 0 )
    goto LABEL_24;
  GameFramework_MineGameLogicModule__InitCtrl();
  *((_BYTE *)self + 60) = 1;
  *((_BYTE *)self + 74) = 0;
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D87068);
  GameFramework_GameFrameEntry__CommonSettings(0);
  v9 = off_8CEC810;
  if ( *((_DWORD *)off_8CEC810 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CEC810);
    v9 = off_8CEC810;
  }
  v10 = *(_QWORD *)(v9[23] + 8LL);
  if ( v10 == 0
    || (DBTSDK_ReportManager__StartMineGame(v10, 0),
        v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100),
        GameFramework_MsgDispatcher_EventHandler___ctor(v11, self, qword_8D2E1B0, 0),
        GameFramework_MsgDispatcher__AddEventListener(qword_8D5FC08, v11, 0),
        (v12 = *((_QWORD *)self + 10)) == 0) )
  {
LABEL_24:
    il2cpp_codegen_raise_null_reference_exception();
  }
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v12 + 424LL))(v12, *(_QWORD *)(*(_QWORD *)v12 + 432LL));
}
