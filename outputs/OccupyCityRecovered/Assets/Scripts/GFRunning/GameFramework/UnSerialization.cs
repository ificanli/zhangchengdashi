using System.Collections.Generic;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Token(Token = "0x2000350")]
	[MemoryPackable(GenerateType.Object)]
	public class UnSerialization<T> : IMemoryPackable<UnSerialization<T>>, IMemoryPackFormatterRegister where T : BaseConfig
	{
		[Token(Token = "0x2000351")]
		[Preserve]
		private sealed class UnSerializationFormatter : MemoryPackFormatter<UnSerialization<T>>
		{
			[Token(Token = "0x6005789")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref UnSerialization<T> value)
			{
			}

			[Token(Token = "0x600578A")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref UnSerialization<T> value)
			{
			}

			[Token(Token = "0x600578B")]
			public UnSerializationFormatter()
			{
			}
		}

		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x0")]
		public List<T> Datas;

		[Token(Token = "0x6005783")]
		public void Add(T t)
		{
		}

		[Token(Token = "0x6005784")]
		static UnSerialization()
		{
		}

		[Token(Token = "0x6005785")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6005786")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref UnSerialization<T>? value)
		{
		}

		[Token(Token = "0x6005787")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref UnSerialization<T>? value)
		{
		}

		[Token(Token = "0x6005788")]
		public UnSerialization()
		{
		}
	}
}
