using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule
{
	[Token(Token = "0x2000FD1")]
	public class AppBuildVersion
	{
		[Token(Token = "0x4006BF0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string m_AppBuildTestApkVer;

		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x43FEEC4", Offset = "0x43FAEC4", VA = "0x43FEEC4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void ShowAppBuildVersion()
		{
		}

		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x43FEFC0", Offset = "0x43FAFC0", VA = "0x43FEFC0")]
		public AppBuildVersion()
		{
		}
	}
}
