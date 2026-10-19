void __fastcall GameFramework_Resources_ResourcesModule__Initialize(__int64 a1)
{
  _QWORD *v2; // x0
  __int64 v3; // x0
  __int64 v4; // x20
  __int64 v5; // x21
  __int64 TypeFromHandle; // x0
  __int64 v7; // x21
  __int64 v8; // x0
  __int64 v9; // x21
  __int64 v10; // x0
  __int64 *v11; // x20
  __int64 v12; // x8
  __int64 v13; // x9
  __int64 v14; // x21
  _DWORD *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x0
  __int64 v18; // x0
  __int64 v19; // x20
  __int64 v20; // x8
  __int64 object; // x0
  __int64 text; // x20
  __int64 v23; // x21
  __int64 Instance; // x20
  __int64 FirstPack; // x0
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x1

  if ( (byte_900A0FC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DBD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8748);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D31578);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD5CA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D37C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3678);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7E348);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7E340);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6DB98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6DBA8);
    byte_900A0FC = 1;
  }
  if ( *(_BYTE *)(a1 + 16) != 0 )
    goto LABEL_36;
  if ( *((_DWORD *)off_8CEC898 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEC898);
  GameFramework_ResLoadHelper__CheckUseRightResLoad(0);
  v2 = off_8CE4408;
  if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE4408);
    v2 = off_8CE4408;
  }
  v3 = *(_QWORD *)(v2[23] + 72LL);
  if ( v3 == 0 )
    goto LABEL_44;
  *(_QWORD *)(a1 + 32) = UnityEngine_GameObject__GetComponent_object_(v3, qword_8D2D768);
  v4 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3678, 1);
  v5 = qword_8CD5CA8;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  if ( v4 == 0 )
    goto LABEL_44;
  v7 = TypeFromHandle;
  if ( TypeFromHandle != 0 )
  {
    v8 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(TypeFromHandle, *(_QWORD *)(*(_QWORD *)v4 + 64LL));
    if ( v8 == 0 )
      goto LABEL_46;
  }
  if ( *(_DWORD *)(v4 + 24) == 0 )
    goto LABEL_45;
  *(_QWORD *)(v4 + 32) = v7;
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
  sub_82EC96C(v9, qword_8D6DBA8, v4, 0);
  *(_QWORD *)(a1 + 48) = v9;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(0, v9, 0) & 1) != 0 )
  {
    v10 = *(_QWORD *)(a1 + 48);
    if ( v10 == 0 )
      goto LABEL_44;
    *(_QWORD *)(a1 + 40) = UnityEngine_GameObject__GetComponent_object_(v10, qword_8D2DBD0);
  }
  v11 = *(__int64 **)(a1 + 112);
  *(_BYTE *)(a1 + 16) = 1;
  if ( v11 == nullptr )
    goto LABEL_44;
  v12 = *v11;
  v13 = *(unsigned __int16 *)(*v11 + 302);
  v14 = qword_8D7E348;
  if ( *(_WORD *)(*v11 + 302) != 0 )
  {
    v15 = (_DWORD *)(*(_QWORD *)(v12 + 176) + 8LL);
    while ( *((_QWORD *)v15 - 1) != qword_8CE8748 )
    {
      --v13;
      v15 += 4;
      if ( v13 == 0 )
        goto LABEL_25;
    }
    v16 = v12 + 16LL * (*v15 + 1) + 312;
  }
  else
  {
LABEL_25:
    v16 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v11, qword_8CE8748, 1);
  }
  v17 = (*(__int64 (__fastcall **)(__int64 *, __int64, _QWORD))v16)(v11, v14, *(_QWORD *)(v16 + 8));
  if ( v17 == 0 )
LABEL_44:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_String__IsNullOrEmpty(*(_QWORD *)(v17 + 32), 0) & 1) == 0 )
  {
    object = UnityEngine_Resources__Load_object_(qword_8D7E340, qword_8D37C70);
    if ( object != 0 )
    {
      text = UnityEngine_TextAsset__get_text(object, 0);
      if ( *((_DWORD *)off_8CE9A10 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE9A10);
      v23 = LitJson_JsonMapper__ToObject_object_(text, qword_8D31578);
      Instance = UpdateManager__get_Instance();
      FirstPack = GameFramework_Resources_ResourcesModule__LoadFirstPack(a1, v23);
      if ( Instance != 0 )
      {
        UnityEngine_MonoBehaviour__StartCoroutine(Instance, FirstPack, 0);
        return;
      }
    }
    goto LABEL_44;
  }
  v18 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( v18 == 0 )
    goto LABEL_44;
  v19 = v18;
  if ( qword_8D6DB98 != 0 )
  {
    v8 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D6DB98, *(_QWORD *)(*(_QWORD *)v18 + 64LL));
    if ( v8 == 0 )
      goto LABEL_46;
  }
  if ( *(_DWORD *)(v19 + 24) == 0 )
  {
LABEL_45:
    v8 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_46:
    v26 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v8);
    v27 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v26, 0);
    GameFramework_Resources_ResourcesModule__LoadFirstPack(v27, v28);
    return;
  }
  *(_QWORD *)(v19 + 32) = qword_8D6DB98;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__R__u_e(v19, 0);
LABEL_36:
  v20 = *(_QWORD *)(a1 + 24);
  if ( v20 != 0 )
    (*(void (__fastcall **)(_QWORD, _QWORD))(v20 + 24))(*(_QWORD *)(v20 + 64), *(_QWORD *)(v20 + 40));
}
