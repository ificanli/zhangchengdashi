using System;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x200045D")]
	public abstract class ObjectPoolBase
	{
		[Token(Token = "0x4001E39")]
		[FieldOffset(Offset = "0x10")]
		private readonly string g_0085eq_00BC_005E;

		[Token(Token = "0x170011BA")]
		public string Name
		{
			[Token(Token = "0x6006B10")]
			[Address(RVA = "0x72829E0", Offset = "0x727E9E0", VA = "0x72829E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BB")]
		public abstract Type ObjectType
		{
			[Token(Token = "0x6006B11")]
			get;
		}

		[Token(Token = "0x170011BC")]
		public abstract int Count
		{
			[Token(Token = "0x6006B12")]
			get;
		}

		[Token(Token = "0x170011BD")]
		public abstract int CanReleaseCount
		{
			[Token(Token = "0x6006B13")]
			get;
		}

		[Token(Token = "0x170011BE")]
		public abstract bool AllowMultiSpawn
		{
			[Token(Token = "0x6006B14")]
			get;
		}

		[Token(Token = "0x170011BF")]
		public abstract float AutoReleaseInterval
		{
			[Token(Token = "0x6006B15")]
			get;
			[Token(Token = "0x6006B16")]
			set;
		}

		[Token(Token = "0x170011C0")]
		public abstract int Capacity
		{
			[Token(Token = "0x6006B17")]
			get;
			[Token(Token = "0x6006B18")]
			set;
		}

		[Token(Token = "0x170011C1")]
		public abstract float ExpireTime
		{
			[Token(Token = "0x6006B19")]
			get;
			[Token(Token = "0x6006B1A")]
			set;
		}

		[Token(Token = "0x170011C2")]
		public abstract int Priority
		{
			[Token(Token = "0x6006B1B")]
			get;
			[Token(Token = "0x6006B1C")]
			set;
		}

		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0x728296C", Offset = "0x727E96C", VA = "0x728296C")]
		public ObjectPoolBase()
		{
		}

		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0x7282974", Offset = "0x727E974", VA = "0x7282974")]
		public ObjectPoolBase(string _00AE_008C_009AiPJ)
		{
		}

		[Token(Token = "0x6006B1D")]
		public abstract void Release();

		[Token(Token = "0x6006B1E")]
		public abstract void Release(int _008B_0099X_00A1_0084b);

		[Token(Token = "0x6006B1F")]
		public abstract void ReleaseAllUnused();

		[Token(Token = "0x6006B20")]
		public abstract ObjectInfo[] GetAllObjectInfos();

		[Token(Token = "0x6006B21")]
		internal abstract void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L);

		[Token(Token = "0x6006B22")]
		internal abstract void Shutdown();
	}
}
