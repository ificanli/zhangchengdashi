bool __fastcall sub_3DF96AC(_DWORD *a1, _QWORD *a2)
{
  _QWORD *v4; // x0
  __int64 v5; // x8

  if ( (byte_8FFD7DE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF1480);
    byte_8FFD7DE = 1;
  }
  if ( a2 != nullptr
    && *a2 == qword_8CF1480
    && (v4 = (_QWORD *)((__int64 (__fastcall *)(_QWORD *))unk_3C3D3BC)(a2),
        __PAIR64__(a1[1], *(unsigned __int8 *)a1) == __PAIR64__(HIDWORD(*v4), *(_DWORD *)v4 & 1))
    && (v5 = v4[1], a1[2] == (_DWORD)v5) )
  {
    return a1[3] == HIDWORD(v5);
  }
  else
  {
    return false;
  }
}
