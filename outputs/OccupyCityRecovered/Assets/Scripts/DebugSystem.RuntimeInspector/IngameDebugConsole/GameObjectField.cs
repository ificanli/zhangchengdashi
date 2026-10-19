using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000027")]
	public class GameObjectField : ExpandableInspectorField
	{
		[Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class _003CRemoveComponentCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x20")]
			public Component component;

			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x28")]
			public RuntimeInspector inspector;

			[Token(Token = "0x17000062")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x4661D18", Offset = "0x465DD18", VA = "0x4661D18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000063")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x4661D58", Offset = "0x465DD58", VA = "0x4661D58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x4661194", Offset = "0x465D194", VA = "0x4661194")]
			[DebuggerHidden]
			public _003CRemoveComponentCoroutine_003Ed__24(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x4661C5C", Offset = "0x465DC5C", VA = "0x4661C5C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x4661C60", Offset = "0x465DC60", VA = "0x4661C60", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x4661D18", Offset = "0x465DD18", VA = "0x4661D18", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x4661D20", Offset = "0x465DD20", VA = "0x4661D20", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x4661D58", Offset = "0x465DD58", VA = "0x4661D58", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xC0")]
		private string currentTag;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0xC8")]
		private Getter isActiveGetter;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xD0")]
		private Getter nameGetter;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xD8")]
		private Getter tagGetter;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0xE0")]
		private Setter isActiveSetter;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0xE8")]
		private Setter nameSetter;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xF0")]
		private Setter tagSetter;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xF8")]
		private PropertyInfo layerProp;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<Component> components;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<bool> componentsExpandedStates;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x110")]
		private Type[] addComponentTypes;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		internal static ExposedMethod addComponentMethod;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x18")]
		internal static ExposedMethod removeComponentMethod;

		[Token(Token = "0x17000061")]
		protected override int Length
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x465E5B0", Offset = "0x465A5B0", VA = "0x465E5B0", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x465E5FC", Offset = "0x465A5FC", VA = "0x465E5FC", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x465EA78", Offset = "0x465AA78", VA = "0x465EA78", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x465EB00", Offset = "0x465AB00", VA = "0x465EB00", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x465EB78", Offset = "0x465AB78", VA = "0x465EB78", Slot = "12")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x465EC40", Offset = "0x465AC40", VA = "0x465EC40", Slot = "19")]
		protected override void ClearElements()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x465EFF4", Offset = "0x465AFF4", VA = "0x465EFF4", Slot = "18")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4660030", Offset = "0x465C030", VA = "0x4660030", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4660308", Offset = "0x465C308", VA = "0x4660308")]
		[Preserve]
		private void AddComponentButtonClicked()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4660F9C", Offset = "0x465CF9C", VA = "0x4660F9C")]
		[Preserve]
		private static void RemoveComponentButtonClicked(ExpandableInspectorField componentDrawer)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4661128", Offset = "0x465D128", VA = "0x4661128")]
		[IteratorStateMachine(typeof(_003CRemoveComponentCoroutine_003Ed__24))]
		private static IEnumerator RemoveComponentCoroutine(Component component, RuntimeInspector inspector)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x46611BC", Offset = "0x465D1BC", VA = "0x46611BC")]
		public GameObjectField()
		{
		}
	}
}
