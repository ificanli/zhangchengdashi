using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000DB8")]
	public struct LocalizedString
	{
		[Token(Token = "0x4006064")]
		[FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x4006065")]
		[FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x4006066")]
		[FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x4006067")]
		[FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x4006068")]
		[FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x6005510")]
		[Address(RVA = "0x432BB2C", Offset = "0x4327B2C", VA = "0x432BB2C")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6005511")]
		[Address(RVA = "0x432BBE8", Offset = "0x4327BE8", VA = "0x432BBE8")]
		public static implicit operator LocalizedString(string term)
		{
			return default;
		}

		[Token(Token = "0x6005512")]
		[Address(RVA = "0x432BBF4", Offset = "0x4327BF4", VA = "0x432BBF4")]
		public LocalizedString(LocalizedString str)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizedString..ctor RVA=0x432BBF4 Token=0x6005512");
}

		[Token(Token = "0x6005513")]
		[Address(RVA = "0x432BB30", Offset = "0x4327B30", VA = "0x432BB30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
