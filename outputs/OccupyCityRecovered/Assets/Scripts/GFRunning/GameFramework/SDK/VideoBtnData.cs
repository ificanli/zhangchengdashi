using System;
using DBTSDK;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework.SDK
{
	[Serializable]
	[Token(Token = "0x20004E4")]
	[MemoryPackable(GenerateType.Object)]
	public class VideoBtnData : BaseConfig, IMemoryPackable<VideoBtnData>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x20004E5")]
		[Preserve]
		private sealed class VideoBtnDataFormatter : MemoryPackFormatter<VideoBtnData>
		{
			[Token(Token = "0x600748B")]
			[Address(RVA = "0x72FB998", Offset = "0x72F7998", VA = "0x72FB998", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref VideoBtnData value)
			{
			}

			[Token(Token = "0x600748C")]
			[Address(RVA = "0x72FB9FC", Offset = "0x72F79FC", VA = "0x72FB9FC", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref VideoBtnData value)
			{
			}

			[Token(Token = "0x600748D")]
			[Address(RVA = "0x72FAED0", Offset = "0x72F6ED0", VA = "0x72FAED0")]
			public VideoBtnDataFormatter()
			{
			}
		}

		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4001FF9")]
		[FieldOffset(Offset = "0x14")]
		public VideFlag VideFlag;

		[Token(Token = "0x4001FFA")]
		[FieldOffset(Offset = "0x18")]
		public BtnShowType showType;

		[Token(Token = "0x4001FFB")]
		[FieldOffset(Offset = "0x1C")]
		public int AudioId;

		[Token(Token = "0x4001FFC")]
		[FieldOffset(Offset = "0x20")]
		public string Video_param1;

		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0x28")]
		public string Video_param2;

		[Token(Token = "0x4001FFE")]
		[FieldOffset(Offset = "0x30")]
		public string ReportLable;

		[Token(Token = "0x1700125D")]
		public VideFlag videFlag
		{
			[Token(Token = "0x6007485")]
			[Address(RVA = "0x72FAB88", Offset = "0x72F6B88", VA = "0x72FAB88")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6007486")]
		[Address(RVA = "0x72FAB90", Offset = "0x72F6B90", VA = "0x72FAB90")]
		static VideoBtnData()
		{
		}

		[Token(Token = "0x6007487")]
		[Address(RVA = "0x72FAB94", Offset = "0x72F6B94", VA = "0x72FAB94")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6007488")]
		[Address(RVA = "0x72FAF18", Offset = "0x72F6F18", VA = "0x72FAF18")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref VideoBtnData? value)
		{
		}

		[Token(Token = "0x6007489")]
		[Address(RVA = "0x72FB128", Offset = "0x72F7128", VA = "0x72FB128")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref VideoBtnData? value)
		{
		}

		[Token(Token = "0x600748A")]
		[Address(RVA = "0x72FB990", Offset = "0x72F7990", VA = "0x72FB990")]
		public VideoBtnData()
		{
		}
	}
}
