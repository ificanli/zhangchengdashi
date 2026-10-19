using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityFBXExporter
{
	[Token(Token = "0x2000D47")]
	public class FBXUnityMeshGetter
	{
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x42FBBD4", Offset = "0x42F7BD4", VA = "0x42FBBD4")]
		public static long GetMeshToString(GameObject gameObj, Material[] materials, ref StringBuilder objects, ref StringBuilder connections, [Optional] GameObject parentObject, long parentModelId = 0L)
		{
			return default;
		}

		[Token(Token = "0x6005241")]
		[Address(RVA = "0x42FEDE8", Offset = "0x42FADE8", VA = "0x42FEDE8")]
		public FBXUnityMeshGetter()
		{
		}
	}
}
