unsigned __int8 TimeModuleO_TimeManager__SyncServerTimeCoroutine_d__38__MoveNext(void *self, const MethodInfo *method)
{
  int v3; // w8
  __int64 v4; // x20
  __int64 I; // x0
  _BYTE **v7; // x0
  float v8; // s8
  __int64 v9; // x1
  float v10; // s0
  __int64 v11; // x0

  if ( (byte_8FFE394 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D173C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_8FFE394 = 1;
  }
  v3 = *((_DWORD *)self + 4);
  v4 = *((_QWORD *)self + 4);
  if ( v3 == 1 )
  {
    *((_DWORD *)self + 4) = -1;
  }
  else
  {
    if ( v3 != 0 )
      return 0;
    *((_DWORD *)self + 4) = -1;
    if ( v4 == 0 )
      goto LABEL_25;
    if ( *(_DWORD *)(v4 + 32) != 0 )
    {
      *(_BYTE *)(v4 + 37) = 1;
      return 0;
    }
    *(_BYTE *)(v4 + 36) = 1;
    I = L_Tools_RichControlBase_object___get_I(qword_8D173C8, method);
    if ( I == 0 )
      goto LABEL_25;
    L_Tools_ServerTimeMgr__TryCheck(I, 1, 0);
    *((_DWORD *)self + 10) = 0;
  }
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CED280);
  if ( byte_8FFE449 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_8FFE449 = 1;
  }
  v7 = (_BYTE **)off_8CED280;
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CED280);
    v7 = (_BYTE **)off_8CED280;
  }
  if ( *v7[23] != 0 )
  {
    if ( v4 != 0 )
    {
      *(_WORD *)(v4 + 36) = 256;
      return 0;
    }
LABEL_25:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v8 = *((float *)self + 10);
  v10 = v8 + UnityEngine_Time__get_deltaTime(0, method);
  *((float *)self + 10) = v10;
  if ( v10 > 3.0 )
  {
    *((_DWORD *)self + 10) = 0;
    v11 = L_Tools_RichControlBase_object___get_I(qword_8D173C8, v9);
    if ( v11 == 0 )
      goto LABEL_25;
    L_Tools_ServerTimeMgr__TryCheck(v11, 1, 0);
  }
  *((_QWORD *)self + 3) = 0;
  *((_DWORD *)self + 4) = 1;
  return 1;
}
