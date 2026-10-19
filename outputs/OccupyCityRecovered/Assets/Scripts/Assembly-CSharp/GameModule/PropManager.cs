using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000302")]
	public class PropManager : ManagerBase<PropManager>
	{
		[Token(Token = "0x2000303")]
		public enum PropAttrType
		{
			[Token(Token = "0x400232B")]
			None = 0,
			[Token(Token = "0x400232C")]
			SoliderAttack = 1,
			[Token(Token = "0x400232D")]
			SoliderHp = 2,
			[Token(Token = "0x400232E")]
			SoliderAttackSpeed = 3,
			[Token(Token = "0x400232F")]
			SoliderMoveSpeed = 4,
			[Token(Token = "0x4002330")]
			BuildingHp = 5,
			[Token(Token = "0x4002331")]
			BuildingSpawnEfficiency = 6,
			[Token(Token = "0x4002332")]
			BuildingAttack = 7
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030B")]
		[CompilerGenerated]
		private struct _003CGetPropAttrIcon_003Ed__127 : IAsyncStateMachine
		{
			[Token(Token = "0x4002342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4002344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropManager _003C_003E4__this;

			[Token(Token = "0x4002345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropAttrType type;

			[Token(Token = "0x4002346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x3D642EC", Offset = "0x3D602EC", VA = "0x3D642EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x3D6471C", Offset = "0x3D6071C", VA = "0x3D6471C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x4002347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropManager _003C_003E4__this;

			[Token(Token = "0x400234A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0x3D64774", Offset = "0x3D60774", VA = "0x3D64774", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x3D659F0", Offset = "0x3D619F0", VA = "0x3D659F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030D")]
		[CompilerGenerated]
		private struct _003CShowPropUseAnim_003Ed__76 : IAsyncStateMachine
		{
			[Token(Token = "0x400234B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400234C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400234D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string propID;

			[Token(Token = "0x400234E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0x3D659FC", Offset = "0x3D619FC", VA = "0x3D659FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x3D65D18", Offset = "0x3D61D18", VA = "0x3D65D18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030E")]
		[CompilerGenerated]
		private struct _003CShowSpecialSummonPanel_003Ed__106 : IAsyncStateMachine
		{
			[Token(Token = "0x400234F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x3D65D24", Offset = "0x3D61D24", VA = "0x3D65D24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x3D66150", Offset = "0x3D62150", VA = "0x3D66150", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200030F")]
		[CompilerGenerated]
		private struct _003CShowSummonPanel_003Ed__105 : IAsyncStateMachine
		{
			[Token(Token = "0x4002352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x3D6615C", Offset = "0x3D6215C", VA = "0x3D6615C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DE9")]
			[Address(RVA = "0x3D66558", Offset = "0x3D62558", VA = "0x3D66558", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000310")]
		[CompilerGenerated]
		private struct _003CStartGame_003Ed__73 : IAsyncStateMachine
		{
			[Token(Token = "0x4002355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PropManager _003C_003E4__this;

			[Token(Token = "0x4002358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CenemyPropId_003E5__2;

			[Token(Token = "0x4002359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DEA")]
			[Address(RVA = "0x3D66564", Offset = "0x3D62564", VA = "0x3D66564", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DEB")]
			[Address(RVA = "0x3D668EC", Offset = "0x3D628EC", VA = "0x3D668EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000311")]
		[CompilerGenerated]
		private struct _003CUpdateCardBG_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x400235A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400235B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x400235C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RareLevel rare;

			[Token(Token = "0x400235D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x3D668F8", Offset = "0x3D628F8", VA = "0x3D668F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x3D67298", Offset = "0x3D63298", VA = "0x3D67298", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002303")]
		private const string NormalSummonDailyLimitSaveKey = "NormalSummonDailyLimit_SaveData";

		[Token(Token = "0x4002304")]
		private const int MaxDailyNormalSummonTimes = 50;

		[Token(Token = "0x4002305")]
		private const string SpecialSummonDailyLimitSaveKey = "SpecialSummonDailyLimit_SaveData";

		[Token(Token = "0x4002306")]
		private const int MaxDailySpecialSummonTimes = 50;

		[Token(Token = "0x4002307")]
		private const string ArtifactForgeDailyLimitSaveKey = "ArtifactForgeDailyLimit_SaveData";

		[Token(Token = "0x4002308")]
		private const int MaxDailyArtifactForgeTimes = 50;

		[Token(Token = "0x4002309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NormalSummonDailyLimitData _normalSummonDailyLimitData;

		[Token(Token = "0x400230A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _normalSummonDailyLimitDataLoaded;

		[Token(Token = "0x400230B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpecialSummonDailyLimitData _specialSummonDailyLimitData;

		[Token(Token = "0x400230C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _specialSummonDailyLimitDataLoaded;

		[Token(Token = "0x400230D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ArtifactForgeDailyLimitData _artifactForgeDailyLimitData;

		[Token(Token = "0x400230E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _artifactForgeDailyLimitDataLoaded;

		[Token(Token = "0x400230F")]
		public const int LimitedSummonCustomPropChangeDiamondCost = 100;

		[Token(Token = "0x4002310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool freeSummon;

		[Token(Token = "0x4002311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly int[] flipChargeThresholds;

		[Token(Token = "0x4002313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, PropBase> _propPlayerBases;

		[Token(Token = "0x4002314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, PropBase> _propEnemyBases;

		[Token(Token = "0x4002315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<PropBase> _tempPlayerBases;

		[Token(Token = "0x4002316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<PropBase> _tempEnemyBases;

		[Token(Token = "0x4002317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Func<string, PropBase>> _propCreators;

		[Token(Token = "0x4002318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<RareLevel, string[]> propAllRareId;

		[Token(Token = "0x4002319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool enemyUsed;

		[Token(Token = "0x400231A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool playerUsed;

		[Token(Token = "0x400231B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool _redDotSystemInitialized;

		[Token(Token = "0x400231C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		private bool _crystalResourceListenerRegistered;

		[Token(Token = "0x400231D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<string> _onCrystalResourceChangedForRedDot;

		[Token(Token = "0x400231E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x400231F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _artifactsFeatureUnlocked;

		[Token(Token = "0x4002320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _artifactsFeatureUnlockCacheInitialized;

		[Token(Token = "0x4002321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TimeManager.Timer lotteryTimer;

		[Token(Token = "0x4002322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool adSummonRefreshEnd;

		[Token(Token = "0x4002323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _lastAdSummonButtonAvailable;

		[Token(Token = "0x4002324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool _lastAdSummonButtonAvailableInitialized;

		[Token(Token = "0x4002325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int[] TraitUnlockLevels;

		[Token(Token = "0x4002326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly Dictionary<PropAttrType, string> _propAttrNameDict;

		[Token(Token = "0x4002327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly Dictionary<PropAttrType, string> _propAttrIconPathDict;

		[Token(Token = "0x4002328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly Dictionary<PropAttrType, float> _playerPropAttrDict;

		[Token(Token = "0x4002329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private PropAttrSnapshot _playerPropAttrSnapshot;

		[Token(Token = "0x170000DF")]
		public IReadOnlyList<int> FlipChargeThresholds
		{
			[Token(Token = "0x6000D63")]
			[Address(RVA = "0x3D5C314", Offset = "0x3D58314", VA = "0x3D5C314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public Vector3 LastPlayerPropReleaseWorldPos
		{
			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x3D5C31C", Offset = "0x3D5831C", VA = "0x3D5C31C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x3D5C328", Offset = "0x3D58328", VA = "0x3D5C328")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public int PlayerPropCount
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x3D51B30", Offset = "0x3D4DB30", VA = "0x3D51B30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E2")]
		public int EnemyPropCount
		{
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x3D51AE8", Offset = "0x3D4DAE8", VA = "0x3D51AE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E3")]
		public bool playerHasNecroBook
		{
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x3D5C340", Offset = "0x3D58340", VA = "0x3D5C340")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E4")]
		public bool enemyHasNecroBook
		{
			[Token(Token = "0x6000D6A")]
			[Address(RVA = "0x3D5C3A8", Offset = "0x3D583A8", VA = "0x3D5C3A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E5")]
		public int MaxDailyNormalSummonCount
		{
			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x3D5C4B8", Offset = "0x3D584B8", VA = "0x3D5C4B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E6")]
		public int MaxDailySpecialSummonCount
		{
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x3D5C790", Offset = "0x3D58790", VA = "0x3D5C790")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E7")]
		public int MaxDailyArtifactForgeCount
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x3D5CA68", Offset = "0x3D58A68", VA = "0x3D5CA68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x3D5C334", Offset = "0x3D58334", VA = "0x3D5C334")]
		public void SetLastPlayerPropReleaseWorldPos(Vector3 worldPos)
		{
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x3D5C410", Offset = "0x3D58410", VA = "0x3D5C410")]
		public bool TryGetEnemyPropRuntimeValues(string propId, out float configNum1, out float configNum2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PropManager.TryGetEnemyPropRuntimeValues RVA=0x3D5C410 Token=0x6000D6B");
}

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x3D5C4C0", Offset = "0x3D584C0", VA = "0x3D5C4C0")]
		public int GetRemainingNormalSummonCount()
		{
			return default;
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x3D5C648", Offset = "0x3D58648", VA = "0x3D5C648")]
		public bool TryConsumeNormalSummonCount(int summonCount)
		{
			return default;
		}

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x3D5C798", Offset = "0x3D58798", VA = "0x3D5C798")]
		public int GetRemainingSpecialSummonCount()
		{
			return default;
		}

		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x3D5C920", Offset = "0x3D58920", VA = "0x3D5C920")]
		public bool TryConsumeSpecialSummonCount(int summonCount)
		{
			return default;
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x3D5CA70", Offset = "0x3D58A70", VA = "0x3D5CA70")]
		public int GetRemainingArtifactForgeCount()
		{
			return default;
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x3D5CBF8", Offset = "0x3D58BF8", VA = "0x3D5CBF8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__54))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x3D5CC90", Offset = "0x3D58C90", VA = "0x3D5CC90")]
		private void CheckEquipPropTutorial(object o)
		{
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x3D5CED4", Offset = "0x3D58ED4", VA = "0x3D5CED4")]
		private bool IsArtifactsFeatureUnlocked()
		{
			return default;
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x3D5CEF8", Offset = "0x3D58EF8", VA = "0x3D5CEF8")]
		private void RefreshArtifactsFeatureUnlockCache()
		{
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x3D5CFD8", Offset = "0x3D58FD8", VA = "0x3D5CFD8")]
		private void OnArtifactsFeatureUnlocked(object obj)
		{
		}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x3D5D058", Offset = "0x3D59058", VA = "0x3D5D058")]
		public bool IsAdSummonButtonAvailable()
		{
			return default;
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x3D5D110", Offset = "0x3D59110", VA = "0x3D5D110")]
		private void RefreshShopArtifactFreeSummonRedDot()
		{
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x3D5D190", Offset = "0x3D59190", VA = "0x3D5D190")]
		public void RefreshLimitedSummonGiftFreeRedDot()
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x3D5D20C", Offset = "0x3D5920C", VA = "0x3D5D20C")]
		private void OnAdSummonCooldownStarted(object o)
		{
		}

		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x3D5D230", Offset = "0x3D59230", VA = "0x3D5D230")]
		private void OnArtifactDataChangedForRedDot(object obj)
		{
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x3D5D238", Offset = "0x3D59238", VA = "0x3D5D238")]
		private void RegisterCrystalResourceChangeForRedDot()
		{
		}

		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x3D5D30C", Offset = "0x3D5930C", VA = "0x3D5D30C")]
		private void OnCrystalResourceChangedForRedDot(string count)
		{
		}

		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x3D5D030", Offset = "0x3D59030", VA = "0x3D5D030")]
		private void RequestRefreshRedDot(bool immediate = false)
		{
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x3D5D314", Offset = "0x3D59314", VA = "0x3D5D314")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x3D5D560", Offset = "0x3D59560", VA = "0x3D5D560")]
		private void GameEnd(object o)
		{
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x3D506F0", Offset = "0x3D4C6F0", VA = "0x3D506F0")]
		public void RemovePropRecordPlayer(PropBase prop)
		{
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x3D50660", Offset = "0x3D4C660", VA = "0x3D50660")]
		public void RemovePropRecordEnemy(PropBase prop)
		{
		}

		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x3D5D5FC", Offset = "0x3D595FC", VA = "0x3D5D5FC")]
		[AsyncStateMachine(typeof(_003CStartGame_003Ed__73))]
		public void StartGame()
		{
		}

		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x3D5D688", Offset = "0x3D59688", VA = "0x3D5D688")]
		public void EnemyTriggerProp(string propID, [Optional] Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x3D5DB3C", Offset = "0x3D59B3C", VA = "0x3D5DB3C")]
		public void PlayerTriggerProp(string propID)
		{
		}

		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x3D5DAAC", Offset = "0x3D59AAC", VA = "0x3D5DAAC")]
		[AsyncStateMachine(typeof(_003CShowPropUseAnim_003Ed__76))]
		private void ShowPropUseAnim(string propID)
		{
		}

		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x3D5D988", Offset = "0x3D59988", VA = "0x3D5D988")]
		private PropBase CreateProp(string id, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x3D5DE18", Offset = "0x3D59E18", VA = "0x3D5DE18")]
		public UserPropData GetPropData(string id)
		{
			return null;
		}

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x3D5DF40", Offset = "0x3D59F40", VA = "0x3D5DF40")]
		public float GetEquippedArtifactTraitPercent(CardFettersType fettersType, ArtifactTraitAttrType attrType)
		{
			return default;
		}

		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x3D5E214", Offset = "0x3D5A214", VA = "0x3D5E214")]
		private static bool UseZeroBasedCardGrouping(IReadOnlyList<GlobalArtifactsForgeInfo> forgeInfoList)
		{
			return default;
		}

		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x3D5E464", Offset = "0x3D5A464", VA = "0x3D5E464")]
		private static bool IsTraitCardGroupingMatched(int cardGrouping, int fettersTypeValue, bool useZeroBasedCardGrouping)
		{
			return default;
		}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x3D5E47C", Offset = "0x3D5A47C", VA = "0x3D5E47C")]
		public bool IsPropSSSR(string propId)
		{
			return default;
		}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x3D5E550", Offset = "0x3D5A550", VA = "0x3D5E550")]
		public void Lottery([Optional][DefaultParameterValue(10)] int num, [Optional] string customPropId, bool isTenSummon = false, int summonUnitCost = 5, int summonBaseCount = 10)
		{
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x3D5F54C", Offset = "0x3D5B54C", VA = "0x3D5F54C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x3D5F5E4", Offset = "0x3D5B5E4", VA = "0x3D5F5E4")]
		[AsyncStateMachine(typeof(_003CUpdateCardBG_003Ed__89))]
		public UniTask<Sprite> UpdateCardBG(RareLevel rare)
		{
			return default;
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x3D5F6C4", Offset = "0x3D5B6C4", VA = "0x3D5F6C4")]
		public void GetPropReward(List<UserPropData> propList)
		{
		}

		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x3D5E3B8", Offset = "0x3D5A3B8", VA = "0x3D5E3B8")]
		public GlobalArtifactsForgeInfo GetArtifactTraitConfig(string traitId)
		{
			return null;
		}

		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x3D5FCFC", Offset = "0x3D5BCFC", VA = "0x3D5FCFC")]
		public string GetArtifactTraitDes(string traitId)
		{
			return null;
		}

		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x3D5FE60", Offset = "0x3D5BE60", VA = "0x3D5FE60")]
		public string GetPropDes(GlobalPropInfo propInfo, int level, int starLevel = 0, PropDesHint hint = PropDesHint.None)
		{
			return null;
		}

		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x3D60B00", Offset = "0x3D5CB00", VA = "0x3D60B00")]
		public string GetNewPropDes(GlobalPropInfo propInfo, int level)
		{
			return null;
		}

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x3D60F28", Offset = "0x3D5CF28", VA = "0x3D60F28")]
		public void EquipArtifact(UserPropData artifact)
		{
		}

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x3D61288", Offset = "0x3D5D288", VA = "0x3D61288")]
		public bool ArtifactUpgrade(UserPropData artifact)
		{
			return default;
		}

		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x3D617C8", Offset = "0x3D5D7C8", VA = "0x3D617C8")]
		public bool ArtifactUpgradeStar(UserPropData artifact)
		{
			return default;
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x3D615C4", Offset = "0x3D5D5C4", VA = "0x3D615C4")]
		private void TryAutoAssignTraitOnLevelUp(UserPropData artifact)
		{
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x3D61C2C", Offset = "0x3D5DC2C", VA = "0x3D61C2C")]
		public bool ReplaceArtifactTrait(UserPropData data, string oldTraitId, string newTraitId)
		{
			return default;
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x3D619A4", Offset = "0x3D5D9A4", VA = "0x3D619A4")]
		public GlobalArtifactsForgeInfo GetRandomArtifactTrait(int level, [Optional] string excludeTraitId)
		{
			return null;
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x3D61E48", Offset = "0x3D5DE48", VA = "0x3D61E48")]
		public bool ForgeArtifactTrait(int forgingLevel, out string newTraitId, [Optional] string excludeTraitId)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PropManager.ForgeArtifactTrait RVA=0x3D61E48 Token=0x6000D9D");
}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x3D62104", Offset = "0x3D5E104", VA = "0x3D62104")]
		public bool SaveArtifactTrait(UserPropData data, string oldTraitId, string newTraitId)
		{
			return default;
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x3D6115C", Offset = "0x3D5D15C", VA = "0x3D6115C")]
		private static UserPropData ResolveActiveArtifactData(UserPropData artifact)
		{
			return null;
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x3D622DC", Offset = "0x3D5E2DC", VA = "0x3D622DC")]
		[AsyncStateMachine(typeof(_003CShowSummonPanel_003Ed__105))]
		public void ShowSummonPanel()
		{
		}

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x3D62364", Offset = "0x3D5E364", VA = "0x3D62364")]
		[AsyncStateMachine(typeof(_003CShowSpecialSummonPanel_003Ed__106))]
		public void ShowSpecialSummonPanel()
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x3D623EC", Offset = "0x3D5E3EC", VA = "0x3D623EC")]
		public void RestartAdSummonTimer()
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x3D5D0A8", Offset = "0x3D590A8", VA = "0x3D5D0A8")]
		public TimeManager.Timer GetAdSummonTimer()
		{
			return null;
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x3D5C4F0", Offset = "0x3D584F0", VA = "0x3D5C4F0")]
		private void EnsureNormalSummonDailyLimitData()
		{
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x3D5C6AC", Offset = "0x3D586AC", VA = "0x3D5C6AC")]
		private void SaveNormalSummonDailyLimitData()
		{
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x3D5C7C8", Offset = "0x3D587C8", VA = "0x3D5C7C8")]
		private void EnsureSpecialSummonDailyLimitData()
		{
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x3D5C984", Offset = "0x3D58984", VA = "0x3D5C984")]
		private void SaveSpecialSummonDailyLimitData()
		{
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x3D5CAA0", Offset = "0x3D58AA0", VA = "0x3D5CAA0")]
		private void EnsureArtifactForgeDailyLimitData()
		{
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x3D62020", Offset = "0x3D5E020", VA = "0x3D62020")]
		private void SaveArtifactForgeDailyLimitData()
		{
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x3D62484", Offset = "0x3D5E484", VA = "0x3D62484")]
		private string GetSummonDailyDateKey()
		{
			return null;
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x3D625CC", Offset = "0x3D5E5CC", VA = "0x3D625CC")]
		public string GetPropRareColor(RareLevel rareLevel)
		{
			return null;
		}

		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x3D62658", Offset = "0x3D5E658", VA = "0x3D62658")]
		public PropAttrSnapshot GetPlayerPropAttrSnapshot()
		{
			return null;
		}

		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x3D62660", Offset = "0x3D5E660", VA = "0x3D62660")]
		private void RefreshPlayerPropAttrSnapshot()
		{
		}

		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x3D626C4", Offset = "0x3D5E6C4", VA = "0x3D626C4")]
		public float GetPlayerPropAttr(PropAttrType type)
		{
			return default;
		}

		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x3D62740", Offset = "0x3D5E740", VA = "0x3D62740")]
		public IReadOnlyDictionary<PropAttrType, float> GetPlayerPropAttrDictReadOnly()
		{
			return null;
		}

		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x3D62748", Offset = "0x3D5E748", VA = "0x3D62748")]
		public string GetPropAttrName(PropAttrType type)
		{
			return null;
		}

		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x3D627D8", Offset = "0x3D5E7D8", VA = "0x3D627D8")]
		[AsyncStateMachine(typeof(_003CGetPropAttrIcon_003Ed__127))]
		public UniTask<Sprite> GetPropAttrIcon(PropAttrType type)
		{
			return default;
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x3D5A39C", Offset = "0x3D5639C", VA = "0x3D5A39C")]
		public Dictionary<PropAttrType, float> CalculatePropAttr(string propId, int level, int starLevel)
		{
			return null;
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x3D5F8E4", Offset = "0x3D5B8E4", VA = "0x3D5F8E4")]
		public void ReCalculatePlayerAllPropsAttr()
		{
		}

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x3D628C4", Offset = "0x3D5E8C4", VA = "0x3D628C4")]
		public PropManager()
		{
		}
	}
}
