using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GameFramework
{
	[Token(Token = "0x200000C")]
	public class ModelClick : MonoBehaviour
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent unityEvent;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		public bool needCheck;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7067EDC", Offset = "0x7063EDC", VA = "0x7067EDC")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7067EE8", Offset = "0x7063EE8", VA = "0x7067EE8", Slot = "4")]
		protected virtual void MouseDown()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7067F70", Offset = "0x7063F70", VA = "0x7067F70", Slot = "5")]
		protected virtual bool NeedCheck()
		{
			return default;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x7067F78", Offset = "0x7063F78", VA = "0x7067F78")]
		public ModelClick()
		{
		}
	}
}
