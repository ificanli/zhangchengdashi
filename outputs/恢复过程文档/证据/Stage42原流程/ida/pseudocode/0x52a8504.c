void GameFramework_Fsm_FsmState_object___SubscribeEvent_52a8504(
        void *this,
        int eventId,
        void *eventHandler,
        const MethodInfo *method)
{
  __int64 v6; // x0
  _BYTE *v7; // x22
  char v9; // w0
  __int64 v10; // x21
  __int64 v11; // x8
  __int64 Item; // x0
  __int64 v13; // x23
  __int64 v14; // x2
  __int64 v15; // x3
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x0
  __int64 v19; // x20
  __int64 v20; // x0

  if ( eventHandler == nullptr )
  {
    v18 = ((__int64 (__fastcall *)(void *, int))unk_3C3D294)(&unk_8CE7B50, eventId);
    v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v18);
    v20 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5FAD8);
    GameFramework_GameFrameworkException___ctor(v19, v20, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v19, method);
    JUMPOUT(0x52A8630);
  }
  v6 = *((_QWORD *)this + 2);
  if ( v6 == 0
    || (v7 = eventHandler,
        v9 = System_Collections_Generic_Dictionary_int__object___ContainsKey(
               v6,
               eventId,
               *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL)),
        (v10 = *((_QWORD *)this + 2)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  v11 = *(_QWORD *)(*((_QWORD *)method + 4) + 192LL);
  if ( (v9 & 1) == 0 )
    goto LABEL_10;
  Item = System_Collections_Generic_Dictionary_int__object___get_Item(v10, (unsigned int)eventId, *(_QWORD *)(v11 + 56));
  v13 = System_Delegate__Combine(Item, v7, 0);
  v7 = *(_BYTE **)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 32LL);
  if ( (v7[309] & 1) == 0 )
    v7 = (_BYTE *)((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL)
                                                                          + 32LL));
  if ( v13 == 0 )
  {
    v14 = 0;
    goto LABEL_12;
  }
  v14 = ((__int64 (__fastcall *)(__int64, _BYTE *))unk_3C3D3B4)(v13, v7);
  if ( v14 != 0 )
  {
LABEL_12:
    v16 = v10;
    v17 = (unsigned int)eventId;
    v15 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 48LL);
    goto LABEL_13;
  }
  ((void (__fastcall *)(__int64, _BYTE *))unk_3C3D868)(v13, v7);
LABEL_10:
  v15 = *(_QWORD *)(v11 + 48);
  v16 = v10;
  v17 = (unsigned int)eventId;
  v14 = (__int64)v7;
LABEL_13:
  System_Collections_Generic_Dictionary_int__object___set_Item(v16, v17, v14, v15);
}
