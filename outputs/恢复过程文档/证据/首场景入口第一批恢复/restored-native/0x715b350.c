void GameFramework_GameFrameEntry__LateUpdate(const MethodInfo *method)
{
  void *v1; // x0
  __int64 v2; // x8
  __int64 Next; // x19
  __int64 v4; // x0

  if ( (byte_90090D6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D07C48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07C58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07D90);
    byte_90090D6 = 1;
  }
  v1 = off_8CE7B30;
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
    v1 = off_8CE7B30;
  }
  if ( *(_BYTE *)(*((_QWORD *)v1 + 23) + 8LL) != 0 )
  {
    if ( *((_DWORD *)v1 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v1);
      v1 = off_8CE7B30;
    }
    v2 = **((_QWORD **)v1 + 23);
    if ( v2 == 0 )
      goto LABEL_13;
    Next = *(_QWORD *)(v2 + 16);
    if ( Next != 0 )
    {
      while ( 1 )
      {
        v4 = *(_QWORD *)(Next + 40);
        if ( v4 == 0 )
          break;
        (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v4 + 440LL))(v4, *(_QWORD *)(*(_QWORD *)v4 + 448LL));
        Next = System_Collections_Generic_LinkedListNode_object___get_Next(Next, qword_8D07C48);
        if ( Next == 0 )
          return;
      }
LABEL_13:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
}
