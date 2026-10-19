// local variable allocation has failed, the output may be wrong!
void GameFramework_FlyEffect___ctor(
        void *self,
        void *arg0,
        Recovery_Vector3 arg1,
        Recovery_Vector3 arg2,
        Recovery_Vector3 arg3,
        float arg4,
        void *arg5,
        unsigned __int8 arg6,
        const MethodInfo *method)
{
  long double v11; // q10
  long double v12; // q11
  long double v13; // q12
  long double v14; // q13
  __int128 v17; // q8
  __int128 v18; // q9
  int v19; // [xsp+48h] [xbp-38h]
  int v20; // [xsp+4Ch] [xbp-34h]

  v11 = *(long double *)&arg2.y;
  v12 = *(long double *)&arg2.x;
  v13 = *(long double *)&arg1.y;
  v14 = *(long double *)&arg1.x;
  if ( (byte_9009228 & 1) == 0 )
  {
    v17 = *(_OWORD *)&arg2.z;
    v18 = *(_OWORD *)&arg1.z;
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4930);
    *(_OWORD *)&arg1.z = v18;
    *(_OWORD *)&arg2.z = v17;
    byte_9009228 = 1;
  }
  if ( *((_DWORD *)off_8CE4930 + 56) == 0 )
  {
    v19 = LODWORD(v11);
    v20 = LODWORD(v12);
    v11 = *(long double *)&arg2.z;
    v12 = *(long double *)&arg1.z;
    il2cpp_codegen_runtime_class_init(off_8CE4930);
    *(long double *)&arg1.z = v12;
    *(long double *)&arg2.z = v11;
    LODWORD(v11) = v19;
    LODWORD(v12) = v20;
  }
  GameFramework_BaseEffect___ctor(
    self,
    arg0,
    arg5,
    arg6 & 1,
    method,
    v14,
    v13,
    *(long double *)&arg1.z,
    v12,
    v11,
    *(long double *)&arg2.z);
  *(Recovery_Vector3 *)((char *)self + 124) = arg3;
  *((float *)self + 34) = arg4;
}
