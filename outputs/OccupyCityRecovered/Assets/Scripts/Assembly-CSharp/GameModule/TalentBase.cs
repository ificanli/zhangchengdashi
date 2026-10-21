using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000244")]
	public abstract class TalentBase : ITalentEffect
	{
		[Token(Token = "0x170000BD")]
		[field: Token(Token = "0x4001E41")]
		[field: Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string TalentId
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x4295674", Offset = "0x4291674", VA = "0x4295674")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x429567C", Offset = "0x429167C", VA = "0x429567C")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x170000BE")]
		[field: Token(Token = "0x4001E42")]
		[field: Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameEventType EventType
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x4295684", Offset = "0x4291684", VA = "0x4295684")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x429568C", Offset = "0x429168C", VA = "0x429568C")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x170000BF")]
		public float Value
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x4295694", Offset = "0x4291694", VA = "0x4295694")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x429569C", Offset = "0x429169C", VA = "0x429569C")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x170000C0")]
		public bool Stop
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x42956A4", Offset = "0x42916A4", VA = "0x42956A4")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x42956AC", Offset = "0x42916AC", VA = "0x42956AC")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x42956B8", Offset = "0x42916B8", VA = "0x42956B8")]
		public TalentBase(string talentId, GameEventType eventType, float value)
		{
            TalentId = talentId;
            EventType = eventType;
            Value = value;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x42956F8", Offset = "0x42916F8", VA = "0x42956F8", Slot = "5")]
		public virtual void OnEventTrigger(GameEventType eventType, GameEventArgs args)
		{
		}

		[Token(Token = "0x60009CC")]
		protected abstract void HandleEvent(GameEventArgs args);

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x4295724", Offset = "0x4291724", VA = "0x4295724")]
		protected bool CheckHealthLargeThan50(EntityBase entity)
		{
			return default;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x42957B0", Offset = "0x42917B0", VA = "0x42957B0")]
		protected bool CheckHealthSmallThan50(EntityBase entity)
		{
			return default;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x429583C", Offset = "0x429183C", VA = "0x429583C", Slot = "7")]
		public virtual void Clear()
		{
		}
	}
}
