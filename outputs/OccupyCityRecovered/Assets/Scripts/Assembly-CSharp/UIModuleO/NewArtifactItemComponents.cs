using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000808")]
	public class NewArtifactItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000809")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__786 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NewArtifactItemComponents _003C_003E4__this;

			[Token(Token = "0x4003DA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002CDF")]
			[Address(RVA = "0x4004F6C", Offset = "0x4000F6C", VA = "0x4004F6C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x40051E4", Offset = "0x40011E4", VA = "0x40051E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageQualityBg;

		[Token(Token = "0x4003D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendQualityBg;

		[Token(Token = "0x4003D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageArtifactIcon;

		[Token(Token = "0x4003D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformUnLock;

		[Token(Token = "0x4003D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageUpgradePrompt;

		[Token(Token = "0x4003DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUILevelText;

		[Token(Token = "0x4003DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ArtifactStarLevelUI _artifactStarLevelUIArtifactStarLevelUI;

		[Token(Token = "0x4003DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgProcess;

		[Token(Token = "0x4003DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4003DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x4003DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformPitchOn;

		[Token(Token = "0x170004F7")]
		public Image ImageQualityBg
		{
			[Token(Token = "0x6002CCD")]
			[Address(RVA = "0x4004528", Offset = "0x4000528", VA = "0x4004528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F8")]
		public ButtonExtend ButtonExtendQualityBg
		{
			[Token(Token = "0x6002CCE")]
			[Address(RVA = "0x4004CCC", Offset = "0x4000CCC", VA = "0x4004CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F9")]
		public Image ImageArtifactIcon
		{
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x4004460", Offset = "0x4000460", VA = "0x4004460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FA")]
		public RectTransform RectTransformUnLock
		{
			[Token(Token = "0x6002CD0")]
			[Address(RVA = "0x40045F0", Offset = "0x40005F0", VA = "0x40045F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FB")]
		public Image ImageUpgradePrompt
		{
			[Token(Token = "0x6002CD1")]
			[Address(RVA = "0x4002DC4", Offset = "0x3FFEDC4", VA = "0x4002DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FC")]
		public TextMeshProUGUI TextMeshProUGUILevelText
		{
			[Token(Token = "0x6002CD2")]
			[Address(RVA = "0x4004780", Offset = "0x4000780", VA = "0x4004780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FD")]
		public ArtifactStarLevelUI ArtifactStarLevelUIArtifactStarLevelUI
		{
			[Token(Token = "0x6002CD3")]
			[Address(RVA = "0x4004848", Offset = "0x4000848", VA = "0x4004848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FE")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x6002CD4")]
			[Address(RVA = "0x4002C34", Offset = "0x3FFEC34", VA = "0x4002C34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FF")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x6002CD5")]
			[Address(RVA = "0x4002CFC", Offset = "0x3FFECFC", VA = "0x4002CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000500")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x6002CD6")]
			[Address(RVA = "0x40046B8", Offset = "0x40006B8", VA = "0x40046B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000501")]
		public RectTransform RectTransformPitchOn
		{
			[Token(Token = "0x6002CD7")]
			[Address(RVA = "0x400317C", Offset = "0x3FFF17C", VA = "0x400317C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x4004D94", Offset = "0x4000D94", VA = "0x4004D94")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x40033C0", Offset = "0x3FFF3C0", VA = "0x40033C0", Slot = "12")]
		protected virtual void OnButtonExtendQualityBgClicked()
		{
		}

		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x4002980", Offset = "0x3FFE980", VA = "0x4002980", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x4004E1C", Offset = "0x4000E1C", VA = "0x4004E1C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__786))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x4004EB0", Offset = "0x4000EB0", VA = "0x4004EB0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x40033AC", Offset = "0x3FFF3AC", VA = "0x40033AC")]
		public NewArtifactItemComponents()
		{
		}
	}
}
