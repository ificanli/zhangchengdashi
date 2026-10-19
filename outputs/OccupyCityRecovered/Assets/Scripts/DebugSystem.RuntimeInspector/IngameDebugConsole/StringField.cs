using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x200003A")]
	public class StringField : InspectorField
	{
		[Token(Token = "0x200003B")]
		public enum Mode
		{
			[Token(Token = "0x400015F")]
			OnValueChange = 0,
			[Token(Token = "0x4000160")]
			OnSubmit = 1
		}

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField input;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x88")]
		private Mode m_setterMode;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x8C")]
		private int lineCount;

		[Token(Token = "0x17000076")]
		public Mode SetterMode
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x4668C88", Offset = "0x4664C88", VA = "0x4668C88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x465FDBC", Offset = "0x465BDBC", VA = "0x465FDBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x4668C90", Offset = "0x4664C90", VA = "0x4668C90", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4668C9C", Offset = "0x4664C9C", VA = "0x4668C9C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4668E10", Offset = "0x4664E10", VA = "0x4668E10", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x4668E98", Offset = "0x4664E98", VA = "0x4668E98", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4669028", Offset = "0x4665028", VA = "0x4669028", Slot = "12")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4669050", Offset = "0x4665050", VA = "0x4669050")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4669070", Offset = "0x4665070", VA = "0x4669070")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x46690B0", Offset = "0x46650B0", VA = "0x46690B0", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4669178", Offset = "0x4665178", VA = "0x4669178", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4669200", Offset = "0x4665200", VA = "0x4669200")]
		public StringField()
		{
		}
	}
}
