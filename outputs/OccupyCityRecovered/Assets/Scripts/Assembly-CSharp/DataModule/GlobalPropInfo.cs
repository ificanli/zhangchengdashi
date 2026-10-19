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
	[Token(Token = "0x2000E74")]
	public class GlobalPropInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E75")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x40064D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40064D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40064D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalPropInfo _003C_003E4__this;

			[Token(Token = "0x40064DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005896")]
			[Address(RVA = "0x4361638", Offset = "0x435D638", VA = "0x4361638", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005897")]
			[Address(RVA = "0x4361F84", Offset = "0x435DF84", VA = "0x4361F84", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E76")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x40064DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40064DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40064DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalPropInfo _003C_003E4__this;

			[Token(Token = "0x40064DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005898")]
			[Address(RVA = "0x4363890", Offset = "0x435F890", VA = "0x4363890", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005899")]
			[Address(RVA = "0x43641E0", Offset = "0x43601E0", VA = "0x43641E0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E77")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x40064DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40064E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40064E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalPropInfo _003C_003E4__this;

			[Token(Token = "0x40064E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600589A")]
			[Address(RVA = "0x4364238", Offset = "0x4360238", VA = "0x4364238", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600589B")]
			[Address(RVA = "0x4364634", Offset = "0x4360634", VA = "0x4364634", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40064C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string upgradePrice;

		[Token(Token = "0x40064C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string upgradeRequireCount;

		[Token(Token = "0x40064C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string value1;

		[Token(Token = "0x40064C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string value2;

		[Token(Token = "0x40064C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string coolDown;

		[Token(Token = "0x40064C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string continueTime;

		[Token(Token = "0x40064C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string applyObj;

		[Token(Token = "0x40064C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string des;

		[Token(Token = "0x40064C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string isContinueProp;

		[Token(Token = "0x40064CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string explain;

		[Token(Token = "0x40064CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string value1Type;

		[Token(Token = "0x40064CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string value2Type;

		[Token(Token = "0x40064CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string releaseRange;

		[Token(Token = "0x40064CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string name;

		[Token(Token = "0x40064CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string type;

		[Token(Token = "0x40064D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string iconPath;

		[Token(Token = "0x40064D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string defaultValue;

		[Token(Token = "0x40064D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string rareLevel;

		[Token(Token = "0x40064D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string iconBGPath;

		[Token(Token = "0x40064D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string iconEffectPath;

		[Token(Token = "0x40064D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string localizationKey;

		[Token(Token = "0x17000F16")]
		public string Id
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0x43612A0", Offset = "0x435D2A0", VA = "0x43612A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F17")]
		public float IconScale
		{
			[Token(Token = "0x6005884")]
			[Address(RVA = "0x43612A8", Offset = "0x435D2A8", VA = "0x43612A8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F18")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x6005885")]
			[Address(RVA = "0x43612B0", Offset = "0x435D2B0", VA = "0x43612B0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F19")]
		public string Name
		{
			[Token(Token = "0x6005886")]
			[Address(RVA = "0x43612BC", Offset = "0x435D2BC", VA = "0x43612BC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1A")]
		public string Des
		{
			[Token(Token = "0x6005887")]
			[Address(RVA = "0x43612C4", Offset = "0x435D2C4", VA = "0x43612C4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1B")]
		public string Explain
		{
			[Token(Token = "0x6005888")]
			[Address(RVA = "0x43612CC", Offset = "0x435D2CC", VA = "0x43612CC", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1C")]
		public string RewardClass
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0x43612D4", Offset = "0x435D2D4", VA = "0x43612D4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1D")]
		public string UseClass
		{
			[Token(Token = "0x600588A")]
			[Address(RVA = "0x4361314", Offset = "0x435D314", VA = "0x4361314", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1E")]
		public int RareLevel
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0x436131C", Offset = "0x435D31C", VA = "0x436131C", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F1F")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x4361364", Offset = "0x435D364", VA = "0x4361364", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F20")]
		public bool ShowBGImage
		{
			[Token(Token = "0x6005892")]
			[Address(RVA = "0x4361618", Offset = "0x435D618", VA = "0x4361618", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F21")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x6005893")]
			[Address(RVA = "0x4361620", Offset = "0x435D620", VA = "0x4361620", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F22")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x6005894")]
			[Address(RVA = "0x4361628", Offset = "0x435D628", VA = "0x4361628")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600588D")]
		[Address(RVA = "0x436136C", Offset = "0x435D36C", VA = "0x436136C", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__42))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x600588E")]
		[Address(RVA = "0x436144C", Offset = "0x435D44C", VA = "0x436144C", Slot = "15")]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x600588F")]
		[Address(RVA = "0x4361458", Offset = "0x435D458", VA = "0x4361458", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__44))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x6005890")]
		[Address(RVA = "0x4361538", Offset = "0x435D538", VA = "0x4361538", Slot = "17")]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x6005891")]
		[Address(RVA = "0x4361544", Offset = "0x435D544", VA = "0x4361544", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__46))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x6005895")]
		[Address(RVA = "0x4361630", Offset = "0x435D630", VA = "0x4361630")]
		public GlobalPropInfo()
		{
		}
	}
}
