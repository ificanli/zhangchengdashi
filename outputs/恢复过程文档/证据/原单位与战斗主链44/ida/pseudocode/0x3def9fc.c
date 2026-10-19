__int64 __fastcall GameModule_BattleGameSceneManager__TryGetWebGLArchitectureAtOrNearPosition(
        long double a1,
        long double a2,
        long double a3,
        __int64 a4,
        char a5,
        __int64 a6,
        __int64 *a7)
{
  _QWORD *v13; // x22
  char v14; // w0
  _QWORD *v16; // x22
  __int64 v17; // x0
  unsigned int *v18; // x22
  __int64 v19; // x23
  __int64 v20; // x0
  __int64 v21; // x9
  __int64 v22; // x23
  unsigned int v23; // w8
  __int64 v24; // x23
  __int64 v25; // x23
  __int64 v26; // x23
  __int64 v27; // x23
  unsigned __int64 v28; // x27
  float v29; // s14
  __int64 v30; // x24
  __int64 v31; // x24
  __int64 transform; // x0
  long double position; // q0
  float v34; // s11
  float v35; // s1
  float v36; // s12
  float v37; // s2
  float v38; // s13
  float v39; // s0
  __int64 v40; // x19
  __int64 v41; // x0
  __int64 v42; // x0
  __int64 v43; // x1
  __int64 v44; // x2
  __int64 v45; // x3
  __int64 v46; // [xsp+8h] [xbp-A8h] BYREF
  _QWORD *v47; // [xsp+18h] [xbp-98h] BYREF

  if ( (byte_8FFD78B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2FA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD78B = 1;
  }
  v47 = nullptr;
  v46 = 0;
  *a7 = 0;
  if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE81E8);
  if ( (HexManager__TryGetHexAt(&v47, 0, a1, a2, a3) & 1) != 0 )
  {
    v13 = v47;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v13, 0, 0) & 1) == 0 )
    {
      v16 = v47;
      if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4A38);
      if ( (GameModule_BattleGameSceneManager__TryGetArchitectureOnHex(v16, a5 & 1, a6, a7) & 1) != 0 )
      {
        v14 = 1;
        return v14 & 1;
      }
      v17 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE2FA0, 6);
      if ( v47 == nullptr )
        goto LABEL_64;
      v18 = (unsigned int *)v17;
      if ( v17 == 0 )
        goto LABEL_64;
      v19 = v47[13];
      if ( v19 != 0 )
      {
        v20 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v19, *(_QWORD *)(*(_QWORD *)v17 + 64LL));
        if ( v20 == 0 )
          goto LABEL_66;
      }
      v21 = *((_QWORD *)v18 + 3);
      if ( (_DWORD)v21 == 0 )
        goto LABEL_65;
      *((_QWORD *)v18 + 4) = v19;
      if ( v47 == nullptr )
        goto LABEL_64;
      v22 = v47[15];
      if ( v22 != 0 )
      {
        v20 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v22, *(_QWORD *)(*(_QWORD *)v18 + 64LL));
        if ( v20 == 0 )
          goto LABEL_66;
        v21 = *((_QWORD *)v18 + 3);
        v23 = v21;
      }
      else
      {
        v23 = v21;
      }
      if ( (unsigned int)v21 <= 1 )
        goto LABEL_65;
      *((_QWORD *)v18 + 5) = v22;
      if ( v47 == nullptr )
        goto LABEL_64;
      v24 = v47[14];
      if ( v24 != 0 )
      {
        v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v47[14], *(_QWORD *)(*(_QWORD *)v18 + 64LL));
        if ( v20 == 0 )
          goto LABEL_66;
        v21 = *((_QWORD *)v18 + 3);
        v23 = v21;
      }
      if ( (unsigned int)v21 <= 2 )
        goto LABEL_65;
      *((_QWORD *)v18 + 6) = v24;
      if ( v47 == nullptr )
        goto LABEL_64;
      v25 = v47[17];
      if ( v25 != 0 )
      {
        v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v47[17], *(_QWORD *)(*(_QWORD *)v18 + 64LL));
        if ( v20 == 0 )
          goto LABEL_66;
        v21 = *((_QWORD *)v18 + 3);
        v23 = v21;
      }
      if ( (unsigned int)v21 <= 3 )
        goto LABEL_65;
      *((_QWORD *)v18 + 7) = v25;
      if ( v47 == nullptr )
        goto LABEL_64;
      v26 = v47[16];
      if ( v26 != 0 )
      {
        v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v47[16], *(_QWORD *)(*(_QWORD *)v18 + 64LL));
        if ( v20 == 0 )
          goto LABEL_66;
        v21 = *((_QWORD *)v18 + 3);
        v23 = v21;
      }
      if ( (unsigned int)v21 <= 4 )
      {
LABEL_65:
        v20 = ((__int64 (*)(void))unk_3C3D4D4)();
        goto LABEL_66;
      }
      *((_QWORD *)v18 + 8) = v26;
      if ( v47 == nullptr )
LABEL_64:
        il2cpp_codegen_raise_null_reference_exception();
      v27 = v47[18];
      if ( v27 == 0 )
        goto LABEL_45;
      v20 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v47[18], *(_QWORD *)(*(_QWORD *)v18 + 64LL));
      if ( v20 != 0 )
      {
        v21 = *((_QWORD *)v18 + 3);
        v23 = v21;
LABEL_45:
        if ( (unsigned int)v21 > 5 )
        {
          *((_QWORD *)v18 + 9) = v27;
          if ( (int)v21 < 1 )
          {
LABEL_61:
            v40 = *a7;
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            v14 = UnityEngine_Object__op_Inequality(v40, 0, 0);
            return v14 & 1;
          }
          v28 = 0;
          v29 = 3.4028e38;
          while ( v28 < v23 )
          {
            v30 = *(_QWORD *)&v18[2 * v28 + 8];
            if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE4A38);
            if ( (GameModule_BattleGameSceneManager__TryGetArchitectureOnHex(v30, a5 & 1, a6, &v46) & 1) != 0 )
            {
              v31 = v46;
              if ( v46 == 0 )
                goto LABEL_64;
              transform = UnityEngine_Component__get_transform(v46, 0);
              if ( transform == 0 )
                goto LABEL_64;
              position = UnityEngine_Transform__get_position(transform, 0);
              v34 = *(float *)&position;
              v36 = v35;
              v38 = v37;
              if ( byte_8FFD020 == 0 )
              {
                il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
                byte_8FFD020 = 1;
              }
              if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEA738);
              v39 = sqrtf(
                      (float)((float)(*(float *)&a3 - v38) * (float)(*(float *)&a3 - v38))
                    + (float)((float)((float)(*(float *)&a1 - v34) * (float)(*(float *)&a1 - v34))
                            + (float)((float)(*(float *)&a2 - v36) * (float)(*(float *)&a2 - v36))));
              if ( v39 < v29 )
              {
                v29 = v39;
                *a7 = v31;
              }
            }
            v23 = v18[6];
            if ( (__int64)++v28 >= (int)v23 )
              goto LABEL_61;
          }
        }
        goto LABEL_65;
      }
LABEL_66:
      v41 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v20);
      v42 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v41, 0);
      return GameModule_BattleGameSceneManager__TryGetArchitectureOnHex(v42, v43, v44, v45);
    }
  }
  v14 = 0;
  return v14 & 1;
}
