using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C43")]
	public class AutoSafeAreaAligner : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C44")]
		[CompilerGenerated]
		private struct _003CRefreshAlignNextFrame_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AutoSafeAreaAligner _003C_003E4__this;

			[Token(Token = "0x4005828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004C08")]
			[Address(RVA = "0x4272088", Offset = "0x426E088", VA = "0x4272088", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004C09")]
			[Address(RVA = "0x4272348", Offset = "0x426E348", VA = "0x4272348", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform _selfRectTransform;

		[Token(Token = "0x4005824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 safeAreaPadding;

		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x4271EE8", Offset = "0x426DEE8", VA = "0x4271EE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x4271F38", Offset = "0x426DF38", VA = "0x4271F38")]
		private void Start()
		{
		}

		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x4271F4C", Offset = "0x426DF4C", VA = "0x4271F4C")]
		[AsyncStateMachine(typeof(_003CRefreshAlignNextFrame_003Ed__4))]
		private UniTask RefreshAlignNextFrame()
		{
			return default;
		}

		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x4271FD4", Offset = "0x426DFD4", VA = "0x4271FD4")]
		public void RefreshAlign()
		{
		}

		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x4272070", Offset = "0x426E070", VA = "0x4272070")]
		private void Adapt()
		{
		}

		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x4272074", Offset = "0x426E074", VA = "0x4272074")]
		public AutoSafeAreaAligner()
		{
		}
	}
}
