using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class TCP2_Demo_PipelineMaterial : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public Material material;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	public Shader birpShader;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	public Shader urpShader;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7D640E4", Offset = "0x7D600E4", VA = "0x7D640E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7D6425C", Offset = "0x7D6025C", VA = "0x7D6425C")]
	public TCP2_Demo_PipelineMaterial()
	{
	}
}
