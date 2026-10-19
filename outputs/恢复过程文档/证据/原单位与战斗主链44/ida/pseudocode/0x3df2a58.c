__int64 __fastcall GameModule_BattleGameSceneManager__GetRandomNumberRole(_QWORD *a1, char a2, int a3, char a4)
{
  __int64 v8; // x19
  __int64 v9; // x24
  __int64 v10; // x22
  __int64 *v11; // x8
  __int64 v12; // x24
  __int64 v13; // x24
  __int64 v14; // x20
  int v15; // w24
  __int64 Item; // x0
  int v17; // w8
  unsigned int v18; // w20
  __int64 v19; // x0
  __int64 v20; // x8
  _QWORD *v21; // x9
  __int64 v22; // x10
  int v23; // w8
  unsigned int v24; // w21
  __int64 v25; // x0
  __int64 v26; // x8
  _QWORD *v27; // x9
  __int64 v28; // x10
  unsigned int v29; // w21
  __int64 v30; // x0
  __int64 v31; // x8
  _QWORD *v32; // x9
  __int64 v33; // x10
  int v34; // w26
  unsigned int v35; // w0
  __int64 v36; // x0
  __int64 v37; // x24
  __int64 v38; // x8
  _QWORD *v39; // x9
  __int64 v40; // x10
  unsigned int v41; // w24
  __int64 v42; // x0
  __int64 v43; // x8
  _QWORD *v44; // x9
  __int64 v45; // x10
  unsigned int v46; // w24
  __int64 v47; // x0
  __int64 v48; // x8
  _QWORD *v49; // x9
  __int64 v50; // x10
  int v51; // w8
  int v52; // w9
  int v53; // w22
  unsigned int v54; // w21
  __int64 v55; // x0
  __int64 v56; // x8
  _QWORD *v57; // x9
  __int64 v58; // x10
  unsigned int v59; // w21
  __int64 v60; // x0
  __int64 v61; // x8
  _QWORD *v62; // x9
  __int64 v63; // x10

  if ( (byte_8FFD7A1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0A588);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0A590);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0A580);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08FB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DD70);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D08FE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0A598);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08FE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD630);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDFF0);
    byte_8FFD7A1 = 1;
  }
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD630);
  System_Collections_Generic_List_object____ctor(v8, qword_8D0A580);
  if ( (a2 & 1) != 0 )
  {
    v9 = a1[25];
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFF0);
    sub_574EE80(v10, v9, qword_8D0DD70);
    v11 = a1 + 28;
  }
  else
  {
    v12 = a1[24];
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFF0);
    sub_574EE80(v10, v12, qword_8D0DD70);
    v11 = a1 + 29;
  }
  v13 = *v11;
  v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD228);
  sub_574EE80(v14, v13, qword_8D08FB8);
  if ( v10 == 0 )
    goto LABEL_92;
  v15 = *(_DWORD *)(v10 + 24) - 1;
  if ( v15 >= 0 )
  {
    while ( 1 )
    {
      Item = System_Collections_Generic_List_object___get_Item(v10, (unsigned int)v15, qword_8D0DDC8);
      if ( Item == 0 )
        break;
      if ( *(_BYTE *)(Item + 396) != 0 )
        System_Collections_Generic_List_object___RemoveAt(v10, (unsigned int)v15, qword_8D0DDB0);
      if ( --v15 < 0 )
        goto LABEL_12;
    }
LABEL_92:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_12:
  if ( (a4 & 1) != 0 )
  {
    v17 = *(_DWORD *)(v10 + 24);
    if ( v17 >= a3 )
    {
      if ( a3 >= 1 )
      {
        v34 = 0;
        while ( 1 )
        {
          v35 = UnityEngine_Random__Range(0);
          v36 = System_Collections_Generic_List_object___get_Item(v10, v35, qword_8D0DDC8);
          if ( v8 == 0 )
            goto LABEL_92;
          v37 = v36;
          if ( (System_Collections_Generic_List_object___Contains(v8, v36, qword_8D0A590) & 1) == 0 )
          {
            System_Collections_Generic_List_object___Remove(v10, v37, qword_8D0DDA8);
            v38 = *(_QWORD *)(v8 + 16);
            v39 = off_8D0A588;
            ++*(_DWORD *)(v8 + 28);
            if ( v38 == 0 )
              goto LABEL_92;
            v40 = *(int *)(v8 + 24);
            if ( (unsigned int)v40 >= *(_DWORD *)(v38 + 24) )
            {
              System_Collections_Generic_List_object___AddWithResize(
                v8,
                v37,
                *(_QWORD *)(*(_QWORD *)(v39[4] + 192LL) + 112LL));
            }
            else
            {
              *(_DWORD *)(v8 + 24) = v40 + 1;
              *(_QWORD *)(v38 + 8 * v40 + 32) = v37;
            }
            if ( ++v34 == a3 )
              goto LABEL_70;
          }
        }
      }
    }
    else if ( v17 >= 1 )
    {
      v18 = 0;
      while ( 1 )
      {
        v19 = System_Collections_Generic_List_object___get_Item(v10, v18, qword_8D0DDC8);
        if ( v8 == 0 )
          break;
        v20 = *(_QWORD *)(v8 + 16);
        v21 = off_8D0A588;
        ++*(_DWORD *)(v8 + 28);
        if ( v20 == 0 )
          break;
        v22 = *(int *)(v8 + 24);
        if ( (unsigned int)v22 >= *(_DWORD *)(v20 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v8,
            v19,
            *(_QWORD *)(*(_QWORD *)(v21[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v8 + 24) = v22 + 1;
          *(_QWORD *)(v20 + 8 * v22 + 32) = v19;
        }
        if ( (signed int)++v18 >= *(_DWORD *)(v10 + 24) )
          return v8;
      }
      goto LABEL_92;
    }
    return v8;
  }
  if ( v14 == 0 )
    goto LABEL_92;
  v23 = *(_DWORD *)(v10 + 24);
  if ( v23 + *(_DWORD *)(v14 + 24) >= a3 )
  {
    if ( v23 <= a3 )
    {
      if ( v23 >= 1 )
      {
        v46 = 0;
        do
        {
          v47 = System_Collections_Generic_List_object___get_Item(v10, v46, qword_8D0DDC8);
          if ( v8 == 0 )
            goto LABEL_92;
          v48 = *(_QWORD *)(v8 + 16);
          v49 = off_8D0A588;
          ++*(_DWORD *)(v8 + 28);
          if ( v48 == 0 )
            goto LABEL_92;
          v50 = *(int *)(v8 + 24);
          if ( (unsigned int)v50 >= *(_DWORD *)(v48 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v8,
              v47,
              *(_QWORD *)(*(_QWORD *)(v49[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v8 + 24) = v50 + 1;
            *(_QWORD *)(v48 + 8 * v50 + 32) = v47;
          }
          ++v46;
        }
        while ( (signed int)v46 < *(_DWORD *)(v10 + 24) );
LABEL_70:
        if ( (a4 & 1) != 0 )
          return v8;
        goto LABEL_73;
      }
    }
    else if ( a3 >= 1 )
    {
      v41 = 0;
      while ( 1 )
      {
        v42 = System_Collections_Generic_List_object___get_Item(v10, v41, qword_8D0DDC8);
        if ( v8 == 0 )
          goto LABEL_92;
        v43 = *(_QWORD *)(v8 + 16);
        v44 = off_8D0A588;
        ++*(_DWORD *)(v8 + 28);
        if ( v43 == 0 )
          goto LABEL_92;
        v45 = *(int *)(v8 + 24);
        if ( (unsigned int)v45 >= *(_DWORD *)(v43 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v8,
            v42,
            *(_QWORD *)(*(_QWORD *)(v44[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v8 + 24) = v45 + 1;
          *(_QWORD *)(v43 + 8 * v45 + 32) = v42;
        }
        if ( a3 == ++v41 )
          goto LABEL_70;
      }
    }
    if ( v8 == 0 )
      goto LABEL_92;
LABEL_73:
    v51 = *(_DWORD *)(v8 + 24);
    if ( v51 < a3 )
    {
      if ( v14 == 0 )
        goto LABEL_92;
      v52 = *(_DWORD *)(v14 + 24);
      v53 = a3 - v51;
      if ( a3 - v51 >= v52 )
      {
        if ( v52 >= 1 )
        {
          v59 = 0;
          while ( 1 )
          {
            v60 = System_Collections_Generic_List_object___get_Item(v14, v59, qword_8D08FE8);
            v61 = *(_QWORD *)(v8 + 16);
            v62 = off_8D0A588;
            ++*(_DWORD *)(v8 + 28);
            if ( v61 == 0 )
              break;
            v63 = *(int *)(v8 + 24);
            if ( (unsigned int)v63 >= *(_DWORD *)(v61 + 24) )
            {
              System_Collections_Generic_List_object___AddWithResize(
                v8,
                v60,
                *(_QWORD *)(*(_QWORD *)(v62[4] + 192LL) + 112LL));
            }
            else
            {
              *(_DWORD *)(v8 + 24) = v63 + 1;
              *(_QWORD *)(v61 + 8 * v63 + 32) = v60;
            }
            if ( (signed int)++v59 >= *(_DWORD *)(v14 + 24) )
              return v8;
          }
          goto LABEL_92;
        }
      }
      else if ( v53 >= 1 )
      {
        v54 = 0;
        while ( 1 )
        {
          v55 = System_Collections_Generic_List_object___get_Item(v14, v54, qword_8D08FE8);
          v56 = *(_QWORD *)(v8 + 16);
          v57 = off_8D0A588;
          ++*(_DWORD *)(v8 + 28);
          if ( v56 == 0 )
            break;
          v58 = *(int *)(v8 + 24);
          if ( (unsigned int)v58 >= *(_DWORD *)(v56 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v8,
              v55,
              *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v8 + 24) = v58 + 1;
            *(_QWORD *)(v56 + 8 * v58 + 32) = v55;
          }
          if ( v53 == ++v54 )
            return v8;
        }
        goto LABEL_92;
      }
    }
    return v8;
  }
  if ( v23 >= 1 )
  {
    v24 = 0;
    do
    {
      v25 = System_Collections_Generic_List_object___get_Item(v10, v24, qword_8D0DDC8);
      if ( v8 == 0 )
        goto LABEL_92;
      v26 = *(_QWORD *)(v8 + 16);
      v27 = off_8D0A588;
      ++*(_DWORD *)(v8 + 28);
      if ( v26 == 0 )
        goto LABEL_92;
      v28 = *(int *)(v8 + 24);
      if ( (unsigned int)v28 >= *(_DWORD *)(v26 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v8,
          v25,
          *(_QWORD *)(*(_QWORD *)(v27[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v8 + 24) = v28 + 1;
        *(_QWORD *)(v26 + 8 * v28 + 32) = v25;
      }
    }
    while ( (signed int)++v24 < *(_DWORD *)(v10 + 24) );
  }
  if ( *(int *)(v14 + 24) >= 1 )
  {
    v29 = 0;
    while ( 1 )
    {
      v30 = System_Collections_Generic_List_object___get_Item(v14, v29, qword_8D08FE8);
      if ( v8 == 0 )
        break;
      v31 = *(_QWORD *)(v8 + 16);
      v32 = off_8D0A588;
      ++*(_DWORD *)(v8 + 28);
      if ( v31 == 0 )
        break;
      v33 = *(int *)(v8 + 24);
      if ( (unsigned int)v33 >= *(_DWORD *)(v31 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v8,
          v30,
          *(_QWORD *)(*(_QWORD *)(v32[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v8 + 24) = v33 + 1;
        *(_QWORD *)(v31 + 8 * v33 + 32) = v30;
      }
      if ( (signed int)++v29 >= *(_DWORD *)(v14 + 24) )
        return v8;
    }
    goto LABEL_92;
  }
  return v8;
}
