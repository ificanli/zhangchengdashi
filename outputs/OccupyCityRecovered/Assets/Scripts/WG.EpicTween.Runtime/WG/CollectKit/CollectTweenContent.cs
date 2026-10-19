using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace WG.CollectKit
{
	[Token(Token = "0x200000A")]
	public class CollectTweenContent : MonoBehaviour
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		public string resourceId;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		public SingleCollection collectPrefab;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x30")]
		private Transform bezierMidPoint;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x38")]
		private Transform targetTrans;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x40")]
		private Transform targetTransFollowerTransform;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x48")]
		public AnimationType animationType;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x4C")]
		public bool useObjectPool;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x50")]
		private List<SingleCollection> _collectionPool;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x58")]
		public Action<int> onSingleValueReached;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x60")]
		private List<CollectionsContainer> _containers;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x68")]
		private List<CollectionsContainer> _recyclingContainers;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x70")]
		private RenderMode _canvasRenderMode;

		[Token(Token = "0x1700000F")]
		public Transform TargetTransFollowerTransform
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x854DA50", Offset = "0x8549A50", VA = "0x854DA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x854DA58", Offset = "0x8549A58", VA = "0x854DA58")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float AccelerateIntensity
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x854DB28", Offset = "0x8549B28", VA = "0x854DB28")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x854DB30", Offset = "0x8549B30", VA = "0x854DB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float RandomIntensity
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x854DB38", Offset = "0x8549B38", VA = "0x854DB38")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x854DB40", Offset = "0x8549B40", VA = "0x854DB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x854DB48", Offset = "0x8549B48", VA = "0x854DB48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x854DCC4", Offset = "0x8549CC4", VA = "0x854DCC4")]
		public CollectionsContainer StartCollectTween(Vector3 startPosition, Transform endPointTrans, int collectValue)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x854DE98", Offset = "0x8549E98", VA = "0x854DE98")]
		public CollectionsContainer StartCollectTween(Transform endPointTrans, int collectValue)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x854DEE4", Offset = "0x8549EE4", VA = "0x854DEE4")]
		public CollectionsContainer StartCollectTween(Vector3 startPosition, int collectValue)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x854DFCC", Offset = "0x8549FCC", VA = "0x854DFCC")]
		public CollectionsContainer StartCollectTween(Vector3 startPosition, int collectValue, float duration, int flyCount)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x854DCD0", Offset = "0x8549CD0", VA = "0x854DCD0")]
		public CollectionsContainer StartCollectTween(Vector3 startPosition, Transform endPointTrans, int collectValue, float duration, int count)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x854E468", Offset = "0x854A468", VA = "0x854E468")]
		private void Update()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x854E0BC", Offset = "0x854A0BC", VA = "0x854E0BC")]
		public List<SingleCollection> GetCollections(int count)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x854E9B8", Offset = "0x854A9B8", VA = "0x854E9B8")]
		public Vector3 GetBezierPos(SingleCollection singleCollection, Vector3 center)
		{
			return default;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x854EAC0", Offset = "0x854AAC0", VA = "0x854EAC0")]
		public Vector3 GetBezierPos(SingleCollection singleCollection, Vector3 center, float t)
		{
			return default;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x854EA60", Offset = "0x854AA60", VA = "0x854EA60")]
		public Vector3 GetBezierPos(float t, Vector3 start, Vector3 center, Vector3 end)
		{
			return default;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x854E990", Offset = "0x854A990", VA = "0x854E990")]
		public void HandleCollection(SingleCollection collection)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x854EB4C", Offset = "0x854AB4C", VA = "0x854EB4C")]
		private void NormalBezierHandle(SingleCollection collection)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x854EBAC", Offset = "0x854ABAC", VA = "0x854EBAC")]
		private void RandomBezierHandle(SingleCollection collection)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x854ECD0", Offset = "0x854ACD0", VA = "0x854ECD0")]
		private void DelayFlyHandle(SingleCollection collection)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x854EF1C", Offset = "0x854AF1C", VA = "0x854EF1C")]
		public CollectTweenContent()
		{
		}
	}
}
