using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x200011B")]
	[AddComponentMenu("Pathfinding/Modifiers/Alternative Path Modifier")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/alternativepath.html")]
	public class AlternativePath : MonoModifier
	{
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x30")]
		public int penalty;

		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x34")]
		public int randomStep;

		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x38")]
		private List<GraphNode> prevNodes;

		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x40")]
		private int prevPenalty;

		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x48")]
		private readonly System.Random rnd;

		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x50")]
		private bool destroyed;

		[Token(Token = "0x170001C0")]
		public override int Order
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x4553958", Offset = "0x454F958", VA = "0x4553958", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x4553960", Offset = "0x454F960", VA = "0x4553960", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x4553BC0", Offset = "0x454FBC0", VA = "0x4553BC0")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x4553BCC", Offset = "0x454FBCC", VA = "0x4553BCC")]
		private void ClearOnDestroy()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x4553BD0", Offset = "0x454FBD0", VA = "0x4553BD0")]
		private void InversePrevious()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x45539F0", Offset = "0x454F9F0", VA = "0x45539F0")]
		private void ApplyNow(List<GraphNode> nodes)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x4553D30", Offset = "0x454FD30", VA = "0x4553D30")]
		public AlternativePath()
		{
		}
	}
}
