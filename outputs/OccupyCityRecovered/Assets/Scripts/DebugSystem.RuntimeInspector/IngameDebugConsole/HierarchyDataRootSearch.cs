using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000012")]
	public class HierarchyDataRootSearch : HierarchyDataRoot
	{
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Transform> searchResult;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x40")]
		private readonly HierarchyDataRoot reference;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x48")]
		private string searchTerm;

		[Token(Token = "0x17000038")]
		public override string Name
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4657134", Offset = "0x4653134", VA = "0x4657134", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public override int ChildCount
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x4657154", Offset = "0x4653154", VA = "0x4657154", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x465220C", Offset = "0x464E20C", VA = "0x465220C")]
		public HierarchyDataRootSearch(RuntimeHierarchy hierarchy, HierarchyDataRoot reference) : base(hierarchy)
        {
            throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchyDataRootSearch.ctor body RVA=0x465220C; original base argument restored only");
        }

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x465719C", Offset = "0x465319C", VA = "0x465719C", Slot = "12")]
		public override void RefreshContent()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4657564", Offset = "0x4653564", VA = "0x4657564", Slot = "8")]
		public override bool Refresh()
		{
			return default;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x46575D8", Offset = "0x46535D8", VA = "0x46575D8", Slot = "9")]
		public override HierarchyDataTransform FindTransformInVisibleChildren(Transform target, int targetDepth = -1)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x46573DC", Offset = "0x46533DC", VA = "0x46573DC")]
		private void SearchTransformRecursively(Transform obj)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x46576AC", Offset = "0x46536AC", VA = "0x46576AC", Slot = "10")]
		public override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4657704", Offset = "0x4653704", VA = "0x4657704", Slot = "11")]
		public override Transform GetNearestRootOf(Transform target)
		{
			return null;
		}
	}
}
