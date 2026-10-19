using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x2000644")]
	public class LoopEffectRuntimeOverrideHandler : MonoBehaviour
	{
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x20")]
		private Action _restoreAction;

		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x3F18B88", Offset = "0x3F14B88", VA = "0x3F18B88")]
		public void SetRestoreAction(Action restoreAction)
		{
		}

		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x3F147D0", Offset = "0x3F107D0", VA = "0x3F147D0")]
		public void RestoreNow()
		{
		}

		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x3F18B90", Offset = "0x3F14B90", VA = "0x3F18B90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x3F18B94", Offset = "0x3F14B94", VA = "0x3F18B94")]
		public LoopEffectRuntimeOverrideHandler()
		{
		}
	}
}
