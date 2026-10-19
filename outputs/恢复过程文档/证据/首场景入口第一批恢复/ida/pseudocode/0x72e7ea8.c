void GameFramework_Base_GameStartEntry___a__gf(void *self, void *args, const MethodInfo *method)
{
  __int64 Instance; // x0
  __int64 v5; // x0
  __int64 gameObject; // x19
  __int64 v7; // x0
  __int64 v8; // x0

  if ( (byte_900A049 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7BE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9308);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF158);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86DC0);
    byte_900A049 = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, (void *)qword_8D86DC0, method);
  Instance = GameFramework_AudioManager__get_Instance(0);
  if ( Instance == 0 )
    goto LABEL_11;
  GameFramework_AudioManager__Destroy(Instance, 0);
  *((_BYTE *)self + 73) = 1;
  v5 = **((_QWORD **)off_8CE9308 + 23);
  if ( v5 == 0 )
    goto LABEL_11;
  DBTSDK_IapManager__CloseIapProcedure(v5, 0);
  gameObject = UnityEngine_Component__get_gameObject(self, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  UnityEngine_Object__Destroy(gameObject, 0);
  v7 = UpdateManager__get_Instance(0);
  if ( v7 == 0 )
LABEL_11:
    il2cpp_codegen_raise_null_reference_exception();
  v8 = UnityEngine_Component__get_gameObject(v7, 0);
  UnityEngine_Object__Destroy(v8, 0);
  if ( *((_DWORD *)off_8CEF158 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEF158);
  GameFramework_UserDataPrefs__OnSave(0);
  GameFramework_MsgDispatcher__ClearEvent(0);
  **((_BYTE **)off_8CE7BE8 + 23) = 0;
}
