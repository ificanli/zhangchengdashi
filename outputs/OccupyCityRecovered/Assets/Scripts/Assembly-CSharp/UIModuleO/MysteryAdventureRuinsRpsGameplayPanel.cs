using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A3A")]
	public class MysteryAdventureRuinsRpsGameplayPanel : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A3B")]
		[CompilerGenerated]
		private struct _003CEnsureTitleBackgroundSpritesAsync_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureRuinsRpsGameplayPanel _003C_003E4__this;

			[Token(Token = "0x4004BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int sessionId;

			[Token(Token = "0x4004BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<(Sprite, Sprite)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003D22")]
			[Address(RVA = "0x41565FC", Offset = "0x41525FC", VA = "0x41565FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003D23")]
			[Address(RVA = "0x4156EDC", Offset = "0x4152EDC", VA = "0x4156EDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A3C")]
		[CompilerGenerated]
		private struct _003CPlayAsync_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<MysteryAdventureRpsOutcome> _003C_003Et__builder;

			[Token(Token = "0x4004BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MysteryAdventureRuinsRpsGameplayPanel _003C_003E4__this;

			[Token(Token = "0x4004BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int playerChoice;

			[Token(Token = "0x4004BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int opponentChoice;

			[Token(Token = "0x4004BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool skipAnimation;

			[Token(Token = "0x4004BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private MysteryAdventureRpsOutcome _003Coutcome_003E5__2;

			[Token(Token = "0x4004BE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CsessionId_003E5__3;

			[Token(Token = "0x4004BE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004BE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003D24")]
			[Address(RVA = "0x4156EE8", Offset = "0x4152EE8", VA = "0x4156EE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003D25")]
			[Address(RVA = "0x4158210", Offset = "0x4154210", VA = "0x4158210", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A3D")]
		[CompilerGenerated]
		private struct _003CPrepareGameplaySpritesAsync_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4004BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureRuinsRpsGameplayPanel _003C_003E4__this;

			[Token(Token = "0x4004BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int sessionId;

			[Token(Token = "0x4004BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public MysteryAdventureRpsOutcome outcome;

			[Token(Token = "0x4004BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int playerChoice;

			[Token(Token = "0x4004BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int opponentChoice;

			[Token(Token = "0x4004BF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004BF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<(Sprite, Sprite, Sprite, Sprite, Sprite, Sprite)>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6003D26")]
			[Address(RVA = "0x4158268", Offset = "0x4154268", VA = "0x4158268", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003D27")]
			[Address(RVA = "0x4158CE4", Offset = "0x4154CE4", VA = "0x4158CE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MysteryAdventureRuinsRpsGameplayPanelView _view;

		[Token(Token = "0x4004BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _playSessionId;

		[Token(Token = "0x4004BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _titleBackgroundSpritesReady;

		[Token(Token = "0x4004BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool _isPlayTween;

		[Token(Token = "0x4004BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _animationSpeed;

		[Token(Token = "0x17000938")]
		public bool IsPlayTween
		{
			[Token(Token = "0x6003D16")]
			[Address(RVA = "0x4155F80", Offset = "0x4151F80", VA = "0x4155F80")]
			get
			{
				return _isPlayTween;
			}
		}

		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x4155F88", Offset = "0x4151F88", VA = "0x4155F88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x415606C", Offset = "0x415206C", VA = "0x415606C")]
		[AsyncStateMachine(typeof(_003CPlayAsync_003Ed__8))]
		public UniTask<MysteryAdventureRpsOutcome> PlayAsync(int playerChoice, int opponentChoice, bool skipAnimation = false)
		{
			return default;
		}

		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x4156150", Offset = "0x4152150", VA = "0x4156150")]
		public void Hide()
		{
		}

		[Token(Token = "0x6003D1A")]
		[Address(RVA = "0x415627C", Offset = "0x415227C", VA = "0x415627C")]
		private void PreparePanelForPlay()
		{
		}

		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x41562A0", Offset = "0x41522A0", VA = "0x41562A0")]
		[AsyncStateMachine(typeof(_003CPrepareGameplaySpritesAsync_003Ed__11))]
		private UniTask PrepareGameplaySpritesAsync(int sessionId, int playerChoice, int opponentChoice, MysteryAdventureRpsOutcome outcome)
		{
			return default;
		}

		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x41561EC", Offset = "0x41521EC", VA = "0x41561EC")]
		private void ResetVisualState()
		{
		}

		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x41563E0", Offset = "0x41523E0", VA = "0x41563E0")]
		[AsyncStateMachine(typeof(_003CEnsureTitleBackgroundSpritesAsync_003Ed__13))]
		private UniTask EnsureTitleBackgroundSpritesAsync(int sessionId)
		{
			return default;
		}

		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x4156480", Offset = "0x4152480", VA = "0x4156480")]
		private static void AssignStaticSprite(Image image, Sprite sprite)
		{
		}

		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x4156548", Offset = "0x4152548", VA = "0x4156548")]
		private static void ApplySprite(Image image, Sprite sprite)
		{
		}

		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x415635C", Offset = "0x415235C", VA = "0x415635C")]
		private static void ClearSprite(Image image)
		{
		}

		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x41565EC", Offset = "0x41525EC", VA = "0x41565EC")]
		public MysteryAdventureRuinsRpsGameplayPanel()
		{
		}
	}
}
