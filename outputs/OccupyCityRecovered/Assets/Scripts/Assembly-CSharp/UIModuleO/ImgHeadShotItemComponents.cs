using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000915")]
	public class ImgHeadShotItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000916")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__66 : IAsyncStateMachine
		{
			[Token(Token = "0x4004458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400445A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ImgHeadShotItemComponents _003C_003E4__this;

			[Token(Token = "0x400445B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003483")]
			[Address(RVA = "0x40AA6DC", Offset = "0x40A66DC", VA = "0x40AA6DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003484")]
			[Address(RVA = "0x40AA954", Offset = "0x40A6954", VA = "0x40AA954", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendImgHeadShotItem;

		[Token(Token = "0x4004456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AvatarItem _avatarItemAvatarItem;

		[Token(Token = "0x4004457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgEff;

		[Token(Token = "0x17000742")]
		public ButtonExtend ButtonExtendImgHeadShotItem
		{
			[Token(Token = "0x6003479")]
			[Address(RVA = "0x40AA3F4", Offset = "0x40A63F4", VA = "0x40AA3F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000743")]
		public AvatarItem AvatarItemAvatarItem
		{
			[Token(Token = "0x600347A")]
			[Address(RVA = "0x40A9F10", Offset = "0x40A5F10", VA = "0x40A9F10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000744")]
		public RectTransform RectTransformImgEff
		{
			[Token(Token = "0x600347B")]
			[Address(RVA = "0x40AA03C", Offset = "0x40A603C", VA = "0x40AA03C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600347C")]
		[Address(RVA = "0x40AA498", Offset = "0x40A6498", VA = "0x40AA498")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600347D")]
		[Address(RVA = "0x40AA520", Offset = "0x40A6520", VA = "0x40AA520", Slot = "12")]
		protected virtual void OnButtonExtendImgHeadShotItemClicked()
		{
		}

		[Token(Token = "0x600347E")]
		[Address(RVA = "0x40A9EC8", Offset = "0x40A5EC8", VA = "0x40A9EC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600347F")]
		[Address(RVA = "0x40AA58C", Offset = "0x40A658C", VA = "0x40AA58C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__66))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003480")]
		[Address(RVA = "0x40AA620", Offset = "0x40A6620", VA = "0x40AA620", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003481")]
		[Address(RVA = "0x40AA380", Offset = "0x40A6380", VA = "0x40AA380")]
		public ImgHeadShotItemComponents()
		{
		}
	}
}
