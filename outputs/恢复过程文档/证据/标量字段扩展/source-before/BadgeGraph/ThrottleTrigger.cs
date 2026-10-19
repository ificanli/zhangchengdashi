using System;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Token(Token = "0x2000E0D")]
	public class ThrottleTrigger
	{
		[Token(Token = "0x40061F7")]
		[FieldOffset(Offset = "0x10")]
		private float _throttleInterval;

		[Token(Token = "0x40061F8")]
		[FieldOffset(Offset = "0x14")]
		private float currentTriggerInterval;

		[Token(Token = "0x40061F9")]
		[FieldOffset(Offset = "0x18")]
		private int _pendingTriggerCount;

		[Token(Token = "0x40061FA")]
		[FieldOffset(Offset = "0x20")]
		private Action _onTriggerCallback;

		[Token(Token = "0x17000EAE")]
		private int PendingTriggerCount
		{
			[Token(Token = "0x60056B8")]
			[Address(RVA = "0x4340240", Offset = "0x433C240", VA = "0x4340240")]
			get
			{
				return default;
			}
			[Token(Token = "0x60056B9")]
			[Address(RVA = "0x4340248", Offset = "0x433C248", VA = "0x4340248")]
			set
			{
			}
		}

		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x4340290", Offset = "0x433C290", VA = "0x4340290")]
		public ThrottleTrigger(float throttleInterval, Action onTriggerCallback)
		{
		}

		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x4340378", Offset = "0x433C378", VA = "0x4340378")]
		private void ToUpdate(float f)
		{
		}

		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x4340394", Offset = "0x433C394", VA = "0x4340394")]
		public void RegisterOneTrigger()
		{
		}

		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x43403B0", Offset = "0x433C3B0", VA = "0x43403B0")]
		public void ForceTrigger()
		{
		}

		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x43403D4", Offset = "0x433C3D4", VA = "0x43403D4")]
		public void UnRegisterTrigger()
		{
		}

		[Token(Token = "0x60056BF")]
		[Address(RVA = "0x434025C", Offset = "0x433C25C", VA = "0x434025C")]
		private void Trigger()
		{
		}
	}
}
