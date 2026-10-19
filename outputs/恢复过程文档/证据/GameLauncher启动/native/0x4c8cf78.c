unsigned __int8 CoreModule_GameLauncher__TrySetPropertyOrField___Il2CppFullySharedGenericType_(
        void *self,
        void *target,
        void *propertyName,
        void *fieldName,
        void *value,
        const MethodInfo *method)
{
  __int64 v9; // x8
  __int64 v12; // x23
  __int64 Type; // x0
  __int64 v14; // x26
  __int64 Property; // x0
  __int64 v16; // x25
  __int64 v17; // x0
  _QWORD *v18; // x21
  __int64 v19; // x24
  _QWORD *v20; // x1
  __int64 v21; // x0
  __int64 v22; // x1
  __int64 v23; // x20
  __int64 v24; // x24
  _QWORD *v26; // x21
  _QWORD *v27; // x1
  __int64 v28; // x0
  __int64 v29; // x0
  _QWORD v30[2]; // [xsp+0h] [xbp-10h] BYREF

  v30[1] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  v30[0] = value;
  v9 = *((_QWORD *)method + 7);
  if ( v9 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    v9 = *((_QWORD *)method + 7);
    if ( v9 == 0 )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v9 = *((_QWORD *)method + 7);
    }
  }
  v12 = *(unsigned int *)(*(_QWORD *)v9 + 252LL);
  if ( target == nullptr )
    return 0;
  Type = System_Object__GetType(target, 0);
  if ( Type == 0 )
    goto LABEL_28;
  v14 = Type;
  Property = System_Type__GetProperty(Type, propertyName, 52, 0);
  if ( Property != 0 )
    v16 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)Property + 728LL))(
            Property,
            1,
            *(_QWORD *)(*(_QWORD *)Property + 736LL));
  else
    v16 = 0;
  if ( (System_Reflection_MethodInfo__op_Inequality(v16, 0, 0) & 1) == 0 )
  {
    v24 = (*(__int64 (__fastcall **)(__int64, void *, __int64, _QWORD))(*(_QWORD *)v14 + 1752LL))(
            v14,
            fieldName,
            36,
            *(_QWORD *)(*(_QWORD *)v14 + 1760LL));
    if ( (System_Reflection_FieldInfo__op_Equality(v24, 0, 0) & 1) == 0 )
    {
      v26 = *((_QWORD **)method + 7);
      if ( *(int *)(*v26 + 40LL) >= 0 )
        v27 = v30;
      else
        v27 = value;
      ((void (__fastcall *)(char *, _QWORD *, __int64))memcpy)((char *)v30 - ((v12 + 15) & 0x1FFFFFFF0LL), v27, v12);
      v28 = ((__int64 (__fastcall *)(_QWORD, char *))unk_3C3D3B8)(*v26, (char *)v30 - ((v12 + 15) & 0x1FFFFFFF0LL));
      if ( v24 != 0 )
      {
        System_Reflection_FieldInfo__SetValue(v24, target, v28, 0);
        return 1;
      }
LABEL_28:
      il2cpp_codegen_raise_null_reference_exception();
    }
    return 0;
  }
  v17 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v18 = *((_QWORD **)method + 7);
  v19 = v17;
  if ( *(int *)(*v18 + 40LL) >= 0 )
    v20 = v30;
  else
    v20 = value;
  ((void (__fastcall *)(char *, _QWORD *, __int64))memcpy)((char *)v30 - ((v12 + 15) & 0x1FFFFFFF0LL), v20, v12);
  v21 = ((__int64 (__fastcall *)(_QWORD, char *))unk_3C3D3B8)(*v18, (char *)v30 - ((v12 + 15) & 0x1FFFFFFF0LL));
  if ( v19 == 0 )
    goto LABEL_28;
  v23 = v21;
  if ( v21 != 0 )
  {
    v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v21, *(_QWORD *)(*(_QWORD *)v19 + 64LL));
    if ( v21 == 0 )
    {
LABEL_30:
      v29 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v21);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v29, 0);
    }
  }
  if ( *(_DWORD *)(v19 + 24) == 0 )
  {
    v21 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D4D4)(v21, v22);
    goto LABEL_30;
  }
  *(_QWORD *)(v19 + 32) = v23;
  if ( v16 == 0 )
    goto LABEL_28;
  System_Reflection_MethodBase__Invoke(v16, target, v19, 0);
  return 1;
}
