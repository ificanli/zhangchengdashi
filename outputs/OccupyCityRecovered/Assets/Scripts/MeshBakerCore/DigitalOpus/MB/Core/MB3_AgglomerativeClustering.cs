using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x2000045")]
	public class MB3_AgglomerativeClustering
	{
		[Serializable]
		[Token(Token = "0x2000046")]
		public class ClusterNode
		{
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x10")]
			public item_s leaf;

			[Token(Token = "0x4000124")]
			[FieldOffset(Offset = "0x18")]
			public ClusterNode cha;

			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x20")]
			public ClusterNode chb;

			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x28")]
			public int height;

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x2C")]
			public float distToMergedCentroid;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 centroid;

			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x40")]
			public int[] leafs;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x48")]
			public int idx;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x4C")]
			public bool isUnclustered;

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x744B038", Offset = "0x7447038", VA = "0x744B038")]
			public ClusterNode(item_s ii, int index)
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x744B508", Offset = "0x7447508", VA = "0x744B508")]
			public ClusterNode(ClusterNode a, ClusterNode b, int index, int h, float dist, ClusterNode[] clusters)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000047")]
		public class item_s
		{
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 coord;

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x744B8C8", Offset = "0x74478C8", VA = "0x744B8C8")]
			public item_s()
			{
			}
		}

		[Token(Token = "0x2000048")]
		public class ClusterDistance
		{
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x10")]
			public ClusterNode a;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x18")]
			public ClusterNode b;

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x744B6C4", Offset = "0x74476C4", VA = "0x744B6C4")]
			public ClusterDistance(ClusterNode aa, ClusterNode bb)
			{
			}
		}

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x10")]
		public List<item_s> items;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		public ClusterNode[] clusters;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x20")]
		public bool wasCanceled;

		[Token(Token = "0x4000122")]
		private const int MAX_PRIORITY_Q_SIZE = 2048;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x744A294", Offset = "0x7446294", VA = "0x744A294")]
		private float euclidean_distance(Vector3 a, Vector3 b)
		{
			return default;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x744A32C", Offset = "0x744632C", VA = "0x744A32C")]
		public bool agglomerate(ProgressUpdateCancelableDelegate progFunc)
		{
			return default;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x744B0E4", Offset = "0x74470E4", VA = "0x744B0E4")]
		private float _RefillPriorityQWithSome(PriorityQueue<float, ClusterDistance> pq, List<ClusterNode> unclustered, ClusterNode[] clusters, ProgressUpdateCancelableDelegate progFunc)
		{
			return default;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x744B6F0", Offset = "0x74476F0", VA = "0x744B6F0")]
		public int TestRun(List<GameObject> gos)
		{
			return default;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x744B8D0", Offset = "0x74478D0", VA = "0x744B8D0")]
		public static void Main()
		{
		}

		[Token(Token = "0x6000176")]
		public static T NthSmallestElement<T>(List<T> array, int n) where T : IComparable<T>
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_AgglomerativeClustering.NthSmallestElement RVA= Token=0x6000176");
}

		[Token(Token = "0x6000177")]
		private static List<T> QuickSelectSmallest<T>(List<T> input, int n) where T : IComparable<T>
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		private static int QuickSelectPartition<T>(List<T> array, int startIndex, int endIndex, int pivotIndex) where T : IComparable<T>
		{
			return default;
		}

		[Token(Token = "0x6000179")]
		private static void Swap<T>(List<T> array, int index1, int index2)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x744BA48", Offset = "0x7447A48", VA = "0x744BA48")]
		public MB3_AgglomerativeClustering()
		{
		}
	}
}
