using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006EE")]
	public class ArtifactUseAnimPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006EF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4003753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactUseAnimPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002587")]
			[Address(RVA = "0x3F8607C", Offset = "0x3F8207C", VA = "0x3F8607C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002588")]
			[Address(RVA = "0x3F862F4", Offset = "0x3F822F4", VA = "0x3F862F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400374F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator _animatorArtifactUseAnimPanel;

		[Token(Token = "0x4003750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageRareBG;

		[Token(Token = "0x4003751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageName;

		[Token(Token = "0x4003752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageIcon;

		[Token(Token = "0x170002BF")]
		public Animator AnimatorArtifactUseAnimPanel
		{
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x3F85A5C", Offset = "0x3F81A5C", VA = "0x3F85A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C0")]
		public Image ImageRareBG
		{
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x3F85CC0", Offset = "0x3F81CC0", VA = "0x3F85CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C1")]
		public Image ImageName
		{
			[Token(Token = "0x600257F")]
			[Address(RVA = "0x3F85D88", Offset = "0x3F81D88", VA = "0x3F85D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C2")]
		public Image ImageIcon
		{
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x3F85E50", Offset = "0x3F81E50", VA = "0x3F85E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002581")]
		[Address(RVA = "0x3F85F18", Offset = "0x3F81F18", VA = "0x3F85F18")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002582")]
		[Address(RVA = "0x3F85F1C", Offset = "0x3F81F1C", VA = "0x3F85F1C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002583")]
		[Address(RVA = "0x3F85F24", Offset = "0x3F81F24", VA = "0x3F85F24", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__53))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002584")]
		[Address(RVA = "0x3F85FB8", Offset = "0x3F81FB8", VA = "0x3F85FB8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002585")]
		[Address(RVA = "0x3F8606C", Offset = "0x3F8206C", VA = "0x3F8606C")]
		public ArtifactUseAnimPanelComponents()
		{
		}
	}
}
