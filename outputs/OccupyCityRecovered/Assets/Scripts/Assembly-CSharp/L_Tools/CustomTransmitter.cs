using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F97")]
	public class CustomTransmitter : BaseHttpNetTransmitter
	{
		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x43B8F04", Offset = "0x43B4F04", VA = "0x43B8F04", Slot = "5")]
		public override void InitProtocol()
		{
		}

		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x43B8FB4", Offset = "0x43B4FB4", VA = "0x43B8FB4")]
		public void SendHttpData(CustomTransmitterType type, IRequesData data)
		{
		}

		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x43B8FC4", Offset = "0x43B4FC4", VA = "0x43B8FC4")]
		private void PushEventAction(string data)
		{
		}

		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x43B8FC8", Offset = "0x43B4FC8", VA = "0x43B8FC8")]
		private void PopEventAction(string data)
		{
		}

		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x43B9010", Offset = "0x43B5010", VA = "0x43B9010")]
		public void PushHttpEventData(PushEventData data)
		{
		}

		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x43B9028", Offset = "0x43B5028", VA = "0x43B9028")]
		public void PopHttpEventData(PopEventData data)
		{
		}

		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x43B9040", Offset = "0x43B5040", VA = "0x43B9040")]
		public CustomTransmitter()
		{
		}
	}
}
