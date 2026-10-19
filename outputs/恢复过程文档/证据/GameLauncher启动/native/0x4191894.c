void CoreModule_GameLauncher__LoadingCompleted(void *self, void *obj, const MethodInfo *method)
{
  __int64 v3; // x0

  CoreModule_GameLauncher__StopLoadingCompletedListening(self, (const MethodInfo *)obj);
  CoreModule_GameLauncher__InitGame(v3);
}
