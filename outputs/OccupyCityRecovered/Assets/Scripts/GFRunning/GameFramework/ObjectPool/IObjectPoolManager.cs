using System;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x2000455")]
	public interface IObjectPoolManager
	{
		[Token(Token = "0x170011AD")]
		int Count
		{
			[Token(Token = "0x6006A55")]
			get;
		}

		[Token(Token = "0x6006A56")]
		bool HasObjectPool<T>() where T : ObjectBase;

		[Token(Token = "0x6006A57")]
		bool HasObjectPool(Type U_0060_007E_00ACvz);

		[Token(Token = "0x6006A58")]
		bool HasObjectPool<T>(string _00AE_008C_009AiPJ) where T : ObjectBase;

		[Token(Token = "0x6006A59")]
		bool HasObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A5A")]
		IObjectPool<T> GetObjectPool<T>() where T : ObjectBase;

		[Token(Token = "0x6006A5B")]
		ObjectPoolBase GetObjectPool(Type U_0060_007E_00ACvz);

		[Token(Token = "0x6006A5C")]
		IObjectPool<T> GetObjectPool<T>(string _00AE_008C_009AiPJ) where T : ObjectBase;

		[Token(Token = "0x6006A5D")]
		ObjectPoolBase GetObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A5E")]
		ObjectPoolBase[] GetAllObjectPools();

		[Token(Token = "0x6006A5F")]
		ObjectPoolBase[] GetAllObjectPools(bool heN_0097_0097F);

		[Token(Token = "0x6006A60")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>() where T : ObjectBase;

		[Token(Token = "0x6006A61")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz);

		[Token(Token = "0x6006A62")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ) where T : ObjectBase;

		[Token(Token = "0x6006A63")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A64")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(int atl_007CÂ_009E) where T : ObjectBase;

		[Token(Token = "0x6006A65")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E);

		[Token(Token = "0x6006A66")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A67")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, float _008CeuIS_008B);

		[Token(Token = "0x6006A68")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E) where T : ObjectBase;

		[Token(Token = "0x6006A69")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E);

		[Token(Token = "0x6006A6A")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A6B")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, float _008CeuIS_008B);

		[Token(Token = "0x6006A6C")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(int atl_007CÂ_009E, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A6D")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, float _008CeuIS_008B);

		[Token(Token = "0x6006A6E")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(int atl_007CÂ_009E, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A6F")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, int rVlHªB);

		[Token(Token = "0x6006A70")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A71")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A72")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A73")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B);

		[Token(Token = "0x6006A74")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A75")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, int rVlHªB);

		[Token(Token = "0x6006A76")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A77")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A78")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A79")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A7A")]
		IObjectPool<T> CreateSingleSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A7B")]
		ObjectPoolBase CreateSingleSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A7C")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>() where T : ObjectBase;

		[Token(Token = "0x6006A7D")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz);

		[Token(Token = "0x6006A7E")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ) where T : ObjectBase;

		[Token(Token = "0x6006A7F")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A80")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(int atl_007CÂ_009E) where T : ObjectBase;

		[Token(Token = "0x6006A81")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E);

		[Token(Token = "0x6006A82")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A83")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, float _008CeuIS_008B);

		[Token(Token = "0x6006A84")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E) where T : ObjectBase;

		[Token(Token = "0x6006A85")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E);

		[Token(Token = "0x6006A86")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A87")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, float _008CeuIS_008B);

		[Token(Token = "0x6006A88")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(int atl_007CÂ_009E, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A89")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, float _008CeuIS_008B);

		[Token(Token = "0x6006A8A")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(int atl_007CÂ_009E, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A8B")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, int rVlHªB);

		[Token(Token = "0x6006A8C")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A8D")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A8E")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B) where T : ObjectBase;

		[Token(Token = "0x6006A8F")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B);

		[Token(Token = "0x6006A90")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A91")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, int rVlHªB);

		[Token(Token = "0x6006A92")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A93")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A94")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A95")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A96")]
		IObjectPool<T> CreateMultiSpawnObjectPool<T>(string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB) where T : ObjectBase;

		[Token(Token = "0x6006A97")]
		ObjectPoolBase CreateMultiSpawnObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ, int atl_007CÂ_009E, float _008CeuIS_008B, int rVlHªB);

		[Token(Token = "0x6006A98")]
		bool DestroyObjectPool<T>() where T : ObjectBase;

		[Token(Token = "0x6006A99")]
		bool DestroyObjectPool(Type U_0060_007E_00ACvz);

		[Token(Token = "0x6006A9A")]
		bool DestroyObjectPool<T>(string _00AE_008C_009AiPJ) where T : ObjectBase;

		[Token(Token = "0x6006A9B")]
		bool DestroyObjectPool(Type U_0060_007E_00ACvz, string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A9C")]
		bool DestroyObjectPool<T>(IObjectPool<T> OHjÂ_009C_0085) where T : ObjectBase;

		[Token(Token = "0x6006A9D")]
		bool DestroyObjectPool(ObjectPoolBase OHjÂ_009C_0085);

		[Token(Token = "0x6006A9E")]
		void Release();

		[Token(Token = "0x6006A9F")]
		void ReleaseAllUnused();
	}
}
