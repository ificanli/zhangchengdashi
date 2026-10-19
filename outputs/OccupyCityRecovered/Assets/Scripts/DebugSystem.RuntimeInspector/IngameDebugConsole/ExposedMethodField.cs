using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000026")]
	public class ExposedMethodField : InspectorField
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button invokeButton;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x88")]
		protected ExposedMethod boundMethod;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x465DDA8", Offset = "0x4659DA8", VA = "0x465DDA8", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x465DE30", Offset = "0x4659E30", VA = "0x465DE30", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x465DFB0", Offset = "0x4659FB0", VA = "0x465DFB0", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x465E100", Offset = "0x465A100", VA = "0x465E100", Slot = "15")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x465E18C", Offset = "0x465A18C", VA = "0x465E18C")]
		public void SetBoundMethod(ExposedMethod boundMethod)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x465E270", Offset = "0x465A270", VA = "0x465E270")]
		public void InvokeMethod()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x465E580", Offset = "0x465A580", VA = "0x465E580")]
		public ExposedMethodField()
		{
		}
	}
}
