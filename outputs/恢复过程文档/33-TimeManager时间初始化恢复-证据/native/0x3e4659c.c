void TimeModuleO_TimeManager__InitAddTimeInfo(void *self, void *timer, const MethodInfo *method)
{
  __int64 v4; // x8
  __int64 v5; // x8
  __int64 v6; // x20
  __int64 Item; // x0
  __int64 v8; // x0
  __int64 v9; // x8
  __int64 v10; // x8
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x8
  __int64 v14; // x8
  __int64 v15; // x0
  __int64 v16; // x0
  _QWORD *v17; // x21
  __int64 v18; // x8
  __int64 v19; // x8
  __int64 v20; // x0
  __int64 v21; // x0

  if ( (byte_8FFDA11 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF450);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF470);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF480);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEE568);
    byte_8FFDA11 = 1;
  }
  v4 = **((_QWORD **)off_8CD9258 + 23);
  if ( v4 == 0 )
    goto LABEL_26;
  v5 = *(_QWORD *)(v4 + 48);
  if ( v5 == 0 )
    goto LABEL_26;
  if ( timer == nullptr )
    goto LABEL_26;
  v6 = *(_QWORD *)(v5 + 16);
  if ( v6 == 0 )
    goto LABEL_26;
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v6, *((_QWORD *)timer + 2), qword_8CFF458) & 1) != 0 )
  {
    Item = System_Collections_Generic_Dictionary_object__object___get_Item(v6, *((_QWORD *)timer + 2), qword_8CFF480);
    if ( Item != 0 )
    {
      *(_QWORD *)(Item + 24) = *((_QWORD *)timer + 3);
      v8 = System_Collections_Generic_Dictionary_object__object___get_Item(v6, *((_QWORD *)timer + 2), qword_8CFF480);
      if ( v8 != 0 )
      {
        *(_QWORD *)(v8 + 32) = *((_QWORD *)timer + 4);
        v9 = **((_QWORD **)off_8CD9258 + 23);
        if ( v9 != 0 )
        {
          v10 = *(_QWORD *)(v9 + 48);
          if ( v10 != 0 )
          {
            v11 = *(_QWORD *)(v10 + 16);
            if ( v11 != 0 )
            {
              v12 = System_Collections_Generic_Dictionary_object__object___get_Item(
                      v11,
                      *((_QWORD *)timer + 2),
                      qword_8CFF480);
              if ( v12 != 0 )
              {
                *(_QWORD *)(v12 + 24) = *((_QWORD *)timer + 3);
                v13 = **((_QWORD **)off_8CD9258 + 23);
                if ( v13 != 0 )
                {
                  v14 = *(_QWORD *)(v13 + 48);
                  if ( v14 != 0 )
                  {
                    v15 = *(_QWORD *)(v14 + 16);
                    if ( v15 != 0 )
                    {
                      v16 = System_Collections_Generic_Dictionary_object__object___get_Item(
                              v15,
                              *((_QWORD *)timer + 2),
                              qword_8CFF480);
                      if ( v16 != 0 )
                      {
                        *(_QWORD *)(v16 + 32) = *((_QWORD *)timer + 4);
                        goto LABEL_24;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v17 = (_QWORD *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEE568);
  DataModule_TimeInfo___ctor(v17, 0);
  if ( v17 == nullptr )
    goto LABEL_26;
  v17[2] = *((_QWORD *)timer + 2);
  v17[3] = *((_QWORD *)timer + 3);
  v17[4] = *((_QWORD *)timer + 4);
  System_Collections_Generic_Dictionary_object__object___Add(v6, *((_QWORD *)timer + 2), v17, qword_8CFF450);
  v18 = **((_QWORD **)off_8CD9258 + 23);
  if ( v18 == 0 )
    goto LABEL_26;
  v19 = *(_QWORD *)(v18 + 48);
  if ( v19 == 0 )
    goto LABEL_26;
  v20 = *(_QWORD *)(v19 + 16);
  if ( v20 == 0 )
    goto LABEL_26;
  System_Collections_Generic_Dictionary_object__object___TryAdd(v20, *((_QWORD *)timer + 2), v17, qword_8CFF470);
LABEL_24:
  v21 = **((_QWORD **)off_8CD9258 + 23);
  if ( v21 == 0 )
    goto LABEL_26;
  DbtSaveDataManagerBase_object__object___Save(v21, qword_8CFB3E0);
}
