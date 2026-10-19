using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000250")]
	[Preserve]
	internal class SerializableAnimationCurve
	{
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x10")]
		public WrapMode preWrapMode;

		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x14")]
		public WrapMode postWrapMode;

		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x18")]
		public Keyframe[] keys;

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x4482FF8", Offset = "0x447EFF8", VA = "0x4482FF8")]
		public SerializableAnimationCurve()
		{
		}
	}
}
