using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x200000F")]
	public abstract class HierarchyDataRoot : HierarchyData
	{
		[Token(Token = "0x17000030")]
		public override Transform BoundTransform
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x4656A24", Offset = "0x4652A24", VA = "0x4656A24", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public override bool IsActive
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x4656A2C", Offset = "0x4652A2C", VA = "0x4656A2C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000032")]
		public RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4656A34", Offset = "0x4652A34", VA = "0x4656A34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x4656A3C", Offset = "0x4652A3C", VA = "0x4656A3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4656A44", Offset = "0x4652A44", VA = "0x4656A44")]
		protected HierarchyDataRoot(RuntimeHierarchy hierarchy)
		{
		}

		[Token(Token = "0x60000BF")]
		public abstract Transform GetNearestRootOf(Transform target);

		[Token(Token = "0x60000C0")]
		public abstract void RefreshContent();

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4656ABC", Offset = "0x4652ABC", VA = "0x4656ABC", Slot = "8")]
		public override bool Refresh()
		{
			return default;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4656ADC", Offset = "0x4652ADC", VA = "0x4656ADC", Slot = "9")]
		public override HierarchyDataTransform FindTransformInVisibleChildren(Transform target, int targetDepth = -1)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x464F488", Offset = "0x464B488", VA = "0x464F488")]
		public void ResetCachedNames()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x464FCD8", Offset = "0x464BCD8", VA = "0x464FCD8")]
		public void RefreshNameOf(Transform target)
		{
		}
	}
}
