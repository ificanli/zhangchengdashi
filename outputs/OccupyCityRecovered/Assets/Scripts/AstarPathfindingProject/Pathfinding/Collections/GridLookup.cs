using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000287")]
	public class GridLookup<T> where T : class
	{
		[Token(Token = "0x2000288")]
		internal class Item
		{
			[Token(Token = "0x4000BB3")]
			[FieldOffset(Offset = "0x0")]
			public Root root;

			[Token(Token = "0x4000BB4")]
			[FieldOffset(Offset = "0x0")]
			public Item prev;

			[Token(Token = "0x4000BB5")]
			[FieldOffset(Offset = "0x0")]
			public Item next;

			[Token(Token = "0x600101B")]
			public Item()
			{
			}
		}

		[Token(Token = "0x2000289")]
		public class Root
		{
			[Token(Token = "0x4000BB6")]
			[FieldOffset(Offset = "0x0")]
			public T obj;

			[Token(Token = "0x4000BB7")]
			[FieldOffset(Offset = "0x0")]
			public Root next;

			[Token(Token = "0x4000BB8")]
			[FieldOffset(Offset = "0x0")]
			internal Root prev;

			[Token(Token = "0x4000BB9")]
			[FieldOffset(Offset = "0x0")]
			internal IntRect previousBounds;

			[Token(Token = "0x4000BBA")]
			[FieldOffset(Offset = "0x0")]
			internal List<Item> items;

			[Token(Token = "0x4000BBB")]
			[FieldOffset(Offset = "0x0")]
			internal bool flag;

			[Token(Token = "0x4000BBC")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 previousPosition;

			[Token(Token = "0x4000BBD")]
			[FieldOffset(Offset = "0x0")]
			public Quaternion previousRotation;

			[Token(Token = "0x600101C")]
			public Root()
			{
			}
		}

		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x0")]
		private Vector2Int size;

		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x0")]
		private Item[] cells;

		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x0")]
		private Root all;

		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, Root> rootLookup;

		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x0")]
		private Stack<Item> itemPool;

		[Token(Token = "0x1700025F")]
		public Root AllItems
		{
			[Token(Token = "0x6001012")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001011")]
		public GridLookup(Vector2Int size)
		{
		}

		[Token(Token = "0x6001013")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001014")]
		public Root GetRoot(T item)
		{
			return null;
		}

		[Token(Token = "0x6001015")]
		public Root Add(T item, IntRect bounds)
		{
			return null;
		}

		[Token(Token = "0x6001016")]
		public void Remove(T item)
		{
		}

		[Token(Token = "0x6001017")]
		public void Dirty(T item)
		{
		}

		[Token(Token = "0x6001018")]
		public void Move(T item, IntRect bounds)
		{
		}

		[Token(Token = "0x6001019")]
		public List<U> QueryRect<U>(IntRect r) where U : class, T
		{
			return null;
		}

		[Token(Token = "0x600101A")]
		public void Resize(IntRect newBounds)
		{
		}
	}
}
