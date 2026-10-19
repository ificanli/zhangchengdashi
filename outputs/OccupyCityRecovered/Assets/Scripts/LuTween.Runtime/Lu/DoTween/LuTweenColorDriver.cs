using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Lu.DoTween
{
	[Token(Token = "0x2000006")]
	public class LuTweenColorDriver : LuTweenDriverBase
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private Color _target;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		private Vector4 _speed;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		private Image _image;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		private Vector4 _nowColor;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x68")]
		private Vector4 _targetColor;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x741FDE0", Offset = "0x741BDE0", VA = "0x741FDE0")]
		internal LuTweenDriverBase DoColor(Color target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x741FF04", Offset = "0x741BF04", VA = "0x741FF04")]
		internal LuTweenDriverBase DoFade(float targetFade, float duration)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x741FFC8", Offset = "0x741BFC8", VA = "0x741FFC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x74200A4", Offset = "0x741C0A4", VA = "0x74200A4")]
		public LuTweenColorDriver()
		{
		}
	}
}
