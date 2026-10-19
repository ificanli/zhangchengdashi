using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x2000461")]
	public delegate LinkedList<T> ReleaseObjectFilterCallback<T>(LinkedList<T> _008FWc_00A2_007B_0081, int _008B_0099X_00A1_0084b, DateTime _008CeuIS_008B) where T : ObjectBase;
}
