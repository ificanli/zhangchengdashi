__int64 __fastcall GameModule_BattleGameSceneManager__ParseKey(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  int v5; // w8
  __int64 v6; // x20
  long double v7; // q0
  long double v8; // q9
  long double v9; // q0
  int v10; // w20
  long double v11; // q8
  float v12; // s10
  double v13; // d0
  double v14; // d0
  double v15; // d1
  double v16; // d1
  double v17; // d9
  float v18; // s10
  float v19; // s11
  double v20; // d0
  double v21; // d0
  double v22; // d1
  double v23; // d1
  __int64 v24; // x0
  __int64 v25; // x1
  __int64 int__int; // x0
  __int64 v28; // x0
  __int64 v29; // x19
  __int64 v30; // x0
  __int64 v31; // x0
  _QWORD v32[2]; // [xsp+8h] [xbp-58h] BYREF
  double v33; // [xsp+18h] [xbp-48h] BYREF

  if ( (byte_8FFD77C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D3B9C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1C390);
    byte_8FFD77C = 1;
  }
  if ( a2 != 0 )
  {
    v4 = System_String__Split(a2, 95, 0, 0);
    if ( v4 != 0 )
    {
      v5 = *(_DWORD *)(v4 + 24);
      if ( v5 == 3 )
        v6 = v4;
      else
        v6 = 0;
      if ( v5 != 3 )
      {
LABEL_43:
        v28 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE4208);
        v29 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v28);
        v30 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D65A20);
        System_ArgumentException___ctor(v29, v30, 0);
        v31 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D23E10);
        ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v29, v31);
        JUMPOUT(0x3DEE96C);
      }
      if ( v6 != 0 )
      {
        if ( *(_DWORD *)(v6 + 24) == 0
          || (ToolModule_StringTool__ToFloat(*(_QWORD *)(v6 + 32), 0), *(_DWORD *)(v6 + 24) <= 2u) )
        {
          ((void (*)(void))unk_3C3D4D4)();
          goto LABEL_43;
        }
        v8 = v7;
        v9 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v6 + 48), 0);
        v10 = *(_DWORD *)(a1 + 392);
        v11 = v9;
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        v12 = *(float *)&v8 * (float)v10;
        *(double *)&v8 = v12;
        ((void (__fastcall *)(double *, long double))modf)(&v33, v8);
        if ( v12 >= 0.0 )
        {
          if ( v13 != 0.5 )
          {
            v17 = floor(*(double *)&v8 + 0.5);
            goto LABEL_24;
          }
          v14 = v33;
          v15 = 1.0;
        }
        else
        {
          if ( v13 != -0.5 )
          {
            v17 = ceil(*(double *)&v8 + -0.5);
            goto LABEL_24;
          }
          v14 = v33;
          v15 = -1.0;
        }
        v16 = v14 + v15;
        if ( ((__int64)v14 & 1) != 0 )
          v17 = v16;
        else
          v17 = v14;
LABEL_24:
        v18 = fabsf(*(float *)&v11);
        v19 = v18 * (float)*(int *)(a1 + 392);
        *(double *)&v11 = v19;
        ((void (__fastcall *)(double *, long double))modf)(&v33, v11);
        if ( v19 >= 0.0 )
        {
          if ( v20 != 0.5 )
          {
            v21 = floor(*(double *)&v11 + 0.5);
            goto LABEL_34;
          }
          v21 = v33;
          v22 = 1.0;
        }
        else
        {
          if ( v20 != -0.5 )
          {
            v21 = ceil(*(double *)&v11 + -0.5);
            goto LABEL_34;
          }
          v21 = v33;
          v22 = -1.0;
        }
        v23 = v21 + v22;
        if ( ((__int64)v21 & 1) != 0 )
          v21 = v23;
LABEL_34:
        if ( v17 == INFINITY )
          v24 = 0x80000000LL;
        else
          v24 = (unsigned int)(int)v17;
        if ( v21 == INFINITY )
          v25 = 0x80000000LL;
        else
          v25 = (unsigned int)(int)v21;
        int__int = System_Tuple__Create_int__int_(v24, v25, qword_8D3B9C8);
        v32[0] = 0;
        v32[1] = 0;
        System_ValueTuple_object__bool____ctor(v32, int__int, v18 < COERCE_FLOAT(1), qword_8D1C390);
        return v32[0];
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
