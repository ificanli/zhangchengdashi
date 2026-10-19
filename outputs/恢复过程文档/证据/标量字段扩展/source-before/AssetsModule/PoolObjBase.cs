using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetsModule
{
	[Token(Token = "0x200064E")]
	public class PoolObjBase : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200064F")]
		[CompilerGenerated]
		private struct _003CDelayDisappear_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4003374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PoolObjBase _003C_003E4__this;

			[Token(Token = "0x4003377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600213C")]
			[Address(RVA = "0x3F222B0", Offset = "0x3F1E2B0", VA = "0x3F222B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600213D")]
			[Address(RVA = "0x3F22690", Offset = "0x3F1E690", VA = "0x3F22690", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _hadAppear;

		[Token(Token = "0x4003371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _delayRecycleTime;

		[Token(Token = "0x4003372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _originalLocalScale;

		[Token(Token = "0x4003373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CancellationTokenSource _cancellationTokenSource;

		[Token(Token = "0x170001CE")]
		public bool HadAppear
		{
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x3F220E4", Offset = "0x3F1E0E4", VA = "0x3F220E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6002136")]
		[Address(RVA = "0x3F220EC", Offset = "0x3F1E0EC", VA = "0x3F220EC", Slot = "4")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6002137")]
		[Address(RVA = "0x3F2211C", Offset = "0x3F1E11C", VA = "0x3F2211C", Slot = "5")]
		public virtual void Appear(float delayRecycleTime = -1f)
		{
		}

		[Token(Token = "0x6002138")]
		[Address(RVA = "0x3F22170", Offset = "0x3F1E170", VA = "0x3F22170")]
		[AsyncStateMachine(typeof(_003CDelayDisappear_003Ed__8))]
		private void DelayDisappear()
		{
		}

		[Token(Token = "0x6002139")]
		[Address(RVA = "0x3F221FC", Offset = "0x3F1E1FC", VA = "0x3F221FC", Slot = "6")]
		public virtual void Disappear()
		{
		}

		[Token(Token = "0x600213A")]
		[Address(RVA = "0x3F22270", Offset = "0x3F1E270", VA = "0x3F22270")]
		private void CancelDelayDisappear()
		{
		}

		[Token(Token = "0x600213B")]
		[Address(RVA = "0x3F222A8", Offset = "0x3F1E2A8", VA = "0x3F222A8")]
		public PoolObjBase()
		{
		}
	}
}
