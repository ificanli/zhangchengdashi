using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200066A")]
	public class WorldCupActivityPanelView : MonoBehaviour
	{
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x20")]
		public Image TitleImage;

		[Token(Token = "0x400340E")]
		[FieldOffset(Offset = "0x28")]
		public Image CountdownBgImage;

		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI CountdownText;

		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x38")]
		public Button RulesButton;

		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x40")]
		public Button ShopButton;

		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x48")]
		public Button DailyGiftButton;

		[Token(Token = "0x4003413")]
		[FieldOffset(Offset = "0x50")]
		public Button DailyTaskButton;

		[Token(Token = "0x4003414")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DailyTaskRedDot;

		[Token(Token = "0x4003415")]
		[FieldOffset(Offset = "0x60")]
		public GameObject DailyGiftRedDot;

		[Token(Token = "0x4003416")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform ShootStageRoot;

		[Token(Token = "0x4003417")]
		[FieldOffset(Offset = "0x70")]
		public Image MultiplierBarImage;

		[Token(Token = "0x4003418")]
		[FieldOffset(Offset = "0x78")]
		public Toggle Multiplier1Toggle;

		[Token(Token = "0x4003419")]
		[FieldOffset(Offset = "0x80")]
		public Toggle Multiplier10Toggle;

		[Token(Token = "0x400341A")]
		[FieldOffset(Offset = "0x88")]
		public Toggle Multiplier50Toggle;

		[Token(Token = "0x400341B")]
		[FieldOffset(Offset = "0x90")]
		public Button ShootButton;

		[Token(Token = "0x400341C")]
		[FieldOffset(Offset = "0x98")]
		public Button BackButton;

		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite StartGameButtonSprite;

		[Token(Token = "0x400341E")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite ShootKickButtonSprite;

		[Token(Token = "0x400341F")]
		[FieldOffset(Offset = "0xB0")]
		public WorldCupShootResultPopup ShootResultPopup;

		[Token(Token = "0x4003420")]
		[FieldOffset(Offset = "0xB8")]
		public WorldCupDailyTaskPanelView DailyTaskPanel;

		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject TopGroup;

		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject LeftEntriesGroup;

		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject MultiplierAreaGroup;

		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject AnimMask;

		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x3F2DF80", Offset = "0x3F29F80", VA = "0x3F2DF80")]
		public WorldCupActivityPanelView()
		{
		}
	}
}
