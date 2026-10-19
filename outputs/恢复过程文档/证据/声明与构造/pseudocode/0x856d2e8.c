void sub_856D2E8(void *self, double value, const MethodInfo *method)
{
  *(double *)self = value;
  *((double *)self + 1) = value;
  *((double *)self + 2) = value;
}
