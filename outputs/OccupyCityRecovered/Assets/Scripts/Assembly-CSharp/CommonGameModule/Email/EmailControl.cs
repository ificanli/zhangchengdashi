using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FFD")]
	public class EmailControl : ControlBase<EmailControl>, IControl
	{
		[Token(Token = "0x2000FFE")]
		public class mail_query_count_data
		{
			[Token(Token = "0x4006CA2")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			[Token(Token = "0x6005FED")]
			[Address(RVA = "0x440D934", Offset = "0x4409934", VA = "0x440D934")]
			public mail_query_count_data()
			{
			}
		}

		[Token(Token = "0x2000FFF")]
		public class mail_query_list_data
		{
			[Token(Token = "0x4006CA3")]
			[FieldOffset(Offset = "0x10")]
			public int total;

			[Token(Token = "0x4006CA4")]
			[FieldOffset(Offset = "0x18")]
			public List<EmailData> list;

			[Token(Token = "0x6005FEE")]
			[Address(RVA = "0x440D93C", Offset = "0x440993C", VA = "0x440D93C")]
			public mail_query_list_data()
			{
			}
		}

		[Token(Token = "0x4006C96")]
		[FieldOffset(Offset = "0x18")]
		private string addres;

		[Token(Token = "0x4006C97")]
		[FieldOffset(Offset = "0x20")]
		private string Tag;

		[Token(Token = "0x4006C98")]
		[FieldOffset(Offset = "0x28")]
		private CommonGameModuleEmailManager emailManager;

		[Token(Token = "0x4006C99")]
		[FieldOffset(Offset = "0x30")]
		private string EmailUserID;

		[Token(Token = "0x4006C9A")]
		[FieldOffset(Offset = "0x38")]
		internal int EmailLimit;

		[Token(Token = "0x4006C9B")]
		[FieldOffset(Offset = "0x3C")]
		private bool IsInit;

		[Token(Token = "0x4006C9C")]
		[FieldOffset(Offset = "0x40")]
		private EmailTransmotter Transmotter;

		[Token(Token = "0x4006C9D")]
		[FieldOffset(Offset = "0x48")]
		private EmailBaseModule emailBaseModule;

		[Token(Token = "0x4006C9E")]
		[FieldOffset(Offset = "0x50")]
		private float timer_query_new;

		[Token(Token = "0x4006C9F")]
		[FieldOffset(Offset = "0x54")]
		private float interval;

		[Token(Token = "0x4006CA0")]
		[FieldOffset(Offset = "0x58")]
		private bool pause;

		[Token(Token = "0x4006CA1")]
		[FieldOffset(Offset = "0x0")]
		private static DateTime BaseTime;

		[Token(Token = "0x17000FB8")]
		public bool ActiveUpdate
		{
			[Token(Token = "0x6005FD6")]
			[Address(RVA = "0x440C978", Offset = "0x4408978", VA = "0x440C978", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005FD7")]
			[Address(RVA = "0x440C980", Offset = "0x4408980", VA = "0x440C980", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x440C98C", Offset = "0x440898C", VA = "0x440C98C", Slot = "6")]
		public void OnInit()
		{
		}

		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0x440CA50", Offset = "0x4408A50", VA = "0x440CA50", Slot = "8")]
		public void OnDispose()
		{
		}

		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0x440CA98", Offset = "0x4408A98", VA = "0x440CA98")]
		public void SetUp(EmailBaseModule emailModule, bool UseXXX)
		{
		}

		[Token(Token = "0x6005FDB")]
		public T GetEmailModule<T>() where T : EmailBaseModule
		{
			return null;
		}

		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0x440C054", Offset = "0x4408054", VA = "0x440C054")]
		public void Pause()
		{
		}

		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0x440C0B0", Offset = "0x44080B0", VA = "0x440C0B0")]
		public void Continue()
		{
		}

		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0x440D04C", Offset = "0x440904C", VA = "0x440D04C", Slot = "7")]
		public void Updata(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x440CD4C", Offset = "0x4408D4C", VA = "0x440CD4C")]
		private void RequestMailCount()
		{
		}

		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0x440D118", Offset = "0x4409118", VA = "0x440D118")]
		private void RequestMail_query_list(int index, int count)
		{
		}

		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0x440D094", Offset = "0x4409094", VA = "0x440D094")]
		private void RequestMail_query_new()
		{
		}

		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0x440BE9C", Offset = "0x4407E9C", VA = "0x440BE9C")]
		public void SetEmailReadState(EmailData emailData)
		{
		}

		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0x440D1A4", Offset = "0x44091A4", VA = "0x440D1A4")]
		internal void RemoveEmail(List<long> remove_list)
		{
		}

		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0x440C3E8", Offset = "0x44083E8", VA = "0x440C3E8")]
		public void OnGetMailCount(string str)
		{
		}

		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x440C58C", Offset = "0x440858C", VA = "0x440C58C")]
		public void OnGetMail_query_list(string str)
		{
		}

		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x440C77C", Offset = "0x440877C", VA = "0x440C77C")]
		public void OnGetMail_query_new(string str)
		{
		}

		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x440BE2C", Offset = "0x4407E2C", VA = "0x440BE2C")]
		public EmailTotalData GetEmailTotalData()
		{
			return null;
		}

		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x440C90C", Offset = "0x440890C", VA = "0x440C90C")]
		public void OnMail_state(string str)
		{
		}

		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x440C95C", Offset = "0x440895C", VA = "0x440C95C")]
		public void OnMail_remove(string str)
		{
		}

		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0x440D730", Offset = "0x4409730", VA = "0x440D730")]
		public static long GetCurrentUnixStamp()
		{
			return default;
		}

		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0x440D824", Offset = "0x4409824", VA = "0x440D824")]
		public EmailControl()
		{
		}
	}
}
