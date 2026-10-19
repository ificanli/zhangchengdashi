using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x200001C")]
public static class TaskExtensions
{
	[Token(Token = "0x200001D")]
	private sealed class _00A0w_00A6_0089_00A6_007B : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		public Task task;

		[Token(Token = "0x17000012")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x706F03C", Offset = "0x706B03C", VA = "0x706F03C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000013")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x706F07C", Offset = "0x706B07C", VA = "0x706F07C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x706EF88", Offset = "0x706AF88", VA = "0x706EF88")]
		[DebuggerHidden]
		public _00A0w_00A6_0089_00A6_007B(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x706EFB0", Offset = "0x706AFB0", VA = "0x706EFB0", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x706EFB4", Offset = "0x706AFB4", VA = "0x706EFB4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x706F03C", Offset = "0x706B03C", VA = "0x706F03C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x706F044", Offset = "0x706B044", VA = "0x706F044", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x706F07C", Offset = "0x706B07C", VA = "0x706F07C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200001E")]
	private sealed class _0098_00B6dÁ_00B3W<T> : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		public Task<T> task;

		[Token(Token = "0x17000014")]
T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x60000E2")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000015")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000DF")]
		[DebuggerHidden]
		public _0098_00B6dÁ_00B3W(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000E0")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E1")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[DebuggerHidden]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TaskExtensions._0098_00B6dÁ_00B3W.System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current RVA= Token=0x60000E2");
}

		[Token(Token = "0x60000E3")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60000E4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x706EF28", Offset = "0x706AF28", VA = "0x706EF28")]
	[IteratorStateMachine(typeof(_00A0w_00A6_0089_00A6_007B))]
	public static IEnumerator AsIEnumerator(this Task Z_00B6_0093D_0098q)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[IteratorStateMachine(typeof(global::TaskExtensions._0098_00B6dÁ_00B3W<>))]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> Z_00B6_0093D_0098q)
	{
		return null;
	}
}
