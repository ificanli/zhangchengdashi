using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000268")]
	public class HelicopterBulletBehaviour : BulletBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000269")]
		[CompilerGenerated]
		private struct _003CFollowBezierPath_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HelicopterBulletBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 _003ClastPosition_003E5__2;

			[Token(Token = "0x4001F22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x4387CB8", Offset = "0x4383CB8", VA = "0x4387CB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                HelicopterBulletBehaviour bullet = _003C_003E4__this;
                try {
                    Cysharp.Threading.Tasks.YieldAwaitable.Awaiter awaiter;
                    int state = _003C_003E1__state;
                    if (state == 0 || state == 1) {
                        awaiter = _003C_003Eu__1;
                        _003C_003Eu__1 = default;
                        _003C_003E1__state = -1;
                        awaiter.GetResult();
                    } else {
                        bullet.currentTime = 0f;
                        _003ClastPosition_003E5__2 = bullet.transform.position;
                    }
                    while (bullet.currentTime < bullet.flightDuration && bullet.isMoving) {
                        if (BattleGameManager.Instance != null && BattleGameManager.Instance.IsGamePaused) {
                            awaiter = UniTask.Yield().GetAwaiter();
                            if (!awaiter.IsCompleted) {
                                _003C_003E1__state = 0;
                                _003C_003Eu__1 = awaiter;
                                _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                                return;
                            }
                            awaiter.GetResult();
                            continue;
                        }
                        bullet.currentTime += Time.deltaTime;
                        float t = Mathf.Clamp01(bullet.currentTime / bullet.flightDuration);
                        Vector3 position = bullet.CalculateBezierPoint(t, bullet.curvePath);
                        Vector3 direction = position - _003ClastPosition_003E5__2;
                        if (direction != Vector3.zero) {
                            direction = direction.normalized;
                            if (direction != Vector3.zero)
                                bullet.transform.forward = direction;
                            _003ClastPosition_003E5__2 = position;
                        }
                        bullet.transform.position = position;
                        awaiter = UniTask.Yield().GetAwaiter();
                        if (!awaiter.IsCompleted) {
                            _003C_003E1__state = 1;
                            _003C_003Eu__1 = awaiter;
                            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                            return;
                        }
                        awaiter.GetResult();
                    }
                    bullet.OnTargetReached();
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetResult();
                } catch (System.Exception exception) {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                }
            }

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x438830C", Offset = "0x438430C", VA = "0x438830C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
                _003C_003Et__builder.SetStateMachine(stateMachine);
            }
		}

		[Token(Token = "0x4001F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int curvePoints = 10;

		[Token(Token = "0x4001F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float flightDuration = 2f;

		[Token(Token = "0x4001F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float height = 3f;

		[Token(Token = "0x4001F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int randomControlPoints = 2;

		[Token(Token = "0x4001F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float controlPointRadius = 2f;

		[Token(Token = "0x4001F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector3> curvePath = new List<Vector3>();

		[Token(Token = "0x4001F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float currentTime;

		[Token(Token = "0x4001F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool isMoving = true;

		[Token(Token = "0x4001F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float speedFactor = 0.05f;

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x43872D4", Offset = "0x43832D4", VA = "0x43872D4", Slot = "4")]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
            base.InitInfo(obj, atk, isEnemy, isEffBullet, fireObj, isLand, fettersType);
            isMoving = true;
            speedFactor = 0.1f;
            GenerateRandomBezierPath();
            FollowBezierPath();
            if (WeeklyCardActivityManager.Instance.IsBTest())
                attack /= 2;
        }

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x43873D0", Offset = "0x43833D0", VA = "0x43873D0")]
		private void GenerateRandomBezierPath()
		{
            if (_target == null) return;
            curvePath.Clear();
            Vector3 start = transform.position;
            Vector3 end = _target.transform.position;
            flightDuration = Vector3.Distance(start, end) * speedFactor;
            curvePath.Add(start);
            for (int i = 0; i < randomControlPoints; i++) {
                float t = ((float)i + 1f) / ((float)randomControlPoints + 1f);
                Vector3 point = Vector3.Lerp(start, end, t);
                float x = UnityEngine.Random.Range(-controlPointRadius, controlPointRadius);
                float y = UnityEngine.Random.Range(0f, height);
                float z = UnityEngine.Random.Range(-controlPointRadius, controlPointRadius);
                curvePath.Add(point + new Vector3(x, y, z));
            }
            curvePath.Add(end);
        }

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x4387784", Offset = "0x4383784", VA = "0x4387784")]
		[AsyncStateMachine(typeof(_003CFollowBezierPath_003Ed__11))]
		private UniTask FollowBezierPath()
		{
            var stateMachine = new _003CFollowBezierPath_003Ed__11 {
                _003C_003Et__builder = AsyncUniTaskMethodBuilder.Create(),
                _003C_003E4__this = this,
                _003C_003E1__state = -1
            };
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
            return stateMachine._003C_003Et__builder.Task;
        }

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x4387810", Offset = "0x4383810", VA = "0x4387810")]
		public void RandomSpeedFactor()
		{
            speedFactor = UnityEngine.Random.Range(0.05f, 0.1f);
        }

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x438783C", Offset = "0x438383C", VA = "0x438783C")]
		private Vector3 CalculateBezierPoint(float t, List<Vector3> points)
		{
            if (points.Count == 0) return Vector3.zero;
            if (points.Count == 1) return points[0];
            var current = new List<Vector3>(points);
            while (current.Count > 1) {
                var next = new List<Vector3>();
                for (int i = 0; i < current.Count - 1; i++)
                    next.Add(Vector3.Lerp(current[i], current[i + 1], t));
                current = next;
            }
            return current[0];
        }

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x4387AA8", Offset = "0x4383AA8", VA = "0x4387AA8", Slot = "10")]
		protected override void Clear()
		{
            base.Clear();
            curvePath.Clear();
            currentTime = 0f;
            isMoving = false;
        }

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x4387B08", Offset = "0x4383B08", VA = "0x4387B08")]
		private void OnTargetReached()
		{
            isMoving = false;
            global::AssetsModule.EffectManager.Instance.ShowEffect(
                "Assets/_Res/Addressable/EffectsBundle/Effects/ExplosionRoundFire.prefab",
                transform.position, default, 1f);
            BulletDamageLogic();
            Clear();
            global::AssetsModule.ObjPoolManager.Instance.Recycle(gameObject);
        }

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x4387C08", Offset = "0x4383C08", VA = "0x4387C08", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x4387C0C", Offset = "0x4383C0C", VA = "0x4387C0C")]
		public HelicopterBulletBehaviour()
		{
		}
	}
}
