using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006B")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerAdData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerAdData, PlayerAdData>
{
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x3D200C8", Offset = "0x3D1C0C8", VA = "0x3D200C8")]
	public DbtSaveDataManager_PlayerAdData()
	{
	}
}
