using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000369")]
	[MemoryPackable(GenerateType.Object)]
	public class EffectData : BaseConfig, IMemoryPackable<EffectData>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x200036A")]
		[Preserve]
		private sealed class EffectDataFormatter : MemoryPackFormatter<EffectData>
		{
			[Token(Token = "0x600591B")]
			[Address(RVA = "0x7180DB4", Offset = "0x717CDB4", VA = "0x7180DB4", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref EffectData value)
			{
			}

			[Token(Token = "0x600591C")]
			[Address(RVA = "0x7180E18", Offset = "0x717CE18", VA = "0x7180E18", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref EffectData value)
			{
			}

			[Token(Token = "0x600591D")]
			[Address(RVA = "0x71807A8", Offset = "0x717C7A8", VA = "0x71807A8")]
			public EffectDataFormatter()
			{
			}
		}

		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x14")]
		public int type;

		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x18")]
		public string res;

		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x20")]
		public double duration;

		[Token(Token = "0x6005916")]
		[Address(RVA = "0x71805F0", Offset = "0x717C5F0", VA = "0x71805F0")]
		static EffectData()
		{
		}

		[Token(Token = "0x6005917")]
		[Address(RVA = "0x71805F4", Offset = "0x717C5F4", VA = "0x71805F4")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6005918")]
		[Address(RVA = "0x71807F0", Offset = "0x717C7F0", VA = "0x71807F0")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref EffectData? value)
		{
		}

		[Token(Token = "0x6005919")]
		[Address(RVA = "0x71808BC", Offset = "0x717C8BC", VA = "0x71808BC")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref EffectData? value)
		{
		}

		[Token(Token = "0x600591A")]
		[Address(RVA = "0x7180DAC", Offset = "0x717CDAC", VA = "0x7180DAC")]
		public EffectData()
		{
		}
	}
}
