using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200001C")]
	public class Triangle : IEquatable<Triangle>
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x14")]
		public int v0;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		public int v1;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x1C")]
		public int v2;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x20")]
		public int subMeshIndex;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x24")]
		public int va0;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		public int va1;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x2C")]
		public int va2;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		public double err0;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x38")]
		public double err1;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x40")]
		public double err2;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x48")]
		public double err3;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x50")]
		public bool deleted;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x51")]
		public bool dirty;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x58")]
		public Ref refCached;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x60")]
		public Vector3d n;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x78")]
		public Vector3d nCached;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x90")]
		public HashSet<ToleranceSphere> enclosingSpheres;

		[Token(Token = "0x17000038")]
		public int this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x85699C0", Offset = "0x85659C0", VA = "0x85699C0")]
			get
			{
				return default;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x85699E8", Offset = "0x85659E8", VA = "0x85699E8")]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x8569A64", Offset = "0x8565A64", VA = "0x8569A64")]
		public Triangle(int index, int v0, int v1, int v2, int subMeshIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x8569B64", Offset = "0x8565B64", VA = "0x8569B64")]
		public void GetAttributeIndices(int[] attributeIndices)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x8569BAC", Offset = "0x8565BAC", VA = "0x8569BAC")]
		public void SetAttributeIndex(int index, int value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x8569C28", Offset = "0x8565C28", VA = "0x8569C28")]
		public int GetAttributeIndex(int index)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x8569CA8", Offset = "0x8565CA8", VA = "0x8569CA8")]
		public void GetErrors(double[] err)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x8569CF0", Offset = "0x8565CF0", VA = "0x8569CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x8569CF8", Offset = "0x8565CF8", VA = "0x8569CF8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x8569D84", Offset = "0x8565D84", VA = "0x8569D84", Slot = "4")]
		public bool Equals(Triangle other)
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x8569DA8", Offset = "0x8565DA8", VA = "0x8569DA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
