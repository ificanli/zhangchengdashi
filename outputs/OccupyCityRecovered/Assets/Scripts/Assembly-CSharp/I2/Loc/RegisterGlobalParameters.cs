using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DBA")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x432BDC4", Offset = "0x4327DC4", VA = "0x432BDC4", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600551A")]
		[Address(RVA = "0x432BEE0", Offset = "0x4327EE0", VA = "0x432BEE0", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x600551B")]
		[Address(RVA = "0x432BF60", Offset = "0x4327F60", VA = "0x432BF60", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600551C")]
		[Address(RVA = "0x432BF68", Offset = "0x4327F68", VA = "0x432BF68")]
		public RegisterGlobalParameters()
		{
		}
	}
}
