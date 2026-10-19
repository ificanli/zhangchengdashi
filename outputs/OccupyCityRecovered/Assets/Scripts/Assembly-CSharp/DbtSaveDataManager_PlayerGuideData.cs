using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006F")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerGuideData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerGuideData, PlayerGuideData>
{
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3D20238", Offset = "0x3D1C238", VA = "0x3D20238")]
	public DbtSaveDataManager_PlayerGuideData()
	{
	}
}
