using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using QuickTutor;
using UnityEngine;

namespace TutorModule
{
	[Token(Token = "0x20001FC")]
	public class TutorialResourceManager : ITutorialResourceManager
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001FF")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4001CDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001CDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<TutorialResourceManager> _003C_003Et__builder;

			[Token(Token = "0x4001CDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TutorialResourceManager _003C_003E4__this;

			[Token(Token = "0x4001CDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<UIFramework.UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x418D098", Offset = "0x4189098", VA = "0x418D098", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x418D548", Offset = "0x4189548", VA = "0x418D548", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001CD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<string> _completeIdList;

		[Token(Token = "0x4001CD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BaseTutorialPanel _tutorialPanel;

		[Token(Token = "0x4001CD8")]
		private const string UIRootPath = "UIPanelsRoot";

		[Token(Token = "0x4001CD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _uiRootTransform;

		[Token(Token = "0x170000A1")]
		private IList<GlobalTutorialInfo> TutorialInfos
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x418C330", Offset = "0x4188330", VA = "0x418C330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private IList<UserTutorialData> UserTutorialDataList
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x418C388", Offset = "0x4188388", VA = "0x418C388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x418C250", Offset = "0x4188250", VA = "0x418C250")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__6))]
		public UniTask<TutorialResourceManager> Init()
		{
			return default;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x418C3F0", Offset = "0x41883F0", VA = "0x418C3F0")]
		private void InitTutorialData()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x418C74C", Offset = "0x418874C", VA = "0x418C74C", Slot = "4")]
		public BaseTutorialPanel GetTutorialPanel()
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x418C754", Offset = "0x4188754", VA = "0x418C754", Slot = "5")]
		public Camera GetMainCamera()
		{
			return null;
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x418C7A4", Offset = "0x41887A4", VA = "0x418C7A4", Slot = "6")]
		public Camera GetUICamera()
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x418C7F4", Offset = "0x41887F4", VA = "0x418C7F4", Slot = "7")]
		public List<TutorialSetupInfo> GetTutorialInfo()
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x418CB3C", Offset = "0x4188B3C", VA = "0x418CB3C", Slot = "8")]
		public bool IsComplete(string tutorialId)
		{
			return default;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x418CB94", Offset = "0x4188B94", VA = "0x418CB94", Slot = "9")]
		public void SetComplete(string tutorialId)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x418CE4C", Offset = "0x4188E4C", VA = "0x418CE4C", Slot = "10")]
		public void SetUnComplete(string tutorialId)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x418CFB0", Offset = "0x4188FB0", VA = "0x418CFB0", Slot = "11")]
		public Transform GetUIRootTransform()
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x418C248", Offset = "0x4188248", VA = "0x418C248")]
		public TutorialResourceManager()
		{
		}
	}
}
