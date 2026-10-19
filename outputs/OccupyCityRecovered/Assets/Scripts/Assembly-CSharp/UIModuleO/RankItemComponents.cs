using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000AC5")]
	public class RankItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AC6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__125 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RankItemComponents _003C_003E4__this;

			[Token(Token = "0x4004F3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004122")]
			[Address(RVA = "0x41B6440", Offset = "0x41B2440", VA = "0x41B6440", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004123")]
			[Address(RVA = "0x41B66B8", Offset = "0x41B26B8", VA = "0x41B66B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImageLabelBox;

		[Token(Token = "0x4004F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgTrophyIcon;

		[Token(Token = "0x4004F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyNum;

		[Token(Token = "0x4004F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AvatarItem _avatarItemAvatarItem;

		[Token(Token = "0x4004F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4004F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtRankNum;

		[Token(Token = "0x4004F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgRankBg;

		[Token(Token = "0x17000A48")]
		public Image ImageImageLabelBox
		{
			[Token(Token = "0x6004115")]
			[Address(RVA = "0x41B6210", Offset = "0x41B2210", VA = "0x41B6210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A49")]
		public Image ImageImgTrophyIcon
		{
			[Token(Token = "0x6004116")]
			[Address(RVA = "0x41B5E28", Offset = "0x41B1E28", VA = "0x41B5E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A4A")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyNum
		{
			[Token(Token = "0x6004117")]
			[Address(RVA = "0x41B5EF0", Offset = "0x41B1EF0", VA = "0x41B5EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A4B")]
		public AvatarItem AvatarItemAvatarItem
		{
			[Token(Token = "0x6004118")]
			[Address(RVA = "0x41B5FB8", Offset = "0x41B1FB8", VA = "0x41B5FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A4C")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x6004119")]
			[Address(RVA = "0x41B6080", Offset = "0x41B2080", VA = "0x41B6080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A4D")]
		public TextMeshProUGUI TextMeshProUGUITxtRankNum
		{
			[Token(Token = "0x600411A")]
			[Address(RVA = "0x41B4F38", Offset = "0x41B0F38", VA = "0x41B4F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A4E")]
		public Image ImageImgRankBg
		{
			[Token(Token = "0x600411B")]
			[Address(RVA = "0x41B6148", Offset = "0x41B2148", VA = "0x41B6148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600411C")]
		[Address(RVA = "0x41B62E4", Offset = "0x41B22E4", VA = "0x41B62E4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600411D")]
		[Address(RVA = "0x41B62E8", Offset = "0x41B22E8", VA = "0x41B62E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600411E")]
		[Address(RVA = "0x41B62F0", Offset = "0x41B22F0", VA = "0x41B62F0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__125))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600411F")]
		[Address(RVA = "0x41B6384", Offset = "0x41B2384", VA = "0x41B6384", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004120")]
		[Address(RVA = "0x41B5328", Offset = "0x41B1328", VA = "0x41B5328")]
		public RankItemComponents()
		{
		}
	}
}
