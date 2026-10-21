using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zip;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000243")]
	public class AstarSerializer
	{
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x10")]
		private AstarData data;

		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x18")]
		private ZipFile zip;

		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream zipStream;

		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x28")]
		private GraphMeta meta;

		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x30")]
		private SerializeSettings settings;

		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x38")]
		private GameObject contextRoot;

		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x40")]
		private NavGraph[] graphs;

		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x48")]
		private bool[] persistentGraphs;

		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<NavGraph, int> graphIndexInZip;

		[Token(Token = "0x4000AC3")]
		private const string binaryExt = ".binary";

		[Token(Token = "0x4000AC4")]
		private const string jsonExt = ".json";

		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x58")]
		private uint checksum = uint.MaxValue;

		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x60")]
		private UTF8Encoding encoding = new UTF8Encoding();

		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder _stringBuilder = new StringBuilder();

		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Version V3_8_3 = new Version(3,8,3);

		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Version V3_9_0 = new Version(3,9,0);

		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Version V4_1_0 = new Version(4,1,0);

		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Version V4_3_2 = new Version(4,3,2);

		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Version V4_3_6 = new Version(4,3,6);

		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Version V4_3_37 = new Version(4,3,37);

		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Version V4_3_12 = new Version(4,3,12);

		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Version V4_3_68 = new Version(4,3,68);

		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Version V4_3_74 = new Version(4,3,74);

		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Version V4_3_80 = new Version(4,3,80);

		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x58")]
		public static readonly Version V4_3_83 = new Version(4,3,83);

		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Version V4_3_85 = new Version(4,3,85);

		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x68")]
		public static readonly Version V4_3_87 = new Version(4,3,87);

		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x70")]
		public static readonly Version V5_1_0 = new Version(5,1,0);

		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Version V5_2_0 = new Version(5,2,0);

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x447E34C", Offset = "0x447A34C", VA = "0x447E34C")]
		private static StringBuilder GetStringBuilder()
		{
			return null;
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x447E3C4", Offset = "0x447A3C4", VA = "0x447E3C4")]
		public AstarSerializer(AstarData data, GameObject contextRoot)
		: this(data, SerializeSettings.Settings, contextRoot)
        {}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x447E458", Offset = "0x447A458", VA = "0x447E458")]
		public AstarSerializer(AstarData data, SerializeSettings settings, GameObject contextRoot)
		{
 this.data = data;
 this.settings = settings;
 this.contextRoot = contextRoot;
}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x447E4E8", Offset = "0x447A4E8", VA = "0x447E4E8")]
		private void AddChecksum(byte[] bytes)
		{
		}

		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x447E510", Offset = "0x447A510", VA = "0x447E510")]
		private void AddEntry(string name, byte[] bytes)
		{
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x447E52C", Offset = "0x447A52C", VA = "0x447E52C")]
		public uint GetChecksum()
		{
			return default;
		}

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x447E534", Offset = "0x447A534", VA = "0x447E534")]
		public void OpenSerialize()
		{
		}

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x447E624", Offset = "0x447A624", VA = "0x447E624")]
		public byte[] CloseSerialize()
		{
			return null;
		}

		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x447EE78", Offset = "0x447AE78", VA = "0x447EE78")]
		public void SerializeGraphs(NavGraph[] _graphs)
		{
		}

		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x447EA3C", Offset = "0x447AA3C", VA = "0x447EA3C")]
		private byte[] SerializeMeta()
		{
			return null;
		}

		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x447F0F0", Offset = "0x447B0F0", VA = "0x447F0F0")]
		public byte[] Serialize(NavGraph graph)
		{
			return null;
		}

		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x447F230", Offset = "0x447B230", VA = "0x447F230")]
		private static int GetMaxNodeIndexInAllGraphs(NavGraph[] graphs)
		{
			return default;
		}

		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x447F3D0", Offset = "0x447B3D0", VA = "0x447F3D0")]
		private static byte[] SerializeNodeIndices(NavGraph[] graphs)
		{
			return null;
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x447F65C", Offset = "0x447B65C", VA = "0x447F65C")]
		private static byte[] SerializeGraphExtraInfo(NavGraph graph, bool[] persistentGraphs)
		{
			return null;
		}

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x447F7D0", Offset = "0x447B7D0", VA = "0x447F7D0")]
		private static byte[] SerializeGraphNodeReferences(NavGraph graph, bool[] persistentGraphs)
		{
			return null;
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x447F958", Offset = "0x447B958", VA = "0x447F958")]
		public void SerializeExtraInfo()
		{
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x447FC14", Offset = "0x447BC14", VA = "0x447FC14")]
		private ZipEntry GetEntry(string name)
		{ return zip[name]; }

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x447FC30", Offset = "0x447BC30", VA = "0x447FC30")]
		private bool ContainsEntry(string name)
		{ return zip[name] != null; }

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x447FC58", Offset = "0x447BC58", VA = "0x447FC58")]
		public bool OpenDeserialize(byte[] bytes)
		{
 zipStream = new MemoryStream();
 zipStream.Write(bytes, 0, bytes.Length);
 zipStream.Position = 0;
 try {
  zip = ZipFile.Read(zipStream);
  zip.ParallelDeflateThreshold = -1;
 } catch (Exception e) {
  UnityEngine.Debug.LogError("Caught exception when loading from zip\n" + e);
  zipStream.Dispose();
  return false;
 }
 if (ContainsEntry("meta.json")) meta = DeserializeMeta(zip["meta.json"]);
 else if (ContainsEntry("meta.binary")) meta = DeserializeBinaryMeta(zip["meta.binary"]);
 else throw new Exception("No metadata found in serialized data.");
 if (FullyDefinedVersion(meta.version) > FullyDefinedVersion(AstarPath.Version)) {
  UnityEngine.Debug.LogWarning("Trying to load data from a newer version of the A* Pathfinding Project\nCurrent version: " + AstarPath.Version + " Data version: " + meta.version + "\nThis is usually fine as the stored data is usually backwards and forwards compatible.\nHowever node data (not settings) can get corrupted between versions (even though I try my best to keep compatibility), so it is recommended to recalculate any caches (those for faster startup) and resave any files. Even if it seems to load fine, it might cause subtle bugs.\n");
 }
 return true;
}

		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x4480624", Offset = "0x447C624", VA = "0x4480624")]
		private static Version FullyDefinedVersion(Version v)
		{ return new Version(Math.Max(v.Major, 0), Math.Max(v.Minor, 0), Math.Max(v.Build, 0), Math.Max(v.Revision, 0)); }

		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x44806B4", Offset = "0x447C6B4", VA = "0x44806B4")]
		public void CloseDeserialize()
		{
 zipStream.Dispose();
 zip.Dispose();
 zip = null;
 zipStream = null;
}

		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x44806EC", Offset = "0x447C6EC", VA = "0x44806EC")]
		private NavGraph DeserializeGraph(int zipIndex, int graphIndex, Type[] availableGraphTypes)
		{
 Type graphType = meta.GetGraphType(zipIndex, availableGraphTypes);
 if (graphType == null) return null;
 NavGraph graph = data.CreateGraph(graphType);
 graph.graphIndex = (uint)graphIndex;
 string name = "graph" + zipIndex + ".json";
 if (!ContainsEntry(name)) throw new FileNotFoundException("Could not find data for graph " + zipIndex + " in zip. Entry 'graph" + zipIndex + ".json' does not exist");
 TinyJsonDeserializer.Deserialize(GetString(zip[name]), graphType, graph, contextRoot);
 if (graph.guid.ToString() != meta.guids[zipIndex]) throw new Exception("Guid in graph file not equal to guid defined in meta file. Have you edited the data manually?\n" + graph.guid + " != " + meta.guids[zipIndex]);
 return graph;
}

		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x4480E14", Offset = "0x447CE14", VA = "0x4480E14")]
		public NavGraph[] DeserializeGraphs(Type[] availableGraphTypes, bool allowLoadingNodes, Func<int> nextGraphIndex)
		{
 var list = new List<NavGraph>();
 graphIndexInZip = new Dictionary<NavGraph, int>();
 for (int i = 0; i < meta.graphs; i++) {
  NavGraph graph = DeserializeGraph(i, nextGraphIndex(), availableGraphTypes);
  if (graph != null) { list.Add(graph); graphIndexInZip[graph] = i; }
 }
 graphs = list.ToArray();
 DeserializeEditorSettingsCompatibility();
 if (allowLoadingNodes) DeserializeExtraInfo();
 return graphs;
}

		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x4481414", Offset = "0x447D414", VA = "0x4481414")]
		private bool DeserializeExtraInfo(NavGraph graph)
		{
 int index = graphIndexInZip[graph];
 ZipEntry entry = zip["graph" + index + "_extra.binary"];
 if (entry == null) return false;
 var reader = GetBinaryReader(entry);
 var context = new GraphSerializationContext(reader, null, graph.graphIndex, meta);
 ((IGraphInternals)graph).DeserializeExtraInfo(context);
 return true;
}

		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x448169C", Offset = "0x447D69C", VA = "0x448169C")]
		private bool AnyDestroyedNodesInGraphs()
		{
			return default;
		}

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x44817BC", Offset = "0x447D7BC", VA = "0x44817BC")]
		private GraphNode[] DeserializeNodeReferenceMap()
		{
			return null;
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x4481C10", Offset = "0x447DC10", VA = "0x4481C10")]
		private void DeserializeNodeReferences(NavGraph graph, GraphNode[] int2Node)
		{
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x4481ECC", Offset = "0x447DECC", VA = "0x4481ECC")]
		private void DeserializeAndRemoveOldNodeLinks(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x4481200", Offset = "0x447D200", VA = "0x4481200")]
		private void DeserializeExtraInfo()
		{
 bool any = false;
 for (int i = 0; i < graphs.Length; i++) any |= DeserializeExtraInfo(graphs[i]);
 if (any) {
  if (AnyDestroyedNodesInGraphs()) UnityEngine.Debug.LogError("Graph contains destroyed nodes. This is a bug.");
  GraphNode[] mapping = DeserializeNodeReferenceMap();
  for (int i = 0; i < graphs.Length; i++) DeserializeNodeReferences(graphs[i], mapping);
  if (meta.version < V4_3_85) {
   ZipEntry entry = zip["node_link2.binary"];
   if (entry != null) DeserializeAndRemoveOldNodeLinks(new GraphSerializationContext(GetBinaryReader(entry), mapping, 0, meta));
  }
 }
}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x44823D8", Offset = "0x447E3D8", VA = "0x44823D8")]
		public void PostDeserialization()
		{
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x448101C", Offset = "0x447D01C", VA = "0x448101C")]
		private void DeserializeEditorSettingsCompatibility()
		{
 for (int i = 0; i < graphs.Length; i++) {
  ZipEntry entry = zip["graph" + graphIndexInZip[graphs[i]] + "_editor.json"];
  if (entry != null) ((IGraphInternals)graphs[i]).SerializedEditorSettings = GetString(entry);
 }
}

		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x44815E4", Offset = "0x447D5E4", VA = "0x44815E4")]
		private static BinaryReader GetBinaryReader(ZipEntry entry)
		{
 var stream = new MemoryStream();
 entry.Extract(stream);
 stream.Position = 0;
 return new BinaryReader(stream);
}

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x4480C80", Offset = "0x447CC80", VA = "0x4480C80")]
		private static string GetString(ZipEntry entry)
		{
 var stream = new MemoryStream();
 entry.Extract(stream);
 stream.Position = 0;
 var reader = new StreamReader(stream);
 string result = reader.ReadToEnd();
 reader.Dispose();
 return result;
}

		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x44800E4", Offset = "0x447C0E4", VA = "0x44800E4")]
		private GraphMeta DeserializeMeta(ZipEntry entry)
		{ return TinyJsonDeserializer.Deserialize(GetString(entry), typeof(GraphMeta), null, null) as GraphMeta; }

		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x4480220", Offset = "0x447C220", VA = "0x4480220")]
		private GraphMeta DeserializeBinaryMeta(ZipEntry entry)
		{
			return null;
		}

		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x448250C", Offset = "0x447E50C", VA = "0x448250C")]
		public static void SaveToFile(string path, byte[] data)
		{
		}

		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x44826C4", Offset = "0x447E6C4", VA = "0x44826C4")]
		public static byte[] LoadFromFile(string path)
		{
			return null;
		}
	}
}
