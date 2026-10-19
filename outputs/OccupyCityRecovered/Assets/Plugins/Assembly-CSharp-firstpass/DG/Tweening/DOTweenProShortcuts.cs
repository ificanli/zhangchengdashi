using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	[Token(Token = "0x2000008")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3CFB38C", Offset = "0x3CF738C", VA = "0x3CFB38C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3CFB3D4", Offset = "0x3CF73D4", VA = "0x3CFB3D4")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3CFB778", Offset = "0x3CF7778", VA = "0x3CFB778")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
