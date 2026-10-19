using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C80")]
	public class TutorialPointRectTransInfo : ITutorialPointInfo
	{
		[Token(Token = "0x40059EF")]
		[FieldOffset(Offset = "0x10")]
		private string _path;

		[Token(Token = "0x40059F0")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform _rectTrans;

		[Token(Token = "0x40059F1")]
		[FieldOffset(Offset = "0x20")]
		private readonly Vector3[] _targetCorners;

		[Token(Token = "0x17000E08")]
		private RectTransform RectTrans
		{
			[Token(Token = "0x6004E70")]
			[Address(RVA = "0x42A6878", Offset = "0x42A2878", VA = "0x42A6878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E71")]
		[Address(RVA = "0x42A6A04", Offset = "0x42A2A04", VA = "0x42A6A04")]
		public TutorialPointRectTransInfo(string path, RectTransform rectTrans)
		{
		}

		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x42A6A74", Offset = "0x42A2A74", VA = "0x42A6A74", Slot = "4")]
		public Vector2 GetUiPos()
		{
			return default;
		}

		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x42A6B04", Offset = "0x42A2B04", VA = "0x42A6B04", Slot = "5")]
		public void OnClick()
		{
		}

		[Token(Token = "0x6004E74")]
		[Address(RVA = "0x42A6B80", Offset = "0x42A2B80", VA = "0x42A6B80", Slot = "6")]
		public bool IsClickedInRange(Vector3 clickPos)
		{
			return default;
		}

		[Token(Token = "0x6004E75")]
		[Address(RVA = "0x42A6BB8", Offset = "0x42A2BB8", VA = "0x42A6BB8", Slot = "7")]
		public void GetCenterAndSize(out Vector2 center, out Vector2 size)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TutorialPointRectTransInfo.GetCenterAndSize RVA=0x42A6BB8 Token=0x6004E75");
}

		[Token(Token = "0x6004E76")]
		[Address(RVA = "0x42A6CD0", Offset = "0x42A2CD0", VA = "0x42A6CD0", Slot = "8")]
		public bool IsEventTriggered(bool isButtonUp, bool isButtonDown, bool isButton)
		{
			return default;
		}
	}
}
