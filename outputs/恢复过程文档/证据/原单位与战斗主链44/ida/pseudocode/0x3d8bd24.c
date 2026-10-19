__int64 __fastcall GameModule_RoleBehaviour__ApplySubGameCurrentHpChange(_BYTE *a1, int a2)
{
  __int64 result; // x0
  __int64 v5; // x8
  int v6; // w8
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x21
  void *Instance; // x0
  long double v13; // q0
  long double v14; // q1
  long double v15; // q2
  long double v16; // q3
  __int64 v17; // x8
  __int64 v18; // x8

  if ( (byte_8FFD49B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52658);
    byte_8FFD49B = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Equality(a1, 0, 0);
  if ( (result & 1) == 0 )
  {
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
    if ( byte_8FFD1AB == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
      byte_8FFD1AB = 1;
    }
    result = (__int64)off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      result = (__int64)off_8CE5E20;
    }
    if ( **(_BYTE **)(result + 184) != 0 && a1[33] == 0 && a2 >= 1 )
    {
      v5 = *((_QWORD *)a1 + 8);
      if ( v5 != 0 )
      {
        v6 = *(_DWORD *)(v5 + 24);
        if ( v6 <= a2 )
          a2 = v6;
        if ( a2 >= 1 )
        {
          v7 = *((_QWORD *)a1 + 68);
          if ( v7 == 0 )
            goto LABEL_29;
          System_Text_StringBuilder__Clear(v7, 0);
          v8 = *((_QWORD *)a1 + 68);
          if ( v8 == 0 )
            goto LABEL_29;
          System_Text_StringBuilder__Append(v8, qword_8D52658, 0);
          v9 = *((_QWORD *)a1 + 68);
          if ( v9 == 0 )
            goto LABEL_29;
          sub_751B730(v9, (unsigned int)a2, 0);
          v10 = *((_QWORD *)a1 + 68);
          if ( v10 == 0 )
            goto LABEL_29;
          v11 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v10 + 360LL))(
                  v10,
                  *(_QWORD *)(*(_QWORD *)v10 + 368LL));
          Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12168);
          if ( Instance == nullptr
            || (GameModule_FloatingTextManager__GetDamageTextColor(Instance, (unsigned __int8)a1[32], 0, 0),
                GameModule_RoleBehaviour__ShowDamageText((__int64)a1, v11, v13, v14, v15, v16),
                (v17 = *((_QWORD *)a1 + 8)) == 0)
            || (*(_DWORD *)(v17 + 24) -= a2,
                result = (*(__int64 (__fastcall **)(_BYTE *, _QWORD))(*(_QWORD *)a1 + 840LL))(
                           a1,
                           *(_QWORD *)(*(_QWORD *)a1 + 848LL)),
                (v18 = *((_QWORD *)a1 + 8)) == 0) )
          {
LABEL_29:
            il2cpp_codegen_raise_null_reference_exception();
          }
          if ( *(int *)(v18 + 24) <= 0 )
          {
            *(_DWORD *)(v18 + 24) = 0;
            return (*(__int64 (__fastcall **)(_BYTE *, _QWORD, _QWORD))(*(_QWORD *)a1 + 696LL))(
                     a1,
                     0,
                     *(_QWORD *)(*(_QWORD *)a1 + 704LL));
          }
        }
      }
    }
  }
  return result;
}
