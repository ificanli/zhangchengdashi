using Il2CppDummyDll;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI.ConsoleWindow
{
	[Token(Token = "0x2000097")]
	public class ConsoleSearchCtrl
	{
		[Token(Token = "0x2000098")]
		private enum SearchState
		{
			[Token(Token = "0x40002A2")]
			Disable = 0,
			[Token(Token = "0x40002A3")]
			Filter = 1
		}

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x10")]
		private readonly InputField _inputField;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x18")]
		private readonly Button _searchPreviousBtn;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Button _searchNextBtn;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x28")]
		private readonly Button _searchStateBtn;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x30")]
		private readonly ConsoleLogHandler _logHandler;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x38")]
		private readonly ConsoleWindowUGUI _consoleWindowUGUI;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x40")]
		private readonly Text _searchStageText;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x48")]
		private SearchState _searchState;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x50")]
		private string _filterText;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4693068", Offset = "0x468F068", VA = "0x4693068")]
		public ConsoleSearchCtrl(InputField inputField, Button searchPreviousBtn, Button searchNextBtn, Button searchStateBtn, ConsoleLogHandler logHandler, ConsoleWindowUGUI consoleWindowUGUI)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x46932AC", Offset = "0x468F2AC", VA = "0x46932AC")]
		private void SetSearchState(SearchState state)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x46933E0", Offset = "0x468F3E0", VA = "0x46933E0")]
		private void SetFilterText(string text)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4693424", Offset = "0x468F424", VA = "0x4693424")]
		private void OnInputFieldChange(string text)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4693468", Offset = "0x468F468", VA = "0x4693468")]
		private void OnSearchPreviousBtnClick()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x469363C", Offset = "0x468F63C", VA = "0x469363C")]
		private void OnSearchNextBtnClick()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4693684", Offset = "0x468F684", VA = "0x4693684")]
		private void OnSearchStageBtnClick()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x46934B0", Offset = "0x468F4B0", VA = "0x46934B0")]
		private ConsoleWindowUGUI.Log FindLog(bool isNext)
		{
			return null;
		}
	}
}
