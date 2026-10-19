using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace ljzs_lt.UI.MainMenu
{
	[Token(Token = "0x2000F4E")]
	[SkipRename]
	public class GameCollectionTestUI : BaseUI
	{
		[Token(Token = "0x40069CC")]
		[FieldOffset(Offset = "0xA8")]
		private Image Image;

		[Token(Token = "0x40069CD")]
		[FieldOffset(Offset = "0xB0")]
		private Text Text;

		[Token(Token = "0x40069CE")]
		[FieldOffset(Offset = "0xB8")]
		private UIOutlet GCTestItem;

		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x439F52C", Offset = "0x439B52C", VA = "0x439F52C")]
		public GameCollectionTestUI()
		{
		}

		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x439F550", Offset = "0x439B550", VA = "0x439F550", Slot = "8")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0x439F554", Offset = "0x439B554", VA = "0x439F554", Slot = "14")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x439F558", Offset = "0x439B558", VA = "0x439F558", Slot = "12")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x439F55C", Offset = "0x439B55C", VA = "0x439F55C", Slot = "5")]
		protected override void InitializeComponent()
		{
		}
	}
}
