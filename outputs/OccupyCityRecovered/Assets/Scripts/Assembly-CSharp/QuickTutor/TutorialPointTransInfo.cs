using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C81")]
	public class TutorialPointTransInfo : ITutorialPointInfo
	{
		[Token(Token = "0x40059F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Transform _trans;

		[Token(Token = "0x40059F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Vector3 _halfSize;

		[Token(Token = "0x40059F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly bool _isClickAnywhere;

		[Token(Token = "0x6004E77")]
		[Address(RVA = "0x42A6CD8", Offset = "0x42A2CD8", VA = "0x42A6CD8")]
		public TutorialPointTransInfo(Transform trans, [Optional] Vector3 size)
		{
		}

		[Token(Token = "0x6004E78")]
		[Address(RVA = "0x42A6D60", Offset = "0x42A2D60", VA = "0x42A6D60", Slot = "4")]
		public Vector2 GetUiPos()
		{
			return default;
		}

		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x42A6D84", Offset = "0x42A2D84", VA = "0x42A6D84", Slot = "5")]
		public void OnClick()
		{
		}

		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0x42A6E68", Offset = "0x42A2E68", VA = "0x42A6E68", Slot = "6")]
		public bool IsClickedInRange(Vector3 clickPos)
		{
			return default;
		}

		[Token(Token = "0x6004E7B")]
		[Address(RVA = "0x42A6F44", Offset = "0x42A2F44", VA = "0x42A6F44", Slot = "7")]
		public void GetCenterAndSize(out Vector2 center, out Vector2 size)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TutorialPointTransInfo.GetCenterAndSize RVA=0x42A6F44 Token=0x6004E7B");
}

		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x42A70A4", Offset = "0x42A30A4", VA = "0x42A70A4", Slot = "8")]
		public bool IsEventTriggered(bool isButtonUp, bool isButtonDown, bool isButton)
		{
			return default;
		}
	}
}
