// local variable allocation has failed, the output may be wrong!
void GameFramework_LineEffect___ctor(
        void *self,
        void *arg0,
        Recovery_Vector3 arg1,
        Recovery_Vector3 arg2,
        Recovery_Vector3 arg3,
        Recovery_Vector3 arg4,
        void *arg5,
        unsigned __int8 arg6,
        const MethodInfo *method)
{
  char z_low; // w21
  __int64 v10; // x20
  long double v11; // q12
  long double v12; // q13
  __int128 v15; // q8
  __int128 v16; // q9
  __int128 v17; // q10
  __int128 v18; // q11
  float x; // [xsp+8h] [xbp-88h]
  float z; // [xsp+Ch] [xbp-84h]
  int v21; // [xsp+58h] [xbp-38h]
  int v22; // [xsp+5Ch] [xbp-34h]
  __int64 v23; // [xsp+A0h] [xbp+10h]
  int v24; // [xsp+A8h] [xbp+18h]

  z_low = LOBYTE(arg4.z);
  v10 = *(_QWORD *)&arg4.x;
  v11 = *(long double *)&arg2.y;
  v12 = *(long double *)&arg1.z;
  if ( (byte_900922B & 1) == 0 )
  {
    v15 = *(_OWORD *)&arg2.z;
    v16 = *(_OWORD *)&arg2.x;
    v17 = *(_OWORD *)&arg1.y;
    v18 = *(_OWORD *)&arg1.x;
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4930);
    *(_OWORD *)&arg1.x = v18;
    *(_OWORD *)&arg1.y = v17;
    *(_OWORD *)&arg2.x = v16;
    *(_OWORD *)&arg2.z = v15;
    byte_900922B = 1;
  }
  if ( *((_DWORD *)off_8CE4930 + 56) == 0 )
  {
    v21 = LODWORD(v12);
    v22 = LODWORD(v11);
    x = arg1.x;
    z = arg2.z;
    v12 = *(long double *)&arg2.x;
    v11 = *(long double *)&arg1.y;
    il2cpp_codegen_runtime_class_init(off_8CE4930);
    arg1.x = x;
    arg2.z = z;
    *(long double *)&arg1.y = v11;
    *(long double *)&arg2.x = v12;
    LODWORD(v12) = v21;
    LODWORD(v11) = v22;
  }
  GameFramework_BaseEffect___ctor(
    self,
    arg0,
    v10,
    z_low & 1,
    arg5,
    *(long double *)&arg1.x,
    *(long double *)&arg1.y,
    v12,
    *(long double *)&arg2.x,
    v11,
    *(long double *)&arg2.z);
  *(_QWORD *)((char *)self + 124) = v23;
  *((_DWORD *)self + 33) = v24;
  *(Recovery_Vector3 *)((char *)self + 136) = arg3;
}
