using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000BB")]
	public class MB3_ShadersThatShareTiling
	{
		[Token(Token = "0x20000BC")]
		public struct ShaderThatSharesTiling
		{
			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x0")]
			public string shadername;

			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x8")]
			public bool allPropsShareTiling;

			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x10")]
			public string tilingTexturePropName;
		}

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x0")]
		private static MB3_ShadersThatShareTiling _singleton;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, ShaderThatSharesTiling> shadersThatShareTiling;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x748313C", Offset = "0x747F13C", VA = "0x748313C")]
		public static MB3_ShadersThatShareTiling GetShadersThatShareTiling()
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x7483490", Offset = "0x747F490", VA = "0x7483490")]
		public static void GetScaleAndOffsetForTextureProp(Material m, string texturePropName, out Vector2 offset, out Vector2 scale)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_ShadersThatShareTiling.GetScaleAndOffsetForTextureProp RVA=0x7483490 Token=0x60003A0");
}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x7483198", Offset = "0x747F198", VA = "0x7483198")]
		private static void Init()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x748359C", Offset = "0x747F59C", VA = "0x748359C")]
		public MB3_ShadersThatShareTiling()
		{
		}
	}
}
