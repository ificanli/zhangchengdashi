using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.AnnouncementModule
{
	[Token(Token = "0x2000FD6")]
	public class AnnouncementTransmotter : BaseHttpNetTransmitter
	{
		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x43FF040", Offset = "0x43FB040", VA = "0x43FF040", Slot = "5")]
		public override void InitProtocol()
		{
		}

		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x43FF104", Offset = "0x43FB104", VA = "0x43FF104")]
		private void GetNoticeResponse(string str)
		{
		}

		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x43FF400", Offset = "0x43FB400", VA = "0x43FF400")]
		public void SendHttpData(NoticeType type, IRequesData data)
		{
		}

		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x43FF410", Offset = "0x43FB410", VA = "0x43FF410")]
		public AnnouncementTransmotter()
		{
		}
	}
}
