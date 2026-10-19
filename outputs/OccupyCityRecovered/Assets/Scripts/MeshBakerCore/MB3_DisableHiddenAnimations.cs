using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000019")]
public class MB3_DisableHiddenAnimations : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x20")]
	public List<Animation> animationsToCull;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x743E9A8", Offset = "0x743A9A8", VA = "0x743E9A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x743EACC", Offset = "0x743AACC", VA = "0x743EACC")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x743EBB8", Offset = "0x743ABB8", VA = "0x743EBB8")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x743ECA4", Offset = "0x743ACA4", VA = "0x743ECA4")]
	public MB3_DisableHiddenAnimations()
	{
	}
}
