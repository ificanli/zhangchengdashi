using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000010")]
	public class HierarchyDataRootPseudoScene : HierarchyDataRoot
	{
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x38")]
		private readonly string name;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<Transform> rootObjects;

		[Token(Token = "0x17000033")]
		public override string Name
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x4656C40", Offset = "0x4652C40", VA = "0x4656C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public override int ChildCount
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x4656C48", Offset = "0x4652C48", VA = "0x4656C48", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4652FF0", Offset = "0x464EFF0", VA = "0x4652FF0")]
		public HierarchyDataRootPseudoScene(RuntimeHierarchy hierarchy, string name) : base(hierarchy)
        {
            throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchyDataRootPseudoScene.ctor body RVA=0x4652FF0; original base argument restored only");
        }

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4652358", Offset = "0x464E358", VA = "0x4652358")]
		public void AddChild(Transform child)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4654D80", Offset = "0x4650D80", VA = "0x4654D80")]
		public void InsertChild(int index, Transform child)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4652794", Offset = "0x464E794", VA = "0x4652794")]
		public void RemoveChild(Transform child)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4656C90", Offset = "0x4652C90", VA = "0x4656C90", Slot = "12")]
		public override void RefreshContent()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4656D84", Offset = "0x4652D84", VA = "0x4656D84", Slot = "10")]
		public override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4656DDC", Offset = "0x4652DDC", VA = "0x4656DDC", Slot = "11")]
		public override Transform GetNearestRootOf(Transform target)
		{
			return null;
		}
	}
}
