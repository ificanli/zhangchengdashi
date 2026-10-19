using Il2CppDummyDll;
using MainTowerModule;
using TMPro;
using UnityEngine;

[Token(Token = "0x20000B8")]
public class BattleEventBehaviour : MonoBehaviour
{
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro TMPCpNum;

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject battleGo;

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject recycleGo;

	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro TMPCoinNum;

	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x40")]
	private string cpNum;

	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x48")]
	private MainCityTileBehaviour _tile;

	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x50")]
	private bool _isRecycle;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x54")]
	private float _scaleFactor;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x58")]
	private float _duration;

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x3E347D8", Offset = "0x3E307D8", VA = "0x3E347D8")]
	public void Init(string num, MainCityTileBehaviour tile, bool isRecycle = false)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x3E349A0", Offset = "0x3E309A0", VA = "0x3E349A0")]
	public void OnClickBattleEvent(MainCityTileBehaviour curClickHex)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x3E34A84", Offset = "0x3E30A84", VA = "0x3E34A84")]
	public BattleEventBehaviour()
	{
	}
}
