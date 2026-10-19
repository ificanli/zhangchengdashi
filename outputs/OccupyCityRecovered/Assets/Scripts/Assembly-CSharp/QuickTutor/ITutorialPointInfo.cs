using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C7F")]
	public interface ITutorialPointInfo
	{
		[Token(Token = "0x40059EE")]
		[FieldOffset(Offset = "0x0")]
		private static RectTransform _parentRectTrans;

		[Token(Token = "0x17000E05")]
		private static RectTransform ParentRectTrans
		{
			[Token(Token = "0x6004E69")]
			[Address(RVA = "0x42A62D8", Offset = "0x42A22D8", VA = "0x42A62D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E06")]
		private static Camera UICamera
		{
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x42A6494", Offset = "0x42A2494", VA = "0x42A6494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E07")]
		private static Camera MainCamera
		{
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x42A6590", Offset = "0x42A2590", VA = "0x42A6590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004E65")]
		Vector2 GetUiPos();

		[Token(Token = "0x6004E66")]
		void OnClick();

		[Token(Token = "0x6004E67")]
		bool IsClickedInRange(Vector3 clickPos);

		[Token(Token = "0x6004E68")]
		void GetCenterAndSize(out Vector2 center, out Vector2 size);

		[Token(Token = "0x6004E6C")]
		[Address(RVA = "0x42A668C", Offset = "0x42A268C", VA = "0x42A668C")]
		static Vector2 WorldToLocalPoint(Vector3 worldPoint, bool isMainCamera = true)
		{
			return default;
		}

		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x42A6764", Offset = "0x42A2764", VA = "0x42A6764")]
		static Vector2 WorldToScreenPoint(Vector3 worldPos, bool isMainCamera = true)
		{
			return default;
		}

		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x42A67F8", Offset = "0x42A27F8", VA = "0x42A67F8")]
		static bool IsRectContainsScreenPoint(RectTransform rectTrans, Vector3 clickPos)
		{
			return default;
		}

		[Token(Token = "0x6004E6F")]
		bool IsEventTriggered(bool isButtonUp, bool isButtonDown, bool isButton);
	}
}
