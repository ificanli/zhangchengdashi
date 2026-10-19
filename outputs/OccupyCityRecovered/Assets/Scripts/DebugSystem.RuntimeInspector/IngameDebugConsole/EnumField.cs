using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000025")]
	public class EnumField : InspectorField
	{
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Graphic dropdownArrow;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform templateRoot;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform templateContentTransform;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform templateItemTransform;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image templateBackground;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Graphic templateCheckmark;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text templateText;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Dropdown input;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, List<string>> enumNames;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, List<object>> enumValues;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xC8")]
		private List<string> currEnumNames;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xD0")]
		private List<object> currEnumValues;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x465D25C", Offset = "0x465925C", VA = "0x465D25C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x465D30C", Offset = "0x465930C", VA = "0x465D30C", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x465D334", Offset = "0x4659334", VA = "0x465D334", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x465D6D4", Offset = "0x46596D4", VA = "0x465D6D4", Slot = "13")]
		protected override void OnInspectorChanged()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x465D6F0", Offset = "0x46596F0", VA = "0x465D6F0")]
		private void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x465D820", Offset = "0x4659820", VA = "0x465D820")]
		private void OnValueChanged(int input)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x465D898", Offset = "0x4659898", VA = "0x465D898", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x465DC3C", Offset = "0x4659C3C", VA = "0x465DC3C", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x465DCC4", Offset = "0x4659CC4", VA = "0x465DCC4")]
		public EnumField()
		{
		}
	}
}
