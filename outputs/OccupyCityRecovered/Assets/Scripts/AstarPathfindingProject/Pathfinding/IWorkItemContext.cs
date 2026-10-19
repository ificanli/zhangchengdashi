using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000096")]
	public interface IWorkItemContext : IGraphUpdateContext
	{
		[Token(Token = "0x60004EF")]
		[Obsolete("You no longer need to call this method. Connectivity data is automatically kept up-to-date.")]
		void QueueFloodFill();

		[Token(Token = "0x60004F0")]
		void EnsureValidFloodFill();

		[Token(Token = "0x60004F1")]
		void PreUpdate();

		[Token(Token = "0x60004F2")]
		void SetGraphDirty(NavGraph graph);

		[Token(Token = "0x60004F3")]
		void VisualizeOriginalGraphUpdateBounds(Bounds bounds);
	}
}
