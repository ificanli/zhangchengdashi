using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000067")]
[ModelRegister("ljzs_lt", true, false)]
[Skip]
public class DbtSaveDataManager_PlayerRankData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerRankData, PlayerRankData>
{
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x3D1FFA8", Offset = "0x3D1BFA8", VA = "0x3D1FFA8")]
	public DbtSaveDataManager_PlayerRankData()
	{
	}
}
