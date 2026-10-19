using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x200011F")]
	public abstract class PathModifier : IPathModifier
	{
		[NonSerialized]
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x10")]
		public Seeker seeker;

		[Token(Token = "0x170001C3")]
		public abstract int Order
		{
			[Token(Token = "0x60009A8")]
			get;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x455437C", Offset = "0x455037C", VA = "0x455437C")]
		public void Awake(Seeker seeker)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x4554414", Offset = "0x4550414", VA = "0x4554414")]
		public void OnDestroy(Seeker seeker)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x45544A8", Offset = "0x45504A8", VA = "0x45544A8", Slot = "8")]
		public virtual void PreProcess(Path path)
		{
		}

		[Token(Token = "0x60009AC")]
		public abstract void Apply(Path path);

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x45544AC", Offset = "0x45504AC", VA = "0x45544AC")]
		protected PathModifier()
		{
		}
	}
}
