using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000005")]
[ExecuteInEditMode]
public class CanvasAdaptive : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class _003CPrintDesignResolutionInfo_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		public CanvasAdaptive _003C_003E4__this;

		[Token(Token = "0x17000003")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x706712C", Offset = "0x706312C", VA = "0x706712C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000004")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x706716C", Offset = "0x706316C", VA = "0x706716C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7066D28", Offset = "0x7062D28", VA = "0x7066D28")]
		[DebuggerHidden]
		public _003CPrintDesignResolutionInfo_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7066EA8", Offset = "0x7062EA8", VA = "0x7066EA8", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7066EAC", Offset = "0x7062EAC", VA = "0x7066EAC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x706712C", Offset = "0x706312C", VA = "0x706712C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7067134", Offset = "0x7063134", VA = "0x7067134", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x706716C", Offset = "0x706316C", VA = "0x706716C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	private AspectRatioFitter aspect;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	private CanvasScaler canvas;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x30")]
	private float AspectWhRatio;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x34")]
	public float whRatioConst;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	public float widthControlsHeightFactor;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x3C")]
	[Range(0f, 1f)]
	public float heightControlsWidthFactor;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x40")]
	public bool isHeightCtrWidthFixedWidth;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7066954", Offset = "0x7062954", VA = "0x7066954")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7066B54", Offset = "0x7062B54", VA = "0x7066B54")]
	private void adaptive()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7066CC8", Offset = "0x7062CC8", VA = "0x7066CC8")]
	[IteratorStateMachine(typeof(_003CPrintDesignResolutionInfo_003Ed__9))]
	private IEnumerator PrintDesignResolutionInfo()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7066C20", Offset = "0x7062C20", VA = "0x7066C20")]
	private void WidthControlsHeight(float whRatio)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7066C74", Offset = "0x7062C74", VA = "0x7066C74")]
	private void HeightControlsWidth(float whRatio)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7066D50", Offset = "0x7062D50", VA = "0x7066D50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7066E90", Offset = "0x7062E90", VA = "0x7066E90")]
	public CanvasAdaptive()
	{
	}
}
