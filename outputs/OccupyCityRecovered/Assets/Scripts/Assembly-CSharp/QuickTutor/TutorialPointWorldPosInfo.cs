using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C82")]
	public class TutorialPointWorldPosInfo : ITutorialPointInfo
	{
		[Token(Token = "0x40059F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Vector3 _worldPos;

		[Token(Token = "0x40059F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly Vector3 _minCorner;

		[Token(Token = "0x40059F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Vector3 _maxCorner;

		[Token(Token = "0x40059F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly bool _isClickAnywhere;

		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x42A70AC", Offset = "0x42A30AC", VA = "0x42A70AC")]
		public TutorialPointWorldPosInfo(Vector3 worldPos, [Optional] Vector3 size)
		{
		}

		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x42A715C", Offset = "0x42A315C", VA = "0x42A715C", Slot = "4")]
		public Vector2 GetUiPos()
		{
			return default;
		}

		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x42A716C", Offset = "0x42A316C", VA = "0x42A716C", Slot = "5")]
		public void OnClick()
		{
		}

		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x42A7170", Offset = "0x42A3170", VA = "0x42A7170", Slot = "6")]
		public bool IsClickedInRange(Vector3 clickPos)
		{
			return default;
		}

		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x42A7204", Offset = "0x42A3204", VA = "0x42A7204", Slot = "7")]
		public void GetCenterAndSize(out Vector2 center, out Vector2 size)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TutorialPointWorldPosInfo.GetCenterAndSize RVA=0x42A7204 Token=0x6004E81");
}

		[Token(Token = "0x6004E82")]
		[Address(RVA = "0x42A7284", Offset = "0x42A3284", VA = "0x42A7284", Slot = "8")]
		public bool IsEventTriggered(bool isButtonUp, bool isButtonDown, bool isButton)
		{
			return default;
		}
	}
}
