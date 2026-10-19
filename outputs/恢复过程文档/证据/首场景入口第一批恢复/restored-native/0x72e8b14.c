void GameFramework_Base_GameStartEntry____f___(void *self, const MethodInfo *method)
{
  __int64 Module_object; // x0
  _QWORD *v4; // x21
  __int64 v5; // x20
  __int64 v6; // x8
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0
  _QWORD *v10; // x21
  __int64 v11; // x20
  __int64 v12; // x8
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x0
  _QWORD *v16; // x21
  __int64 v17; // x20
  __int64 v18; // x8
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x0
  _QWORD *v22; // x21
  __int64 v23; // x20
  __int64 v24; // x8
  __int64 v25; // x0
  __int64 v26; // x0
  __int64 v27; // x0
  _QWORD *v28; // x21
  __int64 v29; // x20
  __int64 v30; // x8
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 v33; // x0
  _QWORD *v34; // x21
  __int64 v35; // x20
  __int64 v36; // x8
  __int64 v37; // x0
  __int64 v38; // x0
  __int64 v39; // x20
  __int64 v40; // x21
  _QWORD *v41; // x19
  __int64 v42; // x8
  __int64 v43; // x0
  __int64 v44; // x0

  if ( (byte_900A04F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D140);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D158);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D160);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2E178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D758A0);
    byte_900A04F = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D758A0);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D158);
  v4 = off_8D1D5E8;
  v5 = Module_object;
  v6 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v6 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v6 = v4[7];
  }
  v7 = *(_QWORD *)(v6 + 16);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v7 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v7);
  v8 = *(_QWORD *)(v4[7] + 16LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v5, 0, **(_QWORD **)(v8 + 184), 0);
  v9 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D148);
  v10 = off_8D1D5E8;
  v11 = v9;
  v12 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v12 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v12 = v10[7];
  }
  v13 = *(_QWORD *)(v12 + 16);
  if ( (*(_BYTE *)(v13 + 309) & 1) == 0 )
    v13 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v13 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v13);
  v14 = *(_QWORD *)(v10[7] + 16LL);
  if ( (*(_BYTE *)(v14 + 309) & 1) == 0 )
    v14 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v11, 0, **(_QWORD **)(v14 + 184), 0);
  v15 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D160);
  v16 = off_8D1D5E8;
  v17 = v15;
  v18 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v18 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v18 = v16[7];
  }
  v19 = *(_QWORD *)(v18 + 16);
  if ( (*(_BYTE *)(v19 + 309) & 1) == 0 )
    v19 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v19 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v19);
  v20 = *(_QWORD *)(v16[7] + 16LL);
  if ( (*(_BYTE *)(v20 + 309) & 1) == 0 )
    v20 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v17, 0, **(_QWORD **)(v20 + 184), 0);
  v21 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D188);
  v22 = off_8D1D5E8;
  v23 = v21;
  v24 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v24 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v24 = v22[7];
  }
  v25 = *(_QWORD *)(v24 + 16);
  if ( (*(_BYTE *)(v25 + 309) & 1) == 0 )
    v25 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v25 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v25);
  v26 = *(_QWORD *)(v22[7] + 16LL);
  if ( (*(_BYTE *)(v26 + 309) & 1) == 0 )
    v26 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v23, 0, **(_QWORD **)(v26 + 184), 0);
  v27 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D140);
  v28 = off_8D1D5E8;
  v29 = v27;
  v30 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v30 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v30 = v28[7];
  }
  v31 = *(_QWORD *)(v30 + 16);
  if ( (*(_BYTE *)(v31 + 309) & 1) == 0 )
    v31 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v31 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v31);
  v32 = *(_QWORD *)(v28[7] + 16LL);
  if ( (*(_BYTE *)(v32 + 309) & 1) == 0 )
    v32 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v29, 0, **(_QWORD **)(v32 + 184), 0);
  v33 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D168);
  v34 = off_8D1D5E8;
  v35 = v33;
  v36 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v36 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v36 = v34[7];
  }
  v37 = *(_QWORD *)(v36 + 16);
  if ( (*(_BYTE *)(v37 + 309) & 1) == 0 )
    v37 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v37 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v37);
  v38 = *(_QWORD *)(v34[7] + 16LL);
  if ( (*(_BYTE *)(v38 + 309) & 1) == 0 )
    v38 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v35, 0, **(_QWORD **)(v38 + 184), 0);
  v39 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D170);
  v40 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
  System_Action___ctor(v40, self, qword_8D2E178, 0);
  v41 = off_8D1D5E8;
  v42 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v42 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v42 = v41[7];
  }
  v43 = *(_QWORD *)(v42 + 16);
  if ( (*(_BYTE *)(v43 + 309) & 1) == 0 )
    v43 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v43 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v43);
  v44 = *(_QWORD *)(v41[7] + 16LL);
  if ( (*(_BYTE *)(v44 + 309) & 1) == 0 )
    v44 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(v39, v40, **(_QWORD **)(v44 + 184), 0);
}
