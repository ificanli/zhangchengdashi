using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000C")]
	public class AllIn1ChangeAllChildTextFonts : MonoBehaviour
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Font newFont;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool changeFontOnStart;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3CEF59C", Offset = "0x3CEB59C", VA = "0x3CEF59C")]
		private void Start()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3CEF5AC", Offset = "0x3CEB5AC", VA = "0x3CEF5AC")]
		[ContextMenu("ChangeFonts")]
		private void ChangeFonts()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3CEF648", Offset = "0x3CEB648", VA = "0x3CEF648")]
		public AllIn1ChangeAllChildTextFonts()
		{
		}
	}
}
