using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200005E")]
	public class DebuggerWindowFullMono : MonoBehaviour
	{
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x20")]
		private DebuggerWindowFull _debuggerWindowFull;

		[Token(Token = "0x17000053")]
		public DebuggerWindowFull DebuggerWindowFull
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x468062C", Offset = "0x467C62C", VA = "0x468062C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4680690", Offset = "0x467C690", VA = "0x4680690")]
		public DebuggerWindowFullMono()
		{
		}
	}
}
