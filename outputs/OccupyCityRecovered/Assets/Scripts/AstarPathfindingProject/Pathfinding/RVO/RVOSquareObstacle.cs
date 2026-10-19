using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002DC")]
	[AddComponentMenu("")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/rvosquareobstacle.html")]
	public class RVOSquareObstacle : RVOObstacle
	{
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 size;

		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 center;

		[Token(Token = "0x170002C6")]
		protected override bool StaticObstacle
		{
			[Token(Token = "0x600120A")]
			[Address(RVA = "0x44A7830", Offset = "0x44A3830", VA = "0x44A7830", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002C7")]
		protected override bool ExecuteInEditor
		{
			[Token(Token = "0x600120B")]
			[Address(RVA = "0x44A7838", Offset = "0x44A3838", VA = "0x44A7838", Slot = "15")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002C8")]
		protected override bool LocalCoordinates
		{
			[Token(Token = "0x600120C")]
			[Address(RVA = "0x44A7840", Offset = "0x44A3840", VA = "0x44A7840", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170002C9")]
		protected override float Height
		{
			[Token(Token = "0x600120D")]
			[Address(RVA = "0x44A7848", Offset = "0x44A3848", VA = "0x44A7848", Slot = "18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600120E")]
		[Address(RVA = "0x44A7850", Offset = "0x44A3850", VA = "0x44A7850")]
		public RVOSquareObstacle()
		{
		}
	}
}
