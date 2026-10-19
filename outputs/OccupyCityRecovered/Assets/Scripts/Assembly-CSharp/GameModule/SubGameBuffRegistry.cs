using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000399")]
	public static class SubGameBuffRegistry
	{
		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, Func<SubGameBuffBase>> Creators;

		[Token(Token = "0x600106B")]
		[Address(RVA = "0x3D9E038", Offset = "0x3D9A038", VA = "0x3D9E038")]
		public static SubGameBuffBase Create(int buffId)
		{
			return null;
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x3D9DFB8", Offset = "0x3D99FB8", VA = "0x3D9DFB8")]
		public static bool Contains(int buffId)
		{
			return default;
		}
	}
}
