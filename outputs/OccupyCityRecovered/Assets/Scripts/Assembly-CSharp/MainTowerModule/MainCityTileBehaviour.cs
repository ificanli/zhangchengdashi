using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace MainTowerModule
{
	[Token(Token = "0x20001E4")]
	public class MainCityTileBehaviour : MonoBehaviour
	{
		[Token(Token = "0x20001E7")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x4001C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float _bornScale;

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x418265C", Offset = "0x417E65C", VA = "0x418265C")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x4182664", Offset = "0x417E664", VA = "0x4182664")]
			internal void _003CCreateModel_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20001E8")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			[Token(Token = "0x4001C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GlobalMainCityBuildTalentInfo talentConfig;

			[Token(Token = "0x4001C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TweenCallback _003C_003E9__4;

			[Token(Token = "0x4001C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TweenCallback _003C_003E9__6;

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x4182698", Offset = "0x417E698", VA = "0x4182698")]
			public _003C_003Ec__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x41826A0", Offset = "0x417E6A0", VA = "0x41826A0")]
			internal bool _003CUpdateLockState_003Eb__0(UserTileData x)
			{
				return default;
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x41826C8", Offset = "0x417E6C8", VA = "0x41826C8")]
			internal bool _003CUpdateLockState_003Eb__1(GlobalMainCityBuildTalentInfo x)
			{
				return default;
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x41826F0", Offset = "0x417E6F0", VA = "0x41826F0")]
			internal void _003CUpdateLockState_003Eb__2()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x41827A0", Offset = "0x417E7A0", VA = "0x41827A0")]
			internal void _003CUpdateLockState_003Eb__3()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x41828F0", Offset = "0x417E8F0", VA = "0x41828F0")]
			internal void _003CUpdateLockState_003Eb__4()
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x41829E0", Offset = "0x417E9E0", VA = "0x41829E0")]
			internal void _003CUpdateLockState_003Eb__5()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x4182B30", Offset = "0x417EB30", VA = "0x4182B30")]
			internal void _003CUpdateLockState_003Eb__6()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001EA")]
		[CompilerGenerated]
		private struct _003CCheckChangeLodModel_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isHigh;

			[Token(Token = "0x4001C85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool isFromBattle;

			[Token(Token = "0x4001C86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x4182E88", Offset = "0x417EE88", VA = "0x4182E88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x4183638", Offset = "0x417F638", VA = "0x4183638", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001EB")]
		[CompilerGenerated]
		private struct _003CCheckEvent_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isBattleWin;

			[Token(Token = "0x4001C8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool isFromBattle;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x4183644", Offset = "0x417F644", VA = "0x4183644", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x4183E30", Offset = "0x417FE30", VA = "0x4183E30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001EC")]
		[CompilerGenerated]
		private struct _003CCreatFamilyName_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x4183E3C", Offset = "0x417FE3C", VA = "0x4183E3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x41845F4", Offset = "0x41805F4", VA = "0x41845F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001ED")]
		[CompilerGenerated]
		private struct _003CCreateEnemy_003Ed__36 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isHigh;

			[Token(Token = "0x4001C94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x4184600", Offset = "0x4180600", VA = "0x4184600", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x41852D8", Offset = "0x41812D8", VA = "0x41852D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001EE")]
		[CompilerGenerated]
		private struct _003CCreateModel_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

			[Token(Token = "0x4001C99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x41852E4", Offset = "0x41812E4", VA = "0x41852E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x4185FD0", Offset = "0x4181FD0", VA = "0x4185FD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001EF")]
		[CompilerGenerated]
		private struct _003CHandleOnComplete_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x4185FDC", Offset = "0x4181FDC", VA = "0x4185FDC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x4186660", Offset = "0x4182660", VA = "0x4186660", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F0")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string tileKey;

			[Token(Token = "0x4001CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string tileType;

			[Token(Token = "0x4001CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string buildId;

			[Token(Token = "0x4001CA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string enemyModelId;

			[Token(Token = "0x4001CA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string humanData;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x418666C", Offset = "0x418266C", VA = "0x418666C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x4186E68", Offset = "0x4182E68", VA = "0x4186E68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F1")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalMapInfo tileInfo;

			[Token(Token = "0x4001CAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x4186E74", Offset = "0x4182E74", VA = "0x4186E74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x418727C", Offset = "0x418327C", VA = "0x418727C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F2")]
		[CompilerGenerated]
		private struct _003CScaleAndRemoveBuild_003Ed__58 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool needChangeMat;

			[Token(Token = "0x4001CAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshRenderer _003C_003E7__wrap1;

			[Token(Token = "0x4001CB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x4187288", Offset = "0x4183288", VA = "0x4187288", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x4187838", Offset = "0x4183838", VA = "0x4187838", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F3")]
		[CompilerGenerated]
		private struct _003CShowBattleEvent_003Ed__56 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x4187844", Offset = "0x4183844", VA = "0x4187844", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x4187BDC", Offset = "0x4183BDC", VA = "0x4187BDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F4")]
		[CompilerGenerated]
		private struct _003CShowFamilyName_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x4187BE8", Offset = "0x4183BE8", VA = "0x4187BE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x4187F80", Offset = "0x4183F80", VA = "0x4187F80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F5")]
		[CompilerGenerated]
		private struct _003CTileEventEnd_003Ed__45 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x4187F8C", Offset = "0x4183F8C", VA = "0x4187F8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x4188228", Offset = "0x4184228", VA = "0x4188228", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F6")]
		[CompilerGenerated]
		private struct _003CUpdateAllState_003Ed__46 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserTileData userData;

			[Token(Token = "0x4001CC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshRenderer _003C_003E7__wrap1;

			[Token(Token = "0x4001CC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001CC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x4188234", Offset = "0x4184234", VA = "0x4188234", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x4188FE0", Offset = "0x4184FE0", VA = "0x4188FE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F7")]
		[CompilerGenerated]
		private struct _003CUpdateCostUI_003Ed__49 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x4188FEC", Offset = "0x4184FEC", VA = "0x4188FEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x4189308", Offset = "0x4185308", VA = "0x4189308", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F8")]
		[CompilerGenerated]
		private struct _003CUpdateLockState_003Ed__41 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001CC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainCityTileBehaviour _003C_003E4__this;

			[Token(Token = "0x4001CC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isChinUnLock;

			[Token(Token = "0x4001CCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

			[Token(Token = "0x4001CCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshRenderer _003C_003E7__wrap1;

			[Token(Token = "0x4001CCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001CCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4001CCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x4189314", Offset = "0x4185314", VA = "0x4189314", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x418AB94", Offset = "0x4186B94", VA = "0x418AB94", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tileKey;

		[Token(Token = "0x4001C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UserTileData data;

		[Token(Token = "0x4001C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int _cpNum;

		[Token(Token = "0x4001C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject displayCamera;

		[Token(Token = "0x4001C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject _battleEventGo;

		[Token(Token = "0x4001C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MainCityTileBehaviour leftUpTile;

		[Token(Token = "0x4001C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MainCityTileBehaviour rightUpTile;

		[Token(Token = "0x4001C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MainCityTileBehaviour upTile;

		[Token(Token = "0x4001C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MainCityTileBehaviour downTile;

		[Token(Token = "0x4001C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MainCityTileBehaviour leftDownTile;

		[Token(Token = "0x4001C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MainCityTileBehaviour rightDownTile;

		[Token(Token = "0x4001C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MainCityTileBehaviour> nearTileList;

		[Token(Token = "0x4001C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject buildModel;

		[Token(Token = "0x4001C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string tileType;

		[Token(Token = "0x4001C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform tweenTransform;

		[Token(Token = "0x4001C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string humanType;

		[Token(Token = "0x4001C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string humanNumber;

		[Token(Token = "0x4001C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string buildModelId;

		[Token(Token = "0x4001C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string enemyModelId;

		[Token(Token = "0x4001C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string eventType;

		[Token(Token = "0x4001C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<GameObject> enemys;

		[Token(Token = "0x4001C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Transform enemyHumanPosParent;

		[Token(Token = "0x4001C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform buildPosParent;

		[Token(Token = "0x4001C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Transform familyPosParent;

		[Token(Token = "0x4001C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public E_MainCityTileState tileState;

		[Token(Token = "0x4001C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Transform tileBaseModelTf;

		[Token(Token = "0x4001C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject _uiObj;

		[Token(Token = "0x4001C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GameObject _uiRes;

		[Token(Token = "0x4001C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshPro tmpUI;

		[Token(Token = "0x4001C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _familyNameGameobject;

		[Token(Token = "0x4001C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string modelPath;

		[Token(Token = "0x4001C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string modelHighPath;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x41802F4", Offset = "0x417C2F4", VA = "0x41802F4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__32))]
		public UniTask Init(string tileKey, string tileType, string humanData, List<string> cards, string buildId, string enemyModelId)
		{
			return default;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x41803B0", Offset = "0x417C3B0", VA = "0x41803B0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__33))]
		public UniTask Init(GlobalMapInfo tileInfo)
		{
			return default;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x418044C", Offset = "0x417C44C", VA = "0x418044C")]
		public List<UserHeroCardData> GetNowTileEnemyCardData()
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4180650", Offset = "0x417C650", VA = "0x4180650")]
		public void ClearAllEnemy()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x41807E8", Offset = "0x417C7E8", VA = "0x41807E8")]
		[AsyncStateMachine(typeof(_003CCreateEnemy_003Ed__36))]
		public UniTask CreateEnemy(bool isHigh = false)
		{
			return default;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x4180888", Offset = "0x417C888", VA = "0x4180888")]
		[AsyncStateMachine(typeof(_003CCreateModel_003Ed__37))]
		private UniTask CreateModel()
		{
			return default;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x4180914", Offset = "0x417C914", VA = "0x4180914")]
		public void ChangeModelActive(bool isActive)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4180AAC", Offset = "0x417CAAC", VA = "0x4180AAC")]
		public void ChangeUIObjActive(bool isActive)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4180AC4", Offset = "0x417CAC4", VA = "0x4180AC4")]
		public void GetCP()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x4180EF8", Offset = "0x417CEF8", VA = "0x4180EF8")]
		[AsyncStateMachine(typeof(_003CUpdateLockState_003Ed__41))]
		public void UpdateLockState(bool isChinUnLock = false)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x4180F9C", Offset = "0x417CF9C", VA = "0x4180F9C")]
		[AsyncStateMachine(typeof(_003CHandleOnComplete_003Ed__42))]
		private UniTask HandleOnComplete()
		{
			return default;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x4181028", Offset = "0x417D028", VA = "0x4181028")]
		[AsyncStateMachine(typeof(_003CCheckEvent_003Ed__43))]
		public void CheckEvent(bool isBattleWin = false, bool isFromBattle = false)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x41810D8", Offset = "0x417D0D8", VA = "0x41810D8")]
		[AsyncStateMachine(typeof(_003CCheckChangeLodModel_003Ed__44))]
		public void CheckChangeLodModel(bool isHigh, bool isFromBattle = false)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x4181188", Offset = "0x417D188", VA = "0x4181188")]
		[AsyncStateMachine(typeof(_003CTileEventEnd_003Ed__45))]
		public void TileEventEnd(object parm)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x4181214", Offset = "0x417D214", VA = "0x4181214")]
		[AsyncStateMachine(typeof(_003CUpdateAllState_003Ed__46))]
		public void UpdateAllState(UserTileData userData)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x41812B4", Offset = "0x417D2B4", VA = "0x41812B4")]
		public void UpdateBuild()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x4181400", Offset = "0x417D400", VA = "0x4181400")]
		public void UpdateTileState()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x41814E4", Offset = "0x417D4E4", VA = "0x41814E4")]
		[AsyncStateMachine(typeof(_003CUpdateCostUI_003Ed__49))]
		public void UpdateCostUI([Optional] object parm)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4181570", Offset = "0x417D570", VA = "0x4181570")]
		public void MainCityModelLevel(object o)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4181574", Offset = "0x417D574", VA = "0x4181574")]
		public void PlayUISfx(string talentId, string num)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x41816F4", Offset = "0x417D6F4", VA = "0x41816F4")]
		[AsyncStateMachine(typeof(_003CCreatFamilyName_003Ed__52))]
		public void CreatFamilyName()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x4181784", Offset = "0x417D784", VA = "0x4181784")]
		public void HideFamilyName(object o)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x4181838", Offset = "0x417D838", VA = "0x4181838")]
		public void HideBattleEvent(object o)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x41818EC", Offset = "0x417D8EC", VA = "0x41818EC")]
		[AsyncStateMachine(typeof(_003CShowFamilyName_003Ed__55))]
		public void ShowFamilyName(object o)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x4181978", Offset = "0x417D978", VA = "0x4181978")]
		[AsyncStateMachine(typeof(_003CShowBattleEvent_003Ed__56))]
		public void ShowBattleEvent(object o)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x4181A04", Offset = "0x417DA04", VA = "0x4181A04")]
		public void ScaleAndRemoveEnemy()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x4181BDC", Offset = "0x417DBDC", VA = "0x4181BDC")]
		[AsyncStateMachine(typeof(_003CScaleAndRemoveBuild_003Ed__58))]
		public void ScaleAndRemoveBuild(bool needChangeMat)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x4181C84", Offset = "0x417DC84", VA = "0x4181C84")]
		public void UpdateEventType()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x4181F8C", Offset = "0x417DF8C", VA = "0x4181F8C")]
		public void AddNearTileToList()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x4182348", Offset = "0x417E348", VA = "0x4182348")]
		public void UpgradeLordTitle(object o)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x4182448", Offset = "0x417E448", VA = "0x4182448")]
		public MainCityTileBehaviour()
		{
		}
	}
}
