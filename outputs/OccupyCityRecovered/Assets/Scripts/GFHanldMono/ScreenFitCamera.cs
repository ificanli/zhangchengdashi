using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class ScreenFitCamera : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x20")]
	private float devHeight;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x24")]
	private float devWidth;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7066864", Offset = "0x7062864", VA = "0x7066864")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7066940", Offset = "0x7062940", VA = "0x7066940")]
	public ScreenFitCamera()
	{
	}
}
