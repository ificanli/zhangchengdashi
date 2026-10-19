void GameFramework_Fsm_FsmState_object___UnsubscribeEvent_52a8630(
        void *this,
        int eventId,
        void *eventHandler,
        const MethodInfo *method)
{
  __int64 v6; // x0
  __int64 v9; // x21
  __int64 Item; // x0
  __int64 v11; // x23
  __int64 v12; // x22
  __int64 v13; // x2
  __int64 v14; // x0
  __int64 v15; // x20
  __int64 v16; // x0

  if ( eventHandler == nullptr )
  {
    v14 = ((__int64 (__fastcall *)(void *, int))unk_3C3D294)(&unk_8CE7B50, eventId);
    v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v14);
    v16 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5FAD8);
    GameFramework_GameFrameworkException___ctor(v15, v16, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v15, method);
    JUMPOUT(0x52A8758);
  }
  v6 = *((_QWORD *)this + 2);
  if ( v6 == 0 )
    goto LABEL_13;
  if ( (System_Collections_Generic_Dictionary_int__object___ContainsKey(
          v6,
          eventId,
          *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL))
      & 1) == 0 )
    return;
  v9 = *((_QWORD *)this + 2);
  if ( v9 == 0 )
LABEL_13:
    il2cpp_codegen_raise_null_reference_exception();
  Item = System_Collections_Generic_Dictionary_int__object___get_Item(
           v9,
           (unsigned int)eventId,
           *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 56LL));
  v11 = System_Delegate__Remove(Item, eventHandler, 0);
  v12 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 32LL);
  if ( (*(_BYTE *)(v12 + 309) & 1) == 0 )
    v12 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 32LL));
  if ( v11 == 0 )
  {
    v13 = 0;
    goto LABEL_12;
  }
  v13 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v11, v12);
  if ( v13 != 0 )
  {
LABEL_12:
    System_Collections_Generic_Dictionary_int__object___set_Item(
      v9,
      (unsigned int)eventId,
      v13,
      *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 48LL));
    return;
  }
  ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v11, v12);
}
