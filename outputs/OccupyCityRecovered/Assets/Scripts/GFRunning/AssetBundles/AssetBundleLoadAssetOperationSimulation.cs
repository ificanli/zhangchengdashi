using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x20001A1")]
	public class AssetBundleLoadAssetOperationSimulation : AssetBundleLoadAssetOperation
	{
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x10")]
		private Object m_0060_00AFAf_00A8;

		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x7361AD0", Offset = "0x735DAD0", VA = "0x7361AD0", Slot = "9")]
		public override float Progress()
		{
			return default;
		}

		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x7361AD8", Offset = "0x735DAD8", VA = "0x7361AD8", Slot = "8")]
		public override bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x60013B7")]
		public override T GetAsset<T>()
		{
			return null;
		}

		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x7361AE0", Offset = "0x735DAE0", VA = "0x7361AE0")]
		public AssetBundleLoadAssetOperationSimulation(Object _009D_0084ª_00A8vR)
		{
		}

		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x7361B08", Offset = "0x735DB08", VA = "0x7361B08", Slot = "7")]
		public override bool Update()
		{
			return default;
		}
	}
}
