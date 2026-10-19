void ____T___ctor(
        void *self,
        void *arg0,
        void *arg1,
        void *arg2,
        int arg3,
        unsigned __int8 arg4,
        int arg5,
        const MethodInfo *method)
{
  __int64 AssetPath; // x22

  if ( (byte_9009370 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB838);
    byte_9009370 = 1;
  }
  __Hcp___ctor(self, arg0, arg1, arg2, 0);
  *((_DWORD *)self + 44) = arg3;
  if ( arg2 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  AssetPath = YooAsset_AssetInfo__get_AssetPath(arg2, 0);
  if ( *((_DWORD *)off_8CEB838 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB838);
  *((_QWORD *)self + 23) = System_IO_Path__GetFileNameWithoutExtension(AssetPath, 0);
  *((_BYTE *)self + 192) = arg4 & 1;
  *((_DWORD *)self + 49) = arg5;
}
