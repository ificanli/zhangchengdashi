using System.Runtime.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000202")]
	public abstract class FeatureUnlockBase
	{
		[Token(Token = "0x4001CE8")]
		[FieldOffset(Offset = "0x18")]
		protected readonly GlobalFeatureUnlockInfo _info;

		[Token(Token = "0x170000A5")]
		public bool IsUnlock
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x418EC48", Offset = "0x418AC48", VA = "0x418EC48")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x418EC50", Offset = "0x418AC50", VA = "0x418EC50")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x170000A6")]
		public virtual bool IsInitCheck
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x418EC5C", Offset = "0x418AC5C", VA = "0x418EC5C", Slot = "4")]
			get
			{
                return true;
            }
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x418E6F4", Offset = "0x418A6F4", VA = "0x418E6F4")]
		protected FeatureUnlockBase(GlobalFeatureUnlockInfo info, bool isUnlock)
		{
            _info = info;
            IsUnlock = isUnlock;
        }

		[Token(Token = "0x6000844")]
		public abstract void StartCheck();

		[Token(Token = "0x6000845")]
		public abstract void EndCheck();

		[Token(Token = "0x6000846")]
		public abstract string UnlockTip();

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x418EC64", Offset = "0x418AC64", VA = "0x418EC64")]
		protected bool IsTutorialComplete()
		{
			return default;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x418ED10", Offset = "0x418AD10", VA = "0x418ED10", Slot = "8")]
		public virtual void ToUpdate()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x418EA2C", Offset = "0x418AA2C", VA = "0x418EA2C")]
		protected void ToUnlock()
		{
		}
	}
}
