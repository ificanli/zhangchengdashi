void GameFramework_Base_GameStartEntry__vj____(void *self, const MethodInfo *method)
{
  void *v3; // x0
  _QWORD *v4; // x0
  __int64 NewResModule; // x20
  __int64 v6; // x0
  unsigned int v7; // w0
  _QWORD *v8; // x8
  unsigned int v9; // w21
  unsigned int v10; // w22
  __int64 v11; // x23
  __int64 v12; // x24
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x24
  __int64 v16; // x0
  __int64 v17; // x23
  __int64 v18; // x0
  __int64 v19; // x1
  __int64 v20; // x2
  __int64 Module_object; // x20
  __int64 v22; // x21
  _QWORD *v23; // x19
  __int64 v24; // x8
  __int64 v25; // x0
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x22
  __int64 v29; // x23
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x23
  __int64 v33; // x22
  __int64 v34; // x0
  _QWORD v35[2]; // [xsp+0h] [xbp-70h] BYREF
  int v36; // [xsp+10h] [xbp-60h]
  _QWORD v37[2]; // [xsp+18h] [xbp-58h] BYREF
  unsigned int v38; // [xsp+28h] [xbp-48h]

  if ( (byte_900A035 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE6D08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEE1A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D77540);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D50340);
    byte_900A035 = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D77540);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v3 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v3 = off_8CE40C8;
  }
  if ( *(_BYTE *)(*((_QWORD *)v3 + 23) + 56LL) != 0 )
  {
    if ( *((_DWORD *)v3 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(v3);
    if ( byte_900876E == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
      byte_900876E = 1;
    }
    v4 = off_8CE40C8;
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v4 = off_8CE40C8;
    }
    NewResModule = GameFramework_NewResLoadHelper__GetNewResModule(*(unsigned __int8 *)(v4[23] + 61LL), 0);
    if ( (GameFramework_AppSetting__get_IsXYXEnvironment(0) & 1) == 0 )
      goto LABEL_20;
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    if ( (GameFramework_AppSetting__get_IsXYXNativeMode(0) & 1) == 0 )
    {
      v27 = *((_QWORD *)self + 10);
      if ( v27 != 0 )
      {
        v9 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v27 + 536LL))(
               v27,
               *(_QWORD *)(*(_QWORD *)v27 + 544LL));
        v28 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        v38 = v9;
        v37[0] = qword_8CEE1A0;
        v37[1] = -1;
        v29 = System_Enum__ToString(v37, 0);
        v36 = 4;
        v35[0] = qword_8CE6D08;
        v35[1] = -1;
        v30 = System_Enum__ToString(v35, 0);
        v31 = System_String__Concat(qword_8D7C460, v29, qword_8D50340, v30, 0);
        if ( v28 != 0 )
        {
          v32 = v31;
          if ( v31 == 0
            || (v16 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v31, *(_QWORD *)(*(_QWORD *)v28 + 64LL))) != 0 )
          {
            if ( *(_DWORD *)(v28 + 24) != 0 )
            {
              *(_QWORD *)(v28 + 32) = v32;
              if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE5250);
              GameFramework_CLog__Log(v28, 0);
              v33 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
              System_Action___ctor(v33, self, qword_8D2E180, 0);
              v20 = 4;
              v18 = NewResModule;
              v19 = v33;
              goto LABEL_48;
            }
            goto LABEL_50;
          }
LABEL_51:
          v34 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v16);
          ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v34, 0);
          JUMPOUT(0x72E632C);
        }
      }
    }
    else
    {
LABEL_20:
      v6 = *((_QWORD *)self + 10);
      if ( v6 != 0 )
      {
        v7 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v6 + 536LL))(
               v6,
               *(_QWORD *)(*(_QWORD *)v6 + 544LL));
        v8 = *((_QWORD **)self + 10);
        if ( v8 != nullptr )
        {
          v9 = v7;
          v10 = (unsigned int)(*(_QWORD *(__fastcall **)(_QWORD *__return_ptr, _QWORD, _QWORD))(*v8 + 552LL))(
                                v8,
                                *((_QWORD *)self + 10),
                                *(_QWORD *)(*v8 + 560LL));
          v11 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
          v38 = v9;
          v37[0] = qword_8CEE1A0;
          v37[1] = -1;
          v12 = System_Enum__ToString(v37, 0);
          v36 = v10;
          v35[0] = qword_8CE6D08;
          v35[1] = -1;
          v13 = System_Enum__ToString(v35, 0);
          v14 = System_String__Concat(qword_8D7C458, v12, qword_8D50340, v13, 0);
          if ( v11 != 0 )
          {
            v15 = v14;
            if ( v14 == 0
              || (v16 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v14, *(_QWORD *)(*(_QWORD *)v11 + 64LL))) != 0 )
            {
              if ( *(_DWORD *)(v11 + 24) != 0 )
              {
                *(_QWORD *)(v11 + 32) = v15;
                if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                  il2cpp_codegen_runtime_class_init(off_8CE5250);
                GameFramework_CLog__Log(v11, 0);
                v17 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
                System_Action___ctor(v17, self, qword_8D2E180, 0);
                v18 = NewResModule;
                v19 = v17;
                v20 = v10;
LABEL_48:
                GameFramework_NewResLoadHelper__Initialize(v18, v19, v20, v9, 0);
                return;
              }
LABEL_50:
              v16 = ((__int64 (*)(void))unk_3C3D4D4)();
              goto LABEL_51;
            }
            goto LABEL_51;
          }
        }
      }
    }
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D138);
  v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
  System_Action___ctor(v22, self, qword_8D2E180, 0);
  v23 = off_8D1D5E8;
  v24 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v24 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v24 = v23[7];
  }
  v25 = *(_QWORD *)(v24 + 16);
  if ( (*(_BYTE *)(v25 + 309) & 1) == 0 )
    v25 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v25 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v25);
  v26 = *(_QWORD *)(v23[7] + 16LL);
  if ( (*(_BYTE *)(v26 + 309) & 1) == 0 )
    v26 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(Module_object, v22, **(_QWORD **)(v26 + 184), 0);
}
