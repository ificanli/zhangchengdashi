using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000010")]
	public sealed class MeshSimplifier
	{
		[Token(Token = "0x400003D")]
		private const int TriangleEdgeCount = 3;

		[Token(Token = "0x400003E")]
		private const int TriangleVertexCount = 3;

		[Token(Token = "0x400003F")]
		private const int EdgeVertexCount = 2;

		[Token(Token = "0x4000040")]
		private const double DoubleEpsilon = 0.001;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int UVChannelCount;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		private bool verbose;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x14")]
		private int subMeshCount;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x18")]
		private int[] subMeshOffsets;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		private ResizableArray<Triangle> triangles;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		private ResizableArray<Vertex> vertices;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x30")]
		private ResizableArray<Ref> vtx2tris;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x38")]
		private ResizableArray<Edge> vtx2edges;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x40")]
		private List<Edge> edgesL;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x48")]
		private ResizableArray<Edge> edgesRA;

		[Token(Token = "0x400004B")]
		private const double PenaltyWeightBorder = 20.0;

		[Token(Token = "0x400004C")]
		private const double PenaltyWeightUVSeamOrFoldover = 10.0;

		[Token(Token = "0x400004D")]
		private const double DegeneratedTriangleCriteria = 0.9999999999;

		[Token(Token = "0x400004E")]
		private const double FlippedTriangleCriteria = 0.0;

		[Token(Token = "0x400004F")]
		private const double RecycleRejectedEdgesThreshold = 0.0025;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x50")]
		private ResizableArray<Vector3> vertNormals;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x58")]
		private ResizableArray<Vector4> vertTangents;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x60")]
		private UVChannels<Vector2> vertUV2D;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x68")]
		private UVChannels<Vector3> vertUV3D;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x70")]
		private UVChannels<Vector4> vertUV4D;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x78")]
		private ResizableArray<Color> vertColors;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x80")]
		private ResizableArray<BoneWeight> vertBoneWeights;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x88")]
		private ResizableArray<BlendShapeContainer> blendShapes;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x90")]
		private Matrix4x4[] bindposes;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x98")]
		private readonly double[] errArr;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xA0")]
		private readonly int[] attributeIndexArr;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xA8")]
		private readonly HashSet<Triangle> triangleHashSet1;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xB0")]
		private readonly HashSet<Triangle> triangleHashSet2;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xB8")]
		public bool isSkinned;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xC0")]
		public BoneWeight[] boneWeightsOriginal;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xC8")]
		public Matrix4x4[] bindPosesOriginal;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xD0")]
		public Transform[] bonesOriginal;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xD8")]
		public Mesh meshToSimplify;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xE0")]
		public ToleranceSphere[] toleranceSpheres;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<int, Matrix4x4> transformations;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0xF0")]
		private HashSet<object> trianglesInToleranceSpheres;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0xF8")]
		private bool isPreservationActive;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0xFC")]
		private int once;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x100")]
		private double vertexLinkDistanceSqr;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x108")]
		private bool preserveBorderEdges;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x109")]
		private bool preserveUVSeamEdges;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x10A")]
		private bool preserveUVFoldoverEdges;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x10B")]
		private bool enableSmartLink;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10C")]
		private bool recalculateNormals;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x110")]
		private int maxIterationCount;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x118")]
		private double aggressiveness;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x120")]
		private bool regardCurvature;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x121")]
		private bool useSortedEdgeMethod;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x122")]
		private bool clearBlendshapesComplete;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x128")]
		private ToleranceSphere[] spheresToSubtract;

		[Token(Token = "0x17000016")]
		[Obsolete("Use the 'MeshSimplifier.PreserveBorderEdges' property instead.", false)]
		public bool PreserveBorders
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x85574CC", Offset = "0x85534CC", VA = "0x85574CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x85574D4", Offset = "0x85534D4", VA = "0x85574D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool PreserveBorderEdges
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x85574E0", Offset = "0x85534E0", VA = "0x85574E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x85574E8", Offset = "0x85534E8", VA = "0x85574E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		[Obsolete("Use the 'MeshSimplifier.PreserveUVSeamEdges' property instead.", false)]
		public bool PreserveSeams
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x85574F4", Offset = "0x85534F4", VA = "0x85574F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x85574FC", Offset = "0x85534FC", VA = "0x85574FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool PreserveUVSeamEdges
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x8557508", Offset = "0x8553508", VA = "0x8557508")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x8557510", Offset = "0x8553510", VA = "0x8557510")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		[Obsolete("Use the 'MeshSimplifier.PreserveUVFoldoverEdges' property instead.", false)]
		public bool PreserveFoldovers
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x855751C", Offset = "0x855351C", VA = "0x855751C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x8557524", Offset = "0x8553524", VA = "0x8557524")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool PreserveUVFoldoverEdges
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x8557530", Offset = "0x8553530", VA = "0x8557530")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x8557538", Offset = "0x8553538", VA = "0x8557538")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool EnableSmartLink
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x8557544", Offset = "0x8553544", VA = "0x8557544")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x855754C", Offset = "0x855354C", VA = "0x855754C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool RecalculateNormals
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x8557558", Offset = "0x8553558", VA = "0x8557558")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x8557560", Offset = "0x8553560", VA = "0x8557560")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public int MaxIterationCount
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x855756C", Offset = "0x855356C", VA = "0x855756C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x8557574", Offset = "0x8553574", VA = "0x8557574")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public double Aggressiveness
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x855757C", Offset = "0x855357C", VA = "0x855757C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x8557584", Offset = "0x8553584", VA = "0x8557584")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool RegardCurvature
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x855758C", Offset = "0x855358C", VA = "0x855758C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x8557594", Offset = "0x8553594", VA = "0x8557594")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool UseSortedEdgeMethod
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x85575A0", Offset = "0x85535A0", VA = "0x85575A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x85575A8", Offset = "0x85535A8", VA = "0x85575A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool ClearBlendshapesComplete
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x85575B4", Offset = "0x85535B4", VA = "0x85575B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x85575BC", Offset = "0x85535BC", VA = "0x85575BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool Verbose
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x85575C8", Offset = "0x85535C8", VA = "0x85575C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x85575D0", Offset = "0x85535D0", VA = "0x85575D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public double VertexLinkDistance
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x85575DC", Offset = "0x85535DC", VA = "0x85575DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x8554118", Offset = "0x8550118", VA = "0x8554118")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public double VertexLinkDistanceSqr
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x855763C", Offset = "0x855363C", VA = "0x855763C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x8557644", Offset = "0x8553644", VA = "0x8557644")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3[] Vertices
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x855764C", Offset = "0x855364C", VA = "0x855764C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x855778C", Offset = "0x855378C", VA = "0x855778C")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public int SubMeshCount
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x8557DEC", Offset = "0x8553DEC", VA = "0x8557DEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000028")]
		public int BlendShapeCount
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x8557DF4", Offset = "0x8553DF4", VA = "0x8557DF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3[] Normals
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x8557E40", Offset = "0x8553E40", VA = "0x8557E40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x8557E8C", Offset = "0x8553E8C", VA = "0x8557E8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector4[] Tangents
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x8557F00", Offset = "0x8553F00", VA = "0x8557F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x8557F4C", Offset = "0x8553F4C", VA = "0x8557F4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector2[] UV1
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x8557FC0", Offset = "0x8553FC0", VA = "0x8557FC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x85580D0", Offset = "0x85540D0", VA = "0x85580D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector2[] UV2
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x8558380", Offset = "0x8554380", VA = "0x8558380")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x8558388", Offset = "0x8554388", VA = "0x8558388")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector2[] UV3
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x8558394", Offset = "0x8554394", VA = "0x8558394")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x855839C", Offset = "0x855439C", VA = "0x855839C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector2[] UV4
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x85583A8", Offset = "0x85543A8", VA = "0x85583A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x85583B0", Offset = "0x85543B0", VA = "0x85583B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector2[] UV5
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x85583BC", Offset = "0x85543BC", VA = "0x85583BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x85583C4", Offset = "0x85543C4", VA = "0x85583C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Vector2[] UV6
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x85583D0", Offset = "0x85543D0", VA = "0x85583D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x85583D8", Offset = "0x85543D8", VA = "0x85583D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Vector2[] UV7
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x85583E4", Offset = "0x85543E4", VA = "0x85583E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x85583EC", Offset = "0x85543EC", VA = "0x85583EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Vector2[] UV8
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x85583F8", Offset = "0x85543F8", VA = "0x85583F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x8558400", Offset = "0x8554400", VA = "0x8558400")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Color[] Colors
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x855840C", Offset = "0x855440C", VA = "0x855840C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x8558458", Offset = "0x8554458", VA = "0x8558458")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public BoneWeight[] BoneWeights
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x85584CC", Offset = "0x85544CC", VA = "0x85584CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x8558518", Offset = "0x8554518", VA = "0x8558518")]
			set
			{
			}
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x8553EB8", Offset = "0x854FEB8", VA = "0x8553EB8")]
		public MeshSimplifier()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x855858C", Offset = "0x855458C", VA = "0x855858C")]
		public MeshSimplifier(Mesh mesh)
		{
		}

		[Token(Token = "0x60000AB")]
		private void InitializeVertexAttribute<T>(T[] attributeValues, ref ResizableArray<T> attributeArray, string attributeName)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x8558620", Offset = "0x8554620", VA = "0x8558620")]
		private static double VertexError(SymmetricMatrix q, double x, double y, double z)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x85586C0", Offset = "0x85546C0", VA = "0x85586C0")]
		private double CurvatureError(ref Vertex vert0, ref Vertex vert1)
		{
			return default;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x8558AB0", Offset = "0x8554AB0", VA = "0x8558AB0")]
		private double CalculateError(ref Vertex vert0, ref Vertex vert1, out Vector3d result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshSimplifier.CalculateError RVA=0x8558AB0 Token=0x60000AE");
}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x8558F48", Offset = "0x8554F48", VA = "0x8558F48")]
		private static void CalculateBarycentricCoords(ref Vector3d point, ref Vector3d a, ref Vector3d b, ref Vector3d c, out Vector3 result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshSimplifier.CalculateBarycentricCoords RVA=0x8558F48 Token=0x60000AF");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x85590F0", Offset = "0x85550F0", VA = "0x85590F0")]
		private static Vector4 NormalizeTangent(Vector4 tangent)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x85591C8", Offset = "0x85551C8", VA = "0x85591C8")]
		private bool Flipped(ref Vector3d p, int i0, int i1, ref Vertex v0, bool[] deleted)
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x85597A0", Offset = "0x85557A0", VA = "0x85597A0")]
		private void UpdateTriangles(int i0, int ia0, ref Vertex v, ResizableArray<bool> deleted, ref int deletedTriangles)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x8559B58", Offset = "0x8555B58", VA = "0x8559B58")]
		private void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x855A3C8", Offset = "0x85563C8", VA = "0x855A3C8")]
		private bool AreUVsTheSame(int channel, int indexA, int indexB)
		{
			return default;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x855A5FC", Offset = "0x85565FC", VA = "0x855A5FC")]
		private void RemoveVertexPass(int startTrisCount, int targetTrisCount, double threshold, ResizableArray<bool> deleted0, ResizableArray<bool> deleted1, ref int deletedTris, bool isPreservationActive = false)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x855B048", Offset = "0x8557048", VA = "0x855B048")]
		private void UpdateMesh(int iteration)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x855BFD0", Offset = "0x8557FD0", VA = "0x855BFD0")]
		private void UpdateReferences()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x855C3B4", Offset = "0x85583B4", VA = "0x855C3B4")]
		private void CompactMesh()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x855D038", Offset = "0x8559038", VA = "0x855D038")]
		private void CalculateSubMeshOffsets()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x855D1A8", Offset = "0x85591A8", VA = "0x855D1A8")]
		private void GetTrianglesContainingVertex(ref Vertex vert, HashSet<Triangle> tris)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x855D29C", Offset = "0x855929C", VA = "0x855D29C")]
		private void GetTrianglesContainingBothVertices(ref Vertex vert0, ref Vertex vert1, HashSet<Triangle> tris)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x855D438", Offset = "0x8559438", VA = "0x855D438")]
		private void CalculateEdgeError(Edge edge)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x855DB2C", Offset = "0x8559B2C", VA = "0x855DB2C")]
		private bool ValidateContractionThenUpdateTrisNormals(Edge edge, ref int survivedIndex, ref int deletedIndex, ref List<Triangle> trisTouchingSurvivedVertexOnly, ref List<Triangle> trisTouchingDeletedVertexOnly, ref List<Triangle> trisTouchingBothVertices)
		{
			return default;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x855E50C", Offset = "0x855A50C", VA = "0x855E50C")]
		private void CalculateEdgePenaltyMatrix(Triangle t, Edge e)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x855E874", Offset = "0x855A874", VA = "0x855E874")]
		private void DistributeEdgePenaltyMatrix(Edge e, Vertex v)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x855E91C", Offset = "0x855A91C", VA = "0x855E91C")]
		private void DistributeEdgePenaltyMatrix(Edge e)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x855EA58", Offset = "0x855AA58", VA = "0x855EA58")]
		private void InitEdges(out int degeneratedTriangles)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MeshSimplifier.InitEdges RVA=0x855EA58 Token=0x60000C1");
}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x855F3C8", Offset = "0x855B3C8", VA = "0x855F3C8")]
		private void RemoveEdgePass(int trisToDelete, ref int deletedTris)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x8560C80", Offset = "0x855CC80", VA = "0x8560C80")]
		private void SimplifyMeshByEdge(float quality)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8560D4C", Offset = "0x855CD4C", VA = "0x8560D4C")]
		public int[][] GetAllSubMeshTriangles()
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x8560DF4", Offset = "0x855CDF4", VA = "0x8560DF4")]
		public int[] GetSubMeshTriangles(int subMeshIndex)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x856104C", Offset = "0x855D04C", VA = "0x856104C")]
		public void ClearSubMeshes()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x85610B0", Offset = "0x855D0B0", VA = "0x85610B0")]
		public void AddSubMeshTriangles(int[] triangles)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x856133C", Offset = "0x855D33C", VA = "0x856133C")]
		public void AddSubMeshTriangles(int[][] triangles)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8557FC8", Offset = "0x8553FC8", VA = "0x8557FC8")]
		public Vector2[] GetUVs2D(int channel)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x8561918", Offset = "0x855D918", VA = "0x8561918")]
		public Vector3[] GetUVs3D(int channel)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x8561A20", Offset = "0x855DA20", VA = "0x8561A20")]
		public Vector4[] GetUVs4D(int channel)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x8561B28", Offset = "0x855DB28", VA = "0x8561B28")]
		public void GetUVs(int channel, List<Vector2> uvs)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x8561CB4", Offset = "0x855DCB4", VA = "0x8561CB4")]
		public void GetUVs(int channel, List<Vector3> uvs)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x8561E40", Offset = "0x855DE40", VA = "0x8561E40")]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x85580DC", Offset = "0x85540DC", VA = "0x85580DC")]
		public void SetUVs(int channel, Vector2[] uvs)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x8561FCC", Offset = "0x855DFCC", VA = "0x8561FCC")]
		public void SetUVs(int channel, Vector3[] uvs)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x8562270", Offset = "0x855E270", VA = "0x8562270")]
		public void SetUVs(int channel, Vector4[] uvs)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x8562514", Offset = "0x855E514", VA = "0x8562514")]
		public void SetUVs(int channel, List<Vector2> uvs)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x85627DC", Offset = "0x855E7DC", VA = "0x85627DC")]
		public void SetUVs(int channel, List<Vector3> uvs)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x8562AA4", Offset = "0x855EAA4", VA = "0x8562AA4")]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x8562D6C", Offset = "0x855ED6C", VA = "0x8562D6C")]
		public void SetUVsAuto(int channel, List<Vector4> uvs)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x8562F68", Offset = "0x855EF68", VA = "0x8562F68")]
		public BlendShape[] GetAllBlendShapes()
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x8563058", Offset = "0x855F058", VA = "0x8563058")]
		public BlendShape GetBlendShape(int blendShapeIndex)
		{
			return default;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x856312C", Offset = "0x855F12C", VA = "0x856312C")]
		public void ClearBlendShapes()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x8563180", Offset = "0x855F180", VA = "0x8563180")]
		public void AddBlendShape(BlendShape blendShape)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x85632CC", Offset = "0x855F2CC", VA = "0x85632CC")]
		public void AddBlendShapes(BlendShape[] blendShapes)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x8554144", Offset = "0x8550144", VA = "0x8554144")]
		public void Initialize(Mesh mesh, bool isPreservationActive = false)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x85543C8", Offset = "0x85503C8", VA = "0x85543C8")]
		public void SimplifyMesh(float quality)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x856351C", Offset = "0x855F51C", VA = "0x856351C")]
		public void SimplifyMeshLossless()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x85548F4", Offset = "0x85508F4", VA = "0x85548F4")]
		public Mesh ToMesh()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x855AD30", Offset = "0x8556D30", VA = "0x855AD30")]
		private bool TriangleLiesInSphere(Triangle triangle)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x8563878", Offset = "0x855F878", VA = "0x8563878")]
		private bool VertexLiesInSphere(ToleranceSphere sphere, Triangle containingTri, Vertex vertex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x8563E6C", Offset = "0x855FE6C", VA = "0x8563E6C")]
		private bool IsTriangleInAnyToleranceSphere(Triangle triangle)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8563EC4", Offset = "0x855FEC4", VA = "0x8563EC4")]
		private HashSet<Triangle> GetTrianglesContainingVertex(ref Vertex toCheck)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x8563FF4", Offset = "0x855FFF4", VA = "0x8563FF4")]
		private HashSet<Triangle> GetTrianglesContainingBothVertices(ref Vertex vertex1, ref Vertex vertex2)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x8564240", Offset = "0x8560240", VA = "0x8564240")]
		private bool TriangleContainsVertex(Triangle triangle, Vertex vertex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x8564384", Offset = "0x8560384", VA = "0x8564384")]
		public Vector3? GetVertexWorldPosition(Vector3 vertexLocalPosition, BoneWeight bw, BoneWeight[] boneWeights, Matrix4x4[] aBindPoses, Transform[] aBones, Matrix4x4[] transformMatrices)
		{
			return null;
		}
	}
}
