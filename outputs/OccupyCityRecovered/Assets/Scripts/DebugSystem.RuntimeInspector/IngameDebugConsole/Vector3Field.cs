using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200003F")]
	public class Vector3Field : InspectorField
	{
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BoundInputField inputZ;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text labelZ;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xB0")]
		private bool isVector3Int;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x466A288", Offset = "0x4666288", VA = "0x466A288", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x466A5AC", Offset = "0x46665AC", VA = "0x466A5AC", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x466A690", Offset = "0x4666690", VA = "0x466A690", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x466A92C", Offset = "0x466692C", VA = "0x466A92C")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x466ABAC", Offset = "0x4666BAC", VA = "0x466ABAC")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x466ABEC", Offset = "0x4666BEC", VA = "0x466ABEC", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x466AE1C", Offset = "0x4666E1C", VA = "0x466AE1C", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x466B168", Offset = "0x4667168", VA = "0x466B168")]
		public Vector3Field()
		{
		}
	}
}
