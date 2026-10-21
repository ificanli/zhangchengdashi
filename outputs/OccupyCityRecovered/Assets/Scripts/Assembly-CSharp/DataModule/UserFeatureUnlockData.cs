using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA7")]
	public class UserFeatureUnlockData : UserDataBase
	{
		[Token(Token = "0x40065E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isUnlock;

		[Token(Token = "0x40065E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> extraData = new Dictionary<string, object>();

		[Token(Token = "0x60058F7")]
		[Address(RVA = "0x4367D88", Offset = "0x4363D88", VA = "0x4367D88")]
		public UserFeatureUnlockData()
		{
		}

		[Token(Token = "0x60058F8")]
		public void SetExtraData<T>(string extraDataId, T value)
		{
		}

		[Token(Token = "0x60058F9")]
		public T GetExtraData<T>(string extraDataId, [Optional] T defaultValue)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UserFeatureUnlockData.GetExtraData RVA= Token=0x60058F9");
}

		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x4367E0C", Offset = "0x4363E0C", VA = "0x4367E0C")]
		public bool HasExtraData(string extraDataId)
		{
			return default;
		}

		[Token(Token = "0x60058FB")]
		[Address(RVA = "0x4367E6C", Offset = "0x4363E6C", VA = "0x4367E6C")]
		public bool RemoveExtraData(string extraDataId)
		{
			return default;
		}

		[Token(Token = "0x60058FC")]
		[Address(RVA = "0x4367ECC", Offset = "0x4363ECC", VA = "0x4367ECC")]
		public void ClearExtraData()
		{
		}
	}
}
