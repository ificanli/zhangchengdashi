using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006E")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerCoreData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerCoreData, PlayerCoreData>
{
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x3D201F0", Offset = "0x3D1C1F0", VA = "0x3D201F0")]
	public DbtSaveDataManager_PlayerCoreData()
	{
	}
}
