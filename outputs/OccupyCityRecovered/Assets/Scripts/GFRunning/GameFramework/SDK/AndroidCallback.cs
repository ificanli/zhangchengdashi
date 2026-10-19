using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.SDK
{
	[Token(Token = "0x20004E3")]
	public class AndroidCallback : AndroidJavaProxy
	{
		[Token(Token = "0x4001FF7")]
		[FieldOffset(Offset = "0x20")]
		private Action<string, string> _Delegate;

		[Token(Token = "0x6007483")]
		[Address(RVA = "0x72FAAE0", Offset = "0x72F6AE0", VA = "0x72FAAE0")]
		public AndroidCallback(Action<string, string> sdkdelegate) : base("com.common.game.callback.GameCallbackInterface")
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AndroidCallback..ctor RVA=0x72FAAE0 Token=0x06007483; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6007484")]
		[Address(RVA = "0x72FAB64", Offset = "0x72F6B64", VA = "0x72FAB64")]
		public void callback(string id, string json)
		{
		}
	}
}
