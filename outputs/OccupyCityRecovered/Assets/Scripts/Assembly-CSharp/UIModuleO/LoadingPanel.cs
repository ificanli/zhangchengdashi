using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000925")]
	public class LoadingPanel : LoadingPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000927")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400449C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400449D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400449E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoadingPanel _003C_003E4__this;

			[Token(Token = "0x60034EA")]
			[Address(RVA = "0x40AE5F0", Offset = "0x40AA5F0", VA = "0x40AE5F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034EB")]
			[Address(RVA = "0x40AE6EC", Offset = "0x40AA6EC", VA = "0x40AE6EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000928")]
		[CompilerGenerated]
		private struct _003CLoadSeasonBackgroundSpine_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400449F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoadingPanel _003C_003E4__this;

			[Token(Token = "0x40044A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CbgPath_003E5__2;

			[Token(Token = "0x40044A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60034EC")]
			[Address(RVA = "0x40AE6F8", Offset = "0x40AA6F8", VA = "0x40AE6F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034ED")]
			[Address(RVA = "0x40AEDC0", Offset = "0x40AADC0", VA = "0x40AEDC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000929")]
		[CompilerGenerated]
		private struct _003CLoadSeasonBackgroundSprite_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40044A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoadingPanel _003C_003E4__this;

			[Token(Token = "0x40044A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CbgPath2_003E5__2;

			[Token(Token = "0x40044A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60034EE")]
			[Address(RVA = "0x40AEDCC", Offset = "0x40AADCC", VA = "0x40AEDCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034EF")]
			[Address(RVA = "0x40AF35C", Offset = "0x40AB35C", VA = "0x40AF35C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200092A")]
		[CompilerGenerated]
		private struct _003COnAssetsManagerInitComplete_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x40044A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40044AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40044AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoadingPanel _003C_003E4__this;

			[Token(Token = "0x40044AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60034F0")]
			[Address(RVA = "0x40AF368", Offset = "0x40AB368", VA = "0x40AF368", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034F1")]
			[Address(RVA = "0x40AF9AC", Offset = "0x40AB9AC", VA = "0x40AF9AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float updateTextInterTime;

		[Token(Token = "0x4004496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int dotNumber;

		[Token(Token = "0x4004497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string loadingTextStr;

		[Token(Token = "0x4004498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int loadingTextTextLength;

		[Token(Token = "0x17000756")]
		public bool IsProgressBarActive
		{
			[Token(Token = "0x60034DA")]
			[Address(RVA = "0x40ADDF0", Offset = "0x40A9DF0", VA = "0x40ADDF0")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x60034DB")]
			[Address(RVA = "0x40ADDF8", Offset = "0x40A9DF8", VA = "0x40ADDF8")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x40ADE04", Offset = "0x40A9E04", VA = "0x40ADE04")]
		public void SetProgressBarActive(bool active)
		{
		}

		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x40ADE10", Offset = "0x40A9E10", VA = "0x40ADE10", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__5))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x40ADE9C", Offset = "0x40A9E9C", VA = "0x40ADE9C")]
		[AsyncStateMachine(typeof(_003COnAssetsManagerInitComplete_003Ed__6))]
		private void OnAssetsManagerInitComplete()
		{
		}

		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x40ADF28", Offset = "0x40A9F28", VA = "0x40ADF28")]
		[AsyncStateMachine(typeof(_003CLoadSeasonBackgroundSpine_003Ed__7))]
		private void LoadSeasonBackgroundSpine()
		{
		}

		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x40ADFB8", Offset = "0x40A9FB8", VA = "0x40ADFB8")]
		[AsyncStateMachine(typeof(_003CLoadSeasonBackgroundSprite_003Ed__8))]
		private void LoadSeasonBackgroundSprite()
		{
		}

		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x40AE048", Offset = "0x40AA048", VA = "0x40AE048")]
		private void Start()
		{
		}

		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x40AE14C", Offset = "0x40AA14C", VA = "0x40AE14C")]
		private void Update()
		{
		}

		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x40AE1FC", Offset = "0x40AA1FC", VA = "0x40AE1FC", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x40AE4C4", Offset = "0x40AA4C4", VA = "0x40AE4C4")]
		public LoadingPanel()
		{
		}
	}
}
