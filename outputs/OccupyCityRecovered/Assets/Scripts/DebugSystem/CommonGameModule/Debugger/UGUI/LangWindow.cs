using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200006C")]
	public class LangWindow : IDebuggerWindowUGUI
	{
		[Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class _003CIE_All_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x20")]
			public LangWindow _003C_003E4__this;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000071")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027B")]
				[Address(RVA = "0x4688558", Offset = "0x4684558", VA = "0x4688558", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000072")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027D")]
				[Address(RVA = "0x4688598", Offset = "0x4684598", VA = "0x4688598", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x4688200", Offset = "0x4684200", VA = "0x4688200")]
			[DebuggerHidden]
			public _003CIE_All_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x4688350", Offset = "0x4684350", VA = "0x4688350", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x4688354", Offset = "0x4684354", VA = "0x4688354", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x4688558", Offset = "0x4684558", VA = "0x4688558", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600027C")]
			[Address(RVA = "0x4688560", Offset = "0x4684560", VA = "0x4688560", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x4688598", Offset = "0x4684598", VA = "0x4688598", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class _003CIE_Down_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000073")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x46885BC", Offset = "0x46845BC", VA = "0x46885BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000074")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x46885FC", Offset = "0x46845FC", VA = "0x46885FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x4688300", Offset = "0x4684300", VA = "0x4688300")]
			[DebuggerHidden]
			public _003CIE_Down_003Ed__24(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x46885A0", Offset = "0x46845A0", VA = "0x46885A0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x46885A4", Offset = "0x46845A4", VA = "0x46885A4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x46885BC", Offset = "0x46845BC", VA = "0x46885BC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x46885C4", Offset = "0x46845C4", VA = "0x46885C4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x46885FC", Offset = "0x46845FC", VA = "0x46885FC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class _003CIE_Up_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000075")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x4688620", Offset = "0x4684620", VA = "0x4688620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000076")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000289")]
				[Address(RVA = "0x4688660", Offset = "0x4684660", VA = "0x4688660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x4688280", Offset = "0x4684280", VA = "0x4688280")]
			[DebuggerHidden]
			public _003CIE_Up_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x4688604", Offset = "0x4684604", VA = "0x4688604", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x4688608", Offset = "0x4684608", VA = "0x4688608", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x4688620", Offset = "0x4684620", VA = "0x4688620", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x4688628", Offset = "0x4684628", VA = "0x4688628", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x4688660", Offset = "0x4684660", VA = "0x4688660", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x10")]
		[UIPath(UIPathType.UGUI, "Scroll View/Viewport/Content/Toggle")]
		private Toggle m_TogglePrefab;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x18")]
		private LocalELangLibrary m_LocalELangLibrary;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x20")]
		private List<(Toggle toggle, ELangType langType)> m_Toggles;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x28")]
		private readonly Transform _root;

		[Token(Token = "0x1700006D")]
		public RectTransform Root
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x46876C0", Offset = "0x46836C0", VA = "0x46876C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x4687720", Offset = "0x4683720", VA = "0x4687720", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006F")]
		public Transform transform
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x4687728", Offset = "0x4683728", VA = "0x4687728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x4687730", Offset = "0x4683730", VA = "0x4687730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x468774C", Offset = "0x468374C", VA = "0x468774C")]
		public LangWindow(Transform root)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x468780C", Offset = "0x468380C", VA = "0x468780C", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4687838", Offset = "0x4683838", VA = "0x4687838", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x468783C", Offset = "0x468383C", VA = "0x468783C", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x4687D60", Offset = "0x4683D60", VA = "0x4687D60")]
		private (Toggle, ELangType) CreateToggle(ELangType eLangType, bool isDefault = false)
		{
			return default;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4687FE8", Offset = "0x4683FE8", VA = "0x4687FE8", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4687FEC", Offset = "0x4683FEC", VA = "0x4687FEC", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4687FF0", Offset = "0x4683FF0", VA = "0x4687FF0", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4687FF4", Offset = "0x4683FF4", VA = "0x4687FF4", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4687FF8", Offset = "0x4683FF8", VA = "0x4687FF8")]
		private void OnSelectLangChanged(ELangType eLangType)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x46881A0", Offset = "0x46841A0", VA = "0x46881A0")]
		[IteratorStateMachine(typeof(_003CIE_All_003Ed__22))]
		private IEnumerator IE_All()
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4688228", Offset = "0x4684228", VA = "0x4688228")]
		[IteratorStateMachine(typeof(_003CIE_Up_003Ed__23))]
		private IEnumerator IE_Up()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x46882A8", Offset = "0x46842A8", VA = "0x46882A8")]
		[IteratorStateMachine(typeof(_003CIE_Down_003Ed__24))]
		private IEnumerator IE_Down()
		{
			return null;
		}
	}
}
