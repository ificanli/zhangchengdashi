using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200002C")]
[ExecuteInEditMode]
public class MB_PreserveLightmapData : MonoBehaviour
{
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x20")]
	public int lightmapIndex;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x24")]
	public Vector4 lightmapScaleOffset;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x74470F4", Offset = "0x74430F4", VA = "0x74470F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7447274", Offset = "0x7443274", VA = "0x7447274")]
	public MB_PreserveLightmapData()
	{
	}
}
