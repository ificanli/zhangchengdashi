using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000066")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerArenaData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerArenaData, PlayerArenaData>
{
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x3D1FF60", Offset = "0x3D1BF60", VA = "0x3D1FF60")]
	public DbtSaveDataManager_PlayerArenaData()
	{
	}
}
