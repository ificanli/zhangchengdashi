// local variable allocation has failed, the output may be wrong!
void *Oke______D__S(void *key, unsigned __int8 useServer, const MethodInfo *method)
{
  void *v5; // x20
  __int64 Instance; // x0
  _QWORD *v7; // x8
  __int64 v8; // x0
  __int64 v9; // x21
  __int64 v10; // x0
  __int64 v11; // x0
  void *FileBytes; // x0
  void *v13; // x22
  __int64 Default; // x0
  __int64 v15; // x22
  __int64 v16; // x0
  unsigned int v17; // w8
  __int64 v18; // x0
  __int64 v19; // x21
  __int64 v20; // x0
  __int64 v22; // x0
  __int64 v23; // x0
  __int64 v24; // x21
  int v25; // w1
  _QWORD **v26; // x21
  __int64 v27; // x0
  _QWORD *v28; // x21
  __int64 Type; // x0
  __int64 v30; // x23
  _DWORD *v31; // x0
  __int64 v32; // x22
  __int64 v33; // x0
  __int64 v34; // x20
  __int64 v35; // x23
  __int64 v36; // x0
  __int64 v37; // x0
  __int64 v38; // x0
  __int64 v39; // x20
  __int64 v40; // x22
  __int64 v41; // x23
  __int64 v42; // x0
  __int64 v43; // x0
  __int64 v44; // x19
  __int64 v45; // x0
  _DWORD *v46; // x0
  __int64 v47; // x0

  if ( (byte_90091A6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7D7B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66710);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EA0);
    byte_90091A6 = 1;
  }
  v5 = (void *)qword_8D4ECC0;
  if ( (useServer & 1) != 0 )
  {
    Instance = GamePath__get_Instance(0, useServer, method);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v7 = (_QWORD *)(Instance + 64);
  }
  else
  {
    v8 = GamePath__get_Instance(0, useServer, method);
    if ( v8 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v7 = (_QWORD *)(v8 + 72);
  }
  v9 = sub_750A330(*v7, key, qword_8D52E08, 0);
  v10 = GameFramework_Tools_FileManager__get_Instance(0);
  if ( v10 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (GameFramework_Tools_FileManager__IsFileExists(v10, v9, 0) & 1) != 0 )
  {
    v11 = GameFramework_Tools_FileManager__get_Instance(0);
    if ( v11 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    FileBytes = (void *)GameFramework_Tools_FileManager__ReadFileBytes(v11, v9, 0);
    v13 = GameFramework_Tools_UIGradientBlender__SplitColors(FileBytes, (void *)qword_8D7D7B0, nullptr);
    Default = System_Text_Encoding__get_Default(0);
    if ( Default == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v5 = (void *)(*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)Default + 888LL))(
                   Default,
                   v13,
                   *(_QWORD *)(*(_QWORD *)Default + 896LL));
    v15 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v16 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 5);
    if ( v16 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v17 = *(_DWORD *)(v16 + 24);
    if ( v17 != 0 )
    {
      *(_QWORD *)(v16 + 32) = qword_8D66710;
      if ( v17 != 1 )
      {
        *(_QWORD *)(v16 + 40) = v9;
        if ( v17 > 2 )
        {
          *(_QWORD *)(v16 + 48) = qword_8D78EC8;
          if ( v17 != 3 )
          {
            *(_QWORD *)(v16 + 56) = v5;
            if ( v17 > 4 )
            {
              *(_QWORD *)(v16 + 64) = qword_8D78EA0;
              v18 = System_String__Concat();
              if ( v15 != 0 )
              {
                v19 = v18;
                if ( v18 == 0
                  || (v20 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                              v18,
                              *(_QWORD *)(*(_QWORD *)v15 + 64LL))) != 0 )
                {
                  if ( *(_DWORD *)(v15 + 24) != 0 )
                  {
                    *(_QWORD *)(v15 + 32) = v19;
                    if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                      il2cpp_codegen_runtime_class_init(off_8CE5250);
                    GameFramework_CLog___y_Eo_(v15, 0);
                    return v5;
                  }
                  v20 = ((__int64 (*)(void))unk_3C3D4D4)();
                }
                v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v20);
                v23 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v22, 0);
                v24 = v23;
                if ( v25 == 1 )
                {
                  v26 = (_QWORD **)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v23);
                  v27 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
                  if ( (((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D8F8)(v27, **v26) & 1) == 0 )
                  {
                    *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8) = *v26;
                    ((void (__noreturn *)(void))__cxa_throw)();
                  }
                  v28 = *v26;
                  ((void (*)(void))__cxa_end_catch)();
                  if ( v28 == nullptr )
                    goto LABEL_53;
                  Type = System_Exception__GetType(v28, 0);
                  if ( Type == 0 )
                    goto LABEL_53;
                  v30 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 440LL))(
                          Type,
                          *(_QWORD *)(*(_QWORD *)Type + 448LL));
                  v31 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CEC810);
                  if ( v31[56] == 0 )
                    il2cpp_codegen_runtime_class_init(v31);
                  v32 = *(_QWORD *)(*(_QWORD *)(((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CEC810) + 184)
                                  + 8LL);
                  v33 = sub_74FE7A4(v30, v5, 0);
                  v34 = UnityEngine_Networking_UnityWebRequest__EscapeURL(v33, 0);
                  v35 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D81B70);
                  v36 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D4FB18);
                  v37 = sub_750A63C(v35, key, v36, v34, 0);
                  if ( v32 == 0
                    || (DBTSDK_ReportManager__Reportclient_Event(v32, 1006, v37, 0),
                        v38 = ((__int64 (__fastcall *)(__int64 *))unk_3C3D294)(&qword_8CE3258),
                        v39 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(v38, 1),
                        v40 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D79238),
                        v41 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D886C0),
                        v42 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*v28 + 360LL))(
                                v28,
                                *(_QWORD *)(*v28 + 368LL)),
                        v43 = sub_750A63C(v41, key, v40, v42, 0),
                        v39 == 0) )
                  {
LABEL_53:
                    il2cpp_codegen_raise_null_reference_exception();
                  }
                  v44 = v43;
                  if ( v43 == 0
                    || (v45 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                                v43,
                                *(_QWORD *)(*(_QWORD *)v39 + 64LL))) != 0 )
                  {
                    if ( *(_DWORD *)(v39 + 24) != 0 )
                    {
                      *(_QWORD *)(v39 + 32) = v44;
                      v46 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CE5250);
                      if ( v46[56] == 0 )
                        il2cpp_codegen_runtime_class_init(v46);
                      GameFramework_CLog__Error(v39, 0);
                      JUMPOUT(0x3C3D294);
                    }
                    v45 = ((__int64 (*)(void))unk_3C3D4D4)();
                  }
                  v47 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v45);
                  v24 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v47, 0);
                  ((void (*)(void))__cxa_end_catch)();
                }
                sub_3CE73C4(v24);
              }
LABEL_37:
              il2cpp_codegen_raise_null_reference_exception();
            }
LABEL_36:
            ((void (__fastcall *)(__int64))unk_3C3D4D4)(v16);
            goto LABEL_37;
          }
LABEL_35:
          v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v16);
          goto LABEL_36;
        }
LABEL_34:
        v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v16);
        goto LABEL_35;
      }
    }
    else
    {
      v16 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
    v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v16);
    goto LABEL_34;
  }
  return v5;
}
