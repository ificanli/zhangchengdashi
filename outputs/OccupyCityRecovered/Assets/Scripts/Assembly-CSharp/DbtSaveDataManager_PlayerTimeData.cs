using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006A")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerTimeData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerTimeData, PlayerTimeData>
{
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x3D20080", Offset = "0x3D1C080", VA = "0x3D20080")]
	public DbtSaveDataManager_PlayerTimeData()
	{
	}
}
