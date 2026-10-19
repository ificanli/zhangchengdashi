using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000A5C")]
	public class MysteryAdventureUiAssets
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A5D")]
		[CompilerGenerated]
		private struct _003CLoadAsync_003Ed__102 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<MysteryAdventureUiAssets> _003C_003Et__builder;

			[Token(Token = "0x4004CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(Sprite, Sprite, Sprite)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E4E")]
			[Address(RVA = "0x416B238", Offset = "0x4167238", VA = "0x416B238", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E4F")]
			[Address(RVA = "0x416B808", Offset = "0x4167808", VA = "0x416B808", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A5E")]
		[CompilerGenerated]
		private struct _003CLoadSprite_003Ed__104 : IAsyncStateMachine
		{
			[Token(Token = "0x4004CC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004CC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4004CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x4004CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003E50")]
			[Address(RVA = "0x416B860", Offset = "0x4167860", VA = "0x416B860", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003E51")]
			[Address(RVA = "0x416BD34", Offset = "0x4167D34", VA = "0x416BD34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x17000957")]
		public Sprite PanelBg
		{
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x416AE8C", Offset = "0x4166E8C", VA = "0x416AE8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x416AE94", Offset = "0x4166E94", VA = "0x416AE94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000958")]
		public Sprite ProgressPanelBg
		{
			[Token(Token = "0x6003E19")]
			[Address(RVA = "0x416AE9C", Offset = "0x4166E9C", VA = "0x416AE9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E1A")]
			[Address(RVA = "0x416AEA4", Offset = "0x4166EA4", VA = "0x416AEA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000959")]
		public Sprite FooterBg
		{
			[Token(Token = "0x6003E1B")]
			[Address(RVA = "0x416AEAC", Offset = "0x4166EAC", VA = "0x416AEAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E1C")]
			[Address(RVA = "0x416AEB4", Offset = "0x4166EB4", VA = "0x416AEB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095A")]
		public Sprite RollButtonBg
		{
			[Token(Token = "0x6003E1D")]
			[Address(RVA = "0x416AEBC", Offset = "0x4166EBC", VA = "0x416AEBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E1E")]
			[Address(RVA = "0x416AEC4", Offset = "0x4166EC4", VA = "0x416AEC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095B")]
		public Sprite RollButtonCircle
		{
			[Token(Token = "0x6003E1F")]
			[Address(RVA = "0x416AECC", Offset = "0x4166ECC", VA = "0x416AECC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x416AED4", Offset = "0x4166ED4", VA = "0x416AED4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095C")]
		public Sprite LapRewardRibbon
		{
			[Token(Token = "0x6003E21")]
			[Address(RVA = "0x416AEDC", Offset = "0x4166EDC", VA = "0x416AEDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x416AEE4", Offset = "0x4166EE4", VA = "0x416AEE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095D")]
		public Sprite LevelBarBg
		{
			[Token(Token = "0x6003E23")]
			[Address(RVA = "0x416AEEC", Offset = "0x4166EEC", VA = "0x416AEEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x416AEF4", Offset = "0x4166EF4", VA = "0x416AEF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095E")]
		public Sprite BoardBg
		{
			[Token(Token = "0x6003E25")]
			[Address(RVA = "0x416AEFC", Offset = "0x4166EFC", VA = "0x416AEFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E26")]
			[Address(RVA = "0x416AF04", Offset = "0x4166F04", VA = "0x416AF04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700095F")]
		public Sprite DailyTaskIcon
		{
			[Token(Token = "0x6003E27")]
			[Address(RVA = "0x416AF0C", Offset = "0x4166F0C", VA = "0x416AF0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E28")]
			[Address(RVA = "0x416AF14", Offset = "0x4166F14", VA = "0x416AF14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000960")]
		public Sprite DailyGiftIcon
		{
			[Token(Token = "0x6003E29")]
			[Address(RVA = "0x416AF1C", Offset = "0x4166F1C", VA = "0x416AF1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E2A")]
			[Address(RVA = "0x416AF24", Offset = "0x4166F24", VA = "0x416AF24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000961")]
		public Sprite PlayerRole
		{
			[Token(Token = "0x6003E2B")]
			[Address(RVA = "0x416AF2C", Offset = "0x4166F2C", VA = "0x416AF2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E2C")]
			[Address(RVA = "0x416AF34", Offset = "0x4166F34", VA = "0x416AF34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000962")]
		public Sprite PlayerRoleFront
		{
			[Token(Token = "0x6003E2D")]
			[Address(RVA = "0x416AF3C", Offset = "0x4166F3C", VA = "0x416AF3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000963")]
		public Sprite PlayerRoleBack
		{
			[Token(Token = "0x6003E2E")]
			[Address(RVA = "0x416AF44", Offset = "0x4166F44", VA = "0x416AF44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E2F")]
			[Address(RVA = "0x416AF4C", Offset = "0x4166F4C", VA = "0x416AF4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000964")]
		public Sprite InfoButton
		{
			[Token(Token = "0x6003E30")]
			[Address(RVA = "0x416AF54", Offset = "0x4166F54", VA = "0x416AF54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E31")]
			[Address(RVA = "0x416AF5C", Offset = "0x4166F5C", VA = "0x416AF5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000965")]
		public Sprite ProgressFill
		{
			[Token(Token = "0x6003E32")]
			[Address(RVA = "0x416AF64", Offset = "0x4166F64", VA = "0x416AF64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E33")]
			[Address(RVA = "0x416AF6C", Offset = "0x4166F6C", VA = "0x416AF6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000966")]
		public Sprite CoinIcon
		{
			[Token(Token = "0x6003E34")]
			[Address(RVA = "0x416AF74", Offset = "0x4166F74", VA = "0x416AF74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E35")]
			[Address(RVA = "0x416AF7C", Offset = "0x4166F7C", VA = "0x416AF7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000967")]
		public Sprite WoodIcon
		{
			[Token(Token = "0x6003E36")]
			[Address(RVA = "0x416AF84", Offset = "0x4166F84", VA = "0x416AF84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E37")]
			[Address(RVA = "0x416AF8C", Offset = "0x4166F8C", VA = "0x416AF8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000968")]
		public Sprite DiamondIcon
		{
			[Token(Token = "0x6003E38")]
			[Address(RVA = "0x416AF94", Offset = "0x4166F94", VA = "0x416AF94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E39")]
			[Address(RVA = "0x416AF9C", Offset = "0x4166F9C", VA = "0x416AF9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000969")]
		public Sprite ChessboardIcon01
		{
			[Token(Token = "0x6003E3A")]
			[Address(RVA = "0x416AFA4", Offset = "0x4166FA4", VA = "0x416AFA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3B")]
			[Address(RVA = "0x416AFAC", Offset = "0x4166FAC", VA = "0x416AFAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096A")]
		public Sprite ChessboardIcon02
		{
			[Token(Token = "0x6003E3C")]
			[Address(RVA = "0x416AFB4", Offset = "0x4166FB4", VA = "0x416AFB4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3D")]
			[Address(RVA = "0x416AFBC", Offset = "0x4166FBC", VA = "0x416AFBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096B")]
		public Sprite ChessboardIcon03
		{
			[Token(Token = "0x6003E3E")]
			[Address(RVA = "0x416AFC4", Offset = "0x4166FC4", VA = "0x416AFC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3F")]
			[Address(RVA = "0x416AFCC", Offset = "0x4166FCC", VA = "0x416AFCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096C")]
		public Sprite ChessboardIcon04
		{
			[Token(Token = "0x6003E40")]
			[Address(RVA = "0x416AFD4", Offset = "0x4166FD4", VA = "0x416AFD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E41")]
			[Address(RVA = "0x416AFDC", Offset = "0x4166FDC", VA = "0x416AFDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096D")]
		public Sprite ChessboardIcon05
		{
			[Token(Token = "0x6003E42")]
			[Address(RVA = "0x416AFE4", Offset = "0x4166FE4", VA = "0x416AFE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E43")]
			[Address(RVA = "0x416AFEC", Offset = "0x4166FEC", VA = "0x416AFEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096E")]
		public Sprite ChessboardIcon06
		{
			[Token(Token = "0x6003E44")]
			[Address(RVA = "0x416AFF4", Offset = "0x4166FF4", VA = "0x416AFF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E45")]
			[Address(RVA = "0x416AFFC", Offset = "0x4166FFC", VA = "0x416AFFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700096F")]
		public Sprite ChessboardIcon07
		{
			[Token(Token = "0x6003E46")]
			[Address(RVA = "0x416B004", Offset = "0x4167004", VA = "0x416B004")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E47")]
			[Address(RVA = "0x416B00C", Offset = "0x416700C", VA = "0x416B00C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000970")]
		public Sprite ChessboardIcon08
		{
			[Token(Token = "0x6003E48")]
			[Address(RVA = "0x416B014", Offset = "0x4167014", VA = "0x416B014")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E49")]
			[Address(RVA = "0x416B01C", Offset = "0x416701C", VA = "0x416B01C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x416B024", Offset = "0x4167024", VA = "0x416B024")]
		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__102))]
		public static UniTask<MysteryAdventureUiAssets> LoadAsync()
		{
			return default;
		}

		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x416B0EC", Offset = "0x41670EC", VA = "0x416B0EC")]
		public Sprite GetChessboardIcon(int iconIndex)
		{
			return null;
		}

		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x416B15C", Offset = "0x416715C", VA = "0x416B15C")]
		[AsyncStateMachine(typeof(_003CLoadSprite_003Ed__104))]
		private static UniTask<Sprite> LoadSprite(string path)
		{
			return default;
		}

		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x416B230", Offset = "0x4167230", VA = "0x416B230")]
		public MysteryAdventureUiAssets()
		{
		}
	}
}
