using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameModule
{
	[Token(Token = "0x2000424")]
	public class BattleGameSceneManager : ManagerBase<BattleGameSceneManager>
	{
        [Token(Token = "0x200042A")]
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass217_0
        {
            [Token(Token = "0x400299D")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
            public int index;
            [Token(Token = "0x400299E")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
            public BattleGameSceneManager _003C_003E4__this;
            [Token(Token = "0x6001460")]
            [Address(RVA = "0x3DF981C", Offset = "0x3DF581C", VA = "0x3DF981C")]
            public _003C_003Ec__DisplayClass217_0() { }
            [Token(Token = "0x6001461")]
            [Address(RVA = "0x3DF9824", Offset = "0x3DF5824", VA = "0x3DF9824")]
            internal void _003CSettlementAnimation_003Eb__0()
            {
                var self = _003C_003E4__this;
                DG.Tweening.ShortcutExtensions.DOMoveY(self.allHexObj[index].transform, -1f, 0.1f);
                self.allHexObjMat[index].material = AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(false, self.allHexObjBehaviour[index].key, self.isSeasonPVP_BTest);
            }
        }

        [Token(Token = "0x200042B")]
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass217_1
        {
            [Token(Token = "0x400299F")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
            public int index;
            [Token(Token = "0x40029A0")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
            public BattleGameSceneManager _003C_003E4__this;
            [Token(Token = "0x6001462")]
            [Address(RVA = "0x3DF9968", Offset = "0x3DF5968", VA = "0x3DF9968")]
            public _003C_003Ec__DisplayClass217_1() { }
            [Token(Token = "0x6001463")]
            [Address(RVA = "0x3DF9970", Offset = "0x3DF5970", VA = "0x3DF9970")]
            internal void _003CSettlementAnimation_003Eb__1()
            {
                var self = _003C_003E4__this;
                DG.Tweening.ShortcutExtensions.DOMoveY(self.allHexObj[index].transform, -1f, 0.1f);
                self.allHexObjMat[index].material = AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(true, self.allHexObjBehaviour[index].key, self.isSeasonPVP_BTest);
            }
        }

		[Token(Token = "0x2000425")]
		private struct RoleTargetFrameCacheKey : IEquatable<RoleTargetFrameCacheKey>
		{
			[Token(Token = "0x400298B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool sourceIsEnemy;

			[Token(Token = "0x400298C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int q;

			[Token(Token = "0x400298D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int r;

			[Token(Token = "0x400298E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int rangeBucket;

			[Token(Token = "0x6001459")]
			[Address(RVA = "0x3DF9650", Offset = "0x3DF5650", VA = "0x3DF9650")]
			public RoleTargetFrameCacheKey(bool sourceIsEnemy, int q, int r, int rangeBucket)
			{
			this.sourceIsEnemy = sourceIsEnemy;
			this.q = q;
			this.r = r;
			this.rangeBucket = rangeBucket;
		}

			[Token(Token = "0x600145A")]
			[Address(RVA = "0x3DF9664", Offset = "0x3DF5664", VA = "0x3DF9664", Slot = "4")]
			public bool Equals(RoleTargetFrameCacheKey other)
			{
			return sourceIsEnemy == other.sourceIsEnemy && q == other.q && r == other.r && rangeBucket == other.rangeBucket;
		}

			[Token(Token = "0x600145B")]
			[Address(RVA = "0x3DF96AC", Offset = "0x3DF56AC", VA = "0x3DF96AC", Slot = "0")]
			public override bool Equals(object obj)
			{
			return obj is RoleTargetFrameCacheKey && Equals((RoleTargetFrameCacheKey)obj);
		}

			[Token(Token = "0x600145C")]
			[Address(RVA = "0x3DF9758", Offset = "0x3DF5758", VA = "0x3DF9758", Slot = "2")]
			public override int GetHashCode()
			{
			return unchecked((397 * ((397 * ((sourceIsEnemy ? 157609 : 0) ^ q)) ^ r)) ^ rangeBucket);
		}
		}

		[Token(Token = "0x2000426")]
		private struct RoleTargetFrameCacheValue
		{
			[Token(Token = "0x400298F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RoleBehaviour target;
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042C")]
		[CompilerGenerated]
		private struct _003CEndGame_003Ed__223 : IAsyncStateMachine
		{
			[Token(Token = "0x40029A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001464")]
			[Address(RVA = "0x3DF9AB4", Offset = "0x3DF5AB4", VA = "0x3DF9AB4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
            var self = _003C_003E4__this;
            Cysharp.Threading.Tasks.YieldAwaitable.Awaiter awaiter;
            try
            {
                if (_003C_003E1__state == 0)
                {
                    awaiter = _003C_003Eu__1;
                    _003C_003Eu__1 = default;
                    _003C_003E1__state = -1;
                    goto AfterYield;
                }
                RoleShadowManager.Instance.RecycleAll();
                self.ShutdownWebGLNavigationManager();
                if (self._generateHexObjRoot != null)
                {
                    var generator = self._generateHexObjRoot.GetComponent<GenerateHexBehaviour>();
                    if (generator != null) generator.ReleaseReferences();
                }
                global::HexManager.Clear();
                if (self.allHellfireBehaviours.Count >= 1)
                {
                    int i = 0;
                    do
                    {
                        if (self.allHellfireBehaviours[i] != null && self.allHellfireBehaviours[i].gameObject != null)
                            UnityEngine.Object.Destroy(self.allHellfireBehaviours[i].gameObject);
                        i++;
                    }
                    while (i < self.allHellfireBehaviours.Count);
                    self.allHellfireBehaviours.Clear();
                }
                for (int i = 0; i < self.allHexObj.Count; i++) UnityEngine.Object.Destroy(self.allHexObj[i]);
                for (int i = 0; i < self.allPlayerArchitectureObj.Count; i++) UnityEngine.Object.Destroy(self.allPlayerArchitectureObj[i]);
                for (int i = 0; i < self.allEnemyArchitectureObj.Count; i++) UnityEngine.Object.Destroy(self.allEnemyArchitectureObj[i]);
                self.DestroyAllROle();
                if (self._waterPlane != null) UnityEngine.Object.Destroy(self._waterPlane);
                UnityEngine.Object.Destroy(self._groundPlane);
                self.needDestroyPoolPrefabOnEndGame.Clear();
                self._waterPlane = null;
                self._groundPlane = null;
                self.allPlayerStayOpenHexObj.Clear();
                self.allEnemyStayOpenHexObj.Clear();
                self.allHexObj.Clear();
                self.allPlayerHasOpenHexObj.Clear();
                self.allEnemyHasOpenHexObj.Clear();
                self.allPlayerArchitectureObj.Clear();
                self.allEnemyArchitectureObj.Clear();
                self.allPlayerRoleObj.Clear();
                self.allEnemyRoleObj.Clear();
                self._playerComboWallCount = 0;
                self._enemyComboWallCount = 0;
                self.allHexObjBehaviour.Clear();
                self.allHexObjMat.Clear();
                self.allPlayerRoleBehaviour.Clear();
                self.allRoleBehaviour.Clear();
                self.allEnemyRoleBehaviour.Clear();
                self._mirrorMap.Clear();
                self.allEnemyStayOpenHexObjBehaviours.Clear();
                self.allArchitectureBehaviours.Clear();
                self.allPlayerArchitectureBehaviours.Clear();
                self.allEnemyArchitectureBehaviours.Clear();
                self.specialHexPos.Clear();
                self.sceneGoldMineCanCreatCount = 0;
                self.sceneGoldMineMirrorSideCount = 0;
                self.scenePLayerUseGoldMineCount = 0;
                self.sceneEnemyUseGoldMineCount = 0;
                self.playerRoleDebutCount = 0;
                self.playerOpenOneStarCount = 0;
                self.playerOpenTwoStarCount = 0;
                self.playerOpenThereStarCount = 0;
                self.playerOpenUnChartCount = 0;
                global::EventModule.EventManager.Instance.TriggerEvent("UpdateUpgradeMainTowerHexGroundActive");
                global::EventModule.EventManager.Instance.TriggerEvent("UpgradeMainTowerHexSetActive", true);
                awaiter = UniTask.Yield().GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 0;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            AfterYield:
                awaiter.GetResult();
                global::AnimationInstancing.AnimationManager.ClearRuntimeAnimationInfoIfExists();
                global::EventModule.EventManager.Instance.TriggerEvent("UpdateUpgradeMainTowerHexScanState");
                global::EventModule.EventManager.Instance.TriggerEvent("UpdateMainTowerPanelSmallRoleState");
                self._currentRoleInstanceID = 0;
                self.playerMainTowerIsDestroy = false;
                self.enemyMainTowerIsDestroy = false;
                self.playerOpenHexCount = 0;
                self._playerRoleCount = 0;
                self._enemyRoleCount = 0;
                self._playerWaitingBarracks.Clear();
                self._enemyWaitingBarracks.Clear();
                self._playerReservedCount = 0;
                self._enemyReservedCount = 0;
                self._playerLegendaryUnitCount.Clear();
                self._enemyLegendaryUnitCount.Clear();
                self._playerLegendaryBarracksCount.Clear();
                self._enemyLegendaryBarracksCount.Clear();
            }
            catch (global::System.Exception exception)
            {
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetException(exception);
                return;
            }
            _003C_003E1__state = -2;
            _003C_003Et__builder.SetResult();
        }

			[Token(Token = "0x6001465")]
			[Address(RVA = "0x3DFA894", Offset = "0x3DF6894", VA = "0x3DFA894", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
            _003C_003Et__builder.SetStateMachine(stateMachine);
        }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042D")]
		[CompilerGenerated]
		private struct _003CGetRoleTarget_003Ed__175 : IAsyncStateMachine
		{
			[Token(Token = "0x40029A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<List<RoleBehaviour>> _003C_003Et__builder;

			[Token(Token = "0x40029A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform transform;

			[Token(Token = "0x40029A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isEnemy;

			[Token(Token = "0x40029A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int roleNum;

			[Token(Token = "0x40029AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float range;

			[Token(Token = "0x40029AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001466")]
			[Address(RVA = "0x3DFA8A0", Offset = "0x3DF68A0", VA = "0x3DFA8A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001467")]
			[Address(RVA = "0x3DFB26C", Offset = "0x3DF726C", VA = "0x3DFB26C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042E")]
		[CompilerGenerated]
		private struct _003CGetRoleTarget_003Ed__207 : IAsyncStateMachine
		{
			[Token(Token = "0x40029AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<List<GameObject>> _003C_003Et__builder;

			[Token(Token = "0x6001468")]
			[Address(RVA = "0x3DFB2C4", Offset = "0x3DF72C4", VA = "0x3DFB2C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001469")]
			[Address(RVA = "0x3DFB4E8", Offset = "0x3DF74E8", VA = "0x3DFB4E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200042F")]
		[CompilerGenerated]
		private struct _003CHideAllRole_003Ed__214 : IAsyncStateMachine
		{
			[Token(Token = "0x40029AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003Cindex_003E5__2;

			[Token(Token = "0x40029B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146A")]
			[Address(RVA = "0x3DFB540", Offset = "0x3DF7540", VA = "0x3DFB540", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
            var self = _003C_003E4__this;
            int initialState = _003C_003E1__state;
            UniTask.Awaiter awaiter;
            try
            {
                if (initialState == 0)
                {
                    awaiter = _003C_003Eu__1;
                    _003C_003Eu__1 = default;
                    _003C_003E1__state = -1;
                    goto ResumeEnemy;
                }
                if (initialState == 1)
                {
                    awaiter = _003C_003Eu__1;
                    _003C_003Eu__1 = default;
                    _003C_003E1__state = -1;
                    goto ResumePlayer;
                }
                HWGPUInstancerManager.Instance.DestroyCrowdManager();
                RoleShadowManager.Instance.RecycleAll();
                var enumerator = self.allHexObjBehaviour.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        HexBehaviour hex = enumerator.Current;
                        if (hex != null) hex.HideRole();
                    }
                }
                finally
                {
                    if (initialState < 0) enumerator.Dispose();
                }
                _003Cindex_003E5__2 = 0;
            EnemyLoop:
                if (_003Cindex_003E5__2 >= self.allEnemyRoleBehaviour.Count) goto PlayerStart;
                RoleBehaviour enemy = self.allEnemyRoleBehaviour[_003Cindex_003E5__2];
                if (enemy == null) goto EnemyNext;
                enemy.SetAiCanMove(false);
                enemy.gameObject.SetActive(false);
                enemy.RemoveHPUI();
                if (_003Cindex_003E5__2 % 100 != 0) goto EnemyNext;
                awaiter = UniTask.WaitForSeconds(0.05f, false, (PlayerLoopTiming)8).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 0;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            ResumeEnemy:
                awaiter.GetResult();
            EnemyNext:
                _003Cindex_003E5__2 = unchecked(_003Cindex_003E5__2 + 1);
                goto EnemyLoop;
            PlayerStart:
                _003Cindex_003E5__2 = 0;
            PlayerLoop:
                if (_003Cindex_003E5__2 >= self.allPlayerRoleBehaviour.Count) goto Complete;
                RoleBehaviour player = self.allPlayerRoleBehaviour[_003Cindex_003E5__2];
                if (player == null) goto PlayerNext;
                player.SetAiCanMove(false);
                player.gameObject.SetActive(false);
                player.RemoveHPUI();
                if (_003Cindex_003E5__2 % 100 != 0) goto PlayerNext;
                awaiter = UniTask.WaitForSeconds(0.05f, false, (PlayerLoopTiming)8).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 1;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            ResumePlayer:
                awaiter.GetResult();
            PlayerNext:
                _003Cindex_003E5__2 = unchecked(_003Cindex_003E5__2 + 1);
                goto PlayerLoop;
            Complete:;
            }
            catch (global::System.Exception exception)
            {
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetException(exception);
                return;
            }
            _003C_003E1__state = -2;
            _003C_003Et__builder.SetResult();
        }

			[Token(Token = "0x600146B")]
			[Address(RVA = "0x3DFC2B8", Offset = "0x3DF82B8", VA = "0x3DFC2B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
            _003C_003Et__builder.SetStateMachine(stateMachine);
        }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000430")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__129 : IAsyncStateMachine
		{
			[Token(Token = "0x40029B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146C")]
			[Address(RVA = "0x3DFC2C4", Offset = "0x3DF82C4", VA = "0x3DFC2C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600146D")]
			[Address(RVA = "0x3DFCE0C", Offset = "0x3DF8E0C", VA = "0x3DFCE0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000431")]
		[CompilerGenerated]
		private struct _003CLoadMapGround_003Ed__147 : IAsyncStateMachine
		{
			[Token(Token = "0x40029B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameType gameType;

			[Token(Token = "0x40029BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600146E")]
			[Address(RVA = "0x3DFCE18", Offset = "0x3DF8E18", VA = "0x3DFCE18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600146F")]
			[Address(RVA = "0x3DFD304", Offset = "0x3DF9304", VA = "0x3DFD304", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000432")]
		[CompilerGenerated]
		private struct _003CPrewarmBattleRuntimePools_003Ed__143 : IAsyncStateMachine
		{
			[Token(Token = "0x40029BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001470")]
			[Address(RVA = "0x3DFD310", Offset = "0x3DF9310", VA = "0x3DFD310", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001471")]
			[Address(RVA = "0x3DFD320", Offset = "0x3DF9320", VA = "0x3DFD320", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000433")]
		[CompilerGenerated]
		private struct _003CSettlementAnimation_003Ed__217 : IAsyncStateMachine
		{
			[Token(Token = "0x40029BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isVictory;

			[Token(Token = "0x40029C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int _003CbeginIndex_003E5__2;

			[Token(Token = "0x40029C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001472")]
			[Address(RVA = "0x3DFD32C", Offset = "0x3DF932C", VA = "0x3DFD32C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
            var self = _003C_003E4__this;
            UniTask.Awaiter awaiter;
            try
            {
                switch (_003C_003E1__state)
                {
                    case 0:
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                        goto ResumeInitial;
                    case 1:
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                        goto ResumeSlice;
                    case 2:
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                        goto ResumeFinal;
                }
                self.HideAllRole();
                CameraModule.CameraManager.Instance.MainCamera.GetComponent<CameraMoveBehaviour>().DoAnimation(self.sizeNum, self.rotateNum);
                awaiter = UniTask.WaitForSeconds(0.4f, false, (PlayerLoopTiming)8).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 0;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            ResumeInitial:
                awaiter.GetResult();
                UIFramework.UIManager.Instance.HidePanel("Assets/_Res/Addressable/Prefabs/UI/Panels/OutsiderCheatPanel.prefab");
                UIFramework.UIManager.Instance.HidePanel("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/GamePanel.prefab");
                if (GameConfigModule.GameConfigManager.GameGlobalConfig.useNewFloatingText)
                    FloatingTextManager.Instance.CleanAllDamageText();
                for (int i = 0; i < self.allPlayerRoleBehaviour.Count; i++) self.allPlayerRoleBehaviour[i].UIHide();
                for (int i = 0; i < self.allEnemyRoleBehaviour.Count; i++) self.allEnemyRoleBehaviour[i].UIHide();
                for (int i = 0; i < self.allPlayerArchitectureObj.Count; i++) self.allPlayerArchitectureObj[i].GetComponent<ArchitectureBehaviour>().UIHide();
                for (int i = 0; i < self.allEnemyArchitectureObj.Count; i++) self.allEnemyArchitectureObj[i].GetComponent<ArchitectureBehaviour>().UIHide();
                _003CbeginIndex_003E5__2 = isVictory ? unchecked(-self.nowMapMaxZ) : self.nowMapMaxZ;
                AudioManager.Instance.PlaySFX(isVictory ? "Assets/_Res/Addressable/AudiosBundle/SFX/Win.mp3" : "Assets/_Res/Addressable/AudiosBundle/SFX/Lose.mp3", null, 1f, 0);
                AudioManager.Instance.PlayBGM(null);
            SliceLoop:
                if (_003CbeginIndex_003E5__2 < unchecked(-self.nowMapMaxZ) || _003CbeginIndex_003E5__2 > self.nowMapMaxZ)
                    goto FinalWait;
                for (int i = 0; i < self.allHexObjMat.Count; i++)
                {
                    if (self.allHexObjBehaviour[i].transform.position.z == (float)_003CbeginIndex_003E5__2)
                        self.allHexObjBehaviour[i].UIHide();
                    if (isVictory)
                    {
                        if (self.allHexObjBehaviour[i].transform.position.z == (float)_003CbeginIndex_003E5__2)
                        {
                            var capture = new _003C_003Ec__DisplayClass217_0 { index = i, _003C_003E4__this = self };
                            DG.Tweening.ShortcutExtensions.DOKill(self.allHexObj[i].transform);
                            DG.Tweening.TweenSettingsExtensions.SetEase(DG.Tweening.ShortcutExtensions.DOMoveY(self.allHexObj[i].transform, 1f, 0.1f), (DG.Tweening.Ease)3);
                            DG.Tweening.Tween rotation = DG.Tweening.ShortcutExtensions.DOLocalRotate(self.allHexObj[i].transform, new Vector3(0f, 0f, 180f), 0.2f);
                            rotation.onComplete += capture._003CSettlementAnimation_003Eb__0;
                        }
                    }
                    else if (self.allHexObjBehaviour[i].transform.position.z == (float)_003CbeginIndex_003E5__2)
                    {
                        var capture = new _003C_003Ec__DisplayClass217_1 { index = i, _003C_003E4__this = self };
                        DG.Tweening.ShortcutExtensions.DOKill(self.allHexObj[i].transform);
                        DG.Tweening.TweenSettingsExtensions.SetEase(DG.Tweening.ShortcutExtensions.DOMoveY(self.allHexObj[i].transform, 1f, 0.1f), (DG.Tweening.Ease)3);
                        DG.Tweening.Tween rotation = DG.Tweening.ShortcutExtensions.DOLocalRotate(self.allHexObj[i].transform, new Vector3(0f, 0f, 180f), 0.2f);
                        rotation.onComplete += capture._003CSettlementAnimation_003Eb__1;
                    }
                }
                _003CbeginIndex_003E5__2 = unchecked(_003CbeginIndex_003E5__2 + (isVictory ? 1 : -1));
                awaiter = UniTask.WaitForSeconds(0.02f, false, (PlayerLoopTiming)8).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 1;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            ResumeSlice:
                awaiter.GetResult();
                goto SliceLoop;
            FinalWait:
                awaiter = UniTask.WaitForSeconds(1f, false, (PlayerLoopTiming)8).GetAwaiter();
                if (!awaiter.IsCompleted)
                {
                    _003C_003E1__state = 2;
                    _003C_003Eu__1 = awaiter;
                    _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                    return;
                }
            ResumeFinal:
                awaiter.GetResult();
                EventModule.EventManager.Instance.TriggerEvent("SettlementAnimationEnd", isVictory);
            }
            catch (global::System.Exception exception)
            {
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetException(exception);
                return;
            }
            _003C_003E1__state = -2;
            _003C_003Et__builder.SetResult();
        }

			[Token(Token = "0x6001473")]
			[Address(RVA = "0x3DFE480", Offset = "0x3DFA480", VA = "0x3DFE480", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
            _003C_003Et__builder.SetStateMachine(stateMachine);
        }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000434")]
		[CompilerGenerated]
		private struct _003CStartGame_003Ed__142 : IAsyncStateMachine
		{
			[Token(Token = "0x40029C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameType gameType;

			[Token(Token = "0x6001474")]
			[Address(RVA = "0x3DFE48C", Offset = "0x3DFA48C", VA = "0x3DFE48C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001475")]
			[Address(RVA = "0x3DFE8BC", Offset = "0x3DFA8BC", VA = "0x3DFE8BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000435")]
		[CompilerGenerated]
		private struct _003CUpdateAllList_003Ed__155 : IAsyncStateMachine
		{
			[Token(Token = "0x40029C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001476")]
			[Address(RVA = "0x3DFE8C8", Offset = "0x3DFA8C8", VA = "0x3DFE8C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001477")]
			[Address(RVA = "0x3DFEDC8", Offset = "0x3DFADC8", VA = "0x3DFEDC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000436")]
		[CompilerGenerated]
		private struct _003CUpdateArchitecture_003Ed__159 : IAsyncStateMachine
		{
			[Token(Token = "0x40029CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001478")]
			[Address(RVA = "0x3DFEDD4", Offset = "0x3DFADD4", VA = "0x3DFEDD4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001479")]
			[Address(RVA = "0x3DFF1FC", Offset = "0x3DFB1FC", VA = "0x3DFF1FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000437")]
		[CompilerGenerated]
		private struct _003CUpdateEnemyRole_003Ed__156 : IAsyncStateMachine
		{
			[Token(Token = "0x40029D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147A")]
			[Address(RVA = "0x3DFF208", Offset = "0x3DFB208", VA = "0x3DFF208", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147B")]
			[Address(RVA = "0x3DFF630", Offset = "0x3DFB630", VA = "0x3DFF630", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000438")]
		[CompilerGenerated]
		private struct _003CUpdateHexObj_003Ed__158 : IAsyncStateMachine
		{
			[Token(Token = "0x40029D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147C")]
			[Address(RVA = "0x3DFF63C", Offset = "0x3DFB63C", VA = "0x3DFF63C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147D")]
			[Address(RVA = "0x3DFFA60", Offset = "0x3DFBA60", VA = "0x3DFFA60", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000439")]
		[CompilerGenerated]
		private struct _003CUpdatePlayerRole_003Ed__157 : IAsyncStateMachine
		{
			[Token(Token = "0x40029DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40029E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40029E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameSceneManager _003C_003E4__this;

			[Token(Token = "0x40029E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CprocessedCount_003E5__2;

			[Token(Token = "0x40029E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x40029E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600147E")]
			[Address(RVA = "0x3DFFA6C", Offset = "0x3DFBA6C", VA = "0x3DFFA6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600147F")]
			[Address(RVA = "0x3DFFE94", Offset = "0x3DFBE94", VA = "0x3DFFE94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentRoleInstanceID;

		[Token(Token = "0x400292A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _generateHexObjRoot;

		[Token(Token = "0x400292B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GenerateHexBehaviour _generateHexBehaviour;

		[Token(Token = "0x400292C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Vector3[] _spawnHexVertices = new Vector3[6];

		[Token(Token = "0x400292D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _spawnHexVertexSize = -1f;

		[Token(Token = "0x400292E")]
		private const int RoleTargetHexSearchPadding = 2;

		[Token(Token = "0x400292F")]
		private const int RoleTargetMaxHexSearchRing = 10;

		[Token(Token = "0x4002930")]
		private const float RoleTargetMinHexStep = 0.5f;

		[Token(Token = "0x4002931")]
		private const float RoleTargetRangeCachePrecision = 100f;

		[Token(Token = "0x4002932")]
		private const int BattleBulletPrewarmCount = 10;

		[Token(Token = "0x4002933")]
		private const int BattleResourceProductPrewarmCount = 80;

		[Token(Token = "0x4002934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _destroyObjRoot;

		[Token(Token = "0x4002935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue> _roleTargetFrameCache = new Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue>(128);

		[Token(Token = "0x4002936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _roleTargetFrameCacheFrame = -1;

		[Token(Token = "0x4002937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<GameObject> allPlayerStayOpenHexObj;

		[Token(Token = "0x4002938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<GameObject> allEnemyStayOpenHexObj;

		[Token(Token = "0x4002939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<HexBehaviour> allEnemyStayOpenHexObjBehaviours;

		[Token(Token = "0x400293A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GameObject> allHexObj;

		[Token(Token = "0x400293B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<HexBehaviour> allHexObjBehaviour;

		[Token(Token = "0x400293C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MeshRenderer> allHexObjMat;

		[Token(Token = "0x400293D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> allPlayerHasOpenHexObj;

		[Token(Token = "0x400293E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GameObject> allEnemyHasOpenHexObj;

		[Token(Token = "0x400293F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GameObject> allPlayerArchitectureObj;

		[Token(Token = "0x4002940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<GameObject> allEnemyArchitectureObj;

		[Token(Token = "0x4002941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<GameObject> allPlayerRoleObj;

		[Token(Token = "0x4002942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<GameObject> allEnemyRoleObj;

		[Token(Token = "0x4002943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<RoleBehaviour> allEnemyRoleBehaviour;

		[Token(Token = "0x4002944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<RoleBehaviour> allPlayerRoleBehaviour;

		[Token(Token = "0x4002945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<RoleBehaviour> allRoleBehaviour;

		[Token(Token = "0x4002946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<ArchitectureBehaviour> allArchitectureBehaviours;

		[Token(Token = "0x4002947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<ArchitectureBehaviour> allPlayerArchitectureBehaviours;

		[Token(Token = "0x4002948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<ArchitectureBehaviour> allEnemyArchitectureBehaviours;

		[Token(Token = "0x4002949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<HellfireBehaviour> allHellfireBehaviours = new List<HellfireBehaviour>();

		[Token(Token = "0x400294A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _playerComboWallCount;

		[Token(Token = "0x400294B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _enemyComboWallCount;

		[Token(Token = "0x400294C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GameObject _waterPlane;

		[Token(Token = "0x400294D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _groundPlane;

		[Token(Token = "0x400294E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<GameObject> needDestroyPoolPrefabOnEndGame = new List<GameObject>();

		[Token(Token = "0x400294F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _playerArchitectureRoot;

		[Token(Token = "0x4002950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private GameObject _enemyArchitectureRoot;

		[Token(Token = "0x4002951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _playerRoleRoot;

		[Token(Token = "0x4002952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject _enemyRoleRoot;

		[Token(Token = "0x4002953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject _specialHexRoot;

		[Token(Token = "0x4002954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private WebGLNavigationManager _webGLNavigationManager;

		[Token(Token = "0x4002955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Vector3 playerMainTowerPos;

		[Token(Token = "0x4002956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public string enemyMainTowerKey;

		[Token(Token = "0x4002957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public string playerMainTowerKey;

		[Token(Token = "0x4002958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool playerMainTowerIsDestroy;

		[Token(Token = "0x4002959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool enemyMainTowerIsDestroy;

		[Token(Token = "0x400295A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string polygonMapId;

		[Token(Token = "0x400295B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<Vector3> specialHexPos;

		[Token(Token = "0x400295C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Dictionary<Tuple<int, int>, HexMirrorInfo> _mirrorMap = new Dictionary<Tuple<int, int>, HexMirrorInfo>();

		[Token(Token = "0x400295D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly int ScaleFactor = 1000;

		[Token(Token = "0x400295E")]
		private const string EnableLegendaryTileOnlineParamKey = "EnableLegendaryTile";

		[Token(Token = "0x400295F")]
		private const string LegendaryLandHexGlobalInfoId = "1005";

		[Token(Token = "0x4002960")]
		private const int LegendaryTileV1DefaultPrice = 350;

		[Token(Token = "0x4002963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int nowMapMaxZ;

		[Token(Token = "0x4002964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int rotateNum;

		[Token(Token = "0x4002965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int sizeNum;

		[Token(Token = "0x4002966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public int sceneGoldMineCanCreatCount;

		[Token(Token = "0x4002967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public int sceneGoldMineMirrorSideCount;

		[Token(Token = "0x4002968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public int scenePLayerUseGoldMineCount;

		[Token(Token = "0x4002969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int sceneEnemyUseGoldMineCount;

		[Token(Token = "0x400296A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public int playerRoleDebutCount;

		[Token(Token = "0x400296B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[FormerlySerializedAs("playerOntStarRoleDebutCount")]
		[FormerlySerializedAs("playerOneStarRoleDebutCount")]
		public int playerOpenOneStarCount;

		[Token(Token = "0x400296C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		[FormerlySerializedAs("playerTwoStarRoleDebutCount")]
		public int playerOpenTwoStarCount;

		[Token(Token = "0x400296D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[FormerlySerializedAs("playerThereStarRoleDebutCount")]
		public int playerOpenThereStarCount;

		[Token(Token = "0x400296E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[FormerlySerializedAs("playerUnChartRoleDebutCount")]
		public int playerOpenUnChartCount;

		[Token(Token = "0x400296F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public int playerOpenHexCount;

		[Token(Token = "0x4002970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public MapType mapType;

		[Token(Token = "0x4002971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool isSeasonPVP_BTest;

		[Token(Token = "0x4002972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public GameObject seasonBTestDecorationObj;

		[Token(Token = "0x4002973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public int playerCanGetWoodNum;

		[Token(Token = "0x4002974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public int enemyCanGetWoodNum;

		[Token(Token = "0x4002975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private GameObject _skillIndicator;

		[Token(Token = "0x4002976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private SpriteRenderer _skillIndicatorRenderer;

		[Token(Token = "0x4002977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Color SkillIndicatorValidColor;

		[Token(Token = "0x4002978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Color SkillIndicatorInvalidColor;

		[Token(Token = "0x4002979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _playerRoleCount;

		[Token(Token = "0x400297A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private int _enemyRoleCount;

		[Token(Token = "0x400297B")]
		private const int MAX_ROLE_COUNT = 100;

		[Token(Token = "0x400297C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int _playerReservedCount;

		[Token(Token = "0x400297D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private int _enemyReservedCount;

		[Token(Token = "0x400297E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private List<BarracksArchitectureBehaviour> _playerWaitingBarracks = new List<BarracksArchitectureBehaviour>();

		[Token(Token = "0x400297F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private List<BarracksArchitectureBehaviour> _enemyWaitingBarracks = new List<BarracksArchitectureBehaviour>();

		[Token(Token = "0x4002980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Dictionary<string, int> _playerLegendaryUnitCount = new Dictionary<string, int>();

		[Token(Token = "0x4002981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Dictionary<string, int> _enemyLegendaryUnitCount = new Dictionary<string, int>();

		[Token(Token = "0x4002982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Dictionary<string, int> _playerLegendaryBarracksCount = new Dictionary<string, int>();

		[Token(Token = "0x4002983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Dictionary<string, int> _enemyLegendaryBarracksCount = new Dictionary<string, int>();

		[Token(Token = "0x4002984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private float currentUpdateInterTime;

		[Token(Token = "0x4002985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private float updateInterTime = 0.02f;

		[Token(Token = "0x4002986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private bool upgradeing;

		[Token(Token = "0x4002987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private float currentUpdateInterTime_FindAllRoleNearestEnemy;

		[Token(Token = "0x4002988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float updateInterTime_FindAllRoleNearesdEnemy = 1f;

		[Token(Token = "0x4002989")]
		private const int BATCH_SIZE = 50;

		[Token(Token = "0x400298A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private DynamicTargetFinder dynamicTargetFinder;

		[Token(Token = "0x1700012F")]
		public bool IsNoneTutorGame
		{
			[Token(Token = "0x60013B8")]
			[Address(RVA = "0x3DEC72C", Offset = "0x3DE872C", VA = "0x3DEC72C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000130")]
		public HexBehaviour LegendaryTileV1LastPlayerHalfHex
		{
			[Token(Token = "0x60013BD")]
			[Address(RVA = "0x3DECBE8", Offset = "0x3DE8BE8", VA = "0x3DECBE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x3DECBF0", Offset = "0x3DE8BF0", VA = "0x3DECBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public HexBehaviour LegendaryTileV1LastEnemyHalfHex
		{
			[Token(Token = "0x60013BF")]
			[Address(RVA = "0x3DECBF8", Offset = "0x3DE8BF8", VA = "0x3DECBF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013C0")]
			[Address(RVA = "0x3DECC00", Offset = "0x3DE8C00", VA = "0x3DECC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public int PlayerHasHex
		{
			[Token(Token = "0x60013C6")]
			[Address(RVA = "0x3DEA55C", Offset = "0x3DE655C", VA = "0x3DEA55C")]
			get
			{
			return unchecked(allPlayerStayOpenHexObj.Count + allPlayerHasOpenHexObj.Count);
		}
		}

		[Token(Token = "0x17000133")]
		public int EnemyHasHex
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x3DEA5B4", Offset = "0x3DE65B4", VA = "0x3DEA5B4")]
			get
			{
			return unchecked(allEnemyStayOpenHexObj.Count + allEnemyHasOpenHexObj.Count);
		}
		}

		[Token(Token = "0x17000134")]
		public int PlayerRoleCount
		{
			[Token(Token = "0x60013C8")]
			[Address(RVA = "0x3DED8DC", Offset = "0x3DE98DC", VA = "0x3DED8DC")]
			get
			{
				return _playerRoleCount;
			}
		}

		[Token(Token = "0x17000135")]
		public int EnemyRoleCount
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x3DED8E4", Offset = "0x3DE98E4", VA = "0x3DED8E4")]
			get
			{
				return _enemyRoleCount;
			}
		}

		[Token(Token = "0x17000136")]
		public int MaxRoleCount
		{
			[Token(Token = "0x60013CA")]
			[Address(RVA = "0x3DED8EC", Offset = "0x3DE98EC", VA = "0x3DED8EC")]
			get
			{
			return MAX_ROLE_COUNT;
		}
		}

		[Token(Token = "0x17000137")]
		public int AllHexCount
		{
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x3DEDC0C", Offset = "0x3DE9C0C", VA = "0x3DEDC0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x3DEC808", Offset = "0x3DE8808", VA = "0x3DEC808")]
		public static bool IsLegendaryTileV1EnabledThisBattle()
		{
			return default;
		}

		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x3DECA5C", Offset = "0x3DE8A5C", VA = "0x3DECA5C")]
		public static int GetLegendaryTileV1Price()
		{
			return default;
		}

		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x3DEC874", Offset = "0x3DE8874", VA = "0x3DEC874")]
		private static bool TryParseLegendaryTileV1OnlineParam(out bool isEnabled, out int onlinePrice)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BattleGameSceneManager.TryParseLegendaryTileV1OnlineParam RVA=0x3DEC874 Token=0x60013BB");
}

		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x3DECAE8", Offset = "0x3DE8AE8", VA = "0x3DECAE8")]
		private static int GetLegendaryTileV1ConfigPriceFallback()
		{
			return default;
		}

		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x3DECC08", Offset = "0x3DE8C08", VA = "0x3DECC08")]
		public void FinalizeLegendaryTiles()
		{
		}

		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x3DED460", Offset = "0x3DE9460", VA = "0x3DED460")]
		private static bool LegendaryTileV1QualityTierOk(Quality q, int tierMin)
		{
			return default;
		}

		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x3DED4AC", Offset = "0x3DE94AC", VA = "0x3DED4AC")]
		private static bool LegendaryTileV1HexPassesBaseFilters(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x3DED544", Offset = "0x3DE9544", VA = "0x3DED544")]
		private List<HexBehaviour> LegendaryTileV1BuildPool(bool enemyHalf, HexManager.HexCoord mainCoord, int minHexSteps, int qualityTierMin)
		{
			return null;
		}

		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x3DECE6C", Offset = "0x3DE8E6C", VA = "0x3DECE6C")]
		private HexBehaviour LegendaryTileV1PickOneHalf(bool enemyHalf, HexManager.HexCoord mainCoord)
		{
			return null;
		}

		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x3DED8F4", Offset = "0x3DE98F4", VA = "0x3DED8F4")]
		public bool CanSpawnRole(bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
			return isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount) < MAX_ROLE_COUNT
			               : unchecked(_playerRoleCount + _playerReservedCount) < MAX_ROLE_COUNT;
		}

		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x3DED9AC", Offset = "0x3DE99AC", VA = "0x3DED9AC")]
		public int GetAvailableSlots(bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return int.MaxValue;
			int used = isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount)
			                   : unchecked(_playerRoleCount + _playerReservedCount);
			return Mathf.Max(0, unchecked(MAX_ROLE_COUNT - used));
		}

		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x3DEDA74", Offset = "0x3DE9A74", VA = "0x3DEDA74")]
		public void ReserveRoleSlot(bool isEnemy)
		{
			ReserveRoleSlot(isEnemy, 1);
		}

		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x3DEDA80", Offset = "0x3DE9A80", VA = "0x3DEDA80")]
		public void ReserveRoleSlot(bool isEnemy, int count)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			if (isEnemy) _enemyReservedCount = unchecked(_enemyReservedCount + count);
			else _playerReservedCount = unchecked(_playerReservedCount + count);
		}

		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x3DEDB30", Offset = "0x3DE9B30", VA = "0x3DEDB30")]
		public void ReleaseReservedSlot(bool isEnemy)
		{
			ReleaseReservedSlot(isEnemy, 1);
		}

		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x3DEDB3C", Offset = "0x3DE9B3C", VA = "0x3DEDB3C")]
		public void ReleaseReservedSlot(bool isEnemy, int count)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			if (isEnemy) _enemyReservedCount = Mathf.Max(0, unchecked(_enemyReservedCount - count));
			else _playerReservedCount = Mathf.Max(0, unchecked(_playerReservedCount - count));
		}

		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x3DEDBF4", Offset = "0x3DE9BF4", VA = "0x3DEDBF4")]
		private int GetRareLevelValue(RareLevel rareLevel)
		{
			return default;
		}

		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x3DEDC54", Offset = "0x3DE9C54", VA = "0x3DEDC54", Slot = "4")]
		public override async UniTask Init()
		{
			allPlayerStayOpenHexObj = new List<GameObject>();
			allEnemyStayOpenHexObj = new List<GameObject>();
			allHexObj = new List<GameObject>();
			allPlayerHasOpenHexObj = new List<GameObject>();
			allEnemyHasOpenHexObj = new List<GameObject>();
			allPlayerArchitectureObj = new List<GameObject>();
			allEnemyArchitectureObj = new List<GameObject>();
			allPlayerRoleObj = new List<GameObject>();
			allEnemyRoleObj = new List<GameObject>();
			allHexObjBehaviour = new List<HexBehaviour>();
			allHexObjMat = new List<MeshRenderer>();
			allEnemyRoleBehaviour = new List<RoleBehaviour>();
			allPlayerRoleBehaviour = new List<RoleBehaviour>();
			allRoleBehaviour = new List<RoleBehaviour>();
			allEnemyStayOpenHexObjBehaviours = new List<HexBehaviour>();
			allArchitectureBehaviours = new List<ArchitectureBehaviour>();
			allPlayerArchitectureBehaviours = new List<ArchitectureBehaviour>();
			allEnemyArchitectureBehaviours = new List<ArchitectureBehaviour>();
			specialHexPos = new List<Vector3>();
			_playerArchitectureRoot = new GameObject("PlayerArchitectureRoot");
			_enemyArchitectureRoot = new GameObject("EnemyArchitectureRoot");
			_playerRoleRoot = new GameObject("PlayerRoleRoot");
			_enemyRoleRoot = new GameObject("EnemyRoleRoot");
			_destroyObjRoot = new GameObject("DestroyObjRoot");
			_specialHexRoot = new GameObject("SpecialHexRoot");
			EnsureWebGLNavigationManager();
			if (_generateHexObjRoot == null)
			{
			    _generateHexObjRoot = new GameObject("GenerateHex");
			    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
			}
			global::EventModule.EventManager.Instance.StartListening("CraetHexEnd", CreatBothMainTower);
			if (global::SDKModule.ABTestManager.Instance.NewArtifactsPlayIsBTest)
			{
			    GameObject prefab = await global::AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/SkillIndicator.prefab");
			    if (_skillIndicator == null)
			    {
			        _skillIndicator = UnityEngine.Object.Instantiate(prefab);
			        _skillIndicatorRenderer = _skillIndicator.GetComponent<SpriteRenderer>();
			    }
			    else if (_skillIndicatorRenderer == null)
			        _skillIndicatorRenderer = _skillIndicator.GetComponent<SpriteRenderer>();
			    _skillIndicator.SetActive(false);
			}
		}

		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x3DEDCF0", Offset = "0x3DE9CF0", VA = "0x3DEDCF0")]
		private static bool ShouldUseWebGLNavigation()
		{
			return global::Pathfinding.AstarWebGLRuntimeConfig.UseWebGLNavigation;
		}

		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x3DEDCF8", Offset = "0x3DE9CF8", VA = "0x3DEDCF8")]
		private void EnsureWebGLNavigationManager()
		{
			if (!ShouldUseWebGLNavigation()) return;
			if (_webGLNavigationManager == null)
			{
			    GameObject obj = new GameObject("WebGLNavigationManager");
			    obj.transform.SetParent(transform, false);
			    _webGLNavigationManager = obj.AddComponent<WebGLNavigationManager>();
			}
			_webGLNavigationManager.Initialize(this);
		}

		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x3DEDE50", Offset = "0x3DE9E50", VA = "0x3DEDE50")]
		private void ShutdownWebGLNavigationManager()
		{
			if (_webGLNavigationManager != null) _webGLNavigationManager.Shutdown();
		}

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x3DEDED4", Offset = "0x3DE9ED4", VA = "0x3DEDED4")]
		private void TickWebGLNavigation(float deltaTime)
		{
			if (!ShouldUseWebGLNavigation()) return;
			EnsureWebGLNavigationManager();
			_webGLNavigationManager?.Tick(deltaTime);
		}

		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x3DEDF64", Offset = "0x3DE9F64", VA = "0x3DEDF64")]
		private void MarkWebGLNavigationDirty()
		{
			MarkWebGLNavigationGraphDirty();
		}

		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x3DEDF68", Offset = "0x3DE9F68", VA = "0x3DEDF68")]
		private void MarkWebGLNavigationGraphDirty()
		{
			if (!ShouldUseWebGLNavigation()) return;
			EnsureWebGLNavigationManager();
			_webGLNavigationManager?.MarkPathGraphDirty();
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x3DEDFE4", Offset = "0x3DE9FE4", VA = "0x3DEDFE4")]
		private void MarkWebGLNavigationAllFieldsDirty()
		{
		}

		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x3DEE060", Offset = "0x3DEA060", VA = "0x3DEE060")]
		public void MarkWebGLNavigationTargetFieldDirty(bool targetIsEnemy)
		{
			if (!ShouldUseWebGLNavigation())
			    return;
			EnsureWebGLNavigationManager();
			_webGLNavigationManager?.MarkTargetPathFieldDirty(targetIsEnemy);
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x3DEE0F0", Offset = "0x3DEA0F0", VA = "0x3DEE0F0")]
		public void ShowSkillIndicator(Vector3 worldPos, float radius = 3f, bool isValid = true)
		{
		}

		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x3DEE40C", Offset = "0x3DEA40C", VA = "0x3DEE40C")]
		public void UpdateSkillIndicator(Vector3 worldPos, bool isValid = true)
		{
		}

		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x3DEE53C", Offset = "0x3DEA53C", VA = "0x3DEE53C")]
		public void HideSkillIndicator()
		{
		}

		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x3DEE298", Offset = "0x3DEA298", VA = "0x3DEE298")]
		private void ApplySkillIndicatorColor(bool isValid)
		{
		}

		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x3DEE5D0", Offset = "0x3DEA5D0", VA = "0x3DEE5D0")]
		public async void StartGame(GameType gameType)
		{
			_currentRoleInstanceID = 0;
			playerCanGetWoodNum = 0;
			enemyCanGetWoodNum = 0;
			_playerRoleCount = 0;
			_enemyRoleCount = 0;
			playerMainTowerIsDestroy = false;
			enemyMainTowerIsDestroy = false;
			EnsureWebGLNavigationManager();
			MarkWebGLNavigationDirty();
			PrewarmBattleRuntimePools().Forget();
			Dictionary<string, global::DataModule.GlobalArenaInfo> arenaInfo = global::DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic;
			string arenaId = ToolModule.StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			sceneGoldMineCanCreatCount = ToolModule.StringTool.ToInt(arenaInfo[arenaId].minesCountLimit);
			if (global::SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest)
			    sceneGoldMineCanCreatCount &= ~1;
			sceneGoldMineMirrorSideCount = sceneGoldMineCanCreatCount / 2;
			if (_generateHexObjRoot == null)
			{
			    _generateHexObjRoot = new GameObject("GenerateHex");
			    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
			}
			_generateHexObjRoot.GetComponent<GenerateHexBehaviour>().Generate(gameType);
		}

		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x3DEE670", Offset = "0x3DEA670", VA = "0x3DEE670")]
		private async UniTaskVoid PrewarmBattleRuntimePools()
		{
			// Original ARM64 MoveNext 0x3DFD310 only completes its async builder.
			return;
		}

		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x3DEE6D8", Offset = "0x3DEA6D8", VA = "0x3DEE6D8")]
		private (Tuple<int, int>, bool) ParseKey(string key)
		{
			return default;
		}

		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x3DEE96C", Offset = "0x3DEA96C", VA = "0x3DEE96C")]
		public HexMirrorInfo GetMirror(string key)
		{
			return null;
		}

		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x3DEE9FC", Offset = "0x3DEA9FC", VA = "0x3DEE9FC")]
		public void AddToRecord(string key, Quality quality, RareLevel rareLevel, HexType hexType)
		{
		}

		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x3DEEB04", Offset = "0x3DEAB04", VA = "0x3DEEB04")]
		public async UniTask LoadMapGround(GameType gameType)
		{
			if (_generateHexObjRoot == null)
			{
			    _generateHexObjRoot = new GameObject("GenerateHex");
			    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
			}
			await _generateHexObjRoot.GetComponent<GenerateHexBehaviour>().LoadGround(gameType);
		}

		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x3DEEBB0", Offset = "0x3DEABB0", VA = "0x3DEEBB0")]
		private void Update()
		{
			if (!CoreGameManager.Gaming) return;
			TickWebGLNavigation(Time.deltaTime);
			currentUpdateInterTime += Time.deltaTime;
			if (currentUpdateInterTime > updateInterTime)
			{
			    currentUpdateInterTime = 0f;
			    if (!upgradeing) UpdateAllList().Forget();
			}
		}

		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x3DEECA0", Offset = "0x3DEACA0", VA = "0x3DEECA0")]
		private async UniTask UpdateAllList()
		{
			upgradeing = true;
			await UniTask.WhenAll(UpdateEnemyRole(), UpdatePlayerRole(), UpdateHexObj(), UpdateArchitecture());
			upgradeing = false;
		}

		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x3DEED38", Offset = "0x3DEAD38", VA = "0x3DEED38")]
		private async UniTask UpdateEnemyRole()
		{
			int processedCount = 0;
			for (int i = allEnemyRoleBehaviour.Count - 1; i >= 0 && i < allEnemyRoleBehaviour.Count; i--)
			{
			    RoleBehaviour obj = allEnemyRoleBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await UniTask.Yield();
			}
		}

		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x3DEEDD0", Offset = "0x3DEADD0", VA = "0x3DEEDD0")]
		private async UniTask UpdatePlayerRole()
		{
			int processedCount = 0;
			for (int i = allPlayerRoleBehaviour.Count - 1; i >= 0 && i < allPlayerRoleBehaviour.Count; i--)
			{
			    RoleBehaviour obj = allPlayerRoleBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await UniTask.Yield();
			}
		}

		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x3DEEE68", Offset = "0x3DEAE68", VA = "0x3DEEE68")]
		private async UniTask UpdateHexObj()
		{
			int processedCount = 0;
			for (int i = allHexObjBehaviour.Count - 1; i >= 0 && i < allHexObjBehaviour.Count; i--)
			{
			    HexBehaviour obj = allHexObjBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await UniTask.Yield();
			}
		}

		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x3DEEF00", Offset = "0x3DEAF00", VA = "0x3DEEF00")]
		private async UniTask UpdateArchitecture()
		{
			int processedCount = 0;
			for (int i = allArchitectureBehaviours.Count - 1; i >= 0 && i < allArchitectureBehaviours.Count; i--)
			{
			    ArchitectureBehaviour obj = allArchitectureBehaviours[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await UniTask.Yield();
			}
		}

		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x3DEEF98", Offset = "0x3DEAF98", VA = "0x3DEEF98")]
		public void GoldMineCountLimitRecordHexCreat()
		{ sceneGoldMineCanCreatCount = UnityEngine.Mathf.Clamp(unchecked(sceneGoldMineCanCreatCount - 1), 0, 100); }

		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x3DEEFB8", Offset = "0x3DEAFB8", VA = "0x3DEEFB8")]
		public void RecordPlayerUseGoldMine()
		{ scenePLayerUseGoldMineCount = unchecked(scenePLayerUseGoldMineCount + 1); }

		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x3DEEFC8", Offset = "0x3DEAFC8", VA = "0x3DEEFC8")]
		public void RecordEnemyUseGoldMine()
		{ sceneEnemyUseGoldMineCount = unchecked(sceneEnemyUseGoldMineCount + 1); }

		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x3DEEFD8", Offset = "0x3DEAFD8", VA = "0x3DEEFD8")]
		public int GetGoldMinePrice(bool isEnemyHex)
		{
		    int price = ToolModule.StringTool.ToInt(DataModule.DataManager.Instance.GlobalInfo.hexInfos[0].price);
		    if (SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest)
		        price = unchecked(price + 5 * (isEnemyHex ? sceneEnemyUseGoldMineCount : scenePLayerUseGoldMineCount));
		    return price;
		}

		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x3DEF0EC", Offset = "0x3DEB0EC", VA = "0x3DEF0EC")]
		public void UpdateAllGoldMinePrices()
		{
		    if (!SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest) return;
		    foreach (HexBehaviour hex in allHexObjBehaviour)
		    {
		        if (hex == null) continue;
		        if (hex.ArchitectureInfoId != null && hex.ArchitectureInfoId == "1001") hex.RefreshSubGameInflationPrice();
		    }
		}

		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x3DEF330", Offset = "0x3DEB330", VA = "0x3DEF330")]
		public void RecordPlayerOpenHexTypeCount(Quality quality)
		{
            switch (quality)
            {
                case Quality.OneStar: playerOpenOneStarCount = unchecked(playerOpenOneStarCount + 1); break;
                case Quality.TwoStar: playerOpenTwoStarCount = unchecked(playerOpenTwoStarCount + 1); break;
                case Quality.ThreeStar: playerOpenThereStarCount = unchecked(playerOpenThereStarCount + 1); break;
                case Quality.UnCharted: playerOpenUnChartCount = unchecked(playerOpenUnChartCount + 1); break;
            }
        }

		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x3DEF394", Offset = "0x3DEB394", VA = "0x3DEF394")]
		public void RecordPlayerBarrackCreatRoleCount()
		{ playerRoleDebutCount = unchecked(playerRoleDebutCount + 1); }

		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x3DEF3A4", Offset = "0x3DEB3A4", VA = "0x3DEF3A4")]
		private void CreatBothMainTower(object o)
		{
			global::EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckComboWallCount);
			global::EventModule.EventManager.Instance.StartListening("HasHexDestroy", CheckComboWallCount);
		}

		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x3DEF4CC", Offset = "0x3DEB4CC", VA = "0x3DEF4CC")]
		private void CheckComboWallCount(object o)
		{
			int playerCount = 0;
			for (int i = 0; i < allPlayerHasOpenHexObj.Count; i++)
			    if (allPlayerHasOpenHexObj[i].GetComponent<HexBehaviour>().IsCombo()) playerCount++;
			_playerComboWallCount = playerCount;
			global::EventModule.EventManager.Instance.TriggerEvent("PlayerComboWallCountChange", _playerComboWallCount);
			int enemyCount = 0;
			for (int i = 0; i < allEnemyHasOpenHexObj.Count; i++)
			    if (allEnemyHasOpenHexObj[i].GetComponent<HexBehaviour>().IsCombo()) enemyCount++;
			_enemyComboWallCount = enemyCount;
			global::EventModule.EventManager.Instance.TriggerEvent("EnemyComboWallCountChange", _enemyComboWallCount);
		}

		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x3DEF6D0", Offset = "0x3DEB6D0", VA = "0x3DEF6D0")]
		public void RecordNewMapSizeZ(int num)
		{
			nowMapMaxZ = num;
		}

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x3DEF6D8", Offset = "0x3DEB6D8", VA = "0x3DEF6D8")]
		public void RecordCameraAniNum(int rotate, int size)
		{
			rotateNum = rotate;
			sizeNum = size;
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x3DEF6E4", Offset = "0x3DEB6E4", VA = "0x3DEF6E4")]
		public ArchitectureBehaviour GetArchitectureTarget(Vector3 pos, bool isEnemy)
		{
            List<GameObject> targetList = isEnemy ? allPlayerArchitectureObj : allEnemyArchitectureObj;
            if (targetList.Count == 0) return null;
            ArchitectureBehaviour nearby;
            if (WebGLNavigationManager.IsRuntimeEnabled
                && TryGetWebGLArchitectureAtOrNearPosition(pos, isEnemy, targetList, out nearby))
                return nearby;
            int nearestIndex = 0;
            float nearestDistance = targetList[0] != null
                ? Vector3.Distance(pos, targetList[0].transform.position) : float.MaxValue;
            for (int i = 1; i < targetList.Count; i++)
            {
                if (targetList[i] == null) continue;
                float distance = Vector3.Distance(pos, targetList[i].transform.position);
                if (nearestDistance > distance)
                {
                    nearestDistance = distance;
                    nearestIndex = i;
                }
            }
            return targetList[nearestIndex].GetComponent<ArchitectureBehaviour>();
        }

		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x3DEF9FC", Offset = "0x3DEB9FC", VA = "0x3DEF9FC")]
		private bool TryGetWebGLArchitectureAtOrNearPosition(Vector3 pos, bool isEnemy, List<GameObject> targetList, out ArchitectureBehaviour architecture)
		{
            architecture = null;
            HexBehaviour hex;
            if (!HexManager.TryGetHexAt(pos, out hex) || hex == null) return false;
            if (TryGetArchitectureOnHex(hex, isEnemy, targetList, out architecture)) return true;
            HexBehaviour[] neighbors =
            {
                hex.leftUpHexBehaviour, hex.upHexBehaviour, hex.rightUpHexBehaviour,
                hex.leftDownHexBehaviour, hex.downHexBehaviour, hex.rightDownHexBehaviour
            };
            float nearestDistance = float.MaxValue;
            for (int i = 0; i < neighbors.Length; i++)
            {
                ArchitectureBehaviour candidate;
                if (!TryGetArchitectureOnHex(neighbors[i], isEnemy, targetList, out candidate)) continue;
                float distance = Vector3.Distance(pos, candidate.transform.position);
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    architecture = candidate;
                }
            }
            return architecture != null;
        }

		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x3DEFE08", Offset = "0x3DEBE08", VA = "0x3DEFE08")]
		private static bool TryGetArchitectureOnHex(HexBehaviour hex, bool ownerIsEnemy, List<GameObject> targetList, out ArchitectureBehaviour architecture)
		{
            architecture = null;
            if (hex == null || !hex.hasArchitecture || hex.isDestroy || hex.isEnemyHex == ownerIsEnemy)
                return false;
            for (int i = 0; i < targetList.Count; i++)
            {
                GameObject obj = targetList[i];
                if (obj == null) continue;
                HexBehaviour targetHex;
                if (HexManager.TryGetHexAt(obj.transform.position, out targetHex) && targetHex == hex)
                {
                    architecture = obj.GetComponent<ArchitectureBehaviour>();
                    return architecture != null && !architecture.isDead;
                }
            }
            return false;
        }

		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x3DF0050", Offset = "0x3DEC050", VA = "0x3DF0050")]
		public Transform GetMainTowerNearArchitecture(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x3DF0358", Offset = "0x3DEC358", VA = "0x3DF0358")]
		[AsyncStateMachine(typeof(_003CGetRoleTarget_003Ed__175))]
		public UniTask<List<RoleBehaviour>> GetRoleTarget(Transform transform, bool isEnemy, float range, int roleNum = 1)
		{
			return default;
		}

		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x3DF0470", Offset = "0x3DEC470", VA = "0x3DF0470")]
		public List<RoleBehaviour> GetRoleTargetsSync(Transform transform, bool isEnemy, float range, int roleNum = 1)
		{
			List<RoleBehaviour> result = new List<RoleBehaviour>();
			if (transform == null) return result;
			Vector3 pos = transform.position;
			if (roleNum <= 1)
			{
			    RoleBehaviour target;
			    if (TryGetNearestRoleTarget(pos, isEnemy, range, out target)) result.Add(target);
			}
			else
			{
			    CollectRoleTargetsInRange(pos, isEnemy, range, result);
			    SortNearestRoleTargetsInPlace(pos, result, roleNum);
			}
			return result;
		}

		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x3DF0C7C", Offset = "0x3DECC7C", VA = "0x3DF0C7C")]
		public RoleBehaviour GetRoleTargetSync(Transform transform, bool isEnemy, float range)
		{
			RoleBehaviour target;
			return transform != null && TryGetNearestRoleTarget(transform.position, isEnemy, range, out target) ? target : null;
		}

		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x3DF0D3C", Offset = "0x3DECD3C", VA = "0x3DF0D3C")]
		public bool TryGetNearestRoleTarget(Transform sourceTransform, bool sourceIsEnemy, float range, out RoleBehaviour target)
		{
			if (sourceTransform == null) { target = null; return false; }
			return TryGetNearestRoleTarget(sourceTransform.position, sourceIsEnemy, range, out target);
		}

		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x3DF06BC", Offset = "0x3DEC6BC", VA = "0x3DF06BC")]
		public bool TryGetNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleBehaviour target)
		{
			target = null;
			List<RoleBehaviour> targetList = GetRoleTargetList(sourceIsEnemy);
			if (targetList == null || range < 0f || targetList.Count == 0) return false;
			float sqrRange = range * range;
			if (!TryGetCachedNearestRoleTarget(sourcePos, sourceIsEnemy, range, sqrRange, out target))
			{
			    bool searchedHexRing;
			    if (!TryGetNearestRoleTargetFromHexRing(sourcePos, !sourceIsEnemy, range, sqrRange, out target, out searchedHexRing))
			    {
			        if (searchedHexRing) return false;
			        if (!TryGetNearestRoleTargetFromList(sourcePos, targetList, sqrRange, out target)) return false;
			    }
			    CacheNearestRoleTarget(sourcePos, sourceIsEnemy, range, target);
			}
			return true;
		}

		[Token(Token = "0x6001400")]
		[Address(RVA = "0x3DF1584", Offset = "0x3DED584", VA = "0x3DF1584")]
		public int CollectRoleTargetsInRange(Transform sourceTransform, bool sourceIsEnemy, float range, List<RoleBehaviour> result)
		{
			if (sourceTransform == null) { if (result != null) result.Clear(); return 0; }
			return CollectRoleTargetsInRange(sourceTransform.position, sourceIsEnemy, range, result);
		}

		[Token(Token = "0x6001401")]
		[Address(RVA = "0x3DF08A8", Offset = "0x3DEC8A8", VA = "0x3DF08A8")]
		public int CollectRoleTargetsInRange(Vector3 sourcePos, bool sourceIsEnemy, float range, List<RoleBehaviour> result)
		{
			if (result == null) return 0;
			result.Clear();
			List<RoleBehaviour> targetList = GetRoleTargetList(sourceIsEnemy);
			if (targetList == null || range < 0f || targetList.Count == 0) return 0;
			float sqrRange = range * range;
			bool searchedHexRing;
			if (TryCollectRoleTargetsInRangeFromHexRing(sourcePos, !sourceIsEnemy, range, sqrRange, result, out searchedHexRing) || searchedHexRing)
			    return result.Count;
			return CollectRoleTargetsInRangeFromList(sourcePos, targetList, sqrRange, result);
		}

		[Token(Token = "0x6001402")]
		[Address(RVA = "0x3DF0E0C", Offset = "0x3DECE0C", VA = "0x3DF0E0C")]
		private List<RoleBehaviour> GetRoleTargetList(bool sourceIsEnemy)
		{
			return sourceIsEnemy ? allPlayerRoleBehaviour : allEnemyRoleBehaviour;
		}

		[Token(Token = "0x6001403")]
		[Address(RVA = "0x3DF1BB4", Offset = "0x3DEDBB4", VA = "0x3DF1BB4")]
		public bool TryGetMostDenseEnemyRolePosition(bool isEnemy, Vector3 sourcePos, float clusterRadius, float searchRange, out Vector3 denseCenter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BattleGameSceneManager.TryGetMostDenseEnemyRolePosition RVA=0x3DF1BB4 Token=0x6001403");
}

		[Token(Token = "0x6001404")]
		[Address(RVA = "0x3DF1F7C", Offset = "0x3DEDF7C", VA = "0x3DF1F7C")]
		public int DamageEnemyEntitiesInRadius(Vector3 center, float radius, bool attackerIsEnemy, int damage, string attackerId, EntityBase attacker, bool isLandRole, AtkWayType atkWayType, CardFettersType fetterType)
		{
			return default;
		}

		[Token(Token = "0x6001405")]
		[Address(RVA = "0x3DF2608", Offset = "0x3DEE608", VA = "0x3DF2608")]
		private void PrepareRoleTargetFrameCache()
		{
			int frame = Time.frameCount;
			if (_roleTargetFrameCacheFrame == frame) return;
			_roleTargetFrameCacheFrame = frame;
			_roleTargetFrameCache.Clear();
		}

		[Token(Token = "0x6001406")]
		[Address(RVA = "0x3DF2680", Offset = "0x3DEE680", VA = "0x3DF2680")]
		private bool TryGetRoleTargetFrameCacheKey(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleTargetFrameCacheKey key)
		{
			key = default;
			int searchRing;
			if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
			HexBehaviour hex;
			if (!HexManager.TryGetHexAt(sourcePos, out hex) || hex == null) return false;
			key = new RoleTargetFrameCacheKey(sourceIsEnemy, hex.HexCoord.q, hex.HexCoord.r,
			                                 Mathf.CeilToInt(range * RoleTargetRangeCachePrecision));
			return true;
		}

		[Token(Token = "0x6001407")]
		[Address(RVA = "0x3DF0E24", Offset = "0x3DECE24", VA = "0x3DF0E24")]
		private bool TryGetCachedNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, float sqrRange, out RoleBehaviour target)
		{
			target = null;
			PrepareRoleTargetFrameCache();
			RoleTargetFrameCacheKey key;
			if (!TryGetRoleTargetFrameCacheKey(sourcePos, sourceIsEnemy, range, out key)) return false;
			RoleTargetFrameCacheValue cached;
			if (!_roleTargetFrameCache.TryGetValue(key, out cached)) return false;
			RoleBehaviour role = cached.target;
			if (!IsRoleTargetValid(role))
			{
			    _roleTargetFrameCache.Remove(key);
			    return false;
			}
			if (!((sourcePos - role.transform.position).sqrMagnitude > sqrRange))
			{
			    target = role;
			    return true;
			}
			return false;
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x3DF12FC", Offset = "0x3DED2FC", VA = "0x3DF12FC")]
		private void CacheNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, RoleBehaviour target)
		{
			if (target == null) return;
			PrepareRoleTargetFrameCache();
			RoleTargetFrameCacheKey key;
			if (!TryGetRoleTargetFrameCacheKey(sourcePos, sourceIsEnemy, range, out key)) return;
			_roleTargetFrameCache[key] = new RoleTargetFrameCacheValue { target = target };
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0x3DF28DC", Offset = "0x3DEE8DC", VA = "0x3DF28DC")]
		private static bool IsRoleTargetValid(RoleBehaviour role)
		{
			return role != null && !role.isDead && !role.StealthIng;
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x3DF2828", Offset = "0x3DEE828", VA = "0x3DF2828")]
		private bool TryGetRoleTargetHexSearchRing(float range, out int searchRing)
		{
			searchRing = unchecked(Mathf.CeilToInt(range / Mathf.Max(GetSpawnHexSize() * 1.73205078f, 0.5f)) + 2);
			return searchRing <= RoleTargetMaxHexSearchRing;
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0x3DF0FBC", Offset = "0x3DECFBC", VA = "0x3DF0FBC")]
		private bool TryGetNearestRoleTargetFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, out RoleBehaviour nearestRole, out bool searchedHexRing)
		{
			nearestRole = null;
			searchedHexRing = false;
			int searchRing;
			if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
			HexBehaviour sourceHex;
			if (!HexManager.TryGetHexAt(sourcePos, out sourceHex) || sourceHex == null) return false;
			searchedHexRing = true;
			float nearestDistance = float.MaxValue;
			int q = sourceHex.HexCoord.q;
			int r = sourceHex.HexCoord.r;
			for (int dq = -searchRing; dq <= searchRing; dq++)
			{
			    int rMin = Mathf.Max(-searchRing, -dq - searchRing);
			    int rMax = Mathf.Min(searchRing, searchRing - dq);
			    for (int dr = rMin; dr <= rMax; dr++)
			    {
			        HexBehaviour hex = HexManager.GetHexBehaviour(new HexManager.HexCoord(unchecked(q + dq), unchecked(r + dr)));
			        if (hex == null) continue;
			        int count = hex.GetRoleCountByCamp(targetIsEnemy);
			        for (int i = 0; i < count; i++)
			        {
			            RoleBehaviour role = hex.GetRoleByCamp(targetIsEnemy, i);
			            if (!IsRoleTargetValid(role)) continue;
			            float distance = (sourcePos - role.transform.position).sqrMagnitude;
			            if (!(distance > sqrRange) && !(distance >= nearestDistance))
			            {
			                nearestDistance = distance;
			                nearestRole = role;
			            }
			        }
			    }
			}
			return nearestRole != null;
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x3DF1684", Offset = "0x3DED684", VA = "0x3DF1684")]
		private bool TryCollectRoleTargetsInRangeFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, List<RoleBehaviour> result, out bool searchedHexRing)
		{
			searchedHexRing = false;
			int searchRing;
			if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
			HexBehaviour sourceHex;
			if (!HexManager.TryGetHexAt(sourcePos, out sourceHex) || sourceHex == null) return false;
			searchedHexRing = true;
			int q = sourceHex.HexCoord.q;
			int r = sourceHex.HexCoord.r;
			for (int dq = -searchRing; dq <= searchRing; dq++)
			{
			    int rMin = Mathf.Max(-searchRing, -dq - searchRing);
			    int rMax = Mathf.Min(searchRing, searchRing - dq);
			    for (int dr = rMin; dr <= rMax; dr++)
			    {
			        HexBehaviour hex = HexManager.GetHexBehaviour(new HexManager.HexCoord(unchecked(q + dq), unchecked(r + dr)));
			        if (hex == null) continue;
			        int count = hex.GetRoleCountByCamp(targetIsEnemy);
			        for (int i = 0; i < count; i++)
			        {
			            RoleBehaviour role = hex.GetRoleByCamp(targetIsEnemy, i);
			            if (IsRoleTargetValid(role) && (sourcePos - role.transform.position).sqrMagnitude <= sqrRange)
			                result.Add(role);
			        }
			    }
			}
			return result.Count > 0;
		}

		[Token(Token = "0x600140D")]
		[Address(RVA = "0x3DF13F8", Offset = "0x3DED3F8", VA = "0x3DF13F8")]
		private static bool TryGetNearestRoleTargetFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, out RoleBehaviour nearestRole)
		{
			nearestRole = null;
			float nearestDistance = float.MaxValue;
			for (int i = 0; i < targetList.Count; i++)
			{
			    RoleBehaviour role = targetList[i];
			    if (!IsRoleTargetValid(role)) continue;
			    float distance = (sourcePos - role.transform.position).sqrMagnitude;
			    if (!(distance > sqrRange) && !(distance >= nearestDistance))
			    {
			        nearestDistance = distance;
			        nearestRole = role;
			    }
			}
			return nearestRole != null;
		}

		[Token(Token = "0x600140E")]
		[Address(RVA = "0x3DF1A0C", Offset = "0x3DEDA0C", VA = "0x3DF1A0C")]
		private static int CollectRoleTargetsInRangeFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, List<RoleBehaviour> result)
		{
			for (int i = 0; i < targetList.Count; i++)
			{
			    RoleBehaviour role = targetList[i];
			    if (IsRoleTargetValid(role) && (sourcePos - role.transform.position).sqrMagnitude <= sqrRange)
			        result.Add(role);
			}
			return result.Count;
		}

		[Token(Token = "0x600140F")]
		[Address(RVA = "0x3DF0A50", Offset = "0x3DECA50", VA = "0x3DF0A50")]
		private static void SortNearestRoleTargetsInPlace(Vector3 sourcePos, List<RoleBehaviour> result, int roleNum)
		{
			int count = Mathf.Min(roleNum, result.Count);
			for (int i = 0; i < count; i++)
			{
			    int nearest = i;
			    float distance = (sourcePos - result[i].transform.position).sqrMagnitude;
			    for (int j = i + 1; j < result.Count; j++)
			    {
			        float candidateDistance = (sourcePos - result[j].transform.position).sqrMagnitude;
			        if (candidateDistance < distance)
			        {
			            nearest = j;
			            distance = candidateDistance;
			        }
			    }
			    if (nearest != i)
			    {
			        RoleBehaviour first = result[nearest];
			        RoleBehaviour second = result[i];
			        result[i] = first;
			        result[nearest] = second;
			    }
			}
			if (result.Count > count) result.RemoveRange(count, result.Count - count);
		}

		[Token(Token = "0x6001410")]
		[Address(RVA = "0x3DF2A58", Offset = "0x3DEEA58", VA = "0x3DF2A58")]
		public List<EntityBase> GetRandomNumberRole(bool isEnemy, int num, bool onlyRole = false)
		{
            var result = new List<EntityBase>();
            var roles = new List<RoleBehaviour>(isEnemy ? allPlayerRoleBehaviour : allEnemyRoleBehaviour);
            var buildings = new List<ArchitectureBehaviour>(isEnemy ? allPlayerArchitectureBehaviours : allEnemyArchitectureBehaviours);
            for (int i = roles.Count - 1; i >= 0; i--)
                if (roles[i].StealthIng) roles.RemoveAt(i);
            if (onlyRole) {
                if (roles.Count >= num) {
                    int added = 0;
                    while (added < num) {
                        RoleBehaviour role = roles[UnityEngine.Random.Range(0, roles.Count)];
                        if (!result.Contains(role)) {
                            roles.Remove(role);
                            result.Add(role);
                            added++;
                        }
                    }
                } else {
                    for (int i = 0; i < roles.Count; i++) result.Add(roles[i]);
                }
                return result;
            }
            if (roles.Count + buildings.Count < num) {
                for (int i = 0; i < roles.Count; i++) result.Add(roles[i]);
                for (int i = 0; i < buildings.Count; i++) result.Add(buildings[i]);
                return result;
            }
            if (roles.Count > num) {
                for (int i = 0; i < num; i++) result.Add(roles[i]);
            } else {
                for (int i = 0; i < roles.Count; i++) result.Add(roles[i]);
            }
            if (result.Count < num) {
                int remaining = num - result.Count;
                if (remaining >= buildings.Count) {
                    for (int i = 0; i < buildings.Count; i++) result.Add(buildings[i]);
                } else {
                    for (int i = 0; i < remaining; i++) result.Add(buildings[i]);
                }
            }
            return result;
        }

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x3DF3188", Offset = "0x3DEF188", VA = "0x3DF3188")]
		public EntityBase GetNearObj(bool isEnemy, Vector3 pos, [Optional][DefaultParameterValue(false)] bool isRole, [Optional][DefaultParameterValue(false)] bool isRandom, [Optional][DefaultParameterValue(-1f)] float range, [Optional] GameObject excludeObj)
		{
            List<GameObject> candidates;
            if (UnityEngine.Random.Range(0, 100) > 49 || isRole) {
                candidates = new List<GameObject>(isEnemy ? allPlayerRoleObj : allEnemyRoleObj);
                for (int i = candidates.Count - 1; i >= 0; i--)
                    if (candidates[i].GetComponent<RoleBehaviour>().StealthIng)
                        candidates.RemoveAt(i);
            } else {
                candidates = new List<GameObject>(isEnemy ? allPlayerArchitectureObj : allEnemyArchitectureObj);
            }
            if (excludeObj != null && candidates.Contains(excludeObj))
                candidates.Remove(excludeObj);
            if (candidates.Count <= 0)
                candidates = new List<GameObject>(isEnemy ? allPlayerArchitectureObj : allEnemyArchitectureObj);
            int selected = 0;
            if (isRandom) {
                selected = UnityEngine.Random.Range(0, candidates.Count);
            } else {
                if (range > 0f) {
                    for (int i = candidates.Count - 1; i >= 0; i--)
                        if (Vector3.Distance(pos, candidates[i].transform.position) > range)
                            candidates.RemoveAt(i);
                }
                if (candidates.Count == 0) return null;
                float nearest = Vector3.Distance(pos, candidates[0].transform.position);
                for (int i = 1; i < candidates.Count; i++) {
                    float distance = Vector3.Distance(pos, candidates[i].transform.position);
                    if (nearest > distance) {
                        selected = i;
                        nearest = distance;
                    }
                }
            }
            if (candidates.Count >= 1)
                return candidates[selected].GetComponent<EntityBase>();
            return null;
        }

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x3DF36D4", Offset = "0x3DEF6D4", VA = "0x3DF36D4")]
		public List<RoleBehaviour> GetNearRole(bool isEnemy, EntityBase role, float range = 1f, int roleNumber = -1)
		{
			return null;
		}

		[Token(Token = "0x6001413")]
		[Address(RVA = "0x3DF3DEC", Offset = "0x3DEFDEC", VA = "0x3DF3DEC")]
		private bool IsInnerHex(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x3DF4010", Offset = "0x3DF0010", VA = "0x3DF4010")]
		private bool IsHexSurrounded(HexBehaviour hex)
		{
			return default;
		}

		[Token(Token = "0x6001415")]
		[Address(RVA = "0x3DF4234", Offset = "0x3DF0234", VA = "0x3DF4234")]
		public UniTask<List<Vector3>> GetRoleBornPos(Transform transform, bool isEnemy, int count = 1)
		{
			List<Vector3> result = new List<Vector3>();
			if (count > 0)
			{
			    Vector3 center = transform.position;
			    for (int i = 0; i < count; i++)
			        result.Add(GetRandomPositionOnHexEdge(center));
			}
			return UniTask.FromResult(result);
		}

		[Token(Token = "0x6001416")]
		[Address(RVA = "0x3DF43E4", Offset = "0x3DF03E4", VA = "0x3DF43E4")]
		private Vector3 GetRandomPositionOnHexEdge(Vector3 hexCenter)
		{
			EnsureSpawnHexVertices(GetSpawnHexSize());
			int index = UnityEngine.Random.Range(0, _spawnHexVertices.Length);
			int vertexCount = _spawnHexVertices.Length;
			Vector3 origin = Vector3.zero;
			Vector3 first = _spawnHexVertices[index];
			Vector3 second = _spawnHexVertices[(index + 1) % vertexCount];
			float firstWeight = UnityEngine.Random.Range(0f, 1f);
			float secondWeight = UnityEngine.Random.Range(0f, 1f);
			if (firstWeight + secondWeight > 1f)
			{
			    firstWeight = 1f - firstWeight;
			    secondWeight = 1f - secondWeight;
			}
			Vector3 offset = origin + (first - origin) * firstWeight + (second - origin) * secondWeight;
			return hexCenter + offset;
		}

		[Token(Token = "0x6001417")]
		[Address(RVA = "0x3DF2964", Offset = "0x3DEE964", VA = "0x3DF2964")]
		private float GetSpawnHexSize()
		{
			if (_generateHexBehaviour == null && _generateHexObjRoot != null)
			    _generateHexBehaviour = _generateHexObjRoot.GetComponent<GenerateHexBehaviour>();
			return _generateHexBehaviour != null ? _generateHexBehaviour.hexSize : 1f;
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0x3DF45F8", Offset = "0x3DF05F8", VA = "0x3DF45F8")]
		private void EnsureSpawnHexVertices(float hexSize)
		{
			float cachedMagnitude = Mathf.Abs(_spawnHexVertexSize);
			float sizeMagnitude = Mathf.Abs(hexSize);
			float larger = cachedMagnitude > sizeMagnitude ? cachedMagnitude : sizeMagnitude;
			float tolerance = larger * 0.000001f;
			float minimum = Mathf.Epsilon * 8f;
			tolerance = tolerance > minimum ? tolerance : minimum;
			if (Mathf.Abs(hexSize - _spawnHexVertexSize) < tolerance)
			    return;
			_spawnHexVertexSize = hexSize;
			_spawnHexVertices[0] = new Vector3(0f, 0f, hexSize);
			float half = hexSize * 0.5f;
			float width = ((hexSize / 1.7320508f) * 3f) * 0.5f;
			_spawnHexVertices[1] = new Vector3(width, 0f, half);
			_spawnHexVertices[2] = new Vector3(width, 0f, -half);
			_spawnHexVertices[3] = new Vector3(0f, 0f, -hexSize);
			_spawnHexVertices[4] = new Vector3(-width, 0f, -half);
			_spawnHexVertices[5] = new Vector3(-width, 0f, half);
		}

		[Token(Token = "0x6001419")]
		[Address(RVA = "0x3DF4778", Offset = "0x3DF0778", VA = "0x3DF4778")]
		public bool CheckForBuilding(HexBehaviour aObject, bool isEnemy, int depth = 0)
		{
			return default;
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0x3DF4890", Offset = "0x3DF0890", VA = "0x3DF4890")]
		[AsyncStateMachine(typeof(_003CGetRoleTarget_003Ed__207))]
		private UniTask<List<GameObject>> GetRoleTarget(Transform t, bool isEnemy, int range, int count)
		{
			return default;
		}

		[Token(Token = "0x600141B")]
		[Address(RVA = "0x3DF495C", Offset = "0x3DF095C", VA = "0x3DF495C")]
		public List<Vector3> GetHexTargetPosNoThisFoot(Vector3 pos, int num)
		{
			return null;
		}

		[Token(Token = "0x600141C")]
		[Address(RVA = "0x3DF4E34", Offset = "0x3DF0E34", VA = "0x3DF4E34")]
		public List<HexBehaviour> GetSpecialNearHex()
		{
            if (specialHexPos.Count == 0) return null;
            var result = new List<HexBehaviour>();
            var openable = new List<HexBehaviour>();
            for (int i = 0; i < allEnemyStayOpenHexObjBehaviours.Count; i++)
                if (allEnemyStayOpenHexObjBehaviours[i].canOpen)
                    openable.Add(allEnemyStayOpenHexObjBehaviours[i]);
            for (int i = 0; i < specialHexPos.Count; i++)
            {
                Vector3 position = specialHexPos[i];
                var distances = new List<ValueTuple<float, HexBehaviour>>(openable.Count);
                for (int j = 0; j < openable.Count; j++)
                    distances.Add(new ValueTuple<float, HexBehaviour>(Vector3.Distance(position, openable[j].transform.position), openable[j]));
                distances.Sort(_003C_003Ec._003C_003E9__209_0 ??
                    (_003C_003Ec._003C_003E9__209_0 = _003C_003Ec._003C_003E9._003CGetSpecialNearHex_003Eb__209_0));
                if (distances.Count > 0)
                {
                    HexBehaviour nearest = distances[0].Item2;
                    if (!result.Contains(nearest)) result.Add(nearest);
                }
            }
            return result;
        }

		[Token(Token = "0x600141D")]
		[Address(RVA = "0x3DF5394", Offset = "0x3DF1394", VA = "0x3DF5394")]
		public HexBehaviour GetMainTowerForwardHex(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x600141E")]
		[Address(RVA = "0x3DF5494", Offset = "0x3DF1494", VA = "0x3DF5494")]
		private HexBehaviour FindTopMostObject(HexBehaviour start, bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x600141F")]
		[Address(RVA = "0x3DF53C8", Offset = "0x3DF13C8", VA = "0x3DF53C8")]
		private HexBehaviour GetDesignatedKeyHex(string hexKey)
		{
			return null;
		}

		[Token(Token = "0x6001420")]
		[Address(RVA = "0x3DECD8C", Offset = "0x3DE8D8C", VA = "0x3DECD8C")]
		public HexManager.HexCoord? GetMainTowerHexCoord(bool isEnemy)
		{
			return null;
		}

		[Token(Token = "0x6001421")]
		[Address(RVA = "0x3DF556C", Offset = "0x3DF156C", VA = "0x3DF556C")]
		[AsyncStateMachine(typeof(_003CHideAllRole_003Ed__214))]
		private void HideAllRole()
		{
            _003CHideAllRole_003Ed__214 stateMachine = default;
            stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6001422")]
		[Address(RVA = "0x3DF55FC", Offset = "0x3DF15FC", VA = "0x3DF55FC")]
		private void DestroyAllROle()
		{
            DestroyRoleList(allPlayerRoleBehaviour);
            DestroyRoleList(allEnemyRoleBehaviour);
            allPlayerRoleBehaviour.Clear();
            allEnemyRoleBehaviour.Clear();
        }

		[Token(Token = "0x6001423")]
		[Address(RVA = "0x3DF56A8", Offset = "0x3DF16A8", VA = "0x3DF56A8")]
		private void DestroyRoleList(List<RoleBehaviour> roleList)
		{
            global::AssetsModule.PoolObjBase poolObjBase = null;
            for (int i = roleList.Count - 1; i >= 0; i--)
            {
                RoleBehaviour role = roleList[i];
                if (role != null)
                {
                    var poolManager = global::AssetsModule.ObjPoolManager.Instance;
                    if (poolManager.IsBattlePersistentPool(role.gameObject.name) && role.TryGetComponent(out poolObjBase))
                        role.RecycleOnBattleEnd();
                    else
                        UnityEngine.Object.Destroy(role.gameObject);
                }
            }
        }

		[Token(Token = "0x6001424")]
		[Address(RVA = "0x3DEAFB0", Offset = "0x3DE6FB0", VA = "0x3DEAFB0")]
		[AsyncStateMachine(typeof(_003CSettlementAnimation_003Ed__217))]
		public void SettlementAnimation(bool isVictory)
		{
            _003CSettlementAnimation_003Ed__217 stateMachine = default;
            stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine.isVictory = isVictory;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6001425")]
		[Address(RVA = "0x3DF5838", Offset = "0x3DF1838", VA = "0x3DF5838")]
		public bool IsLoneUnit(bool isEnemy, EntityBase units)
		{
			return default;
		}

		[Token(Token = "0x6001426")]
		[Address(RVA = "0x3DF5B50", Offset = "0x3DF1B50", VA = "0x3DF5B50")]
		public void RecordPlayerMainTowerKey(string key)
		{
		}

		[Token(Token = "0x6001427")]
		[Address(RVA = "0x3DF5B58", Offset = "0x3DF1B58", VA = "0x3DF5B58")]
		public void RecordEnemyMainTowerKey(string key)
		{
		}

		[Token(Token = "0x6001428")]
		[Address(RVA = "0x3DF5B60", Offset = "0x3DF1B60", VA = "0x3DF5B60")]
		public void RecoredSpecialHex(Vector3 pos)
		{
            specialHexPos.Add(pos);
        }

		[Token(Token = "0x6001429")]
		[Address(RVA = "0x3DF5C34", Offset = "0x3DF1C34", VA = "0x3DF5C34")]
		public void RemoveSpecialHex(Vector3 pos)
		{
            specialHexPos.Remove(pos);
        }

		[Token(Token = "0x600142A")]
		[Address(RVA = "0x3DF5CAC", Offset = "0x3DF1CAC", VA = "0x3DF5CAC")]
		[AsyncStateMachine(typeof(_003CEndGame_003Ed__223))]
		public void EndGame()
		{
            _003CEndGame_003Ed__223 sm = default;
            sm._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
            sm._003C_003E4__this = this;
            sm._003C_003E1__state = -1;
            sm._003C_003Et__builder.Start(ref sm);
        }

		[Token(Token = "0x600142B")]
		[Address(RVA = "0x3DF5D3C", Offset = "0x3DF1D3C", VA = "0x3DF5D3C")]
		public void RecordPlayerOpenHexCount()
		{ playerOpenHexCount = unchecked(playerOpenHexCount + 1); }

		[Token(Token = "0x600142C")]
		[Address(RVA = "0x3DF5D4C", Offset = "0x3DF1D4C", VA = "0x3DF5D4C")]
		public void AddPlayerStayHex(GameObject obj)
		{
			allPlayerStayOpenHexObj.Add(obj);
		}

		[Token(Token = "0x600142D")]
		[Address(RVA = "0x3DF5DF0", Offset = "0x3DF1DF0", VA = "0x3DF5DF0")]
		public void AddEnemyStayHex(GameObject obj)
		{
			allEnemyStayOpenHexObj.Add(obj);
			allEnemyStayOpenHexObjBehaviours.Add(obj.GetComponent<HexBehaviour>());
		}

		[Token(Token = "0x600142E")]
		[Address(RVA = "0x3DF5F28", Offset = "0x3DF1F28", VA = "0x3DF5F28")]
		public void RemovePlayerStayHex(GameObject obj)
		{
			allPlayerStayOpenHexObj.Remove(obj);
		}

		[Token(Token = "0x600142F")]
		[Address(RVA = "0x3DF5F80", Offset = "0x3DF1F80", VA = "0x3DF5F80")]
		public void RemoveEnemyStayHex(GameObject obj)
		{
			allEnemyStayOpenHexObj.Remove(obj);
			allEnemyStayOpenHexObjBehaviours.Remove(obj.GetComponent<HexBehaviour>());
		}

		[Token(Token = "0x6001430")]
		[Address(RVA = "0x3DF6028", Offset = "0x3DF2028", VA = "0x3DF6028")]
		public void AddPlayerHasHex(GameObject obj)
		{
			allPlayerHasOpenHexObj.Add(obj);
		}

		[Token(Token = "0x6001431")]
		[Address(RVA = "0x3DF60CC", Offset = "0x3DF20CC", VA = "0x3DF60CC")]
		public void AddEnemyHasHex(GameObject obj)
		{
			allEnemyHasOpenHexObj.Add(obj);
		}

		[Token(Token = "0x6001432")]
		[Address(RVA = "0x3DF6170", Offset = "0x3DF2170", VA = "0x3DF6170")]
		public void RemovePlayerHasHex(GameObject obj)
		{
			allPlayerHasOpenHexObj.Remove(obj);
		}

		[Token(Token = "0x6001433")]
		[Address(RVA = "0x3DF61C8", Offset = "0x3DF21C8", VA = "0x3DF61C8")]
		public void RemoveEnemyHasHex(GameObject obj)
		{
			allEnemyHasOpenHexObj.Remove(obj);
		}

		[Token(Token = "0x6001434")]
		[Address(RVA = "0x3DF6220", Offset = "0x3DF2220", VA = "0x3DF6220")]
		public void AddPlayerArchitecture(GameObject obj)
		{
			allPlayerArchitectureObj.Add(obj);
			obj.transform.SetParent(_playerArchitectureRoot.transform, false);
			MarkWebGLNavigationTargetFieldDirty(false);
		}

		[Token(Token = "0x6001435")]
		[Address(RVA = "0x3DF6308", Offset = "0x3DF2308", VA = "0x3DF6308")]
		public void AddEnemyArchitecture(GameObject obj)
		{
			allEnemyArchitectureObj.Add(obj);
			obj.transform.SetParent(_enemyArchitectureRoot.transform, false);
			MarkWebGLNavigationTargetFieldDirty(true);
		}

		[Token(Token = "0x6001436")]
		[Address(RVA = "0x3DF63F0", Offset = "0x3DF23F0", VA = "0x3DF63F0")]
		public void RemovePlayerArchitecture(GameObject obj)
		{
			allPlayerArchitectureObj.Remove(obj);
			MarkWebGLNavigationTargetFieldDirty(false);
		}

		[Token(Token = "0x6001437")]
		[Address(RVA = "0x3DF6454", Offset = "0x3DF2454", VA = "0x3DF6454")]
		public void RemoveEnemyArchitecture(GameObject obj)
		{
			allEnemyArchitectureObj.Remove(obj);
			MarkWebGLNavigationTargetFieldDirty(true);
		}

		[Token(Token = "0x6001438")]
		[Address(RVA = "0x3DF64B8", Offset = "0x3DF24B8", VA = "0x3DF64B8")]
		public void AddPlayerRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false)
		{
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit && _playerRoleCount >= MAX_ROLE_COUNT)
			{
			    UnityEngine.Debug.LogWarning(string.Format("尝试创建超过上限的单位！当前计数: {0}, 上限: {1}", _playerRoleCount, MAX_ROLE_COUNT));
			    return;
			}
			allPlayerRoleObj.Add(obj);
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allPlayerRoleBehaviour.Add(role);
			allRoleBehaviour.Add(role);
			WebGLNavigationManager.TryRegisterRole(role);
			if (isFake) return;
			_currentRoleInstanceID = unchecked(_currentRoleInstanceID + 1);
			role._instanceID = _currentRoleInstanceID;
			if (RoleShadowManager.Instance != null) RoleShadowManager.Instance.Bind(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit)
			{
			    if (_playerReservedCount > 0) _playerReservedCount = unchecked(_playerReservedCount - 1);
			    _playerRoleCount = Mathf.Min(unchecked(_playerRoleCount + 1), MAX_ROLE_COUNT);
			    global::EventModule.EventManager.Instance.TriggerEvent("PlayerRoleCountChange", _playerRoleCount);
			    role._isCountedInRoleLimit = true;
			}
			global::EventModule.EventManager.Instance.TriggerEvent("HasPlayerRoleCreat", role);
			obj.transform.SetParent(_playerRoleRoot.transform, false);
			if (BattleGameManager.Instance != null) BattleGameManager.Instance.TryApplyPauseToNewRole(obj);
		}

		[Token(Token = "0x6001439")]
		[Address(RVA = "0x3DF69A0", Offset = "0x3DF29A0", VA = "0x3DF69A0")]
		public void AddEnemyRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false)
		{
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit && _enemyRoleCount >= MAX_ROLE_COUNT)
			{
			    UnityEngine.Debug.LogWarning(string.Format("尝试创建超过上限的单位！当前计数: {0}, 上限: {1}", _enemyRoleCount, MAX_ROLE_COUNT));
			    return;
			}
			allEnemyRoleObj.Add(obj);
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allEnemyRoleBehaviour.Add(role);
			allRoleBehaviour.Add(role);
			WebGLNavigationManager.TryRegisterRole(role);
			if (isFake) return;
			_currentRoleInstanceID = unchecked(_currentRoleInstanceID + 1);
			role._instanceID = _currentRoleInstanceID;
			if (RoleShadowManager.Instance != null) RoleShadowManager.Instance.Bind(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit)
			{
			    if (_enemyReservedCount > 0) _enemyReservedCount = unchecked(_enemyReservedCount - 1);
			    _enemyRoleCount = Mathf.Min(unchecked(_enemyRoleCount + 1), MAX_ROLE_COUNT);
			    global::EventModule.EventManager.Instance.TriggerEvent("EnemyRoleCountChange", _enemyRoleCount);
			    role._isCountedInRoleLimit = true;
			}
			global::EventModule.EventManager.Instance.TriggerEvent("HasEnemyRoleCreat", role);
			obj.transform.SetParent(_enemyRoleRoot.transform, false);
			if (BattleGameManager.Instance != null) BattleGameManager.Instance.TryApplyPauseToNewRole(obj);
		}

		[Token(Token = "0x600143A")]
		[Address(RVA = "0x3DF6E88", Offset = "0x3DF2E88", VA = "0x3DF6E88")]
		public void RemovePlayerRole(GameObject obj, bool triggerTrySpawn = true)
		{
			if (!allPlayerRoleObj.Contains(obj)) return;
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allPlayerRoleObj.Remove(obj);
			allPlayerRoleBehaviour.Remove(role);
			allRoleBehaviour.Remove(role);
			WebGLNavigationManager.TryUnregisterRole(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && role != null && role._isCountedInRoleLimit && triggerTrySpawn)
			{
			    _playerRoleCount = Mathf.Max(0, unchecked(_playerRoleCount - 1));
			    global::EventModule.EventManager.Instance.TriggerEvent("PlayerRoleCountChange", _playerRoleCount);
			    TrySpawnFromWaitingBarracks(false);
			}
		}

		[Token(Token = "0x600143B")]
		[Address(RVA = "0x3DF7B40", Offset = "0x3DF3B40", VA = "0x3DF7B40")]
		public void RemoveEnemyRole(GameObject obj, bool triggerTrySpawn = true)
		{
			if (!allEnemyRoleObj.Contains(obj)) return;
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allEnemyRoleObj.Remove(obj);
			allEnemyRoleBehaviour.Remove(role);
			allRoleBehaviour.Remove(role);
			WebGLNavigationManager.TryUnregisterRole(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && role != null && role._isCountedInRoleLimit && triggerTrySpawn)
			{
			    _enemyRoleCount = Mathf.Max(0, unchecked(_enemyRoleCount - 1));
			    global::EventModule.EventManager.Instance.TriggerEvent("EnemyRoleCountChange", _enemyRoleCount);
			    TrySpawnFromWaitingBarracks(true);
			}
		}

		[Token(Token = "0x600143C")]
		[Address(RVA = "0x3DF7D78", Offset = "0x3DF3D78", VA = "0x3DF7D78")]
		public void RegisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
			if (!waiting.Contains(barracks)) waiting.Add(barracks);
		}

		[Token(Token = "0x600143D")]
		[Address(RVA = "0x3DF7EB8", Offset = "0x3DF3EB8", VA = "0x3DF7EB8")]
		public void UnregisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			(isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks).Remove(barracks);
		}

		[Token(Token = "0x600143E")]
		[Address(RVA = "0x3DF70C0", Offset = "0x3DF30C0", VA = "0x3DF70C0")]
		private void TrySpawnFromWaitingBarracks(bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
			if (waiting.Count == 0 || !CanSpawnRole(isEnemy)) return;
			for (int i = waiting.Count - 1; i >= 0; i--)
			    if (waiting[i] == null || waiting[i].isDead) waiting.RemoveAt(i);
			if (waiting.Count == 0) return;
			List<BarracksArchitectureBehaviour> legendary = new List<BarracksArchitectureBehaviour>();
			List<BarracksArchitectureBehaviour> ordinary = new List<BarracksArchitectureBehaviour>();
			foreach (BarracksArchitectureBehaviour barracks in waiting)
			    if (barracks.IsLegendaryBarracks()) legendary.Add(barracks); else ordinary.Add(barracks);
			if (legendary.Count > 0)
			{
			    Dictionary<string, List<BarracksArchitectureBehaviour>> groups = new Dictionary<string, List<BarracksArchitectureBehaviour>>();
			    foreach (BarracksArchitectureBehaviour barracks in legendary)
			    {
			        string id = barracks.GetCreatRoleID();
			        if (string.IsNullOrEmpty(id)) continue;
			        if (!groups.ContainsKey(id)) groups[id] = new List<BarracksArchitectureBehaviour>();
			        groups[id].Add(barracks);
			    }
			    foreach (KeyValuePair<string, List<BarracksArchitectureBehaviour>> group in groups)
			    {
			        if (!CanSpawnLegendaryUnit(group.Key, isEnemy)) continue;
			        BarracksArchitectureBehaviour best = null;
			        int bestRareLevel = -1;
			        foreach (BarracksArchitectureBehaviour barracks in group.Value)
			        {
			            int rareLevel = barracks.GetRareLevelValue();
			            if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
			        }
			        if (best != null)
			        {
			            waiting.Remove(best);
			            best.OnCanSpawnRole();
			            return;
			        }
			    }
			}
			if (ordinary.Count > 0)
			{
			    BarracksArchitectureBehaviour best = null;
			    int bestRareLevel = -1;
			    foreach (BarracksArchitectureBehaviour barracks in ordinary)
			    {
			        int rareLevel = barracks.GetRareLevelValue();
			        if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
			    }
			    if (best != null) { waiting.Remove(best); best.OnCanSpawnRole(); }
			}
		}

		[Token(Token = "0x600143F")]
		[Address(RVA = "0x3DF8054", Offset = "0x3DF4054", VA = "0x3DF8054")]
		private void TrySpawnLegendaryFromWaitingBarracks(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
			if (waiting.Count == 0 || !CanSpawnLegendaryUnit(roleID, isEnemy) || !CanSpawnRole(isEnemy)) return;
			for (int i = waiting.Count - 1; i >= 0; i--)
			    if (waiting[i] == null || waiting[i].isDead) waiting.RemoveAt(i);
			if (waiting.Count == 0) return;
			BarracksArchitectureBehaviour best = null;
			int bestRareLevel = -1;
			foreach (BarracksArchitectureBehaviour barracks in waiting)
			{
			    if (!barracks.IsLegendaryBarracks() || barracks.GetCreatRoleID() != roleID) continue;
			    int rareLevel = barracks.GetRareLevelValue();
			    if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
			}
			if (best != null) { waiting.Remove(best); best.OnCanSpawnRole(); }
		}

		[Token(Token = "0x6001440")]
		[Address(RVA = "0x3DF83D8", Offset = "0x3DF43D8", VA = "0x3DF83D8")]
		public void AddLegendaryBarracks(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			counts[roleID] = counts.ContainsKey(roleID) ? unchecked(counts[roleID] + 1) : 1;
		}

		[Token(Token = "0x6001441")]
		[Address(RVA = "0x3DF8508", Offset = "0x3DF4508", VA = "0x3DF8508")]
		public void RemoveLegendaryBarracks(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			if (!counts.ContainsKey(roleID)) return;
			counts[roleID] = Mathf.Max(0, unchecked(counts[roleID] - 1));
			if (counts[roleID] == 0) counts.Remove(roleID);
		}

		[Token(Token = "0x6001442")]
		[Address(RVA = "0x3DF866C", Offset = "0x3DF466C", VA = "0x3DF866C")]
		public void AddLegendaryUnit(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			counts[roleID] = counts.ContainsKey(roleID) ? unchecked(counts[roleID] + 1) : 1;
		}

		[Token(Token = "0x6001443")]
		[Address(RVA = "0x3DF879C", Offset = "0x3DF479C", VA = "0x3DF879C")]
		public void RemoveLegendaryUnit(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			if (!counts.ContainsKey(roleID)) return;
			counts[roleID] = Mathf.Max(0, unchecked(counts[roleID] - 1));
			if (counts[roleID] == 0) counts.Remove(roleID);
			TrySpawnLegendaryFromWaitingBarracks(roleID, isEnemy);
		}

		[Token(Token = "0x6001444")]
		[Address(RVA = "0x3DF8910", Offset = "0x3DF4910", VA = "0x3DF8910")]
		public int GetLegendaryUnitCount(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return 0;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			return counts.ContainsKey(roleID) ? counts[roleID] : 0;
		}

		[Token(Token = "0x6001445")]
		[Address(RVA = "0x3DF8A14", Offset = "0x3DF4A14", VA = "0x3DF8A14")]
		public int GetLegendaryBarracksCount(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return 0;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			return counts.ContainsKey(roleID) ? counts[roleID] : 0;
		}

		[Token(Token = "0x6001446")]
		[Address(RVA = "0x3DF7F8C", Offset = "0x3DF3F8C", VA = "0x3DF7F8C")]
		public bool CanSpawnLegendaryUnit(string roleID, bool isEnemy)
		{
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
			return GetLegendaryUnitCount(roleID, isEnemy) < GetLegendaryBarracksCount(roleID, isEnemy);
		}

		[Token(Token = "0x6001447")]
		[Address(RVA = "0x3DF8B18", Offset = "0x3DF4B18", VA = "0x3DF8B18")]
		public void CharmRecordChange()
		{
		}

		[Token(Token = "0x6001448")]
		[Address(RVA = "0x3DF8B1C", Offset = "0x3DF4B1C", VA = "0x3DF8B1C")]
		public void AddArchitectureBehaviour(ArchitectureBehaviour obj)
		{
			allArchitectureBehaviours.Add(obj);
			if (obj.isEnemy)
			    allEnemyArchitectureBehaviours.Add(obj);
			else
			    allPlayerArchitectureBehaviours.Add(obj);
			MarkWebGLNavigationTargetFieldDirty(obj.isEnemy);
		}

		[Token(Token = "0x6001449")]
		[Address(RVA = "0x3DF8C34", Offset = "0x3DF4C34", VA = "0x3DF8C34")]
		public void RemoveArchitectureBehaviour(ArchitectureBehaviour obj)
		{
			allArchitectureBehaviours.Remove(obj);
			if (obj.isEnemy)
			    allEnemyArchitectureBehaviours.Remove(obj);
			else
			    allPlayerArchitectureBehaviours.Remove(obj);
			MarkWebGLNavigationTargetFieldDirty(obj.isEnemy);
		}

		[Token(Token = "0x600144A")]
		[Address(RVA = "0x3DF8CC0", Offset = "0x3DF4CC0", VA = "0x3DF8CC0")]
		public void AddHellfire(HellfireBehaviour hellfire)
		{
            if (hellfire != null && !allHellfireBehaviours.Contains(hellfire))
                allHellfireBehaviours.Add(hellfire);
        }

		[Token(Token = "0x600144B")]
		[Address(RVA = "0x3DF8DD4", Offset = "0x3DF4DD4", VA = "0x3DF8DD4")]
		public void RemoveHellfire(HellfireBehaviour hellfire)
		{
            if (hellfire != null && allHellfireBehaviours.Contains(hellfire))
                allHellfireBehaviours.Remove(hellfire);
        }

		[Token(Token = "0x600144C")]
		[Address(RVA = "0x3DF8EA8", Offset = "0x3DF4EA8", VA = "0x3DF8EA8")]
		public void AddHex(GameObject obj)
		{
			allHexObj.Add(obj);
		}

		[Token(Token = "0x600144D")]
		[Address(RVA = "0x3DF8F4C", Offset = "0x3DF4F4C", VA = "0x3DF8F4C")]
		public void RecordWaterPlane(GameObject obj)
		{
			_waterPlane = obj;
		}

		[Token(Token = "0x600144E")]
		[Address(RVA = "0x3DF8F54", Offset = "0x3DF4F54", VA = "0x3DF8F54")]
		public void RecordGroundPlane(GameObject obj)
		{
			_groundPlane = obj;
		}

		[Token(Token = "0x600144F")]
		[Address(RVA = "0x3DF8F5C", Offset = "0x3DF4F5C", VA = "0x3DF8F5C")]
		public void SetDestroyObjParent(GameObject obj)
		{
            obj.transform.SetParent(_destroyObjRoot.transform, false);
        }

		[Token(Token = "0x6001450")]
		[Address(RVA = "0x3DF8FAC", Offset = "0x3DF4FAC", VA = "0x3DF8FAC")]
		public void AddOneNeedDestroyPoolPrefabOnEndGame(GameObject prefab)
		{ if (!needDestroyPoolPrefabOnEndGame.Contains(prefab)) needDestroyPoolPrefabOnEndGame.Add(prefab); }

		[Token(Token = "0x6001451")]
		[Address(RVA = "0x3DF907C", Offset = "0x3DF507C", VA = "0x3DF907C")]
		public GameObject GetPlayerArchitectureRoot()
		{
			return _playerArchitectureRoot;
		}

		[Token(Token = "0x6001452")]
		[Address(RVA = "0x3DF9084", Offset = "0x3DF5084", VA = "0x3DF9084")]
		public GameObject GetEnemyArchitectureRoot()
		{
			return _enemyArchitectureRoot;
		}

		[Token(Token = "0x6001453")]
		[Address(RVA = "0x3DF908C", Offset = "0x3DF508C", VA = "0x3DF908C")]
		public GameObject GetSpecialHexRoot()
		{
			return _specialHexRoot;
		}

		[Token(Token = "0x6001454")]
		[Address(RVA = "0x3DF9094", Offset = "0x3DF5094", VA = "0x3DF9094")]
		public void HideSpecialHexRootImmediately()
		{
		}

		[Token(Token = "0x6001455")]
		[Address(RVA = "0x3DF911C", Offset = "0x3DF511C", VA = "0x3DF911C")]
		public void AddSpecialHexObject(GameObject obj)
		{
		}

		[Token(Token = "0x6001456")]
		[Address(RVA = "0x3DF9248", Offset = "0x3DF5248", VA = "0x3DF9248")]
		public BattleGameSceneManager()
		{
		}
	
        [Serializable]
        [CompilerGenerated]
        [Token(Token = "0x2000427")]
        private sealed class _003C_003Ec
        {
            [Token(Token = "0x4002990")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            [Token(Token = "0x4002991")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
            public static Comparison<ValueTuple<float, HexBehaviour>> _003C_003E9__209_0;
            [Token(Token = "0x600145E")]
            [Address(RVA = "0x3DF97EC", Offset = "0x3DF57EC", VA = "0x3DF97EC")]
            public _003C_003Ec() { }
            [Token(Token = "0x600145F")]
            [Address(RVA = "0x3DF97F4", Offset = "0x3DF57F4", VA = "0x3DF97F4")]
            internal int _003CGetSpecialNearHex_003Eb__209_0(ValueTuple<float, HexBehaviour> left, ValueTuple<float, HexBehaviour> right)
            {
                return left.Item1.CompareTo(right.Item1);
            }
        }
}
}
