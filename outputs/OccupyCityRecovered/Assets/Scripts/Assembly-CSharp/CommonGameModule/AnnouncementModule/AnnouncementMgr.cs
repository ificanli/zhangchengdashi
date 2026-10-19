using System.Collections.Generic;
using Il2CppDummyDll;
using L_Tools;

namespace CommonGameModule.AnnouncementModule
{
	[Token(Token = "0x2000FD7")]
	public class AnnouncementMgr : Singleton<AnnouncementMgr>
	{
		[Token(Token = "0x4006BFF")]
		[FieldOffset(Offset = "0x10")]
		private AnnouncementTransmotter Transmotter;

		[Token(Token = "0x4006C00")]
		private const string ClientVersionKey = "AnnouncemenClientVersion";

		[Token(Token = "0x4006C01")]
		private const string ClientCacheKey = "AnnouncemenClientCache";

		[Token(Token = "0x4006C02")]
		private const string ShowNoticeVersionKey = "AnnouncemenShowNoticeVersion";

		[Token(Token = "0x4006C03")]
		[FieldOffset(Offset = "0x18")]
		private NoticeResponse noticeResponse;

		[Token(Token = "0x4006C04")]
		[FieldOffset(Offset = "0x20")]
		public bool isRequesFinish;

		[Token(Token = "0x17000FA8")]
		private long clientVersion
		{
			[Token(Token = "0x6005EDE")]
			[Address(RVA = "0x43FF494", Offset = "0x43FB494", VA = "0x43FF494")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EDF")]
			[Address(RVA = "0x43FF534", Offset = "0x43FB534", VA = "0x43FF534")]
			set
			{
			}
		}

		[Token(Token = "0x17000FA9")]
		private long ShowNoticeVersion
		{
			[Token(Token = "0x6005EE0")]
			[Address(RVA = "0x43FF5BC", Offset = "0x43FB5BC", VA = "0x43FF5BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EE1")]
			[Address(RVA = "0x43FF65C", Offset = "0x43FB65C", VA = "0x43FF65C")]
			set
			{
			}
		}

		[Token(Token = "0x17000FAA")]
		private string clientCache
		{
			[Token(Token = "0x6005EE2")]
			[Address(RVA = "0x43FF6E4", Offset = "0x43FB6E4", VA = "0x43FF6E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005EE3")]
			[Address(RVA = "0x43FF764", Offset = "0x43FB764", VA = "0x43FF764")]
			set
			{
			}
		}

		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x43FF418", Offset = "0x43FB418", VA = "0x43FF418")]
		public List<NoticeDO> GetAllNotice()
		{
			return null;
		}

		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x43FF7D4", Offset = "0x43FB7D4", VA = "0x43FF7D4")]
		public void UpdateShowNoticeVersion()
		{
		}

		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x43FF7F0", Offset = "0x43FB7F0", VA = "0x43FF7F0")]
		public void Init()
		{
		}

		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x43FF8B8", Offset = "0x43FB8B8", VA = "0x43FF8B8")]
		private void RequestNotice()
		{
		}

		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x43FF1B0", Offset = "0x43FB1B0", VA = "0x43FF1B0")]
		public void OnGetNotice(string str)
		{
		}

		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x43FF990", Offset = "0x43FB990", VA = "0x43FF990")]
		public bool HasNewNotice()
		{
			return default;
		}

		[Token(Token = "0x6005EE9")]
		[Address(RVA = "0x43FF9BC", Offset = "0x43FB9BC", VA = "0x43FF9BC")]
		public AnnouncementMgr()
		{
		}
	}
}
