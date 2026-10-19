using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000D78")]
	public class LanguageData
	{
		[Token(Token = "0x4005F7B")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4005F7C")]
		[FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x4005F7D")]
		[FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x4005F7E")]
		[FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x6005329")]
		[Address(RVA = "0x4312524", Offset = "0x430E524", VA = "0x4312524")]
		public bool IsEnabled()
		{
			return default;
		}

		[Token(Token = "0x600532A")]
		[Address(RVA = "0x4312534", Offset = "0x430E534", VA = "0x4312534")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x600532B")]
		[Address(RVA = "0x4312548", Offset = "0x430E548", VA = "0x4312548")]
		public bool IsLoaded()
		{
			return default;
		}

		[Token(Token = "0x600532C")]
		[Address(RVA = "0x4312558", Offset = "0x430E558", VA = "0x4312558")]
		public bool CanBeUnloaded()
		{
			return default;
		}

		[Token(Token = "0x600532D")]
		[Address(RVA = "0x4312568", Offset = "0x430E568", VA = "0x4312568")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x600532E")]
		[Address(RVA = "0x4312588", Offset = "0x430E588", VA = "0x4312588")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x600532F")]
		[Address(RVA = "0x43125A8", Offset = "0x430E5A8", VA = "0x43125A8")]
		public LanguageData()
		{
		}
	}
}
