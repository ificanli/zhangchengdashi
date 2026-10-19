using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000022")]
	public class BoolField : InspectorField
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image toggleBackground;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Toggle input;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x465C3C0", Offset = "0x46583C0", VA = "0x465C3C0", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x465C470", Offset = "0x4658470", VA = "0x465C470", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x465C4F8", Offset = "0x46584F8", VA = "0x465C4F8")]
		private void OnValueChanged(bool input)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x465C578", Offset = "0x4658578", VA = "0x465C578", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x465C68C", Offset = "0x465868C", VA = "0x465C68C", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x465C718", Offset = "0x4658718", VA = "0x465C718")]
		public BoolField()
		{
		}
	}
}
