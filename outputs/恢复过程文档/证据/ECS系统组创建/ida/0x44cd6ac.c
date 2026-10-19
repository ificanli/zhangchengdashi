void Pathfinding_ECS_AIMovementSystemGroup__OnCreate(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_90010B9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF0CC0);
    byte_90010B9 = 1;
  }
  Unity_Entities_ComponentSystemGroup__OnCreate(self, 0);
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF0CC0);
  Pathfinding_ECS_AIMovementSystemGroup_TimeScaledRateManager___ctor();
  *((_QWORD *)self + 17) = v3;
}
