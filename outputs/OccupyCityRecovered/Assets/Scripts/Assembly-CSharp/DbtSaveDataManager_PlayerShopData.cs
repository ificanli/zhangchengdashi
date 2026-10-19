using Beebyte.Obfuscator;
using DataModule;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000065")]
[Skip]
[ModelRegister("ljzs_lt", true, false)]
public class DbtSaveDataManager_PlayerShopData : DbtSaveDataManagerBase<DbtSaveDataManager_PlayerShopData, PlayerShopData>
{
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x3D1FF18", Offset = "0x3D1BF18", VA = "0x3D1FF18")]
	public DbtSaveDataManager_PlayerShopData()
	{
	}
}
