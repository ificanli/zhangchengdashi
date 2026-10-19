using System;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x2000454")]
	public interface IObjectPool<T> where T : ObjectBase
	{
		[Token(Token = "0x170011A4")]
		string Name
		{
			[Token(Token = "0x6006A38")]
			get;
		}

		[Token(Token = "0x170011A5")]
		Type ObjectType
		{
			[Token(Token = "0x6006A39")]
			get;
		}

		[Token(Token = "0x170011A6")]
		int Count
		{
			[Token(Token = "0x6006A3A")]
			get;
		}

		[Token(Token = "0x170011A7")]
		int CanReleaseCount
		{
			[Token(Token = "0x6006A3B")]
			get;
		}

		[Token(Token = "0x170011A8")]
		bool AllowMultiSpawn
		{
			[Token(Token = "0x6006A3C")]
			get;
		}

		[Token(Token = "0x170011A9")]
		float AutoReleaseInterval
		{
			[Token(Token = "0x6006A3D")]
			get;
			[Token(Token = "0x6006A3E")]
			set;
		}

		[Token(Token = "0x170011AA")]
		int Capacity
		{
			[Token(Token = "0x6006A3F")]
			get;
			[Token(Token = "0x6006A40")]
			set;
		}

		[Token(Token = "0x170011AB")]
		float ExpireTime
		{
			[Token(Token = "0x6006A41")]
			get;
			[Token(Token = "0x6006A42")]
			set;
		}

		[Token(Token = "0x170011AC")]
		int Priority
		{
			[Token(Token = "0x6006A43")]
			get;
			[Token(Token = "0x6006A44")]
			set;
		}

		[Token(Token = "0x6006A45")]
		void Register(T _008EBÂ_008F_00BB_008B, bool X_00A6_0083Ei_0092);

		[Token(Token = "0x6006A46")]
		bool CanSpawn();

		[Token(Token = "0x6006A47")]
		bool CanSpawn(string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A48")]
		T Spawn();

		[Token(Token = "0x6006A49")]
		T Spawn(string _00AE_008C_009AiPJ);

		[Token(Token = "0x6006A4A")]
		void Unspawn(T _008EBÂ_008F_00BB_008B);

		[Token(Token = "0x6006A4B")]
		void Unspawn(object f_005B_0098_00B6_008DÀ);

		[Token(Token = "0x6006A4C")]
		void SetLocked(T _008EBÂ_008F_00BB_008B, bool _009Ag_00A8B_005E_0096);

		[Token(Token = "0x6006A4D")]
		void SetLocked(object f_005B_0098_00B6_008DÀ, bool _009Ag_00A8B_005E_0096);

		[Token(Token = "0x6006A4E")]
		void SetPriority(T _008EBÂ_008F_00BB_008B, int rVlHªB);

		[Token(Token = "0x6006A4F")]
		void SetPriority(object f_005B_0098_00B6_008DÀ, int rVlHªB);

		[Token(Token = "0x6006A50")]
		void Release();

		[Token(Token = "0x6006A51")]
		void Release(int _008B_0099X_00A1_0084b);

		[Token(Token = "0x6006A52")]
		void Release(ReleaseObjectFilterCallback<T> _0096mL_0060Â_0096);

		[Token(Token = "0x6006A53")]
		void Release(int _008B_0099X_00A1_0084b, ReleaseObjectFilterCallback<T> _0096mL_0060Â_0096);

		[Token(Token = "0x6006A54")]
		void ReleaseAllUnused();
	}
}
