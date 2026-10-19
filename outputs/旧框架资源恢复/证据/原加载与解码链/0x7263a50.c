// local variable allocation has failed, the output may be wrong!
void *GameFramework_Tools_UIGradientBlender____wcm_(void *data, unsigned __int8 flag, const MethodInfo *method)
{
  _DWORD *v4; // x19
  int v5; // w8
  int v6; // w8
  int v7; // w20
  bool v8; // vf
  int v9; // w8
  __int64 v10; // x0
  __int64 v11; // x19
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x20
  __int64 v15; // x0
  __int64 v16; // x0
  void *v17; // x8
  int v18; // w9
  unsigned __int64 v19; // x10
  char v20; // w14
  __int64 v22; // x0
  int v23; // w1
  _QWORD **v24; // x19
  __int64 v25; // x0
  _QWORD *v26; // x19
  int v27; // [xsp+Ch] [xbp-24h] BYREF

  v4 = data;
  if ( (byte_9009AD8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2BF0);
    byte_9009AD8 = 1;
  }
  if ( (flag & 1) == 0 )
    goto LABEL_9;
  if ( v4 == nullptr )
    goto LABEL_21;
  v5 = v4[6];
  if ( v5 == 0 )
  {
    v22 = ((__int64 (__fastcall *)(void *, _QWORD, const MethodInfo *))unk_3C3D4D4)(data, flag, method);
    if ( v23 != 1 )
      sub_3CE73C4(v22);
    v24 = (_QWORD **)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v22);
    v25 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
    if ( (((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D8F8)(v25, **v24) & 1) == 0 )
    {
      *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8) = *v24;
      ((void (__noreturn *)(void))__cxa_throw)();
    }
    v26 = *v24;
    ((void (*)(void))__cxa_end_catch)();
    ((void (__fastcall *)(_QWORD *))GameFramework_Tools_UIGradientBlender___l___h)(v26);
    return nullptr;
  }
  v6 = v5 - 1;
  v7 = v4[v6 + 8];
  v6 *= 4;
  v8 = __OFSUB__(v6, v7);
  v9 = v6 - v7;
  if ( v9 < 0 != v8 || v9 >= 4 )
  {
    v27 = v7;
    v10 = ((__int64 (__fastcall *)(__int64 *, _QWORD, const MethodInfo *))unk_3C3D294)(&qword_8CE95C0, flag, method);
    v11 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(v10, &v27);
    v12 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D84BB0);
    v4 = (_DWORD *)System_String__Format(v12, v11, 0);
    v13 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
    v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v13);
    System_Exception___ctor(v14, v4, 0);
    v15 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D3C448);
    ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v14, v15);
LABEL_9:
    if ( v4 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v7 = 4 * v4[6];
  }
  v16 = ((__int64 (__fastcall *)(__int64, _QWORD, const MethodInfo *))unk_3C3D320)(
          qword_8CE2BF0,
          (unsigned int)v7,
          method);
  v17 = (void *)v16;
  if ( v7 >= 1 )
  {
    v18 = 0;
    v19 = 0;
    while ( 1 )
    {
      if ( (unsigned int)((int)v19 >> 2) >= v4[6] )
        goto LABEL_20;
      if ( v16 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v19 >= *(unsigned int *)(v16 + 24) )
        break;
      v20 = v18 & 0x18;
      v18 += 8;
      *(_BYTE *)(v16 + 32 + v19) = v4[((int)v19 >> 2) + 8] >> v20;
      if ( v7 == ++v19 )
        return v17;
    }
    v16 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_20:
    ((void (__fastcall *)(__int64))unk_3C3D4D4)(v16);
LABEL_21:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return v17;
}
