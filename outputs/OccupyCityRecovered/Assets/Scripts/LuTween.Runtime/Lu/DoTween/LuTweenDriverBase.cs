using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Lu.DoTween
{
	[Token(Token = "0x2000004")]
	public class LuTweenDriverBase : MonoBehaviour
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		protected float tweenDuration;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		private Action _onComplete;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x741FB54", Offset = "0x741BB54", VA = "0x741FB54")]
		public LuTweenDriverBase OnComplete(Action completeAction)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x741FB5C", Offset = "0x741BB5C", VA = "0x741FB5C")]
		public LuTweenDriverBase ClearCompleteAction()
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x741FB64", Offset = "0x741BB64", VA = "0x741FB64")]
		protected void InvokeCompleteAction()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x741FB80", Offset = "0x741BB80", VA = "0x741FB80")]
		public LuTweenDriverBase()
		{
		}
	}
}
