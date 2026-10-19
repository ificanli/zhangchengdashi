void _____d____ye__a(void *self, const MethodInfo *method)
{
  __int64 v3; // x8
  int v4; // w2
  int v5; // w9
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20
  __int64 v9; // x20

  if ( (byte_9009EE0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D10188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D408D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D408E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D40900);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D408B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF66C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60EB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60EB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60EA8);
    byte_9009EE0 = 1;
  }
  v3 = *((_QWORD *)self + 2);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = *(_DWORD *)(v3 + 24);
  v5 = *(_DWORD *)(v3 + 28) + 1;
  *(_DWORD *)(v3 + 24) = 0;
  *(_DWORD *)(v3 + 28) = v5;
  if ( v4 >= 1 )
    System_Array__Clear(*(_QWORD *)(v3 + 16), 0);
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF66C8);
  UpdateManager_UpdateHandle___ctor(v6, self, qword_8D408D8, 0);
  *((_DWORD *)self + 6) = UpdateManager__AddHandle(v6, 0);
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
  GameFramework_MsgDispatcher_EventHandler___ctor(v7, self, qword_8D40900, 0);
  GameFramework_MsgDispatcher__AddEventListener(qword_8D60EA8, v7, 0);
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
  GameFramework_MsgDispatcher_EventHandler___ctor(v8, self, qword_8D408B0, 0);
  GameFramework_MsgDispatcher__AddEventListener(qword_8D60EB8, v8, 0);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
  GameFramework_MsgDispatcher_EventHandler___ctor(v9, self, qword_8D408E8, 0);
  GameFramework_MsgDispatcher__AddEventListener(qword_8D60EB0, v9, 0);
}
