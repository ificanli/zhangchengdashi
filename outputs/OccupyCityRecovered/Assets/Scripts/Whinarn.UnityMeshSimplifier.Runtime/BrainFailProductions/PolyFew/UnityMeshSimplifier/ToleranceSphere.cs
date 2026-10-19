using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Serializable]
	[Token(Token = "0x200001B")]
	public class ToleranceSphere
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x1C")]
		public Matrix4x4 localToWorldMatrix;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x5C")]
		public float diameter;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject targetObject;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x6C")]
		public int currentEnclosedTrianglesCount;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x74")]
		public float preservationStrength;

		[Token(Token = "0x17000036")]
		public int initialEnclosedTrianglesCount
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x8569814", Offset = "0x8565814", VA = "0x8569814")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x856980C", Offset = "0x856580C", VA = "0x856980C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int leastTrianglesCount
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x8569824", Offset = "0x8565824", VA = "0x8569824")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x856981C", Offset = "0x856581C", VA = "0x856981C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x856982C", Offset = "0x856582C", VA = "0x856982C")]
		public void SetInitialEnclosedTrianglesCount(int initialCount)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8569928", Offset = "0x8565928", VA = "0x8569928")]
		public ToleranceSphere()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x8569938", Offset = "0x8565938", VA = "0x8569938")]
		public ToleranceSphere(Vector3 worldPosition, Matrix4x4 localToWorldMatrix, float diameter, GameObject targetObject, float preservationStrength)
		{
		}
	}
}
