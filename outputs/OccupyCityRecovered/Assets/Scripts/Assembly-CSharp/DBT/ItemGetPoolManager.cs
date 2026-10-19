using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DBT
{
	[Token(Token = "0x2000F6A")]
	public class ItemGetPoolManager : MonoBehaviour
	{
		[Token(Token = "0x2000F6B")]
		[CompilerGenerated]
		private sealed class _003CAnimateCoin_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006A72")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006A73")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006A74")]
			[FieldOffset(Offset = "0x20")]
			public FlyItem coin;

			[Token(Token = "0x4006A75")]
			[FieldOffset(Offset = "0x28")]
			public float spreadDuration;

			[Token(Token = "0x4006A76")]
			[FieldOffset(Offset = "0x30")]
			public ItemGetPoolManager _003C_003E4__this;

			[Token(Token = "0x4006A77")]
			[FieldOffset(Offset = "0x38")]
			public Vector3 startPos;

			[Token(Token = "0x4006A78")]
			[FieldOffset(Offset = "0x44")]
			public Vector3 spreadOffset;

			[Token(Token = "0x4006A79")]
			[FieldOffset(Offset = "0x50")]
			public float flyDuration;

			[Token(Token = "0x4006A7A")]
			[FieldOffset(Offset = "0x54")]
			public Vector3 targetPos;

			[Token(Token = "0x4006A7B")]
			[FieldOffset(Offset = "0x60")]
			private RectTransform _003CrectTransform_003E5__2;

			[Token(Token = "0x4006A7C")]
			[FieldOffset(Offset = "0x68")]
			private Vector3 _003CoriginalScale_003E5__3;

			[Token(Token = "0x4006A7D")]
			[FieldOffset(Offset = "0x74")]
			private Vector3 _003CsmallScale_003E5__4;

			[Token(Token = "0x4006A7E")]
			[FieldOffset(Offset = "0x80")]
			private float _003Celapsed_003E5__5;

			[Token(Token = "0x4006A7F")]
			[FieldOffset(Offset = "0x84")]
			private Vector3 _003CspreadPos_003E5__6;

			[Token(Token = "0x17000F86")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005C97")]
				[Address(RVA = "0x43B1E38", Offset = "0x43ADE38", VA = "0x43B1E38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F87")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005C99")]
				[Address(RVA = "0x43B1E78", Offset = "0x43ADE78", VA = "0x43B1E78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005C94")]
			[Address(RVA = "0x43B1A9C", Offset = "0x43ADA9C", VA = "0x43B1A9C")]
			[DebuggerHidden]
			public _003CAnimateCoin_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005C95")]
			[Address(RVA = "0x43B1BA0", Offset = "0x43ADBA0", VA = "0x43B1BA0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005C96")]
			[Address(RVA = "0x43B1BA4", Offset = "0x43ADBA4", VA = "0x43B1BA4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005C97")]
			[Address(RVA = "0x43B1E38", Offset = "0x43ADE38", VA = "0x43B1E38", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005C98")]
			[Address(RVA = "0x43B1E40", Offset = "0x43ADE40", VA = "0x43B1E40", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005C99")]
			[Address(RVA = "0x43B1E78", Offset = "0x43ADE78", VA = "0x43B1E78", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006A6D")]
		[FieldOffset(Offset = "0x0")]
		public static ItemGetPoolManager Instance;

		[Token(Token = "0x4006A6E")]
		[FieldOffset(Offset = "0x20")]
		public NewObjectPool<PoolObjectBase> Pool;

		[Token(Token = "0x4006A6F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<FlyItemType, FlyItemData> ItemPool;

		[Token(Token = "0x4006A70")]
		[FieldOffset(Offset = "0x30")]
		public List<FlyItemData> ItemPoolList;

		[Token(Token = "0x4006A71")]
		[FieldOffset(Offset = "0x38")]
		private Canvas canvas;

		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x43B1240", Offset = "0x43AD240", VA = "0x43B1240")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x43B15BC", Offset = "0x43AD5BC", VA = "0x43B15BC")]
		private void InitPool(FlyItemData itemData)
		{
		}

		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x43B161C", Offset = "0x43AD61C", VA = "0x43B161C")]
		public static void CreateItem(FlyItemType itemType, int num, Vector3 startPos)
		{
		}

		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x43B1748", Offset = "0x43AD748", VA = "0x43B1748")]
		public void _CreateItem(FlyItemType itemType, int num, Vector3 startPos)
		{
		}

		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x43B19BC", Offset = "0x43AD9BC", VA = "0x43B19BC")]
		[IteratorStateMachine(typeof(_003CAnimateCoin_003Ed__9))]
		private IEnumerator AnimateCoin(FlyItem coin, Vector3 startPos, Vector3 spreadOffset, Vector3 targetPos, float spreadDuration, float flyDuration)
		{
			return null;
		}

		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x43B1AC4", Offset = "0x43ADAC4", VA = "0x43B1AC4")]
		private float EaseOutQuad(float t)
		{
			float num = 2f - t;
			return num * t;
		}

		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x43B1AD4", Offset = "0x43ADAD4", VA = "0x43B1AD4")]
		private float EaseInQuad(float t)
		{
			return t * t;
		}

		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x43B1ADC", Offset = "0x43ADADC", VA = "0x43B1ADC")]
		public ItemGetPoolManager()
		{
		}
	}
}
