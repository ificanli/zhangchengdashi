using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200001F")]
	public class ArrayField : ExpandableInspectorField, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private LayoutElement sizeLayoutElement;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text sizeText;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private BoundInputField sizeInput;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0xD8")]
		private bool isArray;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0xE0")]
		private Type elementType;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<bool> elementsExpandedStates;

		[Token(Token = "0x1700005F")]
		protected override int Length
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x465A25C", Offset = "0x465625C", VA = "0x465A25C", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x465A3AC", Offset = "0x46563AC", VA = "0x465A3AC", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x465A52C", Offset = "0x465652C", VA = "0x465A52C", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x465A624", Offset = "0x4656624", VA = "0x465A624", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x465A6A4", Offset = "0x46566A4", VA = "0x465A6A4", Slot = "12")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x465A728", Offset = "0x4656728", VA = "0x465A728", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x465A824", Offset = "0x4656824", VA = "0x465A824", Slot = "15")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x465A878", Offset = "0x4656878", VA = "0x465A878", Slot = "19")]
		protected override void ClearElements()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x465AA40", Offset = "0x4656A40", VA = "0x465AA40", Slot = "18")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x465B1A4", Offset = "0x46571A4", VA = "0x465B1A4", Slot = "20")]
void IDropHandler.OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x465B940", Offset = "0x4657940", VA = "0x465B940")]
		private bool OnSizeInputBeingChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x465B44C", Offset = "0x465744C", VA = "0x465B44C")]
		private bool OnSizeChanged(BoundInputField source, string input)
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x465B9CC", Offset = "0x46579CC", VA = "0x465B9CC")]
		private object GetTemplateElement(object value)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x465C008", Offset = "0x4658008", VA = "0x465C008")]
		public ArrayField()
		{
		}
	}
}
