using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA8")]
	public class UserTutorialData
	{
		[Token(Token = "0x17000F2C")]
		public string Id
		{
			[Token(Token = "0x60058FD")]
			[Address(RVA = "0x4367F24", Offset = "0x4363F24", VA = "0x4367F24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60058FE")]
			[Address(RVA = "0x4367F2C", Offset = "0x4363F2C", VA = "0x4367F2C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000F2D")]
		public bool IsComplete
		{
			[Token(Token = "0x60058FF")]
			[Address(RVA = "0x4367F34", Offset = "0x4363F34", VA = "0x4367F34")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6005900")]
			[Address(RVA = "0x4367F3C", Offset = "0x4363F3C", VA = "0x4367F3C")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x6005901")]
		[Address(RVA = "0x4367F48", Offset = "0x4363F48", VA = "0x4367F48")]
		public UserTutorialData()
		{
		}

		[Token(Token = "0x6005902")]
		[Address(RVA = "0x4367FA8", Offset = "0x4363FA8", VA = "0x4367FA8")]
		public UserTutorialData(GlobalTutorialInfo info)
		{
		}

		[Token(Token = "0x6005903")]
		[Address(RVA = "0x4367FE0", Offset = "0x4363FE0", VA = "0x4367FE0")]
		public UserTutorialData(string id, bool isComplete)
		{
		}

		[Token(Token = "0x6005904")]
		[Address(RVA = "0x4368014", Offset = "0x4364014", VA = "0x4368014", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6005905")]
		[Address(RVA = "0x43680CC", Offset = "0x43640CC", VA = "0x43680CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6005906")]
		[Address(RVA = "0x4368148", Offset = "0x4364148", VA = "0x4368148", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
