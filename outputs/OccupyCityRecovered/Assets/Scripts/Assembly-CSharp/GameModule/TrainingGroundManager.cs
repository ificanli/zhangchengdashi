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

		[Token(Token = "0x4002A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static bool _003CIsCurrentTrainingGame_003Ek__BackingField;

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
			{ return !global::DbtSaveDataManager_PlayerGuideData.I.Data.isTrainingComplete; }
		}

		[Token(Token = "0x1700013F")]
		public static bool IsInTrainingGround
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x3E102CC", Offset = "0x3E0C2CC", VA = "0x3E102CC")]
			get
			{
                return global::SDKModule.ABTestManager.Instance.NewbieTutorialIsBTest && IsInGuidedGame;
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
			return _003CIsCurrentTrainingGame_003Ek__BackingField;
		}
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x3E103A0", Offset = "0x3E0C3A0", VA = "0x3E103A0")]
			[CompilerGenerated]
			set
			{
			_003CIsCurrentTrainingGame_003Ek__BackingField = value;
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
            global::DbtSaveDataManager_PlayerGuideData guideManager = global::DbtSaveDataManager_PlayerGuideData.I;
            if ((object)guideManager == null) throw new global::System.NullReferenceException();
            global::DbtSaveDataManager_PlayerCoreData coreManager = global::DbtSaveDataManager_PlayerCoreData.I;
            if ((object)coreManager == null) throw new global::System.NullReferenceException();
            if (guideManager.Data.isTrainingComplete) return false;
            return coreManager.Data.PlayerGameCount == 0;
        }

		[Token(Token = "0x6001531")]
		[Address(RVA = "0x3E04844", Offset = "0x3E00844", VA = "0x3E04844")]
		public GlobalTrainingMapInfo GetCurrentTrainingConfig()
		{
            if (!IsInGuidedGame) return null;
            int mapIndex = unchecked(global::DbtSaveDataManager_PlayerGuideData.I.Data.trainingGameIndex + 1);
            int mapCount = DataManager.Instance.GlobalInfo.trainingMapInfos != null
                ? DataManager.Instance.GlobalInfo.trainingMapInfos.Count : 3;
            if (mapIndex < 1 || mapIndex > mapCount) mapIndex = 1;
            string mapId = mapIndex.ToString();
            if (_currentTrainingConfig != null && _currentTrainingConfig.id == mapId) return _currentTrainingConfig;
            if (DataManager.Instance.GlobalInfo.trainingMapInfoDic != null
                && DataManager.Instance.GlobalInfo.trainingMapInfoDic.ContainsKey(mapId))
            {
                _currentTrainingConfig = DataManager.Instance.GlobalInfo.trainingMapInfoDic[mapId];
                ParseHexConfigs(_currentTrainingConfig);
                ParseEnemyFlipConfigs(_currentTrainingConfig);
                ParseDragonKnightConfig(_currentTrainingConfig);
                return _currentTrainingConfig;
            }
            return null;
        }

		[Token(Token = "0x6001532")]
		[Address(RVA = "0x3E11094", Offset = "0x3E0D094", VA = "0x3E11094")]
		private void ParseHexConfigs(GlobalTrainingMapInfo config)
		{
            _currentHexConfigs = new Dictionary<string, TrainingHexConfig>();
            if (string.IsNullOrEmpty(config.hexConfigs)) return;
            foreach (string entry in config.hexConfigs.Split(';'))
            {
                if (string.IsNullOrEmpty(entry)) continue;
                string[] fields = entry.Split(':');
                if (fields.Length < 3) continue;
                string[] coords = fields[0].Split(',');
                if (coords.Length != 3) continue;
                Vector3 position = new Vector3(coords[0].ToFloat(), coords[1].ToFloat(), coords[2].ToFloat());
                HexType parsedType;
                HexType type = global::System.Enum.TryParse<HexType>(fields[1], true, out parsedType) ? parsedType : default(HexType);
                Quality parsedQuality;
                Quality quality = global::System.Enum.TryParse<Quality>(fields[2], true, out parsedQuality) ? parsedQuality : default(Quality);
                string cardId = fields.Length >= 4 && !string.IsNullOrEmpty(fields[3]) ? fields[3] : null;
                string endEventId = fields.Length >= 5 && !string.IsNullOrEmpty(fields[4]) ? fields[4] : null;
                TrainingHexConfig hexConfig = new TrainingHexConfig(position, type, quality, cardId, endEventId);
                _currentHexConfigs[GetHexKey(position)] = hexConfig;
            }
        }

		[Token(Token = "0x6001533")]
		[Address(RVA = "0x3E11404", Offset = "0x3E0D404", VA = "0x3E11404")]
		private void ParseEnemyFlipConfigs(GlobalTrainingMapInfo config)
		{
            _enemyFlipSeq = null;
            _enemyFlipIntervals = null;
            _enemyFlipIndex = 0;
            _enemyFlipIntervalIndex = 0;
            if (!string.IsNullOrEmpty(config.enemyFlipHexSeq))
            {
                _enemyFlipSeq = new List<Vector3>();
                foreach (string entry in config.enemyFlipHexSeq.Split(';'))
                {
                    if (string.IsNullOrEmpty(entry)) continue;
                    string[] coords = entry.Split(',');
                    if (coords.Length != 3) continue;
                    _enemyFlipSeq.Add(new Vector3(coords[0].ToFloat(), coords[1].ToFloat(), coords[2].ToFloat()));
                }
            }
            if (string.IsNullOrEmpty(config.enemyFlipIntervals)) return;
            _enemyFlipIntervals = new List<float>();
            foreach (string entry in config.enemyFlipIntervals.Split(','))
            {
                if (!string.IsNullOrEmpty(entry)) _enemyFlipIntervals.Add(entry.ToFloat());
            }
        }

		[Token(Token = "0x6001534")]
		[Address(RVA = "0x3E1173C", Offset = "0x3E0D73C", VA = "0x3E1173C")]
		private void ParseDragonKnightConfig(GlobalTrainingMapInfo config)
		{
            _forceDragonKnightEnabled = false;
            _forceDragonKnightHasCoords = false;
            _forceDragonKnightHexKeys = null;
            if (config == null || string.IsNullOrEmpty(config.dragonKnightConfig)) return;
            string value = config.dragonKnightConfig.Trim();
            if (string.IsNullOrEmpty(value) || !value.StartsWith("TRUE", global::System.StringComparison.OrdinalIgnoreCase)) return;
            _forceDragonKnightEnabled = true;
            if (value.Length < 5 || value[4] != ':') return;
            string positions = value.Substring(5);
            if (string.IsNullOrEmpty(positions)) return;
            _forceDragonKnightHasCoords = true;
            _forceDragonKnightHexKeys = new HashSet<string>();
            foreach (string entry in positions.Split(';'))
            {
                if (string.IsNullOrEmpty(entry)) continue;
                string[] coords = entry.Split(',');
                if (coords.Length != 3) continue;
                Vector3 position = new Vector3(coords[0].ToFloat(), coords[1].ToFloat(), coords[2].ToFloat());
                _forceDragonKnightHexKeys.Add(GetHexKey(position));
            }
        }

		[Token(Token = "0x6001535")]
		[Address(RVA = "0x3E11CF0", Offset = "0x3E0DCF0", VA = "0x3E11CF0")]
		public bool ShouldForceDragonKnightForHex(Vector3 position)
		{
            if (!IsInGuidedGame || !_forceDragonKnightEnabled) return false;
            if (!_forceDragonKnightHasCoords) return true;
            if (_forceDragonKnightHexKeys == null || _forceDragonKnightHexKeys.Count == 0) return false;
            return _forceDragonKnightHexKeys.Contains(GetHexKey(new Vector3(position.x, 0f, position.z)));
        }

		[Token(Token = "0x6001536")]
		[Address(RVA = "0x3E11DB8", Offset = "0x3E0DDB8", VA = "0x3E11DB8")]
		public TrainingHexConfig GetFixedHexConfig(Vector3 position)
		{
            if (_currentHexConfigs == null) return null;
            TrainingHexConfig config;
            return _currentHexConfigs.TryGetValue(GetHexKey(position), out config) ? config : null;
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
            _forceDragonKnightEnabled = false;
            _forceDragonKnightHasCoords = false;
            _currentHexConfigs = null;
            _currentTrainingConfig = null;
            _enemyFlipIndex = 0;
            _forceDragonKnightHexKeys = null;
            _enemyFlipSeq = null;
            _enemyFlipIntervals = null;
            _enemyFlipIntervalIndex = 0;
            _hasRegisteredNewTutorialCoinTutorial = false;
            _hasRegisteredNewTutorialTimeTutorial = false;
            _shouldContinueNewTutorialTimeTutorial = false;
            _hasRegisteredNewTutorialEnemyFlipTutorial_19008 = false;
            _shouldContinueNewTutorialEnemyFlipTutorial_19008 = false;
            _pendingNewTutorialEnemyFlipReward_19008 = false;
            IsCurrentTrainingGame = true;
            if (IsInGuidedGame && global::SDKModule.ABTestManager.Instance.NewbieTutorialIsBTest
                && global::DbtSaveDataManager_PlayerGuideData.I.Data.trainingGameIndex == 1)
            {
                _shouldContinueNewTutorialTimeTutorial = true;
                StartNewPathTimeTutorialTimer().Forget();
            }
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
            pos = default(Vector3);
            if (_enemyFlipSeq == null || _enemyFlipSeq.Count == 0 || _enemyFlipIndex >= _enemyFlipSeq.Count) return false;
            pos = _enemyFlipSeq[_enemyFlipIndex++];
            return true;
        }

		[Token(Token = "0x6001542")]
		[Address(RVA = "0x3E136B0", Offset = "0x3E0F6B0", VA = "0x3E136B0")]
		public bool TryGetNextEnemyFlipInterval(out float interval)
		{
            interval = 0f;
            if (_enemyFlipIntervals == null || _enemyFlipIntervals.Count == 0 || _enemyFlipIntervalIndex >= _enemyFlipIntervals.Count) return false;
            interval = _enemyFlipIntervals[_enemyFlipIntervalIndex++];
            return true;
        }

		[Token(Token = "0x6001543")]
		[Address(RVA = "0x3E119A0", Offset = "0x3E0D9A0", VA = "0x3E119A0")]
		private string GetHexKey(Vector3 ori)
		{
            float x = 0f;
            if (!(global::System.Math.Abs(ori.x) < 0.000001f))
            {
                float scaled = ori.x * 100f;
                double whole = global::System.Math.Truncate((double)scaled);
                double fraction = (double)scaled - whole;
                float rounded;
                if (fraction == 0.5d || fraction == -0.5d)
                {
                    rounded = (float)whole;
                    if (((long)whole & 1L) != 0L) rounded = rounded + (scaled >= 0f ? 1f : -1f);
                }
                else rounded = scaled >= 0f
                    ? (float)global::System.Math.Floor((double)(scaled + 0.5f))
                    : (float)global::System.Math.Ceiling((double)(scaled - 0.5f));
                x = rounded / 100f;
            }
            float y = 0f;
            if (!(global::System.Math.Abs(ori.y) < 0.000001f))
            {
                float scaled = ori.y * 100f;
                double whole = global::System.Math.Truncate((double)scaled);
                double fraction = (double)scaled - whole;
                float rounded;
                if (fraction == 0.5d || fraction == -0.5d)
                {
                    rounded = (float)whole;
                    if (((long)whole & 1L) != 0L) rounded = rounded + (scaled >= 0f ? 1f : -1f);
                }
                else rounded = scaled >= 0f
                    ? (float)global::System.Math.Floor((double)(scaled + 0.5f))
                    : (float)global::System.Math.Ceiling((double)(scaled - 0.5f));
                y = rounded / 100f;
            }
            float z = 0f;
            if (!(global::System.Math.Abs(ori.z) < 0.000001f))
            {
                float scaled = ori.z * 100f;
                double whole = global::System.Math.Truncate((double)scaled);
                double fraction = (double)scaled - whole;
                float rounded;
                if (fraction == 0.5d || fraction == -0.5d)
                {
                    rounded = (float)whole;
                    if (((long)whole & 1L) != 0L) rounded = rounded + (scaled >= 0f ? 1f : -1f);
                }
                else rounded = scaled >= 0f
                    ? (float)global::System.Math.Floor((double)(scaled + 0.5f))
                    : (float)global::System.Math.Ceiling((double)(scaled - 0.5f));
                z = rounded / 100f;
            }
            return string.Concat(new string[] { x.ToString(global::System.Globalization.CultureInfo.InvariantCulture), "_",
                y.ToString(global::System.Globalization.CultureInfo.InvariantCulture), "_",
                z.ToString(global::System.Globalization.CultureInfo.InvariantCulture) });
        }

		[Token(Token = "0x6001544")]
		[Address(RVA = "0x3E04BE4", Offset = "0x3E00BE4", VA = "0x3E04BE4")]
		public List<string> GetFixedEnemyCardDeck()
		{
            GlobalTrainingMapInfo config = GetCurrentTrainingConfig();
            if (config == null || string.IsNullOrEmpty(config.enemyCardDeck)) return null;
            string[] entries = config.enemyCardDeck.Split(',');
            global::System.Func<string, bool> predicate = _003C_003Ec._003C_003E9__52_0;
            if (predicate == null)
            {
                predicate = new global::System.Func<string, bool>(_003C_003Ec._003C_003E9._003CGetFixedEnemyCardDeck_003Eb__52_0);
                _003C_003Ec._003C_003E9__52_0 = predicate;
            }
            return global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Where(entries, predicate));
        }

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x3E04D4C", Offset = "0x3E00D4C", VA = "0x3E04D4C")]
		public int GetFixedEnemyDifficultLevel()
		{
            GlobalTrainingMapInfo config = GetCurrentTrainingConfig();
            return config != null && !string.IsNullOrEmpty(config.enemyDifficultLevel) ? config.enemyDifficultLevel.ToInt() : 1;
        }

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x3E13740", Offset = "0x3E0F740", VA = "0x3E13740")]
		public int GetPlayerInitialCoin()
		{
            GlobalTrainingMapInfo config = GetCurrentTrainingConfig();
            return config != null && !string.IsNullOrEmpty(config.playerInitialCoin) ? config.playerInitialCoin.ToInt() : 150;
        }

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x3E1377C", Offset = "0x3E0F77C", VA = "0x3E1377C")]
		public int GetEnemyInitialCoin()
		{
            GlobalTrainingMapInfo config = GetCurrentTrainingConfig();
            return config != null && !string.IsNullOrEmpty(config.enemyInitialCoin) ? config.enemyInitialCoin.ToInt() : 50;
        }

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x3E137B8", Offset = "0x3E0F7B8", VA = "0x3E137B8")]
		public MapType? GetTrainingMapShape()
		{
            GlobalTrainingMapInfo config = GetCurrentTrainingConfig();
            if (config == null || string.IsNullOrEmpty(config.mapShape)) return null;
            MapType shape;
            if (!global::System.Enum.TryParse<MapType>(config.mapShape, true, out shape) || unchecked((uint)shape) > 2u) return null;
            return shape;
        }

		[Token(Token = "0x6001549")]
		[Address(RVA = "0x3E138A4", Offset = "0x3E0F8A4", VA = "0x3E138A4")]
		public TrainingGroundManager()
		{
		}
        [Token(Token = "0x200045C")]
        [global::System.Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            [Token(Token = "0x4002A92")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            [Token(Token = "0x4002AA7")]
            [Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
            public static global::System.Func<string, bool> _003C_003E9__52_0;
            [Token(Token = "0x600154E")]
            [Address(RVA = "0x3E155D0", Offset = "0x3E115D0", VA = "0x3E155D0")]
            public _003C_003Ec() { }
            [Token(Token = "0x6001563")]
            [Address(RVA = "0x3E15BC8", Offset = "0x3E11BC8", VA = "0x3E15BC8")]
            internal bool _003CGetFixedEnemyCardDeck_003Eb__52_0(string s)
            {
                return !string.IsNullOrEmpty(s);
            }
        }

	}
}
