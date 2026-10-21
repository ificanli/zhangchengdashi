using System.IO;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000242")]
	public class GraphSerializationContext
	{
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x10")]
		private readonly GraphNode[] id2NodeMapping;

		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x18")]
		public readonly BinaryReader reader;

		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x20")]
		public readonly BinaryWriter writer;

		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x28")]
		public readonly uint graphIndex;

		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x30")]
		public readonly GraphMeta meta;

		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x38")]
		public bool[] persistentGraphs;

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x447DB5C", Offset = "0x4479B5C", VA = "0x447DB5C")]
		public GraphSerializationContext(BinaryReader reader, GraphNode[] id2NodeMapping, uint graphIndex, GraphMeta meta)
		{
 this.id2NodeMapping = id2NodeMapping;
 this.reader = reader;
 this.graphIndex = graphIndex;
 this.meta = meta;
}

		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x447DBA0", Offset = "0x4479BA0", VA = "0x447DBA0")]
		public GraphSerializationContext(BinaryWriter writer, bool[] persistentGraphs)
		{
		}

		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x447DBD0", Offset = "0x4479BD0", VA = "0x447DBD0")]
		public void SerializeNodeReference(GraphNode node)
		{
		}

		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x447DC14", Offset = "0x4479C14", VA = "0x447DC14")]
		public void SerializeConnections(Connection[] connections, bool serializeMetadata)
		{
		}

		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x447DDB0", Offset = "0x4479DB0", VA = "0x447DDB0")]
		public Connection[] DeserializeConnections(bool deserializeMetadata)
		{
			return null;
		}

		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x447E044", Offset = "0x447A044", VA = "0x447E044")]
		public GraphNode DeserializeNodeReference()
		{
			return null;
		}

		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x447E170", Offset = "0x447A170", VA = "0x447E170")]
		public void SerializeVector3(Vector3 v)
		{
		}

		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x447E1E0", Offset = "0x447A1E0", VA = "0x447E1E0")]
		public Vector3 DeserializeVector3()
		{
			return default;
		}

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x447E258", Offset = "0x447A258", VA = "0x447E258")]
		public void SerializeInt3(Int3 v)
		{
		}

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x447E2C8", Offset = "0x447A2C8", VA = "0x447E2C8")]
		public Int3 DeserializeInt3()
		{
			return default;
		}

		[Token(Token = "0x6000E5B")]
		public UnsafeSpan<T> ReadSpan<T>(Allocator allocator) where T : unmanaged
		{
			return default;
		}
	}
}
