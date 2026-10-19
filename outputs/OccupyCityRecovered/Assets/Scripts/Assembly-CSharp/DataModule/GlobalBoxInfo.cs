using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000E58")]
	public class GlobalBoxInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E59")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x40063F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40063FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057F9")]
			[Address(RVA = "0x4358FFC", Offset = "0x4354FFC", VA = "0x4358FFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057FA")]
			[Address(RVA = "0x43593E8", Offset = "0x43553E8", VA = "0x43593E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E5A")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__45 : IAsyncStateMachine
		{
			[Token(Token = "0x40063FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40063FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalBoxInfo _003C_003E4__this;

			[Token(Token = "0x40063FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057FB")]
			[Address(RVA = "0x4359440", Offset = "0x4355440", VA = "0x4359440", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057FC")]
			[Address(RVA = "0x4359D8C", Offset = "0x4355D8C", VA = "0x4359D8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E5B")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x40063FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalBoxInfo _003C_003E4__this;

			[Token(Token = "0x4006402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057FD")]
			[Address(RVA = "0x4359DE4", Offset = "0x4355DE4", VA = "0x4359DE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057FE")]
			[Address(RVA = "0x435A1F4", Offset = "0x43561F4", VA = "0x435A1F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E5C")]
		[CompilerGenerated]
		private struct _003CGetTypeIcon_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x4006403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalBoxInfo _003C_003E4__this;

			[Token(Token = "0x4006406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057FF")]
			[Address(RVA = "0x435A24C", Offset = "0x435624C", VA = "0x435A24C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005800")]
			[Address(RVA = "0x435A65C", Offset = "0x435665C", VA = "0x435A65C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40063E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x40063E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string boxName;

		[Token(Token = "0x40063E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string unLockTime;

		[Token(Token = "0x40063E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string boxDiamondRewardRange;

		[Token(Token = "0x40063E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string boxCardRewardRange;

		[Token(Token = "0x40063E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string boxCardNumCofig;

		[Token(Token = "0x40063E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string cardBTestGetNewCardObbCofig;

		[Token(Token = "0x40063E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string SpinePath;

		[Token(Token = "0x40063EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string CloseSpinePath;

		[Token(Token = "0x40063EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string name;

		[Token(Token = "0x40063EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string type;

		[Token(Token = "0x40063ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string iconPath;

		[Token(Token = "0x40063EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string defaultValue;

		[Token(Token = "0x40063EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string rareLevel;

		[Token(Token = "0x40063F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string iconBGPath;

		[Token(Token = "0x40063F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string iconEffectPath;

		[Token(Token = "0x40063F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string localizationKey;

		[Token(Token = "0x40063F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string des;

		[Token(Token = "0x40063F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool hadGetRareLevel;

		[Token(Token = "0x40063F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private RareLevel _rareLevel;

		[Token(Token = "0x17000EF8")]
		public string Id
		{
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0x4358BC0", Offset = "0x4354BC0", VA = "0x4358BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF9")]
		public float IconScale
		{
			[Token(Token = "0x60057E7")]
			[Address(RVA = "0x4358BC8", Offset = "0x4354BC8", VA = "0x4358BC8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EFA")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x60057E8")]
			[Address(RVA = "0x4358BD0", Offset = "0x4354BD0", VA = "0x4358BD0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EFB")]
		public string Name
		{
			[Token(Token = "0x60057E9")]
			[Address(RVA = "0x4358BDC", Offset = "0x4354BDC", VA = "0x4358BDC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFC")]
		public string Des
		{
			[Token(Token = "0x60057EA")]
			[Address(RVA = "0x4358BE4", Offset = "0x4354BE4", VA = "0x4358BE4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFD")]
		public string Explain
		{
			[Token(Token = "0x60057EB")]
			[Address(RVA = "0x4358BEC", Offset = "0x4354BEC", VA = "0x4358BEC", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFE")]
		public string RewardClass
		{
			[Token(Token = "0x60057EC")]
			[Address(RVA = "0x4358BF4", Offset = "0x4354BF4", VA = "0x4358BF4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFF")]
		public string UseClass
		{
			[Token(Token = "0x60057ED")]
			[Address(RVA = "0x4358C34", Offset = "0x4354C34", VA = "0x4358C34", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F00")]
		public int RareLevel
		{
			[Token(Token = "0x60057EE")]
			[Address(RVA = "0x4358C3C", Offset = "0x4354C3C", VA = "0x4358C3C", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F01")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x60057EF")]
			[Address(RVA = "0x4358C84", Offset = "0x4354C84", VA = "0x4358C84", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F02")]
		public bool ShowBGImage
		{
			[Token(Token = "0x60057F5")]
			[Address(RVA = "0x4358FDC", Offset = "0x4354FDC", VA = "0x4358FDC", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F03")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x60057F6")]
			[Address(RVA = "0x4358FE4", Offset = "0x4354FE4", VA = "0x4358FE4", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F04")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x60057F7")]
			[Address(RVA = "0x4358FEC", Offset = "0x4354FEC", VA = "0x4358FEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x4358B30", Offset = "0x4354B30", VA = "0x4358B30", Slot = "21")]
		public virtual RareLevel GetRareLevel()
		{
			return default;
		}

		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x4358C8C", Offset = "0x4354C8C", VA = "0x4358C8C", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__43))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057F1")]
		[Address(RVA = "0x4358D60", Offset = "0x4354D60", VA = "0x4358D60", Slot = "15")]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x4358D6C", Offset = "0x4354D6C", VA = "0x4358D6C", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__45))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x4358E40", Offset = "0x4354E40", VA = "0x4358E40", Slot = "17")]
		[AsyncStateMachine(typeof(_003CGetTypeIcon_003Ed__46))]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x4358F14", Offset = "0x4354F14", VA = "0x4358F14", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__47))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x4358FF4", Offset = "0x4354FF4", VA = "0x4358FF4")]
		public GlobalBoxInfo()
		{
		}
	}
}
