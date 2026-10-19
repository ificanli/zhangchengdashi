using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200043E")]
	public class CoreGameManager : ManagerBase<CoreGameManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200043F")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40029FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CoreGameManager _003C_003E4__this;

			[Token(Token = "0x4002A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600149C")]
			[Address(RVA = "0x3E01AEC", Offset = "0x3DFDAEC", VA = "0x3E01AEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600149D")]
			[Address(RVA = "0x3E02C90", Offset = "0x3DFEC90", VA = "0x3E02C90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000440")]
		[CompilerGenerated]
		private struct _003CLoadRoleAssets_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4002A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalRoleInfo info;

			[Token(Token = "0x4002A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int enemy;

			[Token(Token = "0x4002A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CoreGameManager _003C_003E4__this;

			[Token(Token = "0x4002A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600149E")]
			[Address(RVA = "0x3E02C9C", Offset = "0x3DFEC9C", VA = "0x3E02C9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600149F")]
			[Address(RVA = "0x3E0331C", Offset = "0x3DFF31C", VA = "0x3E0331C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000441")]
		[CompilerGenerated]
		private struct _003CStartGame_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleContext battleContext;

			[Token(Token = "0x4002A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x3E03374", Offset = "0x3DFF374", VA = "0x3E03374", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x3E04E18", Offset = "0x3E00E18", VA = "0x3E04E18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40029F6")]
		public const int WebGLRolePrewarmCount = 8;

		[Token(Token = "0x40029F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string _nowPlayEdArenaID;

		[Token(Token = "0x40029F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ShowHexDesPanel;

		[Token(Token = "0x40029FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _mouseDownPos;

		[Token(Token = "0x40029FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _mouseUpPos;

		[Token(Token = "0x40029FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool canCheat;

		[Token(Token = "0x40029FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool goldCardTest;

		[Token(Token = "0x40029FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HashSet<GameObject> hadLoadedGameRole;

		[Token(Token = "0x1700013A")]
		public static bool Gaming
		{
			[Token(Token = "0x600148F")]
			[Address(RVA = "0x3E00EBC", Offset = "0x3DFCEBC", VA = "0x3E00EBC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001490")]
			[Address(RVA = "0x3E00F14", Offset = "0x3DFCF14", VA = "0x3E00F14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public static string NowPlayEdArenaID
		{
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x3E00F74", Offset = "0x3DFCF74", VA = "0x3E00F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001492")]
			[Address(RVA = "0x3E00FCC", Offset = "0x3DFCFCC", VA = "0x3E00FCC")]
			set
			{
			}
		}

		[Token(Token = "0x6001493")]
		[Address(RVA = "0x3E01064", Offset = "0x3DFD064", VA = "0x3E01064", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__15))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001494")]
		[Address(RVA = "0x3E010F0", Offset = "0x3DFD0F0", VA = "0x3E010F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6001495")]
		[Address(RVA = "0x3E01570", Offset = "0x3DFD570", VA = "0x3E01570")]
		private void OnHexDescribesPanelChangeActive(object o)
		{
		}

		[Token(Token = "0x6001496")]
		[Address(RVA = "0x3E015E8", Offset = "0x3DFD5E8", VA = "0x3E015E8")]
		[AsyncStateMachine(typeof(_003CStartGame_003Ed__18))]
		public void StartGame(BattleContext battleContext)
		{
		}

		[Token(Token = "0x6001497")]
		[Address(RVA = "0x3E01674", Offset = "0x3DFD674", VA = "0x3E01674")]
		public void StartGameDefeat()
		{
		}

		[Token(Token = "0x6001498")]
		[Address(RVA = "0x3E01708", Offset = "0x3DFD708", VA = "0x3E01708")]
		private void OnGameOver(object o)
		{
		}

		[Token(Token = "0x6001499")]
		[Address(RVA = "0x3E01904", Offset = "0x3DFD904", VA = "0x3E01904")]
		[AsyncStateMachine(typeof(_003CLoadRoleAssets_003Ed__21))]
		public UniTask<GameObject> LoadRoleAssets(GlobalRoleInfo info, int enemy)
		{
			return default;
		}

		[Token(Token = "0x600149A")]
		[Address(RVA = "0x3E019F4", Offset = "0x3DFD9F4", VA = "0x3E019F4")]
		public CoreGameManager()
		{
		}
	}
}
