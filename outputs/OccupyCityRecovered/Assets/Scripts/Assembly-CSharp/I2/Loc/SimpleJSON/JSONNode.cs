using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000DC8")]
	public class JSONNode
	{
		[Token(Token = "0x2000DC9")]
		[CompilerGenerated]
		private sealed class _003Cget_Childs_003Ed__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060D3")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060D4")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x40060D5")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x17000E88")]
JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600557B")]
				[Address(RVA = "0x43324D4", Offset = "0x432E4D4", VA = "0x43324D4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E89")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600557D")]
				[Address(RVA = "0x4332514", Offset = "0x432E514", VA = "0x4332514", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005578")]
			[Address(RVA = "0x4332484", Offset = "0x432E484", VA = "0x4332484")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005579")]
			[Address(RVA = "0x43324B8", Offset = "0x432E4B8", VA = "0x43324B8", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600557A")]
			[Address(RVA = "0x43324BC", Offset = "0x432E4BC", VA = "0x43324BC", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600557B")]
			[Address(RVA = "0x43324D4", Offset = "0x432E4D4", VA = "0x43324D4", Slot = "6")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600557C")]
			[Address(RVA = "0x43324DC", Offset = "0x432E4DC", VA = "0x43324DC", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600557D")]
			[Address(RVA = "0x4332514", Offset = "0x432E514", VA = "0x4332514", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600557E")]
			[Address(RVA = "0x433251C", Offset = "0x432E51C", VA = "0x433251C", Slot = "4")]
			[DebuggerHidden]
IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600557F")]
			[Address(RVA = "0x43325AC", Offset = "0x432E5AC", VA = "0x43325AC", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000DCA")]
		[CompilerGenerated]
		private sealed class _003Cget_DeepChilds_003Ed__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060D6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060D7")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x40060D8")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40060D9")]
			[FieldOffset(Offset = "0x28")]
			public JSONNode _003C_003E4__this;

			[Token(Token = "0x40060DA")]
			[FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			[Token(Token = "0x40060DB")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> _003C_003E7__wrap2;

			[Token(Token = "0x17000E8A")]
JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6005585")]
				[Address(RVA = "0x4332C28", Offset = "0x432EC28", VA = "0x4332C28", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E8B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005587")]
				[Address(RVA = "0x4332C68", Offset = "0x432EC68", VA = "0x4332C68", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005580")]
			[Address(RVA = "0x43325B0", Offset = "0x432E5B0", VA = "0x43325B0")]
			[DebuggerHidden]
			public _003Cget_DeepChilds_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005581")]
			[Address(RVA = "0x43325E4", Offset = "0x432E5E4", VA = "0x43325E4", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005582")]
			[Address(RVA = "0x4332694", Offset = "0x432E694", VA = "0x4332694", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005583")]
			[Address(RVA = "0x4332B78", Offset = "0x432EB78", VA = "0x4332B78")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6005584")]
			[Address(RVA = "0x4332AC8", Offset = "0x432EAC8", VA = "0x4332AC8")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x6005585")]
			[Address(RVA = "0x4332C28", Offset = "0x432EC28", VA = "0x4332C28", Slot = "6")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005586")]
			[Address(RVA = "0x4332C30", Offset = "0x432EC30", VA = "0x4332C30", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005587")]
			[Address(RVA = "0x4332C68", Offset = "0x432EC68", VA = "0x4332C68", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005588")]
			[Address(RVA = "0x4332C70", Offset = "0x432EC70", VA = "0x4332C70", Slot = "4")]
			[DebuggerHidden]
IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6005589")]
			[Address(RVA = "0x4332D0C", Offset = "0x432ED0C", VA = "0x4332D0C", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000E7C")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6005548")]
			[Address(RVA = "0x43306EC", Offset = "0x432C6EC", VA = "0x43306EC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005549")]
			[Address(RVA = "0x43306F4", Offset = "0x432C6F4", VA = "0x43306F4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000E7D")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x600554A")]
			[Address(RVA = "0x43306F8", Offset = "0x432C6F8", VA = "0x43306F8", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600554B")]
			[Address(RVA = "0x4330700", Offset = "0x432C700", VA = "0x4330700", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000E7E")]
		public virtual string Value
		{
			[Token(Token = "0x600554C")]
			[Address(RVA = "0x4330704", Offset = "0x432C704", VA = "0x4330704", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600554D")]
			[Address(RVA = "0x4330744", Offset = "0x432C744", VA = "0x4330744", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000E7F")]
		public virtual int Count
		{
			[Token(Token = "0x600554E")]
			[Address(RVA = "0x4330748", Offset = "0x432C748", VA = "0x4330748", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E80")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6005553")]
			[Address(RVA = "0x43307C8", Offset = "0x432C7C8", VA = "0x43307C8", Slot = "16")]
			[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__17))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E81")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6005554")]
			[Address(RVA = "0x4330820", Offset = "0x432C820", VA = "0x4330820")]
			[IteratorStateMachine(typeof(_003Cget_DeepChilds_003Ed__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E82")]
		public virtual int AsInt
		{
			[Token(Token = "0x6005557")]
			[Address(RVA = "0x4330908", Offset = "0x432C908", VA = "0x4330908", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005558")]
			[Address(RVA = "0x433093C", Offset = "0x432C93C", VA = "0x433093C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000E83")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6005559")]
			[Address(RVA = "0x4330978", Offset = "0x432C978", VA = "0x4330978", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x600555A")]
			[Address(RVA = "0x43309B0", Offset = "0x432C9B0", VA = "0x43309B0", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000E84")]
		public virtual double AsDouble
		{
			[Token(Token = "0x600555B")]
			[Address(RVA = "0x43309EC", Offset = "0x432C9EC", VA = "0x43309EC", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x600555C")]
			[Address(RVA = "0x4330A24", Offset = "0x432CA24", VA = "0x4330A24", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000E85")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600555D")]
			[Address(RVA = "0x4330A60", Offset = "0x432CA60", VA = "0x4330A60", Slot = "24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600555E")]
			[Address(RVA = "0x4330B18", Offset = "0x432CB18", VA = "0x4330B18", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000E86")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x600555F")]
			[Address(RVA = "0x4330B90", Offset = "0x432CB90", VA = "0x4330B90", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E87")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6005560")]
			[Address(RVA = "0x4330C08", Offset = "0x432CC08", VA = "0x4330C08", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005547")]
		[Address(RVA = "0x43306E8", Offset = "0x432C6E8", VA = "0x43306E8", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600554F")]
		[Address(RVA = "0x4330750", Offset = "0x432C750", VA = "0x4330750", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6005550")]
		[Address(RVA = "0x43307B0", Offset = "0x432C7B0", VA = "0x43307B0", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6005551")]
		[Address(RVA = "0x43307B8", Offset = "0x432C7B8", VA = "0x43307B8", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6005552")]
		[Address(RVA = "0x43307C0", Offset = "0x432C7C0", VA = "0x43307C0", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6005555")]
		[Address(RVA = "0x4330888", Offset = "0x432C888", VA = "0x4330888", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6005556")]
		[Address(RVA = "0x43308C8", Offset = "0x432C8C8", VA = "0x43308C8", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6005561")]
		[Address(RVA = "0x4330C80", Offset = "0x432CC80", VA = "0x4330C80")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6005562")]
		[Address(RVA = "0x4330CDC", Offset = "0x432CCDC", VA = "0x4330CDC")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6005563")]
		[Address(RVA = "0x4330D18", Offset = "0x432CD18", VA = "0x4330D18")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default;
		}

		[Token(Token = "0x6005564")]
		[Address(RVA = "0x4330DA0", Offset = "0x432CDA0", VA = "0x4330DA0")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default;
		}

		[Token(Token = "0x6005565")]
		[Address(RVA = "0x4330DB8", Offset = "0x432CDB8", VA = "0x4330DB8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6005566")]
		[Address(RVA = "0x4330DC4", Offset = "0x432CDC4", VA = "0x4330DC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6005567")]
		[Address(RVA = "0x4330DCC", Offset = "0x432CDCC", VA = "0x4330DCC")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6005568")]
		[Address(RVA = "0x4330FBC", Offset = "0x432CFBC", VA = "0x4330FBC")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6005569")]
		[Address(RVA = "0x4331754", Offset = "0x432D754", VA = "0x4331754", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x600556A")]
		[Address(RVA = "0x4331758", Offset = "0x432D758", VA = "0x4331758")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x600556B")]
		[Address(RVA = "0x43317D0", Offset = "0x432D7D0", VA = "0x43317D0")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x600556C")]
		[Address(RVA = "0x433181C", Offset = "0x432D81C", VA = "0x433181C")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x600556D")]
		[Address(RVA = "0x4331868", Offset = "0x432D868", VA = "0x4331868")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x600556E")]
		[Address(RVA = "0x43318B4", Offset = "0x432D8B4", VA = "0x43318B4")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x600556F")]
		[Address(RVA = "0x4331A80", Offset = "0x432DA80", VA = "0x4331A80")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6005570")]
		[Address(RVA = "0x4331C88", Offset = "0x432DC88", VA = "0x4331C88")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6005571")]
		[Address(RVA = "0x4331FD4", Offset = "0x432DFD4", VA = "0x4331FD4")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6005572")]
		[Address(RVA = "0x4332020", Offset = "0x432E020", VA = "0x4332020")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6005573")]
		[Address(RVA = "0x433206C", Offset = "0x432E06C", VA = "0x433206C")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6005574")]
		[Address(RVA = "0x43320B8", Offset = "0x432E0B8", VA = "0x43320B8")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6005575")]
		[Address(RVA = "0x4332250", Offset = "0x432E250", VA = "0x4332250")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6005576")]
		[Address(RVA = "0x43323C8", Offset = "0x432E3C8", VA = "0x43323C8")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6005577")]
		[Address(RVA = "0x433247C", Offset = "0x432E47C", VA = "0x433247C")]
		public JSONNode()
		{
		}
	}
}
