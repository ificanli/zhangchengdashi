void DataModule_PlayerCoreData__InitFromDefaults(void *self, const MethodInfo *method)
{
  int v3; // w23
  __int64 v4; // x20
  __int64 v5; // x1
  __int64 v6; // x8
  _QWORD *v7; // x9
  __int64 v8; // x10

  if ( (byte_900072E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0BE78);
    byte_900072E = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  v3 = 4;
  *((_BYTE *)self + 92) = 1;
  *((_DWORD *)self + 8) = 20;
  do
  {
    v4 = *((_QWORD *)self + 12);
    if ( (int)UnityEngine_Random__Range(0) < 80 )
      v5 = 1;
    else
      v5 = 2;
    if ( v4 == 0 || (v6 = *(_QWORD *)(v4 + 16), v7 = off_8D0BE78, ++*(_DWORD *)(v4 + 28), v6 == 0) )
      il2cpp_codegen_raise_null_reference_exception();
    v8 = *(int *)(v4 + 24);
    if ( (unsigned int)v8 >= *(_DWORD *)(v6 + 24) )
    {
      System_Collections_Generic_List_int___AddWithResize(v4, v5, *(_QWORD *)(*(_QWORD *)(v7[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v4 + 24) = v8 + 1;
      *(_DWORD *)(v6 + 4 * v8 + 32) = v5;
    }
    --v3;
  }
  while ( v3 != 0 );
}
