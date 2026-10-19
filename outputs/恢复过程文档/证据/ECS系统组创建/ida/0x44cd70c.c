void Pathfinding_ECS_AIMovementSystemGroup_TimeScaledRateManager___ctor(void *self, const MethodInfo *method)
{
  unsigned int v3; // w0
  unsigned int v4; // w0
  __int64 v5; // [xsp+0h] [xbp-30h] BYREF
  __int64 v6; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_90010BE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D13ED0);
    byte_90010BE = 1;
  }
  *((_DWORD *)self + 7) = 1023969417;
  *((_QWORD *)self + 9) = 0x3FF0000000000000LL;
  System_Object___ctor(self, 0);
  v3 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, 0);
  v6 = 0;
  Unity_Collections_NativeList_TimeData____ctor(&v6, v3, qword_8D13ED0);
  *((_QWORD *)self + 5) = v6;
  v4 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, 0);
  v5 = 0;
  Unity_Collections_NativeList_TimeData____ctor(&v5, v4, qword_8D13ED0);
  *((_QWORD *)self + 6) = v5;
}
