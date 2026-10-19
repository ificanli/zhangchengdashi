using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using QuickTutor;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20005C4")]
	public class SteerManager : ManagerBase<SteerManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C5")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4003111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x3EF097C", Offset = "0x3EEC97C", VA = "0x3EF097C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x3EF0A30", Offset = "0x3EECA30", VA = "0x3EF0A30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform playerMainTower;

		[Token(Token = "0x4003103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform playerGoldMine;

		[Token(Token = "0x4003104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform playerOneStartHex;

		[Token(Token = "0x4003105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform playerDrgonKnightHex;

		[Token(Token = "0x4003106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform mainCitySystem_MainCity;

		[Token(Token = "0x4003107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform mainCitySystem_CanBuyHex;

		[Token(Token = "0x4003108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform playerDefense1;

		[Token(Token = "0x4003109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform playerDefense2;

		[Token(Token = "0x400310A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform playerUnchart;

		[Token(Token = "0x400310B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform playerGodMine1;

		[Token(Token = "0x400310C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform playerGodMine2;

		[Token(Token = "0x400310D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform playerTutor3Unchart1;

		[Token(Token = "0x400310E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playerTutor3Unchart2;

		[Token(Token = "0x400310F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform playerTutor3Defense;

		[Token(Token = "0x4003110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform playerSkeletonGiant;

		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x3EF01F0", Offset = "0x3EEC1F0", VA = "0x3EF01F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x3EF01F4", Offset = "0x3EEC1F4", VA = "0x3EF01F4")]
		public ITutorialPointInfo GetPlayerMainTowerPoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x3EF0260", Offset = "0x3EEC260", VA = "0x3EF0260")]
		public ITutorialPointInfo GetGoldMineHexPoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x3EF02CC", Offset = "0x3EEC2CC", VA = "0x3EF02CC")]
		public ITutorialPointInfo GetGoldMinePoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x3EF0338", Offset = "0x3EEC338", VA = "0x3EF0338")]
		public ITutorialPointInfo GetOneStarHexPoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x3EF03A4", Offset = "0x3EEC3A4", VA = "0x3EF03A4")]
		public ITutorialPointInfo GetOneStarPoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x3EF0410", Offset = "0x3EEC410", VA = "0x3EF0410")]
		public ITutorialPointInfo GetDrgonKnightHexPoint()
		{
			return null;
		}

		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x3EF047C", Offset = "0x3EEC47C", VA = "0x3EF047C")]
		public ITutorialPointInfo MainCitySystem_GetMainCity()
		{
			return null;
		}

		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x3EF04E8", Offset = "0x3EEC4E8", VA = "0x3EF04E8")]
		public ITutorialPointInfo MainCitySystem_CanBuyHex()
		{
			return null;
		}

		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x3EF0554", Offset = "0x3EEC554", VA = "0x3EF0554")]
		public ITutorialPointInfo GetDefense1Point()
		{
			return null;
		}

		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x3EF05C0", Offset = "0x3EEC5C0", VA = "0x3EF05C0")]
		public ITutorialPointInfo GetDefense2Point()
		{
			return null;
		}

		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x3EF062C", Offset = "0x3EEC62C", VA = "0x3EF062C")]
		public ITutorialPointInfo GetGoldeMine1Point()
		{
			return null;
		}

		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x3EF0698", Offset = "0x3EEC698", VA = "0x3EF0698")]
		public ITutorialPointInfo GetUnChartPoint()
		{
			return null;
		}

		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x3EF0704", Offset = "0x3EEC704", VA = "0x3EF0704")]
		public ITutorialPointInfo GetSkeletonGiantPoint()
		{
			return null;
		}

		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x3EF0770", Offset = "0x3EEC770", VA = "0x3EF0770")]
		public ITutorialPointInfo GetTutor3Unchart1Point()
		{
			return null;
		}

		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x3EF07DC", Offset = "0x3EEC7DC", VA = "0x3EF07DC")]
		public ITutorialPointInfo GetTutor3Unchart2Point()
		{
			return null;
		}

		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x3EF0848", Offset = "0x3EEC848", VA = "0x3EF0848")]
		public ITutorialPointInfo GetTutor3DefensePoint()
		{
			return null;
		}

		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x3EF08B4", Offset = "0x3EEC8B4", VA = "0x3EF08B4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__32))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x3EF0934", Offset = "0x3EEC934", VA = "0x3EF0934")]
		public SteerManager()
		{
		}
	}
}
