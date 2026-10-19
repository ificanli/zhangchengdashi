using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002D8")]
	[AddComponentMenu("")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/rvonavmesh.html")]
	public class RVONavmesh : GraphModifier
	{
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x40")]
		public float wallHeight;

		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x44A73B0", Offset = "0x44A33B0", VA = "0x44A73B0")]
		public RVONavmesh()
		{
		}
	}
}
