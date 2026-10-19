void GameFramework_ModelRegister___ctor(
        void *self,
        void *name,
        unsigned __int8 autoSyn,
        unsigned __int8 compress,
        const MethodInfo *method)
{
  char v7; // w21
  char v8; // w22

  v7 = autoSyn & 1;
  v8 = compress & 1;
  *((_BYTE *)self + 24) = 1;
  System_Attribute___ctor();
  *((_QWORD *)self + 2) = name;
  *((_BYTE *)self + 24) = v7;
  *((_BYTE *)self + 25) = v8;
}
