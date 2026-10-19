// local variable allocation has failed, the output may be wrong!
void GameFramework_Fsm_FsmManager__Update_7296d08(
        void *this,
        float elapseSeconds,
        float realElapseSeconds,
        const MethodInfo *method)
{
  long double v4; // q8
  long double v5; // q9
  __int64 v7; // x0
  unsigned int v8; // w20
  __int64 Item; // x0
  __int64 v10; // x21

  v4 = *(long double *)&realElapseSeconds;
  v5 = *(long double *)&elapseSeconds;
  if ( (byte_9009D2A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0A830);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0A838);
    byte_9009D2A = 1;
  }
  v7 = *((_QWORD *)this + 5);
  if ( v7 == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  v8 = 0;
  while ( (signed int)v8 < *(_DWORD *)(v7 + 24) )
  {
    Item = System_Collections_Generic_List_object___get_Item(v7, v8, qword_8D0A838);
    if ( Item != 0 )
    {
      v10 = Item;
      if ( ((*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 456LL))(
              Item,
              *(_QWORD *)(*(_QWORD *)Item + 464LL))
          & 1) == 0 )
        (*(void (__fastcall **)(__int64, _QWORD, long double, long double))(*(_QWORD *)v10 + 504LL))(
          v10,
          *(_QWORD *)(*(_QWORD *)v10 + 512LL),
          v5,
          v4);
      v7 = *((_QWORD *)this + 5);
      ++v8;
      if ( v7 != 0 )
        continue;
    }
    goto LABEL_10;
  }
}
