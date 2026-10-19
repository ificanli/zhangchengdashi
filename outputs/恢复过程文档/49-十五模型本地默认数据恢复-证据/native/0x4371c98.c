void DataModule_PlayerCustomizationData__InitFromDefaults(void *self, const MethodInfo *method)
{
  int v3; // w21
  int v4; // w22
  __int64 v5; // x20
  int v6; // w20
  double v7; // d0
  int v8; // w8
  __int64 v9; // x0
  int v10; // [xsp+Ch] [xbp-44h] BYREF

  if ( (byte_9000731 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEC278);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D77010);
    byte_9000731 = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  if ( (ToolModule_StringTool__IsNullOrEmpty(*((_QWORD *)self + 3), 1, 0) & 1) != 0 )
  {
    v3 = 0;
    v4 = 0;
    do
    {
      v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEC278);
      System_Random___ctor(v5, 0);
      if ( v5 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v6 = (*(__int64 (__fastcall **)(__int64, _QWORD, __int64, _QWORD))(*(_QWORD *)v5 + 408LL))(
             v5,
             0,
             9,
             *(_QWORD *)(*(_QWORD *)v5 + 416LL));
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v7 = System_Math__Pow(0, 10.0, (double)v4);
      v8 = (int)v7;
      ++v4;
      if ( v7 == INFINITY )
        v8 = 0x80000000;
      v3 += v8 * v6;
      v10 = v3;
    }
    while ( v4 != 6 );
    v9 = System_Int32__ToString(&v10, 0);
    *((_QWORD *)self + 3) = sub_74FE7A4(qword_8D77010, v9, 0);
  }
}
