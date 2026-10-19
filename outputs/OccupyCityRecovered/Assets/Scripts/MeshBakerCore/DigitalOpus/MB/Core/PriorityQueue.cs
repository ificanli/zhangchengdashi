using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000BA")]
	public class PriorityQueue<TPriority, TValue> : ICollection<KeyValuePair<TPriority, TValue>>, IEnumerable<KeyValuePair<TPriority, TValue>>, IEnumerable
	{
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x0")]
		public List<KeyValuePair<TPriority, TValue>> _baseHeap;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x0")]
		private IComparer<TPriority> _comparer;

		[Token(Token = "0x17000071")]
		public bool IsEmpty
		{
			[Token(Token = "0x600038F")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000072")]
		public int Count
		{
			[Token(Token = "0x6000399")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000073")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600039B")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000382")]
		public PriorityQueue()
		{
		}

		[Token(Token = "0x6000383")]
		public PriorityQueue(int capacity)
		{
		}

		[Token(Token = "0x6000384")]
		public PriorityQueue(int capacity, IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000385")]
		public PriorityQueue(IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000386")]
		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data)
		{
		}

		[Token(Token = "0x6000387")]
		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data, IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000388")]
		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2, IComparer<TPriority> comparer)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		public void Enqueue(TPriority priority, TValue value)
		{
		}

		[Token(Token = "0x600038B")]
		public KeyValuePair<TPriority, TValue> Dequeue()
		{
			return default;
		}

		[Token(Token = "0x600038C")]
		public TValue DequeueValue()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PriorityQueue.DequeueValue RVA= Token=0x600038C");
}

		[Token(Token = "0x600038D")]
		public KeyValuePair<TPriority, TValue> Peek()
		{
			return default;
		}

		[Token(Token = "0x600038E")]
		public TValue PeekValue()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PriorityQueue.PeekValue RVA= Token=0x600038E");
}

		[Token(Token = "0x6000390")]
		private void ExchangeElements(int pos1, int pos2)
		{
		}

		[Token(Token = "0x6000391")]
		private void Insert(TPriority priority, TValue value)
		{
		}

		[Token(Token = "0x6000392")]
		private int HeapifyFromEndToBeginning(int pos)
		{
			return default;
		}

		[Token(Token = "0x6000393")]
		private void DeleteRoot()
		{
		}

		[Token(Token = "0x6000394")]
		private void HeapifyFromBeginningToEnd(int pos)
		{
		}

		[Token(Token = "0x6000395")]
		public void Add(KeyValuePair<TPriority, TValue> item)
		{
		}

		[Token(Token = "0x6000396")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000397")]
		public bool Contains(KeyValuePair<TPriority, TValue> item)
		{
			return default;
		}

		[Token(Token = "0x6000398")]
		public bool TryFindValue(TPriority item, out TValue foundVersion)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PriorityQueue.TryFindValue RVA= Token=0x6000398");
}

		[Token(Token = "0x600039A")]
		public void CopyTo(KeyValuePair<TPriority, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600039C")]
		public bool Remove(KeyValuePair<TPriority, TValue> item)
		{
			return default;
		}

		[Token(Token = "0x600039D")]
		public IEnumerator<KeyValuePair<TPriority, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600039E")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
