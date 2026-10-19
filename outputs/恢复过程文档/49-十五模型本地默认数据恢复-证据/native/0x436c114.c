void DataModule_PlayerArtifactData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  char IsBGroup; // w20
  unsigned int v5; // w20
  __int64 v6; // x0

  ServerBaseData__Init(self, 0);
  DataModule_PlayerArtifactData__EnsureGroupsNotNull(self);
  v3 = DataModule_PlayerArtifactData__MergeLegacyKeysToGroupsIfNeeded(self);
  IsBGroup = DataModule_PlayerArtifactData__IsBGroup(v3);
  DataModule_PlayerArtifactData__AbsorbLegacyActiveCacheToAIfNeeded(self);
  v5 = IsBGroup & 1;
  DataModule_PlayerArtifactData__TryMigrateAToBOnFirstEnter(self, v5);
  DataModule_PlayerArtifactData__LoadActiveFromGroup(self, v5);
  DataModule_PlayerArtifactData__FillMissingByCurrentConfig(self);
  v6 = DataModule_PlayerArtifactData__SyncActiveToGroupMerge(self, v5);
  DataModule_PlayerArtifactData__TryInitLimitedSummonRotationOnArtifactsUnlock(v6);
}
