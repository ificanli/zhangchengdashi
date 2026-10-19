using Il2CppDummyDll;
using UnityEngine;

namespace Lu.DoTween
{
	[Token(Token = "0x2000005")]
	public class LuTweenAnchorPosDriver : LuTweenDriverBase
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 _target;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 _speed;

		[Token(Token = "0x17000001")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x741FB88", Offset = "0x741BB88", VA = "0x741FB88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x741FC18", Offset = "0x741BC18", VA = "0x741FC18")]
		internal LuTweenDriverBase DoAnchorPos(Vector2 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x741FC78", Offset = "0x741BC78", VA = "0x741FC78")]
		internal LuTweenDriverBase DoAnchorPosY(float targetY, float duration)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x741FCBC", Offset = "0x741BCBC", VA = "0x741FCBC")]
		internal LuTweenDriverBase DoAnchorPosX(float targetX, float duration)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x741FD00", Offset = "0x741BD00", VA = "0x741FD00")]
		private void Update()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x741FDD8", Offset = "0x741BDD8", VA = "0x741FDD8")]
		public LuTweenAnchorPosDriver()
		{
		}
	}
}
