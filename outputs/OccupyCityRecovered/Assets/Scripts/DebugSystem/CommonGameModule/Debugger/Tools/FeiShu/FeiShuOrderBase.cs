using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x200003F")]
	public abstract class FeiShuOrderBase
	{
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action<string> m_EventOnRequestError;

		[Token(Token = "0x14000004")]
		public event Action<string> EventOnRequestError
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4642230", Offset = "0x463E230", VA = "0x4642230")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x46422E0", Offset = "0x463E2E0", VA = "0x46422E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000105")]
		public abstract void Execute();

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4642390", Offset = "0x463E390", VA = "0x4642390", Slot = "5")]
		protected virtual void OnRequestError(string error)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4642548", Offset = "0x463E548", VA = "0x4642548")]
		protected FeiShuOrderBase()
		{
		}
	}
}
