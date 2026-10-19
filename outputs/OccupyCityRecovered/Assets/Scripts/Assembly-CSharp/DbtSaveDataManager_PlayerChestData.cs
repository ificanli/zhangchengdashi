using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000069")]
[ModelRegister("ljzs_lt", true, false)]
[Skip]
public class DbtSaveDataManager_PlayerChestData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerChestData, PlayerChestData>
{
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x3D20038", Offset = "0x3D1C038", VA = "0x3D20038")]
	public DbtSaveDataManager_PlayerChestData()
	{
	}
}
