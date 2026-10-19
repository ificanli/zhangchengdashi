using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000120")]
	public abstract class MonoModifier : VersionedMonoBehaviour, IPathModifier
	{
		[NonSerialized]
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x28")]
		public Seeker seeker;

		[Token(Token = "0x170001C4")]
		public abstract int Order
		{
			[Token(Token = "0x60009B0")]
			get;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x45544B4", Offset = "0x45504B4", VA = "0x45544B4", Slot = "18")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x455456C", Offset = "0x455056C", VA = "0x455456C", Slot = "19")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x45545F4", Offset = "0x45505F4", VA = "0x45545F4", Slot = "21")]
		public virtual void PreProcess(Path path)
		{
		}

		[Token(Token = "0x60009B2")]
		public abstract void Apply(Path path);

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x4550CD8", Offset = "0x454CCD8", VA = "0x4550CD8")]
		protected MonoModifier()
		{
		}
	}
}
