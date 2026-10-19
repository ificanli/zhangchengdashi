using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200013B")]
	public class FloodPathTracer : ABPath
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected FloodPath flood;

		[Token(Token = "0x170001D0")]
		protected override bool hasEndPoint
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x45623C0", Offset = "0x455E3C0", VA = "0x45623C0", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x45623C8", Offset = "0x455E3C8", VA = "0x45623C8")]
		public FloodPathTracer()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x45623CC", Offset = "0x455E3CC", VA = "0x45623CC")]
		public static FloodPathTracer Construct(Vector3 start, FloodPath flood, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x4562488", Offset = "0x455E488", VA = "0x4562488")]
		protected void Setup(Vector3 start, FloodPath flood, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x4562528", Offset = "0x455E528", VA = "0x4562528", Slot = "16")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4562540", Offset = "0x455E540", VA = "0x4562540", Slot = "20")]
		protected override void Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x45627F4", Offset = "0x455E7F4", VA = "0x45627F4", Slot = "25")]
		protected override void CalculateStep(ref SearchContext ctx, long targetTick)
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x4562854", Offset = "0x455E854", VA = "0x4562854", Slot = "17")]
		protected override void Trace(ref SearchContext ctx, uint fromPathNodeIndex)
		{
		}
	}
}
