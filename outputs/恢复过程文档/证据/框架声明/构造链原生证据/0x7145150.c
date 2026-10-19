void GameFramework_AudioLoopFadeAction___ctor(
        void *self,
        void *arg0,
        int arg1,
        void *arg2,
        void *arg3,
        const MethodInfo *method)
{
  *((_DWORD *)self + 21) = 1000;
  GameFramework_AudioActionBase___ctor(self, arg0, arg1, arg2, arg3, method);
}
