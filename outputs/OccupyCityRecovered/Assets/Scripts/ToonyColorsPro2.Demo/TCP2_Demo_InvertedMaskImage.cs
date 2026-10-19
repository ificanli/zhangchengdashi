using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000002")]
public class TCP2_Demo_InvertedMaskImage : Image
{
	[Token(Token = "0x17000001")]
	public override Material materialForRendering
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x7D63FEC", Offset = "0x7D5FFEC", VA = "0x7D63FEC", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7D6408C", Offset = "0x7D6008C", VA = "0x7D6408C")]
	public TCP2_Demo_InvertedMaskImage()
	{
	}
}
