using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C3")]
public class UIJumpTween : MonoBehaviour
{
	[Token(Token = "0x4000404")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform rect;

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x2C")]
	public float delayTime;

	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x30")]
	public float loopbase;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x34")]
	public float scaleX;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x38")]
	public float scaleY;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x3C")]
	public float hight;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x40")]
	public bool active;

	[Token(Token = "0x17000037")]
	private string TweenId
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3E3A760", Offset = "0x3E36760", VA = "0x3E3A760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x3E3A7BC", Offset = "0x3E367BC", VA = "0x3E3A7BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x3E3A80C", Offset = "0x3E3680C", VA = "0x3E3A80C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x3E3A818", Offset = "0x3E36818", VA = "0x3E3A818")]
	private void Update()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x3E3A86C", Offset = "0x3E3686C", VA = "0x3E3A86C")]
	private void Tween()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x3E3AAD0", Offset = "0x3E36AD0", VA = "0x3E3AAD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x3E3AAD4", Offset = "0x3E36AD4", VA = "0x3E3AAD4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x3E3AA64", Offset = "0x3E36A64", VA = "0x3E3AA64")]
	private void KillTween()
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x3E3AAD8", Offset = "0x3E36AD8", VA = "0x3E3AAD8")]
	public UIJumpTween()
	{
	}
}
