using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x20003B5")]
	public class BaseUI : UIObject
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003B6")]
		[CompilerGenerated]
		private struct _003CAwait_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseUI _003C_003E4__this;

			[Token(Token = "0x4001C0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005E45")]
			[Address(RVA = "0x71CC4D8", Offset = "0x71C84D8", VA = "0x71CC4D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005E46")]
			[Address(RVA = "0x71CC75C", Offset = "0x71C875C", VA = "0x71CC75C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20003B7")]
		[CompilerGenerated]
		private sealed class _003CAwaitIEnumerator_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001C0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseUI _003C_003E4__this;

			[Token(Token = "0x17001135")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005E4A")]
				[Address(RVA = "0x71CC89C", Offset = "0x71C889C", VA = "0x71CC89C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001136")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005E4C")]
				[Address(RVA = "0x71CC8DC", Offset = "0x71C88DC", VA = "0x71CC8DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005E47")]
			[Address(RVA = "0x71CC108", Offset = "0x71C8108", VA = "0x71CC108")]
			[DebuggerHidden]
			public _003CAwaitIEnumerator_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005E48")]
			[Address(RVA = "0x71CC7C4", Offset = "0x71C87C4", VA = "0x71CC7C4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005E49")]
			[Address(RVA = "0x71CC7C8", Offset = "0x71C87C8", VA = "0x71CC7C8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005E4A")]
			[Address(RVA = "0x71CC89C", Offset = "0x71C889C", VA = "0x71CC89C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005E4B")]
			[Address(RVA = "0x71CC8A4", Offset = "0x71C88A4", VA = "0x71CC8A4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005E4C")]
			[Address(RVA = "0x71CC8DC", Offset = "0x71C88DC", VA = "0x71CC8DC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20003B8")]
		[CompilerGenerated]
		private sealed class _003CCloseAnimCustomize_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17001137")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005E50")]
				[Address(RVA = "0x71CC900", Offset = "0x71C8900", VA = "0x71CC900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001138")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005E52")]
				[Address(RVA = "0x71CC940", Offset = "0x71C8940", VA = "0x71CC940", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005E4D")]
			[Address(RVA = "0x71CBF4C", Offset = "0x71C7F4C", VA = "0x71CBF4C")]
			[DebuggerHidden]
			public _003CCloseAnimCustomize_003Ed__31(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005E4E")]
			[Address(RVA = "0x71CC8E4", Offset = "0x71C88E4", VA = "0x71CC8E4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005E4F")]
			[Address(RVA = "0x71CC8E8", Offset = "0x71C88E8", VA = "0x71CC8E8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005E50")]
			[Address(RVA = "0x71CC900", Offset = "0x71C8900", VA = "0x71CC900", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005E51")]
			[Address(RVA = "0x71CC908", Offset = "0x71C8908", VA = "0x71CC908", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005E52")]
			[Address(RVA = "0x71CC940", Offset = "0x71C8940", VA = "0x71CC940", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20003B9")]
		[CompilerGenerated]
		private sealed class _003COpenAnimCustomize_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17001139")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005E56")]
				[Address(RVA = "0x71CC964", Offset = "0x71C8964", VA = "0x71CC964", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700113A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005E58")]
				[Address(RVA = "0x71CC9A4", Offset = "0x71C89A4", VA = "0x71CC9A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005E53")]
			[Address(RVA = "0x71CBECC", Offset = "0x71C7ECC", VA = "0x71CBECC")]
			[DebuggerHidden]
			public _003COpenAnimCustomize_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005E54")]
			[Address(RVA = "0x71CC948", Offset = "0x71C8948", VA = "0x71CC948", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005E55")]
			[Address(RVA = "0x71CC94C", Offset = "0x71C894C", VA = "0x71CC94C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005E56")]
			[Address(RVA = "0x71CC964", Offset = "0x71C8964", VA = "0x71CC964", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005E57")]
			[Address(RVA = "0x71CC96C", Offset = "0x71C896C", VA = "0x71CC96C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005E58")]
			[Address(RVA = "0x71CC9A4", Offset = "0x71C89A4", VA = "0x71CC9A4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003BA")]
		[CompilerGenerated]
		private struct _003C_closeUI_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseUI _003C_003E4__this;

			[Token(Token = "0x4001C17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005E59")]
			[Address(RVA = "0x71CC9AC", Offset = "0x71C89AC", VA = "0x71CC9AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005E5A")]
			[Address(RVA = "0x71CD1A8", Offset = "0x71C91A8", VA = "0x71CD1A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20003BB")]
		[CompilerGenerated]
		private sealed class _003CwaitOpenAnim_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001C1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject obj;

			[Token(Token = "0x4001C1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseUI _003C_003E4__this;

			[Token(Token = "0x4001C1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003Cuiname_003E5__2;

			[Token(Token = "0x1700113B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005E5E")]
				[Address(RVA = "0x71CD4B4", Offset = "0x71C94B4", VA = "0x71CD4B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700113C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005E60")]
				[Address(RVA = "0x71CD4F4", Offset = "0x71C94F4", VA = "0x71CD4F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005E5B")]
			[Address(RVA = "0x71CBB9C", Offset = "0x71C7B9C", VA = "0x71CBB9C")]
			[DebuggerHidden]
			public _003CwaitOpenAnim_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005E5C")]
			[Address(RVA = "0x71CD1B4", Offset = "0x71C91B4", VA = "0x71CD1B4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005E5D")]
			[Address(RVA = "0x71CD1B8", Offset = "0x71C91B8", VA = "0x71CD1B8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005E5E")]
			[Address(RVA = "0x71CD4B4", Offset = "0x71C94B4", VA = "0x71CD4B4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005E5F")]
			[Address(RVA = "0x71CD4BC", Offset = "0x71C94BC", VA = "0x71CD4BC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005E60")]
			[Address(RVA = "0x71CD4F4", Offset = "0x71C94F4", VA = "0x71CD4F4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public EUINode UINode;

		[Token(Token = "0x4001BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected object[] _args;

		[Token(Token = "0x4001BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EUIAnim OpenAnim;

		[Token(Token = "0x4001BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected EUIAnim CloseAnim;

		[Token(Token = "0x4001BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected bool EnableLoading;

		[Token(Token = "0x4001BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected float openAniTime;

		[Token(Token = "0x4001BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected float closeAniTime;

		[Token(Token = "0x4001BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected bool ShowTop;

		[Token(Token = "0x4001C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action CloseAction;

		[Token(Token = "0x4001C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal string UIModel;

		[Token(Token = "0x4001C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal float UIOpenTime;

		[Token(Token = "0x4001C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AssetOperationHandle myInfo_newRes;

		[Token(Token = "0x4001C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ResourcesInfo myInfo;

		[Token(Token = "0x4001C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool isPreCache;

		[Token(Token = "0x4001C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal int m_UIWindowIndex;

		[Token(Token = "0x4001C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool canReportOpen;

		[Token(Token = "0x4001C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool canReportClose;

		[Token(Token = "0x17001134")]
		public virtual string UIPath
		{
			[Token(Token = "0x6005E28")]
			[Address(RVA = "0x71CB054", Offset = "0x71C7054", VA = "0x71CB054", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E29")]
		[Address(RVA = "0x71CB130", Offset = "0x71C7130", VA = "0x71CB130", Slot = "14")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x71CB134", Offset = "0x71C7134", VA = "0x71CB134")]
		public void _openUI(params object[] args)
		{
		}

		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x71CB380", Offset = "0x71C7380", VA = "0x71CB380")]
		private void LoadGameObject_newRes(GameObject obj, AssetOperationHandle Info)
		{
		}

		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0x71CB84C", Offset = "0x71C784C", VA = "0x71CB84C", Slot = "9")]
		public override void SetVisible(bool value)
		{
		}

		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0x71CB96C", Offset = "0x71C796C", VA = "0x71CB96C")]
		private void LoadGameObject(GameObject obj, ResourcesInfo Info)
		{
		}

		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0x71CB7E0", Offset = "0x71C77E0", VA = "0x71CB7E0")]
		[IteratorStateMachine(typeof(_003CwaitOpenAnim_003Ed__21))]
		private IEnumerator waitOpenAnim(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0x71CB5A8", Offset = "0x71C75A8", VA = "0x71CB5A8")]
		public void addCanvas()
		{
		}

		[Token(Token = "0x6005E30")]
		[Address(RVA = "0x71CBBC4", Offset = "0x71C7BC4", VA = "0x71CBBC4", Slot = "15")]
		public virtual void CloseSelf()
		{
		}

		[Token(Token = "0x6005E31")]
		[Address(RVA = "0x71CBC7C", Offset = "0x71C7C7C", VA = "0x71CBC7C")]
		[AsyncStateMachine(typeof(_003C_closeUI_003Ed__25))]
		public void _closeUI()
		{
		}

		[Token(Token = "0x6005E32")]
		[Address(RVA = "0x71CBD0C", Offset = "0x71C7D0C", VA = "0x71CBD0C")]
		internal void CloseUINow()
		{
		}

		[Token(Token = "0x6005E33")]
		public T GetArg<T>(int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BaseUI.GetArg RVA= Token=0x6005E33");
}

		[Token(Token = "0x6005E34")]
		[Address(RVA = "0x71CBD94", Offset = "0x71C7D94", VA = "0x71CBD94")]
		public void SetArgs(params object[] args)
		{
		}

		[Token(Token = "0x6005E35")]
		public T GetArg<T>()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BaseUI.GetArg RVA= Token=0x6005E35");
}

		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x71CBE74", Offset = "0x71C7E74", VA = "0x71CBE74", Slot = "16")]
		[IteratorStateMachine(typeof(_003COpenAnimCustomize_003Ed__30))]
		protected virtual IEnumerator OpenAnimCustomize()
		{
			return null;
		}

		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x71CBEF4", Offset = "0x71C7EF4", VA = "0x71CBEF4", Slot = "17")]
		[IteratorStateMachine(typeof(_003CCloseAnimCustomize_003Ed__31))]
		protected virtual IEnumerator CloseAnimCustomize()
		{
			return null;
		}

		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x71CBF74", Offset = "0x71C7F74", VA = "0x71CBF74", Slot = "18")]
		protected virtual void OpenLater()
		{
		}

		[Token(Token = "0x6005E39")]
		[Address(RVA = "0x71CBF78", Offset = "0x71C7F78", VA = "0x71CBF78", Slot = "19")]
		protected virtual void showLoading()
		{
		}

		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x71CC010", Offset = "0x71C8010", VA = "0x71CC010", Slot = "20")]
		protected virtual void closeLoading()
		{
		}

		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0x71CC0A8", Offset = "0x71C80A8", VA = "0x71CC0A8", Slot = "21")]
		[IteratorStateMachine(typeof(_003CAwaitIEnumerator_003Ed__35))]
		public virtual IEnumerator AwaitIEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0x71CC130", Offset = "0x71C8130", VA = "0x71CC130", Slot = "22")]
		[AsyncStateMachine(typeof(_003CAwait_003Ed__36))]
		public virtual Task Await()
		{
			return null;
		}

		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0x71CC1F0", Offset = "0x71C81F0", VA = "0x71CC1F0", Slot = "23")]
		protected virtual void CloseBefore()
		{
		}

		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0x71CC1F4", Offset = "0x71C81F4", VA = "0x71CC1F4", Slot = "11")]
		protected override void VisibleBefore(bool value)
		{
		}

		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0x71CC1F8", Offset = "0x71C81F8", VA = "0x71CC1F8", Slot = "12")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x71CC214", Offset = "0x71C8214", VA = "0x71CC214")]
		public void SetPreCache(bool value)
		{
		}

		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x71CC220", Offset = "0x71C8220", VA = "0x71CC220")]
		public bool GetPreCache()
		{
			return default;
		}

		[Token(Token = "0x6005E42")]
		[Address(RVA = "0x71CC228", Offset = "0x71C8228", VA = "0x71CC228")]
		public BaseUI()
		{
		}
	}
}
