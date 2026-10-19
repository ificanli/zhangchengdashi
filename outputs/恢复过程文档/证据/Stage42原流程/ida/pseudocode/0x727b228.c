void *GameFramework_Procedure_ProcedureManager__GetProceduresType_727b228(void *this, const MethodInfo *method)
{
  void *v2; // x21
  __int64 *v3; // x22
  __int64 v4; // x19
  __int64 v5; // x0
  __int64 v6; // x0
  int v7; // w8
  __int64 v8; // x20
  unsigned int v9; // w23
  __int64 v10; // x21
  __int64 v11; // x22
  __int64 TypeFromHandle; // x0
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x8
  __int64 v16; // x8
  __int64 v17; // x1
  __int64 v18; // x8
  _QWORD *v19; // x9
  __int64 v20; // x10

  v2 = &unk_9009000;
  v3 = &qword_8CDE370;
  if ( (byte_9009C39 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE370);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3308);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD57E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56B20);
    byte_9009C39 = 1;
  }
  v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDE370, method);
  System_Collections_Generic_List_object____ctor(v4, qword_8D0F200);
  v5 = System_Reflection_Assembly__Load(qword_8D56B20, 0);
  if ( v5 == 0 )
    goto LABEL_23;
  v6 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v5 + 600LL))(v5, *(_QWORD *)(*(_QWORD *)v5 + 608LL));
  if ( v6 == 0 )
    goto LABEL_23;
  v7 = *(_DWORD *)(v6 + 24);
  v8 = v6;
  if ( v7 >= 1 )
  {
    v9 = 0;
    while ( 1 )
    {
      if ( v9 >= v7 )
      {
LABEL_24:
        ((void (*)(void))unk_3C3D4D4)();
LABEL_25:
        ((void (__fastcall *)(void *, __int64 *))unk_3C3D868)(v2, v3);
        JUMPOUT(0x727B43C);
      }
      v10 = *(_QWORD *)(v8 + 8LL * (int)v9 + 32);
      v11 = qword_8CD57E0;
      if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEA50);
      TypeFromHandle = System_Type__GetTypeFromHandle(v11, 0);
      if ( v10 == 0 )
        break;
      v13 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD, _QWORD))(*(_QWORD *)v10 + 536LL))(
              v10,
              TypeFromHandle,
              0,
              *(_QWORD *)(*(_QWORD *)v10 + 544LL));
      if ( v13 == 0 )
        break;
      v3 = (__int64 *)qword_8CE3308;
      v2 = (void *)v13;
      v14 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v13, qword_8CE3308);
      if ( v14 == 0 )
        goto LABEL_25;
      v15 = *(_QWORD *)(v14 + 24);
      if ( v15 != 0 )
      {
        if ( (_DWORD)v15 == 0 )
          goto LABEL_24;
        v16 = *(_QWORD *)(v14 + 32);
        if ( v16 == 0 )
          break;
        if ( v4 == 0 )
          break;
        v17 = *(_QWORD *)(v16 + 16);
        v18 = *(_QWORD *)(v4 + 16);
        v19 = off_8D0F210;
        ++*(_DWORD *)(v4 + 28);
        if ( v18 == 0 )
          break;
        v20 = *(int *)(v4 + 24);
        if ( (unsigned int)v20 >= *(_DWORD *)(v18 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v4,
            v17,
            *(_QWORD *)(*(_QWORD *)(v19[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v4 + 24) = v20 + 1;
          *(_QWORD *)(v18 + 8 * v20 + 32) = v17;
        }
      }
      v7 = *(_DWORD *)(v8 + 24);
      if ( (int)++v9 >= v7 )
        return (void *)v4;
    }
LABEL_23:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return (void *)v4;
}
