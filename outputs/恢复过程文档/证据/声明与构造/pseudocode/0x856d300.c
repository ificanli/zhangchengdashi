void sub_856D300(void *self, Recovery_Vector3 vector, const MethodInfo *method)
{
  *(double *)self = vector.x;
  *((double *)self + 1) = vector.y;
  *((double *)self + 2) = vector.z;
}
