using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000054")]
	public class ConsoleLogHandler
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action m_EventOnClear;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		public static string[] scenes;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x18")]
		public string currentScene;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x20")]
		public bool collapse;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x21")]
		public bool clearOnNewSceneLoaded;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x22")]
		public bool showTime;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x23")]
		public bool showScene;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x24")]
		public bool showFps;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x25")]
		public bool showMemory;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x26")]
		public bool showGraph;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x27")]
		public bool showClogTime;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x28")]
		public bool showLog;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x29")]
		public bool showWarning;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x2A")]
		public bool showError;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x2B")]
		public bool showCustomError;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x30")]
		public string filterText;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x38")]
		public float fps;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x40")]
		public string fpsText;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x48")]
		public float gcTotalMemory;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x4C")]
		public float logsMemUsage;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x50")]
		public float graphMemUsage;

		[Token(Token = "0x4000130")]
		private const float MemoryB2MB = 1f / 1048576f;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x54")]
		public float maxSize;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x58")]
		public ConsoleWindowUGUI.Log selectedLog;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x60")]
		public int numOfLogs;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x64")]
		public int numOfLogsWarning;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x68")]
		public int numOfLogsError;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x6C")]
		public int numOfLogsCustomError;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x70")]
		public int numOfCollapsedLogs;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x74")]
		public int numOfCollapsedLogsWarning;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x78")]
		public int numOfCollapsedLogsError;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x7C")]
		public int numOfCollapsedLogsCustomError;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x80")]
		public int numOfWaitAddError;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x88")]
		public List<ConsoleWindowUGUI.Log> threadedLogs;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x90")]
		public List<ConsoleWindowUGUI.Sample> samples;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x98")]
		public List<ConsoleWindowUGUI.Log> logs;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xA0")]
		public List<ConsoleWindowUGUI.Log> collapsedLogs;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xA8")]
		public List<ConsoleWindowUGUI.Log> currentLog;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xB0")]
		public MultiKeyDictionary<string, string, ConsoleWindowUGUI.Log> logsDic;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, string> cachedString;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xC0")]
		public List<(int index, bool isNewAdd, ConsoleWindowUGUI.Log log)> changeList;

		[Token(Token = "0x17000038")]
		public float TotalMemUsage
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x4645E34", Offset = "0x4641E34", VA = "0x4645E34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000005")]
		public event Action EventOnClear
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4645CFC", Offset = "0x4641CFC", VA = "0x4645CFC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x4645D98", Offset = "0x4641D98", VA = "0x4645D98")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4645E40", Offset = "0x4641E40", VA = "0x4645E40")]
		public ConsoleLogHandler()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x46462D4", Offset = "0x46422D4", VA = "0x46462D4")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4646D80", Offset = "0x4642D80", VA = "0x4646D80")]
		public void CaptureLogThread(string condition, string stacktrace, ConsoleWindowUGUI._LogType type)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x46465DC", Offset = "0x46425DC", VA = "0x46465DC")]
		private void AddLog(ConsoleWindowUGUI.Log log)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x46471E8", Offset = "0x46431E8", VA = "0x46471E8")]
		private void addSample()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4647348", Offset = "0x4643348", VA = "0x4647348")]
		public void calculateCurrentLog()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x464765C", Offset = "0x464365C", VA = "0x464765C")]
		public int GetSelectLogIndex()
		{
			return default;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4647004", Offset = "0x4643004", VA = "0x4647004")]
		public void clear()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4647740", Offset = "0x4643740", VA = "0x4647740")]
		public void SaveSetting()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x46478EC", Offset = "0x46438EC", VA = "0x46478EC")]
		public string SaveLogsToDevice(out string fullLogText)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ConsoleLogHandler.SaveLogsToDevice RVA=0x46478EC Token=0x6000178");
}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4647CB0", Offset = "0x4643CB0", VA = "0x4647CB0")]
		public void AddLogMemUsage(string logCondition)
		{
		}
	}
}
