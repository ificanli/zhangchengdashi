void LoadingModule_LoadingManager__Init_d__19__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 GameGlobalConfig; // x0
  __int64 Component_object; // x0
  __int64 v6; // x10
  __int64 v7; // x21
  __int64 v8; // x21
  __int64 v9; // x22
  __int64 v10; // x0
  __int64 v11; // x23
  void *Instance; // x21
  void *v13; // x22
  __int64 persistentDataPath; // x20
  _QWORD *v15; // x0
  __int64 v16; // x21
  _QWORD *v17; // x0
  _QWORD *v18; // x0
  __int64 v19; // x20
  __int64 v20; // x1
  __int64 v21; // x20
  __int64 v22; // x8
  unsigned int v23; // w21
  __int64 v24; // x9
  int *v25; // x10
  __int64 v26; // x0
  __int64 v27; // x20
  __int64 v28; // x8
  unsigned int v29; // w21
  __int64 v30; // x9
  _DWORD *v31; // x10
  __int64 v32; // x0
  __int64 *v33; // x19
  __int64 v34; // x8
  __int64 v35; // x9
  _DWORD *v36; // x10
  __int64 v37; // x0
  __int64 v38; // x0
  int v39; // [xsp+Ch] [xbp-44h] BYREF
  __int128 v40; // [xsp+10h] [xbp-40h] BYREF

  if ( (byte_8FFEDCC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F4E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DCA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D32320);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9FD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9FE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CED538);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D69BB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66480);
    byte_8FFEDCC = 1;
  }
  v40 = 0u;
  if ( *(_DWORD *)self == 0 )
  {
    v40 = *((_OWORD *)self + 2);
    *((_QWORD *)self + 4) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
LABEL_57:
    if ( byte_8FFD1AF == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AF = 1;
    }
    v27 = v40;
    if ( (_QWORD)v40 != 0 )
    {
      v28 = *(_QWORD *)v40;
      v29 = WORD4(v40);
      v30 = *(unsigned __int16 *)(*(_QWORD *)v40 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v40 + 302LL) != 0 )
      {
        v31 = (_DWORD *)(*(_QWORD *)(v28 + 176) + 8LL);
        while ( *((_QWORD *)v31 - 1) != qword_8CE91C8 )
        {
          --v30;
          v31 += 4;
          if ( v30 == 0 )
            goto LABEL_64;
        }
        v32 = v28 + 16LL * (*v31 + 2) + 312;
      }
      else
      {
LABEL_64:
        v32 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v40, qword_8CE91C8, 2);
      }
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v32)(v27, v29, *(_QWORD *)(v32 + 8));
    }
    goto LABEL_67;
  }
  v3 = *((_QWORD *)self + 3);
  GameGlobalConfig = GameConfigModule_GameConfigManager__get_GameGlobalConfig(0, method);
  if ( GameGlobalConfig == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(GameGlobalConfig + 19) != 0 )
  {
    if ( UnityEngine_GameObject__Find(qword_8D66480, 0) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Component_object = UnityEngine_GameObject__GetComponent_object_();
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v3 + 32) = Component_object;
    if ( Component_object != 0
      && (v6 = *((unsigned __int8 *)off_8CE9FE0 + 304),
          *(unsigned __int8 *)(*(_QWORD *)Component_object + 304LL) >= (unsigned int)v6) )
    {
      if ( *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)Component_object + 200LL) + 8 * v6 - 8) == off_8CE9FE0 )
        v7 = Component_object;
      else
        v7 = 0;
    }
    else
    {
      v7 = 0;
    }
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) != 0 )
    {
      if ( v7 == 0 )
        goto LABEL_88;
      UIModuleO_LoadingPanel__SetProgressBarActive(v7, 1, 0);
    }
    v8 = *(_QWORD *)(v3 + 32);
    v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v39 = 0;
    v10 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CED538, &v39);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v11 = v10;
    if ( v10 == 0 || ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v10, *(_QWORD *)(*(_QWORD *)v9 + 64LL)) != 0 )
    {
      if ( *(_DWORD *)(v9 + 24) != 0 )
      {
        *(_QWORD *)(v9 + 32) = v11;
        if ( v8 != 0 )
        {
          (*(void (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)v8 + 456LL))(
            v8,
            v9,
            *(_QWORD *)(*(_QWORD *)v8 + 464LL));
          Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
          v13 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
          System_Action_object____ctor(v13, v3, qword_8D32320, 0);
          if ( Instance == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          EventModule_EventManager__StartListening(Instance, (void *)qword_8D69BB0, v13, nullptr);
          if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE40D8);
          persistentDataPath = UnityEngine_Application__get_persistentDataPath(0);
          v15 = off_8CE9FD0;
          if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE9FD0);
            v15 = off_8CE9FD0;
          }
          v16 = *(_QWORD *)(v15[23] + 16LL);
          if ( *((_DWORD *)off_8CEB838 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB838);
          *(_QWORD *)(*((_QWORD *)off_8CE9FD0 + 23) + 8LL) = System_IO_Path__Combine(persistentDataPath, v16, 0);
          if ( (((__int64 (*)(void))System_IO_Directory__Exists)() & 1) == 0 )
          {
            v17 = off_8CE9FD0;
            if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(off_8CE9FD0);
              v17 = off_8CE9FD0;
            }
            System_IO_Directory__CreateDirectory(*(_QWORD *)(v17[23] + 8LL), 0);
          }
          v18 = off_8CE9FD0;
          if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE9FD0);
            v18 = off_8CE9FD0;
          }
          if ( *(_QWORD *)(v18[23] + 8LL) == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v19 = sub_750BEDC();
          if ( (System_IO_Directory__Exists(v19, 0) & 1) == 0 )
            System_IO_Directory__CreateDirectory(v19, 0);
          if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEEDF8);
          *(_QWORD *)&v40 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.1);
          *((_QWORD *)&v40 + 1) = v20;
          if ( byte_8FFD1AD == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
            byte_8FFD1AD = 1;
          }
          if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEEDF8);
          if ( byte_8FFD1AE == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
            byte_8FFD1AE = 1;
          }
          v21 = v40;
          if ( (_QWORD)v40 != 0 )
          {
            v22 = *(_QWORD *)v40;
            v23 = WORD4(v40);
            v24 = *(unsigned __int16 *)(*(_QWORD *)v40 + 302LL);
            if ( *(_WORD *)(*(_QWORD *)v40 + 302LL) != 0 )
            {
              v25 = (int *)(*(_QWORD *)(v22 + 176) + 8LL);
              while ( *((_QWORD *)v25 - 1) != qword_8CE91C8 )
              {
                --v24;
                v25 += 4;
                if ( v24 == 0 )
                  goto LABEL_54;
              }
              v26 = v22 + 16LL * *v25 + 312;
            }
            else
            {
LABEL_54:
              v26 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v40, qword_8CE91C8, 0);
            }
            if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v26)(v21, v23, *(_QWORD *)(v26 + 8)) == 0 )
            {
              *(_DWORD *)self = 0;
              *((_OWORD *)self + 2) = v40;
              ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_409050C)(
                (char *)self + 8,
                &v40,
                self,
                qword_8D1F4E8);
              return;
            }
          }
          goto LABEL_57;
        }
      }
      else
      {
        ((void (*)(void))unk_3C3D4D4)();
      }
      il2cpp_codegen_raise_null_reference_exception();
    }
    v38 = ((__int64 (*)(void))unk_3C3D4F0)();
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v38, 0);
LABEL_88:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_67:
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v33 = *((__int64 **)self + 1);
  if ( v33 != nullptr )
  {
    v34 = *v33;
    v35 = *(unsigned __int16 *)(*v33 + 302);
    if ( *(_WORD *)(*v33 + 302) != 0 )
    {
      v36 = (_DWORD *)(*(_QWORD *)(v34 + 176) + 8LL);
      while ( *((_QWORD *)v36 - 1) != qword_8CE9038 )
      {
        --v35;
        v36 += 4;
        if ( v35 == 0 )
          goto LABEL_74;
      }
      v37 = v34 + 16LL * (*v36 + 2) + 312;
    }
    else
    {
LABEL_74:
      v37 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v33, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v37)(v33, *(_QWORD *)(v37 + 8));
  }
}
