using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000375")]
	[MemoryPackable(GenerateType.Object)]
	public class Lang : IMemoryPackable<Lang>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x2000376")]
		[Preserve]
		private sealed class LangFormatter : MemoryPackFormatter<Lang>
		{
			[Token(Token = "0x6005A13")]
			[Address(RVA = "0x71A0080", Offset = "0x719C080", VA = "0x71A0080", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref Lang value)
			{
			}

			[Token(Token = "0x6005A14")]
			[Address(RVA = "0x71A00E4", Offset = "0x719C0E4", VA = "0x71A00E4", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref Lang value)
			{
			}

			[Token(Token = "0x6005A15")]
			[Address(RVA = "0x719FDB0", Offset = "0x719BDB0", VA = "0x719FDB0")]
			public LangFormatter()
			{
			}
		}

		[Token(Token = "0x4001AC7")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		[Token(Token = "0x1700111E")]
		[MemoryPackIgnore]
		public string Value
		{
			[Token(Token = "0x6005A0D")]
			[Address(RVA = "0x719F7F8", Offset = "0x719B7F8", VA = "0x719F7F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0x719F7C8", Offset = "0x719B7C8", VA = "0x719F7C8")]
		[MemoryPackConstructor]
		public Lang()
		{
		}

		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0x719F7D0", Offset = "0x719B7D0", VA = "0x719F7D0")]
		public Lang(string _key)
		{
		}

		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x719F8F4", Offset = "0x719B8F4", VA = "0x719F8F4")]
		public string GetValue(ELangType type)
		{
			return null;
		}

		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x719FBF8", Offset = "0x719BBF8", VA = "0x719FBF8")]
		static Lang()
		{
		}

		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x719FBFC", Offset = "0x719BBFC", VA = "0x719FBFC")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x719FDF8", Offset = "0x719BDF8", VA = "0x719FDF8")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref Lang? value)
		{
		}

		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x719FE6C", Offset = "0x719BE6C", VA = "0x719FE6C")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref Lang? value)
		{
		}
	}
}
