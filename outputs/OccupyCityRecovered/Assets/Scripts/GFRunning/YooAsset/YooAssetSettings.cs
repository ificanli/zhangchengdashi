using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	[Token(Token = "0x2000133")]
	[CreateAssetMenu(fileName = "YooAssetSettings", menuName = "YooAsset/Create YooAsset Settings")]
	public class YooAssetSettings : ScriptableObject
	{
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x18")]
		public string ManifestFileName;

		[Token(Token = "0x4000484")]
		public const int ManifestFileMaxSize = 104857600;

		[Token(Token = "0x4000485")]
		public const string CacheBundleDataFileName = "__data";

		[Token(Token = "0x4000486")]
		public const string CacheBundleInfoFileName = "__info";

		[Token(Token = "0x4000487")]
		public const string DefaultYooFolderName = "ResPackage";

		[Token(Token = "0x4000488")]
		public const string CachedBundleFileFolder = "CacheBundleFiles";

		[Token(Token = "0x4000489")]
		public const string CachedRawFileFolder = "CacheRawFiles";

		[Token(Token = "0x400048A")]
		public const string ManifestFolderName = "ManifestFiles";

		[Token(Token = "0x400048B")]
		public const string AppFootPrintFileName = "ApplicationFootPrint.bytes";

		[Token(Token = "0x400048C")]
		public const string OutputFolderName = "OutputCache";

		[Token(Token = "0x400048D")]
		public const string ReportFileName = "BuildReport";

		[Token(Token = "0x400048E")]
		public const string BuildInResTagName = "in";

		[Token(Token = "0x6001101")]
		[Address(RVA = "0x73497CC", Offset = "0x73457CC", VA = "0x73497CC")]
		public YooAssetSettings()
		{
		}
	}
}
