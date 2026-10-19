using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000562")]
	public class RareLevelManager : ManagerBase<RareLevelManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000563")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4002F75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002F76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x3EC058C", Offset = "0x3EBC58C", VA = "0x3EC058C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0x3EC0640", Offset = "0x3EBC640", VA = "0x3EC0640", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x3EC01A0", Offset = "0x3EBC1A0", VA = "0x3EC01A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x3EC0220", Offset = "0x3EBC220", VA = "0x3EC0220")]
		public string GetRareName(RareLevel rareLevel)
		{
			return null;
		}

		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x3EC0494", Offset = "0x3EBC494", VA = "0x3EC0494")]
		public Color GetRareColor(RareLevel rareLevel)
		{
			return default;
		}

		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x3EC0544", Offset = "0x3EBC544", VA = "0x3EC0544")]
		public RareLevelManager()
		{
		}
	}
}
