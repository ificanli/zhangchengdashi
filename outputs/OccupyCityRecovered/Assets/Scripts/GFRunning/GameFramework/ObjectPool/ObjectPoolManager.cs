using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x200045E")]
	public sealed class ObjectPoolManager : GameFrameModule, IObjectPoolManager
	{
		[Token(Token = "0x200045F")]
		private sealed class Object<T> where T : ObjectBase
		{
			[Token(Token = "0x4001E3E")]
			[FieldOffset(Offset = "0x0")]
			private readonly T m_Object;

			[Token(Token = "0x4001E3F")]
			[FieldOffset(Offset = "0x0")]
			private int m_SpawnCount;

			[Token(Token = "0x170011C5")]
			public string Name
			{
				[Token(Token = "0x6006B7B")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011C6")]
			public bool Locked
			{
				[Token(Token = "0x6006B7C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B7D")]
				internal set
				{
				}
			}

			[Token(Token = "0x170011C7")]
			public int Priority
			{
				[Token(Token = "0x6006B7E")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B7F")]
				internal set
				{
				}
			}

			[Token(Token = "0x170011C8")]
			public DateTime LastUseTime
			{
				[Token(Token = "0x6006B80")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170011C9")]
			public bool IsInUse
			{
				[Token(Token = "0x6006B81")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170011CA")]
			public int SpawnCount
			{
				[Token(Token = "0x6006B82")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6006B7A")]
			public Object(T obj, bool spawned)
			{
			}

			[Token(Token = "0x6006B83")]
			public T Peek()
			{
				return null;
			}

			[Token(Token = "0x6006B84")]
			public T Spawn()
			{
				return null;
			}

			[Token(Token = "0x6006B85")]
			public void Unspawn()
			{
			}

			[Token(Token = "0x6006B86")]
			public void Release()
			{
			}
		}

		[Token(Token = "0x2000460")]
		private sealed class ObjectPool<T> : ObjectPoolBase, IObjectPool<T> where T : ObjectBase
		{
			[Token(Token = "0x4001E40")]
			[FieldOffset(Offset = "0x0")]
			private readonly LinkedList<Object<T>> m_Objects;

			[Token(Token = "0x4001E41")]
			[FieldOffset(Offset = "0x0")]
			private readonly bool m_AllowMultiSpawn;

			[Token(Token = "0x4001E42")]
			[FieldOffset(Offset = "0x0")]
			private float m_AutoReleaseInterval;

			[Token(Token = "0x4001E43")]
			[FieldOffset(Offset = "0x0")]
			private int m_Capacity;

			[Token(Token = "0x4001E44")]
			[FieldOffset(Offset = "0x0")]
			private float m_ExpireTime;

			[Token(Token = "0x4001E45")]
			[FieldOffset(Offset = "0x0")]
			private int m_Priority;

			[Token(Token = "0x4001E46")]
			[FieldOffset(Offset = "0x0")]
			private float m_AutoReleaseTime;

			[Token(Token = "0x170011CB")]
			public override Type ObjectType
			{
				[Token(Token = "0x6006B88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170011CC")]
			public override int Count
			{
				[Token(Token = "0x6006B89")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170011CD")]
			public override int CanReleaseCount
			{
				[Token(Token = "0x6006B8A")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170011CE")]
			public override bool AllowMultiSpawn
			{
				[Token(Token = "0x6006B8B")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170011CF")]
			public override float AutoReleaseInterval
			{
				[Token(Token = "0x6006B8C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B8D")]
				set
				{
				}
			}

			[Token(Token = "0x170011D0")]
			public override int Capacity
			{
				[Token(Token = "0x6006B8E")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B8F")]
				set
				{
				}
			}

			[Token(Token = "0x170011D1")]
			public override float ExpireTime
			{
				[Token(Token = "0x6006B90")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B91")]
				set
				{
				}
			}

			[Token(Token = "0x170011D2")]
			public override int Priority
			{
				[Token(Token = "0x6006B92")]
				get
				{
					return default;
				}
				[Token(Token = "0x6006B93")]
				set
				{
				}
			}

			[Token(Token = "0x6006B87")]
			public ObjectPool(string name, bool allowMultiSpawn, int capacity, float expireTime, int priority)
			{
			}

			[Token(Token = "0x6006B94")]
			public void Register(T obj, bool spawned)
			{
			}

			[Token(Token = "0x6006B95")]
			public bool CanSpawn()
			{
				return default;
			}

			[Token(Token = "0x6006B96")]
			public bool CanSpawn(string name)
			{
				return default;
			}

			[Token(Token = "0x6006B97")]
			public T Spawn()
			{
				return null;
			}

			[Token(Token = "0x6006B98")]
			public T Spawn(string name)
			{
				return null;
			}

			[Token(Token = "0x6006B99")]
			public void Unspawn(T obj)
			{
			}

			[Token(Token = "0x6006B9A")]
			public void Unspawn(int hashCode)
			{
			}

			[Token(Token = "0x6006B9B")]
			public void Unspawn(object target)
			{
			}

			[Token(Token = "0x6006B9C")]
			public void SetLocked(T obj, bool locked)
			{
			}

			[Token(Token = "0x6006B9D")]
			public void SetLocked(object target, bool locked)
			{
			}

			[Token(Token = "0x6006B9E")]
			public void SetPriority(T obj, int priority)
			{
			}

			[Token(Token = "0x6006B9F")]
			public void SetPriority(object target, int priority)
			{
			}

			[Token(Token = "0x6006BA0")]
			public override void Release()
			{
			}

			[Token(Token = "0x6006BA1")]
			public override void Release(int toReleaseCount)
			{
			}

			[Token(Token = "0x6006BA2")]
			public void Release(ReleaseObjectFilterCallback<T> releaseObjectFilterCallback)
			{
			}

			[Token(Token = "0x6006BA3")]
			public void Release(int toReleaseCount, ReleaseObjectFilterCallback<T> releaseObjectFilterCallback)
			{
			}

			[Token(Token = "0x6006BA4")]
			public override void ReleaseAllUnused()
			{
			}

			[Token(Token = "0x6006BA5")]
			public override ObjectInfo[] GetAllObjectInfos()
			{
				return null;
			}

			[Token(Token = "0x6006BA6")]
			internal override void Update(float elapseSeconds, float realElapseSeconds)
			{
			}

			[Token(Token = "0x6006BA7")]
			internal override void Shutdown()
			{
			}

			[Token(Token = "0x6006BA8")]
			private LinkedList<T> GetCanReleaseObjects()
			{
				return null;
			}

			[Token(Token = "0x6006BA9")]
			private LinkedList<T> DefaultReleaseObjectFilterCallback(LinkedList<T> candidateObjects, int toReleaseCount, DateTime expireTime)
			{
				return null;
			}
		}

		[Token(Token = "0x4001E3A")]
		private const int DefaultCapacity = int.MaxValue;

		[Token(Token = "0x4001E3B")]
		private const float DefaultExpireTime = float.MaxValue;

		[Token(Token = "0x4001E3C")]
		private const int DefaultPriority = 0;

		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, ObjectPoolBase> m_ObjectPools;

		[Token(Token = "0x170011C3")]
		internal override int Priority
		{
			[Token(Token = "0x6006B25")]
			[Address(RVA = "0x7282A8C", Offset = "0x727EA8C", VA = "0x7282A8C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170011C4")]
		public int Count
		{
			[Token(Token = "0x6006B26")]
			[Address(RVA = "0x7282A94", Offset = "0x727EA94", VA = "0x7282A94", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6006B23")]
		[Address(RVA = "0x72829E8", Offset = "0x727E9E8", VA = "0x72829E8", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x7282A0C", Offset = "0x727EA0C", VA = "0x7282A0C")]
		public ObjectPoolManager()
		{
		}

		[Token(Token = "0x6006B27")]
		[Address(RVA = "0x7282AE4", Offset = "0x727EAE4", VA = "0x7282AE4", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6006B28")]
		[Address(RVA = "0x7282AE8", Offset = "0x727EAE8", VA = "0x7282AE8", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6006B29")]
		[Address(RVA = "0x7282C64", Offset = "0x727EC64", VA = "0x7282C64", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6006B2A")]
		public bool HasObjectPool<T>() where T : ObjectBase
		{
			return default;
		}

		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0x7282DF0", Offset = "0x727EDF0", VA = "0x7282DF0", Slot = "12")]
		public bool HasObjectPool(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6006B2C")]
		public bool HasObjectPool<T>(string name) where T : ObjectBase
		{
			return default;
		}

		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0x7282F84", Offset = "0x727EF84", VA = "0x7282F84", Slot = "14")]
		public bool HasObjectPool(Type objectType, string name)
		{
			return default;
		}

		[Token(Token = "0x6006B2E")]
		public IObjectPool<T> GetObjectPool<T>() where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0x7283048", Offset = "0x727F048", VA = "0x7283048", Slot = "16")]
		public ObjectPoolBase GetObjectPool(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6006B30")]
		public IObjectPool<T> GetObjectPool<T>(string name) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B31")]
		[Address(RVA = "0x728319C", Offset = "0x727F19C", VA = "0x728319C", Slot = "18")]
		public ObjectPoolBase GetObjectPool(Type objectType, string name)
		{
			return null;
		}

		[Token(Token = "0x6006B32")]
		[Address(RVA = "0x7283338", Offset = "0x727F338", VA = "0x7283338", Slot = "19")]
		public ObjectPoolBase[] GetAllObjectPools()
		{
			return null;
		}

		[Token(Token = "0x6006B33")]
		[Address(RVA = "0x7283340", Offset = "0x727F340", VA = "0x7283340", Slot = "20")]
		public ObjectPoolBase[] GetAllObjectPools(bool sort)
		{
			return null;
		}

		[Token(Token = "0x6006B34")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>() where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B35")]
		[Address(RVA = "0x7283634", Offset = "0x727F634", VA = "0x7283634", Slot = "22")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6006B36")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B37")]
		[Address(RVA = "0x7283B6C", Offset = "0x727FB6C", VA = "0x7283B6C", Slot = "24")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name)
		{
			return null;
		}

		[Token(Token = "0x6006B38")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(int capacity) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B39")]
		[Address(RVA = "0x7283B84", Offset = "0x727FB84", VA = "0x7283B84", Slot = "26")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, int capacity)
		{
			return null;
		}

		[Token(Token = "0x6006B3A")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B3B")]
		[Address(RVA = "0x7283BFC", Offset = "0x727FBFC", VA = "0x7283BFC", Slot = "28")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B3C")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, int capacity) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B3D")]
		[Address(RVA = "0x7283C78", Offset = "0x727FC78", VA = "0x7283C78", Slot = "30")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, int capacity)
		{
			return null;
		}

		[Token(Token = "0x6006B3E")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0x7283C90", Offset = "0x727FC90", VA = "0x7283C90", Slot = "32")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B40")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(int capacity, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B41")]
		[Address(RVA = "0x7283CA0", Offset = "0x727FCA0", VA = "0x7283CA0", Slot = "34")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, int capacity, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B42")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(int capacity, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B43")]
		[Address(RVA = "0x7283D20", Offset = "0x727FD20", VA = "0x7283D20", Slot = "36")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, int capacity, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B44")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x7283DA4", Offset = "0x727FDA4", VA = "0x7283DA4", Slot = "38")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B46")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, int capacity, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B47")]
		[Address(RVA = "0x7283E24", Offset = "0x727FE24", VA = "0x7283E24", Slot = "40")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, int capacity, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B48")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, int capacity, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B49")]
		[Address(RVA = "0x7283E34", Offset = "0x727FE34", VA = "0x7283E34", Slot = "42")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, int capacity, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B4A")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B4B")]
		[Address(RVA = "0x7283E4C", Offset = "0x727FE4C", VA = "0x7283E4C", Slot = "44")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B4C")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(int capacity, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B4D")]
		[Address(RVA = "0x7283E5C", Offset = "0x727FE5C", VA = "0x7283E5C", Slot = "46")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, int capacity, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B4E")]
		public IObjectPool<T> CreateSingleSpawnObjectPool<T>(string name, int capacity, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0x7283EE8", Offset = "0x727FEE8", VA = "0x7283EE8", Slot = "48")]
		public ObjectPoolBase CreateSingleSpawnObjectPool(Type objectType, string name, int capacity, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B50")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>() where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B51")]
		[Address(RVA = "0x7283EF8", Offset = "0x727FEF8", VA = "0x7283EF8", Slot = "50")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType)
		{
			return null;
		}

		[Token(Token = "0x6006B52")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B53")]
		[Address(RVA = "0x7283F6C", Offset = "0x727FF6C", VA = "0x7283F6C", Slot = "52")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name)
		{
			return null;
		}

		[Token(Token = "0x6006B54")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(int capacity) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B55")]
		[Address(RVA = "0x7283F84", Offset = "0x727FF84", VA = "0x7283F84", Slot = "54")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, int capacity)
		{
			return null;
		}

		[Token(Token = "0x6006B56")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B57")]
		[Address(RVA = "0x7283FFC", Offset = "0x727FFFC", VA = "0x7283FFC", Slot = "56")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B58")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, int capacity) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B59")]
		[Address(RVA = "0x7284078", Offset = "0x7280078", VA = "0x7284078", Slot = "58")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, int capacity)
		{
			return null;
		}

		[Token(Token = "0x6006B5A")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B5B")]
		[Address(RVA = "0x7284090", Offset = "0x7280090", VA = "0x7284090", Slot = "60")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B5C")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(int capacity, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0x72840A0", Offset = "0x72800A0", VA = "0x72840A0", Slot = "62")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, int capacity, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B5E")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(int capacity, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0x7284120", Offset = "0x7280120", VA = "0x7284120", Slot = "64")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, int capacity, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B60")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B61")]
		[Address(RVA = "0x72841A4", Offset = "0x72801A4", VA = "0x72841A4", Slot = "66")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B62")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, int capacity, float expireTime) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B63")]
		[Address(RVA = "0x7284224", Offset = "0x7280224", VA = "0x7284224", Slot = "68")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, int capacity, float expireTime)
		{
			return null;
		}

		[Token(Token = "0x6006B64")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, int capacity, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B65")]
		[Address(RVA = "0x7284234", Offset = "0x7280234", VA = "0x7284234", Slot = "70")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, int capacity, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B66")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B67")]
		[Address(RVA = "0x728424C", Offset = "0x728024C", VA = "0x728424C", Slot = "72")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B68")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(int capacity, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B69")]
		[Address(RVA = "0x728425C", Offset = "0x728025C", VA = "0x728425C", Slot = "74")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, int capacity, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B6A")]
		public IObjectPool<T> CreateMultiSpawnObjectPool<T>(string name, int capacity, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0x72842E8", Offset = "0x72802E8", VA = "0x72842E8", Slot = "76")]
		public ObjectPoolBase CreateMultiSpawnObjectPool(Type objectType, string name, int capacity, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B6C")]
		public bool DestroyObjectPool<T>() where T : ObjectBase
		{
			return default;
		}

		[Token(Token = "0x6006B6D")]
		[Address(RVA = "0x72842F8", Offset = "0x72802F8", VA = "0x72842F8", Slot = "78")]
		public bool DestroyObjectPool(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6006B6E")]
		public bool DestroyObjectPool<T>(string name) where T : ObjectBase
		{
			return default;
		}

		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0x7284568", Offset = "0x7280568", VA = "0x7284568", Slot = "80")]
		public bool DestroyObjectPool(Type objectType, string name)
		{
			return default;
		}

		[Token(Token = "0x6006B70")]
		public bool DestroyObjectPool<T>(IObjectPool<T> objectPool) where T : ObjectBase
		{
			return default;
		}

		[Token(Token = "0x6006B71")]
		[Address(RVA = "0x7284704", Offset = "0x7280704", VA = "0x7284704", Slot = "82")]
		public bool DestroyObjectPool(ObjectPoolBase objectPool)
		{
			return default;
		}

		[Token(Token = "0x6006B72")]
		[Address(RVA = "0x7284790", Offset = "0x7280790", VA = "0x7284790", Slot = "83")]
		public void Release()
		{
		}

		[Token(Token = "0x6006B73")]
		[Address(RVA = "0x7284800", Offset = "0x7280800", VA = "0x7284800", Slot = "84")]
		public void ReleaseAllUnused()
		{
		}

		[Token(Token = "0x6006B74")]
		[Address(RVA = "0x7282F2C", Offset = "0x727EF2C", VA = "0x7282F2C")]
		private bool InternalHasObjectPool(string fullName)
		{
			return default;
		}

		[Token(Token = "0x6006B75")]
		[Address(RVA = "0x7283124", Offset = "0x727F124", VA = "0x7283124")]
		private ObjectPoolBase InternelGetObjectPool(string fullName)
		{
			return null;
		}

		[Token(Token = "0x6006B76")]
		private IObjectPool<T> InternalCreateObjectPool<T>(string name, bool allowMultiSpawn, int capacity, float expireTime, int priority) where T : ObjectBase
		{
			return null;
		}

		[Token(Token = "0x6006B77")]
		[Address(RVA = "0x72836A8", Offset = "0x727F6A8", VA = "0x72836A8")]
		private ObjectPoolBase InternalCreateObjectPool(Type objectType, string name, bool allowMultiSpawn, int capacity, float expireTime, int priority)
		{
			return null;
		}

		[Token(Token = "0x6006B78")]
		[Address(RVA = "0x72844AC", Offset = "0x72804AC", VA = "0x72844AC")]
		private bool InternalDestroyObjectPool(string fullName)
		{
			return default;
		}

		[Token(Token = "0x6006B79")]
		[Address(RVA = "0x7284870", Offset = "0x7280870", VA = "0x7284870")]
		private int ObjectPoolComparer(ObjectPoolBase a, ObjectPoolBase b)
		{
			return default;
		}
	}
}
