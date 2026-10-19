unsigned __int8 GameModule_GameManager__CheckNetworkState_d__14__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  void *Instance; // x0
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x2
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x0
  int v16; // w8
  _BYTE **v18; // x0
  _BYTE **v19; // x0
  __int64 v20; // x1
  __int64 v21; // x2
  __int64 v22; // x0
  __int64 v23; // x1
  __int64 v24; // x2
  __int64 v25; // x0
  __int64 v26; // x20
  __int64 v27; // x0
  __int64 v28; // x1
  __int64 v29; // x2
  __int64 v30; // x20
  _QWORD *v31; // x21
  __int64 v32; // x8
  __int64 v33; // x0
  __int64 v34; // x0
  __int64 v35; // x1
  _QWORD v36[2]; // [xsp+8h] [xbp-48h] BYREF
  __int64 v37; // [xsp+18h] [xbp-38h] BYREF

  if ( (byte_8FFD8AB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF660);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56F38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57E90);
    byte_8FFD8AB = 1;
  }
  v37 = 0;
  v3 = *((_QWORD *)self + 4);
  switch ( *((_DWORD *)self + 4) )
  {
    case 0:
      *((_DWORD *)self + 4) = -1;
      goto LABEL_38;
    case 1:
      *((_DWORD *)self + 4) = -1;
      if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1930);
      Instance = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D178A0);
      if ( Instance == nullptr )
        goto LABEL_62;
      if ( (QuickTutor_TutorialManager__IsStepComplete(Instance, qword_8D537B0, 0) & 1) == 0 )
        goto LABEL_38;
      v7 = ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v5, v6);
      if ( v7 == 0 )
        goto LABEL_62;
      if ( *(_BYTE *)(v7 + 37) != 0 )
        goto LABEL_13;
      if ( v3 == 0 )
        goto LABEL_62;
      if ( *(_BYTE *)(v3 + 96) != 0 )
      {
LABEL_13:
        v10 = ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v8, v9);
        if ( v10 == 0 )
          goto LABEL_62;
        if ( *(_BYTE *)(v10 + 37) == 0 )
          goto LABEL_38;
        if ( v3 == 0 )
          goto LABEL_62;
        if ( *(_BYTE *)(v3 + 96) != 0 )
        {
          v13 = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, v11, v12);
          if ( v13 != 0 )
          {
            v36[0] = UIFramework_UIManager__HidePanel(v13, qword_8D56F38, 0);
            v36[1] = v14;
            v15 = ((__int64 (__fastcall *)(void *, _QWORD *))unk_3C3D3B8)(off_8CEEDF8, v36);
            v16 = 3;
            *((_QWORD *)self + 3) = v15;
LABEL_19:
            *((_DWORD *)self + 4) = v16;
            return 1;
          }
          goto LABEL_62;
        }
        while ( 1 )
        {
LABEL_38:
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(v3, 0, 0) & 1) == 0 )
            break;
          if ( v3 == 0 )
            goto LABEL_62;
          if ( *(_BYTE *)(v3 + 32) != 0 )
          {
            v22 = ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v20, v21);
            if ( v22 == 0 )
              goto LABEL_62;
            if ( *(_BYTE *)(v22 + 112) != 0 )
            {
              v25 = ToolModule_ManagerBase_object___get_Instance(qword_8D12118, v23, v24);
              if ( v25 == 0 )
                goto LABEL_62;
              if ( *(_BYTE *)(v25 + 32) != 0 )
              {
                v26 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF660);
                UnityEngine_WaitForSeconds___ctor(v26, 0, 0.02);
                *((_QWORD *)self + 3) = v26;
                *((_DWORD *)self + 4) = 1;
                return 1;
              }
            }
          }
        }
      }
      else
      {
        v27 = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, v8, v9);
        if ( v27 == 0 )
          goto LABEL_62;
        if ( (UIFramework_UIManager__IsPanelShowing(v27, qword_8D57E90, &v37, 0) & 1) == 0 )
        {
          v30 = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, v28, v29);
          v31 = off_8D1D5E8;
          v32 = *((_QWORD *)off_8D1D5E8 + 7);
          if ( v32 == 0 )
          {
            ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
            v32 = v31[7];
          }
          v33 = *(_QWORD *)(v32 + 16);
          if ( (*(_BYTE *)(v33 + 309) & 1) == 0 )
            v33 = ((__int64 (*)(void))unk_3C503A0)();
          if ( *(_DWORD *)(v33 + 224) == 0 )
            il2cpp_codegen_runtime_class_init((void *)v33);
          v34 = *(_QWORD *)(v31[7] + 16LL);
          if ( (*(_BYTE *)(v34 + 309) & 1) == 0 )
            v34 = ((__int64 (*)(void))unk_3C503A0)();
          if ( v30 != 0 )
          {
            v36[0] = UIFramework_UIManager__ShowPanel(v30, qword_8D56F38, **(_QWORD **)(v34 + 184), 0);
            v36[1] = v35;
            *((_QWORD *)self + 3) = ((__int64 (__fastcall *)(void *, _QWORD *))unk_3C3D3B8)(off_8CEEDF8, v36);
            v16 = 2;
            goto LABEL_19;
          }
LABEL_62:
          il2cpp_codegen_raise_null_reference_exception();
        }
      }
      return 0;
    case 2:
      *((_DWORD *)self + 4) = -1;
      if ( v3 == 0 )
        goto LABEL_62;
      *(_BYTE *)(v3 + 96) = 1;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD1AB == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD1AB = 1;
      }
      v18 = (_BYTE **)off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v18 = (_BYTE **)off_8CE5E20;
      }
      if ( *v18[23] != 0 )
        GameModule_GameManager__PauseGame();
      goto LABEL_38;
    case 3:
      *((_DWORD *)self + 4) = -1;
      if ( v3 == 0 )
        goto LABEL_62;
      *(_BYTE *)(v3 + 96) = 0;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD1AB == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD1AB = 1;
      }
      v19 = (_BYTE **)off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v19 = (_BYTE **)off_8CE5E20;
      }
      if ( *v19[23] != 0 )
        GameModule_GameManager__ResumeGame();
      goto LABEL_38;
    default:
      return 0;
  }
}
