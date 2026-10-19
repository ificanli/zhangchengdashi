using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace WG.CollectKit
{
	[Token(Token = "0x2000008")]
	public class CollectionsContainer
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private Action _onAllCollectionsReached;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private Action<int> _onSingleCollectionsReached;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public List<SingleCollection> collections;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		public int count;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x34")]
		private int _targetCount;

		[Token(Token = "0x1700000E")]
		public bool Recycling
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x854D844", Offset = "0x8549844", VA = "0x854D844")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x854D84C", Offset = "0x854984C", VA = "0x854D84C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x854D858", Offset = "0x8549858", VA = "0x854D858")]
		public void CollectionReached(int singleValue)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x854D8CC", Offset = "0x85498CC", VA = "0x854D8CC")]
		public CollectionsContainer(List<SingleCollection> _collections)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x854D92C", Offset = "0x854992C", VA = "0x854D92C")]
		public CollectionsContainer OnAllCollectionsReached(Action action)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x854D9B0", Offset = "0x85499B0", VA = "0x854D9B0")]
		public CollectionsContainer OnSingleCollectionsReached(Action<int> action)
		{
			return null;
		}
	}
}
