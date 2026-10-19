using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000067")]
	public class NNConstraintGraphUpdateObjectProxy
	{
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x10")]
		private readonly GraphUpdateObject graphUpdateObject;

		[Token(Token = "0x170000DE")]
		public GraphMask graphMask
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x44F90B8", Offset = "0x44F50B8", VA = "0x44F90B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x44F90D4", Offset = "0x44F50D4", VA = "0x44F90D4")]
			set
			{
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x44F9090", Offset = "0x44F5090", VA = "0x44F9090")]
		public NNConstraintGraphUpdateObjectProxy(GraphUpdateObject graphUpdateObject)
		{
		}
	}
}
