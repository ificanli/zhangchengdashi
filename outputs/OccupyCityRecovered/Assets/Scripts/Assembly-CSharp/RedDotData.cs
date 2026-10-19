using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007F")]
[CreateAssetMenu(fileName = "RedDotData", menuName = "Red Dot System/Red Dot Data")]
public class RedDotData : ScriptableObject
{
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x18")]
	public RedDotNode rootNode;

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x3D22518", Offset = "0x3D1E518", VA = "0x3D22518")]
	public RedDotData()
	{
	}
}
