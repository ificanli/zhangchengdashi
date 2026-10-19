using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Drawing.Text
{
	[Token(Token = "0x200005D")]
	internal struct SDFLookupData
	{
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<SDFCharacter> characters;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<char, int> lookup;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x4000188")]
		public const ushort Newline = ushort.MaxValue;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x46F0FC4", Offset = "0x46ECFC4", VA = "0x46F0FC4")]
		public SDFLookupData(SDFFont font)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SDFLookupData..ctor RVA=0x46F0FC4 Token=0x60002B1");
}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x46F1214", Offset = "0x46ED214", VA = "0x46F1214")]
		public int GetIndex(char c)
		{
			return default;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x46F12C8", Offset = "0x46ED2C8", VA = "0x46F12C8")]
		public void Dispose()
		{
		}
	}
}
