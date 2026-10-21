using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using Pathfinding;
using QuickTutor;
using TMPro;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000295")]
	public class HexBehaviour : MonoBehaviour, ITutorialClick
	{
		[Token(Token = "0x2000298")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass132_0
		{
			[Token(Token = "0x40020D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject _rolePrefabRes;

			[Token(Token = "0x40020D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Vector3> allPos;

			[Token(Token = "0x40020D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalRoleInfo _roleInfo;

			[Token(Token = "0x40020D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int CardLevel;

			[Token(Token = "0x40020D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path2;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x442BEFC", Offset = "0x4427EFC", VA = "0x442BEFC")]
			public _003C_003Ec__DisplayClass132_0()
			{
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x442BF04", Offset = "0x4427F04", VA = "0x442BF04")]
			internal bool _003CCreatSoldierPile_003Eb__0(GlobalRoleInfo x)
			{
		    return x.id == _003C_003E4__this._info.roleID;
		}
		}

		[Token(Token = "0x2000299")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass132_1
		{
			[Token(Token = "0x40020D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x40020D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass132_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x442BF34", Offset = "0x4427F34", VA = "0x442BF34")]
			public _003C_003Ec__DisplayClass132_1()
			{
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x442BF3C", Offset = "0x4427F3C", VA = "0x442BF3C")]
			internal void _003CCreatSoldierPile_003Eb__1()
			{
		    if (!CoreGameManager.Gaming) return;
		    _003C_003Ec__DisplayClass132_0 context = CS_0024_003C_003E8__locals1;
		    GameObject obj = AssetsModule.ObjPoolManager.Instance.GetFromPool(context._rolePrefabRes, -1f, true, 3);
		    obj.transform.position = context.allPos[index];
		    obj.transform.rotation = Quaternion.identity;
		    obj.gameObject.SetActive(false);
		    RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
		    HexBehaviour hex = context._003C_003E4__this;
		    GlobalHeroCardInfo card = DataManager.Instance.GlobalInfo.heroCardDic[hex._id];
		    CardFettersType fetters = (CardFettersType)ToolModule.StringTool.ToInt(card.cardFetters);
		    card = DataManager.Instance.GlobalInfo.heroCardDic[hex._id];
		    AtkWayType attackWay = (AtkWayType)ToolModule.StringTool.ToInt(card.atkType);
		    role.Init(context._roleInfo, hex.isEnemyHex, context.CardLevel, hex.rareLevel, hex._id, fetters, attackWay);
		    if (hex.isEnemyHex) BattleGameSceneManager.Instance.AddEnemyRole(obj, false, false);
		    else BattleGameSceneManager.Instance.AddPlayerRole(obj, false, false);
		    if (CheatControl.DisableSpawnEffect) return;
		    AssetsModule.EffectManager.Instance.ShowEffect(context.path2, context.allPos[index], Vector3.zero, 1f);
		}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029A")]
		[CompilerGenerated]
		private struct _003CArchitectureDeadCallBack_003Ed__133 : IAsyncStateMachine
		{
			[Token(Token = "0x40020D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x442C34C", Offset = "0x442834C", VA = "0x442C34C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                HexBehaviour self = _003C_003E4__this;
                try
                {
                    UniTask<GameObject>.Awaiter awaiter;
                    if (_003C_003E1__state != 0)
                    {
                        self.hasArchitecture = false;
                        self.isDestroy = true;
                        bool season = BattleGameSceneManager.Instance.isSeasonPVP_BTest;
                        MeshRenderer renderer = self.transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer>();
                        if (self.isEnemyHex)
                        {
                            renderer.material = global::AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(false, self.key, season);
                            self.isEnemyHex = false;
                            BattleGameSceneManager.Instance.RemoveEnemyHasHex(self.gameObject);
                            BattleGameSceneManager.Instance.AddPlayerHasHex(self.gameObject);
                        }
                        else
                        {
                            renderer.material = global::AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(true, self.key, season);
                            self.isEnemyHex = true;
                            BattleGameSceneManager.Instance.RemovePlayerHasHex(self.gameObject);
                            BattleGameSceneManager.Instance.AddEnemyHasHex(self.gameObject);
                        }
                        SubGameBuffManager.Instance.NotifyHexOwnershipChanged(self);
                        self.DestroyWall(self.leftUpWall, true);
                        self.DestroyWall(self.rightUpWall, true);
                        self.DestroyWall(self.upWall, true);
                        self.DestroyWall(self.downWall, true);
                        self.DestroyWall(self.leftDownWall, true);
                        self.DestroyWall(self.rightDownWall, true);
                        UnityEngine.Object.Destroy(self._obj);
                        self._obj = null;
                        global::AssetsModule.EffectManager.Instance.ShowEffect("Assets/_Res/Addressable/EffectsBundle/Effects/ArchitectureExplosion.prefab",
                            new Vector3(self.transform.position.x, 0f, self.transform.position.z), default, 1f);
                        awaiter = global::AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Build/Build_Destory.prefab").GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    GameObject prefab = awaiter.GetResult();
                    self._obj = UnityEngine.Object.Instantiate(prefab, new Vector3(self.transform.position.x, 0f, self.transform.position.z), Quaternion.identity);
                    BattleGameSceneManager.Instance.SetDestroyObjParent(self._obj);
                    global::EventModule.EventManager.Instance.StopListening("CraetHexEnd", self.UpdateHexItemUIEvent);
                    global::EventModule.EventManager.Instance.StopListening("HasHexOpen", self.UpdateHexItemUIEvent);
                    global::EventModule.EventManager.Instance.StopListening("UpdateHexItemUI", self.UpdateHexItemUIEvent);
                    global::EventModule.EventManager.Instance.StopListening("CraetHexEnd", self.CheckCanOpen);
                    global::EventModule.EventManager.Instance.StopListening("HasHexOpen", self.CheckCanOpen);
                    global::EventModule.EventManager.Instance.StopListening("HasHexOpen", self.CreatWallJudge);
                    global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", self.CreatWallJudge);
                    global::EventModule.EventManager.Instance.StopListening("CraetHexEndCreatMainTower", self.CreatMainTower);
                    global::EventModule.EventManager.Instance.StopListening("PlayerCoinChange", self.UpdateCoinColorEvent);
                    global::EventModule.EventManager.Instance.StopListening("HasHexOpen", self.HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
                    global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", self.HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
                    global::EventModule.EventManager.Instance.StopListening("HasHexOpen", self.CheckGraphUpdateScene);
                    global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", self.CheckGraphUpdateScene);
                    global::EventModule.EventManager.Instance.StopListening("HasWallDestroy", self.UpdateAllWallState);
                    self.RemoveFromDirtyHexUIBatches();
                    global::EventModule.EventManager.Instance.TriggerEvent("HasHexDestroy", self);
                    global::EventModule.EventManager.Instance.TriggerEvent("BothHexCountChange");
                    global::EventModule.EventManager.Instance.TriggerEvent("UpdateHexItemUI");
                }
                catch (Exception exception)
                {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                    return;
                }
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetResult();
            }

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x442D1F4", Offset = "0x44291F4", VA = "0x442D1F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029B")]
		[CompilerGenerated]
		private struct _003CCreatMainTower_003Ed__120 : IAsyncStateMachine
		{
			[Token(Token = "0x40020DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x442D200", Offset = "0x4429200", VA = "0x442D200", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x442E0B8", Offset = "0x442A0B8", VA = "0x442E0B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029C")]
		[CompilerGenerated]
		private struct _003CCreatShowUIObj_003Ed__137 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x442E0C4", Offset = "0x442A0C4", VA = "0x442E0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x442E3AC", Offset = "0x442A3AC", VA = "0x442E3AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029D")]
		[CompilerGenerated]
		private struct _003CCreatShowUIObjInternalAsync_003Ed__138 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x442E3B8", Offset = "0x442A3B8", VA = "0x442E3B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x442F270", Offset = "0x442B270", VA = "0x442F270", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029E")]
		[CompilerGenerated]
		private struct _003CCreatSoldierPile_003Ed__132 : IAsyncStateMachine
		{
			[Token(Token = "0x40020E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass132_0 _003C_003E8__1;

			[Token(Token = "0x40020EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass132_1 _003C_003E8__2;

			[Token(Token = "0x40020ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003Cnum_003E5__2;

			[Token(Token = "0x40020EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string _003Cpath_003E5__3;

			[Token(Token = "0x40020EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GameObject _003CeffectRes_003E5__4;

			[Token(Token = "0x40020F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40020F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x40020F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x442F27C", Offset = "0x442B27C", VA = "0x442F27C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x44300E4", Offset = "0x442C0E4", VA = "0x44300E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200029F")]
		[CompilerGenerated]
		private struct _003CCreatUIObj_003Ed__135 : IAsyncStateMachine
		{
			[Token(Token = "0x40020F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x44300F0", Offset = "0x442C0F0", VA = "0x44300F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x44303D8", Offset = "0x442C3D8", VA = "0x44303D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A0")]
		[CompilerGenerated]
		private struct _003CCreatUIObjInternalAsync_003Ed__136 : IAsyncStateMachine
		{
			[Token(Token = "0x40020F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x44303E4", Offset = "0x442C3E4", VA = "0x44303E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x4430F40", Offset = "0x442CF40", VA = "0x4430F40", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A1")]
		[CompilerGenerated]
		private struct _003CEncroachmentEnemy_003Ed__169 : IAsyncStateMachine
		{
			[Token(Token = "0x40020FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40020FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40020FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x40020FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x4430F4C", Offset = "0x442CF4C", VA = "0x4430F4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x4432144", Offset = "0x442E144", VA = "0x4432144", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A2")]
		[CompilerGenerated]
		private struct _003CEncroachmentPlayer_003Ed__173 : IAsyncStateMachine
		{
			[Token(Token = "0x40020FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x4432150", Offset = "0x442E150", VA = "0x4432150", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x443302C", Offset = "0x442F02C", VA = "0x443302C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A3")]
		[CompilerGenerated]
		private struct _003CFlushDirtyHexUIAsync_003Ed__126 : IAsyncStateMachine
		{
			[Token(Token = "0x4002103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x4433038", Offset = "0x442F038", VA = "0x4433038", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x4433924", Offset = "0x442F924", VA = "0x4433924", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A4")]
		[CompilerGenerated]
		private struct _003CHandleOnComplete_003Ed__131 : IAsyncStateMachine
		{
			[Token(Token = "0x4002106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400210A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x4433930", Offset = "0x442F930", VA = "0x4433930", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x44353F0", Offset = "0x44313F0", VA = "0x44353F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A5")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x400210B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400210C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400210D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400210E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x400210F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemyHex;

			[Token(Token = "0x4002110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quality _quality;

			[Token(Token = "0x4002111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool setOneStar;

			[Token(Token = "0x4002112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool setSoldier;

			[Token(Token = "0x4002113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			public bool setUnchart;

			[Token(Token = "0x4002114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
			public bool isNoGoldCard;

			[Token(Token = "0x4002115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool setDefense;

			[Token(Token = "0x4002116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			public bool setGoldMine;

			[Token(Token = "0x4002117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			private bool _003CapplySubGameQuestionMark_003E5__2;

			[Token(Token = "0x4002118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x44353FC", Offset = "0x44313FC", VA = "0x44353FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x44371E8", Offset = "0x44331E8", VA = "0x44371E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A6")]
		[CompilerGenerated]
		private struct _003CInitFixed_003Ed__90 : IAsyncStateMachine
		{
			[Token(Token = "0x4002119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400211A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400211B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400211C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x400211D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemyHex;

			[Token(Token = "0x400211E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quality _quality;

			[Token(Token = "0x400211F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public HexType hexType;

			[Token(Token = "0x4002120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string endTriggerEventId;

			[Token(Token = "0x4002121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string fixedCardId;

			[Token(Token = "0x4002122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x44371F4", Offset = "0x44331F4", VA = "0x44371F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x44389F0", Offset = "0x44349F0", VA = "0x44389F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A7")]
		[CompilerGenerated]
		private struct _003CLegendaryTileV1ApplyUiSequenceAsync_003Ed__86 : IAsyncStateMachine
		{
			[Token(Token = "0x4002123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x44389FC", Offset = "0x44349FC", VA = "0x44389FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x44391A8", Offset = "0x44351A8", VA = "0x44391A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A8")]
		[CompilerGenerated]
		private struct _003CLoadArchitectureRes_003Ed__99 : IAsyncStateMachine
		{
			[Token(Token = "0x4002128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400212A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400212B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CplayerPath_003E5__2;

			[Token(Token = "0x400212C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x44391B4", Offset = "0x44351B4", VA = "0x44391B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x4439DE4", Offset = "0x4435DE4", VA = "0x4439DE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002A9")]
		[CompilerGenerated]
		private struct _003CLoadShowIconRes_003Ed__101 : IAsyncStateMachine
		{
			[Token(Token = "0x400212D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400212E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400212F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x4439DF0", Offset = "0x4435DF0", VA = "0x4439DF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x443A8AC", Offset = "0x44368AC", VA = "0x443A8AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AA")]
		[CompilerGenerated]
		private struct _003CSetSpecialHex_003Ed__96 : IAsyncStateMachine
		{
			[Token(Token = "0x4002131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string key;

			[Token(Token = "0x4002135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x4002136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public SpecialHexType type;

			[Token(Token = "0x4002137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CouncilBoxType _003CboxType_003E5__2;

			[Token(Token = "0x4002138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x443A8B8", Offset = "0x44368B8", VA = "0x443A8B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x443C3D4", Offset = "0x44383D4", VA = "0x443C3D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AB")]
		[CompilerGenerated]
		private struct _003CSetToEnemy_003Ed__141 : IAsyncStateMachine
		{
			[Token(Token = "0x4002139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400213A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400213B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400213C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x443C3E0", Offset = "0x44383E0", VA = "0x443C3E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x443C858", Offset = "0x4438858", VA = "0x443C858", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AC")]
		[CompilerGenerated]
		private struct _003CSetToPlayer_003Ed__142 : IAsyncStateMachine
		{
			[Token(Token = "0x400213D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400213E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400213F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x443C864", Offset = "0x4438864", VA = "0x443C864", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x443CCDC", Offset = "0x4438CDC", VA = "0x443CCDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AD")]
		[CompilerGenerated]
		private struct _003CSpecialHexLogic_003Ed__140 : IAsyncStateMachine
		{
			[Token(Token = "0x4002141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x443CCE8", Offset = "0x4438CE8", VA = "0x443CCE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x443E4CC", Offset = "0x443A4CC", VA = "0x443E4CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AE")]
		[CompilerGenerated]
		private struct _003CTryApplyLegendaryTileHexGoldSurface_003Ed__87 : IAsyncStateMachine
		{
			[Token(Token = "0x4002145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x443E4D8", Offset = "0x443A4D8", VA = "0x443E4D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x443EAA4", Offset = "0x443AAA4", VA = "0x443EAA4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002AF")]
		[CompilerGenerated]
		private struct _003CUpdateHexItemUI_003Ed__146 : IAsyncStateMachine
		{
			[Token(Token = "0x4002149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400214A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400214B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x443EAB0", Offset = "0x443AAB0", VA = "0x443EAB0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x443F41C", Offset = "0x443B41C", VA = "0x443F41C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002B0")]
		[CompilerGenerated]
		private struct _003CUpdateHexState_003Ed__143 : IAsyncStateMachine
		{
			[Token(Token = "0x400214C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400214D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400214E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HexBehaviour _003C_003E4__this;

			[Token(Token = "0x400214F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HexBehaviour neighbor;

			[Token(Token = "0x4002150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x443F428", Offset = "0x443B428", VA = "0x443F428", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x443F980", Offset = "0x443B980", VA = "0x443F980", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400207A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HexManager.HexCoord HexCoord;

		[Token(Token = "0x400207B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int coordQ;

		[Token(Token = "0x400207C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int coordR;

		[Token(Token = "0x400207D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<int> _characterIds;

		[Token(Token = "0x400207E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly HashSet<HexBehaviour> DirtyCoinColorHexes = new HashSet<HexBehaviour>();

		[Token(Token = "0x400207F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly HashSet<HexBehaviour> DirtyHexItemUIHexes = new HashSet<HexBehaviour>();

		[Token(Token = "0x4002080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<HexBehaviour> DirtyCoinColorBuffer = new List<HexBehaviour>(256);

		[Token(Token = "0x4002081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<HexBehaviour> DirtyHexItemUIBuffer = new List<HexBehaviour>(256);

		[Token(Token = "0x4002082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _dirtyHexUIFlushScheduled;

		[Token(Token = "0x4002083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int _dirtyCoinNum;

		[Token(Token = "0x4002085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string key;

		[Token(Token = "0x4002086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HexManager.HexCoord hexCoord;

		[Token(Token = "0x4002087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool canOpen;

		[Token(Token = "0x4002088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool trainingLocked;

		[Token(Token = "0x4002089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string trainingEndTriggerEventId;

		[Token(Token = "0x400208A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool LegendaryTileGuaranteed;

		[Token(Token = "0x400208B")]
		private const string LegendaryLandHexGlobalInfoId = "1005";

		[Token(Token = "0x400208C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isInitFixed;

		[Token(Token = "0x400208D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HexBehaviour leftUpHexBehaviour;

		[Token(Token = "0x400208E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public HexBehaviour rightUpHexBehaviour;

		[Token(Token = "0x400208F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public HexBehaviour upHexBehaviour;

		[Token(Token = "0x4002090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public HexBehaviour downHexBehaviour;

		[Token(Token = "0x4002091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public HexBehaviour leftDownHexBehaviour;

		[Token(Token = "0x4002092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public HexBehaviour rightDownHexBehaviour;

		[Token(Token = "0x4002093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Quality quality;

		[Token(Token = "0x4002094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int price;

		[Token(Token = "0x4002095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isEnemyHex;

		[Token(Token = "0x4002096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isOpened;

		[Token(Token = "0x4002097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject _obj;

		[Token(Token = "0x4002098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GlobalArchitectureInfo _info;

		[Token(Token = "0x4002099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _res;

		[Token(Token = "0x400209A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject _enemyRes;

		[Token(Token = "0x400209B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject _playerRes;

		[Token(Token = "0x400209C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string _id;

		[Token(Token = "0x400209D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool shouldHasWall;

		[Token(Token = "0x400209E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool hasArchitecture;

		[Token(Token = "0x400209F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject _uiRes;

		[Token(Token = "0x40020A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject _showIconUIRes;

		[Token(Token = "0x40020A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject _uiObj;

		[Token(Token = "0x40020A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GameObject _showIconUIObj;

		[Token(Token = "0x40020A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GameObject _legendaryGridEffectObj;

		[Token(Token = "0x40020A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _enemyHexUIRes;

		[Token(Token = "0x40020A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject _enemyHexUIObj;

		[Token(Token = "0x40020A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _stoneWallRes;

		[Token(Token = "0x40020A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private GameObject _mainTowerRes;

		[Token(Token = "0x40020A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public GameObject leftUpWall;

		[Token(Token = "0x40020A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public GameObject rightUpWall;

		[Token(Token = "0x40020AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject upWall;

		[Token(Token = "0x40020AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public GameObject leftDownWall;

		[Token(Token = "0x40020AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public GameObject rightDownWall;

		[Token(Token = "0x40020AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public GameObject downWall;

		[Token(Token = "0x40020AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private StoneWallBehaviour leftUpWallBe;

		[Token(Token = "0x40020AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private StoneWallBehaviour rightUpWallBe;

		[Token(Token = "0x40020B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StoneWallBehaviour upWallBe;

		[Token(Token = "0x40020B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private StoneWallBehaviour leftDownWallBe;

		[Token(Token = "0x40020B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private StoneWallBehaviour rightDownWallBe;

		[Token(Token = "0x40020B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private StoneWallBehaviour downWallBe;

		[Token(Token = "0x40020B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public bool isDestroy;

		[Token(Token = "0x40020B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public TextMeshPro tmpUI;

		[Token(Token = "0x40020B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private GraphUpdateScene _graphUpdateScene;

		[Token(Token = "0x40020B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public RareLevel rareLevel;

		[Token(Token = "0x40020B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public bool isBridge;

		[Token(Token = "0x40020B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A5")]
		private bool _isDoOpenHexAni;

		[Token(Token = "0x40020BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public HexType hexBuildType;

		[Token(Token = "0x40020BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public HexType hexUIType;

		[Token(Token = "0x40020BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private SpecialHexType _specialHexType;

		[Token(Token = "0x40020BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		public bool isSpecialHex;

		[Token(Token = "0x40020BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Vector3[] graphPoints;

		[Token(Token = "0x40020BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private GameObject resBoxObj;

		[Token(Token = "0x40020C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private GameObject[] soilderObj;

		[Token(Token = "0x40020C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool UserLablePlayerResetEd;

		[Token(Token = "0x40020C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		private bool UserLableEnemyResetEd;

		[Token(Token = "0x40020C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		private bool leftUpWallIsDead;

		[Token(Token = "0x40020C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		private bool upWallIsDead;

		[Token(Token = "0x40020C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private bool rightUpWallIsDead;

		[Token(Token = "0x40020C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		private bool leftDownWallIsDead;

		[Token(Token = "0x40020C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		private bool downWallIsDead;

		[Token(Token = "0x40020C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		private bool rightDownWallIsDead;

		[Token(Token = "0x40020C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<RoleBehaviour> _roleEnemyList;

		[Token(Token = "0x40020CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<RoleBehaviour> _rolePlayerList;

		[Token(Token = "0x170000D2")]
		public int Priority
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x4420A90", Offset = "0x441CA90", VA = "0x4420A90")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x4420A98", Offset = "0x441CA98", VA = "0x4420A98")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x170000D3")]
		public string ArchitectureInfoId
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x4420AB0", Offset = "0x441CAB0", VA = "0x4420AB0")]
			get
			{
			return _info != null ? _info.id : null;
		}
		}

		[Token(Token = "0x170000D4")]
		public GameObject UIObj
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x4420AC8", Offset = "0x441CAC8", VA = "0x4420AC8")]
			get
			{
			return _uiObj;
		}
		}

		[Token(Token = "0x170000D5")]
		private bool IsNullHex
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x442761C", Offset = "0x442361C", VA = "0x442761C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x4420AA0", Offset = "0x441CAA0", VA = "0x4420AA0")]
		public void InitializeHexCoord(HexManager.HexCoord coord)
		{
			HexCoord = coord;
			coordQ = coord.q;
			coordR = coord.r;
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x4420AD0", Offset = "0x441CAD0", VA = "0x4420AD0")]
		private bool ShouldSkipGraphUpdateScene()
		{
			return default;
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x4420AD8", Offset = "0x441CAD8", VA = "0x4420AD8")]
		private void CacheGraphUpdateScene()
		{
		    if (_graphUpdateScene == null) _graphUpdateScene = transform.GetComponent<Pathfinding.GraphUpdateScene>();
		    if (Pathfinding.AstarWebGLRuntimeConfig.DisableAstarRuntime && _graphUpdateScene != null) _graphUpdateScene.enabled = false;
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4420BC4", Offset = "0x441CBC4", VA = "0x4420BC4")]
		private void InitGraphUpdateScene()
		{
		    CacheGraphUpdateScene();
		    if (_graphUpdateScene == null) return;
		    graphPoints = _graphUpdateScene.points;
		    if (Pathfinding.AstarWebGLRuntimeConfig.DisableAstarRuntime) return;
		    _graphUpdateScene.points = null;
		    _graphUpdateScene.setTag = 0;
		    _graphUpdateScene.Apply();
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4420C88", Offset = "0x441CC88", VA = "0x4420C88")]
		private void Start()
		{
		    if (transform.position == new Vector3(0f, 0f, -6f)) SteerManager.Instance.playerGoldMine = transform;
		    if (transform.position == new Vector3(-1.73f, 0f, -9f)) SteerManager.Instance.playerOneStartHex = transform;
		    if (transform.position == new Vector3(-1.73f, 0f, -7f)) SteerManager.Instance.playerDefense1 = transform;
		    if (transform.position == new Vector3(0f, 0f, -6f)) SteerManager.Instance.playerDefense2 = transform;
		    if (transform.position == new Vector3(-1.73f, 0f, -9f)) SteerManager.Instance.playerGodMine1 = transform;
		    if (transform.position == new Vector3(-1.73f, 0f, -11f)) SteerManager.Instance.playerGodMine2 = transform;
		    if (transform.position == new Vector3(1.73f, 0f, -7f)) SteerManager.Instance.playerTutor3Unchart1 = transform;
		    if (transform.position == new Vector3(1.73f, 0f, -5f)) SteerManager.Instance.playerTutor3Unchart2 = transform;
		    if (transform.position == new Vector3(3.46f, 0f, -4f)) SteerManager.Instance.playerTutor3Defense = transform;
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x442108C", Offset = "0x441D08C", VA = "0x442108C")]
		public void SetBridge(bool isBridge = false)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4421098", Offset = "0x441D098", VA = "0x4421098")]
		private GlobalHexInfo GetLandPriceHexGlobalInfo()
		{
		    List<GlobalHexInfo> configs = DataManager.Instance.GlobalInfo.hexInfos;
		    if (LegendaryTileGuaranteed)
		    {
		        foreach (GlobalHexInfo config in configs) if (config.id == "1005") return config;
		        return configs[2];
		    }
		    return configs[(int)quality];
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x4421294", Offset = "0x441D294", VA = "0x4421294")]
		private int GetLandPriceInt(GlobalHexInfo landCfg)
		{
		    if (LegendaryTileGuaranteed) return BattleGameSceneManager.GetLegendaryTileV1Price();
		    return ToolModule.StringTool.ToInt(landCfg.price);
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x4421310", Offset = "0x441D310", VA = "0x4421310")]
		public void ApplyLegendaryTileV1()
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x44216D4", Offset = "0x441D6D4", VA = "0x44216D4")]
		private void RefreshLegendaryTileCardForCurrentCamp()
		{
		    if (!LegendaryTileGuaranteed || isOpened) return;
		    rareLevel = RareLevel.SSSR;
		    bool isMirror = SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest;
		    (_info, _id) = isEnemyHex ? AIBehaviourManager.Instance.RandomSSSRArchitectureLevelInfo(isMirror, hexBuildType, false) : EquipCardInfoManager.Instance.RandomSSSRArchitectureLevelInfo(isMirror, hexBuildType, false);
		    if (_info != null && !ToolModule.StringTool.IsNullOrEmpty(_id, true)) rareLevel = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[_id].GetRareLevel();
		    RecordHexType();
		    _res = null;
		    _enemyRes = null;
		    _playerRes = null;
		    LoadArchitectureRes();
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x442165C", Offset = "0x441D65C", VA = "0x442165C")]
		[AsyncStateMachine(typeof(_003CLegendaryTileV1ApplyUiSequenceAsync_003Ed__86))]
		private UniTaskVoid LegendaryTileV1ApplyUiSequenceAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x4421928", Offset = "0x441D928", VA = "0x4421928")]
		[AsyncStateMachine(typeof(_003CTryApplyLegendaryTileHexGoldSurface_003Ed__87))]
		private void TryApplyLegendaryTileHexGoldSurface()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x44219B8", Offset = "0x441D9B8", VA = "0x44219B8")]
		private void SyncLegendaryGridEffectWithPriceUi()
		{
		    if (!LegendaryTileGuaranteed || _legendaryGridEffectObj == null) return;
		    if (_uiObj != null)
		    {
		        bool active = _uiObj.activeSelf;
		        _legendaryGridEffectObj.SetActive(active);
		        if (active)
		        {
		            ParticleSystem[] particles = _legendaryGridEffectObj.GetComponentsInChildren<ParticleSystem>(true);
		            for (int i = 0; i < particles.Length; ++i) particles[i].Play();
		        }
		    }
		    else _legendaryGridEffectObj.SetActive(false);
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x4415734", Offset = "0x4411734", VA = "0x4415734")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__89))]
		public async void Init(string key, bool isEnemyHex, Quality _quality, bool setGoldMine = false, bool isNoGoldCard = false, bool setOneStar = false, bool setUnchart = false, bool setDefense = false, bool setSoldier = false)
		{
		    Priority = 1;
		    this.key = key;
		    this.isEnemyHex = isEnemyHex;
		    _isInitFixed = false;
		    quality = _quality;
		    if (setOneStar | setSoldier) quality = Quality.OneStar;
		    if (setUnchart) quality = Quality.UnCharted;
		    bool isNoneTutorGame = BattleGameSceneManager.Instance.IsNoneTutorGame;
		
		    EventModule.EventManager.Instance.StartListening("CraetHexEndCreatMainTower", CreatMainTower);
		    EventModule.EventManager.Instance.StartListening("PlayerCoinChange", UpdateCoinColorEvent);
		    EventModule.EventManager.Instance.StartListening("CraetHexEnd", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("CraetHexEnd", CheckCanOpen);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckCanOpen);
		    EventModule.EventManager.Instance.StartListening("UpdateHexItemUI", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CreatWallJudge);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", CreatWallJudge);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckGraphUpdateScene);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", CheckGraphUpdateScene);
		    EventModule.EventManager.Instance.StartListening("HasWallDestroy", UpdateAllWallState);
		    if (UserLableManager.Instance.UserLableIsOpen())
		    {
		        EventModule.EventManager.Instance.StartListening("LableSystemPlayerRefreshHex", LableTestPlayerRefeshHex);
		        EventModule.EventManager.Instance.StartListening("LableSystemEnemyRefreshHex", LableSystemEnemyRefreshHex);
		    }
		    InitGraphUpdateScene();
		
		    rareLevel = RareLevel.R;
		    RandomHexRare(true);
		    bool guided = TrainingGroundManager.IsInGuidedGame;
		    if (!LegendaryTileGuaranteed)
		    {
		        if (rareLevel == RareLevel.SSSR && ((guided && isEnemyHex) || (isNoGoldCard && transform.position.z > 0f)))
		        {
		            rareLevel = quality == Quality.OneStar ? RareLevel.R : quality == Quality.TwoStar ? RareLevel.SR : quality == Quality.ThreeStar ? RareLevel.SSR : RareLevel.Null;
		        }
		        if (!LegendaryTileGuaranteed && CoreGameManager.Instance.canCheat && CoreGameManager.Instance.goldCardTest && quality == Quality.UnCharted)
		            rareLevel = RareLevel.SSSR;
		    }
		    HexMirrorInfo mirror = BattleGameSceneManager.Instance.GetMirror(this.key);
		    RandomArchitectureInfoAndCardID(true, mirror);
		    if ((setOneStar | setSoldier) && mirror == null)
		    {
		        (GlobalArchitectureInfo, string, string) tuple = (null, "", "");
		        if (_info.type != "barracks" && isEnemyHex)
		        {
		            tuple = AIBehaviourManager.Instance.RandomBarracksArchitectureInfo();
		            _info = tuple.Item1; _id = tuple.Item2;
		        }
		        else if (_info.type != "barracks" && !isEnemyHex)
		        {
		            tuple = EquipCardInfoManager.Instance.RandomBarracksArchitectureInfo();
		            _info = tuple.Item1; _id = tuple.Item2;
		        }
		        if (tuple.Item3 == "R") rareLevel = RareLevel.R;
		        else if (tuple.Item3 == "SR") rareLevel = RareLevel.SR;
		        else if (tuple.Item3 == "SSR") rareLevel = RareLevel.SSR;
		        else if (tuple.Item3 == "SSSR") rareLevel = RareLevel.SSSR;
		    }
		    if (setDefense && mirror == null)
		    {
		        bool arrow = isEnemyHex ? AIBehaviourManager.Instance.EqipDefenseArrowTowerCard : EquipCardInfoManager.Instance.EqipDefenseArrowTowerCard;
		        bool catapults = isEnemyHex ? AIBehaviourManager.Instance.EqipDefenseCatapultsCard : EquipCardInfoManager.Instance.EqipDefenseCatapultsCard;
		        if (arrow | catapults)
		        {
		            quality = (Quality)UnityEngine.Random.Range(0, 3);
		            int choose = UnityEngine.Random.Range(0, 101);
		            if ((arrow & catapults) ? choose <= 49 : arrow)
		            {
		                rareLevel = RareLevel.SR;
		                (_info, _id) = EquipCardInfoManager.Instance.GetArrowTowerInfo();
		            }
		            else
		            {
		                rareLevel = RareLevel.SSR;
		                (_info, _id) = EquipCardInfoManager.Instance.GetCatapultsInfo();
		            }
		        }
		    }
		    if (setGoldMine && mirror == null)
		    {
		        if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && _id != "1001") BattleGameSceneManager.Instance.GoldMineCountLimitRecordHexCreat();
		        quality = Quality.OneStar;
		        rareLevel = RareLevel.R;
		        if (setGoldMine) (_info, _id) = EquipCardInfoManager.Instance.GetGoldMineInfo();
		        else (_info, _id) = EquipCardInfoManager.Instance.GetSkeletonInfo();
		    }
		    SetHexSoldierPile(setOneStar, setSoldier);
		    RecordHexType();
		    bool applySubGameQuestionMark = false;
		    if (SubGameBuffManager.Instance.IsActive)
		    {
		        applySubGameQuestionMark = SubGameBuffManager.Instance.HasBuff(1001);
		        if (applySubGameQuestionMark) ApplySubGameQuestionMarkInitState();
		    }
		    if (isNoneTutorGame && SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest)
		        BattleGameSceneManager.Instance.AddToRecord(this.key, quality, rareLevel, hexBuildType);
		
		    _stoneWallRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(isEnemyHex
		        ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/EnemyStoneWallRoot.prefab"
		        : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/PlayerStoneWallRoot.prefab");
		    if (quality != Quality.UnCharted) LoadShowIconRes();
		    _enemyHexUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/BeelzebubUI.prefab");
		    GlobalHexInfo landConfig = GetLandPriceHexGlobalInfo();
		    price = GetLandPriceInt(landConfig);
		    _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(landConfig.uiResPath);
		    if (!applySubGameQuestionMark && _info != null && _info.id == "1001")
		    {
		        price = BattleGameSceneManager.Instance.GetGoldMinePrice(isEnemyHex);
		        _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(DataManager.Instance.GlobalInfo.hexInfos[0].uiResPath);
		    }
		    if (_enemyHexUIObj == null)
		    {
		        _enemyHexUIObj = UnityEngine.Object.Instantiate(_enemyHexUIRes);
		        _enemyHexUIObj.transform.SetParent(transform, false);
		        _enemyHexUIObj.SetActive(false);
		    }
		    if (_uiObj == null)
		    {
		        _uiObj = UnityEngine.Object.Instantiate(_uiRes);
		        tmpUI = _uiObj.transform.Find("TextRenderer").GetComponent<TMPro.TextMeshPro>();
		        _uiObj.transform.localPosition = quality == Quality.UnCharted ? new Vector3(0f, 0f, 0.214f) : Vector3.zero;
		        _uiObj.transform.SetParent(transform, false);
		        _uiObj.SetActive(false);
		    }
		    RefreshSubGameInflationPrice();
		    if (quality != Quality.UnCharted) CreatShowUIObj();
		    LoadArchitectureRes();
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x4415CF4", Offset = "0x4411CF4", VA = "0x4415CF4")]
		[AsyncStateMachine(typeof(_003CInitFixed_003Ed__90))]
		public async void InitFixed(string key, bool isEnemyHex, Quality _quality, HexType hexType, string fixedCardId, [Optional] string endTriggerEventId)
		{
		    Priority = 1;
		    this.key = key;
		    this.isEnemyHex = isEnemyHex;
		    quality = _quality;
		    hexBuildType = hexType;
		    trainingEndTriggerEventId = endTriggerEventId;
		    bool eventIsEmpty = string.IsNullOrEmpty(endTriggerEventId);
		    _isInitFixed = true;
		    trainingLocked = !eventIsEmpty;
		    bool isNoneTutorGame = BattleGameSceneManager.Instance.IsNoneTutorGame;
		
		    EventModule.EventManager.Instance.StartListening("CraetHexEndCreatMainTower", CreatMainTower);
		    EventModule.EventManager.Instance.StartListening("PlayerCoinChange", UpdateCoinColorEvent);
		    EventModule.EventManager.Instance.StartListening("CraetHexEnd", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("CraetHexEnd", CheckCanOpen);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckCanOpen);
		    EventModule.EventManager.Instance.StartListening("UpdateHexItemUI", UpdateHexItemUIEvent);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CreatWallJudge);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", CreatWallJudge);
		    EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckGraphUpdateScene);
		    EventModule.EventManager.Instance.StartListening("HasHexDestroy", CheckGraphUpdateScene);
		    EventModule.EventManager.Instance.StartListening("HasWallDestroy", UpdateAllWallState);
		    if (UserLableManager.Instance.UserLableIsOpen())
		    {
		        EventModule.EventManager.Instance.StartListening("LableSystemPlayerRefreshHex", LableTestPlayerRefeshHex);
		        EventModule.EventManager.Instance.StartListening("LableSystemEnemyRefreshHex", LableSystemEnemyRefreshHex);
		    }
		    InitGraphUpdateScene();
		
		    rareLevel = RareLevel.R;
		    if (!string.IsNullOrEmpty(fixedCardId) && DataManager.Instance.GlobalInfo.heroCardDic.ContainsKey(fixedCardId))
		    {
		        GlobalHeroCardInfo card = DataManager.Instance.GlobalInfo.heroCardDic[fixedCardId];
		        if (card != null)
		        {
		            _id = fixedCardId;
		            _info = DataManager.Instance.GlobalInfo.architectureInfoDic.ContainsKey(card.architecturdID)
		                ? DataManager.Instance.GlobalInfo.architectureInfoDic[card.architecturdID] : null;
		            if (card.rareLevel == "R") rareLevel = RareLevel.R;
		            else if (card.rareLevel == "SR") rareLevel = RareLevel.SR;
		            else if (card.rareLevel == "SSR") rareLevel = RareLevel.SSR;
		            else if (card.rareLevel == "SSSR") rareLevel = RareLevel.SSSR;
		        }
		    }
		    hexBuildType = hexType;
		    hexUIType = hexType;
		    RecordHexType();
		
		    _stoneWallRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(isEnemyHex
		        ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/EnemyStoneWallRoot.prefab"
		        : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/PlayerStoneWallRoot.prefab");
		    LoadShowIconRes();
		    _enemyHexUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/BeelzebubUI.prefab");
		    GlobalHexInfo landConfig = GetLandPriceHexGlobalInfo();
		    price = GetLandPriceInt(landConfig);
		    _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(landConfig.uiResPath);
		    if (_info != null && _info.id == "1001")
		    {
		        price = BattleGameSceneManager.Instance.GetGoldMinePrice(isEnemyHex);
		        _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(DataManager.Instance.GlobalInfo.hexInfos[0].uiResPath);
		    }
		    if (_enemyHexUIObj == null)
		    {
		        _enemyHexUIObj = UnityEngine.Object.Instantiate(_enemyHexUIRes);
		        _enemyHexUIObj.transform.SetParent(transform, false);
		        _enemyHexUIObj.SetActive(false);
		    }
		    if (_uiObj == null)
		    {
		        _uiObj = UnityEngine.Object.Instantiate(_uiRes);
		        tmpUI = _uiObj.transform.Find("TextRenderer").GetComponent<TMPro.TextMeshPro>();
		        _uiObj.transform.localPosition = _quality == Quality.UnCharted ? new Vector3(0f, 0f, 0.214f) : Vector3.zero;
		        _uiObj.transform.SetParent(transform, false);
		        _uiObj.SetActive(false);
		    }
		    
		    if (quality != Quality.UnCharted) CreatShowUIObj();
		    LoadArchitectureRes();
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x4421B14", Offset = "0x441DB14", VA = "0x4421B14")]
		private void ApplySubGameQuestionMarkInitState()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x4422670", Offset = "0x441E670", VA = "0x4422670")]
		private void SetHexSoldierPile(bool SetOneStar, bool SetSoldier)
		{
		    if (ArenaManager.Instance.GetUnLockArenaCount() < 8 || SetOneStar) return;
		    if (!QuickTutor.TutorialManager.Instance.IsStepComplete("1015")) return;
		    if (_info != null)
		    {
		        if (_info.type == "defense" && hexBuildType == HexType.soldierpile)
		            hexBuildType = hexUIType = HexType.defense;
		    }
		    else if (hexBuildType == HexType.soldierpile) hexBuildType = hexUIType;
		    if (!SDKModule.ABTestManager.Instance.NewHexaTypeABIsBTest || _info == null || _info.type != "barracks") return;
		    if (!SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest)
		    {
		        int value = UnityEngine.Random.Range(0, 100);
		        if (value >= 30 && !SetSoldier) return;
		        hexBuildType = HexType.soldierpile;
		        if (quality != Quality.UnCharted) hexUIType = HexType.soldierpile;
		        return;
		    }
		    if (BattleGameSceneManager.Instance.GetMirror(key) == null)
		    {
		        int value = UnityEngine.Random.Range(0, 100);
		        if (value < 30 || SetSoldier)
		        {
		            hexBuildType = HexType.soldierpile;
		            if (quality != Quality.UnCharted) hexUIType = HexType.soldierpile;
		            return;
		        }
		    }
		    if (BattleGameSceneManager.Instance.GetMirror(key) != null && hexBuildType == HexType.soldierpile && quality != Quality.UnCharted)
		        hexUIType = HexType.soldierpile;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x44214D8", Offset = "0x441D4D8", VA = "0x44214D8")]
		private void RecordHexType()
		{
		    if (hexBuildType == HexType.soldierpile) return;
		    if (_info == null) hexBuildType = HexType.UnCharted;
		    else if (_info.type == "barracks") hexBuildType = HexType.barracks;
		    else if (_info.type == "defense") hexBuildType = HexType.defense;
		    else if (_info.type == "resources") hexBuildType = HexType.resources;
		    if (quality == Quality.UnCharted) hexUIType = HexType.UnCharted;
		    else if (_info != null && _info.type == "barracks") hexUIType = HexType.barracks;
		    else if (_info != null && _info.type == "defense") hexUIType = HexType.defense;
		    else if (_info != null && _info.type == "resources") hexUIType = HexType.resources;
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x441567C", Offset = "0x441167C", VA = "0x441567C")]
		[AsyncStateMachine(typeof(_003CSetSpecialHex_003Ed__96))]
		public void SetSpecialHex(string key, bool isEnemy, SpecialHexType type)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x4415844", Offset = "0x4411844", VA = "0x4415844")]
		public void ChangeSnowMat()
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x4421B5C", Offset = "0x441DB5C", VA = "0x4421B5C")]
		private void RandomHexRare(bool isInit, bool UserLablePlayerReset = false, bool UserLableEnemyReset = false)
		{
		    if (LegendaryTileGuaranteed) { rareLevel = RareLevel.SSSR; return; }
		    string[] weights = DataManager.Instance.GlobalInfo.hexInfos[(int)quality].probabilityProfile.Split(',');
		    int total = 0;
		    for (int i = 0; i < weights.Length; ++i) total = unchecked(total + ToolModule.StringTool.ToInt(weights[i]));
		    int userBonus = 0;
		    if (UserLableManager.Instance.UserLableIsOpen() && !isEnemyHex && BattleGameManager.Instance.GameType != GameType.PVE)
		        userBonus = UserLableManager.Instance.UserOpenLendaryCardOddHandle(UserLablePlayerReset);
		    if (UserLableManager.Instance.UserLableIsOpen() && isEnemyHex && BattleGameManager.Instance.GameType != GameType.PVE)
		        userBonus = UserLableManager.Instance.EnemyOpenLendaryCardOddHandle(UserLableEnemyReset);
		    int blessingBonus = DailyBlessManager.Instance.GoldCardOddHandle(isEnemyHex);
		    SubGameBuffManager buffManager = SubGameBuffManager.Instance;
		    int baseSssr = ToolModule.StringTool.ToInt(weights[3]);
		    int goldBonus = unchecked(blessingBonus + userBonus + buffManager.GetGoldCardOddBonus(baseSssr, isEnemyHex));
		    if (isEnemyHex)
		    {
		        if (WeeklyCardActivityManager.Instance.GetEnemyCardDeckHasCycleCard()) ++goldBonus;
		        else if (!isEnemyHex && WeeklyCardActivityManager.Instance.GetPlayerCardDeckHasCycleCard()) ++goldBonus;
		    }
		    else if (WeeklyCardActivityManager.Instance.GetPlayerCardDeckHasCycleCard()) ++goldBonus;
		    int value = UnityEngine.Random.Range(0, unchecked(goldBonus + total));
		    int first = SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest && quality == Quality.TwoStar ? 0 : ToolModule.StringTool.ToInt(weights[0]);
		    if (value < first) rareLevel = RareLevel.R;
		    else if (value < unchecked(ToolModule.StringTool.ToInt(weights[0]) + ToolModule.StringTool.ToInt(weights[1]))) rareLevel = RareLevel.SR;
		    else if (value < unchecked(ToolModule.StringTool.ToInt(weights[0]) + ToolModule.StringTool.ToInt(weights[1]) + ToolModule.StringTool.ToInt(weights[2]))) rareLevel = RareLevel.SSR;
		    else if (value < unchecked(ToolModule.StringTool.ToInt(weights[0]) + goldBonus + ToolModule.StringTool.ToInt(weights[1]) + ToolModule.StringTool.ToInt(weights[2]) + ToolModule.StringTool.ToInt(weights[3]))) rareLevel = RareLevel.SSSR;
		    else rareLevel = RareLevel.Null;
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x4421898", Offset = "0x441D898", VA = "0x4421898")]
		[AsyncStateMachine(typeof(_003CLoadArchitectureRes_003Ed__99))]
		private async void LoadArchitectureRes()
		{
		    GlobalArchitectureInfo info = _info;
		    if (info == null) return;
		    string id = _id;
		    if (AssetsModule.AssetsManager.Instance == null) return;
		    if (!ToolModule.StringTool.IsNullOrEmpty(info.prefabPath, true) && id != "1001")
		    {
		        string enemyPath = info.GetPath(false);
		        string playerPath = info.GetPath(true);
		        if (ToolModule.StringTool.IsNullOrEmpty(enemyPath, true) || ToolModule.StringTool.IsNullOrEmpty(playerPath, true)) return;
		        _enemyRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(enemyPath);
		        _playerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(playerPath);
		        _res = isEnemyHex ? _enemyRes : _playerRes;
		    }
		    else if (id == "1001")
		    {
		        int level;
		        if (isEnemyHex)
		        {
		            if (AIBehaviourManager.Instance == null) return;
		            if (!AIBehaviourManager.Instance.cardLevelDic.ContainsKey(id)) return;
		            level = AIBehaviourManager.Instance.cardLevelDic[id];
		        }
		        else
		        {
		            if (DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic == null || !DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic.ContainsKey(id)) return;
		            level = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[id].level;
		        }
		        int index = level >= 3 ? 2 : new int[] { 0, 0, 1 }[level];
		        string enemyPath = info.GetPath(false, index);
		        string playerPath = info.GetPath(true, index);
		        if (ToolModule.StringTool.IsNullOrEmpty(enemyPath, true) || ToolModule.StringTool.IsNullOrEmpty(playerPath, true)) return;
		        _enemyRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(enemyPath);
		        _playerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(playerPath);
		        _res = isEnemyHex ? _enemyRes : _playerRes;
		    }
		    foreach (Renderer renderer in GetComponentsInChildren<Renderer>()) renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x4422004", Offset = "0x441E004", VA = "0x4422004")]
		private void RandomArchitectureInfoAndCardID(bool isInit, [Optional] HexMirrorInfo info)
		{
		    bool isMirror = SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest;
		    if (isInit)
		    {
		        if (info != null)
		        {
		            hexBuildType = info.HexType;
		            quality = info.Quality;
		            RandomHexRare(false);
		        }
		        else isMirror = false;
		    }
		    switch (rareLevel)
		    {
		        case RareLevel.R:
		            (_info, _id) = isEnemyHex ? AIBehaviourManager.Instance.RandomRArchitectureLevelInfo(isMirror, hexBuildType, isInit) : EquipCardInfoManager.Instance.RandomRArchitectureLevelInfo(isMirror, hexBuildType, isInit);
		            if (_id == "1001" && isInit) BattleGameSceneManager.Instance.GoldMineCountLimitRecordHexCreat();
		            break;
		        case RareLevel.SR:
		            (_info, _id) = isEnemyHex ? AIBehaviourManager.Instance.RandomSRArchitectureLevelInfo(isMirror, hexBuildType, isInit) : EquipCardInfoManager.Instance.RandomSRArchitectureLevelInfo(isMirror, hexBuildType, isInit);
		            break;
		        case RareLevel.SSR:
		            (_info, _id) = isEnemyHex ? AIBehaviourManager.Instance.RandomSSRArchitectureLevelInfo(isMirror, hexBuildType, isInit) : EquipCardInfoManager.Instance.RandomSSRArchitectureLevelInfo(isMirror, hexBuildType, isInit);
		            break;
		        case RareLevel.SSSR:
		            (_info, _id) = isEnemyHex ? AIBehaviourManager.Instance.RandomSSSRArchitectureLevelInfo(isMirror, hexBuildType, isInit) : EquipCardInfoManager.Instance.RandomSSSRArchitectureLevelInfo(isMirror, hexBuildType, isInit);
		            break;
		        case RareLevel.Null:
		            _info = null;
		            break;
		    }
		    List<int> battleCards = DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList();
		    bool inBattleDeck = battleCards != null && !ToolModule.StringTool.IsNullOrEmpty(_id, true) && battleCards.Contains(ToolModule.StringTool.ToInt(_id));
		    bool unopenedGold = BattleGameManager.Instance != null && !BattleGameManager.Instance.playerNowGameOpenGoldCardEd;
		    bool artifacts = !isEnemyHex && SDKModule.ABTestManager.Instance.NewArtifactsPlayIsBTest;
		    if ((unopenedGold & inBattleDeck & artifacts) && rareLevel != RareLevel.SSSR && _info != null && !ToolModule.StringTool.IsNullOrEmpty(_id, true))
		    {
		        if (DataManager.Instance.GlobalInfo.heroCardDic.TryGetValue(_id, out GlobalHeroCardInfo card))
		        {
		            CardFettersType fetters = (CardFettersType)ToolModule.StringTool.ToInt(card.cardFetters);
		            if ((int)fetters != 4)
		            {
		                float chance = PropManager.Instance.GetEquippedArtifactTraitPercent(fetters, (ArtifactTraitAttrType)3);
		                if (chance > 0f && UnityEngine.Random.Range(0f, 1f) < chance)
		                {
		                    (_info, _id) = EquipCardInfoManager.Instance.RandomSSSRArchitectureLevelInfoByFetters(fetters, isMirror, hexBuildType, isInit);
		                    rareLevel = RareLevel.SSSR;
		                }
		            }
		        }
		    }
		    if (info != null && !ToolModule.StringTool.IsNullOrEmpty(_id, true))
		        rareLevel = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[_id].GetRareLevel();
		    if (_info != null && !ToolModule.StringTool.IsNullOrEmpty(_id, true))
		        rareLevel = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[_id].GetRareLevel();
		    RecordHexType();
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4422908", Offset = "0x441E908", VA = "0x4422908")]
		[AsyncStateMachine(typeof(_003CLoadShowIconRes_003Ed__101))]
		private async void LoadShowIconRes()
		{
		    if (_info == null) return;
		    if (LegendaryTileGuaranteed)
		        _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUILegendaryTile.prefab");
		    else if (hexBuildType == HexType.soldierpile)
		        _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUISoldier.prefab");
		    else if (_info.type == "resources")
		        _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIRes.prefab");
		    else if (_info.type == "defense")
		        _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIDef.prefab");
		    else if (_info.type == "barracks")
		        _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIBar.prefab");
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x4422998", Offset = "0x441E998", VA = "0x4422998")]
		private void LableTestPlayerRefeshHex(object o)
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x4423050", Offset = "0x441F050", VA = "0x4423050")]
		private void LableSystemEnemyRefreshHex(object o)
		{
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x44233B4", Offset = "0x441F3B4", VA = "0x44233B4")]
		public bool Wound(int num, string id, bool isBuild, Transform target, AtkWayType atkWayType)
		{
            if (!CoreGameManager.Gaming) return false;
            StoneWallBehaviour wall = GetTargetWallNearPos(target.position);
            if (wall != null && !wall.isDead && wall.gameObject.activeSelf)
            {
                EntityBase attacker = target != null ? target.GetComponent<EntityBase>() : null;
                wall.Wound(num, id, isBuild, attacker, false, AtkWayType.Melee, CardFettersType.Null, null);
                if (wall.isDead)
                {
                    UpdateAllWallState(this);
                    global::AudioManager.Instance.PlaySFX("Assets/_Res/Addressable/AudiosBundle/SFX/BuildDead.mp3", transform, 1f, 0);
                }
                return false;
            }
            if (wall != null && wall.isDead) UpdateAllWallState(this);
            return true;
        }

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x4424050", Offset = "0x4420050", VA = "0x4424050")]
		private void UpdateAllWallState(object o)
		{
            if ((o as HexBehaviour) != this) return;
            if (leftUpWall != null && leftUpWallBe.isDead) leftUpWallIsDead = true;
            if (upWall != null && upWallBe.isDead) upWallIsDead = true;
            if (rightUpWall != null && rightUpWallBe.isDead) rightUpWallIsDead = true;
            if (leftDownWall != null && leftDownWallBe.isDead) leftDownWallIsDead = true;
            if (downWall != null && downWallBe.isDead) downWallIsDead = true;
            if (rightDownWall != null && rightDownWallBe.isDead) rightDownWallIsDead = true;
        }

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x4423624", Offset = "0x441F624", VA = "0x4423624")]
		private StoneWallBehaviour GetTargetWallNearPos(Vector3 target)
		{
            List<GameObject> walls = new List<GameObject>();
            List<Vector3> missingPositions = new List<Vector3>();
            if (leftUpWall != null) walls.Add(leftUpWall); else missingPositions.Add(CalcWallPos(WallType.LeftUp));
            if (upWall != null) walls.Add(upWall); else missingPositions.Add(CalcWallPos(WallType.Up));
            if (rightUpWall != null) walls.Add(rightUpWall); else missingPositions.Add(CalcWallPos(WallType.RightUp));
            if (leftDownWall != null) walls.Add(leftDownWall); else missingPositions.Add(CalcWallPos(WallType.LeftDown));
            if (downWall != null) walls.Add(downWall); else missingPositions.Add(CalcWallPos(WallType.Down));
            if (rightDownWall != null) walls.Add(rightDownWall); else missingPositions.Add(CalcWallPos(WallType.RightDown));
            if (walls.Count < 1) return null;
            int selected = 0;
            float distance = Vector3.Distance(target, walls[0].transform.position);
            for (int i = 1; i < walls.Count; i++)
            {
                if (distance > Vector3.Distance(target, walls[i].transform.position))
                {
                    distance = Vector3.Distance(target, walls[i].transform.position);
                    selected = i;
                }
            }
            for (int i = 0; i < missingPositions.Count; i++)
                if (distance > Vector3.Distance(missingPositions[i], walls[selected].transform.position)) return null;
            return walls[selected].GetComponent<StoneWallBehaviour>();
        }

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x4424420", Offset = "0x4420420", VA = "0x4424420")]
		private void CheckGraphUpdateScene(object o)
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x44244FC", Offset = "0x44204FC", VA = "0x44244FC")]
		private void CheckCanOpen(object o)
		{
		    if (isOpened) return;
		    canOpen = NearHasOpen();
		    if (IsTrainingHexLocked()) canOpen = false;
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x4424614", Offset = "0x4420614", VA = "0x4424614")]
		private void HexOpen()
		{
		    canOpen = false;
		    trainingLocked = false;
		    isOpened = true;
		    Priority = 2;
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x442462C", Offset = "0x442062C", VA = "0x442462C")]
		public void RefreshTrainingLock()
		{
		    CheckCanOpen(null);
		    UpdateHexItemUI(null);
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x4424568", Offset = "0x4420568", VA = "0x4424568")]
		private bool IsTrainingHexLocked()
		{
		    if (!TrainingGroundManager.IsInGuidedGame) return false;
		    TrainingHexConfig config = TrainingGroundManager.Instance.GetFixedHexConfig(transform.position);
		    if (config == null || string.IsNullOrEmpty(config.endTriggerEventId)) return false;
		    return trainingLocked;
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x44246D0", Offset = "0x44206D0", VA = "0x44246D0")]
		[AsyncStateMachine(typeof(_003CCreatMainTower_003Ed__120))]
		private async void CreatMainTower(object o)
		{
		    if (key != BattleGameSceneManager.Instance.enemyMainTowerKey && key != BattleGameSceneManager.Instance.playerMainTowerKey) return;
		    HexOpen();
		    int playerTalent = UpgradeMainTowerManager.Instance.GetMainTowerTalentInfo();
		    int enemyTalent = AIBehaviourManager.Instance.GetMainTowerTalentInfo();
		    if (!SDKModule.ABTestManager.Instance.NewMainCity2)
		    {
		        playerTalent = playerTalent == -1 ? 1 : 5 - playerTalent;
		        enemyTalent = enemyTalent == -1 ? 1 : 5 - enemyTalent;
		        _mainTowerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(isEnemyHex
		            ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Build/Build_MainTower_Red_" + enemyTalent.ToString() + ".prefab"
		            : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Build/Build_MainTower_Blue_" + playerTalent.ToString() + ".prefab");
		    }
		    else if (!isEnemyHex)
		    {
		        _mainTowerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(string.Format("Assets/_Res/Addressable/04MetaGameBundle/Prefabs/NewMainCity_Building/NewMainCity_Building_MainCity_Lv{0}_Player.prefab", playerTalent));
		    }
		    else
		    {
		        int maxLevel = DataManager.Instance.GlobalInfo.mainCityTitleInfos.Count;
		        enemyTalent = enemyTalent < 1 ? 1 : enemyTalent > maxLevel ? maxLevel : enemyTalent;
		        string path = BattleGameManager.Instance.GameType == GameType.PVE
		            ? "Assets/_Res/Addressable/04MetaGameBundle/Prefabs/NewMainCity_Building/NewMainCity_Building_MainCity_Lv{0}_KuLou.prefab"
		            : "Assets/_Res/Addressable/04MetaGameBundle/Prefabs/NewMainCity_Building/NewMainCity_Building_MainCity_Lv{0}_Enemy.prefab";
		        _mainTowerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(string.Format(path, enemyTalent));
		    }
		    _isDoOpenHexAni = true;
		    if (transform != null) DG.Tweening.ShortcutExtensions.DOMoveY(transform, 1f, 0.2f);
		    DG.Tweening.ShortcutExtensions.DOLocalRotate(transform, new Vector3(0f, 0f, 180f), 0.3f).onComplete += () =>
		    {
		        if (transform != null)
		            DG.Tweening.ShortcutExtensions.DOMoveY(transform, -1f, 0.1f).onComplete += async () =>
		            {
		                _isDoOpenHexAni = false;
		                hasArchitecture = true;
		                _obj = UnityEngine.Object.Instantiate(_mainTowerRes);
		                if (!isEnemyHex && DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame)
		                    SteerManager.Instance.playerMainTower = _obj.transform;
		                ArchitectureBehaviour architecture = _obj.GetComponent<ArchitectureBehaviour>();
		                architecture.Init(this, null, isEnemyHex, 0, RareLevel.R, ArchitectureDeadCallBack, (CardFettersType)4, (AtkWayType)2);
		                _obj.transform.position = new Vector3(transform.position.x, 0f, isEnemyHex ? transform.position.z : transform.position.z - 0.5f);
		                if (isEnemyHex) BattleGameSceneManager.Instance.AddEnemyArchitecture(_obj);
		                else BattleGameSceneManager.Instance.AddPlayerArchitecture(_obj);
		                BattleGameSceneManager.Instance.AddArchitectureBehaviour(architecture);
		                if (isEnemyHex)
		                {
		                    BattleGameSceneManager.Instance.RemoveEnemyStayHex(gameObject);
		                    BattleGameSceneManager.Instance.AddEnemyHasHex(gameObject);
		                }
		                else
		                {
		                    BattleGameSceneManager.Instance.RemovePlayerStayHex(gameObject);
		                    BattleGameSceneManager.Instance.AddPlayerHasHex(gameObject);
		                    BattleGameSceneManager.Instance.playerMainTowerPos = transform.position;
		                }
		                EventModule.EventManager.Instance.TriggerEvent("HasHexOpen", this);
		                EventModule.EventManager.Instance.TriggerEvent("PlayerCoinChange", BattleGameManager.Instance.hasCoin);
		                if (!isEnemyHex) EventModule.EventManager.Instance.TriggerEvent("CreatMainTowerEnd");
		                if (SDKModule.ABTestManager.Instance.NewMainCity2 && !isEnemyHex)
		                    _obj.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
		            };
		    };
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x4424760", Offset = "0x4420760", VA = "0x4424760")]
		private void UpdateCoinColorEvent(object o)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x4424898", Offset = "0x4420898", VA = "0x4424898")]
		private void UpdateHexItemUIEvent(object o)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x4424804", Offset = "0x4420804", VA = "0x4424804")]
		private void MarkCoinColorDirty(int coinNum)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x44248DC", Offset = "0x44208DC", VA = "0x44248DC")]
		private void MarkHexItemUIDirty()
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x4424960", Offset = "0x4420960", VA = "0x4424960")]
		private static void ScheduleDirtyHexUIFlush()
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x44249EC", Offset = "0x44209EC", VA = "0x44249EC")]
		[AsyncStateMachine(typeof(_003CFlushDirtyHexUIAsync_003Ed__126))]
		private static UniTaskVoid FlushDirtyHexUIAsync()
		{
			return default;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x4424A58", Offset = "0x4420A58", VA = "0x4424A58")]
		private void RemoveFromDirtyHexUIBatches()
		{
            DirtyCoinColorHexes.Remove(this);
            DirtyHexItemUIHexes.Remove(this);
        }

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x4424AF4", Offset = "0x4420AF4", VA = "0x4424AF4")]
		public void UpdateCoinColor(int coinNum)
		{
		    if (tmpUI == null) return;
		    tmpUI.color = price > coinNum ? Color.black : Color.white;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x4424C0C", Offset = "0x4420C0C", VA = "0x4424C0C")]
		public void TextDoAni()
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x4424D5C", Offset = "0x4420D5C", VA = "0x4424D5C")]
		public void OpenHex(bool isEnemy, bool isHard = false)
		{
			if (isBridge || isOpened || !CoreGameManager.Gaming) return;
			if (_info != null && _info.id == "1001")
			{
			    int originalPrice = price;
			    if (isEnemyHex) BattleGameSceneManager.Instance.RecordEnemyUseGoldMine();
			    else BattleGameSceneManager.Instance.RecordPlayerUseGoldMine();
			    if (SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest)
			        BattleGameSceneManager.Instance.UpdateAllGoldMinePrices();
			    price = originalPrice;
			}
			canOpen = false;
			trainingLocked = false;
			isOpened = true;
			Priority = 2;
			SubGameBuffManager.Instance.OnActiveHexOpened(isEnemy);
			if (!isEnemy) VibratorManager.Trigger(HapticTypes.MediumImpact);
			_isDoOpenHexAni = true;
			if (price < 250)
			    EventModule.EventManager.Instance.TriggerEvent(isEnemy ? "EnemyBeginOpenHex" : "PlayerBeginOpenHex", null);
			if (transform != null) DG.Tweening.ShortcutExtensions.DOMoveY(transform, 1f, 0.2f);
			DG.Tweening.ShortcutExtensions.DOLocalRotate(transform, new Vector3(0f, 0f, 180f), 0.3f).onComplete += () =>
			{
			    if (transform != null)
			        DG.Tweening.ShortcutExtensions.DOMoveY(transform, -1f, 0.1f).onComplete += HandleOnComplete;
			};
			_uiObj.SetActive(false);
			if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
			if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
			SyncLegendaryGridEffectWithPriceUi();
			if (isEnemyHex)
			{
			    BattleGameSceneManager.Instance.RemoveEnemyStayHex(gameObject);
			    BattleGameSceneManager.Instance.AddEnemyHasHex(gameObject);
			}
			else
			{
			    BattleGameSceneManager.Instance.RemovePlayerStayHex(gameObject);
			    BattleGameSceneManager.Instance.AddPlayerHasHex(gameObject);
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x4425210", Offset = "0x4421210", VA = "0x4425210")]
		[AsyncStateMachine(typeof(_003CHandleOnComplete_003Ed__131))]
		private async void HandleOnComplete()
		{
		    _isDoOpenHexAni = false;
		    bool mayReroll;
		    if (isEnemyHex) mayReroll = !_isInitFixed && AIBehaviourManager.Instance.openHexCount < 4;
		    else mayReroll = BattleGameManager.Instance.openHexCount <= 3;
		    if (mayReroll && _info != null && _info.type != "resources" && _info.type != "defense" && price <= 249 && (uint)rareLevel >= 2u)
		    {
		        UnityEngine.Debug.Log(isEnemyHex.ToString() + "前三次重新随机卡牌了");
		        (GlobalArchitectureInfo, string) selected = isEnemyHex ? AIBehaviourManager.Instance.RandomRArchitectureLevelInfoAndNoGoldMine() : EquipCardInfoManager.Instance.RandomRArchitectureLevelInfoAndNoGoldMine();
		        bool balance = SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest;
		        (_info, _id) = selected;
		        _enemyRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(_info.GetPath(false));
		        _playerRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(_info.GetPath(true));
		        _res = isEnemyHex ? _enemyRes : _playerRes;
		        rareLevel = RareLevel.R;
		    }
		    if (!isEnemyHex && !TutorialManager.Instance.IsStepComplete("1015") && TrainingGroundManager.Instance != null)
		    {
		        if (TrainingGroundManager.Instance.ShouldForceDragonKnightForHex(transform.position))
		        {
		            _res = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Build/Build_DragonKnight_Blue_New.prefab");
		            (_info, _id) = EquipCardInfoManager.Instance.GetDragonKnightInfo();
		            rareLevel = RareLevel.SSSR;
		            SteerManager.Instance.playerDrgonKnightHex = transform;
		            EventModule.EventManager.Instance.TriggerEvent("SkillSteerIngBanCameraMove");
		            TutorialManager.Instance.RegisterTutorialCheck("1015", () => true);
		        }
		    }
		    if (DailyBlessManager.Instance.IsBTest() && !LegendaryTileGuaranteed)
		    {
		        if (isEnemyHex)
		        {
		            if (DailyBlessManager.Instance.NowEnemySuperSummon && (uint)((int)hexUIType - 1) <= 1u)
		            {
		                rareLevel = RareLevel.SSSR;
		                RandomArchitectureInfoAndCardID(false);
		                LoadArchitectureRes();
		                DailyBlessManager.Instance.NowEnemySuperSummon = false;
		            }
		        }
		        else if (DailyBlessManager.Instance.NowPlayerSuperSummon && (uint)((int)hexUIType - 1) <= 1u)
		        {
		            rareLevel = RareLevel.SSSR;
		            RandomArchitectureInfoAndCardID(false);
		            LoadArchitectureRes();
		            DailyBlessManager.Instance.NowPlayerSuperSummon = false;
		        }
		    }
		    if (!isEnemyHex) BattleGameSceneManager.Instance.RecordPlayerOpenHexCount();
		    if (hexBuildType == HexType.soldierpile) CreatSoldierPile();
		    else if (_info != null)
		    {
		        hasArchitecture = true;
		        if (!CoreGameManager.Gaming) return;
		        if (_res == null)
		        {
		            LoadArchitectureRes();
		            UnityEngine.Debug.Log("要实例化的建筑资源是空的，开始等待");
		        }
		        while (_res == null)
		        {
		            UnityEngine.Debug.Log("不是空格子，但是资源没加载完，等待中");
		            await UniTask.WaitForEndOfFrame();
		        }
		        if (!isEnemyHex) BattleGameManager.Instance.RecordCardCount(_id);
		        _obj = UnityEngine.Object.Instantiate(_res);
		        ArchitectureBehaviour architecture = _obj.GetComponent<ArchitectureBehaviour>();
		        int cardLevel = isEnemyHex ? AIBehaviourManager.Instance.cardLevelDic[_id] : DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[_id].level;
		        GlobalHeroCardInfo card = DataManager.Instance.GlobalInfo.heroCardDic[_id];
		        CardFettersType fetters = (CardFettersType)ToolModule.StringTool.ToInt(card.cardFetters);
		        card = DataManager.Instance.GlobalInfo.heroCardDic[_id];
		        AtkWayType attackWay = (AtkWayType)ToolModule.StringTool.ToInt(card.atkType);
		        architecture.Init(this, _info, isEnemyHex, cardLevel, rareLevel, ArchitectureDeadCallBack, fetters, attackWay);
		        _obj.transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
		        if (isEnemyHex) BattleGameSceneManager.Instance.AddEnemyArchitecture(_obj);
		        else BattleGameSceneManager.Instance.AddPlayerArchitecture(_obj);
		        BattleGameSceneManager.Instance.AddArchitectureBehaviour(architecture);
		        if (!isEnemyHex) UIModuleO.UITextEffectManager.Instance.ShowCardUIEffect(rareLevel, _id, new Vector3(transform.position.x, 0f, transform.position.z));
		        EventModule.EventManager.Instance.TriggerEvent("HasBuildCreat");
		    }
		    if (_info != null && _info.id != "1001" && !isEnemyHex) BattleGameSceneManager.Instance.RecordPlayerOpenHexTypeCount(quality);
		    EventModule.EventManager.Instance.TriggerEvent("HasHexOpen", this);
		    if (rareLevel == RareLevel.SSSR)
		    {
		        EventModule.EventManager.Instance.TriggerEvent(isEnemyHex ? "LableSystemEnemyRefreshHex" : "LableSystemPlayerRefreshHex", this);
		        int odds = 0;
		        switch (quality)
		        {
		            case Quality.OneStar: odds = 1; break;
		            case Quality.TwoStar: odds = 2; break;
		            case Quality.ThreeStar: odds = 5; break;
		            case Quality.UnCharted: odds = 5; break;
		        }
		        GoldCardAnimationPanelManager.Instance.AddQuene(new GoldCardAniConfig(isEnemyHex, odds, _id));
		        if (!isEnemyHex && UnityEngine.Random.Range(0, 101) <= 49) EventModule.EventManager.Instance.TriggerEvent("PlayerOpenGoldCard", 2);
		    }
		    if (isEnemyHex)
		    {
		        if (rareLevel == RareLevel.SSSR) AIBehaviourManager.Instance.enemyNowGameOpenGoldCardEd = true;
		    }
		    else
		    {
		        if (rareLevel == RareLevel.SSSR)
		        {
		            AssetsModule.EffectManager.Instance.ShowEffect("Assets/_Res/Addressable/EffectsBundle/Effects/LegendaryHexFlip.prefab", transform.position + Vector3.up, Vector3.one + Vector3.one, 1f);
		            BattleGameManager.Instance.playerNowGameOpenGoldCardEd = true;
		        }
		        if (rareLevel == RareLevel.SSR) AssetsModule.EffectManager.Instance.ShowEffect("Assets/_Res/Addressable/EffectsBundle/Effects/EpicHexFlip.prefab", transform.position + Vector3.up, Vector3.one + Vector3.one, 1f);
		    }
		    AudioManager.Instance.PlaySFX("Assets/_Res/Addressable/AudiosBundle/SFX/BuildComplete.mp3", transform, 1f, 0);
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x44252A0", Offset = "0x44212A0", VA = "0x44252A0")]
		[AsyncStateMachine(typeof(_003CCreatSoldierPile_003Ed__132))]
		private async void CreatSoldierPile()
		{
		    _003C_003Ec__DisplayClass132_0 context = new _003C_003Ec__DisplayClass132_0();
		    context._003C_003E4__this = this;
		    int num = 0;
		    string path = string.Empty;
		    context.path2 = string.Empty;
		    if (_info == null)
		    {
		        UnityEngine.Debug.LogError("此格子的角色信息为空");
		        UnityEngine.Debug.LogError("此格子的" + hexBuildType.ToString());
		    }
		    context._roleInfo = DataManager.Instance.GlobalInfo.roleInfos.Find(context._003CCreatSoldierPile_003Eb__0);
		    if (context._roleInfo == null) UnityEngine.Debug.LogError("为空" + gameObject.ToString() + key);
		    _info = null;
		    context.CardLevel = isEnemyHex ? AIBehaviourManager.Instance.cardLevelDic[_id] : DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[_id].level;
		    switch (rareLevel)
		    {
		        case RareLevel.R:
		            num = 8;
		            path = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicMissileSoftGreen.prefab";
		            context.path2 = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicCircleGreen.prefab";
		            break;
		        case RareLevel.SR:
		            num = 5;
		            path = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicMissileSoftBlue.prefab";
		            context.path2 = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicCircleBlue.prefab";
		            break;
		        case RareLevel.SSR:
		            num = 3;
		            path = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicMissileSoftPurple.prefab";
		            context.path2 = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicCirclePurple.prefab";
		            break;
		        case RareLevel.SSSR:
		            num = 2;
		            path = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicMissileSoftGold.prefab";
		            context.path2 = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicCircleYellow.prefab";
		            break;
		        default:
		            num = 0;
		            path = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicMissileSoftGreen.prefab";
		            context.path2 = "Assets/_Res/Addressable/EffectsBundle/Effects/MagicCircleGreen.prefab";
		            break;
		    }
		    context._rolePrefabRes = await CoreGameManager.Instance.LoadRoleAssets(context._roleInfo, isEnemyHex ? 1 : 0);
		    context.allPos = BattleGameSceneManager.Instance.GetHexTargetPosNoThisFoot(transform.position, num);
		    GameObject effectRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(path);
		    for (int i = 0; i < num; ++i)
		    {
		        _003C_003Ec__DisplayClass132_1 spawn = new _003C_003Ec__DisplayClass132_1();
		        spawn.CS_0024_003C_003E8__locals1 = context;
		        if (i % 5 == 0) await UniTask.Yield();
		        GameObject effect = AssetsModule.ObjPoolManager.Instance.GetFromPool(effectRes, 0.9f, true, 3);
		        effect.transform.position = transform.position + Vector3.up;
		        effect.GetComponent<ParticleSystem>().Play();
		        spawn.index = i;
		        DG.Tweening.ShortcutExtensions.DOJump(effect.transform, context.allPos[spawn.index] + new Vector3(0f, 0.1f, 0f), 1f, 1, 0.5f).onComplete += spawn._003CCreatSoldierPile_003Eb__1;
		    }
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x4425338", Offset = "0x4421338", VA = "0x4425338")]
		[AsyncStateMachine(typeof(_003CArchitectureDeadCallBack_003Ed__133))]
		private void ArchitectureDeadCallBack()
		{
            _003CArchitectureDeadCallBack_003Ed__133 stateMachine = new _003CArchitectureDeadCallBack_003Ed__133
            {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x44253C8", Offset = "0x44213C8", VA = "0x44253C8")]
		public void UIHide()
		{
		    if (_uiObj != null) _uiObj.SetActive(false);
		    if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		    if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		    if (leftUpWall != null) leftUpWallBe.UIHide();
		    if (upWall != null) upWallBe.UIHide();
		    if (rightUpWall != null) rightUpWallBe.UIHide();
		    if (leftDownWall != null) leftDownWallBe.UIHide();
		    if (downWall != null) downWallBe.UIHide();
		    if (rightDownWall != null) rightDownWallBe.UIHide();
		    SyncLegendaryGridEffectWithPriceUi();
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x4422CA8", Offset = "0x441ECA8", VA = "0x4422CA8")]
		[AsyncStateMachine(typeof(_003CCreatUIObj_003Ed__135))]
		private async void CreatUIObj()
		{
		    await CreatUIObjInternalAsync();
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x4425614", Offset = "0x4421614", VA = "0x4425614")]
		[AsyncStateMachine(typeof(_003CCreatUIObjInternalAsync_003Ed__136))]
		private async UniTask CreatUIObjInternalAsync()
		{
		    GlobalHexInfo landCfg = GetLandPriceHexGlobalInfo();
		    price = GetLandPriceInt(landCfg);
		    _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(landCfg.uiResPath);
		    if (_info != null && _info.id == "1001")
		    {
		        price = BattleGameSceneManager.Instance.GetGoldMinePrice(isEnemyHex);
		        _uiRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(DataManager.Instance.GlobalInfo.hexInfos[0].uiResPath);
		    }
		    if (_uiObj != null)
		    {
		        if (tmpUI != null) DG.Tweening.ShortcutExtensions.DOKill(tmpUI.transform, false);
		        UnityEngine.Object.Destroy(_uiObj);
		    }
		    _uiObj = UnityEngine.Object.Instantiate(_uiRes);
		    tmpUI = _uiObj.transform.Find("TextRenderer").GetComponent<TextMeshPro>();
		    UpdateCoinColor(BattleGameManager.Instance.hasCoin);
		    _uiObj.transform.localPosition = quality == Quality.UnCharted ? new Vector3(0f, 0f, 0.214f) : Vector3.zero;
		    _uiObj.transform.SetParent(transform, false);
		    if (_uiObj != null && isEnemyHex) _uiObj.SetActive(false);
		    if (_showIconUIObj != null && quality != Quality.UnCharted)
		    {
		        if (LegendaryTileGuaranteed || quality == Quality.ThreeStar) _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.47f);
		        else if (quality == Quality.TwoStar) _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.49f);
		        else if (quality == Quality.OneStar) _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.53f);
		    }
		    RefreshSubGameInflationPrice();
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x4422D34", Offset = "0x441ED34", VA = "0x4422D34")]
		[AsyncStateMachine(typeof(_003CCreatShowUIObj_003Ed__137))]
		private async void CreatShowUIObj()
		{
		    await CreatShowUIObjInternalAsync();
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x44256B0", Offset = "0x44216B0", VA = "0x44256B0")]
		[AsyncStateMachine(typeof(_003CCreatShowUIObjInternalAsync_003Ed__138))]
		private async UniTask CreatShowUIObjInternalAsync()
		{
		    if (_showIconUIObj != null) UnityEngine.Object.Destroy(_showIconUIObj);
		    if (_showIconUIRes == null && _info != null)
		    {
		        if (LegendaryTileGuaranteed)
		            _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUILegendaryTile.prefab");
		        else if (hexBuildType == HexType.soldierpile)
		            _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUISoldier.prefab");
		        else if (_info.type == "resources")
		            _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIRes.prefab");
		        else if (_info.type == "defense")
		            _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIDef.prefab");
		        else if (_info.type == "barracks")
		            _showIconUIRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/ShowIconUIBar.prefab");
		    }
		    if (_showIconUIRes == null) return;
		    _showIconUIObj = UnityEngine.Object.Instantiate(_showIconUIRes);
		    _showIconUIObj.transform.SetParent(transform, false);
		    _showIconUIObj.transform.localPosition = new Vector3(0f, 0.01f, 0.29f);
		    _showIconUIObj.SetActive(true);
		    if (_uiObj != null)
		    {
		        if (LegendaryTileGuaranteed || quality == Quality.ThreeStar)
		            _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.47f);
		        else if (quality == Quality.TwoStar)
		            _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.49f);
		        else if (quality == Quality.OneStar)
		            _uiObj.transform.localPosition = new Vector3(0f, 0f, -0.53f);
		    }
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x442574C", Offset = "0x442174C", VA = "0x442574C")]
		private void BeGetSpecialHex(object o)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x4425A18", Offset = "0x4421A18", VA = "0x4425A18")]
		[AsyncStateMachine(typeof(_003CSpecialHexLogic_003Ed__140))]
		private void SpecialHexLogic()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x4425AA8", Offset = "0x4421AA8", VA = "0x4425AA8")]
		[ContextMenu("SetToEnemy")]
		[AsyncStateMachine(typeof(_003CSetToEnemy_003Ed__141))]
		private void SetToEnemy()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x4425B38", Offset = "0x4421B38", VA = "0x4425B38")]
		[AsyncStateMachine(typeof(_003CSetToPlayer_003Ed__142))]
		[ContextMenu("SetToPlayer")]
		private void SetToPlayer()
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x442597C", Offset = "0x442197C", VA = "0x442597C")]
		[AsyncStateMachine(typeof(_003CUpdateHexState_003Ed__143))]
		private void UpdateHexState(HexBehaviour neighbor)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4425BC8", Offset = "0x4421BC8", VA = "0x4425BC8")]
		private void UpdateMaterial(bool isEnemy)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4425DB8", Offset = "0x4421DB8", VA = "0x4425DB8")]
		private void UpdateSpecialHexState()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4424644", Offset = "0x4420644", VA = "0x4424644")]
		[AsyncStateMachine(typeof(_003CUpdateHexItemUI_003Ed__146))]
		private async void UpdateHexItemUI(object o)
		{
		    if (isBridge || isOpened) return;
		    bool near = NearHasOpen();
		    if (isEnemyHex)
		    {
		        if (near)
		        {
		            if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(true);
		            if (_uiObj != null) _uiObj.SetActive(false);
		            if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		            canOpen = true;
		            if (!LegendaryTileGuaranteed && !ToolModule.StringTool.IsNullOrEmpty(_id, true) && !AIBehaviourManager.Instance.aiBattleCardID.Contains(_id))
		            {
		                if (TrainingGroundManager.IsInGuidedGame && rareLevel == RareLevel.SSSR)
		                {
		                    if (quality == Quality.ThreeStar) rareLevel = RareLevel.SSR;
		                    else if (quality == Quality.TwoStar) rareLevel = RareLevel.SR;
		                    else if (quality == Quality.OneStar) rareLevel = RareLevel.R;
		                    else rareLevel = RareLevel.Null;
		                }
		                RandomArchitectureInfoAndCardID(false);
		                if (_info != null && _id == "1001") quality = Quality.OneStar;
		                LoadShowIconRes();
		                CreatUIObj();
		                if (quality != Quality.UnCharted) CreatShowUIObj();
		                LoadArchitectureRes();
		            }
		            else if (_info != null && _info.id == "1001" && SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest) RefreshSubGameInflationPrice();
		        }
		        else
		        {
		            if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		            if (_uiObj != null) _uiObj.SetActive(false);
		            if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		            canOpen = false;
		        }
		    }
		    else
		    {
		        if (near)
		        {
		            if (LegendaryTileGuaranteed || ToolModule.StringTool.IsNullOrEmpty(_id, true) || DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList().Contains(ToolModule.StringTool.ToInt(_id)))
		            {
		                if (_info != null && _info.id == "1001" && SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest) RefreshSubGameInflationPrice();
		                if (_uiObj != null) _uiObj.SetActive(true);
		                if (_showIconUIObj != null) _showIconUIObj.SetActive(true);
		                else if (quality != Quality.UnCharted) CreatShowUIObj();
		                if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		            }
		            else
		            {
		                RandomArchitectureInfoAndCardID(false);
		                if (_info != null && _id == "1001") quality = Quality.OneStar;
		                LoadShowIconRes();
		                CreatUIObj();
		                if (quality != Quality.UnCharted) CreatShowUIObj();
		                LoadArchitectureRes();
		            }
		            canOpen = near;
		            UpdateCoinColor(BattleGameManager.Instance.hasCoin);
		        }
		        else
		        {
		            if (_uiObj != null) _uiObj.SetActive(false);
		            if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		            if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		            canOpen = false;
		        }
		    }
		    if (IsTrainingHexLocked()) canOpen = false;
		    SyncLegendaryGridEffectWithPriceUi();
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4425DD8", Offset = "0x4421DD8", VA = "0x4425DD8")]
		private void CreatWallJudge(object o)
		{
            if (isBridge) return;
            if (isOpened && _info == null && !hasArchitecture)
            {
                if (CheckNullHexShouldCreatWall())
                {
                    if (NullHexDesWallJudge(leftUpHexBehaviour) || (leftUpHexBehaviour != null && leftUpHexBehaviour.isSpecialHex && !leftUpHexBehaviour.isOpened)) DestroyWall(leftUpWall);
                    else if (leftUpWall == null || !leftUpWall.activeSelf) CreatWall(ref leftUpWall, WallType.LeftUp);
                    if (NullHexDesWallJudge(rightUpHexBehaviour) || (rightUpHexBehaviour != null && rightUpHexBehaviour.isSpecialHex && !rightUpHexBehaviour.isOpened)) DestroyWall(rightUpWall);
                    else if (rightUpWall == null || !rightUpWall.activeSelf) CreatWall(ref rightUpWall, WallType.RightUp);
                    if (NullHexDesWallJudge(upHexBehaviour) || (upHexBehaviour != null && upHexBehaviour.isSpecialHex && !upHexBehaviour.isOpened)) DestroyWall(upWall);
                    else if (upWall == null || !upWall.activeSelf) CreatWall(ref upWall, WallType.Up);
                    if (NullHexDesWallJudge(downHexBehaviour) || (downHexBehaviour != null && downHexBehaviour.isSpecialHex && !downHexBehaviour.isOpened)) DestroyWall(downWall);
                    else if (downWall == null || !downWall.activeSelf) CreatWall(ref downWall, WallType.Down);
                    if (NullHexDesWallJudge(leftDownHexBehaviour) || (leftDownHexBehaviour != null && leftDownHexBehaviour.isSpecialHex && !leftDownHexBehaviour.isOpened)) DestroyWall(leftDownWall);
                    else if (leftDownWall == null || !leftDownWall.activeSelf) CreatWall(ref leftDownWall, WallType.LeftDown);
                    if (NullHexDesWallJudge(rightDownHexBehaviour) || (rightDownHexBehaviour != null && rightDownHexBehaviour.isSpecialHex && !rightDownHexBehaviour.isOpened)) DestroyWall(rightDownWall);
                    else if (rightDownWall == null || !rightDownWall.activeSelf) CreatWall(ref rightDownWall, WallType.RightDown);
                    if (leftUpWallBe != null) leftUpWallBe.ChangeTagToOne();
                    if (upWallBe != null) upWallBe.ChangeTagToOne();
                    if (rightUpWallBe != null) rightUpWallBe.ChangeTagToOne();
                    if (leftDownWallBe != null) leftDownWallBe.ChangeTagToOne();
                    if (downWallBe != null) downWallBe.ChangeTagToOne();
                    if (rightDownWallBe != null) rightDownWallBe.ChangeTagToOne();
                    return;
                }
            }
            else
            {
                if (NearHasArchitecture())
                {
                    if (!NearHasOpen() || !hasArchitecture) return;
                    if (!NoNullHexCreatWallJudge(leftUpHexBehaviour) || (leftUpHexBehaviour != null && leftUpHexBehaviour.isSpecialHex && !leftUpHexBehaviour.isOpened)) DestroyWall(leftUpWall);
                    else if (leftUpWall == null || !leftUpWall.activeSelf) CreatWall(ref leftUpWall, WallType.LeftUp);
                    if (!NoNullHexCreatWallJudge(rightUpHexBehaviour) || (rightUpHexBehaviour != null && rightUpHexBehaviour.isSpecialHex && !rightUpHexBehaviour.isOpened)) DestroyWall(rightUpWall);
                    else if (rightUpWall == null || !rightUpWall.activeSelf) CreatWall(ref rightUpWall, WallType.RightUp);
                    if (!NoNullHexCreatWallJudge(upHexBehaviour) || (upHexBehaviour != null && upHexBehaviour.isSpecialHex && !upHexBehaviour.isOpened)) DestroyWall(upWall);
                    else if (upWall == null || !upWall.activeSelf) CreatWall(ref upWall, WallType.Up);
                    if (!NoNullHexCreatWallJudge(downHexBehaviour) || (downHexBehaviour != null && downHexBehaviour.isSpecialHex && !downHexBehaviour.isOpened)) DestroyWall(downWall);
                    else if (downWall == null || !downWall.activeSelf) CreatWall(ref downWall, WallType.Down);
                    if (!NoNullHexCreatWallJudge(leftDownHexBehaviour) || (leftDownHexBehaviour != null && leftDownHexBehaviour.isSpecialHex && !leftDownHexBehaviour.isOpened)) DestroyWall(leftDownWall);
                    else if (leftDownWall == null || !leftDownWall.activeSelf) CreatWall(ref leftDownWall, WallType.LeftDown);
                    if (!NoNullHexCreatWallJudge(rightDownHexBehaviour) || (rightDownHexBehaviour != null && rightDownHexBehaviour.isSpecialHex && !rightDownHexBehaviour.isOpened)) DestroyWall(rightDownWall);
                    else if (rightDownWall == null || !rightDownWall.activeSelf) CreatWall(ref rightDownWall, WallType.RightDown);
                    return;
                }
            }
            DestroyWall(leftUpWall); DestroyWall(rightUpWall); DestroyWall(upWall);
            DestroyWall(downWall); DestroyWall(leftDownWall); DestroyWall(rightDownWall);
        }

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4426924", Offset = "0x4422924", VA = "0x4426924")]
		private void DestroyWall(GameObject wall, bool isReally = false)
		{
            if (wall == null) return;
            if (isReally) UnityEngine.Object.Destroy(wall);
            else wall.SetActive(false);
        }

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x4426AA4", Offset = "0x4422AA4", VA = "0x4426AA4")]
		private void CreatWall(ref GameObject wall, WallType wallType)
		{
            switch ((int)wallType)
            {
                case 0: if (leftUpWallIsDead) return; break;
                case 1: if (upWallIsDead) return; break;
                case 2: if (rightUpWallIsDead) return; break;
                case 3: if (leftDownWallIsDead) return; break;
                case 4: if (downWallIsDead) return; break;
                case 5: if (rightDownWallIsDead) return; break;
            }
            if (wall != null) { wall.SetActive(true); return; }
            if (_isDoOpenHexAni) return;
            if (_stoneWallRes == null) UnityEngine.Debug.Log("想要实例化的墙资源是空的");
            wall = UnityEngine.Object.Instantiate(_stoneWallRes);
            StoneWallBehaviour behaviour = wall.AddComponent<StoneWallBehaviour>();
            behaviour.InitInfo(100, wallType, isEnemyHex, this);
            switch ((int)wallType)
            {
                case 0: wall.transform.Rotate(0f, 210f, 0f); wall.name += "_LeftUp"; leftUpWallBe = behaviour; break;
                case 1: wall.transform.Rotate(0f, 270f, 0f); wall.name += "_Up"; upWallBe = behaviour; break;
                case 2: wall.transform.Rotate(0f, 330f, 0f); wall.name += "_RightUp"; rightUpWallBe = behaviour; break;
                case 3: wall.transform.Rotate(0f, 150f, 0f); wall.name += "_LeftDown"; leftDownWallBe = behaviour; break;
                case 4: wall.transform.Rotate(0f, 90f, 0f); wall.name += "_Down"; downWallBe = behaviour; break;
                case 5: wall.transform.Rotate(0f, 30f, 0f); wall.name += "_RightDown"; rightDownWallBe = behaviour; break;
            }
            Vector3 position = CalcWallPos(wallType);
            if (wall != null)
            {
                wall.transform.localPosition = new Vector3(position.x, -1f, position.z);
                wall.transform.SetParent(transform);
                wall.transform.SetAsLastSibling();
                wall.transform.localScale = Vector3.one;
                if (!Pathfinding.AstarWebGLRuntimeConfig.DisableAstarRuntime && behaviour.uc != null)
                    behaviour.uc.Apply();
            }
        }

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x4424294", Offset = "0x4420294", VA = "0x4424294")]
		private Vector3 CalcWallPos(WallType type)
		{
            float angle;
            switch ((int)type)
            {
                case 0: angle = 300f; break;
                case 1: angle = 0f; break;
                case 2: angle = 60f; break;
                case 3: angle = 240f; break;
                case 4: angle = 180f; break;
                case 5: angle = 120f; break;
                default: angle = 0f; break;
            }
            return (Quaternion.Euler(0f, angle, 0f) * transform.forward).normalized * 0.9f + transform.position;
        }

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x44269E4", Offset = "0x44229E4", VA = "0x44269E4")]
		private bool NullHexDesWallJudge(HexBehaviour hex)
		{
            if (hex == null) return false;
            if (hex.hasArchitecture && !hex.isDestroy) return hex.isEnemyHex == isEnemyHex;
            return hex._info == null && hex.isOpened && !hex.hasArchitecture && !hex.isDestroy && hex.isEnemyHex == isEnemyHex;
        }

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x44274BC", Offset = "0x44234BC", VA = "0x44274BC")]
		private bool NoNullHexCreatWallJudge(HexBehaviour hex)
		{
            if (hex == null || hex.isEnemyHex != isEnemyHex) return true;
            if (hex.isEnemyHex == isEnemyHex && !hex.hasArchitecture && !hex.isOpened && !hex.isDestroy) return true;
            return hex.isEnemyHex == isEnemyHex && !hex.hasArchitecture && hex.isOpened && hex.isDestroy;
        }

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x442763C", Offset = "0x442363C", VA = "0x442763C")]
		private void HexOpenAndHexDestroyCheckNullHexShouldCreatWall(object o)
		{
            shouldHasWall = isOpened && _info == null && !hasArchitecture && CheckNullHexShouldCreatWall();
        }

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x44268A8", Offset = "0x44228A8", VA = "0x44268A8")]
		private bool CheckNullHexShouldCreatWall()
		{ return RecursiveCheck(this, new List<HexBehaviour>()); }

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x442767C", Offset = "0x442367C", VA = "0x442767C")]
		private bool RecursiveCheck(HexBehaviour hexagon, List<HexBehaviour> hexs)
		{
            hexs.Add(hexagon);
            if (hexagon.NearHasHasArchitectureReally()) return true;
            if (hexagon.leftUpHexBehaviour != null && hexagon.leftUpHexBehaviour.isOpened && hexagon.leftUpHexBehaviour._info == null && hexagon.leftUpHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.leftUpHexBehaviour) && RecursiveCheck(hexagon.leftUpHexBehaviour, hexs)) return true;
            if (hexagon.upHexBehaviour != null && hexagon.upHexBehaviour.isOpened && hexagon.upHexBehaviour._info == null && hexagon.upHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.upHexBehaviour) && RecursiveCheck(hexagon.upHexBehaviour, hexs)) return true;
            if (hexagon.rightUpHexBehaviour != null && hexagon.rightUpHexBehaviour.isOpened && hexagon.rightUpHexBehaviour._info == null && hexagon.rightUpHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.rightUpHexBehaviour) && RecursiveCheck(hexagon.rightUpHexBehaviour, hexs)) return true;
            if (hexagon.leftDownHexBehaviour != null && hexagon.leftDownHexBehaviour.isOpened && hexagon.leftDownHexBehaviour._info == null && hexagon.leftDownHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.leftDownHexBehaviour) && RecursiveCheck(hexagon.leftDownHexBehaviour, hexs)) return true;
            if (hexagon.downHexBehaviour != null && hexagon.downHexBehaviour.isOpened && hexagon.downHexBehaviour._info == null && hexagon.downHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.downHexBehaviour) && RecursiveCheck(hexagon.downHexBehaviour, hexs)) return true;
            return hexagon.rightDownHexBehaviour != null && hexagon.rightDownHexBehaviour.isOpened && hexagon.rightDownHexBehaviour._info == null && hexagon.rightDownHexBehaviour.isEnemyHex == isEnemyHex && !hexs.Contains(hexagon.rightDownHexBehaviour) && RecursiveCheck(hexagon.rightDownHexBehaviour, hexs);
        }

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4427C50", Offset = "0x4423C50", VA = "0x4427C50")]
		public bool HasActiveWallInDirection(int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4427E28", Offset = "0x4423E28", VA = "0x4427E28")]
		public bool GetActiveWallIsEnemyInDirection(int neighborOffset)
		{
			return default;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4422DC0", Offset = "0x441EDC0", VA = "0x4422DC0")]
		public bool NearHasOpen()
		{
		    if (leftUpHexBehaviour != null && leftUpHexBehaviour.isOpened && leftUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
		    if (rightUpHexBehaviour != null && rightUpHexBehaviour.isOpened && rightUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
		    if (upHexBehaviour != null && upHexBehaviour.isOpened && upHexBehaviour.isEnemyHex == isEnemyHex) return true;
		    if (downHexBehaviour != null && downHexBehaviour.isOpened && downHexBehaviour.isEnemyHex == isEnemyHex) return true;
		    if (leftDownHexBehaviour != null && leftDownHexBehaviour.isOpened && leftDownHexBehaviour.isEnemyHex == isEnemyHex) return true;
		    return rightDownHexBehaviour != null && rightDownHexBehaviour.isOpened && rightDownHexBehaviour.isEnemyHex == isEnemyHex;
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x4427128", Offset = "0x4423128", VA = "0x4427128")]
		private bool NearHasArchitecture()
		{
            if (leftUpHexBehaviour != null && (leftUpHexBehaviour.hasArchitecture || (leftUpHexBehaviour.isOpened && leftUpHexBehaviour._info == null && !leftUpHexBehaviour.isDestroy)) && leftUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (rightUpHexBehaviour != null && (rightUpHexBehaviour.hasArchitecture || (rightUpHexBehaviour.isOpened && rightUpHexBehaviour._info == null && !rightUpHexBehaviour.isDestroy)) && rightUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (upHexBehaviour != null && (upHexBehaviour.hasArchitecture || (upHexBehaviour.isOpened && upHexBehaviour._info == null && !upHexBehaviour.isDestroy)) && upHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (downHexBehaviour != null && (downHexBehaviour.hasArchitecture || (downHexBehaviour.isOpened && downHexBehaviour._info == null && !downHexBehaviour.isDestroy)) && downHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (leftDownHexBehaviour != null && (leftDownHexBehaviour.hasArchitecture || (leftDownHexBehaviour.isOpened && leftDownHexBehaviour._info == null && !leftDownHexBehaviour.isDestroy)) && leftDownHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (rightDownHexBehaviour != null && (rightDownHexBehaviour.hasArchitecture || (rightDownHexBehaviour.isOpened && rightDownHexBehaviour._info == null && !rightDownHexBehaviour.isDestroy)) && rightDownHexBehaviour.isEnemyHex == isEnemyHex) return true;
            return false;
        }

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x4427A4C", Offset = "0x4423A4C", VA = "0x4427A4C")]
		private bool NearHasHasArchitectureReally()
		{
            if (leftUpHexBehaviour != null && leftUpHexBehaviour.hasArchitecture && leftUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (rightUpHexBehaviour != null && rightUpHexBehaviour.hasArchitecture && rightUpHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (upHexBehaviour != null && upHexBehaviour.hasArchitecture && upHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (downHexBehaviour != null && downHexBehaviour.hasArchitecture && downHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (leftDownHexBehaviour != null && leftDownHexBehaviour.hasArchitecture && leftDownHexBehaviour.isEnemyHex == isEnemyHex) return true;
            if (rightDownHexBehaviour != null && rightDownHexBehaviour.hasArchitecture && rightDownHexBehaviour.isEnemyHex == isEnemyHex) return true;
            return false;
        }

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x4427F00", Offset = "0x4423F00", VA = "0x4427F00")]
		public bool IsCombo()
		{
			return default;
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x4428134", Offset = "0x4424134", VA = "0x4428134")]
		public int GetRoleCountByCamp(bool isEnemyRole)
		{
		    return (isEnemyRole ? _roleEnemyList : _rolePlayerList).Count;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x442818C", Offset = "0x442418C", VA = "0x442818C")]
		public RoleBehaviour GetRoleByCamp(bool isEnemyRole, int index)
		{
		    List<RoleBehaviour> roles = isEnemyRole ? _roleEnemyList : _rolePlayerList;
		    if (index < 0 || index >= roles.Count) return null;
		    return roles[index];
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4428230", Offset = "0x4424230", VA = "0x4428230")]
		public void MyUpdate()
		{
		    if (leftUpWallBe != null) leftUpWallBe.MyUpdate();
		    if (upWallBe != null) upWallBe.MyUpdate();
		    if (rightUpWallBe != null) rightUpWallBe.MyUpdate();
		    if (leftDownWallBe != null) leftDownWallBe.MyUpdate();
		    if (downWallBe != null) downWallBe.MyUpdate();
		    if (rightDownWallBe != null) rightDownWallBe.MyUpdate();
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4428468", Offset = "0x4424468", VA = "0x4428468")]
		[AsyncStateMachine(typeof(_003CEncroachmentEnemy_003Ed__169))]
		private async void EncroachmentEnemy()
		{
		    isEnemyHex = false;
		    BattleGameSceneManager.Instance.AddPlayerStayHex(gameObject);
		    BattleGameSceneManager.Instance.RemoveEnemyStayHex(gameObject);
		    ChangeWallLayer(isEnemyHex);
		    ChangeWallIsEnemy(isEnemyHex);
		    _stoneWallRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(isEnemyHex
		        ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/EnemyStoneWallRoot.prefab"
		        : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/PlayerStoneWallRoot.prefab");
		    if (isOpened && _info == null) EventModule.EventManager.Instance.TriggerEvent("UpdateHexItemUI");
		    MeshRenderer renderer = transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer>();
		    renderer.material = AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(false, key, BattleGameSceneManager.Instance.isSeasonPVP_BTest);
		    EventModule.EventManager.Instance.TriggerEvent("BothHexCountChange");
		    RefreshLegendaryTileCardForCurrentCamp();
		    if (!isSpecialHex)
		    {
		        RareLevel oldRare = rareLevel;
		        if (_id != "1001" && !LegendaryTileGuaranteed) RandomHexRare(false, BattleGameManager.Instance.playerNowGameOpenGoldCardEd, false);
		        if (NearHasOpen())
		        {
		            if (isBridge) goto AfterCardChanges;
		            bool reroll = false;
		            if (!LegendaryTileGuaranteed)
		            {
		                if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && !DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList().Contains(ToolModule.StringTool.ToInt(_id))) reroll = true;
		                if (!reroll && oldRare != rareLevel) reroll = true;
		            }
		            if (!reroll)
		            {
		                if (_info != null && _info.id == "1001" && SDKModule.ABTestManager.Instance.GoldMinePrice01IsBTest) RefreshSubGameInflationPrice();
		                if (_uiObj != null) _uiObj.SetActive(true);
		                if (_showIconUIObj != null)
		                {
		                    if (quality != Quality.UnCharted) _showIconUIObj.SetActive(true);
		                }
		                else if (quality != Quality.UnCharted) CreatShowUIObj();
		                Transform priceTransform = _uiObj.transform;
		                switch (quality)
		                {
		                    case Quality.OneStar: priceTransform.localPosition = new Vector3(0f, 0f, -0.53f); break;
		                    case Quality.TwoStar: priceTransform.localPosition = new Vector3(0f, 0f, -0.49f); break;
		                    case Quality.ThreeStar: priceTransform.localPosition = new Vector3(0f, 0f, -0.47f); break;
		                    default: priceTransform.localPosition = _uiObj.transform.localPosition; break;
		                }
		            }
		            else
		            {
		                RandomArchitectureInfoAndCardID(false);
		                SetHexSoldierPile(false, false);
		                if (_info != null && _id == "1001") quality = Quality.OneStar;
		                LoadShowIconRes();
		                CreatUIObj();
		                if (quality != Quality.UnCharted) CreatShowUIObj();
		                LoadArchitectureRes();
		            }
		            if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && _id == "1001" && DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic["1001"].level != AIBehaviourManager.Instance.cardLevelDic["1001"]) LoadArchitectureRes();
		        }
		        else
		        {
		            bool reroll = false;
		            if (!LegendaryTileGuaranteed)
		            {
		                if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && !DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList().Contains(ToolModule.StringTool.ToInt(_id))) reroll = true;
		                if (!reroll && oldRare != rareLevel) reroll = true;
		            }
		            if (!reroll)
		            {
		                if (_info != null && _info.id == "1001" && SDKModule.ABTestManager.Instance.GoldMinePrice01IsBTest) RefreshSubGameInflationPrice();
		            }
		            else
		            {
		                RandomArchitectureInfoAndCardID(false);
		                SetHexSoldierPile(false, false);
		                if (_info != null && _id == "1001") quality = Quality.OneStar;
		                LoadShowIconRes();
		                CreatUIObj();
		                if (quality != Quality.UnCharted) CreatShowUIObj();
		                if (_uiObj != null) _uiObj.SetActive(false);
		                if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		                if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		                LoadArchitectureRes();
		            }
		            if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && _id == "1001" && DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic["1001"].level != AIBehaviourManager.Instance.cardLevelDic["1001"]) LoadArchitectureRes();
		        }
		AfterCardChanges:
		        if (_enemyHexUIObj != null) _enemyHexUIObj.SetActive(false);
		        _res = isEnemyHex ? _enemyRes : _playerRes;
		        if (!isOpened)
		        {
		            canOpen = NearHasOpen();
		            if (canOpen)
		            {
		                if (_uiObj != null) _uiObj.gameObject.SetActive(!isEnemyHex);
		                if (_showIconUIObj != null) _showIconUIObj.gameObject.SetActive(!isEnemyHex);
		                if (_enemyHexUIObj != null) _enemyHexUIObj.gameObject.SetActive(isEnemyHex);
		            }
		            SyncLegendaryGridEffectWithPriceUi();
		        }
		    }
		    SubGameBuffManager.Instance.NotifyHexOwnershipChanged(this);
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x44284F8", Offset = "0x44244F8", VA = "0x44284F8")]
		private void SetLayerRecursively(Transform objTransform, string layerName)
		{
		    int layer = LayerMask.NameToLayer(layerName);
		    if (layer == -1)
		    {
		        UnityEngine.Debug.LogError("层级错误: " + layerName);
		        return;
		    }
		    objTransform.gameObject.layer = layer;
		    foreach (Transform child in objTransform) SetLayerRecursively(child, layerName);
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x442887C", Offset = "0x442487C", VA = "0x442887C")]
		private void ChangeWallLayer(bool toEnemyWall)
		{
		    if (leftUpWall != null) SetLayerRecursively(leftUpWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		    if (upWall != null) SetLayerRecursively(upWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		    if (rightUpWall != null) SetLayerRecursively(rightUpWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		    if (leftDownWall != null) SetLayerRecursively(leftDownWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		    if (downWall != null) SetLayerRecursively(downWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		    if (rightDownWall != null) SetLayerRecursively(rightDownWall.transform, toEnemyWall ? "EnemyWall" : "PlayerWall");
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4428B30", Offset = "0x4424B30", VA = "0x4428B30")]
		private void ChangeWallIsEnemy(bool isEnemy)
		{
		    if (leftUpWallBe != null) leftUpWallBe.isEnemy = isEnemy;
		    if (upWallBe != null) upWallBe.isEnemy = isEnemy;
		    if (rightUpWallBe != null) rightUpWallBe.isEnemy = isEnemy;
		    if (leftDownWallBe != null) leftDownWallBe.isEnemy = isEnemy;
		    if (downWallBe != null) downWallBe.isEnemy = isEnemy;
		    if (rightDownWallBe != null) rightDownWallBe.isEnemy = isEnemy;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4428CD0", Offset = "0x4424CD0", VA = "0x4428CD0")]
		[AsyncStateMachine(typeof(_003CEncroachmentPlayer_003Ed__173))]
		private async void EncroachmentPlayer()
		{
		    isEnemyHex = true;
		    BattleGameSceneManager.Instance.AddEnemyStayHex(gameObject);
		    BattleGameSceneManager.Instance.RemovePlayerStayHex(gameObject);
		    MeshRenderer renderer = transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer>();
		    renderer.material = AssetsModule.MaterialsManager.Instance.GetHexMaterialByKey(true, key, BattleGameSceneManager.Instance.isSeasonPVP_BTest);
		    ChangeWallLayer(isEnemyHex);
		    ChangeWallIsEnemy(isEnemyHex);
		    _stoneWallRes = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(isEnemyHex
		        ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/EnemyStoneWallRoot.prefab"
		        : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Wall/PlayerStoneWallRoot.prefab");
		    if (isOpened && _info == null) EventModule.EventManager.Instance.TriggerEvent("UpdateHexItemUI");
		    EventModule.EventManager.Instance.TriggerEvent("BothHexCountChange");
		    RefreshLegendaryTileCardForCurrentCamp();
		    if (!isSpecialHex)
		    {
		        if (!isBridge)
		        {
		            if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		            if (_uiObj != null) _uiObj.SetActive(false);
		            if (_enemyHexUIObj == null)
		            {
		                _enemyHexUIObj = UnityEngine.Object.Instantiate(_enemyHexUIRes);
		                _enemyHexUIObj.transform.SetParent(transform, false);
		            }
		            GameObject enemyUi = _enemyHexUIObj;
		            bool near = NearHasOpen();
		            enemyUi.SetActive(near);
		        }
		        RareLevel oldRare = rareLevel;
		        if (_id != "1001" && !LegendaryTileGuaranteed)
		        {
		            RandomHexRare(false, false, AIBehaviourManager.Instance.enemyNowGameOpenGoldCardEd);
		            if (TrainingGroundManager.IsInGuidedGame && rareLevel == RareLevel.SSSR)
		            {
		                if (quality == Quality.ThreeStar) rareLevel = RareLevel.SSR;
		                else if (quality == Quality.TwoStar) rareLevel = RareLevel.SR;
		                else if (quality == Quality.OneStar) rareLevel = RareLevel.R;
		                else rareLevel = RareLevel.Null;
		            }
		        }
		        bool reroll = false;
		        if (!LegendaryTileGuaranteed)
		        {
		            if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && !AIBehaviourManager.Instance.aiBattleCardID.Contains(_id)) reroll = true;
		            if (!reroll && oldRare != rareLevel) reroll = true;
		        }
		        if (!reroll)
		        {
		            if (_info != null && _info.id == "1001" && SDKModule.ABTestManager.Instance.GoldMinePriceV2IsBTest) RefreshSubGameInflationPrice();
		        }
		        else
		        {
		            RandomArchitectureInfoAndCardID(false);
		            SetHexSoldierPile(false, false);
		            if (_info != null && _id == "1001") quality = Quality.OneStar;
		            LoadShowIconRes();
		            CreatUIObj();
		            if (quality != Quality.UnCharted) CreatShowUIObj();
		            _uiObj.SetActive(false);
		            if (_showIconUIObj != null) _showIconUIObj.SetActive(false);
		            LoadArchitectureRes();
		        }
		        if (!ToolModule.StringTool.IsNullOrEmpty(_id, true) && _id == "1001" && DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic["1001"].level != AIBehaviourManager.Instance.cardLevelDic["1001"]) LoadArchitectureRes();
		        _res = isEnemyHex ? _enemyRes : _playerRes;
		        if (!isOpened)
		        {
		            canOpen = NearHasOpen();
		            if (canOpen)
		            {
		                if (_uiObj != null) _uiObj.gameObject.SetActive(!isEnemyHex);
		                if (_showIconUIObj != null) _showIconUIObj.gameObject.SetActive(!isEnemyHex);
		                if (_enemyHexUIObj != null) _enemyHexUIObj.gameObject.SetActive(isEnemyHex);
		            }
		            SyncLegendaryGridEffectWithPriceUi();
		        }
		    }
		    SubGameBuffManager.Instance.NotifyHexOwnershipChanged(this);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x4428D60", Offset = "0x4424D60", VA = "0x4428D60")]
		private int GetInflationBasePrice()
		{
		    if (_info != null && (_info.id == "1001" || _info.id == "1001")) return BattleGameSceneManager.Instance.GetGoldMinePrice(isEnemyHex);
		    if (LegendaryTileGuaranteed) return GetLandPriceInt(GetLandPriceHexGlobalInfo());
		    if (SubGameBuffManager.Instance.IsActive && SubGameBuffManager.Instance.HasBuff(1001) && quality == Quality.UnCharted) return 25;
		    return ToolModule.StringTool.ToInt(DataManager.Instance.GlobalInfo.hexInfos[(int)quality].price);
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4428EDC", Offset = "0x4424EDC", VA = "0x4428EDC")]
		public void RefreshSubGameInflationPrice()
		{
		    price = GetInflationBasePrice();
		    SubGameBuffManager.Instance.ModifyHexOpenPrice(ref price, isEnemyHex);
		    if (tmpUI != null)
		    {
		        tmpUI.text = price.ToString();
		        UpdateCoinColor(BattleGameManager.Instance.hasCoin);
		    }
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x4428FD4", Offset = "0x4424FD4", VA = "0x4428FD4")]
		private void OnDestroy()
		{
            RemoveFromDirtyHexUIBatches();
            if (transform != null) DG.Tweening.ShortcutExtensions.DOKill(transform, false);
            if (tmpUI != null) DG.Tweening.ShortcutExtensions.DOKill(tmpUI.transform, false);
            DestroyWall(leftUpWall, true);
            DestroyWall(rightUpWall, true);
            DestroyWall(upWall, true);
            DestroyWall(downWall, true);
            DestroyWall(leftDownWall, true);
            DestroyWall(rightDownWall, true);
            if (resBoxObj != null) UnityEngine.Object.Destroy(resBoxObj);
            if (soilderObj != null)
            {
                for (int i = 0; i < soilderObj.Length; i++)
                    UnityEngine.Object.Destroy(soilderObj[i]);
            }
            if (_obj != null) UnityEngine.Object.Destroy(_obj);
            global::EventModule.EventManager.Instance.StopListening("CraetHexEnd", UpdateHexItemUIEvent);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", UpdateHexItemUIEvent);
            global::EventModule.EventManager.Instance.StopListening("UpdateHexItemUI", UpdateHexItemUIEvent);
            global::EventModule.EventManager.Instance.StopListening("CraetHexEnd", CheckCanOpen);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", CheckCanOpen);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", CreatWallJudge);
            global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", CreatWallJudge);
            global::EventModule.EventManager.Instance.StopListening("CraetHexEndCreatMainTower", CreatMainTower);
            global::EventModule.EventManager.Instance.StopListening("PlayerCoinChange", UpdateCoinColorEvent);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", CheckGraphUpdateScene);
            global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", CheckGraphUpdateScene);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
            global::EventModule.EventManager.Instance.StopListening("HasHexDestroy", HexOpenAndHexDestroyCheckNullHexShouldCreatWall);
            global::EventModule.EventManager.Instance.StopListening("HasWallDestroy", UpdateAllWallState);
            global::EventModule.EventManager.Instance.StopListening("HasHexOpen", BeGetSpecialHex);
            global::EventModule.EventManager.Instance.StopListening("LableSystemPlayerRefreshHex", LableTestPlayerRefeshHex);
            global::EventModule.EventManager.Instance.StopListening("LableSystemEnemyRefreshHex", LableSystemEnemyRefreshHex);
            leftDownHexBehaviour = null;
            rightDownHexBehaviour = null;
            upHexBehaviour = null;
            downHexBehaviour = null;
            leftUpHexBehaviour = null;
            rightUpHexBehaviour = null;
            if (tmpUI != null)
            {
                UnityEngine.Object.Destroy(tmpUI);
                tmpUI = null;
            }
            if (resBoxObj != null) UnityEngine.Object.Destroy(resBoxObj);
        }

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x44298EC", Offset = "0x44258EC", VA = "0x44298EC")]
		private void DetermineHexCamp()
		{
			if (isOpened) return;
			int playerCount = _rolePlayerList.Count;
			int enemyCount = _roleEnemyList.Count;
			if (playerCount == 0 && enemyCount == 0) return;
			if (playerCount > 0 && enemyCount > 0) return;
			if (playerCount > 0 && isEnemyHex)
			{
			    EncroachmentEnemy();
			    return;
			}
			if (enemyCount > 0 && !isEnemyHex) EncroachmentPlayer();
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x44299B0", Offset = "0x44259B0", VA = "0x44299B0")]
		public void AddRole(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
			_characterIds.Add(instanceId);
			List<RoleBehaviour> roles = player ? _rolePlayerList : _roleEnemyList;
			if (!roles.Contains(roleBehaviour)) roles.Add(roleBehaviour);
			DetermineHexCamp();
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4429AE8", Offset = "0x4425AE8", VA = "0x4429AE8")]
		public void RemoveRole(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
			_characterIds.Remove(instanceId);
			(player ? _rolePlayerList : _roleEnemyList).Remove(roleBehaviour);
			DetermineHexCamp();
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4429B8C", Offset = "0x4425B8C", VA = "0x4429B8C")]
		public void RefreshRoleCamp(int instanceId, bool player, RoleBehaviour roleBehaviour)
		{
			_characterIds.Add(instanceId);
			_rolePlayerList.Remove(roleBehaviour);
			_roleEnemyList.Remove(roleBehaviour);
			List<RoleBehaviour> roles = player ? _rolePlayerList : _roleEnemyList;
			if (!roles.Contains(roleBehaviour)) roles.Add(roleBehaviour);
			DetermineHexCamp();
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4429D00", Offset = "0x4425D00", VA = "0x4429D00")]
		public HexBehaviour[] GetNeighborsArray()
		{
			return new[] { leftUpHexBehaviour, rightUpHexBehaviour, upHexBehaviour,
			    downHexBehaviour, leftDownHexBehaviour, rightDownHexBehaviour };
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4429E70", Offset = "0x4425E70", VA = "0x4429E70")]
		public void HideRole()
		{
            GameObject[] roles = soilderObj;
            if (roles != null)
                for (int i = 0; i < roles.Length; i++) roles[i].gameObject.SetActive(false);
        }

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4429EE4", Offset = "0x4425EE4", VA = "0x4429EE4")]
		public void RefreshSubGamePriceDisplay()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4429F84", Offset = "0x4425F84", VA = "0x4429F84", Slot = "4")]
		public void OnTutorialClick()
		{
		    OpenHex(isEnemyHex, false);
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x4429F90", Offset = "0x4425F90", VA = "0x4429F90")]
		public HexBehaviour()
		{
			_characterIds = new HashSet<int>();
			_roleEnemyList = new List<RoleBehaviour>();
			_rolePlayerList = new List<RoleBehaviour>();
		}
	}
}
