using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006DB")]
	public class ArtifactStarUpPanel : ArtifactStarUpPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006DC")]
		[CompilerGenerated]
		private struct _003COnButtonExtendStarUpClicked_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40036D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArtifactStarUpPanel _003C_003E4__this;

			[Token(Token = "0x40036D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60024F4")]
			[Address(RVA = "0x3F6336C", Offset = "0x3F5F36C", VA = "0x3F6336C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024F5")]
			[Address(RVA = "0x3F639F4", Offset = "0x3F5F9F4", VA = "0x3F639F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006DD")]
		[CompilerGenerated]
		private struct _003CRefreshIconLightEffect_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40036D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactStarUpPanel _003C_003E4__this;

			[Token(Token = "0x40036DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int rareLevel;

			[Token(Token = "0x40036DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private SkeletonGraphic _003CspineGraphic_003E5__2;

			[Token(Token = "0x40036DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60024F6")]
			[Address(RVA = "0x3F63A00", Offset = "0x3F5FA00", VA = "0x3F63A00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024F7")]
			[Address(RVA = "0x3F64014", Offset = "0x3F60014", VA = "0x3F64014", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006DE")]
		[CompilerGenerated]
		private struct _003CRefreshView_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40036DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactStarUpPanel _003C_003E4__this;

			[Token(Token = "0x40036E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GlobalPropInfo _003CpropInfo_003E5__2;

			[Token(Token = "0x40036E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x40036E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40036E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60024F8")]
			[Address(RVA = "0x3F64020", Offset = "0x3F60020", VA = "0x3F64020", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024F9")]
			[Address(RVA = "0x3F652D0", Offset = "0x3F612D0", VA = "0x3F652D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006DF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40036E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactStarUpPanel _003C_003E4__this;

			[Token(Token = "0x40036E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40036E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60024FA")]
			[Address(RVA = "0x3F652DC", Offset = "0x3F612DC", VA = "0x3F652DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024FB")]
			[Address(RVA = "0x3F659DC", Offset = "0x3F619DC", VA = "0x3F659DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UserPropData _propData;

		[Token(Token = "0x40036D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Tween _iconFloatTween;

		[Token(Token = "0x40036D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 _iconOriginLocalPos;

		[Token(Token = "0x40036D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool _isPlayingStarAnim;

		[Token(Token = "0x40036D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<PropDetailAttrItem> _attrItems;

		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x3F61FE4", Offset = "0x3F5DFE4", VA = "0x3F61FE4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x3F621F4", Offset = "0x3F5E1F4", VA = "0x3F621F4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x3F62290", Offset = "0x3F5E290", VA = "0x3F62290", Slot = "13")]
		protected override void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x3F6231C", Offset = "0x3F5E31C", VA = "0x3F6231C", Slot = "12")]
		protected override void OnButtonExtendBlackBGClicked()
		{
		}

		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x3F623A8", Offset = "0x3F5E3A8", VA = "0x3F623A8", Slot = "14")]
		[AsyncStateMachine(typeof(_003COnButtonExtendStarUpClicked_003Ed__8))]
		protected override void OnButtonExtendStarUpClicked()
		{
		}

		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x3F62434", Offset = "0x3F5E434", VA = "0x3F62434", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x3F6268C", Offset = "0x3F5E68C", VA = "0x3F6268C")]
		private void EventUpdateUI(object o)
		{
		}

		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x3F626B0", Offset = "0x3F5E6B0", VA = "0x3F626B0")]
		[AsyncStateMachine(typeof(_003CRefreshView_003Ed__11))]
		private UniTask RefreshView()
		{
			return default;
		}

		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x3F62744", Offset = "0x3F5E744", VA = "0x3F62744")]
		[AsyncStateMachine(typeof(_003CRefreshIconLightEffect_003Ed__12))]
		private UniTask RefreshIconLightEffect(int rareLevel)
		{
			return default;
		}

		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x3F627E4", Offset = "0x3F5E7E4", VA = "0x3F627E4")]
		private void PlayIconFloatAnimation()
		{
		}

		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x3F62518", Offset = "0x3F5E518", VA = "0x3F62518")]
		private void StopIconFloatAnimation()
		{
		}

		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x3F628A0", Offset = "0x3F5E8A0", VA = "0x3F628A0")]
		private string BuildStarLevelText(int starLevel)
		{
			return null;
		}

		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x3F629E0", Offset = "0x3F5E9E0", VA = "0x3F629E0")]
		private bool TryRebindPropData()
		{
			return default;
		}

		[Token(Token = "0x60024EF")]
		[Address(RVA = "0x3F62AF4", Offset = "0x3F5EAF4", VA = "0x3F62AF4")]
		private void RefreshAttrList()
		{
		}

		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x3F631AC", Offset = "0x3F5F1AC", VA = "0x3F631AC")]
		public ArtifactStarUpPanel()
		{
		}
	}
}
