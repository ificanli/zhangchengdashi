using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x200024B")]
	public class SerializeSettings
	{
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x10")]
		public bool nodes;

		[Token(Token = "0x1700022B")]
		public static SerializeSettings Settings
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x447E3F8", Offset = "0x447A3F8", VA = "0x447E3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022C")]
		public static SerializeSettings NodesAndSettings
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x4482F58", Offset = "0x447EF58", VA = "0x4482F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x4482F48", Offset = "0x447EF48", VA = "0x4482F48")]
		public SerializeSettings()
		{
		}
	}
}
