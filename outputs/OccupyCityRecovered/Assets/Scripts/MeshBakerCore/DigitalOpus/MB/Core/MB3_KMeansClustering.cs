using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200004A")]
	public class MB3_KMeansClustering
	{
		[Token(Token = "0x200004B")]
		private class DataPoint
		{
			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 center;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x20")]
			public GameObject gameObject;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x28")]
			public int Cluster;

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x744D3D4", Offset = "0x74493D4", VA = "0x744D3D4")]
			public DataPoint(GameObject go)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x10")]
		private List<DataPoint> _normalizedDataToCluster;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x18")]
		private Vector3[] _clusters;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x20")]
		private int _numberOfClusters;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x744D06C", Offset = "0x744906C", VA = "0x744D06C")]
		public MB3_KMeansClustering(List<GameObject> gos, int numClusters)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x744D520", Offset = "0x7449520", VA = "0x744D520")]
		private void InitializeCentroids()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x744D5FC", Offset = "0x74495FC", VA = "0x744D5FC")]
		private bool UpdateDataPointMeans(bool force)
		{
			return default;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x744D820", Offset = "0x7449820", VA = "0x744D820")]
		private bool AnyAreEmpty(List<DataPoint> data)
		{
			return default;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x744D940", Offset = "0x7449940", VA = "0x744D940")]
		private bool UpdateClusterMembership()
		{
			return default;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x744DAD8", Offset = "0x7449AD8", VA = "0x744DAD8")]
		private float ElucidanDistance(DataPoint dataPoint, Vector3 mean)
		{
			return default;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x744DB74", Offset = "0x7449B74", VA = "0x744DB74")]
		private int MinIndex(float[] distances)
		{
			return default;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x744DBD8", Offset = "0x7449BD8", VA = "0x744DBD8")]
		public List<Renderer> GetCluster(int idx, out Vector3 mean, out float size)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_KMeansClustering.GetCluster RVA=0x744DBD8 Token=0x6000189");
}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x744DF48", Offset = "0x7449F48", VA = "0x744DF48")]
		public void Cluster()
		{
		}
	}
}
