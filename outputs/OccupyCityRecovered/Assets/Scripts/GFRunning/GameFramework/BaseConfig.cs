using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Token(Token = "0x2000343")]
	public abstract class BaseConfig
	{
		[Serializable]
		[Token(Token = "0x2000344")]
		[MemoryPackable(GenerateType.Object)]
		public class ListArrayInt : IMemoryPackable<ListArrayInt>, IMemoryPackFormatterRegister
		{
			[Token(Token = "0x2000345")]
			[Preserve]
			private sealed class ListArrayIntFormatter : MemoryPackFormatter<ListArrayInt>
			{
				[Token(Token = "0x6005724")]
				[Address(RVA = "0x7165C30", Offset = "0x7161C30", VA = "0x7165C30", Slot = "8")]
				[Preserve]
				public override void Serialize(ref MemoryPackWriter writer, ref ListArrayInt value)
				{
				}

				[Token(Token = "0x6005725")]
				[Address(RVA = "0x7165C94", Offset = "0x7161C94", VA = "0x7165C94", Slot = "9")]
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref ListArrayInt value)
				{
				}

				[Token(Token = "0x6005726")]
				[Address(RVA = "0x716597C", Offset = "0x716197C", VA = "0x716597C")]
				public ListArrayIntFormatter()
				{
				}
			}

			[Token(Token = "0x40019C1")]
			[FieldOffset(Offset = "0x10")]
			public int[] datas;

			[Token(Token = "0x600571F")]
			[Address(RVA = "0x7165700", Offset = "0x7161700", VA = "0x7165700")]
			static ListArrayInt()
			{
			}

			[Token(Token = "0x6005720")]
			[Address(RVA = "0x7165704", Offset = "0x7161704", VA = "0x7165704")]
			[Preserve]
			public static void RegisterFormatter()
			{
			}

			[Token(Token = "0x6005721")]
			[Address(RVA = "0x71659C4", Offset = "0x71619C4", VA = "0x71659C4")]
			[Preserve]
			public static void Serialize(ref MemoryPackWriter writer, ref ListArrayInt? value)
			{
			}

			[Token(Token = "0x6005722")]
			[Address(RVA = "0x7165A68", Offset = "0x7161A68", VA = "0x7165A68")]
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref ListArrayInt? value)
			{
			}

			[Token(Token = "0x6005723")]
			[Address(RVA = "0x7165C28", Offset = "0x7161C28", VA = "0x7165C28")]
			public ListArrayInt()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000346")]
		[MemoryPackable(GenerateType.Object)]
		public class ListArrayString : IMemoryPackable<ListArrayString>, IMemoryPackFormatterRegister
		{
			[Token(Token = "0x2000347")]
			[Preserve]
			private sealed class ListArrayStringFormatter : MemoryPackFormatter<ListArrayString>
			{
				[Token(Token = "0x600572C")]
				[Address(RVA = "0x71661F4", Offset = "0x71621F4", VA = "0x71661F4", Slot = "8")]
				[Preserve]
				public override void Serialize(ref MemoryPackWriter writer, ref ListArrayString value)
				{
				}

				[Token(Token = "0x600572D")]
				[Address(RVA = "0x7166258", Offset = "0x7162258", VA = "0x7166258", Slot = "9")]
				[Preserve]
				public override void Deserialize(ref MemoryPackReader reader, ref ListArrayString value)
				{
				}

				[Token(Token = "0x600572E")]
				[Address(RVA = "0x7165F74", Offset = "0x7161F74", VA = "0x7165F74")]
				public ListArrayStringFormatter()
				{
				}
			}

			[Token(Token = "0x40019C2")]
			[FieldOffset(Offset = "0x10")]
			public string[] datas;

			[Token(Token = "0x6005727")]
			[Address(RVA = "0x7165CF8", Offset = "0x7161CF8", VA = "0x7165CF8")]
			static ListArrayString()
			{
			}

			[Token(Token = "0x6005728")]
			[Address(RVA = "0x7165CFC", Offset = "0x7161CFC", VA = "0x7165CFC")]
			[Preserve]
			public static void RegisterFormatter()
			{
			}

			[Token(Token = "0x6005729")]
			[Address(RVA = "0x7165FBC", Offset = "0x7161FBC", VA = "0x7165FBC")]
			[Preserve]
			public static void Serialize(ref MemoryPackWriter writer, ref ListArrayString? value)
			{
			}

			[Token(Token = "0x600572A")]
			[Address(RVA = "0x7166044", Offset = "0x7162044", VA = "0x7166044")]
			[Preserve]
			public static void Deserialize(ref MemoryPackReader reader, ref ListArrayString? value)
			{
			}

			[Token(Token = "0x600572B")]
			[Address(RVA = "0x71661EC", Offset = "0x71621EC", VA = "0x71661EC")]
			public ListArrayString()
			{
			}
		}

		[Token(Token = "0x170010DD")]
		[MemoryPackIgnore]
		public virtual object UniqueID
		{
			[Token(Token = "0x600571D")]
			[Address(RVA = "0x71656C0", Offset = "0x71616C0", VA = "0x71656C0", Slot = "4")]
			get
			{
			throw new NotImplementedException();
		}
		}

		[Token(Token = "0x600571E")]
		[Address(RVA = "0x71656F8", Offset = "0x71616F8", VA = "0x71656F8")]
		protected BaseConfig()
		{
		}
	}
}
