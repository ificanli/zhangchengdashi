using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	[Serializable]
	[Token(Token = "0x2000CC2")]
	[DebuggerDisplay("Count = {Count}")]
	public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		[Token(Token = "0x2000CC3")]
		private static class PrimeHelper
		{
			[Token(Token = "0x4005B87")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int[] Primes;

			[Token(Token = "0x6005000")]
			public static bool IsPrime(int candidate)
			{
				return default;
			}

			[Token(Token = "0x6005001")]
			public static int GetPrime(int min)
			{
				return default;
			}

			[Token(Token = "0x6005002")]
			public static int ExpandPrime(int oldSize)
			{
				return default;
			}
		}

		[Token(Token = "0x2000CC4")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005B88")]
			[FieldOffset(Offset = "0x0")]
			private readonly SerializableDictionary<TKey, TValue> _Dictionary;

			[Token(Token = "0x4005B89")]
			[FieldOffset(Offset = "0x0")]
			private int _Version;

			[Token(Token = "0x4005B8A")]
			[FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x4005B8B")]
			[FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _Current;

			[Token(Token = "0x17000E2D")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6005004")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000E2E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005008")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005005")]
			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SerializableDictionary.Enumerator..ctor RVA= Token=0x6005005");
}

			[Token(Token = "0x6005006")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005007")]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005008")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005009")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4005B7D")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int[] _Buckets;

		[Token(Token = "0x4005B7E")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int[] _HashCodes;

		[Token(Token = "0x4005B7F")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int[] _Next;

		[Token(Token = "0x4005B80")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _Count;

		[Token(Token = "0x4005B81")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _Version;

		[Token(Token = "0x4005B82")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _FreeList;

		[Token(Token = "0x4005B83")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _FreeCount;

		[Token(Token = "0x4005B84")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private TKey[] _Keys;

		[Token(Token = "0x4005B85")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private TValue[] _Values;

		[Token(Token = "0x4005B86")]
		[FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> _Comparer;

		[Token(Token = "0x17000E26")]
		public Dictionary<TKey, TValue> AsDictionary
		{
			[Token(Token = "0x6004FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E27")]
		public int Count
		{
			[Token(Token = "0x6004FE1")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E28")]
		public TValue this[TKey key, TValue defaultValue]
		{
			[Token(Token = "0x6004FE2")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SerializableDictionary.indexer.get RVA= Token=0x6004FE2");
}
		}

		[Token(Token = "0x17000E29")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6004FE3")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SerializableDictionary.indexer.get RVA= Token=0x6004FE3");
}
			[Token(Token = "0x6004FE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000E2A")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6004FF6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E2B")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6004FF7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E2C")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6004FFB")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004FE5")]
		public SerializableDictionary()
		{
		}

		[Token(Token = "0x6004FE6")]
		public SerializableDictionary(int capacity)
		{
		}

		[Token(Token = "0x6004FE7")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6004FE8")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6004FE9")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x6004FEA")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6004FEB")]
		public bool ContainsValue(TValue value)
		{
			return default;
		}

		[Token(Token = "0x6004FEC")]
		public bool ContainsKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6004FED")]
		public void Clear()
		{
		}

		[Token(Token = "0x6004FEE")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6004FEF")]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		[Token(Token = "0x6004FF0")]
		private void Resize()
		{
		}

		[Token(Token = "0x6004FF1")]
		public bool Remove(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6004FF2")]
		private void Insert(TKey key, TValue value, bool add)
		{
		}

		[Token(Token = "0x6004FF3")]
		private void Initialize(int capacity)
		{
		}

		[Token(Token = "0x6004FF4")]
		private int FindIndex(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6004FF5")]
		public bool TryGetValue(TKey key, out TValue value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SerializableDictionary.TryGetValue RVA= Token=0x6004FF5");
}

		[Token(Token = "0x6004FF8")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6004FF9")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default;
		}

		[Token(Token = "0x6004FFA")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x6004FFC")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default;
		}

		[Token(Token = "0x6004FFD")]
		public Enumerator GetEnumerator()
		{
			return default;
		}

		[Token(Token = "0x6004FFE")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6004FFF")]
IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			return null;
		}
	}
}
