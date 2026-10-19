using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace CommonGameModule.Debugger.Tools.FeiShu
{
	[Token(Token = "0x200002F")]
	public static class FeiShuApi
	{
		[Serializable]
		[Token(Token = "0x2000030")]
		public class MsgBase
		{
			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x10")]
			public int code;

			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x463E378", Offset = "0x463A378", VA = "0x463E378")]
			public MsgBase()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000031")]
		public class Msg_tenant_access_token : MsgBase
		{
			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x20")]
			public string tenant_access_token;

			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x28")]
			public int expire;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x463E380", Offset = "0x463A380", VA = "0x463E380")]
			public Msg_tenant_access_token()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000032")]
		private class FileData
		{
			[Token(Token = "0x400009D")]
			[FieldOffset(Offset = "0x10")]
			public string file_key;

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x463E388", Offset = "0x463A388", VA = "0x463E388")]
			public FileData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000033")]
		private class Msg_files : MsgBase
		{
			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x20")]
			public FileData data;

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x463E390", Offset = "0x463A390", VA = "0x463E390")]
			public Msg_files()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		private class ChatData
		{
			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x10")]
			public string chat_id;

			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x463E398", Offset = "0x463A398", VA = "0x463E398")]
			public ChatData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		private class ChatsData
		{
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x10")]
			public ChatData[] items;

			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x18")]
			public string page_token;

			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x20")]
			public bool has_more;

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x463E3A0", Offset = "0x463A3A0", VA = "0x463E3A0")]
			public ChatsData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		private class Msg_chats : MsgBase
		{
			[Token(Token = "0x40000A4")]
			[FieldOffset(Offset = "0x20")]
			public ChatsData data;

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x463E3A8", Offset = "0x463A3A8", VA = "0x463E3A8")]
			public Msg_chats()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		private class Msg_messages : MsgBase
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x463E3B0", Offset = "0x463A3B0", VA = "0x463E3B0")]
			public Msg_messages()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		private class Msg_RobotMsg : MsgBase
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x463E3B8", Offset = "0x463A3B8", VA = "0x463E3B8")]
			public Msg_RobotMsg()
			{
			}
		}

		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestChatID_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000A6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000A7")]
			[FieldOffset(Offset = "0x20")]
			public string page_token;

			[Token(Token = "0x40000A8")]
			[FieldOffset(Offset = "0x28")]
			public string tenant_access_token;

			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> error;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x38")]
			public string groupName;

			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x40")]
			public Action<string> success;

			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000021")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000DD")]
				[Address(RVA = "0x463ED4C", Offset = "0x463AD4C", VA = "0x463ED4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000022")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DF")]
				[Address(RVA = "0x463ED8C", Offset = "0x463AD8C", VA = "0x463ED8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x463DAA0", Offset = "0x4639AA0", VA = "0x463DAA0")]
			[DebuggerHidden]
			public _003CIE_RequestChatID_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x463E3C0", Offset = "0x463A3C0", VA = "0x463E3C0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x463E3EC", Offset = "0x463A3EC", VA = "0x463E3EC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x463EC9C", Offset = "0x463AC9C", VA = "0x463EC9C")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x463ED4C", Offset = "0x463AD4C", VA = "0x463ED4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x463ED54", Offset = "0x463AD54", VA = "0x463ED54", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x463ED8C", Offset = "0x463AD8C", VA = "0x463ED8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestFeishuRobot_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x20")]
			public string robot_url;

			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x28")]
			public string json;

			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> error;

			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x38")]
			public Action success;

			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000023")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x463F418", Offset = "0x463B418", VA = "0x463F418", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000024")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E6")]
				[Address(RVA = "0x463F458", Offset = "0x463B458", VA = "0x463F458", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x463E0B0", Offset = "0x463A0B0", VA = "0x463E0B0")]
			[DebuggerHidden]
			public _003CIE_RequestFeishuRobot_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x463ED94", Offset = "0x463AD94", VA = "0x463ED94", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x463EDB0", Offset = "0x463ADB0", VA = "0x463EDB0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x463F368", Offset = "0x463B368", VA = "0x463F368")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x463F418", Offset = "0x463B418", VA = "0x463F418", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x463F420", Offset = "0x463B420", VA = "0x463F420", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x463F458", Offset = "0x463B458", VA = "0x463F458", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestSendChat_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000B6")]
			[FieldOffset(Offset = "0x20")]
			public string json;

			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x28")]
			public string tenant_access_token;

			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> error;

			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x38")]
			public Action success;

			[Token(Token = "0x40000BA")]
			[FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000025")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000EB")]
				[Address(RVA = "0x463FB50", Offset = "0x463BB50", VA = "0x463FB50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000026")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000ED")]
				[Address(RVA = "0x463FB90", Offset = "0x463BB90", VA = "0x463FB90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x463DF50", Offset = "0x4639F50", VA = "0x463DF50")]
			[DebuggerHidden]
			public _003CIE_RequestSendChat_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x463F460", Offset = "0x463B460", VA = "0x463F460", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x463F47C", Offset = "0x463B47C", VA = "0x463F47C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x463FAA0", Offset = "0x463BAA0", VA = "0x463FAA0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x463FB50", Offset = "0x463BB50", VA = "0x463FB50", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x463FB58", Offset = "0x463BB58", VA = "0x463FB58", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x463FB90", Offset = "0x463BB90", VA = "0x463FB90", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestToken_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000BD")]
			[FieldOffset(Offset = "0x20")]
			public string app_id;

			[Token(Token = "0x40000BE")]
			[FieldOffset(Offset = "0x28")]
			public string app_secret;

			[Token(Token = "0x40000BF")]
			[FieldOffset(Offset = "0x30")]
			public Action<string> error;

			[Token(Token = "0x40000C0")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> success;

			[Token(Token = "0x40000C1")]
			[FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000027")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x4640320", Offset = "0x463C320", VA = "0x4640320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000028")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x4640360", Offset = "0x463C360", VA = "0x4640360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x463D728", Offset = "0x4639728", VA = "0x463D728")]
			[DebuggerHidden]
			public _003CIE_RequestToken_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x463FB98", Offset = "0x463BB98", VA = "0x463FB98", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x463FBB4", Offset = "0x463BBB4", VA = "0x463FBB4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4640270", Offset = "0x463C270", VA = "0x4640270")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4640320", Offset = "0x463C320", VA = "0x4640320", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4640328", Offset = "0x463C328", VA = "0x4640328", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4640360", Offset = "0x463C360", VA = "0x4640360", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestUploadFile_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x20")]
			public string tenant_access_token;

			[Token(Token = "0x40000C5")]
			[FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x30")]
			public string rename;

			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> error;

			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x40")]
			public Action<string> success;

			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000029")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F9")]
				[Address(RVA = "0x46414C4", Offset = "0x463D4C4", VA = "0x46414C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000FB")]
				[Address(RVA = "0x4641504", Offset = "0x463D504", VA = "0x4641504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x463D844", Offset = "0x4639844", VA = "0x463D844")]
			[DebuggerHidden]
			public _003CIE_RequestUploadFile_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4640368", Offset = "0x463C368", VA = "0x4640368", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4640384", Offset = "0x463C384", VA = "0x4640384", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x4641414", Offset = "0x463D414", VA = "0x4641414")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x46414C4", Offset = "0x463D4C4", VA = "0x46414C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x46414CC", Offset = "0x463D4CC", VA = "0x46414CC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x4641504", Offset = "0x463D504", VA = "0x4641504", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class _003CIE_RequestUploadTextFile_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0x20")]
			public string tenant_access_token;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x30")]
			public string rename;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x38")]
			public Action<string> error;

			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x40")]
			public Action<string> success;

			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x48")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x1700002B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000100")]
				[Address(RVA = "0x46421E8", Offset = "0x463E1E8", VA = "0x46421E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000102")]
				[Address(RVA = "0x4642228", Offset = "0x463E228", VA = "0x4642228", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x463D960", Offset = "0x4639960", VA = "0x463D960")]
			[DebuggerHidden]
			public _003CIE_RequestUploadTextFile_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x464150C", Offset = "0x463D50C", VA = "0x464150C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x4641528", Offset = "0x463D528", VA = "0x4641528", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x4642138", Offset = "0x463E138", VA = "0x4642138")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x46421E8", Offset = "0x463E1E8", VA = "0x46421E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x46421F0", Offset = "0x463E1F0", VA = "0x46421F0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x4642228", Offset = "0x463E228", VA = "0x4642228", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000095")]
		private const string REQUEST_TOKEN_URL = "https://open.feishu.cn/open-apis/auth/v3/tenant_access_token/internal";

		[Token(Token = "0x4000096")]
		private const string REQUEST_UPLOADFILE_URL = "https://open.feishu.cn/open-apis/im/v1/files";

		[Token(Token = "0x4000097")]
		private const string REQUEST_CHATID_URL = "https://open.feishu.cn/open-apis/im/v1/chats";

		[Token(Token = "0x4000098")]
		private const string REQUEST_SENDCHAT_URL = "https://open.feishu.cn/open-apis/im/v1/messages?receive_id_type=chat_id";

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x463D64C", Offset = "0x463964C", VA = "0x463D64C")]
		public static void RequestToken(string app_id, string app_secret, Action<string> success, Action<string> error)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x463D6A8", Offset = "0x46396A8", VA = "0x463D6A8")]
		[IteratorStateMachine(typeof(_003CIE_RequestToken_003Ed__5))]
		private static IEnumerator IE_RequestToken(string app_id, string app_secret, Action<string> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x463D750", Offset = "0x4639750", VA = "0x463D750")]
		public static void RequestUploadFile(string tenant_access_token, string localFilePath, string rename, Action<string> success, Action<string> error)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x463D7BC", Offset = "0x46397BC", VA = "0x463D7BC")]
		[IteratorStateMachine(typeof(_003CIE_RequestUploadFile_003Ed__7))]
		private static IEnumerator IE_RequestUploadFile(string tenant_access_token, string path, string rename, Action<string> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x463D86C", Offset = "0x463986C", VA = "0x463D86C")]
		public static void RequestUploadTextFile(string tenant_access_token, string text, string rename, Action<string> success, Action<string> error)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x463D8D8", Offset = "0x46398D8", VA = "0x463D8D8")]
		[IteratorStateMachine(typeof(_003CIE_RequestUploadTextFile_003Ed__9))]
		private static IEnumerator IE_RequestUploadTextFile(string tenant_access_token, string text, string rename, Action<string> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x463D988", Offset = "0x4639988", VA = "0x463D988")]
		public static void RequestChatID(string tenant_access_token, string groupName, Action<string> success, Action<string> error)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x463DA18", Offset = "0x4639A18", VA = "0x463DA18")]
		[IteratorStateMachine(typeof(_003CIE_RequestChatID_003Ed__11))]
		private static IEnumerator IE_RequestChatID(string tenant_access_token, string groupName, string page_token, Action<string> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x463DAC8", Offset = "0x4639AC8", VA = "0x463DAC8")]
		public static void RequestSendChat_File(string tenant_access_token, string groupid, string file_key, Action success, Action<string> error)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x463DC7C", Offset = "0x4639C7C", VA = "0x463DC7C")]
		public static void RequestSendChat_Text(string tenant_access_token, string groupid, string text, Action success, Action<string> error)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x463DBFC", Offset = "0x4639BFC", VA = "0x463DBFC")]
		[IteratorStateMachine(typeof(_003CIE_RequestSendChat_003Ed__14))]
		private static IEnumerator IE_RequestSendChat(string tenant_access_token, string json, Action success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x463DF78", Offset = "0x4639F78", VA = "0x463DF78")]
		public static void RequestFeishuRobot(string robot_url, string text, Action success, Action<string> error)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x463E030", Offset = "0x463A030", VA = "0x463E030")]
		[IteratorStateMachine(typeof(_003CIE_RequestFeishuRobot_003Ed__16))]
		private static IEnumerator IE_RequestFeishuRobot(string robot_url, string json, Action success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x463E0D8", Offset = "0x463A0D8", VA = "0x463E0D8")]
		public static string GetMsgTitle()
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4639B94", Offset = "0x4635B94", VA = "0x4639B94")]
		public static string GetLogFileName()
		{
			return null;
		}
	}
}
