void Pathfinding_Util_MutableGraphTransform___ctor(void *self, void *matrix, const MethodInfo *method)
{
  _BYTE v5[64]; // [xsp+0h] [xbp-B0h]
  _QWORD v6[8]; // [xsp+40h] [xbp-70h] BYREF

  if ( (byte_9000E98 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7EC8);
    byte_9000E98 = 1;
  }
  qmemcpy(v5, matrix, sizeof(v5));
  if ( *((_DWORD *)off_8CE7EC8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7EC8);
  System_Object___ctor(self, 0);
  qmemcpy(v6, v5, sizeof(v6));
  Pathfinding_Util_GraphTransform__Set(self, v6);
}
