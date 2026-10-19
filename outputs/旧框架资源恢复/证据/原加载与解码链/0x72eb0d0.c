void GameFramework_Resources_BundleAssetInfo___ctor(
        void *self,
        void *name,
        void *a,
        void *b,
        int size,
        unsigned __int8 flag,
        void *c,
        void *seed,
        unsigned __int8 secondFlag,
        const MethodInfo *method)
{
  char v17; // w28
  _BYTE **v18; // x0
  __int64 v19; // x20
  __int64 v20; // x0
  __int64 v21; // x24
  __int64 v22; // x22
  __int64 v23; // x0
  unsigned int v24; // w8
  __int64 v25; // x24
  __int64 v26; // x24
  __int64 v27; // x0
  __int64 v28; // x24
  __int64 v29; // x0
  __int64 v30; // x23
  unsigned int v31; // w8
  __int64 v32; // x0
  __int64 v33; // x19
  __int64 v34; // x0
  __int64 v35; // x19
  __int64 v36; // x0
  _BYTE v37[4]; // [xsp+4h] [xbp-6Ch] BYREF
  _BYTE v38[4]; // [xsp+8h] [xbp-68h] BYREF
  int v39; // [xsp+Ch] [xbp-64h] BYREF

  v17 = flag & 1;
  if ( (byte_900A060 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE4D90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5D360);
    byte_900A060 = 1;
  }
  *((_BYTE *)self + 64) = 1;
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 4) = a;
  *((_QWORD *)self + 5) = b;
  *((_DWORD *)self + 12) = size;
  *((_BYTE *)self + 52) = v17;
  *((_QWORD *)self + 2) = name;
  *((_QWORD *)self + 3) = c;
  *((_QWORD *)self + 7) = seed;
  *((_BYTE *)self + 64) = secondFlag & 1;
  v18 = (_BYTE **)off_8CE5250;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5250);
    v18 = (_BYTE **)off_8CE5250;
  }
  if ( *v18[23] != 0 )
  {
    v19 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v20 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 8);
    if ( v20 == 0 )
      goto LABEL_45;
    v21 = *((_QWORD *)self + 2);
    v22 = v20;
    if ( v21 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
              *((_QWORD *)self + 2),
              *(_QWORD *)(*(_QWORD *)v20 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
    }
    v24 = *(_DWORD *)(v22 + 24);
    if ( v24 == 0 )
      goto LABEL_43;
    *(_QWORD *)(v22 + 32) = v21;
    v25 = *((_QWORD *)self + 4);
    if ( v25 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
              *((_QWORD *)self + 4),
              *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
      v24 = *(_DWORD *)(v22 + 24);
    }
    if ( v24 <= 1 )
      goto LABEL_43;
    *(_QWORD *)(v22 + 40) = v25;
    v26 = *((_QWORD *)self + 5);
    if ( v26 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
              *((_QWORD *)self + 5),
              *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
      v24 = *(_DWORD *)(v22 + 24);
    }
    if ( v24 <= 2 )
      goto LABEL_43;
    *(_QWORD *)(v22 + 48) = v26;
    v39 = *((_DWORD *)self + 12);
    v27 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v39);
    v28 = v27;
    if ( v27 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v27, *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
    }
    if ( *(_DWORD *)(v22 + 24) <= 3u )
      goto LABEL_43;
    *(_QWORD *)(v22 + 56) = v28;
    v38[0] = *((_BYTE *)self + 52);
    v29 = ((__int64 (__fastcall *)(__int64, _BYTE *))unk_3C3D3B8)(qword_8CE4D90, v38);
    v30 = v29;
    if ( v29 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v29, *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
    }
    v31 = *(_DWORD *)(v22 + 24);
    if ( v31 <= 4 )
      goto LABEL_43;
    *(_QWORD *)(v22 + 64) = v30;
    if ( c != nullptr )
    {
      v23 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(c, *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
      v31 = *(_DWORD *)(v22 + 24);
    }
    if ( v31 <= 5 )
    {
LABEL_43:
      v23 = ((__int64 (*)(void))unk_3C3D4D4)();
      goto LABEL_44;
    }
    *(_QWORD *)(v22 + 72) = c;
    if ( seed != nullptr )
    {
      v23 = ((__int64 (__fastcall *)(void *, _QWORD))unk_3C3D3B4)(seed, *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
      v31 = *(_DWORD *)(v22 + 24);
    }
    if ( v31 <= 6 )
      goto LABEL_43;
    *(_QWORD *)(v22 + 80) = seed;
    v37[0] = secondFlag & 1;
    v32 = ((__int64 (__fastcall *)(__int64, _BYTE *))unk_3C3D3B8)(qword_8CE4D90, v37);
    v33 = v32;
    if ( v32 != 0 )
    {
      v23 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v32, *(_QWORD *)(*(_QWORD *)v22 + 64LL));
      if ( v23 == 0 )
        goto LABEL_44;
    }
    if ( *(_DWORD *)(v22 + 24) <= 7u )
      goto LABEL_43;
    *(_QWORD *)(v22 + 88) = v33;
    v34 = sub_750AAD4(qword_8D5D360, v22, 0);
    if ( v19 != 0 )
    {
      v35 = v34;
      if ( v34 == 0
        || (v23 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v34, *(_QWORD *)(*(_QWORD *)v19 + 64LL))) != 0 )
      {
        if ( *(_DWORD *)(v19 + 24) != 0 )
        {
          *(_QWORD *)(v19 + 32) = v35;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          sub_71FF550(0x1000000, v19, 0);
          return;
        }
        goto LABEL_43;
      }
LABEL_44:
      v36 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v23);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v36, 0);
    }
LABEL_45:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
