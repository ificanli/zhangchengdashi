__int64 __fastcall GameModule_RoleBehaviour__ClearRoleTargetTracking(__int64 result)
{
  *(_QWORD *)(result + 280) = 0;
  *(_DWORD *)(result + 288) = -1;
  return result;
}
