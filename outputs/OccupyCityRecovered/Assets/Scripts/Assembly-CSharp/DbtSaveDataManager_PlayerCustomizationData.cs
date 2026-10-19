using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006D")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerCustomizationData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerCustomizationData, PlayerCustomizationData>
{
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x3D201A8", Offset = "0x3D1C1A8", VA = "0x3D201A8")]
	public DbtSaveDataManager_PlayerCustomizationData()
	{
	}
}
