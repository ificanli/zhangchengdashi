using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000011")]
	public class HierarchyDataRootScene : HierarchyDataRoot
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<GameObject> rootObjects;

		[Token(Token = "0x17000035")]
		public override string Name
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x4656F08", Offset = "0x4652F08", VA = "0x4656F08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public override int ChildCount
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x4656F28", Offset = "0x4652F28", VA = "0x4656F28", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000037")]
		public Scene Scene
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x4656F70", Offset = "0x4652F70", VA = "0x4656F70")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x4656F78", Offset = "0x4652F78", VA = "0x4656F78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4652178", Offset = "0x464E178", VA = "0x4652178")]
		public HierarchyDataRootScene(RuntimeHierarchy hierarchy, Scene target) : base(hierarchy)
        {
            throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchyDataRootScene.ctor body RVA=0x4652178; original base argument restored only");
        }

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4656F80", Offset = "0x4652F80", VA = "0x4656F80", Slot = "12")]
		public override void RefreshContent()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4657018", Offset = "0x4653018", VA = "0x4657018", Slot = "10")]
		public override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x46570CC", Offset = "0x46530CC", VA = "0x46570CC", Slot = "11")]
		public override Transform GetNearestRootOf(Transform target)
		{
			return null;
		}
	}
}
