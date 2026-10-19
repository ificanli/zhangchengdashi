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
		private uint checksum;

		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x60")]
		private UTF8Encoding encoding;

		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder _stringBuilder;

		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Version V3_8_3;

		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Version V3_9_0;

		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Version V4_1_0;

		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Version V4_3_2;

		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Version V4_3_6;

		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Version V4_3_37;

		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Version V4_3_12;

		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Version V4_3_68;

		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Version V4_3_74;

		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Version V4_3_80;

		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x58")]
		public static readonly Version V4_3_83;

		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Version V4_3_85;

		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x68")]
		public static readonly Version V4_3_87;

		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x70")]
		public static readonly Version V5_1_0;

		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Version V5_2_0;

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x447E34C", Offset = "0x447A34C", VA = "0x447E34C")]
		private static StringBuilder GetStringBuilder()
		{
			return null;
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x447E3C4", Offset = "0x447A3C4", VA = "0x447E3C4")]
		public AstarSerializer(AstarData data, GameObject contextRoot)
		{
		}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x447E458", Offset = "0x447A458", VA = "0x447E458")]
		public AstarSerializer(AstarData data, SerializeSettings settings, GameObject contextRoot)
		{
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
		{
			return null;
		}

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x447FC30", Offset = "0x447BC30", VA = "0x447FC30")]
		private bool ContainsEntry(string name)
		{
			return default;
		}

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x447FC58", Offset = "0x447BC58", VA = "0x447FC58")]
		public bool OpenDeserialize(byte[] bytes)
		{
			return default;
		}

		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x4480624", Offset = "0x447C624", VA = "0x4480624")]
		private static Version FullyDefinedVersion(Version v)
		{
			return null;
		}

		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x44806B4", Offset = "0x447C6B4", VA = "0x44806B4")]
		public void CloseDeserialize()
		{
		}

		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x44806EC", Offset = "0x447C6EC", VA = "0x44806EC")]
		private NavGraph DeserializeGraph(int zipIndex, int graphIndex, Type[] availableGraphTypes)
		{
			return null;
		}

		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x4480E14", Offset = "0x447CE14", VA = "0x4480E14")]
		public NavGraph[] DeserializeGraphs(Type[] availableGraphTypes, bool allowLoadingNodes, Func<int> nextGraphIndex)
		{
			return null;
		}

		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x4481414", Offset = "0x447D414", VA = "0x4481414")]
		private bool DeserializeExtraInfo(NavGraph graph)
		{
			return default;
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
		}

		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x44815E4", Offset = "0x447D5E4", VA = "0x44815E4")]
		private static BinaryReader GetBinaryReader(ZipEntry entry)
		{
			return null;
		}

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x4480C80", Offset = "0x447CC80", VA = "0x4480C80")]
		private static string GetString(ZipEntry entry)
		{
			return null;
		}

		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x44800E4", Offset = "0x447C0E4", VA = "0x44800E4")]
		private GraphMeta DeserializeMeta(ZipEntry entry)
		{
			return null;
		}

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
