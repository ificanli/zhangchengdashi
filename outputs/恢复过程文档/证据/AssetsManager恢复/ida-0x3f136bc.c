void AssetsModule_AssetsManager__GenerateGroupsMap_d__18__MoveNext(void *self, const MethodInfo *method)
{
  int v3; // w22
  __int64 v4; // x24
  __int64 v5; // x20
  __int64 object; // x0
  __int64 text; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x21
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x21
  __int64 v15; // x20
  __int64 v16; // x22
  __int64 *v17; // x19
  __int64 v18; // x8
  __int64 v19; // x9
  _DWORD *v20; // x10
  __int64 v21; // x0
  int v22; // [xsp+14h] [xbp-9Ch]
  __int128 v23; // [xsp+18h] [xbp-98h] BYREF
  __int64 v24; // [xsp+28h] [xbp-88h]
  __int128 v25; // [xsp+30h] [xbp-80h] BYREF
  __int64 v26; // [xsp+40h] [xbp-70h]

  if ( (byte_8FFE076 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE0B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE0B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9BB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01758);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01760);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D31BA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D09120);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D37C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D55C98);
    byte_8FFE076 = 1;
  }
  v25 = 0u;
  v26 = 0;
  v3 = *(_DWORD *)self;
  v4 = *((_QWORD *)self + 3);
  v5 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9BB0, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFDE28);
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v4 + 80) = v5;
  object = UnityEngine_Resources__Load_object_(qword_8D55C98, qword_8D37C70);
  if ( object == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  text = UnityEngine_TextAsset__get_text(object, 0);
  v8 = UnityEngine_JsonUtility__FromJson_object_(text, qword_8D31BA8);
  if ( v8 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v9 = *(_QWORD *)(v8 + 16);
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C30);
  System_Collections_Generic_Dictionary_object__object____ctor(v10, qword_8CFE0B0);
  *(_QWORD *)(v4 + 88) = v10;
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v22 = v3;
  System_Collections_Generic_List_object___GetEnumerator(&v23, v9, qword_8D09120);
  v25 = v23;
  v26 = v24;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v25, qword_8D01760) & 1) != 0 )
  {
    v11 = v26;
    if ( v26 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v12 = *(_QWORD *)(v4 + 88);
    if ( v12 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___Add(v12, *(_QWORD *)(v26 + 16), v26, qword_8CFE0B8);
    v13 = *(_QWORD *)(v4 + 80);
    if ( v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v13, *(_QWORD *)(v11 + 24), qword_8CFDE38)
        & 1) == 0 )
    {
      v14 = *(_QWORD *)(v4 + 80);
      v15 = *(_QWORD *)(v11 + 24);
      v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
      System_Collections_Generic_List_object____ctor(v16, qword_8D0E5E0);
      if ( v14 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Collections_Generic_Dictionary_object__object___Add(v14, v15, v16, qword_8CFDE30);
    }
  }
  if ( v22 < 0 )
    System_Collections_Generic_List_Enumerator_object___Dispose(&v25, qword_8D01758);
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v17 = *((__int64 **)self + 1);
  if ( v17 != nullptr )
  {
    v18 = *v17;
    v19 = *(unsigned __int16 *)(*v17 + 302);
    if ( *(_WORD *)(*v17 + 302) != 0 )
    {
      v20 = (_DWORD *)(*(_QWORD *)(v18 + 176) + 8LL);
      while ( *((_QWORD *)v20 - 1) != qword_8CE9038 )
      {
        --v19;
        v20 += 4;
        if ( v19 == 0 )
          goto LABEL_24;
      }
      v21 = v18 + 16LL * (*v20 + 2) + 312;
    }
    else
    {
LABEL_24:
      v21 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v17, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v21)(v17, *(_QWORD *)(v21 + 8));
  }
}
