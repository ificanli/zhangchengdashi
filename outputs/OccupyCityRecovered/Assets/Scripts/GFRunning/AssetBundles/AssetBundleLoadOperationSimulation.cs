using Il2CppDummyDll;
using UnityEngine;

namespace AssetBundles
{
	[Token(Token = "0x20001A4")]
	public class AssetBundleLoadOperationSimulation : AssetBundleLoadBundleOperation
	{
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x10")]
		public Object m_SimulatedObject;

		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x7361DD8", Offset = "0x735DDD8", VA = "0x7361DD8", Slot = "8")]
		public override bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x7361DE0", Offset = "0x735DDE0", VA = "0x7361DE0", Slot = "9")]
		public override float Progress()
		{
			return default;
		}

		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x7361DE8", Offset = "0x735DDE8", VA = "0x7361DE8", Slot = "7")]
		public override bool Update()
		{
			return default;
		}

		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x7361DF0", Offset = "0x735DDF0", VA = "0x7361DF0")]
		public AssetBundleLoadOperationSimulation(Object _009D_0084ª_00A8vR)
		{
		}

		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x7361E18", Offset = "0x735DE18", VA = "0x7361E18", Slot = "10")]
		public override LoadedAssetBundle GetAssetBundle()
		{
			return null;
		}
	}
}
