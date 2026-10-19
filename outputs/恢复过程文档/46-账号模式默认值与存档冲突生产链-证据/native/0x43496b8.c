void DataModule_DataCompareMgr__Awake(void *self, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x20
  __int64 gameObject; // x19
  _QWORD *v6; // x0
  __int64 v7; // x20
  __int64 v8; // x20

  if ( (byte_90005E0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D27CD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6130);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB538);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_90005E0 = 1;
  }
  v3 = off_8CE6130;
  if ( *((_DWORD *)off_8CE6130 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6130);
    v3 = off_8CE6130;
  }
  v4 = *(_QWORD *)(v3[23] + 8LL);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v4, 0, 0) & 1) != 0 )
  {
    gameObject = UnityEngine_Component__get_gameObject(self, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__DestroyImmediate(gameObject, 0);
  }
  else
  {
    v6 = off_8CE6130;
    if ( *((_DWORD *)off_8CE6130 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE6130);
      v6 = off_8CE6130;
    }
    *(_QWORD *)(v6[23] + 8LL) = self;
    v7 = UnityEngine_Component__get_gameObject(self, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__DontDestroyOnLoad(v7, 0);
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB538);
    System_Func_object__bool____ctor(v8, self, qword_8D27CD8, 0);
    if ( *((_DWORD *)off_8CE7B18 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7B18);
    GameFramework_GameData_GameDataVersionMgr__add_onManualHandleData(v8, 0);
  }
}
