using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Token(Token = "0x2000E0C")]
	public class BadgeNode
	{
		[Token(Token = "0x40061F2")]
		[FieldOffset(Offset = "0x10")]
		public string NodeName;

		[Token(Token = "0x40061F3")]
		[FieldOffset(Offset = "0x18")]
		public int PointNumber;

		[Token(Token = "0x40061F4")]
		[FieldOffset(Offset = "0x20")]
		public BadgeNode Parent;

		[Token(Token = "0x40061F5")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private OnPointNumberChanged m_OnPointNumberChangedEvent;

		[Token(Token = "0x17000EAD")]
		public Dictionary<string, BadgeNode> ChildNodeDict
		{
			[Token(Token = "0x60056B2")]
			[Address(RVA = "0x4340090", Offset = "0x433C090", VA = "0x4340090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60056B3")]
			[Address(RVA = "0x4340098", Offset = "0x433C098", VA = "0x4340098")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event OnPointNumberChanged OnPointNumberChangedEvent
		{
			[Token(Token = "0x60056B0")]
			[Address(RVA = "0x433FF58", Offset = "0x433BF58", VA = "0x433FF58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60056B1")]
			[Address(RVA = "0x433FFF4", Offset = "0x433BFF4", VA = "0x433FFF4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x433EF48", Offset = "0x433AF48", VA = "0x433EF48")]
		public void SetNumber(int number)
		{
		}

		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x43400A0", Offset = "0x433C0A0", VA = "0x43400A0")]
		private void ChangePredPointNum()
		{
		}

		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x433EF34", Offset = "0x433AF34", VA = "0x433EF34")]
		public void SetCallback(bool subscribe, OnPointNumberChanged callback)
		{
		}

		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x433ED04", Offset = "0x433AD04", VA = "0x433ED04")]
		public BadgeNode()
		{
		}
	}
}
