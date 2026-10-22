using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200026B")]
	public class RangerBulletBehaviour : BulletBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200026C")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RangerBulletBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public EntityBase obj;

			[Token(Token = "0x4001F2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int atk;

			[Token(Token = "0x4001F2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool isEnemy;

			[Token(Token = "0x4001F2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool isEffBullet;

			[Token(Token = "0x4001F30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public EntityBase fireObj;

			[Token(Token = "0x4001F31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isLand;

			[Token(Token = "0x4001F32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001F33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001F34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x4388D14", Offset = "0x4384D14", VA = "0x4388D14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                RangerBulletBehaviour bullet = _003C_003E4__this;
                try {
                    UniTask<GameObject>.Awaiter assetAwaiter;
                    UniTask.Awaiter delayAwaiter;
                    int state = _003C_003E1__state;
                    if (state == 1) {
                        delayAwaiter = _003C_003Eu__2;
                        _003C_003Eu__2 = default;
                        _003C_003E1__state = -1;
                        goto FinishWait;
                    }
                    if (state == 0) {
                        assetAwaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                    } else {
                        bullet._003C_003En__0(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
                        if (obj != null) {
                            float x = obj.transform.position.x;
                            float y = bullet.transform.position.y;
                            float z = obj.transform.position.z;
                            bullet.beginDir = (new Vector3(x, y, z) - bullet.transform.position).normalized;
                        } else {
                            bullet.beginDir = (Vector3.zero - bullet.transform.position).normalized;
                        }
                        bullet.transform.rotation = Quaternion.LookRotation(bullet.beginDir, Vector3.up);
                        assetAwaiter = global::AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(
                            "Assets/_Res/Addressable/EffectsBundle/Effects/Flash.prefab").GetAwaiter();
                        if (!assetAwaiter.IsCompleted) {
                            _003C_003E1__state = 0;
                            _003C_003Eu__1 = assetAwaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref assetAwaiter, ref this);
                            return;
                        }
                    }
                    GameObject prefab = assetAwaiter.GetResult();
                    bullet.go = UnityEngine.Object.Instantiate(prefab);
                    Transform effectTransform = bullet.go.transform;
                    effectTransform.position = bullet.transform.position + bullet.offset;
                    delayAwaiter = UniTask.WaitForSeconds(3, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
                    if (!delayAwaiter.IsCompleted) {
                        _003C_003E1__state = 1;
                        _003C_003Eu__2 = delayAwaiter;
                        _003C_003Et__builder.AwaitUnsafeOnCompleted(ref delayAwaiter, ref this);
                        return;
                    }
                FinishWait:
                    delayAwaiter.GetResult();
                    bullet.Clear();
                    global::AssetsModule.ObjPoolManager.Instance.Recycle(bullet.gameObject);
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x43896A8", Offset = "0x43856A8", VA = "0x43896A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[Token(Token = "0x4001F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 beginDir;

		[Token(Token = "0x4001F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject go;

		[Token(Token = "0x4001F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 offset = new Vector3(0f, 0f, 0.5f);

		[Token(Token = "0x4001F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CardTalentTreeData _treeData;

		[Token(Token = "0x4001F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float critObb;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x4388574", Offset = "0x4384574", VA = "0x4388574", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__5))]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
            var stateMachine = new _003CInitInfo_003Ed__5 {
                _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
                _003C_003E4__this = this,
                obj = obj, atk = atk, isEnemy = isEnemy, isEffBullet = isEffBullet,
                fireObj = fireObj, isLand = isLand, fettersType = fettersType,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
        }

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x438866C", Offset = "0x438466C", VA = "0x438866C", Slot = "7")]
		protected override void Rebound()
		{
            base.Rebound();
            float x = _target.transform.position.x;
            float y = transform.position.y;
            float z = _target.transform.position.z;
            beginDir = (new Vector3(x, y, z) - transform.position).normalized;
            transform.rotation = Quaternion.LookRotation(beginDir, Vector3.up);
        }

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x4388848", Offset = "0x4384848", VA = "0x4388848", Slot = "5")]
		protected override void Update()
		{
            try {
                if (BattleGameManager.Instance != null && BattleGameManager.Instance.IsGamePaused)
                    return;
                transform.Translate(Vector3.forward * (Time.deltaTime * 20f));
                if (go != null)
                    go.transform.position = transform.position;
            } catch (System.Exception) {
                throw;
            }
        }

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x4388A50", Offset = "0x4384A50", VA = "0x4388A50", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
            try {
                if (other == null || other.gameObject == null) return;
                EntityBase target = other.GetComponent<EntityBase>();
                if (target == null || target.isEnemy == isEnemy || target.isDead) return;
                int damage = attack;
                int roll = UnityEngine.Random.Range(0, 100);
                if (critObb * 100f > (float)roll)
                    damage <<= 1;
                target.Wound(damage, id, isBuild, fireObj, isLandBullet, AtkWayType, fettersType, null);
                callback?.Invoke();
            } catch (System.Exception) {
                throw;
            }
        }

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x4388C44", Offset = "0x4384C44", VA = "0x4388C44")]
		public void InitTreeData(CardTalentTreeData treeData)
		{
            _treeData = treeData;
        }

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x4388C4C", Offset = "0x4384C4C", VA = "0x4388C4C")]
		public void InitCrittObb(float critObb)
		{
            this.critObb = critObb;
        }

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x4388C54", Offset = "0x4384C54", VA = "0x4388C54", Slot = "10")]
		protected override void Clear()
		{
            base.Clear();
            beginDir = default;
            if (go != null)
                UnityEngine.Object.Destroy(go);
        }

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x4388CF4", Offset = "0x4384CF4", VA = "0x4388CF4")]
		public RangerBulletBehaviour()
		{
		}
        [Token(Token = "0x6000A91")]
        [Address(RVA = "0x4388D04", Offset = "0x4384D04", VA = "0x4388D04")]
        [CompilerGenerated]
        [DebuggerHidden]
        private void _003C_003En__0(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, EntityBase fireObj, bool isLand, CardFettersType fettersType)
        {
            base.InitInfo(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
        }

	}
}
