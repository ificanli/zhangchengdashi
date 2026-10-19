using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000E2")]
	public class ShaderTextureProperty
	{
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x18")]
		public bool isNormalMap;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x19")]
		public bool isGammaCorrected;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool isNormalDontKnow;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x748F8B0", Offset = "0x748B8B0", VA = "0x748F8B0")]
		public ShaderTextureProperty(string n, bool norm)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x748F8FC", Offset = "0x748B8FC", VA = "0x748F8FC")]
		public ShaderTextureProperty(string n, bool norm, bool isGamma, bool isNormalDontKnow)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x748F944", Offset = "0x748B944", VA = "0x748F944", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x748F9EC", Offset = "0x748B9EC", VA = "0x748F9EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x748F9F4", Offset = "0x748B9F4", VA = "0x748F9F4")]
		public static string[] GetNames(List<ShaderTextureProperty> props)
		{
			return null;
		}
	}
}
