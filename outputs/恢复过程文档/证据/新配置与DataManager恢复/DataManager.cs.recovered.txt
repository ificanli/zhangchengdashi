using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using EventModule;

namespace DataModule
{
	[Token(Token = "0x2000E29")]
	public class DataManager : ManagerBase<DataManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E2A")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40062BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40062BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DataManager _003C_003E4__this;

			[Token(Token = "0x600573F")]
			[Address(RVA = "0x434F5AC", Offset = "0x434B5AC", VA = "0x434F5AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005740")]
			[Address(RVA = "0x434F8B8", Offset = "0x434B8B8", VA = "0x434F8B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E2B")]
		[CompilerGenerated]
		private struct _003CLoadConfig_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40062BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40062C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DataManager _003C_003E4__this;

			[Token(Token = "0x40062C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005741")]
			[Address(RVA = "0x434F8C4", Offset = "0x434B8C4", VA = "0x434F8C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005742")]
			[Address(RVA = "0x435063C", Offset = "0x434C63C", VA = "0x435063C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E2C")]
		[CompilerGenerated]
		private struct _003CLoadData_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40062C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40062C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DataManager _003C_003E4__this;

			[Token(Token = "0x40062C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005743")]
			[Address(RVA = "0x4350648", Offset = "0x434C648", VA = "0x4350648", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005744")]
			[Address(RVA = "0x4350CEC", Offset = "0x434CCEC", VA = "0x4350CEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40062B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GetDataAgain;

		[Token(Token = "0x40062B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool loadConfigComplete;

		[Token(Token = "0x40062B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool SaveConflictCheckFinish;

		[Token(Token = "0x40062B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool HasCheckedSaveConflict;

		[Token(Token = "0x40062BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static ComflictStatus ComflictStatus;

		[Token(Token = "0x17000EB5")]
		public bool LoadDataCompleted
		{
			[Token(Token = "0x600572C")]
			[Address(RVA = "0x434D548", Offset = "0x4349548", VA = "0x434D548")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x600572D")]
			[Address(RVA = "0x434D550", Offset = "0x4349550", VA = "0x434D550")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x17000EB6")]
		public GlobalInfo GlobalInfo
		{
			[Token(Token = "0x600572E")]
			[Address(RVA = "0x434D55C", Offset = "0x434955C", VA = "0x434D55C")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x600572F")]
			[Address(RVA = "0x434D564", Offset = "0x4349564", VA = "0x434D564")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x6005730")]
		[Address(RVA = "0x434D56C", Offset = "0x434956C", VA = "0x434D56C")]
		public void ChooseConflict(ComflictStatus comflictStatus)
		{
		}

		[Token(Token = "0x6005731")]
		[Address(RVA = "0x434D5C0", Offset = "0x43495C0", VA = "0x434D5C0", Slot = "4")]
		public override async UniTask Init()
		{
			EventManager.Instance.StartListening("StartGame", PlayGame);
			EventManager.Instance.StartListening("GameWin", GameWin);
		}

		[Token(Token = "0x6005732")]
		[Address(RVA = "0x434D644", Offset = "0x4349644", VA = "0x434D644")]
		public async UniTask LoadConfig()
		{
			GlobalInfo = new GlobalInfo();
			await GlobalInfo.InitInfo();
			loadConfigComplete = true;
		}

		[Token(Token = "0x6005733")]
		[Address(RVA = "0x434D6CC", Offset = "0x43496CC", VA = "0x434D6CC")]
		[AsyncStateMachine(typeof(_003CLoadData_003Ed__16))]
		public UniTask LoadData()
		{
			return default;
		}

		[Token(Token = "0x6005734")]
		[Address(RVA = "0x434D758", Offset = "0x4349758", VA = "0x434D758")]
		private void LoadAllSaveData()
		{
		}

		[Token(Token = "0x6005735")]
		[Address(RVA = "0x434DB9C", Offset = "0x4349B9C", VA = "0x434DB9C")]
		public void StopAllSave()
		{
		}

		[Token(Token = "0x6005736")]
		[Address(RVA = "0x434DE20", Offset = "0x4349E20", VA = "0x434DE20")]
		public void SaveAllData()
		{
		}

		[Token(Token = "0x6005737")]
		[Address(RVA = "0x434E254", Offset = "0x434A254", VA = "0x434E254")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x6005738")]
		[Address(RVA = "0x434E668", Offset = "0x434A668", VA = "0x434E668")]
		public void CheckDanChange(bool refreshRankAllInfo = false)
		{
		}

		[Token(Token = "0x6005739")]
		[Address(RVA = "0x434E734", Offset = "0x434A734", VA = "0x434E734")]
		private void CheckDan()
		{
		}

		[Token(Token = "0x600573A")]
		[Address(RVA = "0x434EA94", Offset = "0x434AA94", VA = "0x434EA94")]
		private void DanLogoJudge()
		{
		}

		[Token(Token = "0x600573B")]
		[Address(RVA = "0x434EF38", Offset = "0x434AF38", VA = "0x434EF38")]
		public void CheckDanCount()
		{
		}

		[Token(Token = "0x600573C")]
		[Address(RVA = "0x434F170", Offset = "0x434B170", VA = "0x434F170")]
		public void PlayGame(object o)
		{
		}

		[Token(Token = "0x600573D")]
		[Address(RVA = "0x434F340", Offset = "0x434B340", VA = "0x434F340")]
		public void GameWin(object o)
		{
		}

		[Token(Token = "0x600573E")]
		[Address(RVA = "0x434F564", Offset = "0x434B564", VA = "0x434F564")]
		public DataManager()
		{
		}
	}
}
