using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace DataModule.FeishuTempData
{
	[Token(Token = "0x2000EFF")]
	public class FeishuSheetData
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000F00")]
		[CompilerGenerated]
		private struct _003CGetSheetValuesJson_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4006809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400680A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x400680B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sheetToken;

			[Token(Token = "0x400680C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string sheetRange;

			[Token(Token = "0x400680D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x400680E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Creq_003E5__2;

			[Token(Token = "0x400680F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequestAsyncOperation _003Cres_003E5__3;

			[Token(Token = "0x4006810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6005A55")]
			[Address(RVA = "0x4390970", Offset = "0x438C970", VA = "0x4390970", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005A56")]
			[Address(RVA = "0x4390FCC", Offset = "0x438CFCC", VA = "0x4390FCC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000F01")]
		[CompilerGenerated]
		private struct _003CGetSheetValuesJson_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4006811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			[Token(Token = "0x4006813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sheetToken;

			[Token(Token = "0x4006814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CtenantAccessToken_003E5__2;

			[Token(Token = "0x4006815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x4006816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<WorkBookSheetData[]> _003C_003Eu__2;

			[Token(Token = "0x4006817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003Creq_003E5__3;

			[Token(Token = "0x4006818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequestAsyncOperation _003Cres_003E5__4;

			[Token(Token = "0x4006819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x6005A57")]
			[Address(RVA = "0x4391048", Offset = "0x438D048", VA = "0x4391048", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005A58")]
			[Address(RVA = "0x43917EC", Offset = "0x438D7EC", VA = "0x43917EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000F02")]
		[CompilerGenerated]
		private struct _003CGetWorkbookSheetData_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400681A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400681B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<WorkBookSheetData[]> _003C_003Et__builder;

			[Token(Token = "0x400681C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string accessToken;

			[Token(Token = "0x400681D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string workbook;

			[Token(Token = "0x400681E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<string> _003C_003Eu__1;

			[Token(Token = "0x400681F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest _003Creq_003E5__2;

			[Token(Token = "0x4006820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequestAsyncOperation _003Cres_003E5__3;

			[Token(Token = "0x4006821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6005A59")]
			[Address(RVA = "0x4391868", Offset = "0x438D868", VA = "0x4391868", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005A5A")]
			[Address(RVA = "0x4391ED4", Offset = "0x438DED4", VA = "0x4391ED4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x4006804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Data data;

		[Token(Token = "0x4006805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string msg;

		[Token(Token = "0x4006806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string title;

		[Token(Token = "0x4006807")]
		private const string getValuesUrl = "https://open.feishu.cn/open-apis/sheets/v2/spreadsheets/{0}/values/{1}?valueRenderOption=ToString";

		[Token(Token = "0x4006808")]
		private const string getWorkbookInfoUrl = "https://open.feishu.cn/open-apis/sheets/v3/spreadsheets/{0}/sheets/query";

		[Token(Token = "0x6005A50")]
		[Address(RVA = "0x43901C0", Offset = "0x438C1C0", VA = "0x43901C0")]
		public FeishuSheetData()
		{
		}

		[Token(Token = "0x6005A51")]
		[Address(RVA = "0x43901C8", Offset = "0x438C1C8", VA = "0x43901C8")]
		[AsyncStateMachine(typeof(_003CGetSheetValuesJson_003Ed__7))]
		public static Task<string> GetSheetValuesJson(string sheetToken, string sheetRange)
		{
			return null;
		}

		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x43902B4", Offset = "0x438C2B4", VA = "0x43902B4")]
		[AsyncStateMachine(typeof(_003CGetSheetValuesJson_003Ed__8))]
		public static Task<string> GetSheetValuesJson(string sheetToken)
		{
			return null;
		}

		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x43903A0", Offset = "0x438C3A0", VA = "0x43903A0")]
		[AsyncStateMachine(typeof(_003CGetWorkbookSheetData_003Ed__9))]
		public static Task<WorkBookSheetData[]> GetWorkbookSheetData(string workbook, string accessToken = "")
		{
			return null;
		}

		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x439048C", Offset = "0x438C48C", VA = "0x439048C")]
		public static string ValuesToJson(List<List<object>> values)
		{
			return null;
		}
	}
}
