using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameModule
{
	[Token(Token = "0x20003D4")]
	public class SeasonIntroAnimation : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003D9")]
		[CompilerGenerated]
		private struct _003CPlayHexFlipAnimation_003Ed__82 : IAsyncStateMachine
		{
			[Token(Token = "0x400270B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400270C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400270D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x400270E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<GameObject> _003CallHexObj_003E5__2;

			[Token(Token = "0x400270F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<HexBehaviour> _003CallHexObjBehaviour_003E5__3;

			[Token(Token = "0x4002710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<float>.Enumerator _003C_003E7__wrap3;

			[Token(Token = "0x4002711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600115E")]
			[Address(RVA = "0x3DB06B4", Offset = "0x3DAC6B4", VA = "0x3DB06B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600115F")]
			[Address(RVA = "0x3DB198C", Offset = "0x3DAD98C", VA = "0x3DB198C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DA")]
		[CompilerGenerated]
		private struct _003CPlayIntroAnimation_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x4002712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001160")]
			[Address(RVA = "0x3DB1998", Offset = "0x3DAD998", VA = "0x3DB1998", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001161")]
			[Address(RVA = "0x3DB2C88", Offset = "0x3DAEC88", VA = "0x3DB2C88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DB")]
		[CompilerGenerated]
		private struct _003CPlayIntroAnimation_003Ed__73 : IAsyncStateMachine
		{
			[Token(Token = "0x4002716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject decorationObj;

			[Token(Token = "0x400271A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001162")]
			[Address(RVA = "0x3DB2C94", Offset = "0x3DAEC94", VA = "0x3DB2C94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001163")]
			[Address(RVA = "0x3DB3098", Offset = "0x3DAF098", VA = "0x3DB3098", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DC")]
		[CompilerGenerated]
		private struct _003CPlayMainTowerFlipAnimation_003Ed__85 : IAsyncStateMachine
		{
			[Token(Token = "0x400271B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400271C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400271D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x400271E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001164")]
			[Address(RVA = "0x3DB30A4", Offset = "0x3DAF0A4", VA = "0x3DB30A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001165")]
			[Address(RVA = "0x3DB418C", Offset = "0x3DB018C", VA = "0x3DB418C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DD")]
		[CompilerGenerated]
		private struct _003CPlayNewPhase1_CameraAndStatueAndMountain_003Ed__77 : IAsyncStateMachine
		{
			[Token(Token = "0x400271F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001166")]
			[Address(RVA = "0x3DB4198", Offset = "0x3DB0198", VA = "0x3DB4198", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001167")]
			[Address(RVA = "0x3DB4878", Offset = "0x3DB0878", VA = "0x3DB4878", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DE")]
		[CompilerGenerated]
		private struct _003CPlayNewPhase2_StatueCloseup_003Ed__78 : IAsyncStateMachine
		{
			[Token(Token = "0x4002723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameObject _003CfadeCanvas_003E5__2;

			[Token(Token = "0x4002727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003CfadeImage_003E5__3;

			[Token(Token = "0x4002728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4002729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001168")]
			[Address(RVA = "0x3DB4884", Offset = "0x3DB0884", VA = "0x3DB4884", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001169")]
			[Address(RVA = "0x3DB4FEC", Offset = "0x3DB0FEC", VA = "0x3DB4FEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003DF")]
		[CompilerGenerated]
		private struct _003CPlayNewPhase3_SwitchToTrophyPosition_003Ed__79 : IAsyncStateMachine
		{
			[Token(Token = "0x400272A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400272B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400272C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x400272D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameObject _003CfadeCanvas_003E5__2;

			[Token(Token = "0x400272E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003CfadeImage_003E5__3;

			[Token(Token = "0x400272F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4002730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600116A")]
			[Address(RVA = "0x3DB4FF8", Offset = "0x3DB0FF8", VA = "0x3DB4FF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600116B")]
			[Address(RVA = "0x3DB588C", Offset = "0x3DB188C", VA = "0x3DB588C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003E0")]
		[CompilerGenerated]
		private struct _003CPlayPhase1_TrophyRise_003Ed__80 : IAsyncStateMachine
		{
			[Token(Token = "0x4002731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600116C")]
			[Address(RVA = "0x3DB5898", Offset = "0x3DB1898", VA = "0x3DB5898", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600116D")]
			[Address(RVA = "0x3DB5F9C", Offset = "0x3DB1F9C", VA = "0x3DB5F9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003E1")]
		[CompilerGenerated]
		private struct _003CPlayPhase2_CameraBackAndStatueRise_003Ed__81 : IAsyncStateMachine
		{
			[Token(Token = "0x4002735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600116E")]
			[Address(RVA = "0x3DB5FA8", Offset = "0x3DB1FA8", VA = "0x3DB5FA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600116F")]
			[Address(RVA = "0x3DB66F8", Offset = "0x3DB26F8", VA = "0x3DB66F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003E2")]
		[CompilerGenerated]
		private struct _003CPlayPhase3_TransitionToOrthographic_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x4002739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400273A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400273B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x400273C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameObject _003CfadeCanvas_003E5__2;

			[Token(Token = "0x400273D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003CfadeImage_003E5__3;

			[Token(Token = "0x400273E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _003Cphase3Pos_003E5__4;

			[Token(Token = "0x400273F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4002740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001170")]
			[Address(RVA = "0x3DB6704", Offset = "0x3DB2704", VA = "0x3DB6704", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001171")]
			[Address(RVA = "0x3DB7298", Offset = "0x3DB3298", VA = "0x3DB7298", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003E3")]
		[CompilerGenerated]
		private struct _003CPlayPhase3_TransitionToOrthographicForNewLogic_003Ed__84 : IAsyncStateMachine
		{
			[Token(Token = "0x4002741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonIntroAnimation _003C_003E4__this;

			[Token(Token = "0x4002744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameObject _003CfadeCanvas_003E5__2;

			[Token(Token = "0x4002745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image _003CfadeImage_003E5__3;

			[Token(Token = "0x4002746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x4002747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001172")]
			[Address(RVA = "0x3DB72A4", Offset = "0x3DB32A4", VA = "0x3DB72A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001173")]
			[Address(RVA = "0x3DB7D18", Offset = "0x3DB3D18", VA = "0x3DB7D18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40026BE")]
		private const string TrophyName = "Trophy";

		[Token(Token = "0x40026BF")]
		private const string LeftStatueName = "Statue_A_L";

		[Token(Token = "0x40026C0")]
		private const string RightStatueName = "Statue_A_R";

		[Token(Token = "0x40026C1")]
		private const string MountainRangeName = "MountainRange";

		[Token(Token = "0x40026C2")]
		private const string TheSceneBelowName = "TheSceneBelow";

		[Token(Token = "0x40026C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 NewPhase1_StartCameraPos;

		[Token(Token = "0x40026C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly Vector3 NewPhase1_StartCameraRot;

		[Token(Token = "0x40026C5")]
		private const float NewPhase1_StartCameraFOV = 60f;

		[Token(Token = "0x40026C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly Vector3 NewPhase1_EndCameraPos;

		[Token(Token = "0x40026C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly Vector3 NewPhase1_EndCameraRot;

		[Token(Token = "0x40026C8")]
		private const float NewPhase1_EndCameraFOV = 60f;

		[Token(Token = "0x40026C9")]
		private const float NewPhase1_Duration = 2f;

		[Token(Token = "0x40026CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Vector3 NewPhase2_CameraPos;

		[Token(Token = "0x40026CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly Vector3 NewPhase2_CameraRot;

		[Token(Token = "0x40026CC")]
		private const float NewPhase2_CameraFOV = 60f;

		[Token(Token = "0x40026CD")]
		private const float NewPhase2_Duration = 0.5f;

		[Token(Token = "0x40026CE")]
		private const float TrophyFallHeight = 15f;

		[Token(Token = "0x40026CF")]
		private const float TrophyFallDuration = 1.5f;

		[Token(Token = "0x40026D0")]
		private const float TrophyRotationAmount = 360f;

		[Token(Token = "0x40026D1")]
		private const float MountainRangeRiseHeight = 10f;

		[Token(Token = "0x40026D2")]
		private const float MountainRangeRiseDuration = 2f;

		[Token(Token = "0x40026D3")]
		private const float TheSceneBelowRiseHeight = 10f;

		[Token(Token = "0x40026D4")]
		private const float TheSceneBelowRiseDuration = 2f;

		[Token(Token = "0x40026D5")]
		private const float NewLogicAdditionalLowerHeight = 8f;

		[Token(Token = "0x40026D6")]
		private const float NewLogicStatueRiseDuration = 3.2f;

		[Token(Token = "0x40026D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly Vector3 Phase1_CameraPos;

		[Token(Token = "0x40026D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly Vector3 Phase1_CameraRot;

		[Token(Token = "0x40026D9")]
		private const float Phase1_CameraFOV = 62.274f;

		[Token(Token = "0x40026DA")]
		private const float Phase1_Duration = 2f;

		[Token(Token = "0x40026DB")]
		private const float TrophyRiseHeight = 5f;

		[Token(Token = "0x40026DC")]
		private const float TrophyFinalOffset = 0.5f;

		[Token(Token = "0x40026DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly Vector3 Phase2_CameraPos;

		[Token(Token = "0x40026DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private static readonly Vector3 Phase2_CameraRot;

		[Token(Token = "0x40026DF")]
		private const float Phase2_CameraFOV = 94.2f;

		[Token(Token = "0x40026E0")]
		private const float Phase2_Duration = 2f;

		[Token(Token = "0x40026E1")]
		private const float StatueRiseHeight = 8f;

		[Token(Token = "0x40026E2")]
		private const float StatueRiseDuration = 2.5f;

		[Token(Token = "0x40026E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly Vector3 Phase3_CameraRot;

		[Token(Token = "0x40026E4")]
		private const float Phase3_CameraSize = 31f;

		[Token(Token = "0x40026E5")]
		private const float Phase3_Duration = 2f;

		[Token(Token = "0x40026E6")]
		private const float CameraTransitionFadeDuration = 0.3f;

		[Token(Token = "0x40026E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool useNewCameraLogic;

		[Token(Token = "0x40026E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trophyTransform;

		[Token(Token = "0x40026E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _leftStatueTransform;

		[Token(Token = "0x40026EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _rightStatueTransform;

		[Token(Token = "0x40026EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _mountainRangeTransform;

		[Token(Token = "0x40026EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _theSceneBelowTransform;

		[Token(Token = "0x40026ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 _trophyTargetPos;

		[Token(Token = "0x40026EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 _leftStatueTargetPos;

		[Token(Token = "0x40026EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 _rightStatueTargetPos;

		[Token(Token = "0x40026F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 _mountainRangeTargetPos;

		[Token(Token = "0x40026F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 _theSceneBelowTargetPos;

		[Token(Token = "0x40026F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Camera _mainCamera;

		[Token(Token = "0x40026F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _cameraTransform;

		[Token(Token = "0x40026F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _isInitialized;

		[Token(Token = "0x40026F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject _decorationObj;

		[Token(Token = "0x40026F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _originalNearClipPlane;

		[Token(Token = "0x40026F7")]
		private const float PerspectiveNearClipPlane = 0.01f;

		[Token(Token = "0x40026F8")]
		private const float OrthographicNearClipPlane = -40f;

		[Token(Token = "0x40026F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject _playerArchitectureRoot;

		[Token(Token = "0x40026FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject _enemyArchitectureRoot;

		[Token(Token = "0x40026FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject _specialHexRoot;

		[Token(Token = "0x40026FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject _spawnTimeProgressUIPool;

		[Token(Token = "0x40026FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GameObject _playerMainTowerHexObj;

		[Token(Token = "0x40026FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HexBehaviour _playerMainTowerHexBehaviour;

		[Token(Token = "0x40026FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject _enemyMainTowerHexObj;

		[Token(Token = "0x4002700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private HexBehaviour _enemyMainTowerHexBehaviour;

		[Token(Token = "0x4002701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<GameObject> _playerMainTowerNearHexUIs;

		[Token(Token = "0x4002702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<GameObject> _enemyMainTowerNearHexUIs;

		[Token(Token = "0x600113B")]
		[Address(RVA = "0x3DADAE4", Offset = "0x3DA9AE4", VA = "0x3DADAE4")]
		private static Vector3 GetPhase3CameraPos()
		{
			return default;
		}

		[Token(Token = "0x600113C")]
		[Address(RVA = "0x3DADB48", Offset = "0x3DA9B48", VA = "0x3DADB48")]
		public bool InitDecorationObjects(GameObject decorationObj)
		{
			return default;
		}

		[Token(Token = "0x600113D")]
		[Address(RVA = "0x3DAE5E0", Offset = "0x3DAA5E0", VA = "0x3DAE5E0")]
		private void FindAndHideArchitectureRoots()
		{
		}

		[Token(Token = "0x600113E")]
		[Address(RVA = "0x3DAE8E8", Offset = "0x3DAA8E8", VA = "0x3DAE8E8")]
		[AsyncStateMachine(typeof(_003CPlayIntroAnimation_003Ed__72))]
		public UniTask PlayIntroAnimation()
		{
			return default;
		}

		[Token(Token = "0x600113F")]
		[Address(RVA = "0x3DAE974", Offset = "0x3DAA974", VA = "0x3DAE974")]
		[AsyncStateMachine(typeof(_003CPlayIntroAnimation_003Ed__73))]
		public UniTask PlayIntroAnimation(GameObject decorationObj)
		{
			return default;
		}

		[Token(Token = "0x6001140")]
		[Address(RVA = "0x3DAE278", Offset = "0x3DAA278", VA = "0x3DAE278")]
		private Transform FindChildRecursive(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6001141")]
		[Address(RVA = "0x3DAEA10", Offset = "0x3DAAA10", VA = "0x3DAEA10")]
		private void InitializeCamera()
		{
		}

		[Token(Token = "0x6001142")]
		[Address(RVA = "0x3DAEB1C", Offset = "0x3DAAB1C", VA = "0x3DAEB1C")]
		private void InitializeCameraForNewLogic()
		{
		}

		[Token(Token = "0x6001143")]
		[Address(RVA = "0x3DAEC28", Offset = "0x3DAAC28", VA = "0x3DAEC28")]
		[AsyncStateMachine(typeof(_003CPlayNewPhase1_CameraAndStatueAndMountain_003Ed__77))]
		private UniTask PlayNewPhase1_CameraAndStatueAndMountain()
		{
			return default;
		}

		[Token(Token = "0x6001144")]
		[Address(RVA = "0x3DAECB4", Offset = "0x3DAACB4", VA = "0x3DAECB4")]
		[AsyncStateMachine(typeof(_003CPlayNewPhase2_StatueCloseup_003Ed__78))]
		private UniTask PlayNewPhase2_StatueCloseup()
		{
			return default;
		}

		[Token(Token = "0x6001145")]
		[Address(RVA = "0x3DAED44", Offset = "0x3DAAD44", VA = "0x3DAED44")]
		[AsyncStateMachine(typeof(_003CPlayNewPhase3_SwitchToTrophyPosition_003Ed__79))]
		private UniTask PlayNewPhase3_SwitchToTrophyPosition()
		{
			return default;
		}

		[Token(Token = "0x6001146")]
		[Address(RVA = "0x3DAEDD4", Offset = "0x3DAADD4", VA = "0x3DAEDD4")]
		[AsyncStateMachine(typeof(_003CPlayPhase1_TrophyRise_003Ed__80))]
		private UniTask PlayPhase1_TrophyRise()
		{
			return default;
		}

		[Token(Token = "0x6001147")]
		[Address(RVA = "0x3DAEE60", Offset = "0x3DAAE60", VA = "0x3DAEE60")]
		[AsyncStateMachine(typeof(_003CPlayPhase2_CameraBackAndStatueRise_003Ed__81))]
		private UniTask PlayPhase2_CameraBackAndStatueRise()
		{
			return default;
		}

		[Token(Token = "0x6001148")]
		[Address(RVA = "0x3DAEEEC", Offset = "0x3DAAEEC", VA = "0x3DAEEEC")]
		[AsyncStateMachine(typeof(_003CPlayHexFlipAnimation_003Ed__82))]
		private UniTask PlayHexFlipAnimation()
		{
			return default;
		}

		[Token(Token = "0x6001149")]
		[Address(RVA = "0x3DAEF80", Offset = "0x3DAAF80", VA = "0x3DAEF80")]
		private void ShowArchitectureRoots()
		{
		}

		[Token(Token = "0x600114A")]
		[Address(RVA = "0x3DAF0BC", Offset = "0x3DAB0BC", VA = "0x3DAF0BC")]
		[AsyncStateMachine(typeof(_003CPlayPhase3_TransitionToOrthographicForNewLogic_003Ed__84))]
		private UniTask PlayPhase3_TransitionToOrthographicForNewLogic()
		{
			return default;
		}

		[Token(Token = "0x600114B")]
		[Address(RVA = "0x3DAF14C", Offset = "0x3DAB14C", VA = "0x3DAF14C")]
		[AsyncStateMachine(typeof(_003CPlayMainTowerFlipAnimation_003Ed__85))]
		private UniTask PlayMainTowerFlipAnimation()
		{
			return default;
		}

		[Token(Token = "0x600114C")]
		[Address(RVA = "0x3DAF1D8", Offset = "0x3DAB1D8", VA = "0x3DAF1D8")]
		private void CollectMainTowerNearHexUIsAtStart()
		{
		}

		[Token(Token = "0x600114D")]
		[Address(RVA = "0x3DAF3B0", Offset = "0x3DAB3B0", VA = "0x3DAF3B0")]
		private void CollectAndHideNearHexUIs(HexBehaviour mainTowerHex, List<GameObject> uiList, bool isEnemyMainTower)
		{
		}

		[Token(Token = "0x600114E")]
		[Address(RVA = "0x3DAFC58", Offset = "0x3DABC58", VA = "0x3DAFC58")]
		private void ShowNearHexUIs(List<GameObject> uiList)
		{
		}

		[Token(Token = "0x600114F")]
		[Address(RVA = "0x3DAFDF4", Offset = "0x3DABDF4", VA = "0x3DAFDF4")]
		[AsyncStateMachine(typeof(_003CPlayPhase3_TransitionToOrthographic_003Ed__89))]
		private UniTask PlayPhase3_TransitionToOrthographic()
		{
			return default;
		}

		[Token(Token = "0x6001150")]
		[Address(RVA = "0x3DAFE88", Offset = "0x3DABE88", VA = "0x3DAFE88")]
		private GameObject CreateFadeCanvas()
		{
			return null;
		}

		[Token(Token = "0x6001151")]
		[Address(RVA = "0x3DB012C", Offset = "0x3DAC12C", VA = "0x3DB012C")]
		public SeasonIntroAnimation()
		{
		}
	}
}
