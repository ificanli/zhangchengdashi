using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using StrConstants;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000AEF")]
	public class SeasonPassEntranceBtn : SeasonPassEntranceBtnComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF0")]
		[CompilerGenerated]
		private struct _003CLoadSeasonIcon_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4005035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SeasonPassEntranceBtn _003C_003E4__this;

			[Token(Token = "0x4005038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CiconPath_003E5__2;

			[Token(Token = "0x4005039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004232")]
			[Address(RVA = "0x41CA924", Offset = "0x41C6924", VA = "0x41CA924", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004233")]
			[Address(RVA = "0x41CAE3C", Offset = "0x41C6E3C", VA = "0x41CAE3C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF1")]
		[CompilerGenerated]
		private struct _003CLoadSeasonPassIconSpine_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x400503A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400503B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400503C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SeasonPassEntranceBtn _003C_003E4__this;

			[Token(Token = "0x400503D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CiconPath_003E5__2;

			[Token(Token = "0x400503E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Spine.Unity.SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004234")]
			[Address(RVA = "0x41CAE48", Offset = "0x41C6E48", VA = "0x41CAE48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004235")]
			[Address(RVA = "0x41CB358", Offset = "0x41C7358", VA = "0x41CB358", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AF2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400503F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassEntranceBtn _003C_003E4__this;

			[Token(Token = "0x4005042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004236")]
			[Address(RVA = "0x41CB364", Offset = "0x41C7364", VA = "0x41CB364", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004237")]
			[Address(RVA = "0x41CB574", Offset = "0x41C7574", VA = "0x41CB574", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("IAP触发入口标识")]
		[IAPPlacementDropdown]
		public string placement;

		[Token(Token = "0x4005034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float updateInter;

		[Token(Token = "0x6004228")]
		[Address(RVA = "0x41C9C04", Offset = "0x41C5C04", VA = "0x41C9C04", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004229")]
		[Address(RVA = "0x41C9DE0", Offset = "0x41C5DE0", VA = "0x41C9DE0")]
		[AsyncStateMachine(typeof(_003CLoadSeasonIcon_003Ed__2))]
		private void LoadSeasonIcon()
		{
		}

		[Token(Token = "0x600422A")]
		[Address(RVA = "0x41C9E70", Offset = "0x41C5E70", VA = "0x41C9E70")]
		[AsyncStateMachine(typeof(_003CLoadSeasonPassIconSpine_003Ed__3))]
		private void LoadSeasonPassIconSpine()
		{
		}

		[Token(Token = "0x600422B")]
		[Address(RVA = "0x41C9F00", Offset = "0x41C5F00", VA = "0x41C9F00")]
		private void UpdateProgress(object value)
		{
		}

		[Token(Token = "0x600422C")]
		[Address(RVA = "0x41CA4B0", Offset = "0x41C64B0", VA = "0x41CA4B0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600422D")]
		[Address(RVA = "0x41CA544", Offset = "0x41C6544", VA = "0x41CA544", Slot = "12")]
		protected override void OnButtonExtendSeasonPassEntranceBtnClicked()
		{
		}

		[Token(Token = "0x600422E")]
		[Address(RVA = "0x41CA61C", Offset = "0x41C661C", VA = "0x41CA61C")]
		private string GetResolvedPlacement()
		{
			return null;
		}

		[Token(Token = "0x600422F")]
		[Address(RVA = "0x41CA6F8", Offset = "0x41C66F8", VA = "0x41CA6F8")]
		public SeasonPassEntranceBtn()
		{
		}
	}
}
