void sub_8555634(
        void *self,
        float transitionHeight,
        float fadeWidth,
        float quality,
        unsigned __int8 combineMeshes,
        unsigned __int8 combineSubMeshes,
        void *renderers,
        const MethodInfo *method)
{
  bool v8; // nf
  float v9; // s0
  float v10; // s3
  float v11; // s0

  v8 = transitionHeight < 0.0;
  v9 = fminf(transitionHeight, 1.0);
  v10 = fminf(quality, 1.0);
  if ( v8 )
    v9 = 0.0;
  *((_BYTE *)self + 12) = combineMeshes & 1;
  *(float *)self = v9;
  *((float *)self + 1) = fadeWidth;
  if ( quality < 0.0 )
    v11 = 0.0;
  else
    v11 = v10;
  *((_QWORD *)self + 2) = renderers;
  *((_BYTE *)self + 13) = combineSubMeshes & 1;
  *((_BYTE *)self + 32) = 1;
  *((_DWORD *)self + 9) = 1;
  *((_BYTE *)self + 40) = 1;
  *((float *)self + 2) = v11;
  *((_QWORD *)self + 3) = 0x100000000LL;
  *(_QWORD *)((char *)self + 44) = 0x100000001LL;
}
