void Pathfinding_EndingConditionProximity___ctor(void *self, void *path, float maxDistance, const MethodInfo *method)
{
  *((_DWORD *)self + 8) = 1092616192;
  Pathfinding_ABPathEndingCondition___ctor();
  *((float *)self + 8) = maxDistance;
}
