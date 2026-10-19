using Il2CppDummyDll;
using UnityEngine;

namespace Lu.DoTween
{
	[Token(Token = "0x2000009")]
	public class LuTweenScaleDriver : LuTweenDriverBase
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _target;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _speed;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7420888", Offset = "0x741C888", VA = "0x7420888")]
		internal LuTweenDriverBase DoScale(Vector3 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7420900", Offset = "0x741C900", VA = "0x7420900")]
		private void Update()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7420A00", Offset = "0x741CA00", VA = "0x7420A00")]
		public LuTweenScaleDriver()
		{
		}
	}
}
