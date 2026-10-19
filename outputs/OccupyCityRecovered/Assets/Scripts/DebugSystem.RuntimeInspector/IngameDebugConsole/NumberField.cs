using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000034")]
	public class NumberField : InspectorField
	{
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<Type> supportedTypes;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected BoundInputField input;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x88")]
		protected INumberHandler numberHandler;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4663AE8", Offset = "0x465FAE8", VA = "0x4663AE8", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4663EA0", Offset = "0x465FEA0", VA = "0x4663EA0", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4663F20", Offset = "0x465FF20", VA = "0x4663F20", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4664744", Offset = "0x4660744", VA = "0x4664744", Slot = "17")]
		protected virtual bool OnValueChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x466481C", Offset = "0x466081C", VA = "0x466481C")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4664868", Offset = "0x4660868", VA = "0x4664868", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4664B04", Offset = "0x4660B04", VA = "0x4664B04", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4664C5C", Offset = "0x4660C5C", VA = "0x4664C5C")]
		public NumberField()
		{
		}
	}
}
