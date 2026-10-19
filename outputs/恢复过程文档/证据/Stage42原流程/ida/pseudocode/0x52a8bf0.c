void GameFramework_Fsm_Fsm_object___Update_52a8bf0(
        void *this,
        float elapseSeconds,
        float realElapseSeconds,
        const MethodInfo *method)
{
  __int64 v5; // x0

  v5 = *((_QWORD *)this + 7);
  if ( v5 != 0 )
  {
    *((float *)this + 16) = *((float *)this + 16) + elapseSeconds;
    (*(void (__fastcall **)(__int64))(*(_QWORD *)v5 + 424LL))(v5);
  }
}
