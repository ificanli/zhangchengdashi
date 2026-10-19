__int64 __fastcall GameModule_RoleBehaviour__FindIntermediateHexPath(__int64 a1, __int64 a2, __int64 a3)
{
  __int64 v4; // x22
  __int64 v5; // x22
  __int64 v6; // x23
  __int64 v7; // x21
  _QWORD *v8; // x24
  __int64 v9; // x0
  unsigned int *v10; // x25
  __int64 v11; // x26
  __int64 v12; // x9
  __int64 v13; // x26
  unsigned int v14; // w8
  __int64 v15; // x26
  __int64 v16; // x26
  __int64 v17; // x26
  __int64 v18; // x26
  unsigned __int64 v19; // x28
  __int64 v20; // x26
  __int64 i; // x23
  int v23; // w8
  __int64 Item; // x20
  __int64 v25; // x0

  if ( (byte_8FFD490 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFBEE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFBEE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFBEF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFBEF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9490);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D06678);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D06688);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D06670);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDBBB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2FA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4D0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B530);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D169F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D169F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D169E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D16A00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF490);
    byte_8FFD490 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v4 = 0;
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) == 0 )
  {
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v4 = 0;
    if ( (UnityEngine_Object__op_Equality(a3, 0, 0) & 1) == 0 )
    {
      v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF490);
      System_Collections_Generic_Queue_object____ctor(v5, qword_8D169E8);
      v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDBBB0);
      System_Collections_Generic_HashSet_object____ctor(v6, qword_8D06670);
      v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9490);
      System_Collections_Generic_Dictionary_object__object____ctor(v7, qword_8CFBEE0);
      if ( v5 == 0 )
        goto LABEL_69;
      System_Collections_Generic_Queue_object___Enqueue(v5, a2, qword_8D169F8);
      if ( v6 == 0 )
        goto LABEL_69;
      System_Collections_Generic_HashSet_object___Add(v6, a2, qword_8D06678);
      if ( *(int *)(v5 + 32) < 1 )
      {
        return 0;
      }
      else
      {
        while ( 1 )
        {
          v8 = (_QWORD *)System_Collections_Generic_Queue_object___Dequeue(v5, qword_8D169F0);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Equality(v8, a3, 0) & 1) != 0 )
            break;
          v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE2FA0, 6);
          if ( v8 == nullptr )
            goto LABEL_69;
          v10 = (unsigned int *)v9;
          if ( v9 == 0 )
            goto LABEL_69;
          v11 = v8[13];
          if ( v11 != 0
            && ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[13], *(_QWORD *)(*(_QWORD *)v9 + 64LL)) == 0 )
          {
LABEL_70:
            v25 = ((__int64 (*)(void))unk_3C3D4F0)();
            ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v25, 0);
            JUMPOUT(0x3D8B0BC);
          }
          v12 = *((_QWORD *)v10 + 3);
          if ( (_DWORD)v12 == 0 )
            goto LABEL_68;
          *((_QWORD *)v10 + 4) = v11;
          v13 = v8[14];
          if ( v13 != 0 )
          {
            if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[14], *(_QWORD *)(*(_QWORD *)v10 + 64LL)) == 0 )
              goto LABEL_70;
            v12 = *((_QWORD *)v10 + 3);
            v14 = v12;
          }
          else
          {
            v14 = v12;
          }
          if ( (unsigned int)v12 <= 1 )
            goto LABEL_68;
          *((_QWORD *)v10 + 5) = v13;
          v15 = v8[15];
          if ( v15 != 0 )
          {
            if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[15], *(_QWORD *)(*(_QWORD *)v10 + 64LL)) == 0 )
              goto LABEL_70;
            v12 = *((_QWORD *)v10 + 3);
            v14 = v12;
          }
          if ( (unsigned int)v12 <= 2 )
            goto LABEL_68;
          *((_QWORD *)v10 + 6) = v15;
          v16 = v8[16];
          if ( v16 != 0 )
          {
            if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[16], *(_QWORD *)(*(_QWORD *)v10 + 64LL)) == 0 )
              goto LABEL_70;
            v12 = *((_QWORD *)v10 + 3);
            v14 = v12;
          }
          if ( (unsigned int)v12 <= 3 )
            goto LABEL_68;
          *((_QWORD *)v10 + 7) = v16;
          v17 = v8[17];
          if ( v17 != 0 )
          {
            if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[17], *(_QWORD *)(*(_QWORD *)v10 + 64LL)) == 0 )
              goto LABEL_70;
            v12 = *((_QWORD *)v10 + 3);
            v14 = v12;
          }
          if ( (unsigned int)v12 <= 4 )
            goto LABEL_68;
          *((_QWORD *)v10 + 8) = v17;
          v18 = v8[18];
          if ( v18 != 0 )
          {
            if ( ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(v8[18], *(_QWORD *)(*(_QWORD *)v10 + 64LL)) == 0 )
              goto LABEL_70;
            v12 = *((_QWORD *)v10 + 3);
            v14 = v12;
          }
          if ( (unsigned int)v12 <= 5 )
            goto LABEL_68;
          *((_QWORD *)v10 + 9) = v18;
          if ( (int)v12 >= 1 )
          {
            v19 = 0;
            while ( v19 < v14 )
            {
              v20 = *(_QWORD *)&v10[2 * v19 + 8];
              if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEB3E0);
              if ( (UnityEngine_Object__op_Inequality(v20, 0, 0) & 1) != 0
                && (System_Collections_Generic_HashSet_object___Contains(v6, v20, qword_8D06688) & 1) == 0 )
              {
                System_Collections_Generic_HashSet_object___Add(v6, v20, qword_8D06678);
                if ( v7 == 0 )
                  goto LABEL_69;
                System_Collections_Generic_Dictionary_object__object___set_Item(v7, v20, v8, qword_8CFBEF8);
                System_Collections_Generic_Queue_object___Enqueue(v5, v20, qword_8D169F8);
              }
              v14 = v10[6];
              if ( (__int64)++v19 >= (int)v14 )
                goto LABEL_51;
            }
LABEL_68:
            ((void (*)(void))unk_3C3D4D4)();
LABEL_69:
            il2cpp_codegen_raise_null_reference_exception();
          }
LABEL_51:
          if ( *(int *)(v5 + 32) <= 0 )
            return 0;
        }
        v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD888);
        System_Collections_Generic_List_object____ctor(v4, qword_8D0B4D0);
        for ( i = a3; ; i = System_Collections_Generic_Dictionary_object__object___get_Item(v7, i, qword_8CFBEF0) )
        {
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(i, a2, 0) & 1) == 0 )
            break;
          if ( v7 == 0 )
            goto LABEL_69;
          if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v7, i, qword_8CFBEE8) & 1) == 0 )
            break;
          if ( v4 == 0 )
            goto LABEL_69;
          System_Collections_Generic_List_object___Insert(v4, 0, i, qword_8D0B508);
        }
        if ( v4 == 0 )
          goto LABEL_69;
        v23 = *(_DWORD *)(v4 + 24);
        if ( v23 >= 1 )
        {
          Item = System_Collections_Generic_List_object___get_Item(v4, (unsigned int)(v23 - 1), qword_8D0B530);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Equality(Item, a3, 0) & 1) != 0 )
            System_Collections_Generic_List_object___RemoveAt(
              v4,
              (unsigned int)(*(_DWORD *)(v4 + 24) - 1),
              qword_8D0B520);
        }
      }
    }
  }
  return v4;
}
