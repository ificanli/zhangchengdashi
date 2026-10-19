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
	[Token(Token = "0x200045A")]
	public class TrainingGroundManager : ManagerBase<TrainingGroundManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200045E")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrainingGroundManager _003C_003E4__this;

			[Token(Token = "0x6001566")]
			[Address(RVA = "0x3E16150", Offset = "0x3E12150", VA = "0x3E16150", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001567")]
			[Address(RVA = "0x3E17350", Offset = "0x3E13350", VA = "0x3E17350", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200045F")]
		[CompilerGenerated]
		private struct _003CStartNewPathTimeTutorialTimer_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrainingGroundManager _003C_003E4__this;

			[Token(Token = "0x4002AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001568")]
			[Address(RVA = "0x3E1735C", Offset = "0x3E1335C", VA = "0x3E1735C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001569")]
			[Address(RVA = "0x3E17668", Offset = "0x3E13668", VA = "0x3E17668", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000460")]
		[CompilerGenerated]
		private struct _003CStartThirdGameEnemyFlipTutorialTimer_19008_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrainingGroundManager _003C_003E4__this;

			[Token(Token = "0x4002AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float _003Cwaited_003E5__2;

			[Token(Token = "0x4002AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600156A")]
			[Address(RVA = "0x3E17674", Offset = "0x3E13674", VA = "0x3E17674", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600156B")]
			[Address(RVA = "0x3E17CA8", Offset = "0x3E13CA8", VA = "0x3E17CA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000461")]
		[CompilerGenerated]
		private struct _003CTriggerBeginTrainingGroundTutor_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600156C")]
			[Address(RVA = "0x3E17CB4", Offset = "0x3E13CB4", VA = "0x3E17CB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600156D")]
			[Address(RVA = "0x3E191BC", Offset = "0x3E151BC", VA = "0x3E191BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _handlingTutorClaimUniversalCardEnd;

		[Token(Token = "0x4002A7C")]
		public const int GuidedGameSkeletonSpawnTime = 14373;

		[Token(Token = "0x4002A7D")]
		public const int GuidedGameSkeletonGiantSpawnTime = 33995;

		[Token(Token = "0x4002A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, TrainingHexConfig> _currentHexConfigs;

		[Token(Token = "0x4002A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GlobalTrainingMapInfo _currentTrainingConfig;

		[Token(Token = "0x4002A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _forceDragonKnightEnabled;

		[Token(Token = "0x4002A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _forceDragonKnightHasCoords;

		[Token(Token = "0x4002A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HashSet<string> _forceDragonKnightHexKeys;

		[Token(Token = "0x4002A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector3> _enemyFlipSeq;

		[Token(Token = "0x4002A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _enemyFlipIndex;

		[Token(Token = "0x4002A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<float> _enemyFlipIntervals;

		[Token(Token = "0x4002A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _enemyFlipIntervalIndex;

		[Token(Token = "0x4002A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _hasRegisteredNewTutorialCoinTutorial;

		[Token(Token = "0x4002A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _hasRegisteredNewTutorialTimeTutorial;

		[Token(Token = "0x4002A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool _shouldContinueNewTutorialTimeTutorial;

		[Token(Token = "0x4002A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool _hasRegisteredNewTutorialEnemyFlipTutorial_19008;

		[Token(Token = "0x4002A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _shouldContinueNewTutorialEnemyFlipTutorial_19008;

		[Token(Token = "0x4002A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _pendingNewTutorialEnemyFlipReward_19008;

		[Token(Token = "0x1700013E")]
		public static bool IsInGuidedGame
		{
			[Token(Token = "0x6001526")]
			[Address(RVA = "0x3E04B74", Offset = "0x3E00B74", VA = "0x3E04B74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700013F")]
		public static bool IsInTrainingGround
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x3E102CC", Offset = "0x3E0C2CC", VA = "0x3E102CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000140")]
		public static bool IsCurrentTrainingGame
		{
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x3E10358", Offset = "0x3E0C358", VA = "0x3E10358")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x3E103A0", Offset = "0x3E0C3A0", VA = "0x3E103A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600152A")]
		[Address(RVA = "0x3E103F0", Offset = "0x3E0C3F0", VA = "0x3E103F0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__26))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600152B")]
		[Address(RVA = "0x3E10480", Offset = "0x3E0C480", VA = "0x3E10480")]
		private static void ResetTutorialsToUnComplete(IEnumerable<string> tutorialIds)
		{
		}

		[Token(Token = "0x600152C")]
		[Address(RVA = "0x3E1084C", Offset = "0x3E0C84C", VA = "0x3E1084C")]
		private static void SetTutorialsToComplete(IEnumerable<string> tutorialIds)
		{
		}

		[Token(Token = "0x600152D")]
		[Address(RVA = "0x3E10C18", Offset = "0x3E0CC18", VA = "0x3E10C18")]
		private void OnTutorStrategyEnded(object _)
		{
		}

		[Token(Token = "0x600152E")]
		[Address(RVA = "0x3E10D20", Offset = "0x3E0CD20", VA = "0x3E10D20")]
		private void OnEnemyBeginOpenHexForThirdGameTutorial(object _)
		{
		}

		[Token(Token = "0x600152F")]
		[Address(RVA = "0x3E10F68", Offset = "0x3E0CF68", VA = "0x3E10F68")]
		[AsyncStateMachine(typeof(_003CStartThirdGameEnemyFlipTutorialTimer_19008_003Ed__31))]
		private UniTaskVoid StartThirdGameEnemyFlipTutorialTimer_19008()
		{
			return default;
		}

		[Token(Token = "0x6001530")]
		[Address(RVA = "0x3E10FDC", Offset = "0x3E0CFDC", VA = "0x3E10FDC")]
		public bool ShouldEnterTraining()
		{
			return default;
		}

		[Token(Token = "0x6001531")]
		[Address(RVA = "0x3E04844", Offset = "0x3E00844", VA = "0x3E04844")]
		public GlobalTrainingMapInfo GetCurrentTrainingConfig()
		{
			return null;
		}

		[Token(Token = "0x6001532")]
		[Address(RVA = "0x3E11094", Offset = "0x3E0D094", VA = "0x3E11094")]
		private void ParseHexConfigs(GlobalTrainingMapInfo config)
		{
		}

		[Token(Token = "0x6001533")]
		[Address(RVA = "0x3E11404", Offset = "0x3E0D404", VA = "0x3E11404")]
		private void ParseEnemyFlipConfigs(GlobalTrainingMapInfo config)
		{
		}

		[Token(Token = "0x6001534")]
		[Address(RVA = "0x3E1173C", Offset = "0x3E0D73C", VA = "0x3E1173C")]
		private void ParseDragonKnightConfig(GlobalTrainingMapInfo config)
		{
		}

		[Token(Token = "0x6001535")]
		[Address(RVA = "0x3E11CF0", Offset = "0x3E0DCF0", VA = "0x3E11CF0")]
		public bool ShouldForceDragonKnightForHex(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6001536")]
		[Address(RVA = "0x3E11DB8", Offset = "0x3E0DDB8", VA = "0x3E11DB8")]
		public TrainingHexConfig GetFixedHexConfig(Vector3 position)
		{
			return null;
		}

		[Token(Token = "0x6001537")]
		[Address(RVA = "0x3E11E6C", Offset = "0x3E0DE6C", VA = "0x3E11E6C")]
		public void OnGuideEndEvent(string endTriggerEventId)
		{
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x3E12278", Offset = "0x3E0E278", VA = "0x3E12278")]
		public void OnTrainingGameComplete(bool isVictory)
		{
		}

		[Token(Token = "0x6001539")]
		[Address(RVA = "0x3E12544", Offset = "0x3E0E544", VA = "0x3E12544")]
		public void TriggerOldFetterTutor()
		{
		}

		[Token(Token = "0x600153A")]
		[Address(RVA = "0x3E12708", Offset = "0x3E0E708", VA = "0x3E12708")]
		public void TriggerUniversalCardTutor()
		{
		}

		[Token(Token = "0x600153B")]
		[Address(RVA = "0x3E128E4", Offset = "0x3E0E8E4", VA = "0x3E128E4")]
		public void TriggerOldCardUpgradeTutor()
		{
		}

		[Token(Token = "0x600153C")]
		[Address(RVA = "0x3E12DFC", Offset = "0x3E0EDFC", VA = "0x3E12DFC")]
		[AsyncStateMachine(typeof(_003CTriggerBeginTrainingGroundTutor_003Ed__44))]
		public UniTask TriggerBeginTrainingGroundTutor()
		{
			return default;
		}

		[Token(Token = "0x600153D")]
		[Address(RVA = "0x3E04A3C", Offset = "0x3E00A3C", VA = "0x3E04A3C")]
		public void StartTrainingGame()
		{
		}

		[Token(Token = "0x600153E")]
		[Address(RVA = "0x3E12E8C", Offset = "0x3E0EE8C", VA = "0x3E12E8C")]
		[AsyncStateMachine(typeof(_003CStartNewPathTimeTutorialTimer_003Ed__46))]
		private UniTaskVoid StartNewPathTimeTutorialTimer()
		{
			return default;
		}

		[Token(Token = "0x600153F")]
		[Address(RVA = "0x3E12F04", Offset = "0x3E0EF04", VA = "0x3E12F04")]
		private void CheckAndTriggerNewPathTimeTutorial()
		{
		}

		[Token(Token = "0x6001540")]
		[Address(RVA = "0x3E13254", Offset = "0x3E0F254", VA = "0x3E13254")]
		private void OnPlayerCoinChangeForNewPathTutorial(object coinObj)
		{
		}

		[Token(Token = "0x6001541")]
		[Address(RVA = "0x3E13618", Offset = "0x3E0F618", VA = "0x3E13618")]
		public bool TryGetNextEnemyFlipPos(out Vector3 pos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TrainingGroundManager.TryGetNextEnemyFlipPos RVA=0x3E13618 Token=0x6001541");
}

		[Token(Token = "0x6001542")]
		[Address(RVA = "0x3E136B0", Offset = "0x3E0F6B0", VA = "0x3E136B0")]
		public bool TryGetNextEnemyFlipInterval(out float interval)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TrainingGroundManager.TryGetNextEnemyFlipInterval RVA=0x3E136B0 Token=0x6001542");
}

		[Token(Token = "0x6001543")]
		[Address(RVA = "0x3E119A0", Offset = "0x3E0D9A0", VA = "0x3E119A0")]
		private string GetHexKey(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6001544")]
		[Address(RVA = "0x3E04BE4", Offset = "0x3E00BE4", VA = "0x3E04BE4")]
		public List<string> GetFixedEnemyCardDeck()
		{
			return null;
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x3E04D4C", Offset = "0x3E00D4C", VA = "0x3E04D4C")]
		public int GetFixedEnemyDifficultLevel()
		{
			return default;
		}

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x3E13740", Offset = "0x3E0F740", VA = "0x3E13740")]
		public int GetPlayerInitialCoin()
		{
			return default;
		}

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x3E1377C", Offset = "0x3E0F77C", VA = "0x3E1377C")]
		public int GetEnemyInitialCoin()
		{
			return default;
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x3E137B8", Offset = "0x3E0F7B8", VA = "0x3E137B8")]
		public MapType? GetTrainingMapShape()
		{
			return null;
		}

		[Token(Token = "0x6001549")]
		[Address(RVA = "0x3E138A4", Offset = "0x3E0F8A4", VA = "0x3E138A4")]
		public TrainingGroundManager()
		{
		}
	}
}
