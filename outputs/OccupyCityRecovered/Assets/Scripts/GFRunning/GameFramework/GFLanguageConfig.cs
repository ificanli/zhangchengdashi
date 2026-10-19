using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Token(Token = "0x2000356")]
	[MemoryPackable(GenerateType.Object)]
	public class GFLanguageConfig : BaseConfig, IMemoryPackable<GFLanguageConfig>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x2000357")]
		[Preserve]
		private sealed class GFLanguageConfigFormatter : MemoryPackFormatter<GFLanguageConfig>
		{
			[Token(Token = "0x60057C8")]
			[Address(RVA = "0x717176C", Offset = "0x716D76C", VA = "0x717176C", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref GFLanguageConfig value)
			{
			}

			[Token(Token = "0x60057C9")]
			[Address(RVA = "0x71717D0", Offset = "0x716D7D0", VA = "0x71717D0", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref GFLanguageConfig value)
			{
			}

			[Token(Token = "0x60057CA")]
			[Address(RVA = "0x716ECF0", Offset = "0x716ACF0", VA = "0x716ECF0")]
			public GFLanguageConfigFormatter()
			{
			}
		}

		[Token(Token = "0x170010DF")]
		public override object UniqueID
		{
			[Token(Token = "0x6005794")]
			[Address(RVA = "0x716E9C0", Offset = "0x716A9C0", VA = "0x716E9C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010E0")]
		public string id
		{
			[Token(Token = "0x6005795")]
			[Address(RVA = "0x716E9C8", Offset = "0x716A9C8", VA = "0x716E9C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005796")]
			[Address(RVA = "0x716E9D0", Offset = "0x716A9D0", VA = "0x716E9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E1")]
		public string ZH_CN
		{
			[Token(Token = "0x6005797")]
			[Address(RVA = "0x716E9D8", Offset = "0x716A9D8", VA = "0x716E9D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005798")]
			[Address(RVA = "0x716E9E0", Offset = "0x716A9E0", VA = "0x716E9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E2")]
		public string ZH_TW
		{
			[Token(Token = "0x6005799")]
			[Address(RVA = "0x716E9E8", Offset = "0x716A9E8", VA = "0x716E9E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600579A")]
			[Address(RVA = "0x716E9F0", Offset = "0x716A9F0", VA = "0x716E9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E3")]
		public string EN
		{
			[Token(Token = "0x600579B")]
			[Address(RVA = "0x716E9F8", Offset = "0x716A9F8", VA = "0x716E9F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600579C")]
			[Address(RVA = "0x716EA00", Offset = "0x716AA00", VA = "0x716EA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E4")]
		public string JA
		{
			[Token(Token = "0x600579D")]
			[Address(RVA = "0x716EA08", Offset = "0x716AA08", VA = "0x716EA08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600579E")]
			[Address(RVA = "0x716EA10", Offset = "0x716AA10", VA = "0x716EA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E5")]
		public string KO
		{
			[Token(Token = "0x600579F")]
			[Address(RVA = "0x716EA18", Offset = "0x716AA18", VA = "0x716EA18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A0")]
			[Address(RVA = "0x716EA20", Offset = "0x716AA20", VA = "0x716EA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E6")]
		public string RU
		{
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0x716EA28", Offset = "0x716AA28", VA = "0x716EA28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A2")]
			[Address(RVA = "0x716EA30", Offset = "0x716AA30", VA = "0x716EA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E7")]
		public string SP
		{
			[Token(Token = "0x60057A3")]
			[Address(RVA = "0x716EA38", Offset = "0x716AA38", VA = "0x716EA38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A4")]
			[Address(RVA = "0x716EA40", Offset = "0x716AA40", VA = "0x716EA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E8")]
		public string Fr
		{
			[Token(Token = "0x60057A5")]
			[Address(RVA = "0x716EA48", Offset = "0x716AA48", VA = "0x716EA48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A6")]
			[Address(RVA = "0x716EA50", Offset = "0x716AA50", VA = "0x716EA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010E9")]
		public string Po
		{
			[Token(Token = "0x60057A7")]
			[Address(RVA = "0x716EA58", Offset = "0x716AA58", VA = "0x716EA58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A8")]
			[Address(RVA = "0x716EA60", Offset = "0x716AA60", VA = "0x716EA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EA")]
		public string Ge
		{
			[Token(Token = "0x60057A9")]
			[Address(RVA = "0x716EA68", Offset = "0x716AA68", VA = "0x716EA68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057AA")]
			[Address(RVA = "0x716EA70", Offset = "0x716AA70", VA = "0x716EA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EB")]
		public string It
		{
			[Token(Token = "0x60057AB")]
			[Address(RVA = "0x716EA78", Offset = "0x716AA78", VA = "0x716EA78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057AC")]
			[Address(RVA = "0x716EA80", Offset = "0x716AA80", VA = "0x716EA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EC")]
		public string Ma
		{
			[Token(Token = "0x60057AD")]
			[Address(RVA = "0x716EA88", Offset = "0x716AA88", VA = "0x716EA88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057AE")]
			[Address(RVA = "0x716EA90", Offset = "0x716AA90", VA = "0x716EA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010ED")]
		public string In
		{
			[Token(Token = "0x60057AF")]
			[Address(RVA = "0x716EA98", Offset = "0x716AA98", VA = "0x716EA98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057B0")]
			[Address(RVA = "0x716EAA0", Offset = "0x716AAA0", VA = "0x716EAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EE")]
		public string Th
		{
			[Token(Token = "0x60057B1")]
			[Address(RVA = "0x716EAA8", Offset = "0x716AAA8", VA = "0x716EAA8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057B2")]
			[Address(RVA = "0x716EAB0", Offset = "0x716AAB0", VA = "0x716EAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010EF")]
		public string Vi
		{
			[Token(Token = "0x60057B3")]
			[Address(RVA = "0x716EAB8", Offset = "0x716AAB8", VA = "0x716EAB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057B4")]
			[Address(RVA = "0x716EAC0", Offset = "0x716AAC0", VA = "0x716EAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F0")]
		public string PL
		{
			[Token(Token = "0x60057B5")]
			[Address(RVA = "0x716EAC8", Offset = "0x716AAC8", VA = "0x716EAC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057B6")]
			[Address(RVA = "0x716EAD0", Offset = "0x716AAD0", VA = "0x716EAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F1")]
		public string Tr
		{
			[Token(Token = "0x60057B7")]
			[Address(RVA = "0x716EAD8", Offset = "0x716AAD8", VA = "0x716EAD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057B8")]
			[Address(RVA = "0x716EAE0", Offset = "0x716AAE0", VA = "0x716EAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F2")]
		public string Sv
		{
			[Token(Token = "0x60057B9")]
			[Address(RVA = "0x716EAE8", Offset = "0x716AAE8", VA = "0x716EAE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057BA")]
			[Address(RVA = "0x716EAF0", Offset = "0x716AAF0", VA = "0x716EAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F3")]
		public string Ro
		{
			[Token(Token = "0x60057BB")]
			[Address(RVA = "0x716EAF8", Offset = "0x716AAF8", VA = "0x716EAF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057BC")]
			[Address(RVA = "0x716EB00", Offset = "0x716AB00", VA = "0x716EB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F4")]
		public string Nl
		{
			[Token(Token = "0x60057BD")]
			[Address(RVA = "0x716EB08", Offset = "0x716AB08", VA = "0x716EB08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057BE")]
			[Address(RVA = "0x716EB10", Offset = "0x716AB10", VA = "0x716EB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F5")]
		public string Nb
		{
			[Token(Token = "0x60057BF")]
			[Address(RVA = "0x716EB18", Offset = "0x716AB18", VA = "0x716EB18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C0")]
			[Address(RVA = "0x716EB20", Offset = "0x716AB20", VA = "0x716EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010F6")]
		public string Fi
		{
			[Token(Token = "0x60057C1")]
			[Address(RVA = "0x716EB28", Offset = "0x716AB28", VA = "0x716EB28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C2")]
			[Address(RVA = "0x716EB30", Offset = "0x716AB30", VA = "0x716EB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x716EB38", Offset = "0x716AB38", VA = "0x716EB38")]
		static GFLanguageConfig()
		{
		}

		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x716EB3C", Offset = "0x716AB3C", VA = "0x716EB3C")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x716ED38", Offset = "0x716AD38", VA = "0x716ED38")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref GFLanguageConfig? value)
		{
		}

		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x716F210", Offset = "0x716B210", VA = "0x716F210")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref GFLanguageConfig? value)
		{
		}

		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x7171764", Offset = "0x716D764", VA = "0x7171764")]
		public GFLanguageConfig()
		{
		}
	}
}
