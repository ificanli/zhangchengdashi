using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000263")]
	public class CatapultsBulletBehaviour : BulletBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000265")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CatapultsBulletBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4001F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool isLand;

			[Token(Token = "0x4001F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public EntityBase obj;

			[Token(Token = "0x4001F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int atk;

			[Token(Token = "0x4001F09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isEffBullet;

			[Token(Token = "0x4001F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EntityBase fireObj;

			[Token(Token = "0x4001F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x4385AC4", Offset = "0x4381AC4", VA = "0x4385AC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                CatapultsBulletBehaviour self = _003C_003E4__this;
                try
                {
                    UniTask.Awaiter awaiter;
                    if (_003C_003E1__state == 0)
                    {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    }
                    else
                    {
                        _003C_003Ec__DisplayClass2_0 closure = new _003C_003Ec__DisplayClass2_0();
                        closure._003C_003E4__this = self;
                        closure.isEnemy = isEnemy;
                        closure.isLand = isLand;
                        self._003Cn__0(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
                        if (obj == null)
                        {
                            global::AssetsModule.ObjPoolManager pool = global::AssetsModule.ObjPoolManager.Instance;
                            pool.Recycle(self.gameObject);
                            goto Complete;
                        }
                        Vector3 endPosition = obj.transform.position;
                        Vector3 startPosition = self.transform.position;
                        float distance = Vector3.Distance(endPosition, startPosition);
                        float duration;
                        float extra;
                        if (distance <= 2f) { duration = 0.4f; extra = 0.9f; }
                        else if (distance <= 4f) { duration = 0.6f; extra = 0.6f; }
                        else if (distance <= 6f) { duration = 0.8f; extra = 0.3f; }
                        else { duration = 1f; goto Jump; }
                        float scaled = extra * (float)self.attack;
                        int bonus = float.IsPositiveInfinity(scaled) ? int.MinValue : float.IsNaN(scaled) ? 0
                            : scaled >= int.MaxValue ? int.MaxValue : scaled <= int.MinValue ? int.MinValue : (int)scaled;
                        self.attack = unchecked(self.attack + bonus);
                    Jump:
                        DG.Tweening.Sequence jump = DG.Tweening.ShortcutExtensions.DOJump(self.transform, endPosition, 2f, 1, duration, false);
                        jump.onComplete += closure._003CInitInfo_003Eb__0;
                        GameObject fire = self.transform.Find("Fire").gameObject;
                        fire.SetActive(true);
                        fire.GetComponent<ParticleSystem>().Play();
                        awaiter = UniTask.WaitForSeconds(duration + 0.25f, false, (PlayerLoopTiming)8, default, false).GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                    }
                    awaiter.GetResult();
                    self.Clear();
                    global::AssetsModule.ObjPoolManager recyclePool = global::AssetsModule.ObjPoolManager.Instance;
                    recyclePool.Recycle(self.gameObject);
                }
                catch (global::System.Exception error)
                {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(error);
                    return;
                }
            Complete:
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetResult();
            }

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x438623C", Offset = "0x438223C", VA = "0x438623C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{ _003C_003Et__builder.SetStateMachine(stateMachine); }
		}

		[Token(Token = "0x4001EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 catapultsPos;

		[Token(Token = "0x4001EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float exploseRange = 0.7f;

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x4385668", Offset = "0x4381668", VA = "0x4385668", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__2))]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
            _003CInitInfo_003Ed__2 stateMachine = default;
            stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine.obj = obj;
            stateMachine.atk = atk;
            stateMachine.isEnemy = isEnemy;
            stateMachine.isEffBullet = isEffBullet;
            stateMachine.fireObj = fireObj;
            stateMachine.isLand = isLand;
            stateMachine.fettersType = fettersType;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x4385760", Offset = "0x4381760", VA = "0x4385760")]
		public void InitExploseRange(float num)
		{ exploseRange = num; }

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x4385768", Offset = "0x4381768", VA = "0x4385768", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x438576C", Offset = "0x438176C", VA = "0x438576C", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4385770", Offset = "0x4381770", VA = "0x4385770")]
		public void InitCatapultsPos(Vector3 pos)
		{ catapultsPos = pos; }

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x438577C", Offset = "0x438177C", VA = "0x438577C", Slot = "10")]
		protected override void Clear()
		{
            base.Clear();
            catapultsPos = Vector3.zero;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            exploseRange = 0.7f;
        }

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x4385804", Offset = "0x4381804", VA = "0x4385804")]
		public CatapultsBulletBehaviour()
		{
		}
	
        [Token(Token = "0x2000264")]
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass2_0
        {
            [Token(Token = "0x4001EFF")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
            public CatapultsBulletBehaviour _003C_003E4__this;
            [Token(Token = "0x4001F00")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
            public bool isEnemy;
            [Token(Token = "0x4001F01")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x19")]
            public bool isLand;
            [Token(Token = "0x6000A68")]
            [Address(RVA = "0x4385824", Offset = "0x4381824", VA = "0x4385824")]
            public _003C_003Ec__DisplayClass2_0() { }
            [Token(Token = "0x6000A69")]
            [Address(RVA = "0x438582C", Offset = "0x438182C", VA = "0x438582C")]
            internal void _003CInitInfo_003Eb__0()
            {
                global::AssetsModule.EffectManager effect = global::AssetsModule.EffectManager.Instance;
                effect.ShowEffect("Assets/_Res/Addressable/EffectsBundle/Effects/Boom.prefab", _003C_003E4__this.transform.position, Vector3.zero, 1f);
                Vector3 center = _003C_003E4__this.transform.position;
                Collider[] hits = Physics.OverlapSphere(center, _003C_003E4__this.exploseRange);
                for (int i = 0; i < hits.Length; i++)
                {
                    EntityBase target = hits[i].GetComponent<EntityBase>();
                    if (target != null && target.isEnemy != isEnemy)
                    {
                        CatapultsBulletBehaviour owner = _003C_003E4__this;
                        target.Wound(owner.attack, owner.id, owner.isBuild, owner.fireObj, isLand, AtkWayType.Remote, owner.fettersType, null);
                        global::UnityEngine.Events.UnityAction action = _003C_003E4__this.callback;
                        if (action != null) action();
                    }
                }
                _003C_003E4__this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
        }

        [Token(Token = "0x6000A67")]
        [Address(RVA = "0x4385814", Offset = "0x4381814", VA = "0x4385814")]
        [CompilerGenerated]
        [DebuggerHidden]
        private void _003Cn__0(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, EntityBase fireObj, bool isLand, CardFettersType fettersType)
        {
            base.InitInfo(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
        }
}
}
