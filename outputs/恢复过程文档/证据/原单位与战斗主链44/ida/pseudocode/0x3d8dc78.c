void __fastcall GameModule_RoleBehaviour__Shock(
        __int64 a1,
        unsigned int a2,
        long double a3,
        long double a4,
        long double a5,
        long double a6)
{
  __int64 v12; // x0
  __int64 transform; // x0
  float v14; // s12
  float v15; // s1
  float v16; // s13
  float v17; // s2
  float v18; // s14
  float v19; // s12
  float v20; // s10
  float v21; // s11
  float v22; // s0
  _DWORD *v23; // x8
  __int64 v24; // x0
  long double position; // q0
  float v26; // s1
  float v27; // s2
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 v30; // x20
  __int64 v31; // x21
  __int64 v32; // x22
  _QWORD *v33; // x0
  __int64 v34; // x1

  if ( (byte_8FFD4AF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D37E38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEEA18);
    byte_8FFD4AF = 1;
  }
  if ( *(_QWORD *)(a1 + 64) != 0 )
  {
    v12 = *(_QWORD *)(a1 + 696);
    if ( v12 != 0 )
      DG_Tweening_TweenExtensions__Kill(v12, 0, 0);
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD, __int64, __int64, _QWORD, _QWORD))(*(_QWORD *)a1 + 376LL))(
      a1,
      a2,
      **((_QWORD **)off_8CEDAE8 + 23),
      0,
      0,
      0,
      2,
      4,
      0,
      *(_QWORD *)(*(_QWORD *)a1 + 384LL));
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( transform == 0 )
      goto LABEL_24;
    LODWORD(v14) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
    v16 = v15;
    v18 = v17;
    if ( byte_8FFCFFC == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFCFFC = 1;
    }
    v19 = v14 - *(float *)&a3;
    v20 = v16 - *(float *)&a4;
    v21 = v18 - *(float *)&a5;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    v22 = sqrtf((float)(v21 * v21) + (float)((float)(v19 * v19) + (float)(v20 * v20)));
    if ( v22 <= 0.00001 )
    {
      if ( byte_8FFCFFD == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
        byte_8FFCFFD = 1;
      }
      v23 = *((_DWORD **)off_8CEF3D8 + 23);
      LODWORD(a5) = *v23;
      LODWORD(a4) = v23[1];
      LODWORD(a3) = v23[2];
    }
    else
    {
      *(float *)&a5 = v19 / v22;
      *(float *)&a4 = v20 / v22;
      *(float *)&a3 = v21 / v22;
    }
    v24 = UnityEngine_Component__get_transform(a1, 0);
    if ( v24 == 0 )
      goto LABEL_24;
    position = UnityEngine_Transform__get_position(v24, 0);
    *(float *)&a5 = (float)(*(float *)&a5 * *(float *)&a6) + *(float *)&position;
    *(float *)&a4 = (float)(*(float *)&a4 * *(float *)&a6) + v26;
    *(float *)&a3 = (float)(*(float *)&a3 * *(float *)&a6) + v27;
    *(_BYTE *)(a1 + 688) = 1;
    v28 = UnityEngine_Component__get_transform(a1, 0);
    *(float *)&a6 = *(float *)&a6 * 0.16667;
    v29 = DG_Tweening_ShortcutExtensions__DOMove(v28, 0, 0, a5, a4, a3, a6);
    *(_QWORD *)(a1 + 696) = v29;
    if ( v29 == 0 )
LABEL_24:
      il2cpp_codegen_raise_null_reference_exception();
    v30 = v29;
    v31 = *(_QWORD *)(v29 + 128);
    v32 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEEA18);
    DG_Tweening_TweenCallback___ctor(v32, a1, qword_8D37E38, 0);
    v33 = (_QWORD *)System_Delegate__Combine(v31, v32, 0);
    if ( v33 == nullptr )
      goto LABEL_22;
    v34 = qword_8CEEA18;
    if ( *v33 != qword_8CEEA18 || (*(_QWORD *)(v30 + 128) = v33, *v33 != v34) )
    {
      v33 = (_QWORD *)((__int64 (*)(void))unk_3C3D868)();
LABEL_22:
      *(_QWORD *)(v30 + 128) = v33;
    }
  }
}
