using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200001F")]
	public static class MyServerAPI
	{
		[Serializable]
		[Token(Token = "0x2000020")]
		[Skip]
		public class DebugSystemVersion
		{
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string debug_system_ver;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string gf_ver;

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4638C6C", Offset = "0x4634C6C", VA = "0x4638C6C")]
			public DebugSystemVersion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000021")]
		[Skip]
		public class SendLogMsgRequestData : DebugSystemVersion
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string msg;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string chat_id;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string uac_build_id;

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4638C74", Offset = "0x4634C74", VA = "0x4638C74")]
			public SendLogMsgRequestData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000022")]
		[Skip]
		public class SendLogMsgResultData
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int code;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4638C7C", Offset = "0x4634C7C", VA = "0x4638C7C")]
			public SendLogMsgResultData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000023")]
		[Skip]
		public class SendLogFileRequestData : DebugSystemVersion
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string all_log_text;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string chat_id;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string uac_build_id;

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4638C84", Offset = "0x4634C84", VA = "0x4638C84")]
			public SendLogFileRequestData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000024")]
		[Skip]
		public class SendLogFileResultData
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int code;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4638C8C", Offset = "0x4634C8C", VA = "0x4638C8C")]
			public SendLogFileResultData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000025")]
		[Skip]
		public class UploadNameTranslationRequestData
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string uac_build_id;

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4638C94", Offset = "0x4634C94", VA = "0x4638C94")]
			public UploadNameTranslationRequestData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000026")]
		[Skip]
		public class UploadNameTranslationResultData
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int code;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4638C9C", Offset = "0x4634C9C", VA = "0x4638C9C")]
			public UploadNameTranslationResultData()
			{
			}
		}

		[Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class _003CIE_SendLogFile_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SendLogFileRequestData requestData;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> error;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<SendLogFileResultData> success;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000019")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x4639E98", Offset = "0x4635E98", VA = "0x4639E98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009E")]
				[Address(RVA = "0x4639ED8", Offset = "0x4635ED8", VA = "0x4639ED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x46389E8", Offset = "0x46349E8", VA = "0x46389E8")]
			[DebuggerHidden]
			public _003CIE_SendLogFile_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4638CA4", Offset = "0x4634CA4", VA = "0x4638CA4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4638CC0", Offset = "0x4634CC0", VA = "0x4638CC0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4639DE8", Offset = "0x4635DE8", VA = "0x4639DE8")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4639E98", Offset = "0x4635E98", VA = "0x4639E98", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4639EA0", Offset = "0x4635EA0", VA = "0x4639EA0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x4639ED8", Offset = "0x4635ED8", VA = "0x4639ED8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class _003CIE_SendLogMsg_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SendLogMsgRequestData requestData;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string> error;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<SendLogMsgResultData> success;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x1700001B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x463A8C4", Offset = "0x46368C4", VA = "0x463A8C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x463A904", Offset = "0x4636904", VA = "0x463A904", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x46388BC", Offset = "0x46348BC", VA = "0x46388BC")]
			[DebuggerHidden]
			public _003CIE_SendLogMsg_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4639EE0", Offset = "0x4635EE0", VA = "0x4639EE0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4639EFC", Offset = "0x4635EFC", VA = "0x4639EFC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x463A814", Offset = "0x4636814", VA = "0x463A814")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x463A8C4", Offset = "0x46368C4", VA = "0x463A8C4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x463A8CC", Offset = "0x46368CC", VA = "0x463A8CC", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x463A904", Offset = "0x4636904", VA = "0x463A904", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class _003CIE_UploadNameTranslation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> error;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UploadNameTranslationRequestData requestData;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<UploadNameTranslationResultData> success;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x1700001D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x463B428", Offset = "0x4637428", VA = "0x463B428", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700001E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x463B468", Offset = "0x4637468", VA = "0x463B468", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4638B70", Offset = "0x4634B70", VA = "0x4638B70")]
			[DebuggerHidden]
			public _003CIE_UploadNameTranslation_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x463A90C", Offset = "0x463690C", VA = "0x463A90C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x463A928", Offset = "0x4636928", VA = "0x463A928", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x463B378", Offset = "0x4637378", VA = "0x463B378")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x463B428", Offset = "0x4637428", VA = "0x463B428", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x463B430", Offset = "0x4637430", VA = "0x463B430", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x463B468", Offset = "0x4637468", VA = "0x463B468", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000059")]
		private const string HEX_Server = "8D3SCHtmv3+1s1d25jJ5THVHbAN71TygzPDBJRKEyRA=";

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string _sendLogMsgUrl;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string _sendLogFileUrl;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string _uploadNameTranslationUrl;

		[Token(Token = "0x17000018")]
		private static string ServerUrl
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x4638560", Offset = "0x4634560", VA = "0x4638560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4635E40", Offset = "0x4631E40", VA = "0x4635E40")]
		public static string GetCustomBuildID()
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x463864C", Offset = "0x463464C", VA = "0x463864C")]
		public static void SendLogMsg(SendLogMsgRequestData requestData, [Optional] Action<SendLogMsgResultData> success, [Optional] Action<string> error)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4638848", Offset = "0x4634848", VA = "0x4638848")]
		[IteratorStateMachine(typeof(_003CIE_SendLogMsg_003Ed__8))]
		private static IEnumerator IE_SendLogMsg(SendLogMsgRequestData requestData, Action<SendLogMsgResultData> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x46388E4", Offset = "0x46348E4", VA = "0x46388E4")]
		public static void SendLogFile(SendLogFileRequestData requestData, [Optional] Action<SendLogFileResultData> success, [Optional] Action<string> error)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4638974", Offset = "0x4634974", VA = "0x4638974")]
		[IteratorStateMachine(typeof(_003CIE_SendLogFile_003Ed__10))]
		private static IEnumerator IE_SendLogFile(SendLogFileRequestData requestData, Action<SendLogFileResultData> success, Action<string> error)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4638A10", Offset = "0x4634A10", VA = "0x4638A10")]
		public static void UploadNameTranslation(UploadNameTranslationRequestData requestData, [Optional] Action<UploadNameTranslationResultData> success, [Optional] Action<string> error)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4638AFC", Offset = "0x4634AFC", VA = "0x4638AFC")]
		[IteratorStateMachine(typeof(_003CIE_UploadNameTranslation_003Ed__12))]
		private static IEnumerator IE_UploadNameTranslation(UploadNameTranslationRequestData requestData, Action<UploadNameTranslationResultData> success, Action<string> error)
		{
			return null;
		}
	}
}
