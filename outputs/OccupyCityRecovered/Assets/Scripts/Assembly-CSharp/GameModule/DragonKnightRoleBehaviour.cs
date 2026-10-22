using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000327")]
	public class DragonKnightRoleBehaviour : TerranBehaviour
	{
        [System.Serializable]
        [Token(Token = "0x2000328")]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            [Token(Token = "0x40023A8")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

            [Token(Token = "0x40023A9")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
            public static TweenCallback _003C_003E9__4_0;

            [Token(Token = "0x6000E4D")]
            [Address(RVA = "0x3D6E39C", Offset = "0x3D6A39C", VA = "0x3D6E39C")]
            public _003C_003Ec() { }

            [Token(Token = "0x6000E4E")]
            [Address(RVA = "0x3D6E3A4", Offset = "0x3D6A3A4", VA = "0x3D6E3A4")]
            internal void _003CDragonKnightSkill_003Eb__4_0() { }
        }

		[Token(Token = "0x2000329")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40023AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion qu;

			[Token(Token = "0x40023AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TweenCallback _003C_003E9__2;

			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x3D6E3A8", Offset = "0x3D6A3A8", VA = "0x3D6E3A8")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x3D6E3B0", Offset = "0x3D6A3B0", VA = "0x3D6E3B0")]
			internal void _003CDragonKnightSkill_003Eb__1()
			{
                DragonKnightRoleBehaviour role = _003C_003E4__this;
                _ = role.transform.rotation.eulerAngles;
                var tween = role.transform.DORotate(new Vector3(0f, 0f, 360f), 0.6f, (RotateMode)3);
                TweenCallback callback = _003C_003E9__2;
                if (callback == null)
                    callback = _003C_003E9__2 = _003CDragonKnightSkill_003Eb__2;
                tween.onComplete += callback;
            }

			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x3D6E4D8", Offset = "0x3D6A4D8", VA = "0x3D6E4D8")]
			internal void _003CDragonKnightSkill_003Eb__2()
			{
                DragonKnightRoleBehaviour role = _003C_003E4__this;
                if (role.isDead || role == null) return;
                _003C_003E4__this.transform.DORotateQuaternion(qu, 0.2f);
            }

			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x3D6E580", Offset = "0x3D6A580", VA = "0x3D6E580")]
			internal void _003CDragonKnightSkill_003Eb__3()
			{
                _003C_003E4__this.SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Attack,
                    GPUInstanceAnimationBehaviour.AnimationName.Idle, false);
                _003C_003E4__this.AtkCallBack(_003C_003E4__this.PropertyTemp.attack);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032A")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40023AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x40023B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x3D6E5D0", Offset = "0x3D6A5D0", VA = "0x3D6E5D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                DragonKnightRoleBehaviour role = _003C_003E4__this;
                try {
                    UniTask.Awaiter awaiter;
                    if (_003C_003E1__state != 0) {
                        if (role.isDead) goto Completed;
                        if (!role.Skilling) {
                            role._003C_003En__1(attackNum);
                            goto Completed;
                        }
                        GameObject bulletObject = global::AssetsModule.ObjPoolManager.Instance.GetFromPool(role.bulletProRes, -1f, true, 3);
                        Transform bulletTransform = bulletObject.transform;
                        bulletTransform.position = role.transform.position;
                        DragonKnightBulletBahaviour bullet = bulletObject.GetComponent<DragonKnightBulletBahaviour>();
                        bullet.InitID(role.PropertyTemp.id);
                        if (role.SkillTartget == null) {
                            EntityBase selected = BattleGameSceneManager.Instance.GetNearObj(role.isEnemy, Vector3.zero, false, true, -1f, null);
                            if (selected != null && selected.gameObject != null)
                                role.SkillTartget = selected.gameObject;
                        }
                        if (role.SkillTartget == null) goto Completed;
                        EntityBase target = role.SkillTartget.GetComponent<EntityBase>();
                        int attack = role.PropertyTemp.attack;
                        float multiplier = role.SkillNumber;
                        bool enemy = role.isEnemy;
                        bool land = role.PropertyTemp.roleType == "land";
                        bullet.InitInfo(target, (int)multiplier * attack, enemy, false, role, land, role.CardFettersType);
                        bullet.InitTreeData(role.TalentTreeData);
                        bullet.InitCrittObb(role.PropertyTemp.critObb);
                        if (role.PropertyTemp.vampireObb > 0f)
                            bullet.AddCallBack(role.Vampire);
                        awaiter = UniTask.WaitForSeconds(0.5f, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
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
                    if (role == null) goto Completed;
                    var tween = role.transform.DOMove(role.beginPos, 0.5f, false);
                    tween.onComplete += role._003CAtkCallBack_003Eb__5_0;
                Completed:
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x3D6EDD0", Offset = "0x3D6ADD0", VA = "0x3D6EDD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032B")]
		[CompilerGenerated]
		private struct _003CDragonKnightSkill_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40023B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x40023B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x3D6EDDC", Offset = "0x3D6ADDC", VA = "0x3D6EDDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                DragonKnightRoleBehaviour role = _003C_003E4__this;
                try {
                    UniTask.Awaiter awaiter;
                    if (_003C_003E1__state != 0) {
                        _003C_003E8__1 = new _003C_003Ec__DisplayClass4_0();
                        _003C_003E8__1._003C_003E4__this = _003C_003E4__this;
                        if (role.isDead) goto Completed;
                        role.Skilling = true;
                        role.SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Idle, false);
                        role.beginPos = role.transform.position;
                        Vector3[] path = new Vector3[2];
                        path[0] = role.beginPos;
                        path[1] = new Vector3(role.beginPos.x, role.beginPos.y + 6f, role.beginPos.z);
                        _003C_003E8__1.qu = role.transform.rotation;
                        var rise = role.transform.DOPath(path, 1f, (PathType)1, (PathMode)1, 10, default);
                        TweenCallback emptyCallback = _003C_003Ec._003C_003E9__4_0;
                        if (emptyCallback == null)
                            emptyCallback = _003C_003Ec._003C_003E9__4_0 = _003C_003Ec._003C_003E9._003CDragonKnightSkill_003Eb__4_0;
                        rise.onComplete += emptyCallback;
                        var lookUp = role.transform.DOLookAt(path[1], 0.2f, (AxisConstraint)0, default);
                        lookUp.onComplete += _003C_003E8__1._003CDragonKnightSkill_003Eb__1;
                        awaiter = UniTask.WaitForSeconds(1f, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
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
                    if (role.isDead || role == null) goto Completed;
                    EntityBase selected = BattleGameSceneManager.Instance.GetNearObj(role.isEnemy, Vector3.zero, false, true, -1f, null);
                    if (selected != null)
                        role.SkillTartget = selected.gameObject;
                    if (role == null) goto Completed;
                    if (role.SkillTartget == null) {
                        UnityEngine.Debug.Log("\u6ca1\u6709\u83b7\u5f97\u5230\u76ee\u6807  \u6ca1\u8fdb\u884c\u653b\u51fb\u52a8\u4f5c \u98de\u5230\u534a\u7a7a\u4e2d\u505c\u6b62\u4e86====>");
                        goto Completed;
                    }
                    Transform roleTransform = role.transform;
                    Vector3 targetPosition = role.SkillTartget.transform.position;
                    var lookAtTarget = roleTransform.DOLookAt(targetPosition, 0.2f, (AxisConstraint)0, default);
                    lookAtTarget.onComplete += _003C_003E8__1._003CDragonKnightSkill_003Eb__3;
                Completed:
                    _003C_003E8__1 = null;
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E8__1 = null;
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x3D6F738", Offset = "0x3D6B738", VA = "0x3D6F738", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200032C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40023B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40023B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40023B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DragonKnightRoleBehaviour _003C_003E4__this;

			[Token(Token = "0x40023BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GlobalRoleInfo info;

			[Token(Token = "0x40023BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isEnemy;

			[Token(Token = "0x40023BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int cardLevel;

			[Token(Token = "0x40023BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RareLevel rareLevel;

			[Token(Token = "0x40023BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string relativeCardID;

			[Token(Token = "0x40023BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x40023C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x40023C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x3D6F744", Offset = "0x3D6B744", VA = "0x3D6F744", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                var self = _003C_003E4__this;
                UniTask<GameObject>.Awaiter awaiter;
                try
                {
                    if (_003C_003E1__state != 0)
                    {
                        if (global::System.Object.ReferenceEquals(self, null))
                            throw new global::System.NullReferenceException();
                        self._003C_003En__0(info, isEnemy, cardLevel, rareLevel, relativeCardID, fettersType, atkWayType);
                        awaiter = AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/Bullet/DragonKnightFireBall.prefab").GetAwaiter();
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
                    self.bulletProRes = awaiter.GetResult();
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

			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x3D6FA5C", Offset = "0x3D6BA5C", VA = "0x3D6FA5C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[Token(Token = "0x40023A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private GameObject bulletProRes;

		[Token(Token = "0x40023A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private Vector3 beginPos;

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x3D6E0EC", Offset = "0x3D6A0EC", VA = "0x3D6E0EC", Slot = "20")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
            _003CInit_003Ed__2 stateMachine = default;
            stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine.info = info;
            stateMachine.isEnemy = isEnemy;
            stateMachine.cardLevel = cardLevel;
            stateMachine.rareLevel = rareLevel;
            stateMachine.relativeCardID = relativeCardID;
            stateMachine.fettersType = fettersType;
            stateMachine.atkWayType = atkWayType;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x3D6E1D0", Offset = "0x3D6A1D0", VA = "0x3D6E1D0", Slot = "31")]
		protected override void EmitSkill()
		{
            base.EmitSkill();
            DragonKnightSkill();
        }

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x3D6E1EC", Offset = "0x3D6A1EC", VA = "0x3D6E1EC")]
		[AsyncStateMachine(typeof(_003CDragonKnightSkill_003Ed__4))]
		private void DragonKnightSkill()
		{
            var stateMachine = new _003CDragonKnightSkill_003Ed__4 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x3D6E27C", Offset = "0x3D6A27C", VA = "0x3D6E27C", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__5))]
		protected override void AtkCallBack(int attackNum)
		{
            var stateMachine = new _003CAtkCallBack_003Ed__5 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                attackNum = attackNum,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x3D6E31C", Offset = "0x3D6A31C", VA = "0x3D6E31C")]
		public DragonKnightRoleBehaviour()
		{
		}

        [Token(Token = "0x6000E49")]
        [Address(RVA = "0x3D6E324", Offset = "0x3D6A324", VA = "0x3D6E324")]
        [CompilerGenerated]
        [DebuggerHidden]
        private void _003C_003En__0(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, string relativeCardID, CardFettersType fettersType, AtkWayType atkWayType)
        {
            base.Init(info, isEnemy, cardLevel, rareLevel, relativeCardID, fettersType, atkWayType);
        }
        [Token(Token = "0x6000E4A")]
        [Address(RVA = "0x3D6E330", Offset = "0x3D6A330", VA = "0x3D6E330")]
        [CompilerGenerated]
        private void _003CAtkCallBack_003Eb__5_0()
        {
            Skilling = false;
        }

        [Token(Token = "0x6000E4B")]
        [Address(RVA = "0x3D6E338", Offset = "0x3D6A338", VA = "0x3D6E338")]
        [DebuggerHidden]
        [CompilerGenerated]
        private void _003C_003En__1(int attackNum)
        {
            base.AtkCallBack(attackNum);
        }

	}
}
