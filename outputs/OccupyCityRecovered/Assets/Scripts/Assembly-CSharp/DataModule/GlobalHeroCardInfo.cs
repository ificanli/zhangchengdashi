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
	[Token(Token = "0x2000E3D")]
	public class GlobalHeroCardInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E3F")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x4006339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400633A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x400633B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x400633C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005799")]
			[Address(RVA = "0x43543E0", Offset = "0x43503E0", VA = "0x43543E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600579A")]
			[Address(RVA = "0x4354D2C", Offset = "0x4350D2C", VA = "0x4354D2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E40")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x400633D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400633E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x400633F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x4006340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600579B")]
			[Address(RVA = "0x4354D84", Offset = "0x4350D84", VA = "0x4354D84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600579C")]
			[Address(RVA = "0x43556D0", Offset = "0x43516D0", VA = "0x43556D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E41")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__50 : IAsyncStateMachine
		{
			[Token(Token = "0x4006341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x4006344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int level;

			[Token(Token = "0x4006345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600579D")]
			[Address(RVA = "0x4355728", Offset = "0x4351728", VA = "0x4355728", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600579E")]
			[Address(RVA = "0x4355B44", Offset = "0x4351B44", VA = "0x4355B44", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E42")]
		[CompilerGenerated]
		private struct _003CGetTypeIcon_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4006346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x4006349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600579F")]
			[Address(RVA = "0x4355B9C", Offset = "0x4351B9C", VA = "0x4355B9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057A0")]
			[Address(RVA = "0x4356390", Offset = "0x4352390", VA = "0x4356390", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string des;

		[Token(Token = "0x400631A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string architecturdID;

		[Token(Token = "0x400631B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string upLevelRequireCount;

		[Token(Token = "0x400631C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string hasSkill;

		[Token(Token = "0x400631D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string skillRequireCount;

		[Token(Token = "0x400631E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string skillDes;

		[Token(Token = "0x400631F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string cardPropertyCofig;

		[Token(Token = "0x4006320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string cardFetters;

		[Token(Token = "0x4006321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string atkType;

		[Token(Token = "0x4006322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string cardTalentConfig;

		[Token(Token = "0x4006323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string towerIconPath;

		[Token(Token = "0x4006324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string showModelPath;

		[Token(Token = "0x4006325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string showModelConfigTalentBTesst;

		[Token(Token = "0x4006326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string cardUnlockLevel;

		[Token(Token = "0x4006327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string showBuildModelPath;

		[Token(Token = "0x4006328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string showModelConfig;

		[Token(Token = "0x4006329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string showBuildModelConfig;

		[Token(Token = "0x400632A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string showUpSfx;

		[Token(Token = "0x400632B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string skillIconPath;

		[Token(Token = "0x400632C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string iconPath;

		[Token(Token = "0x400632D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string name;

		[Token(Token = "0x400632E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string type;

		[Token(Token = "0x400632F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string defaultValue;

		[Token(Token = "0x4006330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string rareLevel;

		[Token(Token = "0x4006331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string iconBGPath;

		[Token(Token = "0x4006332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string iconEffectPath;

		[Token(Token = "0x4006333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string localizationKey;

		[Token(Token = "0x4006336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public string enName;

		[Token(Token = "0x17000ED0")]
		public string Id
		{
			[Token(Token = "0x6005783")]
			[Address(RVA = "0x4353F00", Offset = "0x434FF00", VA = "0x4353F00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED1")]
		public float IconScale
		{
			[Token(Token = "0x6005784")]
			[Address(RVA = "0x4353F08", Offset = "0x434FF08", VA = "0x4353F08", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ED2")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x6005785")]
			[Address(RVA = "0x4353F14", Offset = "0x434FF14", VA = "0x4353F14", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ED3")]
		public string Name
		{
			[Token(Token = "0x6005786")]
			[Address(RVA = "0x4353F20", Offset = "0x434FF20", VA = "0x4353F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED4")]
		public string Des
		{
			[Token(Token = "0x6005787")]
			[Address(RVA = "0x4353F28", Offset = "0x434FF28", VA = "0x4353F28", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED5")]
		public string Explain
		{
			[Token(Token = "0x6005788")]
			[Address(RVA = "0x4353F30", Offset = "0x434FF30", VA = "0x4353F30", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED6")]
		public string RewardClass
		{
			[Token(Token = "0x6005789")]
			[Address(RVA = "0x4353F38", Offset = "0x434FF38", VA = "0x4353F38", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED7")]
		public string UseClass
		{
			[Token(Token = "0x600578A")]
			[Address(RVA = "0x4353F78", Offset = "0x434FF78", VA = "0x4353F78", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED8")]
		public int RareLevel
		{
			[Token(Token = "0x600578B")]
			[Address(RVA = "0x4353F80", Offset = "0x434FF80", VA = "0x4353F80", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ED9")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x600578C")]
			[Address(RVA = "0x4353FC8", Offset = "0x434FFC8", VA = "0x4353FC8", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EDA")]
		public bool ShowBGImage
		{
			[Token(Token = "0x6005792")]
			[Address(RVA = "0x4354338", Offset = "0x4350338", VA = "0x4354338", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EDB")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x6005793")]
			[Address(RVA = "0x4354340", Offset = "0x4350340", VA = "0x4354340", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EDC")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x6005794")]
			[Address(RVA = "0x4354348", Offset = "0x4350348", VA = "0x4354348")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005782")]
		[Address(RVA = "0x4353D50", Offset = "0x434FD50", VA = "0x4353D50")]
		public string GetIconPath(int level = -1)
		{
			return null;
		}

		[Token(Token = "0x600578D")]
		[Address(RVA = "0x4353FD0", Offset = "0x434FFD0", VA = "0x4353FD0", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__50))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x600578E")]
		[Address(RVA = "0x43540B0", Offset = "0x43500B0", VA = "0x43540B0", Slot = "15")]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x600578F")]
		[Address(RVA = "0x43540BC", Offset = "0x43500BC", VA = "0x43540BC", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__52))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x6005790")]
		[Address(RVA = "0x4354190", Offset = "0x4350190", VA = "0x4354190", Slot = "17")]
		[AsyncStateMachine(typeof(_003CGetTypeIcon_003Ed__53))]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x6005791")]
		[Address(RVA = "0x4354264", Offset = "0x4350264", VA = "0x4354264", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__54))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x6005795")]
		[Address(RVA = "0x4354350", Offset = "0x4350350", VA = "0x4354350")]
		public GlobalHeroCardInfo()
		{
		}
	}
}
