using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000064")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerCardData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerCardData, PlayerCardData>
{
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x3D1FBA0", Offset = "0x3D1BBA0", VA = "0x3D1FBA0", Slot = "13")]
	protected override void OnBeforeSerializeForSave()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3D1FED0", Offset = "0x3D1BED0", VA = "0x3D1FED0")]
	public DbtSaveDataManager_PlayerCardData()
	{
	}
}
