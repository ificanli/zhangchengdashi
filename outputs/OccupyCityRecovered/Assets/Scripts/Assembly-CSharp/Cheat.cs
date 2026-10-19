using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000007")]
public class Cheat : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x0")]
	private static bool isInitCheat;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3CFDE84", Offset = "0x3CF9E84", VA = "0x3CFDE84")]
	public void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3CFDED8", Offset = "0x3CF9ED8", VA = "0x3CFDED8")]
	public void RegCheat()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3CFDEDC", Offset = "0x3CF9EDC", VA = "0x3CFDEDC")]
	public Cheat()
	{
	}
}
