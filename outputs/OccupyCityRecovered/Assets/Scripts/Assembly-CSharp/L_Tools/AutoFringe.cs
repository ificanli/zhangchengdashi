using Il2CppDummyDll;
using UnityEngine;

namespace L_Tools
{
	[Token(Token = "0x2000FB9")]
	public class AutoFringe : MonoBehaviour
	{
		[Token(Token = "0x4006B9E")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 offset;

		[Token(Token = "0x4006B9F")]
		[FieldOffset(Offset = "0x28")]
		private readonly Vector2 _androidOffset;

		[Token(Token = "0x4006BA0")]
		[FieldOffset(Offset = "0x0")]
		private static int WebGLFringeH;

		[Token(Token = "0x4006BA1")]
		[FieldOffset(Offset = "0x8")]
		public static FringeConfig GlobalPhoneFringe;

		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x43FA8F4", Offset = "0x43F68F4", VA = "0x43FA8F4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x43FA9C4", Offset = "0x43F69C4", VA = "0x43FA9C4")]
		public static void InitWebGLFringe()
		{
		}

		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x43FA9C8", Offset = "0x43F69C8", VA = "0x43FA9C8")]
		private static float PixelsToCanvasUnits(float pixels)
		{
			return default;
		}

		[Token(Token = "0x6005E39")]
		[Address(RVA = "0x43FA940", Offset = "0x43F6940", VA = "0x43FA940")]
		public static void GetPhoneScreenInfo()
		{
		}

		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x43FAA5C", Offset = "0x43F6A5C", VA = "0x43FAA5C")]
		public void Start()
		{
		}

		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0x43FAB84", Offset = "0x43F6B84", VA = "0x43FAB84")]
		public AutoFringe()
		{
		}
	}
}
