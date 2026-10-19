void Pathfinding_Util_GraphTransform___ctor(void *self, void *matrix, const MethodInfo *method)
{
  __int128 v5; // q0
  __int128 v6; // q2
  __int128 v7; // q3
  _QWORD v8[8]; // [xsp+0h] [xbp-60h] BYREF

  System_Object___ctor(self, 0);
  v5 = *((_OWORD *)matrix + 3);
  v7 = *(_OWORD *)matrix;
  v6 = *((_OWORD *)matrix + 1);
  *(_OWORD *)&v8[4] = *((_OWORD *)matrix + 2);
  *(_OWORD *)&v8[6] = v5;
  *(_OWORD *)v8 = v7;
  *(_OWORD *)&v8[2] = v6;
  Pathfinding_Util_GraphTransform__Set(self, v8);
}
