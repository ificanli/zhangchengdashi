using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008C8")]
	public class ImgEmojPropComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008C9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x400428E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400428F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ImgEmojPropComponents _003C_003E4__this;

			[Token(Token = "0x4004291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003255")]
			[Address(RVA = "0x406E0D8", Offset = "0x406A0D8", VA = "0x406E0D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003256")]
			[Address(RVA = "0x406E350", Offset = "0x406A350", VA = "0x406E350", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformImgEmojProp;

		[Token(Token = "0x400428A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgEmojProp;

		[Token(Token = "0x400428B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SkeletonGraphic _skeletonGraphicEmojiSpine;

		[Token(Token = "0x400428C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgPropIcon;

		[Token(Token = "0x400428D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgPropIcon;

		[Token(Token = "0x17000693")]
		public RectTransform RectTransformImgEmojProp
		{
			[Token(Token = "0x600324A")]
			[Address(RVA = "0x406D86C", Offset = "0x406986C", VA = "0x406D86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000694")]
		public Image ImageImgEmojProp
		{
			[Token(Token = "0x600324B")]
			[Address(RVA = "0x406D7C8", Offset = "0x40697C8", VA = "0x406D7C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000695")]
		public SkeletonGraphic SkeletonGraphicEmojiSpine
		{
			[Token(Token = "0x600324C")]
			[Address(RVA = "0x406D638", Offset = "0x4069638", VA = "0x406D638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000696")]
		public RectTransform RectTransformImgPropIcon
		{
			[Token(Token = "0x600324D")]
			[Address(RVA = "0x406D570", Offset = "0x4069570", VA = "0x406D570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000697")]
		public Image ImageImgPropIcon
		{
			[Token(Token = "0x600324E")]
			[Address(RVA = "0x406D700", Offset = "0x4069700", VA = "0x406D700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600324F")]
		[Address(RVA = "0x406DF7C", Offset = "0x4069F7C", VA = "0x406DF7C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003250")]
		[Address(RVA = "0x406DF80", Offset = "0x4069F80", VA = "0x406DF80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003251")]
		[Address(RVA = "0x406DF88", Offset = "0x4069F88", VA = "0x406DF88", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__32))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003252")]
		[Address(RVA = "0x406E01C", Offset = "0x406A01C", VA = "0x406E01C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003253")]
		[Address(RVA = "0x406CD04", Offset = "0x4068D04", VA = "0x406CD04")]
		public ImgEmojPropComponents()
		{
		}
	}
}
