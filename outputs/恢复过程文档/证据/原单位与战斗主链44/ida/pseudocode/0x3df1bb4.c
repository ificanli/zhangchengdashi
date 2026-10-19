__int64 __fastcall GameModule_BattleGameSceneManager__TryGetMostDenseEnemyRolePosition(
        __int64 a1,
        char a2,
        __int64 a3,
        float a4,
        float a5,
        float a6,
        float a7,
        float a8)
{
  __int64 v16; // x8
  __int64 v17; // x20
  int v18; // w29
  unsigned int v19; // w21
  float v20; // s15
  __int64 Item; // x23
  __int64 transform; // x0
  float v23; // s11
  float v24; // s1
  float v25; // s12
  float v26; // s2
  float v27; // s13
  int v28; // w25
  unsigned int v29; // w23
  float *v30; // x8
  float v31; // s14
  __int64 v32; // x24
  __int64 v33; // x0
  long double position; // q0
  float v35; // s1
  float v36; // s2
  __int64 v37; // x0
  long double v38; // q0
  float v39; // s1
  float v40; // s2
  __int64 v41; // x0
  long double v42; // q0
  float v43; // s1
  float v44; // s2
  float v46; // [xsp+4h] [xbp-BCh]
  float v47; // [xsp+8h] [xbp-B8h]
  float v48; // [xsp+Ch] [xbp-B4h]
  float v49; // [xsp+10h] [xbp-B0h]
  float v50; // [xsp+14h] [xbp-ACh]
  float v51; // [xsp+18h] [xbp-A8h]
  float v52; // [xsp+1Ch] [xbp-A4h]

  if ( (byte_8FFD795 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD795 = 1;
  }
  v16 = 192;
  *(_DWORD *)(a3 + 8) = 0;
  *(_QWORD *)a3 = 0;
  if ( (a2 & 1) != 0 )
    v16 = 200;
  v17 = *(_QWORD *)(a1 + v16);
  if ( v17 == 0 || *(int *)(v17 + 24) <= 0 )
    return 0;
  v47 = a7 * a7;
  v52 = 0.0;
  v18 = 0;
  v19 = 0;
  v20 = a8 * a8;
  v51 = 0.0;
  v46 = 3.4028e38;
  v50 = 0.0;
  do
  {
    Item = System_Collections_Generic_List_object___get_Item(v17, v19, qword_8D0DDC8);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(Item, 0, 0) & 1) == 0 )
    {
      if ( Item == 0 )
        goto LABEL_42;
      if ( *(_BYTE *)(Item + 33) == 0 && *(_BYTE *)(Item + 396) == 0 )
      {
        transform = UnityEngine_Component__get_transform(Item, 0);
        if ( transform == 0 )
LABEL_42:
          il2cpp_codegen_raise_null_reference_exception();
        v23 = COERCE_FLOAT(COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0)));
        v25 = v24;
        v27 = v26;
        if ( (float)((float)((float)(v26 - a6) * (float)(v26 - a6))
                   + (float)((float)((float)(v23 - a4) * (float)(v23 - a4))
                           + (float)((float)(v24 - a5) * (float)(v24 - a5)))) <= v20 )
        {
          if ( byte_8FFCFFD == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
            byte_8FFCFFD = 1;
          }
          if ( *(int *)(v17 + 24) >= 1 )
          {
            v28 = 0;
            v29 = 0;
            v30 = *((float **)off_8CEF3D8 + 23);
            v31 = *v30;
            v48 = v30[1];
            v49 = v30[2];
            do
            {
              v32 = System_Collections_Generic_List_object___get_Item(v17, v29, qword_8D0DDC8);
              if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEB3E0);
              if ( (UnityEngine_Object__op_Equality(v32, 0, 0) & 1) == 0 )
              {
                if ( v32 == 0 )
                  goto LABEL_42;
                if ( *(_BYTE *)(v32 + 33) == 0 && *(_BYTE *)(v32 + 396) == 0 )
                {
                  v33 = UnityEngine_Component__get_transform(v32, 0);
                  if ( v33 == 0 )
                    goto LABEL_42;
                  position = UnityEngine_Transform__get_position(v33, 0);
                  if ( (float)((float)((float)(v36 - a6) * (float)(v36 - a6))
                             + (float)((float)((float)(*(float *)&position - a4) * (float)(*(float *)&position - a4))
                                     + (float)((float)(v35 - a5) * (float)(v35 - a5)))) <= v20 )
                  {
                    v37 = UnityEngine_Component__get_transform(v32, 0);
                    if ( v37 == 0 )
                      goto LABEL_42;
                    v38 = UnityEngine_Transform__get_position(v37, 0);
                    if ( (float)((float)((float)(v40 - v27) * (float)(v40 - v27))
                               + (float)((float)((float)(*(float *)&v38 - v23) * (float)(*(float *)&v38 - v23))
                                       + (float)((float)(v39 - v25) * (float)(v39 - v25)))) <= v47 )
                    {
                      v41 = UnityEngine_Component__get_transform(v32, 0);
                      if ( v41 == 0 )
                        goto LABEL_42;
                      ++v28;
                      v42 = UnityEngine_Transform__get_position(v41, 0);
                      v31 = v31 + *(float *)&v42;
                      v48 = v48 + v43;
                      v49 = v49 + v44;
                    }
                  }
                }
              }
              ++v29;
            }
            while ( (signed int)v29 < *(_DWORD *)(v17 + 24) );
            if ( v28 >= 1
              && (v28 > v18
               || v28 == v18
               && (float)((float)((float)((float)(v49 / (float)v28) - a6) * (float)((float)(v49 / (float)v28) - a6))
                        + (float)((float)((float)((float)(v31 / (float)v28) - a4)
                                        * (float)((float)(v31 / (float)v28) - a4))
                                + (float)((float)((float)(v48 / (float)v28) - a5)
                                        * (float)((float)(v48 / (float)v28) - a5)))) < v46) )
            {
              v18 = v28;
              v50 = v31 / (float)v28;
              v51 = v48 / (float)v28;
              v52 = v49 / (float)v28;
              v46 = (float)((float)(v52 - a6) * (float)(v52 - a6))
                  + (float)((float)((float)(v50 - a4) * (float)(v50 - a4))
                          + (float)((float)(v51 - a5) * (float)(v51 - a5)));
            }
          }
        }
      }
    }
    ++v19;
  }
  while ( (signed int)v19 < *(_DWORD *)(v17 + 24) );
  if ( v18 < 1 )
    return 0;
  *(float *)a3 = v50;
  *(float *)(a3 + 4) = v51;
  *(float *)(a3 + 8) = v52;
  return 1;
}
