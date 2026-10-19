using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000084")]
	[AddComponentMenu("Pathfinding/Link")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/nodelink.html")]
	public class NodeLink : GraphModifier
	{
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x40")]
		public Transform end;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x48")]
		public float costFactor;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x4C")]
		public bool oneWay;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x4D")]
		public bool deleteConnection;

		[Token(Token = "0x170000EC")]
		public Transform Start
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x45059F0", Offset = "0x45019F0", VA = "0x45059F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public Transform End
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x45059F8", Offset = "0x45019F8", VA = "0x45059F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x4505A00", Offset = "0x4501A00", VA = "0x4505A00", Slot = "25")]
		public override void OnGraphsPostUpdateBeforeAreaRecalculation()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x4505A10", Offset = "0x4501A10", VA = "0x4505A10")]
		public static void DrawArch(Vector3 a, Vector3 b, Vector3 up, Color color)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x4505D5C", Offset = "0x4501D5C", VA = "0x4505D5C", Slot = "26")]
		public virtual void Apply()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x4506020", Offset = "0x4502020", VA = "0x4506020", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x45061A4", Offset = "0x45021A4", VA = "0x45061A4")]
		public NodeLink()
		{
		}
	}
}
