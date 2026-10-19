void GameFramework_Procedure_ProcedureManager__Register_727aa3c(void *this, void *procedures, const MethodInfo *method)
{
  __int64 *Module_object; // x0
  __int64 v6; // x8
  void *v7; // x21
  void *v8; // x22
  __int64 v9; // x9
  __int64 v10; // x1
  __int64 v11; // x2
  _DWORD *v12; // x10
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x19
  __int64 v17; // x0
  __int64 v18; // x0

  if ( (byte_9009C32 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D2F548);
    byte_9009C32 = 1;
  }
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = (__int64 *)GameFramework_GameFrameEntry__GetModule_object_((const MethodInfo *)qword_8D2D148);
  *((_QWORD *)this + 4) = Module_object;
  if ( Module_object == nullptr )
  {
    v15 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v15);
    v17 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600E0);
    GameFramework_GameFrameworkException___ctor(v16, v17, 0);
    v18 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D36020);
    ((void (__fastcall *)(__int64, __int64))unk_3C3D3A0)(v16, v18);
    JUMPOUT(0x727AB98);
  }
  v6 = *Module_object;
  v7 = Module_object;
  v8 = off_8D2F548;
  v9 = *(unsigned __int16 *)(*Module_object + 302);
  v10 = *((_QWORD *)off_8D2F548 + 4);
  v11 = *((unsigned __int16 *)off_8D2F548 + 40);
  if ( *(_WORD *)(*Module_object + 302) != 0 )
  {
    v12 = (_DWORD *)(*(_QWORD *)(v6 + 176) + 8LL);
    while ( *((_QWORD *)v12 - 1) != v10 )
    {
      --v9;
      v12 += 4;
      if ( v9 == 0 )
        goto LABEL_10;
    }
    v13 = v6 + 16LL * (*v12 + (int)v11) + 312;
  }
  else
  {
LABEL_10:
    v13 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(Module_object, v10, v11);
  }
  v14 = ((__int64 (__fastcall *)(_QWORD, void *))unk_3C3D3AC)(*(_QWORD *)(v13 + 8), v8);
  *((_QWORD *)this + 5) = (*(__int64 (__fastcall **)(void *, void *, void *, __int64))(v14 + 8))(
                            v7,
                            this,
                            procedures,
                            v14);
}
