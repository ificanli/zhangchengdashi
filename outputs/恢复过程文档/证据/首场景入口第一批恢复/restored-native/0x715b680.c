void *GameFramework_GameFrameEntry__K____b(void *type, const MethodInfo *method)
{
  _QWORD **v3; // x0
  __int64 v4; // x0
  __int64 Last; // x0
  __int64 Previous; // x20
  __int64 v7; // x0
  __int64 v8; // x21

  if ( (byte_90090D8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D07C50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07C58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D07D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    byte_90090D8 = 1;
  }
  v3 = (_QWORD **)off_8CE7B30;
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
    v3 = (_QWORD **)off_8CE7B30;
  }
  v4 = *v3[23];
  if ( v4 == 0 )
LABEL_17:
    il2cpp_codegen_raise_null_reference_exception();
  Last = System_Collections_Generic_LinkedList_object___get_Last(v4, qword_8D07D98);
  if ( Last != 0 )
  {
    Previous = Last;
    while ( 1 )
    {
      v7 = *(_QWORD *)(Previous + 40);
      if ( v7 == 0 )
        goto LABEL_17;
      v8 = System_Object__GetType(v7, 0);
      if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEA50);
      if ( (System_Type__op_Equality(v8, type, 0) & 1) != 0 )
        return *(void **)(Previous + 40);
      Previous = System_Collections_Generic_LinkedListNode_object___get_Previous(Previous, qword_8D07C50);
      if ( Previous == 0 )
        goto LABEL_13;
    }
  }
  else
  {
LABEL_13:
    if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7B30);
    return GameFramework_GameFrameEntry___X____(type);
  }
}
