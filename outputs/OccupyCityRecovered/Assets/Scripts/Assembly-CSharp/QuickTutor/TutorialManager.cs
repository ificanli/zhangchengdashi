using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace QuickTutor
{
	[Token(Token = "0x2000C91")]
	public class TutorialManager : Singleton<TutorialManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C92")]
		[CompilerGenerated]
		private struct _003CEndTutorial_003Ed__41 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialManager _003C_003E4__this;

			[Token(Token = "0x4005A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string _003CnextId_003E5__2;

			[Token(Token = "0x4005A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004EF0")]
			[Address(RVA = "0x42AD494", Offset = "0x42A9494", VA = "0x42AD494", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004EF1")]
			[Address(RVA = "0x42AE258", Offset = "0x42AA258", VA = "0x42AE258", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C93")]
		[CompilerGenerated]
		private struct _003CGetTargetRectList_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4005A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> paths;

			[Token(Token = "0x4005A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialManager _003C_003E4__this;

			[Token(Token = "0x4005A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<ITutorialPointInfo> result;

			[Token(Token = "0x4005A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string>.Enumerator _003C_003E7__wrap1;

			[Token(Token = "0x4005A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string _003Cpath_003E5__3;

			[Token(Token = "0x4005A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004EF2")]
			[Address(RVA = "0x42AE264", Offset = "0x42AA264", VA = "0x42AE264", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004EF3")]
			[Address(RVA = "0x42AEEB0", Offset = "0x42AAEB0", VA = "0x42AEEB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C94")]
		[CompilerGenerated]
		private struct _003COnDragTutorialEnd_003Ed__42 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialManager _003C_003E4__this;

			[Token(Token = "0x4005A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object obj;

			[Token(Token = "0x4005A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004EF4")]
			[Address(RVA = "0x42AEF08", Offset = "0x42AAF08", VA = "0x42AEF08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004EF5")]
			[Address(RVA = "0x42AF350", Offset = "0x42AB350", VA = "0x42AF350", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C95")]
		[CompilerGenerated]
		private struct _003COnTutorialBtnClick_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialManager _003C_003E4__this;

			[Token(Token = "0x4005A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004EF6")]
			[Address(RVA = "0x42AF35C", Offset = "0x42AB35C", VA = "0x42AF35C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004EF7")]
			[Address(RVA = "0x42AF76C", Offset = "0x42AB76C", VA = "0x42AF76C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C96")]
		[CompilerGenerated]
		private struct _003CStartTutorial_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4005A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialManager _003C_003E4__this;

			[Token(Token = "0x4005A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string id;

			[Token(Token = "0x4005A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private BaseTutorialPanel _003CtutorialPanel_003E5__2;

			[Token(Token = "0x4005A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool _003CfastBlockModeOpened_003E5__3;

			[Token(Token = "0x4005A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TutorialSetupInfo _003CtutorialSetupInfo_003E5__4;

			[Token(Token = "0x4005A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TutorialActionType _003CactionType_003E5__5;

			[Token(Token = "0x4005A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float _003CmaskType_003E5__6;

			[Token(Token = "0x4005A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private List<ITutorialPointInfo> _003CmaskPoints_003E5__7;

			[Token(Token = "0x4005A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<ITutorialPointInfo> _003CslideAnimPoints_003E5__8;

			[Token(Token = "0x4005A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private bool _003CisHaveMaskPoint_003E5__9;

			[Token(Token = "0x4005A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004EF8")]
			[Address(RVA = "0x42AF778", Offset = "0x42AB778", VA = "0x42AF778", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004EF9")]
			[Address(RVA = "0x42B07DC", Offset = "0x42AC7DC", VA = "0x42B07DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> blockTutorialTriggerKeys;

		[Token(Token = "0x4005A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, TutorialSetupInfo> _tutorialInfoDic;

		[Token(Token = "0x4005A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _currentId;

		[Token(Token = "0x4005A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool tutorialing;

		[Token(Token = "0x4005A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _tutorialEnding;

		[Token(Token = "0x4005A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool _forceClosed;

		[Token(Token = "0x4005A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Regex _methodRegex;

		[Token(Token = "0x4005A37")]
		private const string ClassNameGroup = "className";

		[Token(Token = "0x4005A38")]
		private const string MethodNameGroup = "methodName";

		[Token(Token = "0x4005A39")]
		private const string MethodParameterGroup = "methodParameter";

		[Token(Token = "0x4005A3A")]
		private const string InstanceProperty = "Instance";

		[Token(Token = "0x4005A3B")]
		private const string TutorialDiagPrefix = "[TutorialManager]";

		[Token(Token = "0x4005A3C")]
		private const bool TutorialDiagLogEnabled = false;

		[Token(Token = "0x4005A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool InitSteerInfoEnd;

		[Token(Token = "0x4005A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, Func<bool>> allTutorial;

		[Token(Token = "0x4005A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string[] YinDaoStep1To8Ids;

		[Token(Token = "0x4005A41")]
		private const string StrConstantsCommonSymbols = "/";

		[Token(Token = "0x4005A42")]
		private const int MaxFindCount = 60;

		[Token(Token = "0x4005A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _currentFindCount;

		[Token(Token = "0x17000E15")]
		public static ITutorialResourceManager TutorialResManager
		{
			[Token(Token = "0x6004ED7")]
			[Address(RVA = "0x42AADEC", Offset = "0x42A6DEC", VA = "0x42AADEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ED8")]
			[Address(RVA = "0x42AAE44", Offset = "0x42A6E44", VA = "0x42AAE44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x42AADE8", Offset = "0x42A6DE8", VA = "0x42AADE8")]
		private static void TutorialDiagLog(string message)
		{
		}

		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x42AAEA0", Offset = "0x42A6EA0", VA = "0x42AAEA0")]
		public void Init(ITutorialResourceManager tutorialResManager)
		{
		}

		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x42A77C4", Offset = "0x42A37C4", VA = "0x42A77C4")]
		public bool IsStepComplete(string tutorialId)
		{
			return default;
		}

		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x42AB5A4", Offset = "0x42A75A4", VA = "0x42AB5A4")]
		private void ResetYinDaoStep1To8ToUnComplete()
		{
		}

		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x42AB724", Offset = "0x42A7724", VA = "0x42AB724")]
		private void SetYinDaoStep2To8ToComplete()
		{
		}

		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x42AB8A4", Offset = "0x42A78A4", VA = "0x42AB8A4")]
		private void ResetYinDaoStep7To8ToUnComplete()
		{
		}

		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x42ABA84", Offset = "0x42A7A84", VA = "0x42ABA84")]
		private void ResetYinDaoStep8ToUnComplete()
		{
		}

		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x42ABBA8", Offset = "0x42A7BA8", VA = "0x42ABBA8")]
		private bool IsYinDaoStep1Or7Or8(string tutorialId)
		{
			return default;
		}

		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x42ABC54", Offset = "0x42A7C54", VA = "0x42ABC54")]
		public void TutorialCheck()
		{
		}

		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x42AC1C8", Offset = "0x42A81C8", VA = "0x42AC1C8")]
		public void AddOneBlockTutorialTriggerKey(string key)
		{
		}

		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x42AC328", Offset = "0x42A8328", VA = "0x42AC328")]
		public void RemoveOneBlockTutorialTriggerKey(string key)
		{
		}

		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x42A78C8", Offset = "0x42A38C8", VA = "0x42A78C8")]
		public void RegisterTutorialCheck(string tutorialId, Func<bool> canTutorial)
		{
		}

		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x42AC438", Offset = "0x42A8438", VA = "0x42AC438")]
		public void CleanAllTutorial()
		{
		}

		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0x42AC128", Offset = "0x42A8128", VA = "0x42AC128")]
		[AsyncStateMachine(typeof(_003CStartTutorial_003Ed__33))]
		private void StartTutorial(string id)
		{
		}

		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x42AC488", Offset = "0x42A8488", VA = "0x42AC488")]
		[AsyncStateMachine(typeof(_003CGetTargetRectList_003Ed__37))]
		private UniTask<bool> GetTargetRectList(List<string> paths, List<ITutorialPointInfo> result)
		{
			return default;
		}

		[Token(Token = "0x6004EE7")]
		[Address(RVA = "0x42AC564", Offset = "0x42A8564", VA = "0x42AC564")]
		private object GetTransByRef(string path)
		{
			return null;
		}

		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x42AC90C", Offset = "0x42A890C", VA = "0x42AC90C")]
		private void StartTutorial(List<ITutorialPointInfo> maskPoints, List<ITutorialPointInfo> slideAnimPoints, TutorialActionType tutorialActionType, float maskType, string tutorialText, float textPos)
		{
		}

		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x42ACBEC", Offset = "0x42A8BEC", VA = "0x42ACBEC")]
		public void ForceCloseTutorial()
		{
		}

		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x42ACEE8", Offset = "0x42A8EE8", VA = "0x42ACEE8")]
		[AsyncStateMachine(typeof(_003CEndTutorial_003Ed__41))]
		private UniTask EndTutorial()
		{
			return default;
		}

		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x42ACF84", Offset = "0x42A8F84", VA = "0x42ACF84")]
		[AsyncStateMachine(typeof(_003COnDragTutorialEnd_003Ed__42))]
		private void OnDragTutorialEnd(object obj)
		{
		}

		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x42AD020", Offset = "0x42A9020", VA = "0x42AD020")]
		[AsyncStateMachine(typeof(_003COnTutorialBtnClick_003Ed__43))]
		private void OnTutorialBtnClick(object clickObj)
		{
		}

		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x42AD0AC", Offset = "0x42A90AC", VA = "0x42AD0AC")]
		public TutorialManager()
		{
		}
	}
}
