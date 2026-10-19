using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x200011C")]
	[AddComponentMenu("Pathfinding/Modifiers/Funnel Modifier")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/funnelmodifier.html")]
	public class FunnelModifier : MonoModifier
	{
		[Token(Token = "0x200011D")]
		public enum FunnelQuality
		{
			[Token(Token = "0x4000619")]
			Medium = 0,
			[Token(Token = "0x400061A")]
			High = 1
		}

		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x30")]
		public FunnelQuality quality;

		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x34")]
		public bool splitAtEveryPortal;

		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x35")]
		public bool accountForGridPenalties;

		[Token(Token = "0x170001C1")]
		public override int Order
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x4553DE4", Offset = "0x454FDE4", VA = "0x4553DE4", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x4553DEC", Offset = "0x454FDEC", VA = "0x4553DEC", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x4554374", Offset = "0x4550374", VA = "0x4554374")]
		public FunnelModifier()
		{
		}
	}
}
