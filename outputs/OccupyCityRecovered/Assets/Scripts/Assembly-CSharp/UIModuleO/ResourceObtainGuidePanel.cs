using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AD4")]
	public class ResourceObtainGuidePanel : ResourceObtainGuidePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD5")]
		[CompilerGenerated]
		private struct _003CRefreshBaseInfo_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceObtainGuidePanel _003C_003E4__this;

			[Token(Token = "0x4004F6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GlobalAssetInfo _003CassetInfo_003E5__2;

			[Token(Token = "0x4004F6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GlobalHeroCardInfo _003CcardInfo_003E5__3;

			[Token(Token = "0x4004F70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalPropInfo _003CpropInfo_003E5__4;

			[Token(Token = "0x4004F71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap4;

			[Token(Token = "0x4004F72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004171")]
			[Address(RVA = "0x41BA5A4", Offset = "0x41B65A4", VA = "0x41BA5A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004172")]
			[Address(RVA = "0x41BC624", Offset = "0x41B8624", VA = "0x41BC624", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD6")]
		[CompilerGenerated]
		private struct _003CRefreshView_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceObtainGuidePanel _003C_003E4__this;

			[Token(Token = "0x4004F76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004173")]
			[Address(RVA = "0x41BC630", Offset = "0x41B8630", VA = "0x41BC630", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004174")]
			[Address(RVA = "0x41BCC34", Offset = "0x41B8C34", VA = "0x41BCC34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AD7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceObtainGuidePanel _003C_003E4__this;

			[Token(Token = "0x4004F7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004F7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004175")]
			[Address(RVA = "0x41BCC40", Offset = "0x41B8C40", VA = "0x41BCC40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004176")]
			[Address(RVA = "0x41BD29C", Offset = "0x41B929C", VA = "0x41BD29C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<ResourceObtainGuideWayItem> _items;

		[Token(Token = "0x4004F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ResourceObtainGuideManager.ResourceGuidePanelData _panelData;

		[Token(Token = "0x6004166")]
		[Address(RVA = "0x41B996C", Offset = "0x41B596C", VA = "0x41B996C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004167")]
		[Address(RVA = "0x41B9A08", Offset = "0x41B5A08", VA = "0x41B9A08", Slot = "12")]
		protected override void OnButtonMaskClicked()
		{
		}

		[Token(Token = "0x6004168")]
		[Address(RVA = "0x41B9A14", Offset = "0x41B5A14", VA = "0x41B9A14", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004169")]
		[Address(RVA = "0x41B9A20", Offset = "0x41B5A20", VA = "0x41B9A20")]
		[AsyncStateMachine(typeof(_003CRefreshView_003Ed__5))]
		private UniTask RefreshView()
		{
			return default;
		}

		[Token(Token = "0x600416A")]
		[Address(RVA = "0x41B9AAC", Offset = "0x41B5AAC", VA = "0x41B9AAC")]
		[AsyncStateMachine(typeof(_003CRefreshBaseInfo_003Ed__6))]
		private UniTask RefreshBaseInfo()
		{
			return default;
		}

		[Token(Token = "0x600416B")]
		[Address(RVA = "0x41B9B40", Offset = "0x41B5B40", VA = "0x41B9B40")]
		private void RefreshWayList()
		{
		}

		[Token(Token = "0x600416C")]
		[Address(RVA = "0x41B9FF8", Offset = "0x41B5FF8", VA = "0x41B9FF8")]
		private ResourceObtainGuideWayItem CreateWayItem()
		{
			return null;
		}

		[Token(Token = "0x600416D")]
		[Address(RVA = "0x41B9DF8", Offset = "0x41B5DF8", VA = "0x41B9DF8")]
		private void ClearWayItems()
		{
		}

		[Token(Token = "0x600416E")]
		[Address(RVA = "0x41BA3BC", Offset = "0x41B63BC", VA = "0x41BA3BC")]
		private void OnWayItemClicked(ResourceObtainGuideManager.ResourceGuideWayData wayData, ResourceObtainGuideManager.ResourceGuidePanelData panelData)
		{
		}

		[Token(Token = "0x600416F")]
		[Address(RVA = "0x41BA488", Offset = "0x41B6488", VA = "0x41BA488")]
		public ResourceObtainGuidePanel()
		{
		}
	}
}
