using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200008A")]
public class OscillateLightBrightness : MonoBehaviour
{
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x20")]
	private Light lightComponent;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 10f)]
	private float lower;

	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 10f)]
	[SerializeField]
	private float upper;

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x3D22DEC", Offset = "0x3D1EDEC", VA = "0x3D22DEC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x3D22E3C", Offset = "0x3D1EE3C", VA = "0x3D22E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3D22E68", Offset = "0x3D1EE68", VA = "0x3D22E68")]
	public OscillateLightBrightness()
	{
	}
}
