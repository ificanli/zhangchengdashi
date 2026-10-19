using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003AE")]
	public class TimeModule : GameFrameModule
	{
		[Token(Token = "0x20003AF")]
		public delegate void CompleteHandler(int id);

		[Token(Token = "0x20003B0")]
		public delegate void EveryHandle(int id, int time);

		[Token(Token = "0x4001BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DateTime now;

		[Token(Token = "0x4001BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DateTime startTime;

		[Token(Token = "0x4001BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool isInit;

		[Token(Token = "0x4001BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static double timeDifference;

		[Token(Token = "0x4001BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static DateTime defaultTime;

		[Token(Token = "0x4001BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double lastTime;

		[Token(Token = "0x4001BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double lastMillisecond;

		[Token(Token = "0x4001BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double lastMinute;

		[Token(Token = "0x4001BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int timeId;

		[Token(Token = "0x4001BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double unityRealTime;

		[Token(Token = "0x4001BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<int, CompleteHandler> completeHandles;

		[Token(Token = "0x4001BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, double> completeTimes;

		[Token(Token = "0x4001BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<int, _00B3e_0086pº_00AD> everySecondHandles;

		[Token(Token = "0x4001BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<int, _00B3e_0086pº_00AD> everyMillisecondHandles;

		[Token(Token = "0x4001BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, _00B3e_0086pº_00AD> everyMinuteHandles;

		[Token(Token = "0x4001BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<int, _0097_0084S_007E_0089_0095> loopTimers;

		[Token(Token = "0x4001BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static bool IsFocus;

		[Token(Token = "0x4001BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<_0097_0084S_007E_0089_0095> AddLoopTimerData;

		[Token(Token = "0x4001BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<int> loopTimerRemoveID;

		[Token(Token = "0x4001BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<int> removeList;

		[Token(Token = "0x4001BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<int, N_00A8_00A6jO_005D> dicUnityTimer;

		[Token(Token = "0x4001BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<int, N_00A8_00A6jO_005D> dicEverySecondTimer;

		[Token(Token = "0x4001BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<int, N_00A8_00A6jO_005D> dicEveryMinuteTimer;

		[Token(Token = "0x4001BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<N_00A8_00A6jO_005D> NewAddUnityTimer;

		[Token(Token = "0x4001BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<N_00A8_00A6jO_005D> NewAddEverySecond;

		[Token(Token = "0x4001BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<N_00A8_00A6jO_005D> NewAddEveryMinute;

		[Token(Token = "0x4001BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<int> CompleteUnityTimer;

		[Token(Token = "0x4001BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<int> CashCompleteUnityTimer;

		[Token(Token = "0x17001132")]
		internal override int Priority
		{
			[Token(Token = "0x6005D3E")]
			[Address(RVA = "0x71C283C", Offset = "0x71BE83C", VA = "0x71C283C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0x71C2844", Offset = "0x71BE844", VA = "0x71C2844", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x71C2AA8", Offset = "0x71BEAA8", VA = "0x71C2AA8", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005D41")]
		[Address(RVA = "0x71C2B9C", Offset = "0x71BEB9C", VA = "0x71C2B9C", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005D42")]
		[Address(RVA = "0x71C373C", Offset = "0x71BF73C", VA = "0x71C373C")]
		private void GamePause(object[] Args)
		{
		}

		[Token(Token = "0x6005D43")]
		[Address(RVA = "0x71C3974", Offset = "0x71BF974", VA = "0x71C3974")]
		private void GameFocus(object[] Args)
		{
		}

		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x71C3A28", Offset = "0x71BFA28", VA = "0x71C3A28")]
		private void ClearTimer()
		{
		}

		[Token(Token = "0x6005D45")]
		[Address(RVA = "0x71C3B78", Offset = "0x71BFB78", VA = "0x71C3B78")]
		private int AddLoopTimer(int LoopSteepTime, bool UseGamePause, bool UseTimeScale, bool AutoPlay, Action<int> CompleteCallBack)
		{
			return default;
		}

		[Token(Token = "0x6005D46")]
		[Address(RVA = "0x71C3E58", Offset = "0x71BFE58", VA = "0x71C3E58")]
		public int AddLoopTimer(float LoopSteepTime, bool UseGamePause, bool UseTimeScale, bool AutoPlay, Action<float> CompleteCallBack)
		{
			return default;
		}

		[Token(Token = "0x6005D47")]
		[Address(RVA = "0x71C2C84", Offset = "0x71BEC84", VA = "0x71C2C84")]
		private void CheckLoopTimer(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005D48")]
		[Address(RVA = "0x71C43F0", Offset = "0x71C03F0", VA = "0x71C43F0")]
		public int AddLoopTimer(int LoopSteepTime, Action<int> LoopTimeCompleteCallBack, bool AutoPaly = true, bool UseTimeScale = false)
		{
			return default;
		}

		[Token(Token = "0x6005D49")]
		[Address(RVA = "0x71C4408", Offset = "0x71C0408", VA = "0x71C4408")]
		public int AddLoopTimer(int LoopSteepTime, bool UseGamePause, Action<int> CompleteCallBack, bool AutoPaly = true, bool UseTimeScale = false)
		{
			return default;
		}

		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0x71C4420", Offset = "0x71C0420", VA = "0x71C4420")]
		public void PlayLoopTimer(int Id)
		{
		}

		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0x71C457C", Offset = "0x71C057C", VA = "0x71C457C")]
		public void PauseLoopTimer(int Id, [Optional] Action<int> PauseLoopTimerCallBack)
		{
		}

		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x71C4718", Offset = "0x71C0718", VA = "0x71C4718")]
		public void ResetLoopTimer(int Id, bool IsResetAll = true)
		{
		}

		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x71C4898", Offset = "0x71C0898", VA = "0x71C4898")]
		public int GetLoopTimerValue(int Id)
		{
			return default;
		}

		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x71C4A10", Offset = "0x71C0A10", VA = "0x71C4A10")]
		public void RemoveLoopTimer(int Id, [Optional] Action<int> RemoveLoopTimerCallBack)
		{
		}

		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x71C412C", Offset = "0x71C012C", VA = "0x71C412C")]
		private void PRemoveLoopTimer(int Id)
		{
		}

		[Token(Token = "0x6005D50")]
		[Address(RVA = "0x71C4B58", Offset = "0x71C0B58", VA = "0x71C4B58")]
		private double GetTime(DateTime t)
		{
			return default;
		}

		[Token(Token = "0x6005D51")]
		[Address(RVA = "0x71C4C3C", Offset = "0x71C0C3C", VA = "0x71C4C3C")]
		public double GetNowTime()
		{
			return default;
		}

		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x71C4D30", Offset = "0x71C0D30", VA = "0x71C4D30")]
		[Obsolete("时间戳最好用long存储,GetNowTimeLong")]
		public int GetNowTimeInt()
		{
			return default;
		}

		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x71C4E2C", Offset = "0x71C0E2C", VA = "0x71C4E2C")]
		public long GetNowTimeLong()
		{
			return default;
		}

		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x71C4F28", Offset = "0x71C0F28", VA = "0x71C4F28")]
		public double RealtimeSinceStartup()
		{
			return default;
		}

		[Token(Token = "0x6005D55")]
		[Address(RVA = "0x71C4F3C", Offset = "0x71C0F3C", VA = "0x71C4F3C")]
		public void SetServerTime(double t)
		{
		}

		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x71C5078", Offset = "0x71C1078", VA = "0x71C5078")]
		public static int GetToDayZeroTime()
		{
			return default;
		}

		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x71C5190", Offset = "0x71C1190", VA = "0x71C5190")]
		public static int GetNextDayTwoTime()
		{
			return default;
		}

		[Token(Token = "0x6005D58")]
		[Address(RVA = "0x71C3D90", Offset = "0x71BFD90", VA = "0x71C3D90")]
		private int GetTimeId()
		{
			return default;
		}

		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x71C52AC", Offset = "0x71C12AC", VA = "0x71C52AC")]
		private int AddDeadLine(double deadLine, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x71C5404", Offset = "0x71C1404", VA = "0x71C5404")]
		private int AddDeadLineStr(string deadLineStr, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x71C5544", Offset = "0x71C1544", VA = "0x71C5544")]
		private int AddCoundDown(int sec, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x71C5670", Offset = "0x71C1670", VA = "0x71C5670")]
		private int AddCoundDown2(int sec, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D5D")]
		[Address(RVA = "0x71C5794", Offset = "0x71C1794", VA = "0x71C5794")]
		private int AddSecond(EveryHandle eHandle, int t)
		{
			return default;
		}

		[Token(Token = "0x6005D5E")]
		[Address(RVA = "0x71C5850", Offset = "0x71C1850", VA = "0x71C5850")]
		private int AddMillisecond(EveryHandle eHandle, int t)
		{
			return default;
		}

		[Token(Token = "0x6005D5F")]
		[Address(RVA = "0x71C590C", Offset = "0x71C190C", VA = "0x71C590C")]
		private int AddMinute(EveryHandle eHandle, int t)
		{
			return default;
		}

		[Token(Token = "0x6005D60")]
		[Address(RVA = "0x71C5A04", Offset = "0x71C1A04", VA = "0x71C5A04")]
		private void Remove(int id)
		{
		}

		[Token(Token = "0x6005D61")]
		[Address(RVA = "0x71C5BF0", Offset = "0x71C1BF0", VA = "0x71C5BF0")]
		private void Check(DateTime t)
		{
		}

		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x71C5C38", Offset = "0x71C1C38", VA = "0x71C5C38")]
		private void CheckComplete(double t)
		{
		}

		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x71C6178", Offset = "0x71C2178", VA = "0x71C6178")]
		private void CheckSecond(double t)
		{
		}

		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x71C663C", Offset = "0x71C263C", VA = "0x71C663C")]
		private void CheckMillisecond(double t)
		{
		}

		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x71C6ACC", Offset = "0x71C2ACC", VA = "0x71C6ACC")]
		private void CheckMinute(double t)
		{
		}

		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x71C2C78", Offset = "0x71BEC78", VA = "0x71C2C78")]
		private void CheckTime(DateTime t, float unityRealTime)
		{
		}

		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x71C6FD4", Offset = "0x71C2FD4", VA = "0x71C6FD4")]
		public int SetDeadLine(int deadLine, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x71C6FEC", Offset = "0x71C2FEC", VA = "0x71C6FEC")]
		public int SetDeadLineStr(string deadLine, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D69")]
		[Address(RVA = "0x71C6FF0", Offset = "0x71C2FF0", VA = "0x71C6FF0")]
		public int SetDeadLineMs(double deadLine, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x71C6FF4", Offset = "0x71C2FF4", VA = "0x71C6FF4")]
		public int SetCountDown(int sec, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x71C6FF8", Offset = "0x71C2FF8", VA = "0x71C6FF8")]
		public int SetCountDownByMillisecond(int sec, CompleteHandler cHandle, [Optional] EveryHandle eHandle)
		{
			return default;
		}

		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0x71C6FFC", Offset = "0x71C2FFC", VA = "0x71C6FFC")]
		public int SetEveryMilliSecond(EveryHandle eHandle, int t = 1)
		{
			return default;
		}

		[Token(Token = "0x6005D6D")]
		[Address(RVA = "0x71C7000", Offset = "0x71C3000", VA = "0x71C7000")]
		public int SetEverySecond(EveryHandle eHandle, int t = 1)
		{
			return default;
		}

		[Token(Token = "0x6005D6E")]
		[Address(RVA = "0x71C7004", Offset = "0x71C3004", VA = "0x71C7004")]
		public int SetEveryMinute(EveryHandle eHandle, int t = 1)
		{
			return default;
		}

		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0x71C7008", Offset = "0x71C3008", VA = "0x71C7008")]
		public void RemoveTime(int id)
		{
		}

		[Token(Token = "0x6005D70")]
		[Address(RVA = "0x71C700C", Offset = "0x71C300C", VA = "0x71C700C")]
		public static void SetStartTime(int year, int month, int day)
		{
		}

		[Token(Token = "0x6005D71")]
		[Address(RVA = "0x71C70A0", Offset = "0x71C30A0", VA = "0x71C70A0")]
		public int AddUnityTimer(float duration, bool UseTimeScale, Action CompleteActive, [Optional] Action<float> EveryUpdate, [Optional] Action EverySecond)
		{
			return default;
		}

		[Token(Token = "0x6005D72")]
		[Address(RVA = "0x71C72B4", Offset = "0x71C32B4", VA = "0x71C72B4")]
		public int AddUnityEverySecondTimer(bool UseTimeScale, Action EverySecond)
		{
			return default;
		}

		[Token(Token = "0x6005D73")]
		[Address(RVA = "0x71C73B8", Offset = "0x71C33B8", VA = "0x71C73B8")]
		public int AddUnityEveryMinuteTimer(bool UseTimeScale, Action EverySecond)
		{
			return default;
		}

		[Token(Token = "0x6005D74")]
		[Address(RVA = "0x71C74BC", Offset = "0x71C34BC", VA = "0x71C74BC")]
		private void AddNewUnityTimer()
		{
		}

		[Token(Token = "0x6005D75")]
		[Address(RVA = "0x71C3180", Offset = "0x71BF180", VA = "0x71C3180")]
		private void CheckUnityTimer()
		{
		}

		[Token(Token = "0x6005D76")]
		[Address(RVA = "0x71C7720", Offset = "0x71C3720", VA = "0x71C7720")]
		private void PriRemoveUnityTimer(int id)
		{
		}

		[Token(Token = "0x6005D77")]
		[Address(RVA = "0x71C7928", Offset = "0x71C3928", VA = "0x71C7928")]
		public void RemoveUnityTimer(int id)
		{
		}

		[Token(Token = "0x6005D78")]
		[Address(RVA = "0x71C79CC", Offset = "0x71C39CC", VA = "0x71C79CC", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005D79")]
		[Address(RVA = "0x71C7AD0", Offset = "0x71C3AD0", VA = "0x71C7AD0")]
		public TimeModule()
		{
		}
	}
}
