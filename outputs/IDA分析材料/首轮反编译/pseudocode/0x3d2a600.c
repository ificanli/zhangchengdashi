ZCDS_Int32 HexManager__HexDistance(HexManager_HexCoord_o a, HexManager_HexCoord_o b, const MethodInfo *method)
{
  ZCDS_Int32 q; // w19
  ZCDS_Int32 v4; // w20
  ZCDS_Int32 r; // w21
  ZCDS_Int32 v6; // w22
  int v7; // w8
  int v8; // w9
  int v9; // w10

  q = b.fields.q;
  v4 = a.fields.q;
  r = a.fields.r;
  v6 = b.fields.r;
  if ( (byte_8FFD24D & 1) == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEA738);
    byte_8FFD24D = 1;
  }
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  v7 = v4 - q;
  if ( v4 - q < 0 )
    v7 = q - v4;
  v8 = r + v4 - q - v6;
  if ( v8 < 0 )
    v8 = v6 - (r + v4 - q);
  v9 = r - v6;
  if ( r - v6 < 0 )
    v9 = v6 - r;
  return (v9 + v7 + v8) / 2;
}
