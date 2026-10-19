unsigned __int8 TimeModuleO_TimeManager__LoadTimers_d__68__MoveNext(void *self, const MethodInfo *method)
{
  unsigned int v3; // w8
  __int64 v4; // x20
  _BYTE *Instance; // x0
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x0
  __int64 v10; // x8
  __int64 v11; // x8
  __int64 v12; // x0
  __int128 v13; // kr00_16
  void *v14; // x22
  const MethodInfo *v15; // x2
  __int64 v16; // x0
  __int64 *v17; // x8
  __int128 *v18; // x0
  int v19; // w8
  __int64 v20; // x0
  _BYTE *v21; // x0
  __int64 v22; // x1
  __int64 v23; // x0
  __int64 started; // x0
  __int64 v25; // x1
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x1
  __int64 v29; // x0
  __int128 v30; // [xsp+8h] [xbp-D8h] BYREF
  __int128 v31; // [xsp+18h] [xbp-C8h]
  __int64 v32; // [xsp+28h] [xbp-B8h]
  __int128 v33; // [xsp+30h] [xbp-B0h] BYREF
  __int128 v34; // [xsp+40h] [xbp-A0h]
  __int64 v35; // [xsp+50h] [xbp-90h]
  __int128 v36; // [xsp+60h] [xbp-80h] BYREF
  __int128 v37; // [xsp+70h] [xbp-70h]
  __int64 v38; // [xsp+80h] [xbp-60h]

  if ( (byte_8FFE392 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB268);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFCA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04FB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D05190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04FC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D05198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D051A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D04FC8);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D078D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D079B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D078D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12298);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF5EC0);
    byte_8FFE392 = 1;
  }
  v38 = 0;
  v35 = 0;
  v36 = 0u;
  v37 = 0u;
  v33 = 0u;
  v34 = 0u;
  v3 = *((_DWORD *)self + 4);
  v4 = *((_QWORD *)self + 4);
  if ( v3 < 2 )
  {
    *((_DWORD *)self + 4) = -1;
    if ( v4 == 0 )
      goto LABEL_46;
    if ( *(_BYTE *)(v4 + 37) == 0 )
    {
      *((_QWORD *)self + 3) = 0;
      *((_DWORD *)self + 4) = 1;
      return 1;
    }
LABEL_11:
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( Instance == nullptr )
      goto LABEL_46;
    if ( Instance[32] == 0 )
    {
      v19 = 2;
      *((_QWORD *)self + 3) = 0;
LABEL_48:
      *((_DWORD *)self + 4) = v19;
      return 1;
    }
    v7 = **((_QWORD **)off_8CD9218 + 23);
    if ( v7 != 0 )
    {
      v8 = *(_QWORD *)(v7 + 48);
      if ( v8 != 0 )
      {
        if ( *(_BYTE *)(v8 + 83) != 0 )
        {
          if ( v4 != 0 )
          {
            v9 = *(_QWORD *)(v4 + 40);
            if ( v9 != 0 )
            {
              System_Collections_Generic_Dictionary_object__object___Clear(v9, qword_8CFFC90);
              v10 = **((_QWORD **)off_8CD9258 + 23);
              if ( v10 != 0 )
              {
                v11 = *(_QWORD *)(v10 + 48);
                if ( v11 != 0 )
                {
                  v12 = *(_QWORD *)(v11 + 16);
                  if ( v12 != 0 )
                  {
                    System_Collections_Generic_Dictionary_object__object___GetEnumerator(&v30, v12, qword_8CFF460);
                    v33 = v30;
                    v34 = v31;
                    v35 = v32;
                    while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(
                               &v33,
                               qword_8D04FC0)
                           & 1) != 0 )
                    {
                      v13 = v34;
                      v14 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF5EC0);
                      sub_3F6CA60(v14, *((void **)&v13 + 1), v15);
                      v16 = *(_QWORD *)(v4 + 40);
                      if ( v16 == 0 )
                        il2cpp_codegen_raise_null_reference_exception();
                      System_Collections_Generic_Dictionary_object__object___Add(v16, v13, v14, qword_8CFFC88);
                    }
                    v17 = &qword_8D04FB8;
                    v18 = &v33;
                    goto LABEL_34;
                  }
                }
              }
            }
          }
        }
        else
        {
          *(_BYTE *)(v8 + 83) = 1;
          DbtSaveDataManagerBase_object__object___Save(v7, qword_8CFB260);
          if ( v4 != 0 )
          {
            v20 = *(_QWORD *)(v4 + 40);
            if ( v20 != 0 )
            {
              System_Collections_Generic_Dictionary_object__object___GetEnumerator(&v30, v20, qword_8CFFCA0);
              v36 = v30;
              v37 = v31;
              v38 = v32;
              while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(&v36, qword_8D05198)
                     & 1) != 0 )
                TimeModuleO_TimeManager__InitAddTimeInfo(v4, *((_QWORD *)&v37 + 1), 0);
              v17 = &qword_8D05190;
              v18 = &v36;
LABEL_34:
              System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v18, *v17);
              goto LABEL_35;
            }
          }
        }
      }
    }
LABEL_46:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( v3 == 2 )
  {
    *((_DWORD *)self + 4) = -1;
    goto LABEL_11;
  }
  if ( v3 != 3 )
    return 0;
  *((_DWORD *)self + 4) = -1;
LABEL_35:
  v21 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12298);
  if ( v21 == nullptr )
    goto LABEL_46;
  if ( v21[40] == 0 )
  {
    *((_QWORD *)self + 3) = 0;
    v19 = 3;
    goto LABEL_48;
  }
  if ( v4 == 0 )
    goto LABEL_46;
  TimeModuleO_TimeManager__InitToZeroTimer(v4, 0);
  TimeModuleO_TimeManager__InitToWeekTimer(v4, 0);
  v22 = *(_QWORD *)(v4 + 152);
  if ( v22 != 0 )
    UnityEngine_MonoBehaviour__StopCoroutine(v4, v22, 0);
  v23 = TimeModuleO_TimeManager__CheckTimerToZeroCoroutine(v4, 0);
  started = UnityEngine_MonoBehaviour__StartCoroutine(v4, v23, 0);
  v25 = *(_QWORD *)(v4 + 160);
  *(_QWORD *)(v4 + 152) = started;
  if ( v25 != 0 )
    UnityEngine_MonoBehaviour__StopCoroutine(v4, v25, 0);
  v26 = TimeModuleO_TimeManager__CheckTimerEndEventCoroutine(v4, 0);
  v27 = UnityEngine_MonoBehaviour__StartCoroutine(v4, v26, 0);
  v28 = *(_QWORD *)(v4 + 168);
  *(_QWORD *)(v4 + 160) = v27;
  if ( v28 != 0 )
    UnityEngine_MonoBehaviour__StopCoroutine(v4, v28, 0);
  v29 = TimeModuleO_TimeManager__CheckWeekPassedCoroutine(v4, 0);
  *(_QWORD *)(v4 + 168) = UnityEngine_MonoBehaviour__StartCoroutine(v4, v29, 0);
  return 0;
}
