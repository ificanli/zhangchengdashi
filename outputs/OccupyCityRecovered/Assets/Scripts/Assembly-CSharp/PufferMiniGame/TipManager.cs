using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace PufferMiniGame
{
	[Token(Token = "0x2000D4B")]
	public class TipManager : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D4C")]
		[CompilerGenerated]
		private struct _003CShowTip_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4005F00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005F01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x4005F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005259")]
			[Address(RVA = "0x43000CC", Offset = "0x42FC0CC", VA = "0x43000CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600525A")]
			[Address(RVA = "0x4300680", Offset = "0x42FC680", VA = "0x4300680", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TipPanel tipPanel;

		[Token(Token = "0x4005EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TipManager _instance;

		[Token(Token = "0x4005EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _isLoading;

		[Token(Token = "0x4005EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _newestTip;

		[Token(Token = "0x17000E60")]
		public static TipManager Instance
		{
			[Token(Token = "0x6005256")]
			[Address(RVA = "0x42FFE24", Offset = "0x42FBE24", VA = "0x42FFE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005257")]
		[Address(RVA = "0x4300034", Offset = "0x42FC034", VA = "0x4300034")]
		[AsyncStateMachine(typeof(_003CShowTip_003Ed__6))]
		public static void ShowTip(string text)
		{
		}

		[Token(Token = "0x6005258")]
		[Address(RVA = "0x43000C4", Offset = "0x42FC0C4", VA = "0x43000C4")]
		public TipManager()
		{
		}
	}
}
