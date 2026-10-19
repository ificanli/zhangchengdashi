void TimeModuleO_TimeManager__RegisterOnTimeToZero(void *self, void *action, const MethodInfo *method)
{
  _QWORD *v5; // x0
  __int64 v6; // x1

  if ( (byte_8FFDA05 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    byte_8FFDA05 = 1;
  }
  v5 = (_QWORD *)System_Delegate__Combine(*((_QWORD *)self + 6), action, 0);
  if ( v5 == nullptr )
    goto LABEL_7;
  v6 = qword_8CE3CE0;
  if ( *v5 != qword_8CE3CE0 || (*((_QWORD *)self + 6) = v5, *v5 != v6) )
  {
    v5 = (_QWORD *)((__int64 (*)(void))unk_3C3D868)();
LABEL_7:
    *((_QWORD *)self + 6) = v5;
  }
}
