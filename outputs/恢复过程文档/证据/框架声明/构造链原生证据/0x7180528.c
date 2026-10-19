// local variable allocation has failed, the output may be wrong!
void GameFramework_UIEffect___ctor(
        void *self,
        void *arg0,
        Recovery_Vector3 arg1,
        Recovery_Vector3 arg2,
        void *arg3,
        unsigned __int8 arg4,
        const MethodInfo *method)
{
  long double v9; // q8
  long double v10; // q9
  long double v11; // q10
  long double v12; // q11
  long double v13; // q12
  long double v14; // q13

  v9 = *(long double *)&arg2.z;
  v10 = *(long double *)&arg2.y;
  v11 = *(long double *)&arg2.x;
  v12 = *(long double *)&arg1.z;
  v13 = *(long double *)&arg1.y;
  v14 = *(long double *)&arg1.x;
  if ( (byte_900922D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4930);
    byte_900922D = 1;
  }
  if ( *((_DWORD *)off_8CE4930 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4930);
  GameFramework_BaseEffect___ctor(self, arg0, arg3, arg4 & 1, method, v14, v13, v12, v11, v10, v9);
}
