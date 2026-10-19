__int64 __fastcall GameModule_RoleBehaviour__Atk_d__198__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  int v3; // w8
  __int64 transform; // x21
  __int64 v5; // x0
  long double v6; // q0
  long double v7; // q1
  long double v8; // q2
  long double v9; // q3
  __int64 v10; // x0
  long double v11; // q8
  long double v12; // q9
  long double v13; // q10
  long double v14; // q11
  __int64 v15; // x0
  long double position; // q0
  long double XZDirection; // q12
  long double v18; // q1
  long double v19; // q13
  long double v20; // q2
  long double v21; // q14
  long double v22; // q4
  long double v23; // q1
  long double v24; // q2
  long double v25; // q3
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x21
  __int64 v29; // x0
  long double v30; // q0
  long double v31; // q1
  long double v32; // q2
  long double v33; // q3
  __int64 v34; // x0
  long double v35; // q8
  long double v36; // q9
  long double v37; // q10
  long double v38; // q11
  __int64 v39; // x0
  long double v40; // q0
  long double v41; // q12
  long double v42; // q1
  long double v43; // q13
  long double v44; // q2
  long double v45; // q14
  long double v46; // q4
  long double v47; // q1
  long double v48; // q2
  long double v49; // q3
  __int64 v50; // x0
  long double v51; // q0
  int v52; // s1
  int v53; // s2
  __int64 v54; // x21
  int v55; // w8
  __int64 v56; // x9
  float v57; // s8
  __int64 v58; // x1
  __int64 v59; // x8
  __int64 v60; // x9
  int *v61; // x10
  __int64 v62; // x0
  __int64 v63; // x8
  __int64 v64; // x9
  _DWORD *v65; // x10
  __int64 v66; // x0
  double v68; // [xsp+0h] [xbp-90h]
  __int128 v69; // [xsp+10h] [xbp-80h] BYREF

  if ( (byte_8FFD4BB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D22510);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0E290);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E298);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD4BB = 1;
  }
  v69 = 0u;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 == 0 )
  {
    v69 = *(_OWORD *)(a1 + 56);
    *(_QWORD *)(a1 + 56) = 0;
    *(_QWORD *)(a1 + 64) = 0;
    *(_DWORD *)a1 = -1;
    goto LABEL_62;
  }
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(v2 + 188) != 0 )
    goto LABEL_75;
  GameModule_RoleBehaviour__SetAnimation(*(_QWORD *)(a1 + 40), 3, 0, 0, 0);
  v3 = *(_DWORD *)(v2 + 72);
  if ( v3 != 0 )
  {
    if ( v3 != 1 )
      goto LABEL_27;
    transform = UnityEngine_Component__get_transform(v2, 0);
    v5 = UnityEngine_Component__get_transform(v2, 0);
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_Transform__get_rotation(v5, 0);
    v10 = *(_QWORD *)(v2 + 88);
    if ( v10 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v11 = v6;
    v12 = v7;
    v13 = v8;
    v14 = v9;
    v15 = UnityEngine_Component__get_transform(v10, 0);
    if ( v15 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(v15, 0);
    XZDirection = GameModule_RoleBehaviour__GetXZDirection(v2, 0, position);
    v19 = v18;
    v21 = v20;
    if ( byte_8FFCFFE == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
      byte_8FFCFFE = 1;
    }
    v22 = UnityEngine_Quaternion__LookRotation(
            0,
            XZDirection,
            v19,
            v21,
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 24LL),
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 28LL),
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 32LL));
    LODWORD(v68) = 1061997773;
    UnityEngine_Quaternion__Lerp(0, v11, v12, v13, v14, v22, v23, v24, v25, v68);
    if ( transform == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_Transform__set_rotation(transform, 0);
    v26 = *(_QWORD *)(v2 + 88);
    *(_QWORD *)(v2 + 104) = v26;
    if ( v26 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v27 = UnityEngine_Component__get_transform(v26, 0);
    if ( v27 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
  }
  else
  {
    v28 = UnityEngine_Component__get_transform(v2, 0);
    v29 = UnityEngine_Component__get_transform(v2, 0);
    if ( v29 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_Transform__get_rotation(v29, 0);
    v34 = *(_QWORD *)(v2 + 80);
    if ( v34 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v35 = v30;
    v36 = v31;
    v37 = v32;
    v38 = v33;
    v39 = UnityEngine_Component__get_transform(v34, 0);
    if ( v39 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v40 = UnityEngine_Transform__get_position(v39, 0);
    v41 = GameModule_RoleBehaviour__GetXZDirection(v2, 0, v40);
    v43 = v42;
    v45 = v44;
    if ( byte_8FFCFFE == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
      byte_8FFCFFE = 1;
    }
    v46 = UnityEngine_Quaternion__LookRotation(
            0,
            v41,
            v43,
            v45,
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 24LL),
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 28LL),
            *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 32LL));
    LODWORD(v68) = 1061997773;
    UnityEngine_Quaternion__Lerp(0, v35, v36, v37, v38, v46, v47, v48, v49, v68);
    if ( v28 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_Transform__set_rotation(v28, 0);
    v50 = *(_QWORD *)(v2 + 80);
    *(_QWORD *)(v2 + 104) = v50;
    if ( v50 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v27 = UnityEngine_Component__get_transform(v50, 0);
    if ( v27 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
  }
  v51 = UnityEngine_Transform__get_position(v27, 0);
  *(_DWORD *)(v2 + 560) = LODWORD(v51);
  *(_DWORD *)(v2 + 564) = v52;
  *(_DWORD *)(v2 + 568) = v53;
LABEL_27:
  v54 = *(_QWORD *)(v2 + 80);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v54, 0, 0) & 1) == 0 )
  {
    v55 = 0;
    for ( *(_DWORD *)(a1 + 52) = 0; ; *(_DWORD *)(a1 + 52) = v55 )
    {
      v56 = *(_QWORD *)(v2 + 304);
      if ( v56 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v55 >= *(_DWORD *)(v56 + 24) )
        break;
      LODWORD(v57) = COERCE_UNSIGNED_INT128(
                       System_Collections_Generic_List_float___get_Item(
                         *(_QWORD *)(v2 + 304),
                         (unsigned int)v55,
                         qword_8D0E298));
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      *(_QWORD *)&v69 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, v57);
      *((_QWORD *)&v69 + 1) = v58;
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
      if ( (_QWORD)v69 != 0 )
      {
        v59 = *(_QWORD *)v69;
        v60 = *(unsigned __int16 *)(*(_QWORD *)v69 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v69 + 302LL) != 0 )
        {
          v61 = (int *)(*(_QWORD *)(v59 + 176) + 8LL);
          while ( *((_QWORD *)v61 - 1) != qword_8CE91C8 )
          {
            --v60;
            v61 += 4;
            if ( v60 == 0 )
              goto LABEL_59;
          }
          v62 = v59 + 16LL * *v61 + 312;
        }
        else
        {
LABEL_59:
          v62 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v69, qword_8CE91C8, 0);
        }
        if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v62)(v69, WORD4(v69), *(_QWORD *)(v62 + 8)) == 0 )
        {
          *(_DWORD *)a1 = 0;
          *(_OWORD *)(a1 + 56) = v69;
          return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__RoleBehaviour__Atk_d__198_(
                   a1 + 8,
                   &v69,
                   a1,
                   qword_8D22510);
        }
      }
LABEL_62:
      if ( byte_8FFD1AF == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AF = 1;
      }
      if ( (_QWORD)v69 != 0 )
      {
        v63 = *(_QWORD *)v69;
        v64 = *(unsigned __int16 *)(*(_QWORD *)v69 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v69 + 302LL) != 0 )
        {
          v65 = (_DWORD *)(*(_QWORD *)(v63 + 176) + 8LL);
          while ( *((_QWORD *)v65 - 1) != qword_8CE91C8 )
          {
            --v64;
            v65 += 4;
            if ( v64 == 0 )
              goto LABEL_69;
          }
          v66 = v63 + 16LL * (*v65 + 2) + 312;
        }
        else
        {
LABEL_69:
          v66 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v69, qword_8CE91C8, 2);
        }
        (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v66)(v69, WORD4(v69), *(_QWORD *)(v66 + 8));
      }
      if ( v2 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v2 + 33) != 0 )
        break;
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v2 + 792LL))(
        v2,
        *(unsigned int *)(a1 + 48),
        *(_QWORD *)(*(_QWORD *)v2 + 800LL));
      v55 = *(_DWORD *)(a1 + 52) + 1;
    }
  }
LABEL_75:
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
