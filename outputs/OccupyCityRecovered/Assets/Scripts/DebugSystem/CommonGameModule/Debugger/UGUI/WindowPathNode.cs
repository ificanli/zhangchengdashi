using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200008F")]
	public class WindowPathNode
	{
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x28")]
		public string SelectCache;

		[Token(Token = "0x1700008C")]
		public List<WindowPathNode> Children
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x4691C48", Offset = "0x468DC48", VA = "0x4691C48")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x4691C50", Offset = "0x468DC50", VA = "0x4691C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public string Name
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x4691C58", Offset = "0x468DC58", VA = "0x4691C58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x4691C60", Offset = "0x468DC60", VA = "0x4691C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public IDebuggerWindowUGUI Window
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x4691C68", Offset = "0x468DC68", VA = "0x4691C68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x4691C70", Offset = "0x468DC70", VA = "0x4691C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x4691C78", Offset = "0x468DC78", VA = "0x4691C78")]
		public WindowPathNode FindInChildren(string name)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x4691D44", Offset = "0x468DD44", VA = "0x4691D44")]
		public WindowPathNode FindByPaths(string[] paths)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4691DC4", Offset = "0x468DDC4", VA = "0x4691DC4")]
		public WindowPathNode CreateByPath(IDebuggerWindowUGUI window, string[] paths)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x469222C", Offset = "0x468E22C", VA = "0x469222C")]
		public void Log(string parentPath = "")
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x4692224", Offset = "0x468E224", VA = "0x4692224")]
		public WindowPathNode()
		{
		}
	}
}
