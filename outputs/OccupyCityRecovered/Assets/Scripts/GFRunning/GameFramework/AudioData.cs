using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x200031D")]
	[MemoryPackable(GenerateType.Object)]
	public class AudioData : BaseConfig, IMemoryPackable<AudioData>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x200031E")]
		[Preserve]
		private sealed class AudioDataFormatter : MemoryPackFormatter<AudioData>
		{
			[Token(Token = "0x6005480")]
			[Address(RVA = "0x7148648", Offset = "0x7144648", VA = "0x7148648", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref AudioData value)
			{
			}

			[Token(Token = "0x6005481")]
			[Address(RVA = "0x71486AC", Offset = "0x71446AC", VA = "0x71486AC", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref AudioData value)
			{
			}

			[Token(Token = "0x6005482")]
			[Address(RVA = "0x7147E44", Offset = "0x7143E44", VA = "0x7147E44")]
			public AudioDataFormatter()
			{
			}
		}

		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x14")]
		public VoiceType VoiceType;

		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x18")]
		public int Atype;

		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x1C")]
		public int Ptype;

		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x20")]
		public int StartTime;

		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0x24")]
		public int EndTime;

		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x28")]
		public float Vol;

		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x30")]
		public string ResPath;

		[Token(Token = "0x600547B")]
		[Address(RVA = "0x7147BC8", Offset = "0x7143BC8", VA = "0x7147BC8")]
		static AudioData()
		{
		}

		[Token(Token = "0x600547C")]
		[Address(RVA = "0x7147BCC", Offset = "0x7143BCC", VA = "0x7147BCC")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x600547D")]
		[Address(RVA = "0x7147E8C", Offset = "0x7143E8C", VA = "0x7147E8C")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref AudioData? value)
		{
		}

		[Token(Token = "0x600547E")]
		[Address(RVA = "0x7148038", Offset = "0x7144038", VA = "0x7148038")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref AudioData? value)
		{
		}

		[Token(Token = "0x600547F")]
		[Address(RVA = "0x7148638", Offset = "0x7144638", VA = "0x7148638")]
		public AudioData()
		{
		}
	}
}
