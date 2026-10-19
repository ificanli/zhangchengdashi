using System.Collections.Generic;
using System.Numerics;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000578")]
	public class RewardBoostCtrl
	{
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, float> _floatBoostDic;

		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, int> _intBoostDic;

		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, BigInteger> _bigIntBoostDic;

		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, List<bool>> _boolBoostDic;

		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x3ECED88", Offset = "0x3ECAD88", VA = "0x3ECED88")]
		public void AddBoost(string key, float value)
		{
		}

		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x3ECEE58", Offset = "0x3ECAE58", VA = "0x3ECEE58")]
		public void AddBoost(string key, int value)
		{
		}

		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x3ECEF28", Offset = "0x3ECAF28", VA = "0x3ECEF28")]
		public void AddBoost(string key, BigInteger value)
		{
		}

		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x3ECF054", Offset = "0x3ECB054", VA = "0x3ECF054")]
		public void AddBoost(string key, bool value)
		{
		}

		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x3ECF21C", Offset = "0x3ECB21C", VA = "0x3ECF21C")]
		public float GetFloatFinalValue(string key)
		{
			return default;
		}

		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x3ECF278", Offset = "0x3ECB278", VA = "0x3ECF278")]
		public int GetIntFinalValue(string key)
		{
			return default;
		}

		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x3ECF2D4", Offset = "0x3ECB2D4", VA = "0x3ECF2D4")]
		public BigInteger GetBigIntFinalValue(string key)
		{
			return default;
		}

		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x3ECF368", Offset = "0x3ECB368", VA = "0x3ECF368")]
		public bool GetBoolFinalValue(string key)
		{
			return default;
		}

		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x3ECF404", Offset = "0x3ECB404", VA = "0x3ECF404")]
		public RewardBoostCtrl()
		{
		}
	}
}
