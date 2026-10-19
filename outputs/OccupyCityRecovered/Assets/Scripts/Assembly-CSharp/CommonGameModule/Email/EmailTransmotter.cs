using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FFC")]
	public class EmailTransmotter : BaseHttpNetTransmitter
	{
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x440C0E8", Offset = "0x44080E8", VA = "0x440C0E8", Slot = "5")]
		public override void InitProtocol()
		{
		}

		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x440C394", Offset = "0x4408394", VA = "0x440C394")]
		private void GetEmail_CountResponse(string data)
		{
		}

		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x440C538", Offset = "0x4408538", VA = "0x440C538")]
		private void GetEmail_AllResponse(string data)
		{
		}

		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x440C728", Offset = "0x4408728", VA = "0x440C728")]
		private void GetEmail_NewResponse(string data)
		{
		}

		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x440C8C0", Offset = "0x44088C0", VA = "0x440C8C0")]
		private void GetEmail_State(string data)
		{
		}

		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x440C910", Offset = "0x4408910", VA = "0x440C910")]
		private void GetEmail_Remove(string data)
		{
		}

		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x440C960", Offset = "0x4408960", VA = "0x440C960")]
		public void SendHttpData(EmailRequestType type, IRequesData data)
		{
		}

		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x440C970", Offset = "0x4408970", VA = "0x440C970")]
		public EmailTransmotter()
		{
		}
	}
}
