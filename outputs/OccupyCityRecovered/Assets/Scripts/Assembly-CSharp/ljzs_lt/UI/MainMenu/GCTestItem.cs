using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace ljzs_lt.UI.MainMenu
{
	[Token(Token = "0x2000F4F")]
	[SkipRename]
	public class GCTestItem : BaseItem
	{
		[Token(Token = "0x40069CF")]
		[FieldOffset(Offset = "0x48")]
		public Action<GCTestItem> onClick;

		[Token(Token = "0x40069D0")]
		[FieldOffset(Offset = "0x50")]
		private Image Image;

		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x439F654", Offset = "0x439B654", VA = "0x439F654", Slot = "8")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x439F6DC", Offset = "0x439B6DC", VA = "0x439F6DC", Slot = "23")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0x439F6E0", Offset = "0x439B6E0", VA = "0x439F6E0")]
		private void self_Click()
		{
		}

		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0x439F700", Offset = "0x439B700", VA = "0x439F700", Slot = "12")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0x439F708", Offset = "0x439B708", VA = "0x439F708", Slot = "5")]
		protected override void InitializeComponent()
		{
		}

		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0x439F778", Offset = "0x439B778", VA = "0x439F778", Slot = "6")]
		protected override void InitializeSkin()
		{
		}

		[Token(Token = "0x6005BAC")]
		[Address(RVA = "0x439F77C", Offset = "0x439B77C", VA = "0x439F77C")]
		public GCTestItem()
		{
		}
	}
}
