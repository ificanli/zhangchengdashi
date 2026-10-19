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
	[Token(Token = "0x2000E43")]
	public class GlobalRandomHeroCardInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E44")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4006353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalRandomHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x4006356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057B4")]
			[Address(RVA = "0x4356814", Offset = "0x4352814", VA = "0x4356814", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057B5")]
			[Address(RVA = "0x4356C24", Offset = "0x4352C24", VA = "0x4356C24", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E45")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4006357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4006359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalRandomHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x400635A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057B6")]
			[Address(RVA = "0x4356C7C", Offset = "0x4352C7C", VA = "0x4356C7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057B7")]
			[Address(RVA = "0x43575C8", Offset = "0x43535C8", VA = "0x43575C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E46")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x400635B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400635C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x400635D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalRandomHeroCardInfo _003C_003E4__this;

			[Token(Token = "0x400635E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60057B8")]
			[Address(RVA = "0x4357620", Offset = "0x4353620", VA = "0x4357620", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057B9")]
			[Address(RVA = "0x4357A30", Offset = "0x4353A30", VA = "0x4357A30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E47")]
		[CompilerGenerated]
		private struct _003CGetTypeIcon_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x400635F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x60057BA")]
			[Address(RVA = "0x4357A88", Offset = "0x4353A88", VA = "0x4357A88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60057BB")]
			[Address(RVA = "0x4357B70", Offset = "0x4353B70", VA = "0x4357B70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400634A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string randomProbability;

		[Token(Token = "0x400634B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x400634C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string iconPath;

		[Token(Token = "0x400634D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string rareLevel;

		[Token(Token = "0x400634E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string des;

		[Token(Token = "0x400634F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string bgIconPath;

		[Token(Token = "0x4006352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool randomFromOwnedCards;

		[Token(Token = "0x17000EDD")]
		public string Id
		{
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0x43563E8", Offset = "0x43523E8", VA = "0x43563E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EDE")]
		public float IconScale
		{
			[Token(Token = "0x60057A2")]
			[Address(RVA = "0x43563F0", Offset = "0x43523F0", VA = "0x43563F0", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EDF")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x60057A3")]
			[Address(RVA = "0x43563F8", Offset = "0x43523F8", VA = "0x43563F8", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EE0")]
		public string Name
		{
			[Token(Token = "0x60057A4")]
			[Address(RVA = "0x4356404", Offset = "0x4352404", VA = "0x4356404", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE1")]
		public string Des
		{
			[Token(Token = "0x60057A5")]
			[Address(RVA = "0x435640C", Offset = "0x435240C", VA = "0x435640C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE2")]
		public string Explain
		{
			[Token(Token = "0x60057A6")]
			[Address(RVA = "0x4356414", Offset = "0x4352414", VA = "0x4356414", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE3")]
		public string RewardClass
		{
			[Token(Token = "0x60057A7")]
			[Address(RVA = "0x435641C", Offset = "0x435241C", VA = "0x435641C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE4")]
		public string UseClass
		{
			[Token(Token = "0x60057A8")]
			[Address(RVA = "0x435645C", Offset = "0x435245C", VA = "0x435645C", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE5")]
		public int RareLevel
		{
			[Token(Token = "0x60057A9")]
			[Address(RVA = "0x4356464", Offset = "0x4352464", VA = "0x4356464", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EE6")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x60057AA")]
			[Address(RVA = "0x43564AC", Offset = "0x43524AC", VA = "0x43564AC", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EE7")]
		public bool ShowBGImage
		{
			[Token(Token = "0x60057B0")]
			[Address(RVA = "0x43567F4", Offset = "0x43527F4", VA = "0x43567F4", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EE8")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x60057B1")]
			[Address(RVA = "0x43567FC", Offset = "0x43527FC", VA = "0x43567FC", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EE9")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x60057B2")]
			[Address(RVA = "0x4356804", Offset = "0x4352804", VA = "0x4356804")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x43564B4", Offset = "0x43524B4", VA = "0x43564B4", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__28))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x4356588", Offset = "0x4352588", VA = "0x4356588", Slot = "15")]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x4356594", Offset = "0x4352594", VA = "0x4356594", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__30))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x4356668", Offset = "0x4352668", VA = "0x4356668", Slot = "17")]
		[AsyncStateMachine(typeof(_003CGetTypeIcon_003Ed__31))]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x4356720", Offset = "0x4352720", VA = "0x4356720", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__32))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x435680C", Offset = "0x435280C", VA = "0x435680C")]
		public GlobalRandomHeroCardInfo()
		{
		}
	}
}
