using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x200006C")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerArtifactData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerArtifactData, PlayerArtifactData>
{
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x3D20110", Offset = "0x3D1C110", VA = "0x3D20110", Slot = "13")]
	protected override void OnBeforeSerializeForSave()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x3D20160", Offset = "0x3D1C160", VA = "0x3D20160")]
	public DbtSaveDataManager_PlayerArtifactData()
	{
	}
}
