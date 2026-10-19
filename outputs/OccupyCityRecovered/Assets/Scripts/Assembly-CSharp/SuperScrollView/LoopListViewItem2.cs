using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C75")]
	public class LoopListViewItem2 : MonoBehaviour
	{
		[Token(Token = "0x4005974")]
		[FieldOffset(Offset = "0x20")]
		private int mItemIndex;

		[Token(Token = "0x4005975")]
		[FieldOffset(Offset = "0x24")]
		private int mItemId;

		[Token(Token = "0x4005976")]
		[FieldOffset(Offset = "0x28")]
		private LoopListView2 mParentListView;

		[Token(Token = "0x4005977")]
		[FieldOffset(Offset = "0x30")]
		private bool mIsInitHandlerCalled;

		[Token(Token = "0x4005978")]
		[FieldOffset(Offset = "0x38")]
		private string mItemPrefabName;

		[Token(Token = "0x4005979")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform mCachedRectTransform;

		[Token(Token = "0x400597A")]
		[FieldOffset(Offset = "0x48")]
		private float mPadding;

		[Token(Token = "0x400597B")]
		[FieldOffset(Offset = "0x4C")]
		private float mDistanceWithViewPortSnapCenter;

		[Token(Token = "0x400597C")]
		[FieldOffset(Offset = "0x50")]
		private int mItemCreatedCheckFrameCount;

		[Token(Token = "0x400597D")]
		[FieldOffset(Offset = "0x54")]
		private float mStartPosOffset;

		[Token(Token = "0x400597E")]
		[FieldOffset(Offset = "0x58")]
		private object mUserObjectData;

		[Token(Token = "0x400597F")]
		[FieldOffset(Offset = "0x60")]
		private int mUserIntData1;

		[Token(Token = "0x4005980")]
		[FieldOffset(Offset = "0x64")]
		private int mUserIntData2;

		[Token(Token = "0x4005981")]
		[FieldOffset(Offset = "0x68")]
		private string mUserStringData1;

		[Token(Token = "0x4005982")]
		[FieldOffset(Offset = "0x70")]
		private string mUserStringData2;

		[Token(Token = "0x17000DC5")]
		public object UserObjectData
		{
			[Token(Token = "0x6004DA5")]
			[Address(RVA = "0x429CFD0", Offset = "0x4298FD0", VA = "0x429CFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DA6")]
			[Address(RVA = "0x429CFD8", Offset = "0x4298FD8", VA = "0x429CFD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000DC6")]
		public int UserIntData1
		{
			[Token(Token = "0x6004DA7")]
			[Address(RVA = "0x429CFE0", Offset = "0x4298FE0", VA = "0x429CFE0")]
			get
			{
				return mUserIntData1;
			}
			[Token(Token = "0x6004DA8")]
			[Address(RVA = "0x429CFE8", Offset = "0x4298FE8", VA = "0x429CFE8")]
			set
			{
				mUserIntData1 = value;
			}
		}

		[Token(Token = "0x17000DC7")]
		public int UserIntData2
		{
			[Token(Token = "0x6004DA9")]
			[Address(RVA = "0x429CFF0", Offset = "0x4298FF0", VA = "0x429CFF0")]
			get
			{
				return mUserIntData2;
			}
			[Token(Token = "0x6004DAA")]
			[Address(RVA = "0x429CFF8", Offset = "0x4298FF8", VA = "0x429CFF8")]
			set
			{
				mUserIntData2 = value;
			}
		}

		[Token(Token = "0x17000DC8")]
		public string UserStringData1
		{
			[Token(Token = "0x6004DAB")]
			[Address(RVA = "0x429D000", Offset = "0x4299000", VA = "0x429D000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DAC")]
			[Address(RVA = "0x429D008", Offset = "0x4299008", VA = "0x429D008")]
			set
			{
			}
		}

		[Token(Token = "0x17000DC9")]
		public string UserStringData2
		{
			[Token(Token = "0x6004DAD")]
			[Address(RVA = "0x429D010", Offset = "0x4299010", VA = "0x429D010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DAE")]
			[Address(RVA = "0x429D018", Offset = "0x4299018", VA = "0x429D018")]
			set
			{
			}
		}

		[Token(Token = "0x17000DCA")]
		public float DistanceWithViewPortSnapCenter
		{
			[Token(Token = "0x6004DAF")]
			[Address(RVA = "0x429D020", Offset = "0x4299020", VA = "0x429D020")]
			get
			{
				return mDistanceWithViewPortSnapCenter;
			}
			[Token(Token = "0x6004DB0")]
			[Address(RVA = "0x429D028", Offset = "0x4299028", VA = "0x429D028")]
			set
			{
				mDistanceWithViewPortSnapCenter = value;
			}
		}

		[Token(Token = "0x17000DCB")]
		public float StartPosOffset
		{
			[Token(Token = "0x6004DB1")]
			[Address(RVA = "0x429D030", Offset = "0x4299030", VA = "0x429D030")]
			get
			{
				return mStartPosOffset;
			}
			[Token(Token = "0x6004DB2")]
			[Address(RVA = "0x429D038", Offset = "0x4299038", VA = "0x429D038")]
			set
			{
				mStartPosOffset = value;
			}
		}

		[Token(Token = "0x17000DCC")]
		public int ItemCreatedCheckFrameCount
		{
			[Token(Token = "0x6004DB3")]
			[Address(RVA = "0x429D040", Offset = "0x4299040", VA = "0x429D040")]
			get
			{
				return mItemCreatedCheckFrameCount;
			}
			[Token(Token = "0x6004DB4")]
			[Address(RVA = "0x429D048", Offset = "0x4299048", VA = "0x429D048")]
			set
			{
				mItemCreatedCheckFrameCount = value;
			}
		}

		[Token(Token = "0x17000DCD")]
		public float Padding
		{
			[Token(Token = "0x6004DB5")]
			[Address(RVA = "0x429D050", Offset = "0x4299050", VA = "0x429D050")]
			get
			{
				return mPadding;
			}
			[Token(Token = "0x6004DB6")]
			[Address(RVA = "0x429D058", Offset = "0x4299058", VA = "0x429D058")]
			set
			{
				mPadding = value;
			}
		}

		[Token(Token = "0x17000DCE")]
		public RectTransform CachedRectTransform
		{
			[Token(Token = "0x6004DB7")]
			[Address(RVA = "0x429D060", Offset = "0x4299060", VA = "0x429D060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DCF")]
		public string ItemPrefabName
		{
			[Token(Token = "0x6004DB8")]
			[Address(RVA = "0x429D104", Offset = "0x4299104", VA = "0x429D104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DB9")]
			[Address(RVA = "0x429D10C", Offset = "0x429910C", VA = "0x429D10C")]
			set
			{
			}
		}

		[Token(Token = "0x17000DD0")]
		public int ItemIndex
		{
			[Token(Token = "0x6004DBA")]
			[Address(RVA = "0x429D114", Offset = "0x4299114", VA = "0x429D114")]
			get
			{
				return mItemIndex;
			}
			[Token(Token = "0x6004DBB")]
			[Address(RVA = "0x429D11C", Offset = "0x429911C", VA = "0x429D11C")]
			set
			{
				mItemIndex = value;
			}
		}

		[Token(Token = "0x17000DD1")]
		public int ItemId
		{
			[Token(Token = "0x6004DBC")]
			[Address(RVA = "0x429D124", Offset = "0x4299124", VA = "0x429D124")]
			get
			{
				return mItemId;
			}
			[Token(Token = "0x6004DBD")]
			[Address(RVA = "0x429D12C", Offset = "0x429912C", VA = "0x429D12C")]
			set
			{
				mItemId = value;
			}
		}

		[Token(Token = "0x17000DD2")]
		public bool IsInitHandlerCalled
		{
			[Token(Token = "0x6004DBE")]
			[Address(RVA = "0x429D134", Offset = "0x4299134", VA = "0x429D134")]
			get
			{
				return mIsInitHandlerCalled;
			}
			[Token(Token = "0x6004DBF")]
			[Address(RVA = "0x429D13C", Offset = "0x429913C", VA = "0x429D13C")]
			set
			{
				mIsInitHandlerCalled = value;
			}
		}

		[Token(Token = "0x17000DD3")]
		public LoopListView2 ParentListView
		{
			[Token(Token = "0x6004DC0")]
			[Address(RVA = "0x429D148", Offset = "0x4299148", VA = "0x429D148")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DC1")]
			[Address(RVA = "0x429D150", Offset = "0x4299150", VA = "0x429D150")]
			set
			{
			}
		}

		[Token(Token = "0x17000DD4")]
		public float TopY
		{
			[Token(Token = "0x6004DC2")]
			[Address(RVA = "0x429D158", Offset = "0x4299158", VA = "0x429D158")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DD5")]
		public float BottomY
		{
			[Token(Token = "0x6004DC3")]
			[Address(RVA = "0x429D1DC", Offset = "0x42991DC", VA = "0x429D1DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DD6")]
		public float LeftX
		{
			[Token(Token = "0x6004DC4")]
			[Address(RVA = "0x429D260", Offset = "0x4299260", VA = "0x429D260")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DD7")]
		public float RightX
		{
			[Token(Token = "0x6004DC5")]
			[Address(RVA = "0x429D2E4", Offset = "0x42992E4", VA = "0x429D2E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DD8")]
		public float ItemSize
		{
			[Token(Token = "0x6004DC6")]
			[Address(RVA = "0x429D368", Offset = "0x4299368", VA = "0x429D368")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DD9")]
		public float ItemSizeWithPadding
		{
			[Token(Token = "0x6004DC7")]
			[Address(RVA = "0x429D39C", Offset = "0x429939C", VA = "0x429D39C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x429D3B8", Offset = "0x42993B8", VA = "0x429D3B8")]
		public LoopListViewItem2()
		{
		}
	}
}
