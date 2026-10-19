void GameFramework_DataManagerPool____Fe_p(void *self, const MethodInfo *method)
{
  _BYTE *v2; // x24
  __int64 CSharpAssembly; // x0
  __int64 v5; // x0
  __int64 v6; // x21
  __int64 v7; // x20
  __int64 TypeFromHandle; // x0
  int v9; // w8
  __int64 v10; // x21
  unsigned int v11; // w25
  __int64 v12; // x22
  __int64 CustomAttribute_object; // x0
  __int64 v14; // x23
  __int64 MineGameName; // x0
  __int64 v16; // x3
  _BYTE *Instance; // x0
  __int64 v18; // x9
  __int64 v19; // x9
  __int64 v20; // x0

  if ( (byte_90091E8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF6750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D27768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD3AC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    byte_90091E8 = 1;
  }
  if ( *((_DWORD *)off_8CF6750 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CF6750);
  CSharpAssembly = GameFramework_Utility_AssemblyUtility__LoadCSharpAssembly(0, method);
  if ( CSharpAssembly == 0 )
    goto LABEL_25;
  v5 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)CSharpAssembly + 600LL))(
         CSharpAssembly,
         *(_QWORD *)(*(_QWORD *)CSharpAssembly + 608LL));
  v6 = qword_8CD3AC0;
  v7 = v5;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v6, 0);
  if ( v7 == 0 )
LABEL_25:
    il2cpp_codegen_raise_null_reference_exception();
  v9 = *(_DWORD *)(v7 + 24);
  if ( v9 >= 1 )
  {
    v10 = TypeFromHandle;
    v11 = 0;
    while ( v11 < v9 )
    {
      v12 = *(_QWORD *)(v7 + 8LL * (int)v11 + 32);
      if ( v12 == 0 )
        goto LABEL_25;
      if ( ((*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)v12 + 696LL))(
              v12,
              v10,
              *(_QWORD *)(*(_QWORD *)v12 + 704LL))
          & 1) != 0 )
      {
        CustomAttribute_object = System_Reflection_CustomAttributeExtensions__GetCustomAttribute_object_(
                                   v12,
                                   qword_8D27768);
        if ( CustomAttribute_object != 0 )
        {
          v14 = CustomAttribute_object;
          v2 = *(_BYTE **)(CustomAttribute_object + 16);
          if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE40C8);
          MineGameName = GameFramework_AppSetting__get_MineGameName();
          if ( (System_String__op_Equality(v2, MineGameName, 0, v16) & 1) != 0 )
          {
            Instance = (_BYTE *)System_Activator__CreateInstance(v12, 0);
            if ( Instance == nullptr )
              goto LABEL_25;
            v2 = Instance;
            v18 = *((unsigned __int8 *)off_8CE6170 + 304);
            if ( *(unsigned __int8 *)(*(_QWORD *)Instance + 304LL) < (unsigned int)v18
              || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)Instance + 200LL) + 8 * v18 - 8) != off_8CE6170 )
            {
              goto LABEL_27;
            }
            v19 = *(_QWORD *)Instance;
            Instance[17] = *(_BYTE *)(v14 + 24);
            Instance[18] = *(_BYTE *)(v14 + 25);
            (*(void (__fastcall **)(_BYTE *, _QWORD))(v19 + 392))(Instance, *(_QWORD *)(v19 + 400));
            v20 = *((_QWORD *)self + 2);
            if ( v20 == 0 )
              goto LABEL_25;
            System_Collections_Generic_Dictionary_object__object___set_Item(v20, v12, v2, qword_8D00198);
          }
        }
      }
      v9 = *(_DWORD *)(v7 + 24);
      if ( (int)++v11 >= v9 )
        return;
    }
    ((void (*)(void))unk_3C3D4D4)();
LABEL_27:
    ((void (__fastcall *)(_BYTE *))unk_3C3D868)(v2);
    JUMPOUT(0x7178788);
  }
}
