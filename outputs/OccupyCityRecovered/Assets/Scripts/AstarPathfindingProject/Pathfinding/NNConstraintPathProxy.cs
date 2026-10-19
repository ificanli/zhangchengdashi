using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000068")]
	public class NNConstraintPathProxy
	{
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x10")]
		private readonly Path path;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x18")]
		private readonly int pathID;

		[Token(Token = "0x170000DF")]
		public GraphMask graphMask
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x44F9198", Offset = "0x44F5198", VA = "0x44F9198")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x44F91B4", Offset = "0x44F51B4", VA = "0x44F91B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public int tags
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x44F91E4", Offset = "0x44F51E4", VA = "0x44F91E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x44F9200", Offset = "0x44F5200", VA = "0x44F9200")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public DistanceMetric distanceMetric
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x44F9230", Offset = "0x44F5230", VA = "0x44F9230")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x44F9250", Offset = "0x44F5250", VA = "0x44F9250")]
			set
			{
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x44F90F0", Offset = "0x44F50F0", VA = "0x44F90F0")]
		internal NNConstraintPathProxy(Path path)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x44F9128", Offset = "0x44F5128", VA = "0x44F9128")]
		private void Validate()
		{
		}
	}
}
