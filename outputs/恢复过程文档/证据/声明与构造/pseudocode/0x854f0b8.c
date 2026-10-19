void BrainFailProductions_PolyFew_UnityMeshSimplifier_BlendShapeFrame___ctor(
        void *self,
        float weight,
        void *vertices,
        void *normals,
        void *tangents,
        const MethodInfo *method)
{
  __int64 v11; // x8

  if ( (byte_901B90A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_901B90A = 1;
  }
  *((float *)self + 2) = weight;
  *((_QWORD *)self + 2) = vertices;
  *((_QWORD *)self + 3) = normals;
  *((_QWORD *)self + 4) = tangents;
  v11 = qword_8D4ECC0;
  *((_DWORD *)self + 10) = -1;
  *(_QWORD *)self = v11;
}
