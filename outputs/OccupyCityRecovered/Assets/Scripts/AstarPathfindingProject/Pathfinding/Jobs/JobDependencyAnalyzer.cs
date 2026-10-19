using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200019A")]
	internal struct JobDependencyAnalyzer<T> where T : struct
	{
		[Token(Token = "0x200019B")]
		private struct ReflectionData
		{
			[Token(Token = "0x40007D3")]
			[FieldOffset(Offset = "0x0")]
			public int[] fieldOffsets;

			[Token(Token = "0x40007D4")]
			[FieldOffset(Offset = "0x0")]
			public bool[] writes;

			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x0")]
			public bool[] checkUninitializedRead;

			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x0")]
			public string[] fieldNames;

			[Token(Token = "0x6000BF9")]
			public void Build()
			{
			}

			[Token(Token = "0x6000BFA")]
			private void Build(Type type, List<int> fields, List<bool> writes, List<bool> reads, List<string> names, int offset, bool forceReadOnly, bool forceWriteOnly, bool forceDisableUninitializedCheck)
			{
			}
		}

		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionData reflectionData;

		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BufferOffset;

		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SpanPtrOffset;

		[Token(Token = "0x6000BF2")]
		private static void initReflectionData()
		{
		}

		[Token(Token = "0x6000BF3")]
		private static bool HasHash(int[] hashes, int hash, int count)
		{
			return default;
		}

		[Token(Token = "0x6000BF4")]
		public static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker)
		{
			return default;
		}

		[Token(Token = "0x6000BF5")]
		public static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker, JobHandle additionalDependency)
		{
			return default;
		}

		[Token(Token = "0x6000BF6")]
		private static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker, JobHandle additionalDependency, bool useAdditionalDependency)
		{
			return default;
		}

		[Token(Token = "0x6000BF7")]
		internal static void Scheduled(ref T data, JobDependencyTracker tracker, JobHandle job)
		{
		}
	}
}
