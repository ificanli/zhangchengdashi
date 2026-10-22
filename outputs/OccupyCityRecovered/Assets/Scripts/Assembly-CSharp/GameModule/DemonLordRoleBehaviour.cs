using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000323")]
	public class DemonLordRoleBehaviour : UndeadBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000324")]
		[CompilerGenerated]
		private struct _003CDemonLordSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4002393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x4002396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x3D6D0C4", Offset = "0x3D690C4", VA = "0x3D6D0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                DemonLordRoleBehaviour role = _003C_003E4__this;
                try {
                    UniTask.Awaiter awaiter;
                    if (_003C_003E1__state != 0) {
                        if (role.TargetBehaviour != null && role.TargetType == TargetType.Architecture)
                            goto Cancelled;
                        if (role.isEnemy && BattleGameSceneManager.Instance.allPlayerRoleObj.Count < 1)
                            goto Cancelled;
                        if (!role.isEnemy && BattleGameSceneManager.Instance.allEnemyRoleObj.Count <= 0)
                            goto Cancelled;
                        role.Skilling = true;
                        role.SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Idle, false);
                        role.SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Attack,
                            GPUInstanceAnimationBehaviour.AnimationName.Idle, false);
                        awaiter = UniTask.WaitForSeconds(0.3f, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
                        if (!awaiter.IsCompleted) {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    } else {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    awaiter.GetResult();
                    if (!role.isDead)
                        role.AtkCallBack(role.PropertyTemp.attack);
                    goto Completed;
                Cancelled:
                    role.coolingComplete = false;
                    float retryTime = Time.time;
                    float required = role.skillRequireCount;
                    role.Skilling = false;
                    role.skillCompleteTime = retryTime - required + 1f;
                Completed:
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x3D6D544", Offset = "0x3D69544", VA = "0x3D6D544", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000325")]
		[CompilerGenerated]
		private struct _003CDemonLordSkillLogic_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400239A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x3D6D550", Offset = "0x3D69550", VA = "0x3D6D550", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                DemonLordRoleBehaviour role = _003C_003E4__this;
                try {
                    UniTask.Awaiter awaiter;
                    if (_003C_003E1__state != 0) {
                        if (!CoreGameManager.Gaming) {
                            role.EmitHellFireIng = false;
                            goto Completed;
                        }
                        role.EmitHellFireIng = true;
                        GameObject instance = UnityEngine.Object.Instantiate(role.res);
                        instance.transform.localScale = Vector3.one * 2f;
                        if (role.TargetBehaviour != null) {
                            Transform effectTransform = instance.transform;
                            effectTransform.position = role.TargetBehaviour.transform.position;
                        } else {
                            RoleBehaviour selected = BattleGameSceneManager.Instance.GetRoleTargetSync(role.transform, role.isEnemy, 10000f);
                            if (selected == null) {
                                Transform effectTransform = instance.transform;
                                effectTransform.position = role.transform.position;
                                goto Completed;
                            }
                            Transform targetTransform = instance.transform;
                            targetTransform.position = selected.transform.position;
                        }
                        HellfireBehaviour hellfire = instance.GetComponent<HellfireBehaviour>();
                        int attack = role.PropertyTemp.attack;
                        string sourceId = role.PropertyTemp.id;
                        bool enemy = role.isEnemy;
                        float multiplier = role.SkillNumber;
                        bool land = role.PropertyTemp.roleType == "land";
                        hellfire.Init(enemy, (int)(multiplier * (float)attack), sourceId, false, role,
                            land, role.AtkWayType, role.CardFettersType, 3f);
                        BattleGameSceneManager.Instance.AddHellfire(hellfire);
                        awaiter = UniTask.WaitForSeconds(3.1f, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
                        if (!awaiter.IsCompleted) {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    } else {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    awaiter.GetResult();
                    role.EmitHellFireIng = false;
                Completed:
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x3D6DC68", Offset = "0x3D69C68", VA = "0x3D6DC68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000326")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x400239B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400239C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400239D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DemonLordRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x400239E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x400239F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x3D6DC74", Offset = "0x3D69C74", VA = "0x3D6DC74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                DemonLordRoleBehaviour role = _003C_003E4__this;
                try {
                    UniTask<GameObject>.Awaiter awaiter;
                    if (_003C_003E1__state != 0) {
                        role._003C_003En__0(info, isEnemy, cardLevel, rareLevel, relativeCardID, fettersType, atkWayType);
                        if (WeeklyCardActivityManager.Instance.IsBTest()) {
                            var weekly = global::DbtSaveDataManager_PlayerCoreData.I.Data.userWeeklyActivityData;
                            if (weekly.unLockActivity && weekly.cycleCardType == WeeklyCardActivityManager.CycleCardType.DemonLord) {
                                RolePropertyTemp property = role.PropertyTemp;
                                int attack = property.attack;
                                int hp = property.hp;
                                attack = unchecked(attack + (int)((float)attack * 0.2f));
                                hp = unchecked(hp + (int)((float)hp * 0.2f));
                                property.hp = hp;
                                property.maxHp = hp;
                                property.attack = attack;
                                role.bornAttack = attack;
                                role.OnHealthChangeTalentTrigger();
                            }
                        }
                        if (!(role.SkillNumber > 0f)) goto Completed;
                        string path = isEnemy
                            ? "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Bullet/HellFireBlue.prefab"
                            : "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Bullet/HellFireGreen.prefab";
                        awaiter = global::AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(path).GetAwaiter();
                        if (!awaiter.IsCompleted) {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    } else {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    role.res = awaiter.GetResult();
                Completed:
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x3D6E0E0", Offset = "0x3D6A0E0", VA = "0x3D6E0E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[Token(Token = "0x4002391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
		public bool EmitHellFireIng;

		[Token(Token = "0x4002392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private GameObject res;

		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x3D6CE5C", Offset = "0x3D68E5C", VA = "0x3D6CE5C", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
            var stateMachine = new _003CInit_003Ed__2 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                info = info, isEnemy = isEnemy, cardLevel = cardLevel,
                rareLevel = rareLevel, relativeCardID = relativeCardID,
                fettersType = fettersType, atkWayType = atkWayType,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x3D6CF40", Offset = "0x3D68F40", VA = "0x3D6CF40", Slot = "31")]
		protected override void EmitSkill()
		{
            base.EmitSkill();
            DemonLordSkill();
        }

		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x3D6CF5C", Offset = "0x3D68F5C", VA = "0x3D6CF5C")]
		[AsyncStateMachine(typeof(_003CDemonLordSkill_003Ed__4))]
		private void DemonLordSkill()
		{
            var stateMachine = new _003CDemonLordSkill_003Ed__4 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x3D6CFE8", Offset = "0x3D68FE8", VA = "0x3D6CFE8", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
            if (isDead) return;
            if (Skilling) {
                DemonLordSkillLogic();
                Skilling = false;
            } else {
                base.AtkCallBack(attackNum);
            }
        }

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x3D6D024", Offset = "0x3D69024", VA = "0x3D6D024")]
		[AsyncStateMachine(typeof(_003CDemonLordSkillLogic_003Ed__6))]
		private void DemonLordSkillLogic()
		{
            var stateMachine = new _003CDemonLordSkillLogic_003Ed__6 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x3D6D0B0", Offset = "0x3D690B0", VA = "0x3D6D0B0")]
		public DemonLordRoleBehaviour()
		{
		}
        [Token(Token = "0x6000E3D")]
        [Address(RVA = "0x3D6D0B8", Offset = "0x3D690B8", VA = "0x3D6D0B8")]
        [CompilerGenerated]
        [DebuggerHidden]
        private void _003C_003En__0(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, string relativeCardID, CardFettersType fettersType, AtkWayType atkWayType)
        {
            base.Init(info, isEnemy, cardLevel, rareLevel, relativeCardID, fettersType, atkWayType);
        }

	}
}
