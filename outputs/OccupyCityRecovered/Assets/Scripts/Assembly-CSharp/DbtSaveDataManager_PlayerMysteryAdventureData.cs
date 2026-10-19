using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000070")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerMysteryAdventureData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerMysteryAdventureData, PlayerMysteryAdventureData>
{
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x3D20280", Offset = "0x3D1C280", VA = "0x3D20280")]
	public DbtSaveDataManager_PlayerMysteryAdventureData()
	{
	}
}
