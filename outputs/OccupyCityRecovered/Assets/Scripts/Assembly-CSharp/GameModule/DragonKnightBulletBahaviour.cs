using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000267")]
	public class DragonKnightBulletBahaviour : BulletBehaviour
	{
		[Token(Token = "0x4001F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 en;

		[Token(Token = "0x4001F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CardTalentTreeData _treeData;

		[Token(Token = "0x4001F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float critObb;

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x4386A58", Offset = "0x4382A58", VA = "0x4386A58", Slot = "4")]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
            base.InitInfo(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
            EntityBase selected = obj;
            if (selected == null)
                selected = BattleGameSceneManager.Instance.GetNearObj(isEnemy, Vector3.zero, false, true, -1f, null);
            if (selected == null) {
                Clear();
                global::AssetsModule.ObjPoolManager.Instance.Recycle(gameObject);
                return;
            }
            en = selected.transform.position;
        }

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x4386C5C", Offset = "0x4382C5C", VA = "0x4386C5C")]
		public void InitTreeData(CardTalentTreeData treeData)
		{
            _treeData = treeData;
        }

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x4386C64", Offset = "0x4382C64", VA = "0x4386C64")]
		public void InitCrittObb(float critObb)
		{
            this.critObb = critObb;
        }

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x4386C6C", Offset = "0x4382C6C", VA = "0x4386C6C", Slot = "6")]
		protected override void BulletLogic()
		{
            try {
                if (BattleGameManager.Instance != null && BattleGameManager.Instance.IsGamePaused)
                    return;
                _endPos = en;
                Transform bulletTransform = transform;
                Vector3 current = transform.position;
                Vector3 destination = _endPos;
                float step = Time.deltaTime * (_isEffBullet ? 10f : 25f);
                bulletTransform.position = Vector3.MoveTowards(current, destination, step);
                if (Vector3.Distance(transform.position, _endPos) <= 0.2f) {
                    global::AssetsModule.EffectManager.Instance.ShowEffect(
                        "Assets/_Res/Addressable/EffectsBundle/Effects/ExplosionRoundFire.prefab",
                        transform.position + Vector3.up, default, 1f);
                    Collider[] hits = Physics.OverlapSphere(transform.position, 0.8f);
                    for (int i = 0; i < hits.Length; i++) {
                        EntityBase target = hits[i].GetComponent<EntityBase>();
                        if (target != null && target.isEnemy != isEnemy) {
                            int damage = attack;
                            int roll = UnityEngine.Random.Range(0, 100);
                            if (critObb * 100f > (float)roll)
                                damage <<= 1;
                            target.Wound(damage, id, isBuild, fireObj, isLandBullet, AtkWayType, fettersType, null);
                            callback?.Invoke();
                        }
                    }
                    Clear();
                    global::AssetsModule.ObjPoolManager.Instance.Recycle(gameObject);
                }
            } catch (System.Exception) {
                throw;
            }
        }

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x43872A8", Offset = "0x43832A8", VA = "0x43872A8", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x43872AC", Offset = "0x43832AC", VA = "0x43872AC", Slot = "10")]
		protected override void Clear()
		{
            base.Clear();
            en = default;
            _treeData = null;
            critObb = 0f;
        }

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x43872D0", Offset = "0x43832D0", VA = "0x43872D0")]
		public DragonKnightBulletBahaviour()
		{
		}
	}
}
