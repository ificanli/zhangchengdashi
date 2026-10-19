using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C6C")]
	public class LoopGridViewItem : MonoBehaviour
	{
		[Token(Token = "0x40058FA")]
		[FieldOffset(Offset = "0x20")]
		private int mItemIndex;

		[Token(Token = "0x40058FB")]
		[FieldOffset(Offset = "0x24")]
		private int mRow;

		[Token(Token = "0x40058FC")]
		[FieldOffset(Offset = "0x28")]
		private int mColumn;

		[Token(Token = "0x40058FD")]
		[FieldOffset(Offset = "0x2C")]
		private int mItemId;

		[Token(Token = "0x40058FE")]
		[FieldOffset(Offset = "0x30")]
		private LoopGridView mParentGridView;

		[Token(Token = "0x40058FF")]
		[FieldOffset(Offset = "0x38")]
		private bool mIsInitHandlerCalled;

		[Token(Token = "0x4005900")]
		[FieldOffset(Offset = "0x40")]
		private string mItemPrefabName;

		[Token(Token = "0x4005901")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform mCachedRectTransform;

		[Token(Token = "0x4005902")]
		[FieldOffset(Offset = "0x50")]
		private int mItemCreatedCheckFrameCount;

		[Token(Token = "0x4005903")]
		[FieldOffset(Offset = "0x58")]
		private object mUserObjectData;

		[Token(Token = "0x4005904")]
		[FieldOffset(Offset = "0x60")]
		private int mUserIntData1;

		[Token(Token = "0x4005905")]
		[FieldOffset(Offset = "0x64")]
		private int mUserIntData2;

		[Token(Token = "0x4005906")]
		[FieldOffset(Offset = "0x68")]
		private string mUserStringData1;

		[Token(Token = "0x4005907")]
		[FieldOffset(Offset = "0x70")]
		private string mUserStringData2;

		[Token(Token = "0x4005908")]
		[FieldOffset(Offset = "0x78")]
		private LoopGridViewItem mPrevItem;

		[Token(Token = "0x4005909")]
		[FieldOffset(Offset = "0x80")]
		private LoopGridViewItem mNextItem;

		[Token(Token = "0x17000DA4")]
		public object UserObjectData
		{
			[Token(Token = "0x6004D0D")]
			[Address(RVA = "0x427ED0C", Offset = "0x427AD0C", VA = "0x427ED0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D0E")]
			[Address(RVA = "0x427ED14", Offset = "0x427AD14", VA = "0x427ED14")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA5")]
		public int UserIntData1
		{
			[Token(Token = "0x6004D0F")]
			[Address(RVA = "0x427ED1C", Offset = "0x427AD1C", VA = "0x427ED1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D10")]
			[Address(RVA = "0x427ED24", Offset = "0x427AD24", VA = "0x427ED24")]
			set
			{
				mUserIntData1 = value;
			}
		}

		[Token(Token = "0x17000DA6")]
		public int UserIntData2
		{
			[Token(Token = "0x6004D11")]
			[Address(RVA = "0x427ED2C", Offset = "0x427AD2C", VA = "0x427ED2C")]
			get
			{
				return mUserIntData2;
			}
			[Token(Token = "0x6004D12")]
			[Address(RVA = "0x427ED34", Offset = "0x427AD34", VA = "0x427ED34")]
			set
			{
				mUserIntData2 = value;
			}
		}

		[Token(Token = "0x17000DA7")]
		public string UserStringData1
		{
			[Token(Token = "0x6004D13")]
			[Address(RVA = "0x427ED3C", Offset = "0x427AD3C", VA = "0x427ED3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D14")]
			[Address(RVA = "0x427ED44", Offset = "0x427AD44", VA = "0x427ED44")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA8")]
		public string UserStringData2
		{
			[Token(Token = "0x6004D15")]
			[Address(RVA = "0x427ED4C", Offset = "0x427AD4C", VA = "0x427ED4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D16")]
			[Address(RVA = "0x427ED54", Offset = "0x427AD54", VA = "0x427ED54")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA9")]
		public int ItemCreatedCheckFrameCount
		{
			[Token(Token = "0x6004D17")]
			[Address(RVA = "0x427ED5C", Offset = "0x427AD5C", VA = "0x427ED5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D18")]
			[Address(RVA = "0x427ED64", Offset = "0x427AD64", VA = "0x427ED64")]
			set
			{
				mItemCreatedCheckFrameCount = value;
			}
		}

		[Token(Token = "0x17000DAA")]
		public RectTransform CachedRectTransform
		{
			[Token(Token = "0x6004D19")]
			[Address(RVA = "0x427C6BC", Offset = "0x42786BC", VA = "0x427C6BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DAB")]
		public string ItemPrefabName
		{
			[Token(Token = "0x6004D1A")]
			[Address(RVA = "0x427ED6C", Offset = "0x427AD6C", VA = "0x427ED6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D1B")]
			[Address(RVA = "0x427ED74", Offset = "0x427AD74", VA = "0x427ED74")]
			set
			{
			}
		}

		[Token(Token = "0x17000DAC")]
		public int Row
		{
			[Token(Token = "0x6004D1C")]
			[Address(RVA = "0x427ED7C", Offset = "0x427AD7C", VA = "0x427ED7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D1D")]
			[Address(RVA = "0x427ED84", Offset = "0x427AD84", VA = "0x427ED84")]
			set
			{
				mRow = value;
			}
		}

		[Token(Token = "0x17000DAD")]
		public int Column
		{
			[Token(Token = "0x6004D1E")]
			[Address(RVA = "0x427ED8C", Offset = "0x427AD8C", VA = "0x427ED8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D1F")]
			[Address(RVA = "0x427ED94", Offset = "0x427AD94", VA = "0x427ED94")]
			set
			{
				mColumn = value;
			}
		}

		[Token(Token = "0x17000DAE")]
		public int ItemIndex
		{
			[Token(Token = "0x6004D20")]
			[Address(RVA = "0x427ED9C", Offset = "0x427AD9C", VA = "0x427ED9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D21")]
			[Address(RVA = "0x427EDA4", Offset = "0x427ADA4", VA = "0x427EDA4")]
			set
			{
				mItemIndex = value;
			}
		}

		[Token(Token = "0x17000DAF")]
		public int ItemId
		{
			[Token(Token = "0x6004D22")]
			[Address(RVA = "0x427EDAC", Offset = "0x427ADAC", VA = "0x427EDAC")]
			get
			{
				return mItemId;
			}
			[Token(Token = "0x6004D23")]
			[Address(RVA = "0x427EDB4", Offset = "0x427ADB4", VA = "0x427EDB4")]
			set
			{
				mItemId = value;
			}
		}

		[Token(Token = "0x17000DB0")]
		public bool IsInitHandlerCalled
		{
			[Token(Token = "0x6004D24")]
			[Address(RVA = "0x427EDBC", Offset = "0x427ADBC", VA = "0x427EDBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D25")]
			[Address(RVA = "0x427EDC4", Offset = "0x427ADC4", VA = "0x427EDC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000DB1")]
		public LoopGridView ParentGridView
		{
			[Token(Token = "0x6004D26")]
			[Address(RVA = "0x427EDD0", Offset = "0x427ADD0", VA = "0x427EDD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D27")]
			[Address(RVA = "0x427EDD8", Offset = "0x427ADD8", VA = "0x427EDD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000DB2")]
		public LoopGridViewItem PrevItem
		{
			[Token(Token = "0x6004D28")]
			[Address(RVA = "0x427EDE0", Offset = "0x427ADE0", VA = "0x427EDE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D29")]
			[Address(RVA = "0x427EDE8", Offset = "0x427ADE8", VA = "0x427EDE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000DB3")]
		public LoopGridViewItem NextItem
		{
			[Token(Token = "0x6004D2A")]
			[Address(RVA = "0x427EDF0", Offset = "0x427ADF0", VA = "0x427EDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D2B")]
			[Address(RVA = "0x427EDF8", Offset = "0x427ADF8", VA = "0x427EDF8")]
			set
			{
			}
		}

		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0x427EE00", Offset = "0x427AE00", VA = "0x427EE00")]
		public LoopGridViewItem()
		{
		}
	}
}
