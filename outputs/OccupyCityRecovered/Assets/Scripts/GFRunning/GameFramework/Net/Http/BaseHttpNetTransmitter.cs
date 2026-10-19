using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000463")]
	public class BaseHttpNetTransmitter : IDisposable
	{
		[Token(Token = "0x4001E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool ushexxxkkk;

		[Token(Token = "0x4001E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int m_id;

		[Token(Token = "0x4001E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string m_baseUrl;

		[Token(Token = "0x4001E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, string> m_Url;

		[Token(Token = "0x4001E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, Action<string>> m_DicAction;

		[Token(Token = "0x4001E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_isDisposable;

		[Token(Token = "0x4001E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EncryptDataRequest m_ERequest;

		[Token(Token = "0x170011D3")]
		public int Id
		{
			[Token(Token = "0x6006BAE")]
			[Address(RVA = "0x72848D4", Offset = "0x72808D4", VA = "0x72848D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6006BAF")]
		[Address(RVA = "0x72848DC", Offset = "0x72808DC", VA = "0x72848DC")]
		internal void SetUrl(string BaseUrl, bool UseSSL = true)
		{
		}

		[Token(Token = "0x6006BB0")]
		[Address(RVA = "0x728494C", Offset = "0x728094C", VA = "0x728494C")]
		protected int Send(int httpProtocolType, [Optional] IRequesData PostData)
		{
			return default;
		}

		[Token(Token = "0x6006BB1")]
		[Address(RVA = "0x7284F08", Offset = "0x7280F08", VA = "0x7284F08")]
		private void EncryptData(IRequesData postData)
		{
		}

		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0x7284FB0", Offset = "0x7280FB0", VA = "0x7284FB0")]
		private string DecryptData(string json)
		{
			return null;
		}

		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0x7285030", Offset = "0x7281030", VA = "0x7285030")]
		private void RequestCallBack(int code, GameFrameworkEventArgs args)
		{
		}

		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0x7285BC0", Offset = "0x7281BC0", VA = "0x7285BC0")]
		protected void AddHttpProtocol(int httpProtocolType, string url, Action<string> action)
		{
		}

		[Token(Token = "0x6006BB5")]
		[Address(RVA = "0x7285D98", Offset = "0x7281D98", VA = "0x7285D98", Slot = "5")]
		public virtual void InitProtocol()
		{
		}

		[Token(Token = "0x6006BB6")]
		[Address(RVA = "0x7285D9C", Offset = "0x7281D9C", VA = "0x7285D9C", Slot = "6")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6006BB7")]
		[Address(RVA = "0x7285DA0", Offset = "0x7281DA0", VA = "0x7285DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0x7285E20", Offset = "0x7281E20", VA = "0x7285E20")]
		public BaseHttpNetTransmitter()
		{
		}
	}
}
