void CommonGameModule_Debugger_UGUI_RuntimeMemoryInformationWindowUGUI_1___ctor(
        void *self,
        void *arg0,
        const MethodInfo *method)
{
  __int64 v6; // x0
  __int64 v7; // x22
  _QWORD *v8; // x0
  __int64 v9; // x20
  __int64 TypeFromHandle; // x0

  if ( (byte_9003F5F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    byte_9003F5F = 1;
  }
  v6 = **(_QWORD **)(*((_QWORD *)method + 4) + 192LL);
  if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
    v6 = ((__int64 (*)(void))unk_3C503A0)();
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v6);
  System_Collections_Generic_List_object____ctor(v7, *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 8LL));
  *((_QWORD *)self + 6) = v7;
  v8 = off_8CE6460;
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6460);
    v8 = off_8CE6460;
  }
  *((_QWORD *)self + 7) = *(_QWORD *)(v8[23] + 16LL);
  CommonGameModule_Debugger_UGUI_BaseInformationWindowUGUI___ctor(self, arg0, nullptr);
  v9 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL);
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v9, 0);
  if ( TypeFromHandle == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)self + 11) = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 440LL))(
                             TypeFromHandle,
                             *(_QWORD *)(*(_QWORD *)TypeFromHandle + 448LL));
}
