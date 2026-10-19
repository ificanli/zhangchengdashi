void O_Uks___ctor(
        void *self,
        void *arg0,
        void *arg1,
        void *arg2,
        int arg3,
        unsigned __int8 arg4,
        int arg5,
        const MethodInfo *method)
{
  char v11; // w22

  v11 = arg4 & 1;
  __Hcp___ctor(self, arg0, arg1, arg2, arg3);
  *((_DWORD *)self + 44) = arg3;
  *((_BYTE *)self + 180) = v11;
  *((_DWORD *)self + 46) = arg5;
}
