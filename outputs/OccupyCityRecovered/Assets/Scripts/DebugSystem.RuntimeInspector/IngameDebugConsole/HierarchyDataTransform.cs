using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000013")]
	public class HierarchyDataTransform : HierarchyData
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x30")]
		private string cachedName;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x40")]
		private bool isSearchEntry;

		[Token(Token = "0x1700003A")]
		public override string Name
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x4657768", Offset = "0x4653768", VA = "0x4657768", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public override int ChildCount
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x4657808", Offset = "0x4653808", VA = "0x4657808", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003C")]
		public override Transform BoundTransform
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x4657894", Offset = "0x4653894", VA = "0x4657894", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public override bool IsActive
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x465789C", Offset = "0x465389C", VA = "0x465789C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4656910", Offset = "0x4652910", VA = "0x4656910")]
		public void Initialize(Transform transform, bool isSearchEntry)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x465792C", Offset = "0x465392C", VA = "0x465792C", Slot = "10")]
		public override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4656AF8", Offset = "0x4652AF8", VA = "0x4656AF8")]
		public void ResetCachedName()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4656B84", Offset = "0x4652B84", VA = "0x4656B84")]
		public void RefreshNameOf(Transform target)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4656920", Offset = "0x4652920", VA = "0x4656920")]
		public void PoolData()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x46568B0", Offset = "0x46528B0", VA = "0x46568B0")]
		public HierarchyDataTransform()
		{
		}
	}
}
