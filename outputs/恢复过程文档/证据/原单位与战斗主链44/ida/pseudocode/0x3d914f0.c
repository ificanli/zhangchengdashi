__int64 __fastcall GameModule_RoleBehaviour__Dizzy_d__101__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  float v3; // s0
  float v4; // s1
  __int64 v5; // x21
  __int64 v6; // x0
  __int64 v7; // x21
  void *Instance; // x0
  __int128 v9; // q0
  __int128 v11; // q0
  __int64 *v12; // x21
  unsigned int v13; // w22
  __int64 v14; // x0
  __int64 v15; // x1
  __int64 v16; // x8
  __int64 v17; // x9
  int *v18; // x10
  __int64 v19; // x0
  __int64 v20; // x21
  __int64 v21; // x0
  __int64 transform; // x21
  __int64 v23; // x1
  __int64 v24; // x0
  float v25; // s8
  __int64 v26; // x0
  __int64 v27; // x21
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 v30; // x21
  __int64 v31; // x0
  __int64 v32; // x0
  __int128 v33; // [xsp+8h] [xbp-98h] BYREF
  __int64 v34; // [xsp+18h] [xbp-88h]
  __int128 v35; // [xsp+20h] [xbp-80h]
  __int64 v36; // [xsp+30h] [xbp-70h]
  __int128 v37; // [xsp+40h] [xbp-60h] BYREF
  __int64 v38; // [xsp+50h] [xbp-50h]

  if ( (byte_8FFD4C0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21C88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF9920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF9928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34FB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57D50);
    byte_8FFD4C0 = 1;
  }
  v37 = 0u;
  v38 = 0;
  v35 = 0u;
  v36 = 0;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 == 0 )
  {
    v11 = *(_OWORD *)(a1 + 56);
    v38 = *(_QWORD *)(a1 + 72);
    v37 = v11;
    *(_QWORD *)(a1 + 64) = 0;
    *(_QWORD *)(a1 + 72) = 0;
    *(_QWORD *)(a1 + 56) = 0;
    *(_DWORD *)a1 = -1;
LABEL_20:
    v12 = (__int64 *)v37;
    if ( (_QWORD)v37 != 0 )
    {
      v13 = (unsigned __int16)v38;
      v14 = *((_QWORD *)off_8CF9920 + 4);
      if ( (*(_BYTE *)(v14 + 309) & 1) == 0 )
        v14 = ((__int64 (*)(void))unk_3C503A0)();
      v15 = *(_QWORD *)(*(_QWORD *)(v14 + 192) + 40LL);
      if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
        v15 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v14 + 192) + 40LL));
      v16 = *v12;
      v17 = *(unsigned __int16 *)(*v12 + 302);
      if ( *(_WORD *)(*v12 + 302) != 0 )
      {
        v18 = (int *)(*(_QWORD *)(v16 + 176) + 8LL);
        while ( *((_QWORD *)v18 - 1) != v15 )
        {
          --v17;
          v18 += 4;
          if ( v17 == 0 )
            goto LABEL_29;
        }
        v19 = v16 + 16LL * *v18 + 312;
      }
      else
      {
LABEL_29:
        v19 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v12, v15, 0);
      }
      v20 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v19)(v12, v13, *(_QWORD *)(v19 + 8));
    }
    else
    {
      v20 = *((_QWORD *)&v37 + 1);
    }
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v21 = UnityEngine_Object__Instantiate_object_(v20, qword_8D34FB0);
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v2 + 416) = v21;
    if ( v21 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    transform = UnityEngine_GameObject__get_transform(v21, 0);
    v23 = UnityEngine_Component__get_transform(v2, 0);
    if ( transform == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    sub_82F9798(transform, v23, 1, 0);
    v24 = UnityEngine_Component__get_transform(v2, 0);
    if ( v24 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v25 = COERCE_FLOAT(COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_lossyScale(v24, 0)));
    v26 = *(_QWORD *)(v2 + 416);
    if ( v25 <= 0.001 )
    {
      if ( v26 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v30 = UnityEngine_GameObject__get_transform(v26, 0);
      if ( byte_8FFD01F == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
        byte_8FFD01F = 1;
      }
      if ( v30 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__set_localScale(
        v30,
        0,
        *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 12LL),
        *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 16LL),
        *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 20LL));
      v31 = *(_QWORD *)(v2 + 416);
      if ( v31 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v32 = UnityEngine_GameObject__get_transform(v31, 0);
      if ( v32 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__set_localPosition(v32, 0, 0.0, 2.0, 0.0);
    }
    else
    {
      if ( v26 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v27 = UnityEngine_GameObject__get_transform(v26, 0);
      if ( byte_8FFD01F == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
        byte_8FFD01F = 1;
      }
      if ( v27 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__set_localScale(
        v27,
        0,
        (float)(1.0 / v25) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 12LL),
        (float)(1.0 / v25) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 16LL),
        (float)(1.0 / v25) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 20LL));
      v28 = *(_QWORD *)(v2 + 416);
      if ( v28 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v29 = UnityEngine_GameObject__get_transform(v28, 0);
      if ( v29 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__set_localPosition(v29, 0, 0.0, 2.0 / v25, 0.0);
    }
    goto LABEL_54;
  }
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_BYTE *)(v2 + 404) = 1;
  v3 = *(float *)(v2 + 408);
  v4 = *(float *)(a1 + 48);
  *(_BYTE *)(v2 + 576) = 0;
  *(float *)(v2 + 408) = v3 + v4;
  if ( (GameModule_RoleBehaviour__ShouldUseWebGLPathfindingTuning(0) & 1) == 0 )
  {
    v5 = *(_QWORD *)(v2 + 128);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v5, 0, 0) & 1) != 0 )
    {
      v6 = *(_QWORD *)(v2 + 128);
      if ( v6 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Behaviour__set_enabled(v6, 0, 0);
    }
  }
  sub_3D7F628(v2, 0, 0, 0);
  GameModule_RoleBehaviour__SetAiCanMove(v2, 0, 0);
  v7 = *(_QWORD *)(v2 + 416);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) == 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12008);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    AssetsModule_AssetsManager__LoadAssetAsync_object_(&v33, Instance, qword_8D57D50, qword_8D1E008);
    v35 = v33;
    v36 = v34;
    if ( (*(_BYTE *)(*((_QWORD *)off_8D19980 + 4) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    v37 = v35;
    v38 = v36;
    if ( (((__int64 (__fastcall *)(__int128 *, __int64))unk_35BD764)(&v37, qword_8CF9928) & 1) == 0 )
    {
      *(_DWORD *)a1 = 0;
      v9 = v37;
      *(_QWORD *)(a1 + 72) = v38;
      *(_OWORD *)(a1 + 56) = v9;
      return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___RoleBehaviour__Dizzy_d__101_(
               a1 + 8,
               &v37,
               a1,
               qword_8D21C88);
    }
    goto LABEL_20;
  }
LABEL_54:
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
