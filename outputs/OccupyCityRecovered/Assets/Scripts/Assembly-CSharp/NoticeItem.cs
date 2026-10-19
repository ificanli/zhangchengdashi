using System;
using CommonGameModule.AnnouncementModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200004B")]
public class NoticeItem : MonoBehaviour
{
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x20")]
	public Image ImageBG;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] BGs;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x30")]
	public Toggle Toggle;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI TextTitle;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x40")]
	private Action<NoticeDO> _onNoticeItemClicked;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x48")]
	private NoticeDO _noticeDO;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x3D0ACD4", Offset = "0x3D06CD4", VA = "0x3D0ACD4")]
	public void Init(ToggleGroup toggleGroup, bool isOn, NoticeDO noticeDO, Action<NoticeDO> onNoticeItemClicked)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x3D0AEF8", Offset = "0x3D06EF8", VA = "0x3D0AEF8")]
	public void OnNoticeItemClicked(bool isOn)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x3D0AF78", Offset = "0x3D06F78", VA = "0x3D0AF78")]
	public NoticeItem()
	{
	}
}
