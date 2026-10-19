using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x200000E")]
	public abstract class HierarchyData
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<HierarchyDataTransform> transformDataPool;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<List<HierarchyDataTransform>> childrenListPool;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<HierarchyDataTransform> children;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected HierarchyData parent;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected int m_index;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected int m_height;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int m_depth;

		[Token(Token = "0x17000025")]
		public abstract string Name
		{
			[Token(Token = "0x600009F")]
			get;
		}

		[Token(Token = "0x17000026")]
		public abstract bool IsActive
		{
			[Token(Token = "0x60000A0")]
			get;
		}

		[Token(Token = "0x17000027")]
		public abstract int ChildCount
		{
			[Token(Token = "0x60000A1")]
			get;
		}

		[Token(Token = "0x17000028")]
		public abstract Transform BoundTransform
		{
			[Token(Token = "0x60000A2")]
			get;
		}

		[Token(Token = "0x17000029")]
		public HierarchyDataRoot Root
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4650F08", Offset = "0x464CF08", VA = "0x4650F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public int Index
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4655B94", Offset = "0x4651B94", VA = "0x4655B94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002B")]
		public int AbsoluteIndex
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4651480", Offset = "0x464D480", VA = "0x4651480")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002C")]
		public int Height
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4655B9C", Offset = "0x4651B9C", VA = "0x4655B9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002D")]
		public int Depth
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4655BA4", Offset = "0x4651BA4", VA = "0x4655BA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002E")]
		public bool CanExpand
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x464F9CC", Offset = "0x464B9CC", VA = "0x464F9CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002F")]
		public bool IsExpanded
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x464DE38", Offset = "0x4649E38", VA = "0x464DE38")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x464DE48", Offset = "0x4649E48", VA = "0x464DE48")]
			set
			{
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4655FD4", Offset = "0x4651FD4", VA = "0x4655FD4", Slot = "8")]
		public virtual bool Refresh()
		{
			return default;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x46514A4", Offset = "0x464D4A4", VA = "0x46514A4")]
		public HierarchyData FindDataAtIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4651A84", Offset = "0x464DA84", VA = "0x4651A84")]
		public HierarchyDataTransform FindTransform(Transform target, [Optional] Transform nextInPath)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4656714", Offset = "0x4652714", VA = "0x4656714", Slot = "9")]
		public virtual HierarchyDataTransform FindTransformInVisibleChildren(Transform target, int targetDepth = -1)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		public abstract Transform GetChild(int index);

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x465470C", Offset = "0x465070C", VA = "0x465470C")]
		public int IndexOf(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4650F8C", Offset = "0x464CF8C", VA = "0x4650F8C")]
		public void GetSiblingIndexTraversalList(List<int> traversalList)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x46513A8", Offset = "0x464D3A8", VA = "0x46513A8")]
		public HierarchyData TraverseSiblingIndexList(List<int> traversalList)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4656358", Offset = "0x4652358", VA = "0x4656358")]
		private void GenerateChildItem(Transform child, int index, RuntimeHierarchy hierarchy)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x46565C4", Offset = "0x46525C4", VA = "0x46565C4")]
		private void RemoveChildItem(int index)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4655DC4", Offset = "0x4651DC4", VA = "0x4655DC4")]
		protected void PoolChildrenList()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4655BAC", Offset = "0x4651BAC", VA = "0x4655BAC")]
		protected void PopChildrenList()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x464E638", Offset = "0x464A638", VA = "0x464E638")]
		public static void ClearPool()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4656930", Offset = "0x4652930", VA = "0x4656930")]
		protected HierarchyData()
		{
		}
	}
}
