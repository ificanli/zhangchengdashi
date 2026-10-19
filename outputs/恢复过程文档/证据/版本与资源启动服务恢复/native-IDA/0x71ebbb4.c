__int64 __fastcall GameFramework_VersionMondule__Init_d__9__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  __int64 Instance; // x20
  __int64 v4; // x0
  __int64 result; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  int v8; // w8
  __int64 v9; // x0
  __int64 v10; // x20
  __int64 GameInfo; // x0
  __int64 v12; // x21
  __int64 MineGameName; // x0
  __int64 v14; // x21
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x22
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x20
  __int64 v21; // x20
  __int64 v22; // x0
  __int64 v23; // x21
  __int64 v24; // x0
  __int64 v25; // x22
  __int64 v26; // x0
  __int64 v27; // x20
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 v31; // x21
  __int64 error; // x0
  __int64 v33; // x0
  __int64 v34; // x22
  _QWORD **v35; // x0
  __int64 v36; // x19
  __int64 v37; // x0
  _QWORD **v38; // x0
  __int64 v39; // x19
  __int64 v40; // x0
  __int64 Item; // x0
  __int64 v42; // x0
  __int64 v43; // x19
  __int64 ABFileStreaming; // x0
  int v45; // w9
  __int64 v46; // x21
  __int64 streamingAssetsPath; // x0
  __int64 v48; // x21
  __int64 v49; // x0
  __int64 v50; // x22
  _QWORD *v51; // x0
  __int64 v52; // x20
  __int64 v53; // x21
  __int64 v54; // x0
  __int64 v55; // x22
  __int64 v56; // x0
  __int64 v57; // x20
  __int64 v58; // x21
  __int64 v59; // x0
  __int64 v60; // x0
  __int64 downloadHandler; // x0
  void *data; // x21
  void *v63; // x0
  __int64 v64; // x21
  __int64 v65; // x0
  __int64 v66; // x22
  char IsNullOrEmpty; // w22
  __int64 v68; // x0
  __int64 v69; // x21
  _QWORD *v70; // x0
  __int64 v71; // x21
  __int64 v72; // x0
  __int64 v73; // x22
  __int64 v74; // x0
  __int64 v75; // x21
  _QWORD *v76; // x0
  _QWORD *Module_object; // x0
  __int64 v78; // x23
  __int64 v79; // x24
  unsigned int v80; // w25
  _QWORD *v81; // x21
  __int64 v82; // x22
  __int64 v83; // x0
  __int64 v84; // x8
  _QWORD *v85; // x0
  __int64 v86; // x0
  __int64 v87; // x21
  __int64 v88; // x8
  __int64 v89; // x0
  __int64 v90; // x20
  _QWORD *v91; // x0
  __int64 v92; // x21
  __int64 v93; // x22
  __int64 v94; // x0
  __int64 v95; // x23
  __int64 v96; // x0
  __int64 v97; // x0
  _QWORD v98[2]; // [xsp+8h] [xbp-68h] BYREF
  int v99; // [xsp+18h] [xbp-58h]

  if ( (byte_90096EC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE978);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE6B50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7938);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9C08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF0A40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF480);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF660);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D865F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D644E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87088);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86788);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86608);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D644F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D82A58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87038);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D644E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D644F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D890E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52E88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D884E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D62008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7BA78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89000);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86600);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7BA70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88FF8);
    byte_90096EC = 1;
  }
  v2 = *(_QWORD *)(a1 + 32);
  switch ( *(_DWORD *)(a1 + 16) )
  {
    case 0:
      *(_DWORD *)(a1 + 16) = -1;
      Instance = UpdateManager__get_Instance(0);
      if ( *((_DWORD *)off_8CE9C08 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE9C08);
      v4 = GameFramework_KeywordBuild___ye__a(0);
      if ( Instance == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 24) = UnityEngine_MonoBehaviour__StartCoroutine(Instance, v4, 0);
      *(_DWORD *)(a1 + 16) = 1;
      return 1;
    case 1:
      *(_DWORD *)(a1 + 16) = -1;
      v6 = UpdateManager__get_Instance(0);
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v7 = GameFramework_AppSetting______lY(0);
      if ( v6 == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 24) = UnityEngine_MonoBehaviour__StartCoroutine(v6, v7, 0);
      v8 = 2;
      goto LABEL_208;
    case 2:
      *(_DWORD *)(a1 + 16) = -1;
      v9 = UpdateManager__get_Instance(0);
      if ( **((_QWORD **)off_8CECCD8 + 23) == 0 )
        goto LABEL_210;
      v10 = v9;
      GameInfo = DBTSDK_SDKToolManager__AwaitLoadGameInfo(**((_QWORD **)off_8CECCD8 + 23), 0);
      if ( v10 == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 24) = UnityEngine_MonoBehaviour__StartCoroutine(v10, GameInfo, 0);
      v8 = 3;
      goto LABEL_208;
    case 3:
      *(_DWORD *)(a1 + 16) = -1;
      v12 = **((_QWORD **)off_8CECCD8 + 23);
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      MineGameName = GameFramework_AppSetting__get_MineGameName(0);
      if ( v12 == 0 )
        goto LABEL_210;
      *(_DWORD *)(a1 + 40) = DBTSDK_SDKToolManager__GetGameAssetType(v12, MineGameName, 0);
      v14 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v98[0] = qword_8CE7938;
      v98[1] = -1;
      v99 = *(_DWORD *)(a1 + 40);
      v15 = System_Enum__ToString(v98, 0);
      v16 = sub_74FE7A4(qword_8D7BA70, v15, 0);
      if ( v14 == 0 )
        goto LABEL_210;
      v17 = v16;
      if ( v16 != 0 )
      {
        v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
        if ( v18 == 0 )
          goto LABEL_212;
      }
      if ( *(_DWORD *)(v14 + 24) == 0 )
        goto LABEL_211;
      *(_QWORD *)(v14 + 32) = v17;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__d_e___(v14, 0);
      if ( *(_DWORD *)(a1 + 40) != 0 )
      {
        v19 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v19 != 0 )
        {
          v20 = v19;
          if ( qword_8D890E0 == 0
            || (v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                        qword_8D890E0,
                        *(_QWORD *)(*(_QWORD *)v19 + 64LL))) != 0 )
          {
            if ( *(_DWORD *)(v20 + 24) != 0 )
            {
              *(_QWORD *)(v20 + 32) = qword_8D890E0;
              if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE5250);
              GameFramework_CLog__d_e___(v20, 0);
              if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE40C8);
              *(_QWORD *)(a1 + 48) = GameFramework_AppSetting__get_MineGameName(0);
              v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF660);
              UnityEngine_WaitForSeconds___ctor(v21, 0, 0.5);
              *(_QWORD *)(a1 + 24) = v21;
              v8 = 4;
              goto LABEL_208;
            }
            goto LABEL_211;
          }
LABEL_212:
          v97 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v18);
          ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v97, 0);
          JUMPOUT(0x71ECC4C);
        }
LABEL_210:
        il2cpp_codegen_raise_null_reference_exception();
      }
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      if ( byte_900876D == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
        byte_900876D = 1;
      }
      v85 = off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v85 = off_8CE40C8;
      }
      if ( *(_BYTE *)(v85[23] + 56LL) != 0 )
      {
        if ( v2 == 0 )
          goto LABEL_210;
        *(_BYTE *)(v2 + 16) = 1;
        v86 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v86 == 0 )
          goto LABEL_210;
        v87 = v86;
        if ( qword_8D86608 != 0 )
        {
          v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                  qword_8D86608,
                  *(_QWORD *)(*(_QWORD *)v86 + 64LL));
          if ( v18 == 0 )
            goto LABEL_212;
        }
        if ( *(_DWORD *)(v87 + 24) != 0 )
        {
          *(_QWORD *)(v87 + 32) = qword_8D86608;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__d_e___(v87, 0);
          v88 = *(_QWORD *)(v2 + 24);
          if ( v88 != 0 )
            (*(void (__fastcall **)(_QWORD, _QWORD))(v88 + 24))(*(_QWORD *)(v88 + 64), *(_QWORD *)(v88 + 40));
          *(_QWORD *)(a1 + 24) = 0;
          v8 = 7;
          goto LABEL_208;
        }
        goto LABEL_211;
      }
      v8 = 6;
      *(_QWORD *)(a1 + 24) = 0;
      goto LABEL_208;
    case 4:
      *(_DWORD *)(a1 + 16) = -1;
      v22 = **((_QWORD **)off_8CECCD8 + 23);
      if ( v22 == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 56) = DBTSDK_SDKToolManager__GetGoogleAssetPath(v22, *(_QWORD *)(a1 + 48), 0);
      v23 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v24 = sub_74FE7A4(qword_8D62008, *(_QWORD *)(a1 + 56), 0);
      if ( v23 == 0 )
        goto LABEL_210;
      v25 = v24;
      if ( v24 != 0 )
      {
        v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v24, *(_QWORD *)(*(_QWORD *)v23 + 64LL));
        if ( v18 == 0 )
          goto LABEL_212;
      }
      if ( *(_DWORD *)(v23 + 24) == 0 )
        goto LABEL_211;
      *(_QWORD *)(v23 + 32) = v25;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__d_e___(v23, 0);
      if ( (System_String__IsNullOrEmpty(*(_QWORD *)(a1 + 56), 0) & 1) != 0 )
      {
        v26 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v26 == 0 )
          goto LABEL_210;
        v27 = v26;
        if ( qword_8D89000 != 0 )
        {
          v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                  qword_8D89000,
                  *(_QWORD *)(*(_QWORD *)v26 + 64LL));
          if ( v18 == 0 )
            goto LABEL_212;
        }
        if ( *(_DWORD *)(v27 + 24) == 0 )
          goto LABEL_211;
        *(_QWORD *)(v27 + 32) = qword_8D89000;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v27, 0);
        v28 = **((_QWORD **)off_8CECCD8 + 23);
        if ( v28 == 0 )
          goto LABEL_210;
        DBTSDK_SDKToolManager__ShowToast(v28, qword_8D884E0, 0);
LABEL_191:
        *(_QWORD *)(a1 + 48) = 0;
        *(_QWORD *)(a1 + 56) = 0;
        return 0;
      }
      v45 = *(_DWORD *)(a1 + 40);
      *(_QWORD *)(a1 + 64) = **((_QWORD **)off_8CEDAE8 + 23);
      if ( v45 != 1 )
      {
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
        if ( byte_900876D == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
          byte_900876D = 1;
        }
        v91 = off_8CE40C8;
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
          v91 = off_8CE40C8;
        }
        if ( *(_BYTE *)(v91[23] + 56LL) == 0 )
        {
          v92 = sub_74FE7A4(*(_QWORD *)(a1 + 56), qword_8D52E88, 0);
          v93 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
          v94 = sub_74FE7A4(qword_8D87088, v92, 0);
          if ( v93 == 0 )
            goto LABEL_210;
          v95 = v94;
          if ( v94 != 0 )
          {
            v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v94, *(_QWORD *)(*(_QWORD *)v93 + 64LL));
            if ( v18 == 0 )
              goto LABEL_212;
          }
          if ( *(_DWORD *)(v93 + 24) == 0 )
            goto LABEL_211;
          *(_QWORD *)(v93 + 32) = v95;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__d_e___(v93, 0);
          v96 = GameFramework_Tools_FileManager__get_Instance(0);
          if ( v96 == 0 )
            goto LABEL_210;
          *(_QWORD *)(a1 + 64) = GameFramework_Tools_FileManager__ReadFilByJaTng(v96, v92, 0);
        }
        goto LABEL_109;
      }
      v46 = *(_QWORD *)(a1 + 56);
      if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40D8);
      streamingAssetsPath = UnityEngine_Application__get_streamingAssetsPath(0);
      if ( v46 == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 56) = sub_750BEDC(v46, qword_8D7BA78, streamingAssetsPath, 0);
      v48 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v49 = sub_74FE7A4(qword_8D644E0, *(_QWORD *)(a1 + 56), 0);
      if ( v48 == 0 )
        goto LABEL_210;
      v50 = v49;
      if ( v49 != 0 )
      {
        v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v49, *(_QWORD *)(*(_QWORD *)v48 + 64LL));
        if ( v18 == 0 )
          goto LABEL_212;
      }
      if ( *(_DWORD *)(v48 + 24) == 0 )
        goto LABEL_211;
      *(_QWORD *)(v48 + 32) = v50;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__Log(v48, 0);
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      if ( byte_900876D == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
        byte_900876D = 1;
      }
      v51 = off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v51 = off_8CE40C8;
      }
      if ( *(_BYTE *)(v51[23] + 56LL) != 0 )
      {
LABEL_109:
        v64 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        v65 = sub_74FE7A4(qword_8D644F8, *(_QWORD *)(a1 + 64), 0);
        if ( v64 == 0 )
          goto LABEL_210;
        v66 = v65;
        if ( v65 != 0 )
        {
          v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v65, *(_QWORD *)(*(_QWORD *)v64 + 64LL));
          if ( v18 == 0 )
            goto LABEL_212;
        }
        if ( *(_DWORD *)(v64 + 24) == 0 )
          goto LABEL_211;
        *(_QWORD *)(v64 + 32) = v66;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Log(v64, 0);
        IsNullOrEmpty = System_String__IsNullOrEmpty(*(_QWORD *)(a1 + 64), 0);
        v68 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v68 == 0 )
          goto LABEL_210;
        v69 = v68;
        if ( (IsNullOrEmpty & 1) != 0 )
        {
          if ( qword_8D644E8 != 0 )
          {
            v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                    qword_8D644E8,
                    *(_QWORD *)(*(_QWORD *)v68 + 64LL));
            if ( v18 == 0 )
              goto LABEL_212;
          }
          if ( *(_DWORD *)(v69 + 24) == 0 )
            goto LABEL_211;
          *(_QWORD *)(v69 + 32) = qword_8D644E8;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__Log(v69, 0);
          if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE40C8);
          if ( byte_900876D == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
            byte_900876D = 1;
          }
          v70 = off_8CE40C8;
          if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE40C8);
            v70 = off_8CE40C8;
          }
          if ( *(_BYTE *)(v70[23] + 56LL) == 0 )
          {
            v89 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
            if ( v89 == 0 )
              goto LABEL_210;
            v90 = v89;
            if ( qword_8D88FF8 != 0 )
            {
              v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                      qword_8D88FF8,
                      *(_QWORD *)(*(_QWORD *)v89 + 64LL));
              if ( v18 == 0 )
                goto LABEL_212;
            }
            if ( *(_DWORD *)(v90 + 24) == 0 )
              goto LABEL_211;
            *(_QWORD *)(v90 + 32) = qword_8D88FF8;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Error(v90, 0);
            goto LABEL_190;
          }
          if ( v2 == 0 )
            goto LABEL_210;
          *(_QWORD *)(v2 + 56) = *(_QWORD *)(a1 + 56);
          v71 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
          v72 = sub_74FE7A4(qword_8D82A58, *(_QWORD *)(v2 + 56), 0);
          if ( v71 == 0 )
            goto LABEL_210;
          v73 = v72;
          if ( v72 != 0 )
          {
            v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v72, *(_QWORD *)(*(_QWORD *)v71 + 64LL));
            if ( v18 == 0 )
              goto LABEL_212;
          }
          if ( *(_DWORD *)(v71 + 24) != 0 )
          {
            *(_QWORD *)(v71 + 32) = v73;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Log(v71, 0);
            *(_BYTE *)(v2 + 16) = 1;
            v74 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
            if ( v74 == 0 )
              goto LABEL_210;
            v75 = v74;
            if ( qword_8D86600 != 0 )
            {
              v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                      qword_8D86600,
                      *(_QWORD *)(*(_QWORD *)v74 + 64LL));
              if ( v18 == 0 )
                goto LABEL_212;
            }
            if ( *(_DWORD *)(v75 + 24) != 0 )
            {
              *(_QWORD *)(v75 + 32) = qword_8D86600;
LABEL_164:
              GameFramework_CLog__d_e___(v75, 0);
              v84 = *(_QWORD *)(v2 + 24);
              if ( v84 != 0 )
                (*(void (__fastcall **)(_QWORD, _QWORD))(v84 + 24))(*(_QWORD *)(v84 + 64), *(_QWORD *)(v84 + 40));
LABEL_190:
              *(_QWORD *)(a1 + 64) = 0;
              goto LABEL_191;
            }
          }
        }
        else
        {
          if ( qword_8D644F0 != 0 )
          {
            v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                    qword_8D644F0,
                    *(_QWORD *)(*(_QWORD *)v68 + 64LL));
            if ( v18 == 0 )
              goto LABEL_212;
          }
          if ( *(_DWORD *)(v69 + 24) != 0 )
          {
            *(_QWORD *)(v69 + 32) = qword_8D644F0;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Log(v69, 0);
            if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE40C8);
            if ( byte_900876D == 0 )
            {
              il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
              byte_900876D = 1;
            }
            v76 = off_8CE40C8;
            if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(off_8CE40C8);
              v76 = off_8CE40C8;
            }
            if ( *(_BYTE *)(v76[23] + 56LL) == 0 )
            {
              if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE7B30);
              Module_object = GameFramework_GameFrameEntry__GetModule_object_((const MethodInfo *)qword_8D2D180);
              v79 = *(_QWORD *)(a1 + 56);
              v78 = *(_QWORD *)(a1 + 64);
              v80 = *(_DWORD *)(a1 + 40);
              v81 = Module_object;
              v82 = ((__int64 (__fastcall *)(void *))unk_3C3D4C4)(off_8CF0A40);
              slf_____ctor(v82, v78, v79, v80, 0);
              if ( v81 == nullptr )
                goto LABEL_210;
              v81[14] = v82;
            }
            if ( v2 == 0 )
              goto LABEL_210;
            *(_BYTE *)(v2 + 16) = 1;
            v83 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
            if ( v83 == 0 )
              goto LABEL_210;
            v75 = v83;
            if ( qword_8D865F8 != 0 )
            {
              v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                      qword_8D865F8,
                      *(_QWORD *)(*(_QWORD *)v83 + 64LL));
              if ( v18 == 0 )
                goto LABEL_212;
            }
            if ( *(_DWORD *)(v75 + 24) != 0 )
            {
              *(_QWORD *)(v75 + 32) = qword_8D865F8;
              if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE5250);
              goto LABEL_164;
            }
          }
        }
LABEL_211:
        v18 = ((__int64 (*)(void))unk_3C3D4D4)();
        goto LABEL_212;
      }
      v52 = sub_74FE7A4(*(_QWORD *)(a1 + 56), qword_8D52E88, 0);
      v53 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v54 = sub_74FE7A4(qword_8D87038, v52, 0);
      if ( v53 == 0 )
        goto LABEL_210;
      v55 = v54;
      if ( v54 != 0 )
      {
        v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v54, *(_QWORD *)(*(_QWORD *)v53 + 64LL));
        if ( v18 == 0 )
          goto LABEL_212;
      }
      if ( *(_DWORD *)(v53 + 24) == 0 )
        goto LABEL_211;
      *(_QWORD *)(v53 + 32) = v55;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__d_e___(v53, 0);
      v56 = UnityEngine_Networking_UnityWebRequest__Get(v52, 0);
      *(_QWORD *)(a1 + 72) = v56;
      v57 = v56;
      v58 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE6B50);
      UnityEngine_Networking_DownloadHandlerBuffer___ctor(v58, 0);
      if ( v57 == 0 )
        goto LABEL_210;
      UnityEngine_Networking_UnityWebRequest__set_downloadHandler(v57, v58, 0);
      v59 = *(_QWORD *)(a1 + 72);
      if ( v59 == 0 )
        goto LABEL_210;
      *(_QWORD *)(a1 + 24) = UnityEngine_Networking_UnityWebRequest__SendWebRequest(v59, 0);
      v8 = 5;
LABEL_208:
      *(_DWORD *)(a1 + 16) = v8;
      return 1;
    case 5:
      v29 = *(_QWORD *)(a1 + 72);
      *(_DWORD *)(a1 + 16) = -1;
      if ( v29 == 0 )
        goto LABEL_210;
      if ( UnityEngine_Networking_UnityWebRequest__get_error(v29, 0) != 0 )
      {
        v30 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( *(_QWORD *)(a1 + 72) == 0 )
          goto LABEL_210;
        v31 = v30;
        error = UnityEngine_Networking_UnityWebRequest__get_error(*(_QWORD *)(a1 + 72), 0);
        v33 = sub_74FE7A4(qword_8D86788, error, 0);
        if ( v31 == 0 )
          goto LABEL_210;
        v34 = v33;
        if ( v33 != 0 )
        {
          v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v33, *(_QWORD *)(*(_QWORD *)v31 + 64LL));
          if ( v18 == 0 )
            goto LABEL_212;
        }
        if ( *(_DWORD *)(v31 + 24) == 0 )
          goto LABEL_211;
        *(_QWORD *)(v31 + 32) = v34;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v31, 0);
      }
      else
      {
        v60 = *(_QWORD *)(a1 + 72);
        if ( v60 == 0 )
          goto LABEL_210;
        downloadHandler = UnityEngine_Networking_UnityWebRequest__get_downloadHandler(v60, 0);
        if ( downloadHandler == 0 )
          goto LABEL_210;
        data = (void *)UnityEngine_Networking_DownloadHandler__get_data(downloadHandler, 0);
        v63 = (void *)GameFramework_Tools_FileManager__get_Instance(0);
        if ( v63 == nullptr )
          goto LABEL_210;
        *(_QWORD *)(a1 + 64) = GameFramework_Tools_FileManager__QnXgString(v63, data, nullptr);
      }
      *(_QWORD *)(a1 + 72) = 0;
      goto LABEL_109;
    case 6:
      *(_DWORD *)(a1 + 16) = -1;
      v35 = (_QWORD **)off_8CEF480;
      if ( *((_DWORD *)off_8CEF480 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CEF480);
        v35 = (_QWORD **)off_8CEF480;
      }
      v36 = *v35[23];
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v37 = GameFramework_AppSetting__get_MineGameName(0);
      if ( v36 == 0 )
        goto LABEL_210;
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v36, v37, qword_8CFE978) & 1) != 0 )
      {
        v38 = (_QWORD **)off_8CEF480;
        if ( *((_DWORD *)off_8CEF480 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CEF480);
          v38 = (_QWORD **)off_8CEF480;
        }
        v39 = *v38[23];
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v40 = GameFramework_AppSetting__get_MineGameName(0);
        if ( v39 == 0 )
          goto LABEL_210;
        Item = System_Collections_Generic_Dictionary_object__object___get_Item(v39, v40, qword_8CFE980);
        if ( v2 == 0 )
          goto LABEL_210;
        *(_QWORD *)(v2 + 48) = Item;
        GameFramework_VersionMondule__SetAssetBundleURL(v2);
      }
      else
      {
        v42 = UpdateManager__get_Instance(0);
        if ( v2 == 0 )
          goto LABEL_210;
        v43 = v42;
        ABFileStreaming = GameFramework_VersionMondule__LoadABFileStreaming(v2);
        if ( v43 == 0 )
          goto LABEL_210;
        UnityEngine_MonoBehaviour__StartCoroutine(v43, ABFileStreaming, 0);
      }
      return 0;
    case 7:
      result = 0;
      *(_DWORD *)(a1 + 16) = -1;
      return result;
    default:
      return 0;
  }
}
