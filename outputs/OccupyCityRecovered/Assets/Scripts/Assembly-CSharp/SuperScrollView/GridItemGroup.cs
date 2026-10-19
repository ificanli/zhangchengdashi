using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C64")]
	public class GridItemGroup
	{
		[Token(Token = "0x40058A8")]
		[FieldOffset(Offset = "0x10")]
		private int mCount;

		[Token(Token = "0x40058A9")]
		[FieldOffset(Offset = "0x14")]
		private int mGroupIndex;

		[Token(Token = "0x40058AA")]
		[FieldOffset(Offset = "0x18")]
		private LoopGridViewItem mFirst;

		[Token(Token = "0x40058AB")]
		[FieldOffset(Offset = "0x20")]
		private LoopGridViewItem mLast;

		[Token(Token = "0x17000D91")]
		public int Count
		{
			[Token(Token = "0x6004C91")]
			[Address(RVA = "0x4279050", Offset = "0x4275050", VA = "0x4279050")]
			get
			{
				return mCount;
			}
		}

		[Token(Token = "0x17000D92")]
		public LoopGridViewItem First
		{
			[Token(Token = "0x6004C92")]
			[Address(RVA = "0x4279058", Offset = "0x4275058", VA = "0x4279058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D93")]
		public LoopGridViewItem Last
		{
			[Token(Token = "0x6004C93")]
			[Address(RVA = "0x4279060", Offset = "0x4275060", VA = "0x4279060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D94")]
		public int GroupIndex
		{
			[Token(Token = "0x6004C94")]
			[Address(RVA = "0x4279068", Offset = "0x4275068", VA = "0x4279068")]
			get
			{
				return mGroupIndex;
			}
			[Token(Token = "0x6004C95")]
			[Address(RVA = "0x4279070", Offset = "0x4275070", VA = "0x4279070")]
			set
			{
				mGroupIndex = value;
			}
		}

		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x4279078", Offset = "0x4275078", VA = "0x4279078")]
		public LoopGridViewItem GetItemByColumn(int column)
		{
			return null;
		}

		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x427910C", Offset = "0x427510C", VA = "0x427910C")]
		public LoopGridViewItem GetItemByRow(int row)
		{
			return null;
		}

		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x42791A0", Offset = "0x42751A0", VA = "0x42791A0")]
		public void ReplaceItem(LoopGridViewItem curItem, LoopGridViewItem newItem)
		{
		}

		[Token(Token = "0x6004C99")]
		[Address(RVA = "0x42792C8", Offset = "0x42752C8", VA = "0x42792C8")]
		public void AddFirst(LoopGridViewItem newItem)
		{
		}

		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0x427937C", Offset = "0x427537C", VA = "0x427937C")]
		public void AddLast(LoopGridViewItem newItem)
		{
		}

		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x4279430", Offset = "0x4275430", VA = "0x4279430")]
		public LoopGridViewItem RemoveFirst()
		{
			return null;
		}

		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x4279500", Offset = "0x4275500", VA = "0x4279500")]
		public LoopGridViewItem RemoveLast()
		{
			return null;
		}

		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x42795D4", Offset = "0x42755D4", VA = "0x42795D4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x4279664", Offset = "0x4275664", VA = "0x4279664")]
		public GridItemGroup()
		{
		}
	}
}
