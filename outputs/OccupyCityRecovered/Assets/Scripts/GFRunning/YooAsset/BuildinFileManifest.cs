using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	[Token(Token = "0x200009B")]
	public class BuildinFileManifest : ScriptableObject
	{
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x18")]
		public List<string> BuildinFiles;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x72C2DA0", Offset = "0x72BEDA0", VA = "0x72C2DA0")]
		public BuildinFileManifest()
		{
		}
	}
}
