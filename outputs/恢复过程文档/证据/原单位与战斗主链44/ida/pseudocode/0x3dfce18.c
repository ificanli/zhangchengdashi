void __fastcall GameModule_BattleGameSceneManager__LoadMapGround_d__147__MoveNext(__int64 a1)
{
  __int64 v2; // x21
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x0
  __int64 Component_object; // x0
  __int64 HexBehaviour__LoadGround; // x20
  __int64 v8; // x1
  __int64 v9; // x21
  __int64 v10; // x8
  __int64 v11; // x9
  int *v12; // x10
  __int64 v13; // x0
  __int64 v14; // x8
  __int64 v15; // x9
  _DWORD *v16; // x10
  __int64 v17; // x0
  __int64 *v18; // x19
  __int64 v19; // x8
  __int64 v20; // x9
  _DWORD *v21; // x10
  __int64 v22; // x0
  __int128 v23; // [xsp+0h] [xbp-40h] BYREF

  if ( (byte_8FFD7EB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F318);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D398);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D9A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61A80);
    byte_8FFD7EB = 1;
  }
  v23 = 0u;
  if ( *(_DWORD *)a1 != 0 )
  {
    v2 = *(_QWORD *)(a1 + 24);
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v3 = *(_QWORD *)(v2 + 40);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v3, 0, 0) & 1) != 0 )
    {
      v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
      UnityEngine_GameObject___ctor(v4, qword_8D61A80, 0);
      *(_QWORD *)(v2 + 40) = v4;
      if ( v4 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_GameObject__AddComponent_object_(v4, qword_8D2D398);
    }
    v5 = *(_QWORD *)(v2 + 40);
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Component_object = UnityEngine_GameObject__GetComponent_object_(v5, qword_8D2D9A8);
    if ( Component_object == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    HexBehaviour__LoadGround = GameModule_GenerateHexBehaviour__LoadGround(Component_object, *(unsigned int *)(a1 + 32));
    v9 = v8;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v23 = HexBehaviour__LoadGround;
    *((_QWORD *)&v23 + 1) = v9;
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
    if ( (_QWORD)v23 != 0 )
    {
      v10 = *(_QWORD *)v23;
      v11 = *(unsigned __int16 *)(*(_QWORD *)v23 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v23 + 302LL) != 0 )
      {
        v12 = (int *)(*(_QWORD *)(v10 + 176) + 8LL);
        while ( *((_QWORD *)v12 - 1) != qword_8CE91C8 )
        {
          --v11;
          v12 += 4;
          if ( v11 == 0 )
            goto LABEL_25;
        }
        v13 = v10 + 16LL * *v12 + 312;
      }
      else
      {
LABEL_25:
        v13 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v23, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v13)(v23, WORD4(v23), *(_QWORD *)(v13 + 8)) == 0 )
      {
        *(_DWORD *)a1 = 0;
        *(_OWORD *)(a1 + 40) = v23;
        ((void (__fastcall *)(__int64, __int128 *, __int64, __int64))unk_3E13B98)(a1 + 8, &v23, a1, qword_8D1F318);
        return;
      }
    }
  }
  else
  {
    v23 = *(_OWORD *)(a1 + 40);
    *(_QWORD *)(a1 + 40) = 0;
    *(_QWORD *)(a1 + 48) = 0;
    *(_DWORD *)a1 = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v23 != 0 )
  {
    v14 = *(_QWORD *)v23;
    v15 = *(unsigned __int16 *)(*(_QWORD *)v23 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v23 + 302LL) != 0 )
    {
      v16 = (_DWORD *)(*(_QWORD *)(v14 + 176) + 8LL);
      while ( *((_QWORD *)v16 - 1) != qword_8CE91C8 )
      {
        --v15;
        v16 += 4;
        if ( v15 == 0 )
          goto LABEL_36;
      }
      v17 = v14 + 16LL * (*v16 + 2) + 312;
    }
    else
    {
LABEL_36:
      v17 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v23, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v17)(v23, WORD4(v23), *(_QWORD *)(v17 + 8));
  }
  *(_DWORD *)a1 = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v18 = *(__int64 **)(a1 + 8);
  if ( v18 != nullptr )
  {
    v19 = *v18;
    v20 = *(unsigned __int16 *)(*v18 + 302);
    if ( *(_WORD *)(*v18 + 302) != 0 )
    {
      v21 = (_DWORD *)(*(_QWORD *)(v19 + 176) + 8LL);
      while ( *((_QWORD *)v21 - 1) != qword_8CE9038 )
      {
        --v20;
        v21 += 4;
        if ( v20 == 0 )
          goto LABEL_46;
      }
      v22 = v19 + 16LL * (*v21 + 2) + 312;
    }
    else
    {
LABEL_46:
      v22 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v18, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v22)(v18, *(_QWORD *)(v22 + 8));
  }
}
