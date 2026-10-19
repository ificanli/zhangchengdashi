using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D63")]
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x4305D4C", Offset = "0x4301D4C", VA = "0x4305D4C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x4305E30", Offset = "0x4301E30", VA = "0x4305E30")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x4305E90", Offset = "0x4301E90", VA = "0x4305E90", Slot = "5")]
		public virtual UnityEngine.Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}

		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x4305E98", Offset = "0x4301E98", VA = "0x4305E98")]
		public RegisterBundlesManager()
		{
		}
	}
}
