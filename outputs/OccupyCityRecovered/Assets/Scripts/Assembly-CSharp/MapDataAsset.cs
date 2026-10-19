using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B0")]
[CreateAssetMenu(fileName = "MapDataAsset", menuName = "MapDataAsset", order = 1)]
public class MapDataAsset : ScriptableObject
{
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x18")]
	public List<string> mapData;

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x3E2FAA4", Offset = "0x3E2BAA4", VA = "0x3E2FAA4")]
	public MapDataAsset()
	{
	}
}
