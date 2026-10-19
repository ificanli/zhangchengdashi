using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x2000DCB")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000DCC")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060DD")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060DE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40060DF")]
			[FieldOffset(Offset = "0x20")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x40060E0")]
			[FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000E90")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600559C")]
				[Address(RVA = "0x4333AE8", Offset = "0x432FAE8", VA = "0x4333AE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E91")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600559E")]
				[Address(RVA = "0x4333B28", Offset = "0x432FB28", VA = "0x4333B28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005598")]
			[Address(RVA = "0x43332F0", Offset = "0x432F2F0", VA = "0x43332F0")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005599")]
			[Address(RVA = "0x43338E8", Offset = "0x432F8E8", VA = "0x43338E8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600559A")]
			[Address(RVA = "0x4333904", Offset = "0x432F904", VA = "0x4333904", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600559B")]
			[Address(RVA = "0x4333A98", Offset = "0x432FA98", VA = "0x4333A98")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600559C")]
			[Address(RVA = "0x4333AE8", Offset = "0x432FAE8", VA = "0x4333AE8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600559D")]
			[Address(RVA = "0x4333AF0", Offset = "0x432FAF0", VA = "0x4333AF0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600559E")]
			[Address(RVA = "0x4333B28", Offset = "0x432FB28", VA = "0x4333B28", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000DCD")]
		[CompilerGenerated]
		private sealed class _003Cget_Childs_003Ed__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060E1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060E2")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode _003C_003E2__current;

			[Token(Token = "0x40060E3")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40060E4")]
			[FieldOffset(Offset = "0x28")]
			public JSONArray _003C_003E4__this;

			[Token(Token = "0x40060E5")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x17000E92")]
JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60055A3")]
				[Address(RVA = "0x4333D30", Offset = "0x432FD30", VA = "0x4333D30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E93")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60055A5")]
				[Address(RVA = "0x4333D70", Offset = "0x432FD70", VA = "0x4333D70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600559F")]
			[Address(RVA = "0x433325C", Offset = "0x432F25C", VA = "0x433325C")]
			[DebuggerHidden]
			public _003Cget_Childs_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60055A0")]
			[Address(RVA = "0x4333B30", Offset = "0x432FB30", VA = "0x4333B30", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60055A1")]
			[Address(RVA = "0x4333B4C", Offset = "0x432FB4C", VA = "0x4333B4C", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60055A2")]
			[Address(RVA = "0x4333CE0", Offset = "0x432FCE0", VA = "0x4333CE0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60055A3")]
			[Address(RVA = "0x4333D30", Offset = "0x432FD30", VA = "0x4333D30", Slot = "6")]
			[DebuggerHidden]
			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CI2_002ELoc_002ESimpleJSON_002EJSONNode_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60055A4")]
			[Address(RVA = "0x4333D38", Offset = "0x432FD38", VA = "0x4333D38", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60055A5")]
			[Address(RVA = "0x4333D70", Offset = "0x432FD70", VA = "0x4333D70", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60055A6")]
			[Address(RVA = "0x4333D78", Offset = "0x432FD78", VA = "0x4333D78", Slot = "4")]
			[DebuggerHidden]
IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60055A7")]
			[Address(RVA = "0x4333E14", Offset = "0x432FE14", VA = "0x4333E14", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40060DC")]
		[FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x17000E8C")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600558A")]
			[Address(RVA = "0x4332D10", Offset = "0x432ED10", VA = "0x4332D10", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600558B")]
			[Address(RVA = "0x4332DE8", Offset = "0x432EDE8", VA = "0x4332DE8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000E8D")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600558C")]
			[Address(RVA = "0x4332EEC", Offset = "0x432EEEC", VA = "0x4332EEC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600558D")]
			[Address(RVA = "0x4332F48", Offset = "0x432EF48", VA = "0x4332F48", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000E8E")]
		public override int Count
		{
			[Token(Token = "0x600558E")]
			[Address(RVA = "0x4332FEC", Offset = "0x432EFEC", VA = "0x4332FEC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E8F")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6005592")]
			[Address(RVA = "0x43331EC", Offset = "0x432F1EC", VA = "0x43331EC", Slot = "16")]
			[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__13))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600558F")]
		[Address(RVA = "0x4333034", Offset = "0x432F034", VA = "0x4333034", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6005590")]
		[Address(RVA = "0x43330D8", Offset = "0x432F0D8", VA = "0x43330D8", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6005591")]
		[Address(RVA = "0x433318C", Offset = "0x432F18C", VA = "0x433318C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6005593")]
		[Address(RVA = "0x4333290", Offset = "0x432F290", VA = "0x4333290", Slot = "29")]
		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__14))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6005594")]
		[Address(RVA = "0x4333318", Offset = "0x432F318", VA = "0x4333318", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6005595")]
		[Address(RVA = "0x4333510", Offset = "0x432F510", VA = "0x4333510", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6005596")]
		[Address(RVA = "0x4333790", Offset = "0x432F790", VA = "0x4333790", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6005597")]
		[Address(RVA = "0x433386C", Offset = "0x432F86C", VA = "0x433386C")]
		public JSONArray()
		{
		}
	}
}
