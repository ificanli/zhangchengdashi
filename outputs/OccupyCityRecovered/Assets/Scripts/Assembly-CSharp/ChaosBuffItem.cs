using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20000C9")]
public class ChaosBuffItem : MonoBehaviour
{
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform rectTransform;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI buffName;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI buffDesc;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _showDuration;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Ease _showEase;

	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 _restScale;

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x3E3DF50", Offset = "0x3E39F50", VA = "0x3E3DF50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x3E3E044", Offset = "0x3E3A044", VA = "0x3E3E044")]
	public void SetData(int buffId)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x3E3E210", Offset = "0x3E3A210", VA = "0x3E3E210")]
	public void PrepareForShow()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x3E3E358", Offset = "0x3E3A358", VA = "0x3E3E358")]
	public void PlayShowAnimation(float delay, bool immediate)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x3E3E2D8", Offset = "0x3E3A2D8", VA = "0x3E3E2D8")]
	public void KillShowAnimation()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x3E3E4E4", Offset = "0x3E3A4E4", VA = "0x3E3E4E4")]
	public ChaosBuffItem()
	{
	}
}
