using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000276")]
	public class AABBTree<T>
	{
		[Token(Token = "0x2000277")]
		private struct Node
		{
			[Token(Token = "0x4000B78")]
			[FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			[Token(Token = "0x4000B79")]
			[FieldOffset(Offset = "0x0")]
			public uint flags;

			[Token(Token = "0x4000B7A")]
			private const uint TagInsideBit = 1073741824u;

			[Token(Token = "0x4000B7B")]
			private const uint TagPartiallyInsideBit = 2147483648u;

			[Token(Token = "0x4000B7C")]
			private const uint AllocatedBit = 536870912u;

			[Token(Token = "0x4000B7D")]
			private const uint ParentMask = 536870911u;

			[Token(Token = "0x4000B7E")]
			public const int InvalidParent = 536870911;

			[Token(Token = "0x4000B7F")]
			[FieldOffset(Offset = "0x0")]
			public int left;

			[Token(Token = "0x4000B80")]
			[FieldOffset(Offset = "0x0")]
			public int right;

			[Token(Token = "0x4000B81")]
			[FieldOffset(Offset = "0x0")]
			public T value;

			[Token(Token = "0x17000253")]
			public bool wholeSubtreeTagged
			{
				[Token(Token = "0x6000FCA")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000FCB")]
				set
				{
				}
			}

			[Token(Token = "0x17000254")]
			public bool subtreePartiallyTagged
			{
				[Token(Token = "0x6000FCC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000FCD")]
				set
				{
				}
			}

			[Token(Token = "0x17000255")]
			public bool isAllocated
			{
				[Token(Token = "0x6000FCE")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000FCF")]
				set
				{
				}
			}

			[Token(Token = "0x17000256")]
			public bool isLeaf
			{
				[Token(Token = "0x6000FD0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000257")]
			public int parent
			{
				[Token(Token = "0x6000FD1")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000FD2")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000278")]
		public readonly struct Key
		{
			[Token(Token = "0x4000B82")]
			[FieldOffset(Offset = "0x0")]
			internal readonly int value;

			[Token(Token = "0x17000258")]
			public int node
			{
				[Token(Token = "0x6000FD3")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000259")]
			public bool isValid
			{
				[Token(Token = "0x6000FD4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000FD5")]
			internal Key(int node)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AABBTree.Key..ctor RVA= Token=0x6000FD5");
}
		}

		[Token(Token = "0x2000279")]
		private struct AABBComparer : IComparer<int>
		{
			[Token(Token = "0x4000B83")]
			[FieldOffset(Offset = "0x0")]
			public Node[] nodes;

			[Token(Token = "0x4000B84")]
			[FieldOffset(Offset = "0x0")]
			public int dim;

			[Token(Token = "0x6000FD6")]
			public int Compare(int a, int b)
			{
				return default;
			}
		}

		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x0")]
		private Node[] nodes;

		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x0")]
		private int root;

		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<int> freeNodes;

		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x0")]
		private int rebuildCounter;

		[Token(Token = "0x4000B77")]
		private const int NoNode = -1;

		[Token(Token = "0x17000252")]
		public T this[Key key]
		{
			[Token(Token = "0x6000FB6")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AABBTree.indexer.get RVA= Token=0x6000FB6");
}
		}

		[Token(Token = "0x6000FB5")]
		private static float ExpansionRequired(Bounds b, Bounds b2)
		{
			return default;
		}

		[Token(Token = "0x6000FB7")]
		public Bounds GetBounds(Key key)
		{
			return default;
		}

		[Token(Token = "0x6000FB8")]
		private int AllocNode()
		{
			return default;
		}

		[Token(Token = "0x6000FB9")]
		private void FreeNode(int node)
		{
		}

		[Token(Token = "0x6000FBA")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x6000FBB")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000FBC")]
		private static int ArgMax(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000FBD")]
		private int Rebuild(UnsafeSpan<int> leaves, int parent)
		{
			return default;
		}

		[Token(Token = "0x6000FBE")]
		public void Move(Key key, Bounds bounds)
		{
		}

		[Token(Token = "0x6000FBF")]
		[Conditional("VALIDATE_AABB_TREE")]
		private void Validate(int node)
		{
		}

		[Token(Token = "0x6000FC0")]
		public Bounds Remove(Key key)
		{
			return default;
		}

		[Token(Token = "0x6000FC1")]
		public Key Add(Bounds bounds, T value)
		{
			return default;
		}

		[Token(Token = "0x6000FC2")]
		public void Query(Bounds bounds, List<T> buffer)
		{
		}

		[Token(Token = "0x6000FC3")]
		private void QueryNode(int node, Bounds bounds, List<T> buffer)
		{
		}

		[Token(Token = "0x6000FC4")]
		public void QueryTagged(List<T> buffer, bool clearTags = false)
		{
		}

		[Token(Token = "0x6000FC5")]
		private void QueryTaggedNode(int node, bool clearTags, List<T> buffer)
		{
		}

		[Token(Token = "0x6000FC6")]
		public void Tag(Key key)
		{
		}

		[Token(Token = "0x6000FC7")]
		public void Tag(Bounds bounds)
		{
		}

		[Token(Token = "0x6000FC8")]
		private bool TagNode(int node, Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6000FC9")]
		public AABBTree()
		{
		}
	}
}
