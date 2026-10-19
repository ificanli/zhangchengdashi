using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003F9")]
	public class UpdateInfo
	{
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x10")]
		public bool isShowLog;

		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x14")]
		public float updateInterval;

		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x18")]
		public float lastUpdateTimer;

		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x20")]
		private Action<float> action;

		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x3DD1B1C", Offset = "0x3DCDB1C", VA = "0x3DD1B1C")]
		public void AddAction(Action<float> addAction)
		{
		}

		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x3DD1BFC", Offset = "0x3DCDBFC", VA = "0x3DD1BFC")]
		public void RemoveAction(Action<float> removeAction)
		{
		}

		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x3DD1CA4", Offset = "0x3DCDCA4", VA = "0x3DD1CA4")]
		private void TriggerAction()
		{
		}

		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x3DD1D68", Offset = "0x3DCDD68", VA = "0x3DD1D68")]
		public void ToUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x3DD1D94", Offset = "0x3DCDD94", VA = "0x3DD1D94")]
		public UpdateInfo()
		{
		}
	}
}
