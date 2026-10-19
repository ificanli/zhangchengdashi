void Pathfinding_ECS_AIMovementSystemGroup_TimeScaledRateManager__Dispose(void *self, const MethodInfo *method)
{
  if ( (byte_90010BF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D13EE8);
    byte_90010BF = 1;
  }
  Unity_Collections_NativeList_TimeData___Dispose((char *)self + 40, qword_8D13EE8);
  Unity_Collections_NativeList_TimeData___Dispose((char *)self + 48, qword_8D13EE8);
}
