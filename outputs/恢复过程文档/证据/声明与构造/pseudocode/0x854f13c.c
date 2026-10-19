void sub_854F13C(
        void *self,
        void *name,
        float weight,
        void *vertices,
        void *normals,
        void *tangents,
        int vertexOffset,
        const MethodInfo *method)
{
  *(_QWORD *)self = name;
  *((float *)self + 2) = weight;
  *((_QWORD *)self + 2) = vertices;
  *((_QWORD *)self + 3) = normals;
  *((_QWORD *)self + 4) = tangents;
  *((_DWORD *)self + 10) = vertexOffset;
}
