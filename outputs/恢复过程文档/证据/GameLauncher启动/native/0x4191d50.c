void CoreModule_GameLauncher__DisablePostProcessingForLoadedCameras(void *self, const MethodInfo *method)
{
  int allCamerasCount; // w0
  __int64 v3; // x19
  int AllCameras; // w0
  unsigned __int64 v5; // x21
  __int64 v6; // x22
  __int64 v7; // x20
  __int64 UniversalAdditionalCameraData; // x0

  if ( (byte_8FFF6B3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2C08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D54190);
    byte_8FFF6B3 = 1;
  }
  allCamerasCount = UnityEngine_Camera__get_allCamerasCount(0, method);
  if ( allCamerasCount <= 0 )
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogWarning(qword_8D54190, 0);
  }
  else
  {
    v3 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D320)(qword_8CE2C08, (unsigned int)allCamerasCount);
    AllCameras = UnityEngine_Camera__GetAllCameras(v3, 0);
    if ( AllCameras >= 1 )
    {
      if ( v3 != 0 )
      {
        v5 = 0;
        v6 = (unsigned int)AllCameras;
        while ( v5 < *(unsigned int *)(v3 + 24) )
        {
          v7 = *(_QWORD *)(v3 + 32 + 8 * v5);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Equality(v7, 0, 0) & 1) == 0 )
          {
            UniversalAdditionalCameraData = UnityEngine_Rendering_Universal_CameraExtensions__GetUniversalAdditionalCameraData(
                                              v7,
                                              0);
            if ( UniversalAdditionalCameraData == 0 )
              goto LABEL_19;
            *(_BYTE *)(UniversalAdditionalCameraData + 76) = 0;
            *(_DWORD *)(UniversalAdditionalCameraData + 80) = 0;
          }
          if ( v6 == ++v5 )
            return;
        }
        ((void (*)(void))unk_3C3D4D4)();
      }
LABEL_19:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
}
