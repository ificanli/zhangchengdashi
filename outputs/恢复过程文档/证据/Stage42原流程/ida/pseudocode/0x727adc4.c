void GameFramework_Procedure_ProcedureManager__Shutdown_727adc4(void *this, const MethodInfo *method)
{
  __int64 *v3; // x20
  __int64 v4; // x21
  __int64 v5; // x8
  void *v6; // x22
  __int64 v7; // x9
  __int64 v8; // x1
  __int64 v9; // x2
  _DWORD *v10; // x10
  __int64 v11; // x0
  __int64 v12; // x0

  if ( (byte_9009C35 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D2F558);
    byte_9009C35 = 1;
  }
  v3 = *((__int64 **)this + 4);
  if ( v3 != nullptr )
  {
    v4 = *((_QWORD *)this + 5);
    if ( v4 != 0 )
    {
      v5 = *v3;
      v6 = off_8D2F558;
      v7 = *(unsigned __int16 *)(*v3 + 302);
      v8 = *((_QWORD *)off_8D2F558 + 4);
      v9 = *((unsigned __int16 *)off_8D2F558 + 40);
      if ( *(_WORD *)(*v3 + 302) != 0 )
      {
        v10 = (_DWORD *)(*(_QWORD *)(v5 + 176) + 8LL);
        while ( *((_QWORD *)v10 - 1) != v8 )
        {
          --v7;
          v10 += 4;
          if ( v7 == 0 )
            goto LABEL_9;
        }
        v11 = v5 + 16LL * (*v10 + (int)v9) + 312;
      }
      else
      {
LABEL_9:
        v11 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(*((_QWORD *)this + 4), v8, v9);
      }
      v12 = ((__int64 (__fastcall *)(_QWORD, void *))unk_3C3D3AC)(*(_QWORD *)(v11 + 8), v6);
      (*(void (__fastcall **)(__int64 *, __int64, __int64))(v12 + 8))(v3, v4, v12);
      *((_QWORD *)this + 5) = 0;
    }
    *((_QWORD *)this + 4) = 0;
  }
  *((_BYTE *)this + 16) = 0;
}
