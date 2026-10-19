using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000377")]
	[MemoryPackable(GenerateType.Object)]
	public class LangData : BaseConfig, IMemoryPackable<LangData>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x2000378")]
		[Preserve]
		private sealed class LangDataFormatter : MemoryPackFormatter<LangData>
		{
			[Token(Token = "0x6005A1C")]
			[Address(RVA = "0x71A35E0", Offset = "0x719F5E0", VA = "0x71A35E0", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref LangData value)
			{
			}

			[Token(Token = "0x6005A1D")]
			[Address(RVA = "0x71A3644", Offset = "0x719F644", VA = "0x71A3644", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref LangData value)
			{
			}

			[Token(Token = "0x6005A1E")]
			[Address(RVA = "0x71A0308", Offset = "0x719C308", VA = "0x71A0308")]
			public LangDataFormatter()
			{
			}
		}

		[Token(Token = "0x4001AC8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4001AC9")]
		[FieldOffset(Offset = "0x18")]
		public string zh_cn;

		[Token(Token = "0x4001ACA")]
		[FieldOffset(Offset = "0x20")]
		public string zh_tw;

		[Token(Token = "0x4001ACB")]
		[FieldOffset(Offset = "0x28")]
		public string en;

		[Token(Token = "0x4001ACC")]
		[FieldOffset(Offset = "0x30")]
		public string ja;

		[Token(Token = "0x4001ACD")]
		[FieldOffset(Offset = "0x38")]
		public string ko;

		[Token(Token = "0x4001ACE")]
		[FieldOffset(Offset = "0x40")]
		public string ru;

		[Token(Token = "0x4001ACF")]
		[FieldOffset(Offset = "0x48")]
		public string sp;

		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x50")]
		public string fr;

		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x58")]
		public string po;

		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x60")]
		public string ge;

		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x68")]
		public string ar;

		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x70")]
		public string It;

		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x78")]
		public string Ma;

		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x80")]
		public string Vi;

		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x88")]
		public string In;

		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x90")]
		public string Th;

		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x98")]
		public string PL;

		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0xA0")]
		public string Tr;

		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0xA8")]
		public string Sv;

		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0xB0")]
		public string Ro;

		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0xB8")]
		public string Nl;

		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0xC0")]
		public string Nb;

		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0xC8")]
		public string Fi;

		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0xD0")]
		public string Hu;

		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0xD8")]
		public string Cs;

		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0xE0")]
		public string Hi;

		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0xE8")]
		public string Bn;

		[Token(Token = "0x1700111F")]
		public override object UniqueID
		{
			[Token(Token = "0x6005A16")]
			[Address(RVA = "0x71A0148", Offset = "0x719C148", VA = "0x71A0148", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x71A0150", Offset = "0x719C150", VA = "0x71A0150")]
		static LangData()
		{
		}

		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x71A0154", Offset = "0x719C154", VA = "0x71A0154")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x71A0350", Offset = "0x719C350", VA = "0x71A0350")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref LangData? value)
		{
		}

		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x71A0808", Offset = "0x719C808", VA = "0x71A0808")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref LangData? value)
		{
		}

		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0x71A355C", Offset = "0x719F55C", VA = "0x71A355C")]
		public LangData()
		{
		}
	}
}
