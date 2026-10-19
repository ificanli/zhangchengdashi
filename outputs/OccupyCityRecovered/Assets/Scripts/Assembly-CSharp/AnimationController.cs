using AnimationInstancing;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002D")]
[ExecuteAlways]
public class AnimationController : MonoBehaviour
{
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private global::AnimationInstancing.AnimationInstancing targetAnimationInstancing;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool onlyWhenSelected;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x3D04264", Offset = "0x3D00264", VA = "0x3D04264")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x3D0439C", Offset = "0x3D0039C", VA = "0x3D0439C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x3D043A0", Offset = "0x3D003A0", VA = "0x3D043A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x3D043A4", Offset = "0x3D003A4", VA = "0x3D043A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x3D043A8", Offset = "0x3D003A8", VA = "0x3D043A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3D04268", Offset = "0x3D00268", VA = "0x3D04268")]
	private void CacheTarget()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3D04424", Offset = "0x3D00424", VA = "0x3D04424")]
	private void SwitchToNextAnimation()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x3D046A8", Offset = "0x3D006A8", VA = "0x3D046A8")]
	private int GetCurrentAnimationIndex(string[] animationNames)
	{
		return default;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x3D04554", Offset = "0x3D00554", VA = "0x3D04554")]
	private string[] GetAvailableAnimationNames()
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x3D04768", Offset = "0x3D00768", VA = "0x3D04768")]
	public AnimationController()
	{
	}
}
