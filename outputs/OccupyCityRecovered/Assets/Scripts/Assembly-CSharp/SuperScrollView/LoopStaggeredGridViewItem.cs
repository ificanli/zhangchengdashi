using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C7C")]
	public class LoopStaggeredGridViewItem : MonoBehaviour
	{
		[Token(Token = "0x40059BB")]
		[FieldOffset(Offset = "0x20")]
		private int mItemIndex;

		[Token(Token = "0x40059BC")]
		[FieldOffset(Offset = "0x24")]
		private int mItemIndexInGroup;

		[Token(Token = "0x40059BD")]
		[FieldOffset(Offset = "0x28")]
		private int mItemId;

		[Token(Token = "0x40059BE")]
		[FieldOffset(Offset = "0x2C")]
		private float mPadding;

		[Token(Token = "0x40059BF")]
		[FieldOffset(Offset = "0x30")]
		private float mExtraPadding;

		[Token(Token = "0x40059C0")]
		[FieldOffset(Offset = "0x34")]
		private bool mIsInitHandlerCalled;

		[Token(Token = "0x40059C1")]
		[FieldOffset(Offset = "0x38")]
		private string mItemPrefabName;

		[Token(Token = "0x40059C2")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform mCachedRectTransform;

		[Token(Token = "0x40059C3")]
		[FieldOffset(Offset = "0x48")]
		private LoopStaggeredGridView mParentListView;

		[Token(Token = "0x40059C4")]
		[FieldOffset(Offset = "0x50")]
		private float mDistanceWithViewPortSnapCenter;

		[Token(Token = "0x40059C5")]
		[FieldOffset(Offset = "0x54")]
		private int mItemCreatedCheckFrameCount;

		[Token(Token = "0x40059C6")]
		[FieldOffset(Offset = "0x58")]
		private float mStartPosOffset;

		[Token(Token = "0x40059C7")]
		[FieldOffset(Offset = "0x60")]
		private object mUserObjectData;

		[Token(Token = "0x40059C8")]
		[FieldOffset(Offset = "0x68")]
		private int mUserIntData1;

		[Token(Token = "0x40059C9")]
		[FieldOffset(Offset = "0x6C")]
		private int mUserIntData2;

		[Token(Token = "0x40059CA")]
		[FieldOffset(Offset = "0x70")]
		private string mUserStringData1;

		[Token(Token = "0x40059CB")]
		[FieldOffset(Offset = "0x78")]
		private string mUserStringData2;

		[Token(Token = "0x17000DE8")]
		public object UserObjectData
		{
			[Token(Token = "0x6004E0F")]
			[Address(RVA = "0x42A2774", Offset = "0x429E774", VA = "0x42A2774")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E10")]
			[Address(RVA = "0x42A277C", Offset = "0x429E77C", VA = "0x42A277C")]
			set
			{
			}
		}

		[Token(Token = "0x17000DE9")]
		public int UserIntData1
		{
			[Token(Token = "0x6004E11")]
			[Address(RVA = "0x42A2784", Offset = "0x429E784", VA = "0x42A2784")]
			get
			{
				return mUserIntData1;
			}
			[Token(Token = "0x6004E12")]
			[Address(RVA = "0x42A278C", Offset = "0x429E78C", VA = "0x42A278C")]
			set
			{
				mUserIntData1 = value;
			}
		}

		[Token(Token = "0x17000DEA")]
		public int UserIntData2
		{
			[Token(Token = "0x6004E13")]
			[Address(RVA = "0x42A2794", Offset = "0x429E794", VA = "0x42A2794")]
			get
			{
				return mUserIntData2;
			}
			[Token(Token = "0x6004E14")]
			[Address(RVA = "0x42A279C", Offset = "0x429E79C", VA = "0x42A279C")]
			set
			{
				mUserIntData2 = value;
			}
		}

		[Token(Token = "0x17000DEB")]
		public string UserStringData1
		{
			[Token(Token = "0x6004E15")]
			[Address(RVA = "0x42A27A4", Offset = "0x429E7A4", VA = "0x42A27A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E16")]
			[Address(RVA = "0x42A27AC", Offset = "0x429E7AC", VA = "0x42A27AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000DEC")]
		public string UserStringData2
		{
			[Token(Token = "0x6004E17")]
			[Address(RVA = "0x42A27B4", Offset = "0x429E7B4", VA = "0x42A27B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E18")]
			[Address(RVA = "0x42A27BC", Offset = "0x429E7BC", VA = "0x42A27BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000DED")]
		public float DistanceWithViewPortSnapCenter
		{
			[Token(Token = "0x6004E19")]
			[Address(RVA = "0x42A27C4", Offset = "0x429E7C4", VA = "0x42A27C4")]
			get
			{
				return mDistanceWithViewPortSnapCenter;
			}
			[Token(Token = "0x6004E1A")]
			[Address(RVA = "0x42A27CC", Offset = "0x429E7CC", VA = "0x42A27CC")]
			set
			{
				mDistanceWithViewPortSnapCenter = value;
			}
		}

		[Token(Token = "0x17000DEE")]
		public float StartPosOffset
		{
			[Token(Token = "0x6004E1B")]
			[Address(RVA = "0x42A27D4", Offset = "0x429E7D4", VA = "0x42A27D4")]
			get
			{
				return mStartPosOffset;
			}
			[Token(Token = "0x6004E1C")]
			[Address(RVA = "0x42A27DC", Offset = "0x429E7DC", VA = "0x42A27DC")]
			set
			{
				mStartPosOffset = value;
			}
		}

		[Token(Token = "0x17000DEF")]
		public int ItemCreatedCheckFrameCount
		{
			[Token(Token = "0x6004E1D")]
			[Address(RVA = "0x42A27E4", Offset = "0x429E7E4", VA = "0x42A27E4")]
			get
			{
				return mItemCreatedCheckFrameCount;
			}
			[Token(Token = "0x6004E1E")]
			[Address(RVA = "0x42A27EC", Offset = "0x429E7EC", VA = "0x42A27EC")]
			set
			{
				mItemCreatedCheckFrameCount = value;
			}
		}

		[Token(Token = "0x17000DF0")]
		public float Padding
		{
			[Token(Token = "0x6004E1F")]
			[Address(RVA = "0x42A27F4", Offset = "0x429E7F4", VA = "0x42A27F4")]
			get
			{
				return mPadding;
			}
			[Token(Token = "0x6004E20")]
			[Address(RVA = "0x42A27FC", Offset = "0x429E7FC", VA = "0x42A27FC")]
			set
			{
				mPadding = value;
			}
		}

		[Token(Token = "0x17000DF1")]
		public float ExtraPadding
		{
			[Token(Token = "0x6004E21")]
			[Address(RVA = "0x42A2804", Offset = "0x429E804", VA = "0x42A2804")]
			get
			{
				return mExtraPadding;
			}
			[Token(Token = "0x6004E22")]
			[Address(RVA = "0x42A280C", Offset = "0x429E80C", VA = "0x42A280C")]
			set
			{
				mExtraPadding = value;
			}
		}

		[Token(Token = "0x17000DF2")]
		public RectTransform CachedRectTransform
		{
			[Token(Token = "0x6004E23")]
			[Address(RVA = "0x42A2814", Offset = "0x429E814", VA = "0x42A2814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DF3")]
		public string ItemPrefabName
		{
			[Token(Token = "0x6004E24")]
			[Address(RVA = "0x42A28B8", Offset = "0x429E8B8", VA = "0x42A28B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E25")]
			[Address(RVA = "0x42A28C0", Offset = "0x429E8C0", VA = "0x42A28C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000DF4")]
		public int ItemIndexInGroup
		{
			[Token(Token = "0x6004E26")]
			[Address(RVA = "0x42A28C8", Offset = "0x429E8C8", VA = "0x42A28C8")]
			get
			{
				return mItemIndexInGroup;
			}
			[Token(Token = "0x6004E27")]
			[Address(RVA = "0x42A28D0", Offset = "0x429E8D0", VA = "0x42A28D0")]
			set
			{
				mItemIndexInGroup = value;
			}
		}

		[Token(Token = "0x17000DF5")]
		public int ItemIndex
		{
			[Token(Token = "0x6004E28")]
			[Address(RVA = "0x42A28D8", Offset = "0x429E8D8", VA = "0x42A28D8")]
			get
			{
				return mItemIndex;
			}
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x42A28E0", Offset = "0x429E8E0", VA = "0x42A28E0")]
			set
			{
				mItemIndex = value;
			}
		}

		[Token(Token = "0x17000DF6")]
		public int ItemId
		{
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x42A28E8", Offset = "0x429E8E8", VA = "0x42A28E8")]
			get
			{
				return mItemId;
			}
			[Token(Token = "0x6004E2B")]
			[Address(RVA = "0x42A28F0", Offset = "0x429E8F0", VA = "0x42A28F0")]
			set
			{
				mItemId = value;
			}
		}

		[Token(Token = "0x17000DF7")]
		public bool IsInitHandlerCalled
		{
			[Token(Token = "0x6004E2C")]
			[Address(RVA = "0x42A28F8", Offset = "0x429E8F8", VA = "0x42A28F8")]
			get
			{
				return mIsInitHandlerCalled;
			}
			[Token(Token = "0x6004E2D")]
			[Address(RVA = "0x42A2900", Offset = "0x429E900", VA = "0x42A2900")]
			set
			{
				mIsInitHandlerCalled = value;
			}
		}

		[Token(Token = "0x17000DF8")]
		public LoopStaggeredGridView ParentListView
		{
			[Token(Token = "0x6004E2E")]
			[Address(RVA = "0x42A290C", Offset = "0x429E90C", VA = "0x42A290C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E2F")]
			[Address(RVA = "0x42A2914", Offset = "0x429E914", VA = "0x42A2914")]
			set
			{
			}
		}

		[Token(Token = "0x17000DF9")]
		public float TopY
		{
			[Token(Token = "0x6004E30")]
			[Address(RVA = "0x42A291C", Offset = "0x429E91C", VA = "0x42A291C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DFA")]
		public float BottomY
		{
			[Token(Token = "0x6004E31")]
			[Address(RVA = "0x42A29A0", Offset = "0x429E9A0", VA = "0x42A29A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DFB")]
		public float LeftX
		{
			[Token(Token = "0x6004E32")]
			[Address(RVA = "0x42A2A24", Offset = "0x429EA24", VA = "0x42A2A24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DFC")]
		public float RightX
		{
			[Token(Token = "0x6004E33")]
			[Address(RVA = "0x42A2AA8", Offset = "0x429EAA8", VA = "0x42A2AA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DFD")]
		public float ItemSize
		{
			[Token(Token = "0x6004E34")]
			[Address(RVA = "0x42A2B2C", Offset = "0x429EB2C", VA = "0x42A2B2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DFE")]
		public float ItemSizeWithPadding
		{
			[Token(Token = "0x6004E35")]
			[Address(RVA = "0x42A2B60", Offset = "0x429EB60", VA = "0x42A2B60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x42A2B7C", Offset = "0x429EB7C", VA = "0x42A2B7C")]
		public LoopStaggeredGridViewItem()
		{
		}
	}
}
