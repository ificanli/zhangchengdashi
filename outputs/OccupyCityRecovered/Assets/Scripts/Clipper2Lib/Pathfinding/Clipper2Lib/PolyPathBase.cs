using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000027")]
	public abstract class PolyPathBase : IEnumerable
	{
		[Token(Token = "0x2000028")]
		private class NodeEnumerator : IEnumerator
		{
			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int position;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly List<PolyPathBase> _nodes;

			[Token(Token = "0x1700000C")]
			public object Current
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x461B314", Offset = "0x4617314", VA = "0x461B314", Slot = "5")]
				get
				{
					return null;
				}
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x461B21C", Offset = "0x461721C", VA = "0x461B21C")]
			public NodeEnumerator(List<PolyPathBase> nodes)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x461B2AC", Offset = "0x46172AC", VA = "0x461B2AC", Slot = "4")]
			public bool MoveNext()
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x461B308", Offset = "0x4617308", VA = "0x461B308", Slot = "6")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal PolyPathBase? _parent;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<PolyPathBase> _childs;

		[Token(Token = "0x17000009")]
		public bool IsHole
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x461AA9C", Offset = "0x4616A9C", VA = "0x461AA9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public int Level
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x461AB64", Offset = "0x4616B64", VA = "0x461AB64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000B")]
		public int Count
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x461ABA8", Offset = "0x4616BA8", VA = "0x461ABA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x461A9DC", Offset = "0x46169DC", VA = "0x461A9DC", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x461AAC4", Offset = "0x4616AC4", VA = "0x461AAC4")]
		public PolyPathBase([Optional] PolyPathBase? parent)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x461AB4C", Offset = "0x4616B4C", VA = "0x461AB4C")]
		private int GetLevel()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x461AB7C", Offset = "0x4616B7C", VA = "0x461AB7C")]
		private bool GetIsHole()
		{
			return default;
		}

		[Token(Token = "0x600016A")]
		public abstract PolyPathBase AddChild(List<Point64> p);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x461ABF0", Offset = "0x4616BF0", VA = "0x461ABF0")]
		public void Clear()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x461AC60", Offset = "0x4616C60", VA = "0x461AC60")]
		internal string ToStringInternal(int idx, int level)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x461AFD8", Offset = "0x4616FD8", VA = "0x461AFD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
