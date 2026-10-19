using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIFramework
{
	[Token(Token = "0x2000C4D")]
	public class UIPanel : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C4E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4005855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIPanel _003C_003E4__this;

			[Token(Token = "0x6004C50")]
			[Address(RVA = "0x4275744", Offset = "0x4271744", VA = "0x4275744", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C51")]
			[Address(RVA = "0x4275B58", Offset = "0x4271B58", VA = "0x4275B58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TweenRoot;

		[Token(Token = "0x4005852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isPlayTween;

		[Token(Token = "0x4005853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas _canvas;

		[Token(Token = "0x4005854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PanelConfig panelConfig;

		[Token(Token = "0x17000D8A")]
		protected RectTransform TweenRoot
		{
			[Token(Token = "0x6004C3E")]
			[Address(RVA = "0x427520C", Offset = "0x427120C", VA = "0x427520C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C3F")]
			[Address(RVA = "0x4275214", Offset = "0x4271214", VA = "0x4275214")]
			set
			{
			}
		}

		[Token(Token = "0x17000D8B")]
		protected bool IsPlayTween
		{
			[Token(Token = "0x6004C40")]
			[Address(RVA = "0x4275278", Offset = "0x4271278", VA = "0x4275278")]
			get
			{
				return m_isPlayTween;
			}
		}

		[Token(Token = "0x17000D8C")]
		public bool IsShowing
		{
			[Token(Token = "0x6004C41")]
			[Address(RVA = "0x4275280", Offset = "0x4271280", VA = "0x4275280")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000D8D")]
		private Canvas Canvas
		{
			[Token(Token = "0x6004C42")]
			[Address(RVA = "0x42752A0", Offset = "0x42712A0", VA = "0x42752A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x4275334", Offset = "0x4271334", VA = "0x4275334", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x4275338", Offset = "0x4271338", VA = "0x4275338", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__13))]
		public virtual UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x42753BC", Offset = "0x42713BC", VA = "0x42753BC", Slot = "6")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x42755D8", Offset = "0x42715D8", VA = "0x42755D8", Slot = "7")]
		protected virtual void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x42755DC", Offset = "0x42715DC", VA = "0x42755DC", Slot = "8")]
		protected virtual void OnOpenAnimationComplete()
		{
		}

		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x42755E0", Offset = "0x42715E0", VA = "0x42755E0")]
		public void UnloadObject()
		{
		}

		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x427564C", Offset = "0x427164C", VA = "0x427564C", Slot = "9")]
		public virtual void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x4275650", Offset = "0x4271650", VA = "0x4275650", Slot = "10")]
		public virtual void InvokeMethod(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x4275654", Offset = "0x4271654", VA = "0x4275654", Slot = "11")]
		protected virtual void BindButtonEvent()
		{
		}

		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x4275658", Offset = "0x4271658", VA = "0x4275658")]
		public void Init(PanelConfig panelConfig)
		{
			this.panelConfig = panelConfig;
		}

		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x4275660", Offset = "0x4271660", VA = "0x4275660")]
		public UIPanel()
		{
		}
	}
}
