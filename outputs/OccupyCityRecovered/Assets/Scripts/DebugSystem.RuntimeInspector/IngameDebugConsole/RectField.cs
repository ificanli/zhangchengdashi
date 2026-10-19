using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000039")]
	public class RectField : InspectorField
	{
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BoundInputField inputW;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BoundInputField inputH;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text labelW;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text labelH;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xC0")]
		private bool isRectInt;

		[Token(Token = "0x17000075")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x4667ABC", Offset = "0x4663ABC", VA = "0x4667ABC", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4667AC4", Offset = "0x4663AC4", VA = "0x4667AC4", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4667EC0", Offset = "0x4663EC0", VA = "0x4667EC0", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4667FA4", Offset = "0x4663FA4", VA = "0x4667FA4", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x46682B8", Offset = "0x46642B8", VA = "0x46682B8")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x4668598", Offset = "0x4664598", VA = "0x4668598")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x46685D8", Offset = "0x46645D8", VA = "0x46685D8", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4668890", Offset = "0x4664890", VA = "0x4668890", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4668C70", Offset = "0x4664C70", VA = "0x4668C70")]
		public RectField()
		{
		}
	}
}
