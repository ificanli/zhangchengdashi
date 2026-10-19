void DataModule_PlayerChestData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x21
  __int64 v7; // x20
  __int64 v8; // x0
  __int64 v9; // x8
  unsigned int v10; // w20
  __int64 v11; // x0
  __int64 Item; // x0
  __int64 v13; // x0
  __int64 v14; // x0
  _QWORD *Instance; // x0
  __int64 v16; // x8
  __int64 v17; // x0
  __int64 v18; // x21
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x21
  __int64 v22; // x0
  __int64 v23; // x22
  _QWORD *v24; // x0
  __int64 v25; // x8
  __int64 v26; // x0
  __int64 v27; // x0
  int v28; // w0
  int v29; // w22
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 v33; // x0
  __int64 v34; // x0
  __int64 v35; // x0
  __int64 v36; // x0
  __int64 v37; // x0
  __int64 v38; // x0
  __int64 v39; // x0
  __int64 v40; // x0
  __int64 v41; // x0
  __int64 v42; // x0
  __int64 v43; // x0
  __int64 v44; // x0
  __int64 v45; // x0
  __int64 v46; // x0
  __int64 v47; // x0
  __int64 v48; // x0
  __int64 v49; // x0
  __int64 v50; // x25
  __int64 v51; // x21
  __int64 v52; // x22
  __int64 v53; // x0
  int v54; // w8
  __int64 v55; // x0
  unsigned int v56; // w8
  __int64 v57; // x0
  unsigned int v58; // w8
  __int64 v59; // x0
  unsigned int v60; // w8
  __int64 v61; // x0
  int v62; // w8
  __int64 v63; // x0
  __int64 v64; // x0
  __int64 v65; // x9
  _QWORD *v66; // x10
  __int64 v67; // x0
  __int64 v68; // x8
  _QWORD *v69; // x9
  __int64 v70; // x10
  __int64 v71; // x0
  __int64 v72; // x8
  _QWORD *v73; // x9
  __int64 v74; // x10
  __int64 v75; // x0
  __int64 v76; // x8
  _QWORD *v77; // x9
  __int64 v78; // x10
  __int64 v79; // x0
  __int64 v80; // [xsp+8h] [xbp-78h] BYREF
  __int64 v81; // [xsp+10h] [xbp-70h] BYREF
  __int64 v82; // [xsp+18h] [xbp-68h] BYREF

  if ( (byte_900072C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE55B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F4D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F4D0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F510);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AE68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE3F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D54508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D523E8);
    byte_900072C = 1;
  }
  v81 = 0;
  v82 = 0;
  v80 = 0;
  ServerBaseData__Init(self, 0);
  if ( *((_QWORD *)self + 2) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE3F8);
    System_Collections_Generic_List_object____ctor(v3, qword_8D0F4D0);
    *((_QWORD *)self + 2) = v3;
  }
  if ( *((_QWORD *)self + 3) == 0 )
  {
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE3F8);
    System_Collections_Generic_List_object____ctor(v4, qword_8D0F4D0);
    *((_QWORD *)self + 3) = v4;
  }
  v5 = *((_QWORD *)self + 4);
  if ( v5 == 0 )
  {
    v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE55B8);
    ((void (*)(void))DataModule_ChestSlotUnlockData___ctor)();
    *((_QWORD *)self + 4) = v5;
    if ( v5 == 0 )
      goto LABEL_104;
  }
  if ( *(_QWORD *)(v5 + 16) == 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
    System_Collections_Generic_Dictionary_int__int____ctor(v6, qword_8CFC8D0);
    *(_QWORD *)(v5 + 16) = v6;
  }
  if ( *((_QWORD *)self + 5) == 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE3F8);
    System_Collections_Generic_List_object____ctor(v7, qword_8D0F4D0);
    *((_QWORD *)self + 5) = v7;
  }
  v8 = *((_QWORD *)self + 2);
  if ( v8 == 0 )
    goto LABEL_104;
  v9 = *(int *)(v8 + 24);
  if ( (int)v9 >= 1 )
  {
    v10 = 0;
    while ( 1 )
    {
      if ( System_Collections_Generic_List_object___get_Item(v8, v10, qword_8D0F510) != 0 )
      {
        v11 = *((_QWORD *)self + 2);
        if ( v11 == 0 )
          goto LABEL_104;
        Item = System_Collections_Generic_List_object___get_Item(v11, v10, qword_8D0F510);
        if ( Item == 0 )
          goto LABEL_104;
        if ( *(_QWORD *)(Item + 152) == 0 )
        {
          v13 = *((_QWORD *)self + 2);
          if ( v13 == 0 )
            goto LABEL_104;
          v14 = System_Collections_Generic_List_object___get_Item(v13, v10, qword_8D0F510);
          if ( v14 == 0 )
            goto LABEL_104;
          LODWORD(v82) = *(_DWORD *)(v14 + 140);
          HIDWORD(v82) = v82;
          Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
          if ( Instance == nullptr )
            goto LABEL_104;
          v16 = Instance[5];
          if ( v16 == 0 )
            goto LABEL_104;
          v17 = *((_QWORD *)self + 2);
          if ( v17 == 0 )
            goto LABEL_104;
          v18 = *(_QWORD *)(v16 + 216);
          v19 = System_Collections_Generic_List_object___get_Item(v17, v10, qword_8D0F510);
          if ( v19 == 0 )
            goto LABEL_104;
          if ( v18 == 0 )
            goto LABEL_104;
          v20 = System_Collections_Generic_List_object___get_Item(v18, *(unsigned int *)(v19 + 120), qword_8D0AE68);
          if ( *((_QWORD *)self + 2) == 0 )
            goto LABEL_104;
          v21 = v20;
          v22 = System_Collections_Generic_List_object___get_Item(*((_QWORD *)self + 2), v10, qword_8D0F510);
          if ( v22 == 0 )
            goto LABEL_104;
          v23 = *(_QWORD *)(v22 + 112);
          v24 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
          if ( v24 == nullptr )
            goto LABEL_104;
          v25 = v24[5];
          if ( v25 == 0 )
            goto LABEL_104;
          v26 = *(_QWORD *)(v25 + 184);
          if ( v26 == 0 )
            goto LABEL_104;
          v27 = System_Collections_Generic_Dictionary_object__object___get_Item(v26, v23, qword_8CFE650);
          if ( v27 == 0 )
            goto LABEL_104;
          v28 = ToolModule_StringTool__ToInt(*(_QWORD *)(v27 + 112), 0);
          if ( v21 == 0 )
            goto LABEL_104;
          v29 = v28;
          v30 = *(_QWORD *)(v21 + 64);
          if ( v30 == 0 )
            goto LABEL_104;
          v31 = System_String__Split(v30, 59, 0, 0);
          if ( v31 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v31 + 24) == 0 )
            goto LABEL_105;
          v32 = *(_QWORD *)(v31 + 32);
          if ( v32 == 0 )
            goto LABEL_104;
          v33 = System_String__Split(v32, 44, 0, 0);
          if ( v33 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v33 + 24) == 0 )
            goto LABEL_105;
          HIDWORD(v81) = ToolModule_StringTool__ToInt(*(_QWORD *)(v33 + 32), 0) * v29;
          v34 = *(_QWORD *)(v21 + 64);
          if ( v34 == 0 )
            goto LABEL_104;
          v35 = System_String__Split(v34, 59, 0, 0);
          if ( v35 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v35 + 24) == 0 )
            goto LABEL_105;
          v36 = *(_QWORD *)(v35 + 32);
          if ( v36 == 0 )
            goto LABEL_104;
          v37 = System_String__Split(v36, 44, 0, 0);
          if ( v37 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v37 + 24) <= 1u )
            goto LABEL_105;
          LODWORD(v81) = ToolModule_StringTool__ToInt(*(_QWORD *)(v37 + 40), 0) * v29;
          v38 = *(_QWORD *)(v21 + 64);
          if ( v38 == 0 )
            goto LABEL_104;
          v39 = System_String__Split(v38, 59, 0, 0);
          if ( v39 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v39 + 24) == 0 )
            goto LABEL_105;
          v40 = *(_QWORD *)(v39 + 32);
          if ( v40 == 0 )
            goto LABEL_104;
          v41 = System_String__Split(v40, 44, 0, 0);
          if ( v41 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v41 + 24) <= 2u )
            goto LABEL_105;
          HIDWORD(v80) = ToolModule_StringTool__ToInt(*(_QWORD *)(v41 + 48), 0) * v29;
          v42 = *(_QWORD *)(v21 + 64);
          if ( v42 == 0 )
            goto LABEL_104;
          v43 = System_String__Split(v42, 59, 0, 0);
          if ( v43 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v43 + 24) == 0 )
            goto LABEL_105;
          v44 = *(_QWORD *)(v43 + 32);
          if ( v44 == 0 )
            goto LABEL_104;
          v45 = System_String__Split(v44, 44, 0, 0);
          if ( v45 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v45 + 24) <= 3u )
            goto LABEL_105;
          LODWORD(v80) = ToolModule_StringTool__ToInt(*(_QWORD *)(v45 + 56), 0) * v29;
          v46 = *(_QWORD *)(v21 + 64);
          if ( v46 == 0 )
            goto LABEL_104;
          v47 = System_String__Split(v46, 59, 0, 0);
          if ( v47 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v47 + 24) == 0 )
            goto LABEL_105;
          v48 = *(_QWORD *)(v47 + 32);
          if ( v48 == 0 )
            goto LABEL_104;
          v49 = System_String__Split(v48, 44, 0, 0);
          if ( v49 == 0 )
            goto LABEL_104;
          if ( *(_DWORD *)(v49 + 24) <= 4u )
            goto LABEL_105;
          if ( *((_QWORD *)self + 2) == 0 )
            goto LABEL_104;
          v50 = *(_QWORD *)(v49 + 64);
          v51 = System_Collections_Generic_List_object___get_Item(*((_QWORD *)self + 2), v10, qword_8D0F510);
          v52 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 13);
          v53 = System_Int32__ToString((char *)&v81 + 4, 0);
          if ( v52 == 0 )
            goto LABEL_104;
          v54 = *(_DWORD *)(v52 + 24);
          if ( v54 == 0 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 32) = v53;
          if ( v54 == 1 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 40) = qword_8D523E8;
          v55 = System_Int32__ToString(&v81, 0);
          v56 = *(_DWORD *)(v52 + 24);
          if ( v56 <= 2 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 48) = v55;
          if ( v56 == 3 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 56) = qword_8D523E8;
          v57 = System_Int32__ToString((char *)&v80 + 4, 0);
          v58 = *(_DWORD *)(v52 + 24);
          if ( v58 <= 4 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 64) = v57;
          if ( v58 == 5 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 72) = qword_8D523E8;
          v59 = System_Int32__ToString(&v80, 0);
          v60 = *(_DWORD *)(v52 + 24);
          if ( v60 <= 6 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 80) = v59;
          if ( v60 == 7 )
            goto LABEL_105;
          *(_QWORD *)(v52 + 88) = qword_8D523E8;
          if ( v60 <= 8
            || (*(_QWORD *)(v52 + 96) = v50, v60 == 9)
            || (*(_QWORD *)(v52 + 104) = qword_8D54508,
                v61 = System_Int32__ToString((char *)&v82 + 4, 0),
                (unsigned int)(v62 = *(_DWORD *)(v52 + 24)) <= 0xA)
            || (*(_QWORD *)(v52 + 112) = v61, v62 == 11)
            || (*(_QWORD *)(v52 + 120) = qword_8D523E8,
                v63 = System_Int32__ToString(&v82, 0),
                *(_DWORD *)(v52 + 24) <= 0xCu) )
          {
LABEL_105:
            v79 = ((__int64 (*)(void))unk_3C3D4D4)();
            DataModule_ChestSlotUnlockData___ctor(v79);
            return;
          }
          *(_QWORD *)(v52 + 128) = v63;
          v64 = System_String__Concat(v52, 0);
          if ( v51 == 0 )
            goto LABEL_104;
          *(_QWORD *)(v51 + 152) = v64;
        }
      }
      v8 = *((_QWORD *)self + 2);
      if ( v8 == 0 )
        goto LABEL_104;
      if ( (signed int)++v10 >= *(_DWORD *)(v8 + 24) )
        return;
    }
  }
  v65 = *(_QWORD *)(v8 + 16);
  v66 = off_8D0F4D8;
  ++*(_DWORD *)(v8 + 28);
  if ( v65 == 0 )
    goto LABEL_104;
  if ( (unsigned int)v9 >= *(_DWORD *)(v65 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v8, 0, *(_QWORD *)(*(_QWORD *)(v66[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v8 + 24) = v9 + 1;
    *(_QWORD *)(v65 + 8 * v9 + 32) = 0;
  }
  v67 = *((_QWORD *)self + 2);
  if ( v67 == 0 )
    goto LABEL_104;
  v68 = *(_QWORD *)(v67 + 16);
  v69 = off_8D0F4D8;
  ++*(_DWORD *)(v67 + 28);
  if ( v68 == 0 )
    goto LABEL_104;
  v70 = *(int *)(v67 + 24);
  if ( (unsigned int)v70 >= *(_DWORD *)(v68 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v67, 0, *(_QWORD *)(*(_QWORD *)(v69[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v67 + 24) = v70 + 1;
    *(_QWORD *)(v68 + 8 * v70 + 32) = 0;
  }
  v71 = *((_QWORD *)self + 2);
  if ( v71 == 0 )
    goto LABEL_104;
  v72 = *(_QWORD *)(v71 + 16);
  v73 = off_8D0F4D8;
  ++*(_DWORD *)(v71 + 28);
  if ( v72 == 0 )
    goto LABEL_104;
  v74 = *(int *)(v71 + 24);
  if ( (unsigned int)v74 >= *(_DWORD *)(v72 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v71, 0, *(_QWORD *)(*(_QWORD *)(v73[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v71 + 24) = v74 + 1;
    *(_QWORD *)(v72 + 8 * v74 + 32) = 0;
  }
  v75 = *((_QWORD *)self + 2);
  if ( v75 == 0 || (v76 = *(_QWORD *)(v75 + 16), v77 = off_8D0F4D8, ++*(_DWORD *)(v75 + 28), v76 == 0) )
LABEL_104:
    il2cpp_codegen_raise_null_reference_exception();
  v78 = *(int *)(v75 + 24);
  if ( (unsigned int)v78 >= *(_DWORD *)(v76 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v75, 0, *(_QWORD *)(*(_QWORD *)(v77[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v75 + 24) = v78 + 1;
    *(_QWORD *)(v76 + 8 * v78 + 32) = 0;
  }
}
