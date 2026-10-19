using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class WaterCausticsCookieSwapper : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class _003CanimateCookies_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		public WaterCausticsCookieSwapper _003C_003E4__this;

		[Token(Token = "0x17000001")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x73BEA20", Offset = "0x73BAA20", VA = "0x73BEA20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000002")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x73BEA60", Offset = "0x73BAA60", VA = "0x73BEA60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x73BE8F0", Offset = "0x73BA8F0", VA = "0x73BE8F0")]
		[DebuggerHidden]
		public _003CanimateCookies_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x73BE928", Offset = "0x73BA928", VA = "0x73BE928", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x73BE92C", Offset = "0x73BA92C", VA = "0x73BE92C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x73BEA20", Offset = "0x73BAA20", VA = "0x73BEA20", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x73BEA28", Offset = "0x73BAA28", VA = "0x73BEA28", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x73BEA60", Offset = "0x73BAA60", VA = "0x73BEA60", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	public Texture[] cookies;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x28")]
	public float framesPerSecond;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x30")]
	private Light m_light;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x38")]
	private int m_index;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x73BE82C", Offset = "0x73BA82C", VA = "0x73BE82C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x73BE890", Offset = "0x73BA890", VA = "0x73BE890")]
	[IteratorStateMachine(typeof(_003CanimateCookies_003Ed__5))]
	private IEnumerator animateCookies()
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x73BE918", Offset = "0x73BA918", VA = "0x73BE918")]
	public WaterCausticsCookieSwapper()
	{
	}
}
