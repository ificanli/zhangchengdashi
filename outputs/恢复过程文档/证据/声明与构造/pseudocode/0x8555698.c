void BrainFailProductions_PolyFew_UnityMeshSimplifier_LODLevel___ctor(
        void *self,
        float transitionHeight,
        float fadeWidth,
        float quality,
        unsigned __int8 combineMeshes,
        unsigned __int8 combineSubMeshes,
        const MethodInfo *method)
{
  bool v7; // nf
  float v8; // s0
  float v9; // s3
  float v10; // s0

  v7 = transitionHeight < 0.0;
  *((_BYTE *)self + 12) = combineMeshes & 1;
  v8 = fminf(transitionHeight, 1.0);
  v9 = fminf(quality, 1.0);
  if ( v7 )
    v8 = 0.0;
  *((_BYTE *)self + 13) = combineSubMeshes & 1;
  *(float *)self = v8;
  *((float *)self + 1) = fadeWidth;
  if ( quality < 0.0 )
    v10 = 0.0;
  else
    v10 = v9;
  *((_QWORD *)self + 2) = 0;
  *((_BYTE *)self + 32) = 1;
  *((_DWORD *)self + 9) = 1;
  *((_BYTE *)self + 40) = 1;
  *((float *)self + 2) = v10;
  *((_QWORD *)self + 3) = 0x100000000LL;
  *(_QWORD *)((char *)self + 44) = 0x100000001LL;
}
