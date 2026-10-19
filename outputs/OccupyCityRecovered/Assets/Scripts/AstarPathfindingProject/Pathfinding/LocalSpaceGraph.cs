using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200007A")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/localspacegraph.html")]
	public class LocalSpaceGraph : VersionedMonoBehaviour
	{
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x28")]
		private Matrix4x4 originalMatrix;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x68")]
		private MutableGraphTransform graphTransform;

		[Token(Token = "0x170000EA")]
		public GraphTransform transformation
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x4500108", Offset = "0x44FC108", VA = "0x4500108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x4500110", Offset = "0x44FC110", VA = "0x4500110")]
		private void Start()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x4500188", Offset = "0x44FC188", VA = "0x4500188")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x4500270", Offset = "0x44FC270", VA = "0x4500270")]
		public LocalSpaceGraph()
		{
		}
	}
}
