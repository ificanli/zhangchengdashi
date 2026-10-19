using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A48")]
	public class MysteryAdventureRulesItemView : MonoBehaviour
	{
		[Token(Token = "0x4004C20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backgroundImage;

		[Token(Token = "0x4004C21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconImage;

		[Token(Token = "0x4004C22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _descText;

		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x415D678", Offset = "0x4159678", VA = "0x415D678")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x415D784", Offset = "0x4159784", VA = "0x415D784")]
		public void Bind(string title, string description, Sprite rowBackground, Sprite icon, bool showIcon)
		{
		}

		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x415D9EC", Offset = "0x41599EC", VA = "0x415D9EC")]
		public void SetVisible(bool visible)
		{
		}

		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x415D67C", Offset = "0x415967C", VA = "0x415D67C")]
		private void ResolveReferences()
		{
		}

		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x415DA14", Offset = "0x4159A14", VA = "0x415DA14")]
		internal void BindReferences(Image background, Image icon, TextMeshProUGUI desc)
		{
		}

		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x415DA20", Offset = "0x4159A20", VA = "0x415DA20")]
		public MysteryAdventureRulesItemView()
		{
		}
	}
}
