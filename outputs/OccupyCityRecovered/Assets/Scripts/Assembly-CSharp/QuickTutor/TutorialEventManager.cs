using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace QuickTutor
{
	[Token(Token = "0x2000C88")]
	public class TutorialEventManager : ManagerBase<TutorialEventManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C8E")]
		[CompilerGenerated]
		private struct _003CCheckTutorial_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialEventManager _003C_003E4__this;

			[Token(Token = "0x6004ED0")]
			[Address(RVA = "0x42AA10C", Offset = "0x42A610C", VA = "0x42AA10C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004ED1")]
			[Address(RVA = "0x42AA380", Offset = "0x42A6380", VA = "0x42AA380", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C8F")]
		[CompilerGenerated]
		private struct _003CCheckTutorialOnArenaUnlock_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialEventManager _003C_003E4__this;

			[Token(Token = "0x4005A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004ED2")]
			[Address(RVA = "0x42AA38C", Offset = "0x42A638C", VA = "0x42AA38C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004ED3")]
			[Address(RVA = "0x42AA78C", Offset = "0x42A678C", VA = "0x42AA78C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C90")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialEventManager _003C_003E4__this;

			[Token(Token = "0x6004ED4")]
			[Address(RVA = "0x42AA798", Offset = "0x42A6798", VA = "0x42AA798", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004ED5")]
			[Address(RVA = "0x42AADDC", Offset = "0x42A6DDC", VA = "0x42AADDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isRecordingArtifactCharge;

		[Token(Token = "0x4005A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool IsArtifactDragTutorialActive;

		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x42A73EC", Offset = "0x42A33EC", VA = "0x42A73EC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x42A7470", Offset = "0x42A3470", VA = "0x42A7470")]
		public void CheckBattleArtifactTutorialOnCameraReady()
		{
		}

		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x42A7AC0", Offset = "0x42A3AC0", VA = "0x42A7AC0")]
		[AsyncStateMachine(typeof(_003CCheckTutorialOnArenaUnlock_003Ed__4))]
		public void CheckTutorialOnArenaUnlock()
		{
		}

		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x42A7B4C", Offset = "0x42A3B4C", VA = "0x42A7B4C")]
		[AsyncStateMachine(typeof(_003CCheckTutorial_003Ed__5))]
		public UniTask CheckTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x42A7BD0", Offset = "0x42A3BD0", VA = "0x42A7BD0")]
		private bool CheckArtifactIntroTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x42A7F84", Offset = "0x42A3F84", VA = "0x42A7F84")]
		private bool CheckFiefTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x42A83AC", Offset = "0x42A43AC", VA = "0x42A83AC")]
		private bool CheckArtifactSummonTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x42A867C", Offset = "0x42A467C", VA = "0x42A867C")]
		public static string GetCurrentChestTutorialId()
		{
			return null;
		}

		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x42A86BC", Offset = "0x42A46BC", VA = "0x42A86BC")]
		public bool CheckChestTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x42A8974", Offset = "0x42A4974", VA = "0x42A8974")]
		private bool CheckMoraleTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EAF")]
		[Address(RVA = "0x42A8B90", Offset = "0x42A4B90", VA = "0x42A8B90")]
		private bool CheckSeasonPassTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EB0")]
		[Address(RVA = "0x42A8DD8", Offset = "0x42A4DD8", VA = "0x42A8DD8")]
		private bool CheckWeeklyClashTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EB1")]
		[Address(RVA = "0x42A9020", Offset = "0x42A5020", VA = "0x42A9020")]
		public bool CheckRuneStoneTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x42A79E4", Offset = "0x42A39E4", VA = "0x42A79E4")]
		private void StartRecordArtifactCharge()
		{
		}

		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x42A926C", Offset = "0x42A526C", VA = "0x42A926C")]
		private void OnArtifactFullCharge(object obj)
		{
		}

		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x42A94D8", Offset = "0x42A54D8", VA = "0x42A94D8")]
		public TutorialEventManager()
		{
		}
	}
}
