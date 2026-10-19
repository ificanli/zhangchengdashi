__int64 __fastcall GameModule_RoleBehaviour__SetSummonsNumber(_QWORD *a1, float a2)
{
  __int64 v2; // x8
  float32x2_t v3; // d0
  unsigned __int64 v4; // d0

  v2 = a1[8];
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v3.n64_u64[0] = vmul_n_f32(vcvt_f32_s32(*(int32x2_t *)(v2 + 28)), a2).n64_u64[0];
  v4 = vbsl_s8(vceq_f32(v3, vdup_n_s32(0x7F800000u)), (int8x8_t)0x8000000080000000LL, vcvt_s32_f32(v3)).n64_u64[0];
  *(_DWORD *)(v2 + 24) = v4;
  *(_QWORD *)(v2 + 28) = v4;
  return (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*a1 + 680LL))(a1, *(_QWORD *)(*a1 + 688LL));
}
