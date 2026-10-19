using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000C3F")]
	public class PropDetailsManager : ManagerBase<PropDetailsManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C41")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x400581E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400581F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropDetailsManager _003C_003E4__this;

			[Token(Token = "0x4005821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004BFC")]
			[Address(RVA = "0x42719B0", Offset = "0x426D9B0", VA = "0x42719B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BFD")]
			[Address(RVA = "0x4271E6C", Offset = "0x426DE6C", VA = "0x4271E6C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400581C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PropDetailsPanel _propDetailsPanel;

		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0x4271264", Offset = "0x426D264", VA = "0x4271264", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x42712F4", Offset = "0x426D2F4", VA = "0x42712F4")]
		public void ShowDetailsFindId(RectTransform rectTransform, string id, GlobalAssetsType type)
		{
		}

		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x4271848", Offset = "0x426D848", VA = "0x4271848")]
		public void ShowDetailsString(RectTransform rectTransform, string name, string des)
		{
		}

		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x4271550", Offset = "0x426D550", VA = "0x4271550")]
		public void ShowDetails(RectTransform rectTransform, IGlobalAssetsInfo assetsInfo)
		{
		}

		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x42718FC", Offset = "0x426D8FC", VA = "0x42718FC")]
		public PropDetailsManager()
		{
		}
	}
}
