void AssetBundles_AssetBundleLoadAssetOperationFull___ctor(
        void *self,
        void *bundleName,
        void *assetName,
        void *type,
        const MethodInfo *method)
{
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 2) = bundleName;
  *((_QWORD *)self + 3) = assetName;
  *((_QWORD *)self + 5) = type;
}
