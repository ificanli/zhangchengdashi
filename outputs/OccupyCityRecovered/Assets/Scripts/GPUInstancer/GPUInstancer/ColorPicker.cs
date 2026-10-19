using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200001B")]
	public class ColorPicker : MonoBehaviour
	{
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		private Color _color;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		private Action<Color> _onValueChange;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		private Action _onValueChangeVoid;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x40")]
		private Action _update;

		[Token(Token = "0x17000011")]
		public Color Color
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x73B4728", Offset = "0x73B0728", VA = "0x73B4728")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x73ACCC4", Offset = "0x73A8CC4", VA = "0x73ACCC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x73B4D74", Offset = "0x73B0D74", VA = "0x73B4D74")]
		public void SetOnValueChangeCallback(Action<Color> onValueChange)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x73B4D7C", Offset = "0x73B0D7C", VA = "0x73B4D7C")]
		public void SetOnValueChangeCallback(Action onValueChange)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x73B4D84", Offset = "0x73B0D84", VA = "0x73B4D84")]
		private static void RGBToHSV(Color color, out float h, out float s, out float v)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ColorPicker.RGBToHSV RVA=0x73B4D84 Token=0x6000094");
}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x73B4F54", Offset = "0x73B0F54", VA = "0x73B4F54")]
		private static bool GetLocalMouse(GameObject go, out Vector2 result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ColorPicker.GetLocalMouse RVA=0x73B4F54 Token=0x6000095");
}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x73B50A0", Offset = "0x73B10A0", VA = "0x73B50A0")]
		private static Vector2 GetWidgetSize(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x73B511C", Offset = "0x73B111C", VA = "0x73B511C")]
		private GameObject GO(string name)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x73B4734", Offset = "0x73B0734", VA = "0x73B4734")]
		private void Setup(Color inputColor)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x73B5158", Offset = "0x73B1158", VA = "0x73B5158")]
		public void SetRandomColor()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x73B5274", Offset = "0x73B1274", VA = "0x73B5274")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x73B5288", Offset = "0x73B1288", VA = "0x73B5288")]
		private void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x73B52AC", Offset = "0x73B12AC", VA = "0x73B52AC")]
		public ColorPicker()
		{
		}
	}
}
