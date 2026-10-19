bool GameModule_BattleGameSceneManager__IsHexSurrounded(
        GameModule_BattleGameSceneManager_o *this,
        GameModule_HexBehaviour_o *hex,
        const MethodInfo *method)
{
  __int64 v4; // x0
  unsigned int *v5; // x19
  __int64 v6; // x21
  __int64 v7; // x9
  __int64 v8; // x21
  unsigned int v9; // w8
  __int64 v10; // x21
  __int64 v11; // x21
  __int64 v12; // x21
  __int64 v13; // x20
  unsigned __int64 v14; // x22
  int v15; // w21
  __int64 v16; // x20
  __int64 v18; // x0

  if ( (byte_8FFD7A5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2FA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7A5 = 1;
  }
  v4 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D320)(qword_8CE2FA0, 6, method);
  if ( hex == nullptr || (v5 = (unsigned int *)v4, v4 == 0) )
LABEL_43:
    il2cpp_codegen_raise_null_reference_exception();
  v6 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[88];
  if ( v6 != 0
    && ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
         *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[88],
         *(_QWORD *)(*(_QWORD *)v4 + 64LL)) == 0 )
  {
    goto LABEL_44;
  }
  v7 = *((_QWORD *)v5 + 3);
  if ( (_DWORD)v7 == 0 )
    goto LABEL_42;
  *((_QWORD *)v5 + 4) = v6;
  v8 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[96];
  if ( v8 != 0 )
  {
    if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
           *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[96],
           *(_QWORD *)(*(_QWORD *)v5 + 64LL)) == 0 )
      goto LABEL_44;
    v7 = *((_QWORD *)v5 + 3);
    v9 = v7;
  }
  else
  {
    v9 = v7;
  }
  if ( (unsigned int)v7 <= 1 )
    goto LABEL_42;
  *((_QWORD *)v5 + 5) = v8;
  v10 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[104];
  if ( v10 != 0 )
  {
    if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
           *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[104],
           *(_QWORD *)(*(_QWORD *)v5 + 64LL)) == 0 )
      goto LABEL_44;
    v7 = *((_QWORD *)v5 + 3);
    v9 = v7;
  }
  if ( (unsigned int)v7 <= 2 )
    goto LABEL_42;
  *((_QWORD *)v5 + 6) = v10;
  v11 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[112];
  if ( v11 != 0 )
  {
    if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
           *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[112],
           *(_QWORD *)(*(_QWORD *)v5 + 64LL)) == 0 )
      goto LABEL_44;
    v7 = *((_QWORD *)v5 + 3);
    v9 = v7;
  }
  if ( (unsigned int)v7 <= 3 )
    goto LABEL_42;
  *((_QWORD *)v5 + 7) = v11;
  v12 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[120];
  if ( v12 != 0 )
  {
    if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
           *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[120],
           *(_QWORD *)(*(_QWORD *)v5 + 64LL)) == 0 )
      goto LABEL_44;
    v7 = *((_QWORD *)v5 + 3);
    v9 = v7;
  }
  if ( (unsigned int)v7 <= 4 )
  {
LABEL_42:
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_43;
  }
  *((_QWORD *)v5 + 8) = v12;
  v13 = *(_QWORD *)&hex->fields._unknown_object_0010_to_009F[128];
  if ( v13 != 0 )
  {
    if ( ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v13, *(_QWORD *)(*(_QWORD *)v5 + 64LL)) == 0 )
    {
LABEL_44:
      v18 = ((__int64 (*)(void))unk_3C3D4F0)();
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v18, 0);
      JUMPOUT(0x3DF4234);
    }
    v7 = *((_QWORD *)v5 + 3);
    v9 = v7;
  }
  if ( (unsigned int)v7 <= 5 )
    goto LABEL_42;
  *((_QWORD *)v5 + 9) = v13;
  if ( (int)v7 >= 1 )
  {
    v14 = 0;
    v15 = 0;
    while ( v14 < v9 )
    {
      v16 = *(_QWORD *)&v5[2 * v14 + 8];
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(v16, 0, 0) & 1) != 0 )
        goto LABEL_37;
      if ( v16 == 0 )
        goto LABEL_43;
      if ( *(_BYTE *)(v16 + 161) != 0 )
LABEL_37:
        ++v15;
      v9 = v5[6];
      if ( (__int64)++v14 >= (int)v9 )
        return v15 > 2;
    }
    goto LABEL_42;
  }
  v15 = 0;
  return v15 > 2;
}
