using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x2000445")]
	public class GetNewCardPanelManager : ManagerBase<GetNewCardPanelManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000446")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetNewCardPanelManager _003C_003E4__this;

			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x3E05B14", Offset = "0x3E01B14", VA = "0x3E05B14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014B8")]
			[Address(RVA = "0x3E05DE8", Offset = "0x3E01DE8", VA = "0x3E05DE8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<UserHeroCardData> _configs;

		[Token(Token = "0x4002A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isPanelAniIng;

		[Token(Token = "0x4002A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityAction action;

		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x3E057BC", Offset = "0x3E017BC", VA = "0x3E057BC", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x3E05840", Offset = "0x3E01840", VA = "0x3E05840")]
		private void Update()
		{
		}

		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x3E005F0", Offset = "0x3DFC5F0", VA = "0x3E005F0")]
		public void AddQuene(UserHeroCardData config)
		{
		}

		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x3E059A8", Offset = "0x3E019A8", VA = "0x3E059A8")]
		public void AddAnimationCallBack(UnityAction callBack)
		{
		}

		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x3E05A28", Offset = "0x3E01A28", VA = "0x3E05A28")]
		private void GoldCardPanelBoolChange(object o)
		{
		}

		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x3E05ACC", Offset = "0x3E01ACC", VA = "0x3E05ACC")]
		public GetNewCardPanelManager()
		{
		}
	}
}
