using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	[Token(Token = "0x2000D12")]
	public class Vertex
	{
		[Token(Token = "0x4005D7E")]
		[FieldOffset(Offset = "0x10")]
		private Vertex prevVertex;

		[Token(Token = "0x4005D7F")]
		[FieldOffset(Offset = "0x18")]
		private Vertex nextVertex;

		[Token(Token = "0x4005D80")]
		[FieldOffset(Offset = "0x20")]
		private float triangleArea;

		[Token(Token = "0x4005D81")]
		[FieldOffset(Offset = "0x24")]
		private bool triangleHasChanged;

		[Token(Token = "0x17000E55")]
		public Vector3 Position
		{
			[Token(Token = "0x6005149")]
			[Address(RVA = "0x42DB6CC", Offset = "0x42D76CC", VA = "0x42DB6CC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600514A")]
			[Address(RVA = "0x42DB6D8", Offset = "0x42D76D8", VA = "0x42DB6D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000E56")]
		public int OriginalIndex
		{
			[Token(Token = "0x600514B")]
			[Address(RVA = "0x42DB6E4", Offset = "0x42D76E4", VA = "0x42DB6E4")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x600514C")]
			[Address(RVA = "0x42DB6EC", Offset = "0x42D76EC", VA = "0x42DB6EC")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x17000E57")]
		public Vertex PreviousVertex
		{
			[Token(Token = "0x600514D")]
			[Address(RVA = "0x42DB6F4", Offset = "0x42D76F4", VA = "0x42DB6F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600514E")]
			[Address(RVA = "0x42DB6FC", Offset = "0x42D76FC", VA = "0x42DB6FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000E58")]
		public Vertex NextVertex
		{
			[Token(Token = "0x600514F")]
			[Address(RVA = "0x42DB714", Offset = "0x42D7714", VA = "0x42DB714")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005150")]
			[Address(RVA = "0x42DB71C", Offset = "0x42D771C", VA = "0x42DB71C")]
			set
			{
			}
		}

		[Token(Token = "0x17000E59")]
		public float TriangleArea
		{
			[Token(Token = "0x6005151")]
			[Address(RVA = "0x42DB734", Offset = "0x42D7734", VA = "0x42DB734")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005152")]
		[Address(RVA = "0x42DB854", Offset = "0x42D7854", VA = "0x42DB854")]
		public Vertex(int originalIndex, Vector3 position)
		{
		}

		[Token(Token = "0x6005153")]
		[Address(RVA = "0x42DB8A0", Offset = "0x42D78A0", VA = "0x42DB8A0")]
		public Vector2 GetPosOnPlane(Vector3 planeNormal)
		{
			return default;
		}

		[Token(Token = "0x6005154")]
		[Address(RVA = "0x42DB758", Offset = "0x42D7758", VA = "0x42DB758")]
		private void ComputeTriangleArea()
		{
		}
	}
}
