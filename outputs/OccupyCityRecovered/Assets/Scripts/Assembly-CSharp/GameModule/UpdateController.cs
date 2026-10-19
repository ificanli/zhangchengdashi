using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003FA")]
	public class UpdateController
	{
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x10")]
		public bool showLog;

		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, UpdateInfo> updateInfoDic;

		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x3DD1D9C", Offset = "0x3DCDD9C", VA = "0x3DD1D9C")]
		public void RegisterOneAction(float interval, Action<float> action)
		{
		}

		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x3DD1ED4", Offset = "0x3DCDED4", VA = "0x3DD1ED4")]
		public void UnRegisterOneAction(float interval, Action<float> action)
		{
		}

		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x3DD1FA8", Offset = "0x3DCDFA8", VA = "0x3DD1FA8")]
		public void ToUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x3DD21A4", Offset = "0x3DCE1A4", VA = "0x3DD21A4")]
		public UpdateController()
		{
		}
	}
}
