using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x2000722")]
	public class BoxShowIcon : BoxShowIconComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000723")]
		[CompilerGenerated]
		private struct _003CInItInfo_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4003884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BoxShowIcon _003C_003E4__this;

			[Token(Token = "0x4003887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserBoxData data;

			[Token(Token = "0x4003888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60026F1")]
			[Address(RVA = "0x3F9AE04", Offset = "0x3F96E04", VA = "0x3F9AE04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026F2")]
			[Address(RVA = "0x3F9B410", Offset = "0x3F97410", VA = "0x3F9B410", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000724")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4003889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400388A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400388B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxShowIcon _003C_003E4__this;

			[Token(Token = "0x400388C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60026F3")]
			[Address(RVA = "0x3F9B41C", Offset = "0x3F9741C", VA = "0x3F9B41C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x3F9B5FC", Offset = "0x3F975FC", VA = "0x3F9B5FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UserBoxData _data;

		[Token(Token = "0x4003881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TimeManager.Timer _timer;

		[Token(Token = "0x4003882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Sequence sequence;

		[Token(Token = "0x4003883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _lastUpdateTime;

		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x3F9A5BC", Offset = "0x3F965BC", VA = "0x3F9A5BC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x3F9A650", Offset = "0x3F96650", VA = "0x3F9A650")]
		[AsyncStateMachine(typeof(_003CInItInfo_003Ed__5))]
		public void InItInfo(UserBoxData data)
		{
		}

		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x3F9A6EC", Offset = "0x3F966EC", VA = "0x3F9A6EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x3F9A978", Offset = "0x3F96978", VA = "0x3F9A978")]
		private void CheckIsUnLockEd()
		{
		}

		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x3F9AD34", Offset = "0x3F96D34", VA = "0x3F9AD34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x3F9AD5C", Offset = "0x3F96D5C", VA = "0x3F9AD5C")]
		public BoxShowIcon()
		{
		}
	}
}
