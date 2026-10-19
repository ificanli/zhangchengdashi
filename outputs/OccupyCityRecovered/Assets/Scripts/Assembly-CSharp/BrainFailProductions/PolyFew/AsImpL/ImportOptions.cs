using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Serializable]
	[Token(Token = "0x2000CE4")]
	public class ImportOptions
	{
		[Token(Token = "0x4005C2F")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("load the OBJ file assuming its vertical axis is Z instead of Y")]
		public bool zUp;

		[Token(Token = "0x4005C30")]
		[FieldOffset(Offset = "0x11")]
		[Tooltip("Consider diffuse map as already lit (disable lighting) if no other texture is present")]
		public bool litDiffuse;

		[Token(Token = "0x4005C31")]
		[FieldOffset(Offset = "0x12")]
		[Tooltip("Consider to double-sided (duplicate and flip faces and normals")]
		public bool convertToDoubleSided;

		[Token(Token = "0x4005C32")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Rescaling for the model (1 = no rescaling)")]
		public float modelScaling;

		[Token(Token = "0x4005C33")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Reuse a model in memory if already loaded")]
		public bool reuseLoaded;

		[Token(Token = "0x4005C34")]
		[FieldOffset(Offset = "0x19")]
		[Tooltip("Inherit parent layer")]
		public bool inheritLayer;

		[Token(Token = "0x4005C35")]
		[FieldOffset(Offset = "0x1A")]
		[Tooltip("Generate mesh colliders")]
		public bool buildColliders;

		[Token(Token = "0x4005C36")]
		[FieldOffset(Offset = "0x1B")]
		[Tooltip("Generate convex mesh colliders (only active if buildColliders = true)\nNote: it could not work for meshes with too many smooth surface regions.")]
		public bool colliderConvex;

		[Token(Token = "0x4005C37")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Mesh colliders as trigger (only active if colliderConvex = true)")]
		public bool colliderTrigger;

		[Token(Token = "0x4005C38")]
		[FieldOffset(Offset = "0x1D")]
		[Tooltip("Use 32 bit indices when needed, if available")]
		public bool use32bitIndices;

		[Token(Token = "0x4005C39")]
		[FieldOffset(Offset = "0x1E")]
		[Tooltip("Hide the loaded object during the loading process")]
		public bool hideWhileLoading;

		[Token(Token = "0x4005C3A")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Position of the object")]
		[Header("Local Transform for the imported game object")]
		public Vector3 localPosition;

		[Token(Token = "0x4005C3B")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Rotation of the object\n(Euler angles)")]
		public Vector3 localEulerAngles;

		[Token(Token = "0x4005C3C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Scaling of the object\n([1,1,1] = no rescaling)")]
		public Vector3 localScale;

		[Token(Token = "0x6005074")]
		[Address(RVA = "0x42C9308", Offset = "0x42C5308", VA = "0x42C9308")]
		public ImportOptions()
		{
		}
	}
}
