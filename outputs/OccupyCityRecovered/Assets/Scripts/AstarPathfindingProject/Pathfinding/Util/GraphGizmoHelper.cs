using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Pooling;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x20002A5")]
	public class GraphGizmoHelper : IAstarPooledObject, IDisposable
	{
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x18")]
		private PathHandler debugData;

		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x20")]
		private ushort debugPathID;

		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x24")]
		private GraphDebugMode debugMode;

		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x28")]
		public bool showSearchTree;

		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x2C")]
		private float debugFloor;

		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x30")]
		private float debugRoof;

		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x38")]
		public CommandBuilder builder;

		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 drawConnectionStart;

		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x5C")]
		private Color drawConnectionColor;

		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x70")]
		private readonly Action<GraphNode> drawConnection;

		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x78")]
		private GlobalNodeStorage nodeStorage;

		[Token(Token = "0x17000275")]
		public DrawingData.Hasher hasher
		{
			[Token(Token = "0x60010CE")]
			[Address(RVA = "0x4498634", Offset = "0x4494634", VA = "0x4498634")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60010CF")]
			[Address(RVA = "0x449863C", Offset = "0x449463C", VA = "0x449863C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x4498644", Offset = "0x4494644", VA = "0x4498644")]
		public GraphGizmoHelper()
		{
		}

		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x44986CC", Offset = "0x44946CC", VA = "0x44986CC")]
		public static GraphGizmoHelper GetSingleFrameGizmoHelper(DrawingData gizmos, AstarPath active, RedrawScope redrawScope, bool renderInGame)
		{
			return null;
		}

		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x449871C", Offset = "0x449471C", VA = "0x449871C")]
		public static GraphGizmoHelper GetGizmoHelper(DrawingData gizmos, AstarPath active, DrawingData.Hasher hasher, RedrawScope redrawScope, bool renderInGame)
		{
			return null;
		}

		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x44987BC", Offset = "0x44947BC", VA = "0x44987BC")]
		public void Init(AstarPath active, DrawingData.Hasher hasher, DrawingData gizmos, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x44988CC", Offset = "0x44948CC", VA = "0x44988CC", Slot = "4")]
		public void OnEnterPool()
		{
		}

		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x449892C", Offset = "0x449492C", VA = "0x449892C")]
		public void DrawConnections(GraphNode node)
		{
		}

		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x4498BAC", Offset = "0x4494BAC", VA = "0x4498BAC")]
		private void DrawConnection(GraphNode other)
		{
		}

		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x44989B8", Offset = "0x44949B8", VA = "0x44989B8")]
		public Color NodeColor(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x4498CA8", Offset = "0x4494CA8", VA = "0x4498CA8")]
		public void DrawWireTriangle(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x4498DEC", Offset = "0x4494DEC", VA = "0x4498DEC")]
		public void DrawTriangles(Vector3[] vertices, Color[] colors, int numTriangles)
		{
		}

		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x4498F44", Offset = "0x4494F44", VA = "0x4498F44")]
		public void DrawWireTriangles(Vector3[] vertices, Color[] colors, int numTriangles)
		{
		}

		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x449903C", Offset = "0x449503C", VA = "0x449903C", Slot = "5")]
		public void Dispose()
		{
		}
	}
}
