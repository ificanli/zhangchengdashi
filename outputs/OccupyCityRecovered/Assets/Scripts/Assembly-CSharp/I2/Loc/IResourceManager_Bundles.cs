using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DBB")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x600551D")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
}
