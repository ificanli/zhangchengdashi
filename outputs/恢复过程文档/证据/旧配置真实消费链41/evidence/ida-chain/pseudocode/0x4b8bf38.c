void stage41_GameFramework_ConfigRead____it_g_object_(void *a0, void *a1, void *a2, void *a3)
{
  __int64 it_g_object; // x0
  __int64 v9; // x22
  unsigned int v10; // w23
  __int64 Item; // x0
  __int64 v12; // x0
  __int64 v13; // x24
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x25
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x24
  __int64 v21; // x0
  __int64 v22; // x0

  if ( *((_QWORD *)a3 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88368);
    if ( *((_QWORD *)a3 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a3);
  }
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  it_g_object = GameFramework_ConfigRead____it_g_object_(a0, **((_QWORD **)a3 + 7));
  if ( it_g_object != 0 )
  {
    v9 = it_g_object;
    if ( *(int *)(it_g_object + 24) >= 1 )
    {
      v10 = 0;
      while ( 1 )
      {
        Item = System_Collections_Generic_List_object___get_Item(v9, v10, *(_QWORD *)(*((_QWORD *)a3 + 7) + 24LL));
        if ( Item == 0 )
          break;
        v12 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 376LL))(
                Item,
                *(_QWORD *)(*(_QWORD *)Item + 384LL));
        if ( a1 == nullptr )
          break;
        if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
                a1,
                v12,
                *(_QWORD *)(*((_QWORD *)a3 + 7) + 40LL))
            & 1) != 0 )
        {
          v13 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
          v14 = System_Collections_Generic_List_object___get_Item(v9, v10, *(_QWORD *)(*((_QWORD *)a3 + 7) + 24LL));
          if ( v14 == 0 )
            break;
          v15 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v14 + 376LL))(
                  v14,
                  *(_QWORD *)(*(_QWORD *)v14 + 384LL));
          v16 = sub_750AA4C(qword_8D88368, a2, v15, 0);
          if ( v13 == 0 )
            break;
          v17 = v16;
          if ( v16 != 0 )
          {
            v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v13 + 64LL));
            if ( v18 == 0 )
              goto LABEL_26;
          }
          if ( *(_DWORD *)(v13 + 24) == 0 )
          {
            v18 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_26:
            v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v18);
            ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v22, 0);
            JUMPOUT(0x4B8C16C);
          }
          *(_QWORD *)(v13 + 32) = v17;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__Error(v13, 0);
        }
        else
        {
          v19 = System_Collections_Generic_List_object___get_Item(v9, v10, *(_QWORD *)(*((_QWORD *)a3 + 7) + 24LL));
          if ( v19 == 0 )
            break;
          v20 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v19 + 376LL))(
                  v19,
                  *(_QWORD *)(*(_QWORD *)v19 + 384LL));
          v21 = System_Collections_Generic_List_object___get_Item(v9, v10, *(_QWORD *)(*((_QWORD *)a3 + 7) + 24LL));
          System_Collections_Generic_Dictionary_object__object___Add(
            a1,
            v20,
            v21,
            *(_QWORD *)(*((_QWORD *)a3 + 7) + 48LL));
        }
        if ( (signed int)++v10 >= *(_DWORD *)(v9 + 24) )
          return;
      }
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
}
