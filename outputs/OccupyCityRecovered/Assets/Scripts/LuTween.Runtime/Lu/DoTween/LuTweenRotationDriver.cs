using Il2CppDummyDll;
using UnityEngine;

namespace Lu.DoTween
{
	[Token(Token = "0x2000008")]
	public class LuTweenRotationDriver : LuTweenDriverBase
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _target;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _speed;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x48")]
		private bool _isLocal;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x742036C", Offset = "0x741C36C", VA = "0x742036C")]
		internal LuTweenDriverBase DoEuler(Vector3 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x74203E8", Offset = "0x741C3E8", VA = "0x74203E8")]
		internal LuTweenDriverBase DoEulerX(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x742045C", Offset = "0x741C45C", VA = "0x742045C")]
		internal LuTweenDriverBase DoEulerY(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x74204D0", Offset = "0x741C4D0", VA = "0x74204D0")]
		internal LuTweenDriverBase DoEulerZ(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7420544", Offset = "0x741C544", VA = "0x7420544")]
		internal LuTweenDriverBase DoLocalEuler(Vector3 target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x74205C4", Offset = "0x741C5C4", VA = "0x74205C4")]
		internal LuTweenDriverBase DoLocalEulerX(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7420638", Offset = "0x741C638", VA = "0x7420638")]
		internal LuTweenDriverBase DoLocalEulerY(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x74206AC", Offset = "0x741C6AC", VA = "0x74206AC")]
		internal LuTweenDriverBase DoLocalEulerZ(float target, float duration)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7420720", Offset = "0x741C720", VA = "0x7420720")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7420880", Offset = "0x741C880", VA = "0x7420880")]
		public LuTweenRotationDriver()
		{
		}
	}
}
