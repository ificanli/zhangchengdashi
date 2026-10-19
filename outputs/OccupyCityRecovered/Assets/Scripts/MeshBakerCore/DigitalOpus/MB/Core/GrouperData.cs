using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x2000127")]
	public class GrouperData
	{
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x10")]
		public bool clusterOnLMIndex;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x11")]
		public bool clusterByLODLevel;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 origin;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 cellSize;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x2C")]
		public int pieNumSegments;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 pieAxis;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x3C")]
		public float ringSpacing;

		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x40")]
		public bool combineSegmentsInInnermostRing;

		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x41")]
		public bool includeCellsWithOnlyOneRenderer;

		[Token(Token = "0x4000478")]
		[FieldOffset(Offset = "0x48")]
		public MB3_AgglomerativeClustering cluster;

		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x50")]
		public float maxDistBetweenClusters;

		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x54")]
		public float _lastMaxDistBetweenClusters;

		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x58")]
		public float _ObjsExtents;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x5C")]
		public float _minDistBetweenClusters;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x60")]
		public List<MB3_AgglomerativeClustering.ClusterNode> _clustersToDraw;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x68")]
		public float[] _radii;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x74B2F00", Offset = "0x74AEF00", VA = "0x74B2F00")]
		public GrouperData()
		{
		}
	}
}
