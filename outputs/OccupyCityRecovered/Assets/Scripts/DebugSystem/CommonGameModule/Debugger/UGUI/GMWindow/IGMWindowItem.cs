using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI.GMWindow
{
	[Token(Token = "0x2000096")]
	public interface IGMWindowItem
	{
		[Token(Token = "0x17000099")]
		GameObject gameObject
		{
			[Token(Token = "0x600036A")]
			get;
		}

		[Token(Token = "0x1700009A")]
		bool IsDirty
		{
			[Token(Token = "0x600036B")]
			get;
			[Token(Token = "0x600036C")]
			set;
		}

		[Token(Token = "0x1700009B")]
		string Name
		{
			[Token(Token = "0x600036D")]
			get;
			[Token(Token = "0x600036E")]
			set;
		}

		[Token(Token = "0x1700009C")]
		string[] Tags
		{
			[Token(Token = "0x600036F")]
			get;
			[Token(Token = "0x6000370")]
			set;
		}

		[Token(Token = "0x6000371")]
		void RefreshView();

		[Token(Token = "0x6000372")]
		bool EqualsCallback(object callback);

		[Token(Token = "0x6000373")]
		void SetFontSize(int size);
	}
}
