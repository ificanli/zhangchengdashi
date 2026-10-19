using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000B47")]
	public class ImgIAPCardItem : ImgIAPCardItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B48")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x400522F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgIAPCardItem _003C_003E4__this;

			[Token(Token = "0x4005232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isArtifact;

			[Token(Token = "0x4005233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string rewardCofig;

			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x41F58C4", Offset = "0x41F18C4", VA = "0x41F58C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x41F5B50", Offset = "0x41F1B50", VA = "0x41F5B50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B49")]
		[CompilerGenerated]
		private struct _003CUpdateUI_003Ed__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4005234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImgIAPCardItem _003C_003E4__this;

			[Token(Token = "0x4005237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isArtifact;

			[Token(Token = "0x4005238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Sprite[] _003CloadedSprites_003E5__2;

			[Token(Token = "0x4005239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite[]>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400523A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x41F5B5C", Offset = "0x41F1B5C", VA = "0x41F5B5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60044D9")]
			[Address(RVA = "0x41F7514", Offset = "0x41F3514", VA = "0x41F7514", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string cardId;

		[Token(Token = "0x4005229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int cardNum;

		[Token(Token = "0x400522A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool isArtifact;

		[Token(Token = "0x400522B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool isDecreaseOne;

		[Token(Token = "0x400522C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		private bool customSetCardAddNumTxt;

		[Token(Token = "0x400522D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F")]
		private bool isShowCustomSelectCardPanel;

		[Token(Token = "0x400522E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isShowGoldLight;

		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x41EE23C", Offset = "0x41EA23C", VA = "0x41EE23C")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public void Init(string rewardCofig, bool isArtifact = false)
		{
		}

		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x41F4754", Offset = "0x41F0754", VA = "0x41F4754", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x41EF9A4", Offset = "0x41EB9A4", VA = "0x41EF9A4")]
		public void ShowRewardCardNumDecreaseOne()
		{
		}

		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x41F48D4", Offset = "0x41F08D4", VA = "0x41F48D4")]
		private void LoseCard(object o)
		{
		}

		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x41F48DC", Offset = "0x41F08DC", VA = "0x41F48DC")]
		private void GetCard(object o)
		{
		}

		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x41F48E4", Offset = "0x41F08E4", VA = "0x41F48E4")]
		public void CustomSetCardAddNumTxt(int num)
		{
		}

		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x41F4A4C", Offset = "0x41F0A4C", VA = "0x41F4A4C")]
		public void SetBtnToCanClick(bool isShowCustomSelectCardPanel)
		{
		}

		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x41F4C28", Offset = "0x41F0C28", VA = "0x41F4C28", Slot = "12")]
		protected override void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x41F4830", Offset = "0x41F0830", VA = "0x41F4830")]
		[AsyncStateMachine(typeof(_003CUpdateUI_003Ed__14))]
		public void UpdateUI(bool isArtifact = false)
		{
		}

		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x41EE2E4", Offset = "0x41EA2E4", VA = "0x41EE2E4")]
		public void ShowCardName(bool isArtifact = false)
		{
		}

		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x41F5644", Offset = "0x41F1644", VA = "0x41F5644")]
		private void Update()
		{
		}

		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x41EF9B0", Offset = "0x41EB9B0", VA = "0x41EF9B0")]
		public void ShowGoldLight()
		{
		}

		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x41EE630", Offset = "0x41EA630", VA = "0x41EE630")]
		public void ShowRareLevel(bool isArtifact = false)
		{
		}

		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x41F5134", Offset = "0x41F1134", VA = "0x41F5134")]
		private void SetRareText(string rareLevel)
		{
		}

		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x41F5744", Offset = "0x41F1744", VA = "0x41F5744")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x41F5890", Offset = "0x41F1890", VA = "0x41F5890")]
		public ImgIAPCardItem()
		{
		}
	}
}
