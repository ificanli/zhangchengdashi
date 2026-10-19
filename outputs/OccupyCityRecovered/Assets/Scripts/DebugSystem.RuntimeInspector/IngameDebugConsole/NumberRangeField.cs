using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000035")]
	public class NumberRangeField : NumberField
	{
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BoundSlider slider;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4664F9C", Offset = "0x4660F9C", VA = "0x4664F9C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4665168", Offset = "0x4661168", VA = "0x4665168", Slot = "10")]
		public override bool CanBindTo(Type type, MemberInfo variable)
		{
			return default;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x46651F8", Offset = "0x46611F8", VA = "0x46651F8", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4665500", Offset = "0x4661500", VA = "0x4665500", Slot = "17")]
		protected override bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4665670", Offset = "0x4661670", VA = "0x4665670")]
		private void OnSliderValueChanged(BoundSlider source, float value)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x46657F4", Offset = "0x46617F4", VA = "0x46657F4", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4665A30", Offset = "0x4661A30", VA = "0x4665A30", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4665B28", Offset = "0x4661B28", VA = "0x4665B28")]
		public NumberRangeField()
		{
		}
	}
}
