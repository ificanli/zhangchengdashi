using System;
using CommonGameModule.Email;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000049")]
public class EmailListItem : MonoBehaviour
{
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x20")]
	public Button Btn;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x28")]
	public Image BG;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x30")]
	public Image Icon;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject icon2;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x40")]
	public Sprite[] BGs;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x48")]
	public Sprite[] MailIcons;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x0")]
	private static Color32 EndTime_NotRead;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x4")]
	private static Color32 EndTime_Read;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI Text_Title;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI Text_StartTime;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI Text_EndTime;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x68")]
	private EmailData emailData;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x70")]
	private Action<EmailData> _onClick;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x3D09314", Offset = "0x3D05314", VA = "0x3D09314")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x3D093CC", Offset = "0x3D053CC", VA = "0x3D093CC")]
	public void SetData(EmailData emailData, Action<EmailData> onClick)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x3D0979C", Offset = "0x3D0579C", VA = "0x3D0979C")]
	private string FormatEndTime(long timeExpired)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x3D09A18", Offset = "0x3D05A18", VA = "0x3D09A18")]
	public EmailListItem()
	{
	}
}
