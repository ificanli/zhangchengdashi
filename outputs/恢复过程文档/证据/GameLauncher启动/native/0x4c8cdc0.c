unsigned __int8 CoreModule_GameLauncher__TrySetPropertyOrField_bool_(
        void *self,
        void *target,
        void *propertyName,
        void *fieldName,
        unsigned __int8 value,
        const MethodInfo *method)
{
  __int64 Type; // x0
  __int64 v12; // x23
  char v13; // w24
  __int64 Property; // x0
  __int64 v15; // x22
  __int64 v16; // x0
  _QWORD *v17; // x8
  __int64 v18; // x20
  __int64 v19; // x0
  __int64 v20; // x21
  __int64 v21; // x0
  __int64 v22; // x21
  __int64 v23; // x0
  __int64 v25; // x0
  void *v26; // x0
  void *v27; // x1
  void *v28; // x2
  void *v29; // x3
  void *v30; // x4
  const MethodInfo *v31; // x5
  _BYTE v32[4]; // [xsp+8h] [xbp-38h] BYREF
  _BYTE v33[4]; // [xsp+Ch] [xbp-34h] BYREF

  if ( *((_QWORD *)method + 7) != 0
    || (il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258), *((_QWORD *)method + 7) != 0) )
  {
    if ( target != nullptr )
      goto LABEL_4;
    return 0;
  }
  ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  if ( target == nullptr )
    return 0;
LABEL_4:
  Type = System_Object__GetType(target, 0);
  if ( Type == 0 )
    goto LABEL_21;
  v12 = Type;
  v13 = value & 1;
  Property = System_Type__GetProperty(Type, propertyName, 52, 0);
  if ( Property != 0 )
    v15 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)Property + 728LL))(
            Property,
            1,
            *(_QWORD *)(*(_QWORD *)Property + 736LL));
  else
    v15 = 0;
  if ( (System_Reflection_MethodInfo__op_Inequality(v15, 0, 0) & 1) == 0 )
  {
    v22 = (*(__int64 (__fastcall **)(__int64, void *, __int64, _QWORD))(*(_QWORD *)v12 + 1752LL))(
            v12,
            fieldName,
            36,
            *(_QWORD *)(*(_QWORD *)v12 + 1760LL));
    if ( (System_Reflection_FieldInfo__op_Equality(v22, 0, 0) & 1) == 0 )
    {
      v32[0] = v13;
      v23 = ((__int64 (__fastcall *)(_QWORD, _BYTE *))unk_3C3D3B8)(**((_QWORD **)method + 7), v32);
      if ( v22 != 0 )
      {
        System_Reflection_FieldInfo__SetValue(v22, target, v23, 0);
        return 1;
      }
LABEL_21:
      il2cpp_codegen_raise_null_reference_exception();
    }
    return 0;
  }
  v16 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  v33[0] = v13;
  v17 = *((_QWORD **)method + 7);
  v18 = v16;
  v19 = ((__int64 (__fastcall *)(_QWORD, _BYTE *))unk_3C3D3B8)(*v17, v33);
  if ( v18 == 0 )
    goto LABEL_21;
  v20 = v19;
  if ( v19 == 0
    || (v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v19, *(_QWORD *)(*(_QWORD *)v18 + 64LL))) != 0 )
  {
    if ( *(_DWORD *)(v18 + 24) != 0 )
    {
      *(_QWORD *)(v18 + 32) = v20;
      if ( v15 != 0 )
      {
        System_Reflection_MethodBase__Invoke(v15, target, v18, 0);
        return 1;
      }
      goto LABEL_21;
    }
    v21 = ((__int64 (*)(void))unk_3C3D4D4)();
  }
  v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v21);
  v26 = (void *)((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v25, 0);
  return CoreModule_GameLauncher__TrySetPropertyOrField___Il2CppFullySharedGenericType_(v26, v27, v28, v29, v30, v31);
}
