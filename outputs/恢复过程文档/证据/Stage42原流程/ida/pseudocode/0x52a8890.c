void GameFramework_Fsm_Fsm_object____ctor_52a8890(
        void *this,
        void *name,
        void *owner,
        void *states,
        const MethodInfo *method)
{
  __int64 v10; // x0
  __int64 *v11; // x24
  __int64 v12; // x23
  __int64 v13; // x23
  __int64 v14; // x0
  int v15; // w8
  __int64 v16; // x25
  __int64 v17; // x23
  __int64 Type; // x0
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 v22; // x20
  void *v23; // x0
  __int64 v24; // x0
  __int64 i; // x0
  __int64 v26; // x20
  __int64 v27; // x0
  __int64 v28; // x20
  __int64 v29; // x0
  __int64 v30; // x21
  __int64 v31; // x0

  if ( (byte_9002564 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA098);
    byte_9002564 = 1;
  }
  GameFramework_Fsm_FsmBase___ctor(this, name, 0);
  if ( owner == nullptr )
    goto LABEL_24;
  if ( states == nullptr || *((int *)states + 6) <= 0 )
  {
LABEL_19:
    v21 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v21);
    v23 = &unk_8D600F0;
    goto LABEL_20;
  }
  *((_QWORD *)this + 4) = owner;
  v10 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL);
  v11 = &qword_8CFF750;
  if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
    v10 = ((__int64 (*)(void))unk_3C503A0)();
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v10);
  System_Collections_Generic_Dictionary_object__object____ctor(
    v12,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 32LL));
  *((_QWORD *)this + 5) = v12;
  v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA098);
  v14 = System_Collections_Generic_Dictionary_object__object____ctor(v13, qword_8CFF750);
  *((_QWORD *)this + 6) = v13;
  v15 = *((_DWORD *)states + 6);
  if ( v15 >= 1 )
  {
    v16 = 0;
    do
    {
      if ( (unsigned int)v16 >= v15 )
      {
        ((void (__fastcall *)(__int64))unk_3C3D4D4)(v14);
LABEL_22:
        v26 = ((__int64 (__fastcall *)(void *, _QWORD))unk_35FB8E0)(
                name,
                *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 48LL));
        v27 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600C8);
        v28 = sub_750AA4C(v27, v26, v11, 0);
        v29 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
        v30 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v29);
        GameFramework_GameFrameworkException___ctor(v30, v28, 0);
        for ( i = v30; ; i = v22 )
        {
          ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(i, method);
LABEL_24:
          v31 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
          v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v31);
          v23 = &unk_8D600E8;
LABEL_20:
          v24 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(v23);
          GameFramework_GameFrameworkException___ctor(v22, v24, 0);
        }
      }
      v17 = *((_QWORD *)states + v16 + 4);
      if ( v17 == 0 )
        goto LABEL_19;
      Type = System_Object__GetType(*((_QWORD *)states + v16 + 4), 0);
      if ( Type == 0 )
        goto LABEL_18;
      v19 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 776LL))(
              Type,
              *(_QWORD *)(*(_QWORD *)Type + 784LL));
      if ( *((_QWORD *)this + 5) == 0 )
        goto LABEL_18;
      v11 = (__int64 *)v19;
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
              *((_QWORD *)this + 5),
              v19,
              *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL))
          & 1) != 0 )
        goto LABEL_22;
      v20 = *((_QWORD *)this + 5);
      if ( v20 == 0 )
LABEL_18:
        il2cpp_codegen_raise_null_reference_exception();
      System_Collections_Generic_Dictionary_object__object___Add(
        v20,
        v11,
        v17,
        *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 56LL));
      v14 = (*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)v17 + 376LL))(
              v17,
              this,
              *(_QWORD *)(*(_QWORD *)v17 + 384LL));
      v15 = *((_DWORD *)states + 6);
      ++v16;
    }
    while ( (int)v16 < v15 );
  }
  *((_DWORD *)this + 16) = 0;
  *((_QWORD *)this + 7) = 0;
  *((_BYTE *)this + 68) = 0;
}
