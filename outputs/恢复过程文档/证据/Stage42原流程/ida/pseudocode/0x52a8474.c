void GameFramework_Fsm_FsmState_object____ctor_52a8474(void *this, const MethodInfo *method)
{
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x8
  __int64 v7; // x20

  System_Object___ctor(this, 0);
  v4 = **(_QWORD **)(*((_QWORD *)method + 4) + 192LL);
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (*)(void))unk_3C503A0)();
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v4);
  v6 = *((_QWORD *)method + 4);
  v7 = v5;
  System_Collections_Generic_Dictionary_int__object____ctor(v5, *(_QWORD *)(*(_QWORD *)(v6 + 192) + 8LL));
  *((_QWORD *)this + 2) = v7;
}
