using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000148")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/singlenodeblocker.html")]
	public class SingleNodeBlocker : VersionedMonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x30")]
		public BlockManager manager;

		[Token(Token = "0x170001D6")]
		public GraphNode lastBlocked
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x4565690", Offset = "0x4561690", VA = "0x4565690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x4565698", Offset = "0x4561698", VA = "0x4565698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x45656A0", Offset = "0x45616A0", VA = "0x45656A0")]
		public void BlockAtCurrentPosition()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x45656CC", Offset = "0x45616CC", VA = "0x45656CC")]
		public void BlockAt(Vector3 position)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x45657C4", Offset = "0x45617C4", VA = "0x45657C4")]
		public void Block(GraphNode node)
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x4565784", Offset = "0x4561784", VA = "0x4565784")]
		public void Unblock()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x456584C", Offset = "0x456184C", VA = "0x456584C")]
		public SingleNodeBlocker()
		{
		}
	}
}
