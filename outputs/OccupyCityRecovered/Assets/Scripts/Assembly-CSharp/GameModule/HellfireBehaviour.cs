using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200026F")]
	public class HellfireBehaviour : MonoBehaviour
	{
		[Token(Token = "0x2000270")]
		[CompilerGenerated]
		private sealed class _003CBulletRainRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001F55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HellfireBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003Celapsed_003E5__2;

			[Token(Token = "0x4001F57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 _003Ccenter_003E5__3;

			[Token(Token = "0x170000C4")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AA7")]
				[Address(RVA = "0x438A950", Offset = "0x4386950", VA = "0x438A950", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000C5")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA9")]
				[Address(RVA = "0x438A990", Offset = "0x4386990", VA = "0x438A990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x438A580", Offset = "0x4386580", VA = "0x438A580")]
			[DebuggerHidden]
			public _003CBulletRainRoutine_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x438A680", Offset = "0x4386680", VA = "0x438A680", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x438A684", Offset = "0x4386684", VA = "0x438A684", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x438A950", Offset = "0x4386950", VA = "0x438A950", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x438A958", Offset = "0x4386958", VA = "0x438A958", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x438A990", Offset = "0x4386990", VA = "0x438A990", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000271")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HellfireBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4001F5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int damage;

			[Token(Token = "0x4001F5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string roleId;

			[Token(Token = "0x4001F5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isBuild;

			[Token(Token = "0x4001F5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EntityBase source;

			[Token(Token = "0x4001F60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool isLandRole;

			[Token(Token = "0x4001F61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4001F62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public CardFettersType fetterType;

			[Token(Token = "0x4001F63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float delayTime;

			[Token(Token = "0x4001F64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x438A998", Offset = "0x4386998", VA = "0x438A998", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x438B068", Offset = "0x4387068", VA = "0x438B068", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int damage;

		[Token(Token = "0x4001F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string roleId;

		[Token(Token = "0x4001F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isBuild;

		[Token(Token = "0x4001F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EntityBase source;

		[Token(Token = "0x4001F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isLandRole;

		[Token(Token = "0x4001F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private AtkWayType atkWayType;

		[Token(Token = "0x4001F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CardFettersType fetterType;

		[Token(Token = "0x4001F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool isEnemy;

		[Token(Token = "0x4001F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool skillIng;

		[Token(Token = "0x4001F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float jtime;

		[Token(Token = "0x4001F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("技能设置")]
		[SerializeField]
		private GameObject bulletPrefab;

		[Token(Token = "0x4001F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x4001F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float duration;

		[Token(Token = "0x4001F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float spawnInterval;

		[Token(Token = "0x4001F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float spawnHeight;

		[Token(Token = "0x4001F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine rainCoroutine;

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x438A22C", Offset = "0x438622C", VA = "0x438A22C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__16))]
		public void Init(bool isEnemy, int damage, string roleId, bool isBuild, EntityBase source, bool isLandRole, AtkWayType atkWayType, CardFettersType fetterType, float delayTime)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x438A33C", Offset = "0x438633C", VA = "0x438A33C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x438A4BC", Offset = "0x43864BC", VA = "0x438A4BC")]
		private void CastSkill()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x438A55C", Offset = "0x438655C", VA = "0x438A55C")]
		private void StopSkill()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x438A4FC", Offset = "0x43864FC", VA = "0x438A4FC")]
		[IteratorStateMachine(typeof(_003CBulletRainRoutine_003Ed__20))]
		private IEnumerator BulletRainRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x4386814", Offset = "0x4382814", VA = "0x4386814")]
		public void AllTargetWound(List<RoleBehaviour> role)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x438A384", Offset = "0x4386384", VA = "0x438A384")]
		private void Cleanup()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x438A5A8", Offset = "0x43865A8", VA = "0x438A5A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x438A66C", Offset = "0x438666C", VA = "0x438A66C")]
		public HellfireBehaviour()
		{
		}
	}
}
