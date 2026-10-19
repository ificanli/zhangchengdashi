float __fastcall GameModule_RoleBehaviour__InitSkillInfo(__int64 a1)
{
  __int64 v1; // x8
  float v2; // s0
  float result; // s0

  v1 = *(_QWORD *)(a1 + 64);
  if ( v1 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v2 = 20.0;
  if ( *(_DWORD *)(v1 + 80) == 3 )
    v2 = 15.0;
  *(float *)(a1 + 292) = v2;
  result = UnityEngine_Time__get_time(0) + 3.0;
  *(float *)(a1 + 296) = result;
  *(_BYTE *)(a1 + 300) = 0;
  return result;
}
