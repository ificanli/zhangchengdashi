using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DB9")]
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		[Token(Token = "0x6005514")]
		[Address(RVA = "0x432BC2C", Offset = "0x4327C2C", VA = "0x432BC2C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6005515")]
		[Address(RVA = "0x432BCC4", Offset = "0x4327CC4", VA = "0x432BCC4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6005516")]
		[Address(RVA = "0x432BD5C", Offset = "0x4327D5C", VA = "0x432BD5C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6005517")]
		[Address(RVA = "0x432BDB4", Offset = "0x4327DB4", VA = "0x432BDB4", Slot = "4")]
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default;
		}

		[Token(Token = "0x6005518")]
		[Address(RVA = "0x432BDBC", Offset = "0x4327DBC", VA = "0x432BDBC")]
		public RegisterCallback_AllowSyncFromGoogle()
		{
		}
	}
}
