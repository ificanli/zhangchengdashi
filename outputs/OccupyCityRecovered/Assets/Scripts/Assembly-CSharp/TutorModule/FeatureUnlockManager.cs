using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace TutorModule
{
	[Token(Token = "0x20001FA")]
	public class FeatureUnlockManager : ManagerBase<FeatureUnlockManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001FB")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FeatureUnlockManager _003C_003E4__this;

			[Token(Token = "0x4001CD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TutorialResourceManager _003CtutorialResourceManager_003E5__2;

			[Token(Token = "0x4001CD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<TutorialResourceManager>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x418BDD8", Offset = "0x4187DD8", VA = "0x418BDD8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x418C324", Offset = "0x4188324", VA = "0x418C324", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FeatureUnlockCtrl _featureUnlockCtrl;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x418BA68", Offset = "0x4187A68", VA = "0x418BA68", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x418BAF4", Offset = "0x4187AF4", VA = "0x418BAF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x418BB04", Offset = "0x4187B04", VA = "0x418BB04")]
		public bool IsUnlock(string infoId, bool showTip = false)
		{
			return default;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x418BC3C", Offset = "0x4187C3C", VA = "0x418BC3C")]
		public UserFeatureUnlockData GetFeatureData(string infoId)
		{
			return null;
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x418BBD8", Offset = "0x4187BD8", VA = "0x418BBD8")]
		public void ShowUnlockTip(string infoId)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x418BCBC", Offset = "0x4187CBC", VA = "0x418BCBC")]
		public string GetUnlockTip(string infoId)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x418BD90", Offset = "0x4187D90", VA = "0x418BD90")]
		public FeatureUnlockManager()
		{
		}
	}
}
