using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000006")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class _003ClargeNumber_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample _003C_003E4__this;

		[Token(Token = "0x17000001")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x74C1EF4", Offset = "0x74BDEF4", VA = "0x74C1EF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000002")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x74C1F34", Offset = "0x74BDF34", VA = "0x74C1F34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x74C1C5C", Offset = "0x74BDC5C", VA = "0x74C1C5C")]
		[DebuggerHidden]
		public _003ClargeNumber_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x74C1DA8", Offset = "0x74BDDA8", VA = "0x74C1DA8", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x74C1DAC", Offset = "0x74BDDAC", VA = "0x74C1DAC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x74C1EF4", Offset = "0x74BDEF4", VA = "0x74C1EF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x74C1EFC", Offset = "0x74BDEFC", VA = "0x74C1EFC", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x74C1F34", Offset = "0x74BDF34", VA = "0x74C1F34", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	public GameObject prefab;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x30")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	private GameObject[] objs;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x74C1774", Offset = "0x74BD774", VA = "0x74C1774")]
	private float GaussianValue()
	{
		return default;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x74C17F8", Offset = "0x74BD7F8", VA = "0x74C17F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x74C1BFC", Offset = "0x74BDBFC", VA = "0x74C1BFC")]
	[IteratorStateMachine(typeof(_003ClargeNumber_003Ed__6))]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x74C1C84", Offset = "0x74BDC84", VA = "0x74C1C84")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x74C1D2C", Offset = "0x74BDD2C", VA = "0x74C1D2C")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
