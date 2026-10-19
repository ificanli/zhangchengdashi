using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D10")]
	public class PathSettings : MonoBehaviour
	{
		[Token(Token = "0x4005D79")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Default root path for models")]
		public RootPathEnum defaultRootPath;

		[Token(Token = "0x4005D7A")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Root path for models on mobile devices")]
		public RootPathEnum mobileRootPath;

		[Token(Token = "0x17000E54")]
		public string RootPath
		{
			[Token(Token = "0x6005144")]
			[Address(RVA = "0x42D8850", Offset = "0x42D4850", VA = "0x42D8850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005145")]
		[Address(RVA = "0x42DB4E4", Offset = "0x42D74E4", VA = "0x42DB4E4")]
		public static PathSettings FindPathComponent(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6005146")]
		[Address(RVA = "0x42DB5F8", Offset = "0x42D75F8", VA = "0x42DB5F8")]
		public string FullPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6005147")]
		[Address(RVA = "0x42DB688", Offset = "0x42D7688", VA = "0x42DB688")]
		public PathSettings()
		{
		}
	}
}
