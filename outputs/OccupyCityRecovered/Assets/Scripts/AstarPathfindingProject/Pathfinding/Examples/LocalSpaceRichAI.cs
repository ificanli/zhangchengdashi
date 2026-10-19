using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	[Token(Token = "0x20002DD")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/localspacerichai.html")]
	public class LocalSpaceRichAI : RichAI
	{
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x210")]
		public LocalSpaceGraph graph;

		[Token(Token = "0x600120F")]
		[Address(RVA = "0x44A78E4", Offset = "0x44A38E4", VA = "0x44A78E4", Slot = "101")]
		protected override Vector3 ClampPositionToGraph(Vector3 newPosition)
		{
			return default;
		}

		[Token(Token = "0x6001210")]
		[Address(RVA = "0x44A7AE8", Offset = "0x44A3AE8", VA = "0x44A7AE8")]
		private void RefreshTransform()
		{
		}

		[Token(Token = "0x6001211")]
		[Address(RVA = "0x44A7B60", Offset = "0x44A3B60", VA = "0x44A7B60", Slot = "40")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001212")]
		[Address(RVA = "0x44A7B7C", Offset = "0x44A3B7C", VA = "0x44A7B7C", Slot = "45")]
		protected override void CalculatePathRequestEndpoints(out Vector3 start, out Vector3 end)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalSpaceRichAI.CalculatePathRequestEndpoints RVA=0x44A7B7C Token=0x6001212");
}

		[Token(Token = "0x6001213")]
		[Address(RVA = "0x44A7C08", Offset = "0x44A3C08", VA = "0x44A7C08", Slot = "39")]
		protected override void OnUpdate(float dt)
		{
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0x44A7C34", Offset = "0x44A3C34", VA = "0x44A7C34")]
		public LocalSpaceRichAI()
		{
		}
	}
}
