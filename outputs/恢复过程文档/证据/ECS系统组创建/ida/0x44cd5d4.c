void Pathfinding_ECS_AIMovementSystemGroup__OnDestroy(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x10

  if ( (byte_90010B8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF0CC0);
    byte_90010B8 = 1;
  }
  Unity_Entities_ComponentSystemGroup__OnDestroy(self, 0);
  v3 = *((_QWORD *)self + 17);
  if ( v3 == 0
    || (v4 = *(unsigned __int8 *)(off_8CF0CC0 + 304), *(unsigned __int8 *)(*(_QWORD *)v3 + 304LL) < (unsigned int)v4)
    || *(_QWORD *)(*(_QWORD *)(*(_QWORD *)v3 + 200LL) + 8 * v4 - 8) != off_8CF0CC0 )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  Pathfinding_ECS_AIMovementSystemGroup_TimeScaledRateManager__Dispose();
}
