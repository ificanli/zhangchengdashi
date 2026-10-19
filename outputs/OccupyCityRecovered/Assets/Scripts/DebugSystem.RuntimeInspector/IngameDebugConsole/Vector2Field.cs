using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200003E")]
	public class Vector2Field : InspectorField
	{
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xA0")]
		private bool isVector2Int;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x466968C", Offset = "0x466568C", VA = "0x466968C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x46698D8", Offset = "0x46658D8", VA = "0x46698D8", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x46699BC", Offset = "0x46659BC", VA = "0x46699BC", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4669BF0", Offset = "0x4665BF0", VA = "0x4669BF0")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4669DF4", Offset = "0x4665DF4", VA = "0x4669DF4")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4669E34", Offset = "0x4665E34", VA = "0x4669E34", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4669FE4", Offset = "0x4665FE4", VA = "0x4669FE4", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x466A270", Offset = "0x4666270", VA = "0x466A270")]
		public Vector2Field()
		{
		}
	}
}
