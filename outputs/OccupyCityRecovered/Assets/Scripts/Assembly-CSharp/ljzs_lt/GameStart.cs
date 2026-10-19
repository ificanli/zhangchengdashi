using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameFramework.Base;
using GameFramework.Resources;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Token(Token = "0x2000F44")]
	public class GameStart : IGameStart
	{
		[Token(Token = "0x2000F45")]
		[CompilerGenerated]
		private sealed class _003COpenLoadingUI_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40069A2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40069A3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40069A4")]
			[FieldOffset(Offset = "0x20")]
			public Action loadOver;

			[Token(Token = "0x17000F6E")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005B4E")]
				[Address(RVA = "0x439C19C", Offset = "0x439819C", VA = "0x439C19C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F6F")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005B50")]
				[Address(RVA = "0x439C1DC", Offset = "0x43981DC", VA = "0x439C1DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005B4B")]
			[Address(RVA = "0x439BEAC", Offset = "0x4397EAC", VA = "0x439BEAC")]
			[DebuggerHidden]
			public _003COpenLoadingUI_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005B4C")]
			[Address(RVA = "0x439C0B8", Offset = "0x43980B8", VA = "0x439C0B8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005B4D")]
			[Address(RVA = "0x439C0BC", Offset = "0x43980BC", VA = "0x439C0BC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005B4E")]
			[Address(RVA = "0x439C19C", Offset = "0x439819C", VA = "0x439C19C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x439C1A4", Offset = "0x43981A4", VA = "0x439C1A4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005B50")]
			[Address(RVA = "0x439C1DC", Offset = "0x43981DC", VA = "0x439C1DC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6005B41")]
		[Address(RVA = "0x439B9B0", Offset = "0x43979B0", VA = "0x439B9B0", Slot = "6")]
		public override void InitConfig(ResourcesInfo resourcesInfo)
		{
			ConfigMgr.Instance.SetConfigABRes(resourcesInfo);
			ConfigMgr.Instance.Initialize();
			InitConfigOver();
		}

		[Token(Token = "0x6005B42")]
		[Address(RVA = "0x439B9F4", Offset = "0x43979F4", VA = "0x439B9F4", Slot = "9")]
		public override void RegisterProcedure()
		{
			base.RegisterProcedure();
			var procedures = new List<GameFramework.Procedure.ProcedureBase>();
			procedures.Add(new ljzs_lt.Procedure.ProcedurePreLoad());
			procedures.Add(new ljzs_lt.Procedure.ProcedureStarGame());
			procedures.Add(new ljzs_lt.Procedure.ProcedureExitGame());
			GameFramework.GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>().Register(procedures.ToArray());
		}

		[Token(Token = "0x6005B43")]
		[Address(RVA = "0x439BC8C", Offset = "0x4397C8C", VA = "0x439BC8C", Slot = "4")]
		public override void InitPatchManager()
		{
			StartCoroutine(OpenLoadingUI(LoadingUIShow));
		}

		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x439BD78", Offset = "0x4397D78", VA = "0x439BD78")]
		private void PatchUpdateOverEventHandler(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x439BD18", Offset = "0x4397D18", VA = "0x439BD18")]
		private IEnumerator OpenLoadingUI(Action loadOver)
		{
			UnityEngine.Debug.Log("OpenLoadingUI");
			yield return 0;
			loadOver?.Invoke();
		}

		[Token(Token = "0x6005B46")]
		[Address(RVA = "0x439BED4", Offset = "0x4397ED4", VA = "0x439BED4", Slot = "8")]
		public override void MnieGameProjectSetting()
		{
		}

		[Token(Token = "0x6005B47")]
		[Address(RVA = "0x439BEDC", Offset = "0x4397EDC", VA = "0x439BEDC", Slot = "11")]
		public override void SetLayerCollisionMatrix()
		{
		}

		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x439BEE4", Offset = "0x4397EE4", VA = "0x439BEE4", Slot = "10")]
		public override void RegisterLogicCtr()
		{
			base.RegisterLogicCtr();
			GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(L_Tools.ServerTimeMgr.I, false);
			GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(PurchaseControl.I, false);
			GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(CommonGameModule.Email.EmailControl.I, false);
		}

		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x439C028", Offset = "0x4398028", VA = "0x439C028", Slot = "7")]
		public override void StartGame()
		{
			GameFramework.GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>().StartProcedure<ljzs_lt.Procedure.ProcedurePreLoad>();
		}

		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x439C0B0", Offset = "0x43980B0", VA = "0x439C0B0")]
		public GameStart()
		{
		}
	}
}
