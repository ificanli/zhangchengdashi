using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200090D")]
	public class HeadShotDetailPanel : HeadShotDetailPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200090F")]
		[CompilerGenerated]
		private struct _003CHeadShotClick_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4004425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HeadShotDetailPanel _003C_003E4__this;

			[Token(Token = "0x4004428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x600343F")]
			[Address(RVA = "0x40A7364", Offset = "0x40A3364", VA = "0x40A7364", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003440")]
			[Address(RVA = "0x40A7538", Offset = "0x40A3538", VA = "0x40A7538", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000910")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4004429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400442A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400442B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeadShotDetailPanel _003C_003E4__this;

			[Token(Token = "0x400442C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x400442D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400442E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<UnityEngine.Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003441")]
			[Address(RVA = "0x40A7544", Offset = "0x40A3544", VA = "0x40A7544", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003442")]
			[Address(RVA = "0x40A800C", Offset = "0x40A400C", VA = "0x40A800C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400441F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TMP_InputField TextMeshProUGUITxtInputFieldTMP;

		[Token(Token = "0x4004420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<ImgHeadShotItem> _headShotItems;

		[Token(Token = "0x4004421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private string trophyNowNum;

		[Token(Token = "0x4004422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private string danNextTrophyRequireNum;

		[Token(Token = "0x600342E")]
		[Address(RVA = "0x40A5AC8", Offset = "0x40A1AC8", VA = "0x40A5AC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600342F")]
		[Address(RVA = "0x40A5D00", Offset = "0x40A1D00", VA = "0x40A5D00")]
		private void ChangeeBanner(object o)
		{
		}

		[Token(Token = "0x6003430")]
		[Address(RVA = "0x40A5D6C", Offset = "0x40A1D6C", VA = "0x40A5D6C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__6))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003431")]
		[Address(RVA = "0x40A5E14", Offset = "0x40A1E14", VA = "0x40A5E14")]
		private void UpdateBasicDataText()
		{
		}

		[Token(Token = "0x6003432")]
		[Address(RVA = "0x40A6710", Offset = "0x40A2710", VA = "0x40A6710")]
		[AsyncStateMachine(typeof(_003CHeadShotClick_003Ed__8))]
		private void HeadShotClick(object o)
		{
		}

		[Token(Token = "0x6003433")]
		[Address(RVA = "0x40A67AC", Offset = "0x40A27AC", VA = "0x40A67AC", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003434")]
		[Address(RVA = "0x40A67D0", Offset = "0x40A27D0", VA = "0x40A67D0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003435")]
		[Address(RVA = "0x40A67E4", Offset = "0x40A27E4", VA = "0x40A67E4")]
		private void OnNameInputEndEdit(string inputName)
		{
		}

		[Token(Token = "0x6003436")]
		[Address(RVA = "0x40A6994", Offset = "0x40A2994", VA = "0x40A6994", Slot = "14")]
		protected override void OnButtonExtendAvatarItemClicked()
		{
		}

		[Token(Token = "0x6003437")]
		[Address(RVA = "0x40A6E64", Offset = "0x40A2E64", VA = "0x40A6E64", Slot = "16")]
		protected override void OnButtonHeadTipsBgClicked()
		{
		}

		[Token(Token = "0x6003438")]
		[Address(RVA = "0x40A69B4", Offset = "0x40A29B4", VA = "0x40A69B4")]
		private void OpenHead(bool isopen)
		{
		}

		[Token(Token = "0x6003439")]
		[Address(RVA = "0x40A6E84", Offset = "0x40A2E84", VA = "0x40A6E84", Slot = "15")]
		protected override void OnButtonExtendChangeBannerClicked()
		{
		}

		[Token(Token = "0x600343A")]
		[Address(RVA = "0x40A6F70", Offset = "0x40A2F70", VA = "0x40A6F70", Slot = "12")]
		protected override void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x600343B")]
		[Address(RVA = "0x40A6F94", Offset = "0x40A2F94", VA = "0x40A6F94")]
		public HeadShotDetailPanel()
		{
		}
	}
}
