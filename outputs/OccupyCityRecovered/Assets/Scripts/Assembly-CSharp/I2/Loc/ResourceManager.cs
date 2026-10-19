using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Token(Token = "0x2000DBC")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x4006069")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x400606A")]
		[FieldOffset(Offset = "0x20")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x400606B")]
		[FieldOffset(Offset = "0x28")]
		public Object[] Assets;

		[Token(Token = "0x400606C")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, Object> mResourcesCache;

		[Token(Token = "0x17000E7A")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x600551E")]
			[Address(RVA = "0x431E028", Offset = "0x431A028", VA = "0x431E028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600551F")]
		[Address(RVA = "0x432BF70", Offset = "0x4327F70", VA = "0x432BF70")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6005520")]
		public T GetAsset<T>(string Name) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6005521")]
		[Address(RVA = "0x432C034", Offset = "0x4328034", VA = "0x432C034")]
		private Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6005522")]
		[Address(RVA = "0x431E3F0", Offset = "0x431A3F0", VA = "0x431E3F0")]
		public bool HasAsset(Object Obj)
		{
			return default;
		}

		[Token(Token = "0x6005523")]
		public T LoadFromResources<T>(string Path) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6005524")]
		public T LoadFromBundle<T>(string path) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6005525")]
		[Address(RVA = "0x432BFC8", Offset = "0x4327FC8", VA = "0x432BFC8")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		}

		[Token(Token = "0x6005526")]
		[Address(RVA = "0x432C158", Offset = "0x4328158", VA = "0x432C158")]
		public ResourceManager()
		{
		}
	}
}
