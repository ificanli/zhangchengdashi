void GameModule_GameManager__ShowCardProbabilityPanel_d__24__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v4; // x8
  __int64 v5; // x9
  int *v6; // x10
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  _DWORD *v10; // x10
  __int64 v11; // x0
  __int64 Instance; // x20
  _QWORD *v13; // x21
  __int64 v14; // x8
  __int64 v15; // x0
  __int64 v16; // x0
  __int128 v17; // [xsp+0h] [xbp-30h] BYREF

  if ( (byte_8FFD8AE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D22328);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57460);
    byte_8FFD8AE = 1;
  }
  v17 = 0u;
  if ( *(_DWORD *)self != 0 )
  {
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v17 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.05);
    *((_QWORD *)&v17 + 1) = method;
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
    if ( (_QWORD)v17 != 0 )
    {
      v4 = *(_QWORD *)v17;
      v5 = *(unsigned __int16 *)(*(_QWORD *)v17 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v17 + 302LL) != 0 )
      {
        v6 = (int *)(*(_QWORD *)(v4 + 176) + 8LL);
        while ( *((_QWORD *)v6 - 1) != qword_8CE91C8 )
        {
          --v5;
          v6 += 4;
          if ( v5 == 0 )
            goto LABEL_17;
        }
        v7 = v4 + 16LL * *v6 + 312;
      }
      else
      {
LABEL_17:
        v7 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v17, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v7)(v17, WORD4(v17), *(_QWORD *)(v7 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *(_OWORD *)((char *)self + 40) = v17;
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__GameManager__ShowCardProbabilityPanel_d__24_(
          (char *)self + 8,
          &v17,
          self,
          qword_8D22328);
        return;
      }
    }
  }
  else
  {
    v17 = *(_OWORD *)((char *)self + 40);
    *((_QWORD *)self + 5) = 0;
    *((_QWORD *)self + 6) = 0;
    *(_DWORD *)self = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v17 != 0 )
  {
    v8 = *(_QWORD *)v17;
    v9 = *(unsigned __int16 *)(*(_QWORD *)v17 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v17 + 302LL) != 0 )
    {
      v10 = (_DWORD *)(*(_QWORD *)(v8 + 176) + 8LL);
      while ( *((_QWORD *)v10 - 1) != qword_8CE91C8 )
      {
        --v9;
        v10 += 4;
        if ( v9 == 0 )
          goto LABEL_28;
      }
      v11 = v8 + 16LL * (*v10 + 2) + 312;
    }
    else
    {
LABEL_28:
      v11 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v17, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v11)(v17, WORD4(v17), *(_QWORD *)(v11 + 8));
  }
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, method, v2);
  v13 = off_8D1D5E8;
  v14 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v14 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v14 = v13[7];
  }
  v15 = *(_QWORD *)(v14 + 16);
  if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
    v15 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v15 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v15);
  v16 = *(_QWORD *)(v13[7] + 16LL);
  if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
    v16 = ((__int64 (*)(void))unk_3C503A0)();
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  UIFramework_UIManager__ShowPanel(Instance, qword_8D57460, **(_QWORD **)(v16 + 184), 0);
  *(_DWORD *)self = -2;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
}
