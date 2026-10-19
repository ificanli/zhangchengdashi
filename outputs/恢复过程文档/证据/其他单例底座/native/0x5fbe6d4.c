void L_Tools_Singleton_SingletonCreator_object____cctor(const MethodInfo *method)
{
  __int64 v2; // x0
  void *Instance_object; // x0
  __int64 v4; // x8
  void *v5; // x20
  __int64 v6; // x0
  __int64 v7; // x0

  v2 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v2 + 309) & 1) == 0 )
    v2 = ((__int64 (*)(void))unk_3C503A0)();
  Instance_object = System_Activator__CreateInstance_object_(**(_QWORD **)(v2 + 192));
  v4 = *((_QWORD *)method + 4);
  v5 = Instance_object;
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*((_QWORD *)method + 4));
  v6 = *(_QWORD *)(*(_QWORD *)(v4 + 192) + 24LL);
  if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
    v6 = ((__int64 (*)(void))unk_3C503A0)();
  **(_QWORD **)(v6 + 184) = v5;
  v7 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  if ( (*(_BYTE *)(*(_QWORD *)(*(_QWORD *)(v7 + 192) + 24LL) + 309LL) & 1) == 0 )
    JUMPOUT(0x3C503A0);
}
