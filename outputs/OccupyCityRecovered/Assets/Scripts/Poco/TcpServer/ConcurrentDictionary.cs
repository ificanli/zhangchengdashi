using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace TcpServer
{
	[Serializable]
	[Token(Token = "0x200001A")]
	[ComVisible(false)]
	[DebuggerDisplay("Count = {Count}")]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
	{
		[Token(Token = "0x200001B")]
		private class Node
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TKey m_key;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue m_value;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node m_next;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int m_hashcode;

			[Token(Token = "0x60000AC")]
			internal Node(TKey key, TValue value, int hashcode)
			{
			}

			[Token(Token = "0x60000AD")]
			internal Node(TKey key, TValue value, int hashcode, Node next)
			{
			}
		}

		[Token(Token = "0x200001C")]
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator;

			[Token(Token = "0x1700000F")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x60000AF")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000010")]
			public object Key
			{
				[Token(Token = "0x60000B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			public object Value
			{
				[Token(Token = "0x60000B1")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			public object Current
			{
				[Token(Token = "0x60000B2")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000AE")]
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
			}

			[Token(Token = "0x60000B3")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000B4")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__29 : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _003C_003E2__current;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ConcurrentDictionary<TKey, TValue> _003C_003E4__this;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Node[] _003Cbuckets_003E5__2;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Node _003Ccurrent_003E5__4;

			[Token(Token = "0x17000013")]
KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
			{
				[Token(Token = "0x60000B8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000014")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BA")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000B5")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000B6")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B7")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000B8")]
			[DebuggerHidden]
			private KeyValuePair<TKey, TValue> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x60000B9")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000BA")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node[] m_buckets;

		[NonSerialized]
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object[] m_locks;

		[NonSerialized]
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] m_countPerLock;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEqualityComparer<TKey> m_comparer;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private KeyValuePair<TKey, TValue>[] m_serializationArray;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_serializationConcurrencyLevel;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_serializationCapacity;

		[Token(Token = "0x400003B")]
		private const int DEFAULT_CONCURRENCY_MULTIPLIER = 4;

		[Token(Token = "0x400003C")]
		private const int DEFAULT_CAPACITY = 31;

		[Token(Token = "0x17000001")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6000082")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.indexer.get RVA= Token=0x6000082");
}
			[Token(Token = "0x6000083")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public int Count
		{
			[Token(Token = "0x6000084")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000089")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x600008C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x600008D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
		{
			[Token(Token = "0x6000090")]
			get
			{
				return System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x17000007")]
bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x6000096")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsFixedSize();
			}
		}

		[Token(Token = "0x17000008")]
bool System.Collections.IDictionary.IsReadOnly
		{
			[Token(Token = "0x6000097")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_IsReadOnly();
			}
		}

		[Token(Token = "0x17000009")]
ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x6000098")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Keys();
			}
		}

		[Token(Token = "0x1700000A")]
ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x600009A")]
			get
			{
				return System_002ECollections_002EIDictionary_002Eget_Values();
			}
		}

		[Token(Token = "0x1700000B")]
        object System.Collections.IDictionary.this[object key]
        {
            [Token(Token = "0x600009B")]
            get { return System_002ECollections_002EIDictionary_002Eget_Item(key); }
            [Token(Token = "0x600009C")]
            set { System_002ECollections_002EIDictionary_002Eset_Item(key, value); }
        }

		[Token(Token = "0x1700000C")]
bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x600009E")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_IsSynchronized();
			}
		}

		[Token(Token = "0x1700000D")]
object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x600009F")]
			get
			{
				return System_002ECollections_002EICollection_002Eget_SyncRoot();
			}
		}

		[Token(Token = "0x1700000E")]
		private static int DefaultConcurrencyLevel
		{
			[Token(Token = "0x60000A2")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600006C")]
		public ConcurrentDictionary()
		{
		}

		[Token(Token = "0x600006D")]
		public ConcurrentDictionary(int concurrencyLevel, int capacity)
		{
		}

		[Token(Token = "0x600006E")]
		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		[Token(Token = "0x600006F")]
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000070")]
		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000071")]
		public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000072")]
		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		[Token(Token = "0x6000073")]
		public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000074")]
		public bool TryAdd(TKey key, TValue value)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		public bool ContainsKey(TKey key)
		{
			return default;
		}

		[Token(Token = "0x6000076")]
		public bool TryRemove(TKey key, out TValue value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.TryRemove RVA= Token=0x6000076");
}

		[Token(Token = "0x6000077")]
		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.TryRemoveInternal RVA= Token=0x6000077");
}

		[Token(Token = "0x6000078")]
		public bool TryGetValue(TKey key, out TValue value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.TryGetValue RVA= Token=0x6000078");
}

		[Token(Token = "0x6000079")]
		public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		public void Clear()
		{
		}

		[Token(Token = "0x600007B")]
void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x600007C")]
		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x600007E")]
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
		}

		[Token(Token = "0x600007F")]
		private void CopyToObjects(object[] array, int index)
		{
		}

		[Token(Token = "0x6000080")]
		[IteratorStateMachine(typeof(ConcurrentDictionary<, >._003CGetEnumerator_003Ed__29))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		private bool TryAddInternal(TKey key, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.TryAddInternal RVA= Token=0x6000081");
}

		[Token(Token = "0x6000085")]
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.GetOrAdd RVA= Token=0x6000085");
}

		[Token(Token = "0x6000086")]
		public TValue GetOrAdd(TKey key, TValue value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.GetOrAdd RVA= Token=0x6000086");
}

		[Token(Token = "0x6000087")]
		public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.AddOrUpdate RVA= Token=0x6000087");
}

		[Token(Token = "0x6000088")]
		public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.AddOrUpdate RVA= Token=0x6000088");
}

		[Token(Token = "0x600008A")]
void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x600008B")]
bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key)
		{
			return default;
		}

		[Token(Token = "0x600008E")]
void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		[Token(Token = "0x600008F")]
bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default;
		}

		[Token(Token = "0x6000090")]
		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6000091")]
bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return default;
		}

		[Token(Token = "0x6000092")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000093")]
void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		[Token(Token = "0x6000094")]
bool System.Collections.IDictionary.Contains(object key)
		{
			return default;
		}

		[Token(Token = "0x6000095")]
IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsFixedSize()
		{
			return default;
		}

		[Token(Token = "0x6000097")]
		private bool System_002ECollections_002EIDictionary_002Eget_IsReadOnly()
		{
			return default;
		}

		[Token(Token = "0x6000098")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Keys()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x600009A")]
		private ICollection System_002ECollections_002EIDictionary_002Eget_Values()
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		private object System_002ECollections_002EIDictionary_002Eget_Item(object key)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		private void System_002ECollections_002EIDictionary_002Eset_Item(object key, object value)
		{
		}

		[Token(Token = "0x600009D")]
void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x600009E")]
		private bool System_002ECollections_002EICollection_002Eget_IsSynchronized()
		{
			return default;
		}

		[Token(Token = "0x600009F")]
		private object System_002ECollections_002EICollection_002Eget_SyncRoot()
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		private void GrowTable(Node[] buckets)
		{
		}

		[Token(Token = "0x60000A1")]
		private void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConcurrentDictionary.GetBucketAndLockNo RVA= Token=0x60000A1");
}

		[Token(Token = "0x60000A3")]
		private void AcquireAllLocks(ref int locksAcquired)
		{
		}

		[Token(Token = "0x60000A4")]
		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
		}

		[Token(Token = "0x60000A5")]
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
		}

		[Token(Token = "0x60000A6")]
		private ReadOnlyCollection<TKey> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		private ReadOnlyCollection<TValue> GetValues()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Conditional("DEBUG")]
		private void Assert(bool condition)
		{
		}

		[Token(Token = "0x60000A9")]
		private string GetResource(string key)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
		}

		[Token(Token = "0x60000AB")]
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}
	}
}
