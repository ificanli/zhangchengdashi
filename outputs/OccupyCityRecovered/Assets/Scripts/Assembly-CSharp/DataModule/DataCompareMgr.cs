using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameFramework.GameData;
using Il2CppDummyDll;
using L_Tools;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000E22")]
	public class DataCompareMgr : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E23")]
		[CompilerGenerated]
		private struct _003CCompareData_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4006298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400629A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DataCompareMgr _003C_003E4__this;

			[Token(Token = "0x400629B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005716")]
			[Address(RVA = "0x434C168", Offset = "0x4348168", VA = "0x434C168", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005717")]
			[Address(RVA = "0x434C544", Offset = "0x4348544", VA = "0x434C544", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] NeedCompareDataList;

		[Token(Token = "0x4006292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ManualHandleDataDelegate _manualHandleDataDelegate;

		[Token(Token = "0x4006293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComflictStatus comflictStatus;

		[Token(Token = "0x4006294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DataCompareMgr _instance;

		[Token(Token = "0x4006295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerPrefs2RunTime _local;

		[Token(Token = "0x4006296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PlayerPrefs2RunTime _server;

		[Token(Token = "0x4006297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int RequestServerDataRetryCount;

		[Token(Token = "0x6005705")]
		[Address(RVA = "0x43496B8", Offset = "0x43456B8", VA = "0x43496B8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6005706")]
		[Address(RVA = "0x434985C", Offset = "0x434585C", VA = "0x434985C")]
		public bool StartCompare(ManualHandleDataDelegate manualHandleData)
		{
			return default;
		}

		[Token(Token = "0x6005707")]
		[Address(RVA = "0x4349900", Offset = "0x4345900", VA = "0x4349900")]
		public void StartCompare()
		{
		}

		[Token(Token = "0x6005708")]
		[Address(RVA = "0x4349A34", Offset = "0x4345A34", VA = "0x4349A34")]
		private void OnLTDataCallback(List<RevServerGameData> serverList, bool isSucceed)
		{
		}

		[Token(Token = "0x6005709")]
		[Address(RVA = "0x434A288", Offset = "0x4346288", VA = "0x434A288")]
		public void OnLTCompareFinish()
		{
		}

		[Token(Token = "0x600570A")]
		[Address(RVA = "0x434A5A0", Offset = "0x43465A0", VA = "0x434A5A0")]
		private ComflictStatus VersionConflict()
		{
			return default;
		}

		[Token(Token = "0x600570B")]
		[Address(RVA = "0x4349FE4", Offset = "0x4345FE4", VA = "0x4349FE4")]
		private bool CheckSaveUserID(bool isLocal, string saveID)
		{
			return default;
		}

		[Token(Token = "0x600570C")]
		[Address(RVA = "0x434ABD0", Offset = "0x4346BD0", VA = "0x434ABD0")]
		[AsyncStateMachine(typeof(_003CCompareData_003Ed__13))]
		public void CompareData()
		{
		}

		[Token(Token = "0x600570D")]
		[Address(RVA = "0x434AE78", Offset = "0x4346E78", VA = "0x434AE78")]
		public CompareData BuildLocalData()
		{
			return null;
		}

		[Token(Token = "0x600570E")]
		[Address(RVA = "0x434B1E4", Offset = "0x43471E4", VA = "0x434B1E4")]
		public void RequestServerData()
		{
		}

		[Token(Token = "0x600570F")]
		[Address(RVA = "0x434B498", Offset = "0x4347498", VA = "0x434B498")]
		private void OnRequestDataCallback(List<RevServerGameData> serverList, bool isSucceed)
		{
		}

		[Token(Token = "0x6005710")]
		[Address(RVA = "0x434BEAC", Offset = "0x4347EAC", VA = "0x434BEAC")]
		public void OnUseChoose(bool uselocal)
		{
		}

		[Token(Token = "0x6005711")]
		[Address(RVA = "0x434BF58", Offset = "0x4347F58", VA = "0x434BF58")]
		public DataCompareMgr()
		{
		}
	}
}
