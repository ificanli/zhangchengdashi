using GameFramework.Fsm;
using GameFramework.Procedure;
using Il2CppDummyDll;

namespace ljzs_lt.Procedure
{
	[Token(Token = "0x2000F54")]
	public class ProcedureStarGame : ProcedureBase
	{
		[Token(Token = "0x40069DA")]
		[FieldOffset(Offset = "0x18")]
		private IFsm<IProcedureManager> m_ProcedureOwner;

		[Token(Token = "0x40069DB")]
		[FieldOffset(Offset = "0x20")]
		private int GameTimer;

		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0x43A07A4", Offset = "0x439C7A4", VA = "0x43A07A4", Slot = "4")]
		public override void OnInit(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnInit(procedureOwner);
    m_ProcedureOwner = procedureOwner;
}

		[Token(Token = "0x6005BC4")]
		[Address(RVA = "0x43A07CC", Offset = "0x439C7CC", VA = "0x43A07CC", Slot = "5")]
		public override void OnEnter(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnEnter(procedureOwner);
    GameFramework.MsgDispatcher.AddEventListener("ReadyExitGame", ReadyExitGame);
    GameTimer = GameFramework.GameFrameEntry.GetModule<GameFramework.TimeModule>().AddLoopTimer(30, true, ReportGameTimes, true, false);
    DBTSDK.ReportManager.Instance.StartGameModel(MineGameModel.None);
    GameFramework.Base.GameStartEntry.EnterGame = true;
    GameFramework.GlobalData.CheckNewDay();
    StarGame();
}

		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x43A0A9C", Offset = "0x439CA9C", VA = "0x43A0A9C")]
		private void ReportGameTimes(int times)
		{
    DBTSDK.ReportManager.Instance.ReportGamePlayTime(times);
}

		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x43A09D4", Offset = "0x439C9D4", VA = "0x43A09D4")]
		private void StarGame()
		{
    UnityEngine.Debug.Log("显示主UI");
    UnityEngine.AddressableAssets.Addressables.LoadSceneAsync("Assets/_Scene/Game.unity", UnityEngine.SceneManagement.LoadSceneMode.Single, true, 100);
}

		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x43A0B08", Offset = "0x439CB08", VA = "0x43A0B08")]
		private void GotoTestScene()
		{
    GameFramework.ResLoadHelper.LoadScene("MineGameTest", null, false, null);
}

		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x43A0B7C", Offset = "0x439CB7C", VA = "0x43A0B7C")]
		private void ReadyExitGame(object[] Args)
		{
    GameFramework.MsgDispatcher.SendMessage("MineGameExitLogic", (object[])null);
    ChangeState<ProcedureExitGame>(m_ProcedureOwner, System.Array.Empty<object>());
}

		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x43A0C58", Offset = "0x439CC58", VA = "0x43A0C58", Slot = "7")]
		public override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
    base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
}

		[Token(Token = "0x6005BCA")]
		[Address(RVA = "0x43A0C60", Offset = "0x439CC60", VA = "0x43A0C60", Slot = "8")]
		public override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
		{
    base.OnLeave(procedureOwner, isShutdown);
    GameFramework.GameFrameEntry.GetModule<GameFramework.TimeModule>().RemoveLoopTimer(GameTimer, time => ReportGameTimes(time));
    GameFramework.MsgDispatcher.RemoveEventListener("ReadyExitGame", ReadyExitGame);
}

		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x43A0DC8", Offset = "0x439CDC8", VA = "0x43A0DC8", Slot = "9")]
		public override void OnDestroy(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnDestroy(procedureOwner);
}

		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x439BC7C", Offset = "0x4397C7C", VA = "0x439BC7C")]
		public ProcedureStarGame()
		{
		}
	}
}
