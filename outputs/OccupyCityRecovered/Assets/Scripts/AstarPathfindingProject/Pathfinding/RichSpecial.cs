using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000023")]
	public class RichSpecial : RichPathPart
	{
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x10")]
		public OffMeshLinks.OffMeshLinkTracer nodeLink;

		[Token(Token = "0x170000B1")]
		public FakeTransform first
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x4457274", Offset = "0x4453274", VA = "0x4457274")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B2")]
		public FakeTransform second
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x4457218", Offset = "0x4453218", VA = "0x4457218")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B3")]
		public bool reverse
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x445B748", Offset = "0x4457748", VA = "0x445B748")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x445B750", Offset = "0x4457750", VA = "0x445B750", Slot = "5")]
		public override void OnEnterPool()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4458C14", Offset = "0x4454C14", VA = "0x4458C14")]
		public RichSpecial Initialize(OffMeshLinks.OffMeshLinkTracer nodeLink)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x445B760", Offset = "0x4457760", VA = "0x445B760")]
		public RichSpecial()
		{
		}
	}
}
