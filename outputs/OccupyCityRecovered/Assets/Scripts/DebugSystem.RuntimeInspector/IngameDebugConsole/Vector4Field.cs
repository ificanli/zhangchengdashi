using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000040")]
	public class Vector4Field : InspectorField
	{
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BoundInputField inputZ;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BoundInputField inputW;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text labelZ;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text labelW;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xC0")]
		private bool isQuaternion;

		[Token(Token = "0x1700007A")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x466B180", Offset = "0x4667180", VA = "0x466B180", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x466B188", Offset = "0x4667188", VA = "0x466B188", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x466B584", Offset = "0x4667584", VA = "0x466B584", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x466B668", Offset = "0x4667668", VA = "0x466B668", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x466B90C", Offset = "0x466790C", VA = "0x466B90C")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x466BAF0", Offset = "0x4667AF0", VA = "0x466BAF0")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x466BB30", Offset = "0x4667B30", VA = "0x466BB30", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x466BDE8", Offset = "0x4667DE8", VA = "0x466BDE8", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x466C1AC", Offset = "0x46681AC", VA = "0x466C1AC")]
		public Vector4Field()
		{
		}
	}
}
