using System;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x2000040")]
	public class FeiShuOrderGetChatID : FeiShuOrderTokenBase
	{
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x30")]
		private readonly string groupName;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x38")]
		private Action<string> onGetChatIDSuccess;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4642550", Offset = "0x463E550", VA = "0x4642550")]
		public FeiShuOrderGetChatID(string appId, string appSecret, string groupName, Action<string> onGetChatIDSuccess) : base(appId, appSecret)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeiShuOrderGetChatID..ctor RVA=0x4642550 Token=0x06000108; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x46425BC", Offset = "0x463E5BC", VA = "0x46425BC", Slot = "6")]
		protected override void OnGetTokenSuccess(string token)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x464266C", Offset = "0x463E66C", VA = "0x464266C")]
		private void OnGetChatIDSuccess(string chatId)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4642688", Offset = "0x463E688", VA = "0x4642688", Slot = "5")]
		protected override void OnRequestError(string error)
		{
		}
	}
}
