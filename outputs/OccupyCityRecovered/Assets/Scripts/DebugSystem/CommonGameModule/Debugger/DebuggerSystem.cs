using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000005")]
	public class DebuggerSystem
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static DebuggerSystem _instance;

		[Token(Token = "0x17000001")]
		public static DebuggerSystem I
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x462F808", Offset = "0x462B808", VA = "0x462F808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x462F888", Offset = "0x462B888", VA = "0x462F888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public bool ActiveWindow
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x462F928", Offset = "0x462B928", VA = "0x462F928")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x462F9D8", Offset = "0x462B9D8", VA = "0x462F9D8")]
			set
			{
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x462F880", Offset = "0x462B880", VA = "0x462F880")]
		private DebuggerSystem()
		{
		}
	}
}
