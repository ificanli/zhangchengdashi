using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000882")]
	public class FoundEnemyPanel : FoundEnemyPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000884")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x4004074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x4004077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600300F")]
			[Address(RVA = "0x4040A68", Offset = "0x403CA68", VA = "0x4040A68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003010")]
			[Address(RVA = "0x404116C", Offset = "0x403D16C", VA = "0x404116C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000885")]
		[CompilerGenerated]
		private struct _003CCloseBattleBanner_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x4004078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400407A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x400407B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003Cduration_003E5__2;

			[Token(Token = "0x400407C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003011")]
			[Address(RVA = "0x4041178", Offset = "0x403D178", VA = "0x4041178", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003012")]
			[Address(RVA = "0x40417CC", Offset = "0x403D7CC", VA = "0x40417CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000886")]
		[CompilerGenerated]
		private struct _003CCloudsAnima_003Ed__51 : IAsyncStateMachine
		{
			[Token(Token = "0x400407D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400407E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400407F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x4004080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003013")]
			[Address(RVA = "0x40417D8", Offset = "0x403D7D8", VA = "0x40417D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003014")]
			[Address(RVA = "0x4042358", Offset = "0x403E358", VA = "0x4042358", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000887")]
		[CompilerGenerated]
		private struct _003CCountDownAndClosePanel_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4004081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x4004084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003015")]
			[Address(RVA = "0x4042364", Offset = "0x403E364", VA = "0x4042364", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003016")]
			[Address(RVA = "0x4043D34", Offset = "0x403FD34", VA = "0x4043D34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000888")]
		[CompilerGenerated]
		private struct _003CCutDown_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4004085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x4004088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x4004089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003017")]
			[Address(RVA = "0x4043D40", Offset = "0x403FD40", VA = "0x4043D40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003018")]
			[Address(RVA = "0x4044308", Offset = "0x4040308", VA = "0x4044308", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000889")]
		[CompilerGenerated]
		private struct _003CEnemyUpdateUI_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x400408A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400408B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400408C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x400408D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, GlobalPropInfo> _003CpropInfo_003E5__2;

			[Token(Token = "0x400408E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003CdanNum_003E5__3;

			[Token(Token = "0x400408F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Image _003C_003E7__wrap3;

			[Token(Token = "0x4004090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003019")]
			[Address(RVA = "0x4044314", Offset = "0x4040314", VA = "0x4044314", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600301A")]
			[Address(RVA = "0x40451D0", Offset = "0x40411D0", VA = "0x40451D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088A")]
		[CompilerGenerated]
		private struct _003COnCreatMainTowerEnd_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x4004091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x600301B")]
			[Address(RVA = "0x40451DC", Offset = "0x40411DC", VA = "0x40451DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600301C")]
			[Address(RVA = "0x4045348", Offset = "0x4041348", VA = "0x4045348", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088B")]
		[CompilerGenerated]
		private struct _003CPlaySeasonBTestIntroAnimation_003Ed__53 : IAsyncStateMachine
		{
			[Token(Token = "0x4004094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SingleSeasonData _003CcurrentSeasonData_003E5__2;

			[Token(Token = "0x4004097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600301D")]
			[Address(RVA = "0x4045354", Offset = "0x4041354", VA = "0x4045354", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600301E")]
			[Address(RVA = "0x4046080", Offset = "0x4042080", VA = "0x4046080", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088C")]
		[CompilerGenerated]
		private struct _003CPlayerUpdateUI_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4004098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400409A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x400409B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x400409C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600301F")]
			[Address(RVA = "0x404608C", Offset = "0x404208C", VA = "0x404608C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003020")]
			[Address(RVA = "0x4046AB0", Offset = "0x4042AB0", VA = "0x4046AB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088D")]
		[CompilerGenerated]
		private struct _003CPullInAnimation_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x400409D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400409E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400409F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x40040A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003021")]
			[Address(RVA = "0x4046ABC", Offset = "0x4042ABC", VA = "0x4046ABC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003022")]
			[Address(RVA = "0x40471F0", Offset = "0x40431F0", VA = "0x40471F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088E")]
		[CompilerGenerated]
		private struct _003CSetEnemyBlessUI_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40040A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40040A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40040A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x40040A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40040A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003023")]
			[Address(RVA = "0x40471FC", Offset = "0x40431FC", VA = "0x40471FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003024")]
			[Address(RVA = "0x40476DC", Offset = "0x40436DC", VA = "0x40476DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200088F")]
		[CompilerGenerated]
		private struct _003CSetPlayerBlessUI_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40040A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40040A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40040A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x40040A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x40040AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003025")]
			[Address(RVA = "0x40476E8", Offset = "0x40436E8", VA = "0x40476E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003026")]
			[Address(RVA = "0x4047C50", Offset = "0x4043C50", VA = "0x4047C50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000890")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40040AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40040AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40040AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x40040AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003027")]
			[Address(RVA = "0x4047C5C", Offset = "0x4043C5C", VA = "0x4047C5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003028")]
			[Address(RVA = "0x40483D0", Offset = "0x40443D0", VA = "0x40483D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000891")]
		[CompilerGenerated]
		private struct _003CUpdate_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x40040AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40040B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40040B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FoundEnemyPanel _003C_003E4__this;

			[Token(Token = "0x40040B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003029")]
			[Address(RVA = "0x40483DC", Offset = "0x40443DC", VA = "0x40483DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600302A")]
			[Address(RVA = "0x4048DA8", Offset = "0x4044DA8", VA = "0x4048DA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private float _stayTime;

		[Token(Token = "0x4004059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private float _fTime;

		[Token(Token = "0x400405A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private RankItemData _info;

		[Token(Token = "0x400405B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float _angle;

		[Token(Token = "0x400405C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float _radius;

		[Token(Token = "0x400405D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private float _speed;

		[Token(Token = "0x400405E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private RectTransform _circleCenter;

		[Token(Token = "0x400405F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Vector2 _pos;

		[Token(Token = "0x4004060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private Vector2 _loupePos;

		[Token(Token = "0x4004061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private GameObject res;

		[Token(Token = "0x4004062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private GameObject txtResItem;

		[Token(Token = "0x4004063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<GameObject> itemList;

		[Token(Token = "0x4004064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private List<GameObject> tipItemList;

		[Token(Token = "0x4004065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private int enemyBetNum;

		[Token(Token = "0x4004066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private string playerBetNum;

		[Token(Token = "0x4004067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private GameType gameType;

		[Token(Token = "0x4004068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private float zTime;

		[Token(Token = "0x4004069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private bool cloudAniIng;

		[Token(Token = "0x400406A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B9")]
		private bool isCreatMainTowerEnd;

		[Token(Token = "0x400406B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public AnimationCurve animationCurve;

		[Token(Token = "0x400406C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private bool cloudOpening;

		[Token(Token = "0x400406D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private float hTime;

		[Token(Token = "0x400406E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private bool noCarousel;

		[Token(Token = "0x400406F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private float[] nums;

		[Token(Token = "0x4004070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private int index;

		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x403D498", Offset = "0x4039498", VA = "0x403D498", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__16))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x403D528", Offset = "0x4039528", VA = "0x403D528")]
		private void RecordBetNum(object o)
		{
		}

		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x403D558", Offset = "0x4039558", VA = "0x403D558", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__18))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x403D5EC", Offset = "0x40395EC", VA = "0x403D5EC")]
		private void UIInit()
		{
		}

		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x403DA1C", Offset = "0x4039A1C", VA = "0x403DA1C")]
		[AsyncStateMachine(typeof(_003CPlayerUpdateUI_003Ed__20))]
		private void PlayerUpdateUI()
		{
		}

		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x403DAAC", Offset = "0x4039AAC", VA = "0x403DAAC")]
		private void EnemyTopUIUpdate(object o)
		{
		}

		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x403DAD4", Offset = "0x4039AD4", VA = "0x403DAD4")]
		[AsyncStateMachine(typeof(_003CEnemyUpdateUI_003Ed__22))]
		private void EnemyUpdateUI()
		{
		}

		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x403DDE4", Offset = "0x4039DE4", VA = "0x403DDE4")]
		private void SetBetUI()
		{
		}

		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x403E204", Offset = "0x403A204", VA = "0x403E204")]
		private void LoadBanner()
		{
		}

		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x403E29C", Offset = "0x403A29C", VA = "0x403E29C")]
		private void SetPlayerMoraleUI()
		{
		}

		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x403E340", Offset = "0x403A340", VA = "0x403E340")]
		[AsyncStateMachine(typeof(_003CSetPlayerBlessUI_003Ed__26))]
		private void SetPlayerBlessUI()
		{
		}

		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x403DB64", Offset = "0x4039B64", VA = "0x403DB64")]
		private void SetEnemyMoraleUI()
		{
		}

		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x403DB68", Offset = "0x4039B68", VA = "0x403DB68")]
		[AsyncStateMachine(typeof(_003CSetEnemyBlessUI_003Ed__28))]
		private void SetEnemyBlessUI()
		{
		}

		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x403E3D0", Offset = "0x403A3D0", VA = "0x403E3D0")]
		private int ComputePlayerCpNum()
		{
			return default;
		}

		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x403E420", Offset = "0x403A420", VA = "0x403E420")]
		private static void TryGetArtifactConfigValuesForLog(string infoId, int level, int startLevel, out float configValue1, out float configValue2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FoundEnemyPanel.TryGetArtifactConfigValuesForLog RVA=0x403E420 Token=0x6002FE9");
}

		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x403E624", Offset = "0x403A624", VA = "0x403E624")]
		[Conditional("UNITY_EDITOR")]
		private static void LogEnemyBattlePowerConfigBeforeWeighting(BattlePowerSideInput enemyInput, int deckCp, int rawEnemyCp, int playerCp)
		{
		}

		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x403F02C", Offset = "0x403B02C", VA = "0x403F02C")]
		private int ComputeDisplayEnemyCpWeighted(BattlePowerSideInput enemyInput, int deckCp, int rawEnemyCp, int playerCp)
		{
			return default;
		}

		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x403F12C", Offset = "0x403B12C", VA = "0x403F12C")]
		private void SetPlayerCpNum()
		{
		}

		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x403DBF8", Offset = "0x4039BF8", VA = "0x403DBF8")]
		private void SetEnemyCpNum()
		{
		}

		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x403F188", Offset = "0x403B188", VA = "0x403F188")]
		private void SetTip()
		{
		}

		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x403F498", Offset = "0x403B498", VA = "0x403F498")]
		private void InitPageOnePlayerFetterItem()
		{
		}

		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x403DD4C", Offset = "0x4039D4C", VA = "0x403DD4C")]
		private void InitPageOneEnemyFetterItem()
		{
		}

		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x403FA10", Offset = "0x403BA10", VA = "0x403FA10", Slot = "12")]
		protected override void OnButtonExtendRawImageClicked()
		{
		}

		[Token(Token = "0x6002FF2")]
		[Address(RVA = "0x403F530", Offset = "0x403B530", VA = "0x403F530")]
		private void InstantiateFetterItem(Dictionary<CardFettersType, int> cardDic, Dictionary<AtkWayType, int> atkType, RectTransform rect, bool isEnemy)
		{
		}

		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x403FBF4", Offset = "0x403BBF4", VA = "0x403FBF4")]
		private void MatchSuccess(object o)
		{
		}

		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x403FC04", Offset = "0x403BC04", VA = "0x403FC04")]
		[AsyncStateMachine(typeof(_003CUpdate_003Ed__42))]
		private void Update()
		{
		}

		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x403FC90", Offset = "0x403BC90", VA = "0x403FC90")]
		[AsyncStateMachine(typeof(_003CCountDownAndClosePanel_003Ed__44))]
		private void CountDownAndClosePanel()
		{
		}

		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x403FD1C", Offset = "0x403BD1C", VA = "0x403FD1C")]
		[AsyncStateMachine(typeof(_003COnCreatMainTowerEnd_003Ed__46))]
		private void OnCreatMainTowerEnd(object b)
		{
		}

		[Token(Token = "0x6002FF7")]
		[Address(RVA = "0x403FDA8", Offset = "0x403BDA8", VA = "0x403FDA8")]
		[AsyncStateMachine(typeof(_003CCutDown_003Ed__47))]
		private UniTask CutDown()
		{
			return default;
		}

		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x403FE38", Offset = "0x403BE38", VA = "0x403FE38")]
		[ContextMenu("CloudInit")]
		public void CloudInit()
		{
		}

		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x404004C", Offset = "0x403C04C", VA = "0x404004C")]
		[ContextMenu("CloudsAnima")]
		[AsyncStateMachine(typeof(_003CCloudsAnima_003Ed__51))]
		public UniTask CloudsAnima()
		{
			return default;
		}

		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x40400D8", Offset = "0x403C0D8", VA = "0x40400D8")]
		[AsyncStateMachine(typeof(_003CPullInAnimation_003Ed__52))]
		private UniTask PullInAnimation()
		{
			return default;
		}

		[Token(Token = "0x6002FFB")]
		[Address(RVA = "0x4040164", Offset = "0x403C164", VA = "0x4040164")]
		[AsyncStateMachine(typeof(_003CPlaySeasonBTestIntroAnimation_003Ed__53))]
		private UniTask PlaySeasonBTestIntroAnimation()
		{
			return default;
		}

		[Token(Token = "0x6002FFC")]
		[Address(RVA = "0x40401E8", Offset = "0x403C1E8", VA = "0x40401E8")]
		[AsyncStateMachine(typeof(_003CCloseBattleBanner_003Ed__54))]
		public UniTask CloseBattleBanner()
		{
			return default;
		}

		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x4040278", Offset = "0x403C278", VA = "0x4040278")]
		private void HintCarousel()
		{
		}

		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x404033C", Offset = "0x403C33C", VA = "0x404033C", Slot = "14")]
		protected override void OnButtonExtendBtnTipLeftClicked()
		{
		}

		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x40403D8", Offset = "0x403C3D8", VA = "0x40403D8", Slot = "15")]
		protected override void OnButtonExtendBtnTipRightClicked()
		{
		}

		[Token(Token = "0x6003000")]
		[Address(RVA = "0x4040474", Offset = "0x403C474", VA = "0x4040474", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003001")]
		[Address(RVA = "0x40407D0", Offset = "0x403C7D0", VA = "0x40407D0")]
		public FoundEnemyPanel()
		{
		}
	}
}
