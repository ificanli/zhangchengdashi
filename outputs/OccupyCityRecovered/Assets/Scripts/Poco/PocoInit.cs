using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class PocoInit
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x787870C", Offset = "0x787470C", VA = "0x787870C")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void InitializePocoInit()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x78787F8", Offset = "0x78747F8", VA = "0x78787F8")]
	public PocoInit()
	{
	}
}
