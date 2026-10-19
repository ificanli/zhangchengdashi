using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000DCE")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000DD0")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060E8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060E9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40060EA")]
			[FieldOffset(Offset = "0x20")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x40060EB")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000E98")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60055BD")]
				[Address(RVA = "0x433535C", Offset = "0x433135C", VA = "0x433535C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E99")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60055BF")]
				[Address(RVA = "0x433539C", Offset = "0x433139C", VA = "0x433539C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60055B9")]
			[Address(RVA = "0x4334714", Offset = "0x4330714", VA = "0x4334714")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055BA")]
			[Address(RVA = "0x433511C", Offset = "0x433111C", VA = "0x433511C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60055BB")]
			[Address(RVA = "0x4335138", Offset = "0x4331138", VA = "0x4335138", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60055BC")]
			[Address(RVA = "0x433530C", Offset = "0x433130C", VA = "0x433530C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60055BD")]
			[Address(RVA = "0x433535C", Offset = "0x433135C", VA = "0x433535C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60055BE")]
			[Address(RVA = "0x4335364", Offset = "0x4331364", VA = "0x4335364", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60055BF")]
			[Address(RVA = "0x433539C", Offset = "0x433139C", VA = "0x433539C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000DD1")]
		[CompilerGenerated]
		private sealed class _003Cget_Childs_003Ed__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060EC")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060ED")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x40060EE")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40060EF")]
			[FieldOffset(Offset = "0x28")]
			public JSONClass _003C_003E4__this;

			[Token(Token = "0x40060F0")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000E9A")]
JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60055C4")]
				[Address(RVA = "0x43355B8", Offset = "0x43315B8", VA = "0x43355B8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E9B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60055C6")]
				[Address(RVA = "0x43355F8", Offset = "0x43315F8", VA = "0x43355F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60055C0")]
			[Address(RVA = "0x4334680", Offset = "0x4330680", VA = "0x4334680")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055C1")]
			[Address(RVA = "0x43353A4", Offset = "0x43313A4", VA = "0x43353A4", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60055C2")]
			[Address(RVA = "0x43353C0", Offset = "0x43313C0", VA = "0x43353C0", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60055C3")]
			[Address(RVA = "0x4335568", Offset = "0x4331568", VA = "0x4335568")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60055C4")]
			[Address(RVA = "0x43355B8", Offset = "0x43315B8", VA = "0x43355B8", Slot = "6")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60055C5")]
			[Address(RVA = "0x43355C0", Offset = "0x43315C0", VA = "0x43355C0", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60055C6")]
			[Address(RVA = "0x43355F8", Offset = "0x43315F8", VA = "0x43355F8", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60055C7")]
			[Address(RVA = "0x4335600", Offset = "0x4331600", VA = "0x4335600", Slot = "4")]
			[DebuggerHidden]
IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60055C8")]
			[Address(RVA = "0x433569C", Offset = "0x433169C", VA = "0x433569C", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40060E6")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000E94")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60055A8")]
			[Address(RVA = "0x4333E18", Offset = "0x432FE18", VA = "0x4333E18", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055A9")]
			[Address(RVA = "0x4333F04", Offset = "0x432FF04", VA = "0x4333F04", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000E95")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60055AA")]
			[Address(RVA = "0x4333FD0", Offset = "0x432FFD0", VA = "0x4333FD0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055AB")]
			[Address(RVA = "0x4334070", Offset = "0x4330070", VA = "0x4334070", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000E96")]
		public override int Count
		{
			[Token(Token = "0x60055AC")]
			[Address(RVA = "0x433414C", Offset = "0x433014C", VA = "0x433414C", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E97")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60055B1")]
			[Address(RVA = "0x4334610", Offset = "0x4330610", VA = "0x4334610", Slot = "16")]
			[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__14))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x433419C", Offset = "0x433019C", VA = "0x433419C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x43342B4", Offset = "0x43302B4", VA = "0x43342B4", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x4334378", Offset = "0x4330378", VA = "0x4334378", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x4334454", Offset = "0x4330454", VA = "0x4334454", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x43346B4", Offset = "0x43306B4", VA = "0x43346B4", Slot = "29")]
		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__15))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x433473C", Offset = "0x433073C", VA = "0x433473C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x4334A40", Offset = "0x4330A40", VA = "0x4334A40", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x4334DD4", Offset = "0x4330DD4", VA = "0x4334DD4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x4334FF4", Offset = "0x4330FF4", VA = "0x4334FF4")]
		public JSONClass()
		{
		}
	}
}
