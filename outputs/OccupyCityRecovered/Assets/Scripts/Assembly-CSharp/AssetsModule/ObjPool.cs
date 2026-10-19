using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x200064D")]
	public class ObjPool
	{
		[Token(Token = "0x400336D")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameObject _prefab;

		[Token(Token = "0x400336E")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<PoolObjBase> _pool;

		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x20")]
		private readonly Transform _poolTrans;

		[Token(Token = "0x600212D")]
		[Address(RVA = "0x3F20978", Offset = "0x3F1C978", VA = "0x3F20978")]
		public ObjPool(GameObject prefab, int initialSize, bool uiPool = false)
		{
		}

		[Token(Token = "0x600212E")]
		[Address(RVA = "0x3F21E70", Offset = "0x3F1DE70", VA = "0x3F21E70")]
		private PoolObjBase CreateNewObject()
		{
			return null;
		}

		[Token(Token = "0x600212F")]
		[Address(RVA = "0x3F1F3B4", Offset = "0x3F1B3B4", VA = "0x3F1F3B4")]
		public PoolObjBase GetObject(float delayRecycleTime = -1f)
		{
			return null;
		}

		[Token(Token = "0x6002130")]
		[Address(RVA = "0x3F20B2C", Offset = "0x3F1CB2C", VA = "0x3F20B2C")]
		public void EnsureSize(int targetSize)
		{
		}

		[Token(Token = "0x6002131")]
		[Address(RVA = "0x3F2205C", Offset = "0x3F1E05C", VA = "0x3F2205C")]
		private PoolObjBase GetPoolObjBase(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6002132")]
		[Address(RVA = "0x3F1F838", Offset = "0x3F1B838", VA = "0x3F1F838")]
		public void Clean()
		{
		}

		[Token(Token = "0x6002133")]
		[Address(RVA = "0x3F1F71C", Offset = "0x3F1B71C", VA = "0x3F1F71C")]
		public void RecycleAll()
		{
		}

		[Token(Token = "0x6002134")]
		public bool HasComponent<T>() where T : Component
		{
			return default;
		}
	}
}
