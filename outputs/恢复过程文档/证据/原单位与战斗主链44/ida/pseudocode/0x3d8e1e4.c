__int64 __fastcall GameModule_RoleBehaviour___ctor(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x20
  __int64 v9; // x20
  __int64 v10; // x20
  __int64 v11; // x20
  __int64 v12; // x20
  __int64 v13; // x20

  if ( (byte_8FFD4B3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F7C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E240);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DD68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F7B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE0C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE470);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDFF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEDAF0);
    byte_8FFD4B3 = 1;
  }
  *(_DWORD *)(a1 + 144) = -1082130432;
  *(_DWORD *)(a1 + 276) = -1082130432;
  *(_DWORD *)(a1 + 288) = -1;
  *(_BYTE *)(a1 + 301) = 1;
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE0C0);
  System_Collections_Generic_List_float____ctor(v2, qword_8D0E240);
  *(_QWORD *)(a1 + 304) = v2;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFF0);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0DD68);
  __asm { FMOV            V0.2S, #-1.0 }
  *(_QWORD *)(a1 + 384) = v3;
  *(_QWORD *)(a1 + 444) = _D0;
  *(int32x2_t *)(a1 + 456) = vdup_n_s32(0xC479C000);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFF0);
  System_Collections_Generic_List_object____ctor(v9, qword_8D0DD68);
  *(_QWORD *)(a1 + 512) = v9;
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE470);
  System_Collections_Generic_List_Vector3____ctor(v10, qword_8D0F7B0);
  *(_QWORD *)(a1 + 520) = v10;
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE0C0);
  System_Collections_Generic_List_float____ctor(v11, qword_8D0E240);
  *(_QWORD *)(a1 + 528) = v11;
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE470);
  sub_5817A48(v12, 32, qword_8D0F7C0);
  *(_QWORD *)(a1 + 536) = v12;
  v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEDAF0);
  System_Text_StringBuilder___ctor(v13, 16, 0);
  *(_QWORD *)(a1 + 544) = v13;
  *(_DWORD *)(a1 + 616) = -1082130432;
  *(_DWORD *)(a1 + 632) = -1082130432;
  return GameModule_EntityBase___ctor(a1, 0);
}
