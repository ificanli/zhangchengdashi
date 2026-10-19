using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200000C")]
	public class AddRuntimeCreatedGameObjects : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class _003CAddRemoveAtRuntime_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x20")]
			public AddRuntimeCreatedGameObjects _003C_003E4__this;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x28")]
			private IEnumerator _003C_003E7__wrap1;

			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0x30")]
			private PrimitiveType _003CprimitiveType_003E5__3;

			[Token(Token = "0x17000009")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0x73B0620", Offset = "0x73AC620", VA = "0x73B0620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700000A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x73B0660", Offset = "0x73AC660", VA = "0x73B0660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x73AFCFC", Offset = "0x73ABCFC", VA = "0x73AFCFC")]
			[DebuggerHidden]
			public _003CAddRemoveAtRuntime_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x73AFEC4", Offset = "0x73ABEC4", VA = "0x73AFEC4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x73AFEF0", Offset = "0x73ABEF0", VA = "0x73AFEF0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x73B0564", Offset = "0x73AC564", VA = "0x73B0564")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x73B0620", Offset = "0x73AC620", VA = "0x73B0620", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x73B0628", Offset = "0x73AC628", VA = "0x73B0628", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x73B0660", Offset = "0x73AC660", VA = "0x73B0660", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerPrefabManager prefabManager;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x28")]
		public Material material;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x30")]
		private List<GameObject> instanceList;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x38")]
		private GPUInstancerPrefabPrototype prototype;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x40")]
		private GameObject prototypeGameObject;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x73AF944", Offset = "0x73AB944", VA = "0x73AF944")]
		private void Start()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x73AFC9C", Offset = "0x73ABC9C", VA = "0x73AFC9C")]
		[IteratorStateMachine(typeof(_003CAddRemoveAtRuntime_003Ed__6))]
		private IEnumerator AddRemoveAtRuntime()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x73AFD24", Offset = "0x73ABD24", VA = "0x73AFD24")]
		public void ClearInstances()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x73AFBF8", Offset = "0x73ABBF8", VA = "0x73AFBF8")]
		public void SetMaterial()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x73AFEBC", Offset = "0x73ABEBC", VA = "0x73AFEBC")]
		public AddRuntimeCreatedGameObjects()
		{
		}
	}
}
