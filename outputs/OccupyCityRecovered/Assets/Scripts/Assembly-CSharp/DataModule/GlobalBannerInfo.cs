using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000E52")]
	public class GlobalBannerInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E53")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40063D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x60057DC")]
			[Address(RVA = "0x4358324", Offset = "0x4354324", VA = "0x4358324", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057DD")]
			[Address(RVA = "0x435840C", Offset = "0x435440C", VA = "0x435840C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E54")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40063D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x60057DE")]
			[Address(RVA = "0x4358464", Offset = "0x4354464", VA = "0x4358464", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057DF")]
			[Address(RVA = "0x435854C", Offset = "0x435454C", VA = "0x435854C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E55")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40063D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40063D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalBannerInfo _003C_003E4__this;

			[Token(Token = "0x40063D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057E0")]
			[Address(RVA = "0x43585A4", Offset = "0x43545A4", VA = "0x43585A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057E1")]
			[Address(RVA = "0x4358990", Offset = "0x4354990", VA = "0x4358990", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E56")]
		[CompilerGenerated]
		private struct _003CGetTypeIcon_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x40063D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40063D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x60057E2")]
			[Address(RVA = "0x43589E8", Offset = "0x43549E8", VA = "0x43589E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057E3")]
			[Address(RVA = "0x4358AD0", Offset = "0x4354AD0", VA = "0x4358AD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40063C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string BannerName;

		[Token(Token = "0x40063C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string BannerPath;

		[Token(Token = "0x40063C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string BannerType;

		[Token(Token = "0x40063CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string des;

		[Token(Token = "0x17000EEB")]
		public string Id
		{
			[Token(Token = "0x60057C9")]
			[Address(RVA = "0x4357F6C", Offset = "0x4353F6C", VA = "0x4357F6C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EEC")]
		public float IconScale
		{
			[Token(Token = "0x60057CA")]
			[Address(RVA = "0x4357F74", Offset = "0x4353F74", VA = "0x4357F74", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EED")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x60057CB")]
			[Address(RVA = "0x4357F80", Offset = "0x4353F80", VA = "0x4357F80", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EEE")]
		public string Name
		{
			[Token(Token = "0x60057CC")]
			[Address(RVA = "0x4357F8C", Offset = "0x4353F8C", VA = "0x4357F8C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EEF")]
		public string Des
		{
			[Token(Token = "0x60057CD")]
			[Address(RVA = "0x4357F94", Offset = "0x4353F94", VA = "0x4357F94", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF0")]
		public string Explain
		{
			[Token(Token = "0x60057CE")]
			[Address(RVA = "0x4357F9C", Offset = "0x4353F9C", VA = "0x4357F9C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF1")]
		public string RewardClass
		{
			[Token(Token = "0x60057CF")]
			[Address(RVA = "0x4357FA4", Offset = "0x4353FA4", VA = "0x4357FA4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF2")]
		public string UseClass
		{
			[Token(Token = "0x60057D0")]
			[Address(RVA = "0x4357FE4", Offset = "0x4353FE4", VA = "0x4357FE4", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EF3")]
		public int RareLevel
		{
			[Token(Token = "0x60057D1")]
			[Address(RVA = "0x4357FEC", Offset = "0x4353FEC", VA = "0x4357FEC", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EF4")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x60057D2")]
			[Address(RVA = "0x4357FF4", Offset = "0x4353FF4", VA = "0x4357FF4", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EF5")]
		public bool ShowBGImage
		{
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0x4358304", Offset = "0x4354304", VA = "0x4358304", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EF6")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0x435830C", Offset = "0x435430C", VA = "0x435830C", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EF7")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x60057DA")]
			[Address(RVA = "0x4358314", Offset = "0x4354314", VA = "0x4358314")]
			[CompilerGenerated]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x4357FFC", Offset = "0x4353FFC", VA = "0x4357FFC", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__26))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057D4")]
		[Address(RVA = "0x43580D0", Offset = "0x43540D0", VA = "0x43580D0", Slot = "15")]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057D5")]
		[Address(RVA = "0x43580DC", Offset = "0x43540DC", VA = "0x43580DC", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__28))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x60057D6")]
		[Address(RVA = "0x4358194", Offset = "0x4354194", VA = "0x4358194", Slot = "17")]
		[AsyncStateMachine(typeof(_003CGetTypeIcon_003Ed__29))]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x60057D7")]
		[Address(RVA = "0x435824C", Offset = "0x435424C", VA = "0x435824C", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__30))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x60057DB")]
		[Address(RVA = "0x435831C", Offset = "0x435431C", VA = "0x435831C")]
		public GlobalBannerInfo()
		{
		}
	}
}
