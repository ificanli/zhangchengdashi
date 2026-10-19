using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BF3")]
	public class UserResourcesPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BF4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4005696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserResourcesPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x4252F30", Offset = "0x424EF30", VA = "0x4252F30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x42531A8", Offset = "0x424F1A8", VA = "0x42531A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformLayout;

		[Token(Token = "0x17000CED")]
		public RectTransform RectTransformLayout
		{
			[Token(Token = "0x60049EF")]
			[Address(RVA = "0x424FDBC", Offset = "0x424BDBC", VA = "0x424FDBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x4252E70", Offset = "0x424EE70", VA = "0x4252E70")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x424F34C", Offset = "0x424B34C", VA = "0x424F34C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x425238C", Offset = "0x424E38C", VA = "0x425238C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__29))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x4252E74", Offset = "0x424EE74", VA = "0x4252E74", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x42521C8", Offset = "0x424E1C8", VA = "0x42521C8")]
		public UserResourcesPanelComponents()
		{
		}
	}
}
