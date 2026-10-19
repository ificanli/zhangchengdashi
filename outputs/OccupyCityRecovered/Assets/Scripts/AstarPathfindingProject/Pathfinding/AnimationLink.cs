using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200006B")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/animationlink.html")]
	public class AnimationLink : NodeLink2
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public class LinkClip
		{
			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x10")]
			public AnimationClip clip;

			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 velocity;

			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x24")]
			public int loopCount;

			[Token(Token = "0x170000E6")]
			public string name
			{
				[Token(Token = "0x6000415")]
				[Address(RVA = "0x44FAC08", Offset = "0x44F6C08", VA = "0x44FAC08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x44FACA4", Offset = "0x44F6CA4", VA = "0x44FACA4")]
			public LinkClip()
			{
			}
		}

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x68")]
		public string clip;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x70")]
		public float animSpeed;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x74")]
		public bool reverseAnim;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x78")]
		public GameObject referenceMesh;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x80")]
		public LinkClip[] sequence;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x88")]
		public string boneRoot;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x44F9804", Offset = "0x44F5804", VA = "0x44F9804")]
		private static Transform SearchRec(Transform tr, string name)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x44F98F8", Offset = "0x44F58F8", VA = "0x44F98F8")]
		public void CalculateOffsets(List<Vector3> trace, out Vector3 endPosition)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AnimationLink.CalculateOffsets RVA=0x44F98F8 Token=0x6000412");
}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x44FA07C", Offset = "0x44F607C", VA = "0x44FA07C", Slot = "6")]
		public override void DrawGizmos()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x44FAB04", Offset = "0x44F6B04", VA = "0x44FAB04")]
		public AnimationLink()
		{
		}
	}
}
