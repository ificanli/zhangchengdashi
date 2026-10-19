using Il2CppDummyDll;
using UnityEngine;

namespace Lu.DoTween
{
	[Token(Token = "0x2000007")]
	public class LuTweenPositionDriver : LuTweenDriverBase
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _target;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _speed;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x48")]
		private bool _isLocal;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x7420108", Offset = "0x741C108", VA = "0x7420108")]
		internal LuTweenDriverBase DoMove(Vector3 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x7420184", Offset = "0x741C184", VA = "0x7420184")]
		internal LuTweenDriverBase DoLocalMove(Vector3 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x7420204", Offset = "0x741C204", VA = "0x7420204")]
		private void Update()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x7420364", Offset = "0x741C364", VA = "0x7420364")]
		public LuTweenPositionDriver()
		{
		}
	}
}
