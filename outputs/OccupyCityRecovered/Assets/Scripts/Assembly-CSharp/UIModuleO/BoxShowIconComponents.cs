using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000725")]
	public class BoxShowIconComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000726")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x4003890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxShowIconComponents _003C_003E4__this;

			[Token(Token = "0x4003893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x3F9B6D0", Offset = "0x3F976D0", VA = "0x3F9B6D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x3F9B948", Offset = "0x3F97948", VA = "0x3F9B948", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400388D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SkeletonGraphic _skeletonGraphicBox;

		[Token(Token = "0x400388E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageCutDowmBG;

		[Token(Token = "0x400388F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUICutDowmText;

		[Token(Token = "0x17000332")]
		public SkeletonGraphic SkeletonGraphicBox
		{
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x3F9AC6C", Offset = "0x3F96C6C", VA = "0x3F9AC6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000333")]
		public Image ImageCutDowmBG
		{
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x3F9AADC", Offset = "0x3F96ADC", VA = "0x3F9AADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000334")]
		public TextMeshProUGUI TextMeshProUGUICutDowmText
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x3F9ABA4", Offset = "0x3F96BA4", VA = "0x3F9ABA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026F8")]
		[Address(RVA = "0x3F9B608", Offset = "0x3F97608", VA = "0x3F9B608")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x3F9B60C", Offset = "0x3F9760C", VA = "0x3F9B60C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x3F9AD70", Offset = "0x3F96D70", VA = "0x3F9AD70", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__50))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026FB")]
		[Address(RVA = "0x3F9B614", Offset = "0x3F97614", VA = "0x3F9B614", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60026FC")]
		[Address(RVA = "0x3F9AD64", Offset = "0x3F96D64", VA = "0x3F9AD64")]
		public BoxShowIconComponents()
		{
		}
	}
}
