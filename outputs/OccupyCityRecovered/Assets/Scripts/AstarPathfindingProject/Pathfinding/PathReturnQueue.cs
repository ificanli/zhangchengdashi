using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000C3")]
	internal class PathReturnQueue
	{
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x10")]
		private Queue<Path> pathReturnQueueWriting;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x18")]
		private Queue<Path> pathReturnQueueReading;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x20")]
		private readonly object pathsClaimedSilentlyBy;

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x28")]
		private readonly Action OnReturnedPaths;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x451BEFC", Offset = "0x4517EFC", VA = "0x451BEFC")]
		public PathReturnQueue(object pathsClaimedSilentlyBy, Action OnReturnedPaths)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x451B460", Offset = "0x4517460", VA = "0x451B460")]
		public void Enqueue(Path path)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x451BFA8", Offset = "0x4517FA8", VA = "0x451BFA8")]
		public void ReturnPaths(bool timeSlice)
		{
		}
	}
}
