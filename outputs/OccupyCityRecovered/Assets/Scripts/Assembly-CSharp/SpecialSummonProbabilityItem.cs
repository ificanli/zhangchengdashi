using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using ljzs_lt;

[Token(Token = "0x20000D1")]
public class SpecialSummonProbabilityItem : MonoBehaviour
{
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI itemName;

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI itemProbability;

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x3E41000", Offset = "0x3E3D000", VA = "0x3E41000")]
	public void Init(LimitedPropInfoConfig config, int totalWeight)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x3E41284", Offset = "0x3E3D284", VA = "0x3E41284")]
	public SpecialSummonProbabilityItem()
	{
	}
}
