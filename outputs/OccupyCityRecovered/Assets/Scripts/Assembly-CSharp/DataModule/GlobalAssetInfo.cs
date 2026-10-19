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
	[Token(Token = "0x2000E2F")]
	public class GlobalAssetInfo : GlobalInfoBase, IGlobalAssetsInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E30")]
		[CompilerGenerated]
		private struct _003CGetBg2Icon_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x40062E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40062E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600575D")]
			[Address(RVA = "0x43513CC", Offset = "0x434D3CC", VA = "0x43513CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600575E")]
			[Address(RVA = "0x43517DC", Offset = "0x434D7DC", VA = "0x43517DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E31")]
		[CompilerGenerated]
		private struct _003CGetBgIcon_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x40062E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40062EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600575F")]
			[Address(RVA = "0x4351834", Offset = "0x434D834", VA = "0x4351834", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005760")]
			[Address(RVA = "0x4352334", Offset = "0x434E334", VA = "0x4352334", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E32")]
		[CompilerGenerated]
		private struct _003CGetDefaultIconSpine_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x40062EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<SkeletonDataAsset> _003C_003Et__builder;

			[Token(Token = "0x40062EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005761")]
			[Address(RVA = "0x435238C", Offset = "0x434E38C", VA = "0x435238C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005762")]
			[Address(RVA = "0x435279C", Offset = "0x434E79C", VA = "0x435279C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E33")]
		[CompilerGenerated]
		private struct _003CGetDefaultIconSprite_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x40062F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40062F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005763")]
			[Address(RVA = "0x43527F4", Offset = "0x434E7F4", VA = "0x43527F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005764")]
			[Address(RVA = "0x4352C04", Offset = "0x434EC04", VA = "0x4352C04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E34")]
		[CompilerGenerated]
		private struct _003CGetIconSpine_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x40062F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<SkeletonDataAsset> _003C_003Et__builder;

			[Token(Token = "0x40062F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int level;

			[Token(Token = "0x40062F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005765")]
			[Address(RVA = "0x4352C5C", Offset = "0x434EC5C", VA = "0x4352C5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005766")]
			[Address(RVA = "0x4353260", Offset = "0x434F260", VA = "0x4353260", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E35")]
		[CompilerGenerated]
		private struct _003CGetIconSprite_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x40062F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x40062FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int level;

			[Token(Token = "0x40062FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GlobalAssetInfo _003C_003E4__this;

			[Token(Token = "0x40062FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005767")]
			[Address(RVA = "0x43532B8", Offset = "0x434F2B8", VA = "0x43532B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005768")]
			[Address(RVA = "0x43538BC", Offset = "0x434F8BC", VA = "0x43538BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E36")]
		[CompilerGenerated]
		private struct _003CGetTypeIcon_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x40062FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40062FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x6005769")]
			[Address(RVA = "0x4353914", Offset = "0x434F914", VA = "0x4353914", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600576A")]
			[Address(RVA = "0x43539FC", Offset = "0x434F9FC", VA = "0x43539FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40062D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40062D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x40062DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string iconPath;

		[Token(Token = "0x40062DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string defaultIconPath;

		[Token(Token = "0x40062DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string defaultValue;

		[Token(Token = "0x40062DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string iconBGPath;

		[Token(Token = "0x40062DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string rareLevel;

		[Token(Token = "0x40062DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string iconEffectPath;

		[Token(Token = "0x40062E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string localizationKey;

		[Token(Token = "0x40062E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string des;

		[Token(Token = "0x17000EB7")]
		public string Id
		{
			[Token(Token = "0x6005748")]
			[Address(RVA = "0x4350D18", Offset = "0x434CD18", VA = "0x4350D18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EB8")]
		public float IconScale
		{
			[Token(Token = "0x6005749")]
			[Address(RVA = "0x4350D20", Offset = "0x434CD20", VA = "0x4350D20", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EB9")]
		public Vector2 IconArchPosition
		{
			[Token(Token = "0x600574A")]
			[Address(RVA = "0x4350D28", Offset = "0x434CD28", VA = "0x4350D28", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EBA")]
		public string Name
		{
			[Token(Token = "0x600574B")]
			[Address(RVA = "0x4350D34", Offset = "0x434CD34", VA = "0x4350D34", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EBB")]
		public string Des
		{
			[Token(Token = "0x600574C")]
			[Address(RVA = "0x4350D3C", Offset = "0x434CD3C", VA = "0x4350D3C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EBC")]
		public string Explain
		{
			[Token(Token = "0x600574D")]
			[Address(RVA = "0x4350D44", Offset = "0x434CD44", VA = "0x4350D44", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EBD")]
		public string RewardClass
		{
			[Token(Token = "0x600574E")]
			[Address(RVA = "0x4350D4C", Offset = "0x434CD4C", VA = "0x4350D4C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EBE")]
		public string UseClass
		{
			[Token(Token = "0x600574F")]
			[Address(RVA = "0x4350D8C", Offset = "0x434CD8C", VA = "0x4350D8C", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EBF")]
		public int RareLevel
		{
			[Token(Token = "0x6005750")]
			[Address(RVA = "0x4350D94", Offset = "0x434CD94", VA = "0x4350D94", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EC0")]
		public GlobalAssetsType Type
		{
			[Token(Token = "0x6005751")]
			[Address(RVA = "0x4350DDC", Offset = "0x434CDDC", VA = "0x4350DDC", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EC1")]
		public bool ShowBGImage
		{
			[Token(Token = "0x6005759")]
			[Address(RVA = "0x43513AC", Offset = "0x434D3AC", VA = "0x43513AC", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EC2")]
		public bool ShowTypeImage
		{
			[Token(Token = "0x600575A")]
			[Address(RVA = "0x43513B4", Offset = "0x434D3B4", VA = "0x43513B4", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EC3")]
		public bool ShowBG2Image
		{
			[Token(Token = "0x600575B")]
			[Address(RVA = "0x43513BC", Offset = "0x434D3BC", VA = "0x43513BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005747")]
		[Address(RVA = "0x4350D10", Offset = "0x434CD10", VA = "0x4350D10", Slot = "21")]
		public virtual string GetIconPath(int level = -1)
		{
			return null;
		}

		[Token(Token = "0x6005752")]
		[Address(RVA = "0x4350DE4", Offset = "0x434CDE4", VA = "0x4350DE4", Slot = "14")]
		[AsyncStateMachine(typeof(_003CGetIconSprite_003Ed__33))]
		public UniTask<Sprite> GetIconSprite(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x6005753")]
		[Address(RVA = "0x4350EC4", Offset = "0x434CEC4", VA = "0x4350EC4", Slot = "15")]
		[AsyncStateMachine(typeof(_003CGetIconSpine_003Ed__34))]
		public UniTask<SkeletonDataAsset> GetIconSpine(int level = -1)
		{
			return default;
		}

		[Token(Token = "0x6005754")]
		[Address(RVA = "0x4350FA4", Offset = "0x434CFA4", VA = "0x4350FA4")]
		[AsyncStateMachine(typeof(_003CGetDefaultIconSprite_003Ed__35))]
		private UniTask<Sprite> GetDefaultIconSprite()
		{
			return default;
		}

		[Token(Token = "0x6005755")]
		[Address(RVA = "0x4351078", Offset = "0x434D078", VA = "0x4351078")]
		[AsyncStateMachine(typeof(_003CGetDefaultIconSpine_003Ed__36))]
		private UniTask<SkeletonDataAsset> GetDefaultIconSpine()
		{
			return default;
		}

		[Token(Token = "0x6005756")]
		[Address(RVA = "0x435114C", Offset = "0x434D14C", VA = "0x435114C", Slot = "16")]
		[AsyncStateMachine(typeof(_003CGetBgIcon_003Ed__37))]
		public UniTask<Sprite> GetBgIcon()
		{
			return default;
		}

		[Token(Token = "0x6005757")]
		[Address(RVA = "0x4351220", Offset = "0x434D220", VA = "0x4351220", Slot = "17")]
		[AsyncStateMachine(typeof(_003CGetTypeIcon_003Ed__38))]
		public UniTask<Sprite> GetTypeIcon()
		{
			return default;
		}

		[Token(Token = "0x6005758")]
		[Address(RVA = "0x43512D8", Offset = "0x434D2D8", VA = "0x43512D8", Slot = "18")]
		[AsyncStateMachine(typeof(_003CGetBg2Icon_003Ed__39))]
		public UniTask<Sprite> GetBg2Icon()
		{
			return default;
		}

		[Token(Token = "0x600575C")]
		[Address(RVA = "0x43513C4", Offset = "0x434D3C4", VA = "0x43513C4")]
		public GlobalAssetInfo()
		{
		}
	}
}
