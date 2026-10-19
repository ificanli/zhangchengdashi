using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FCA")]
	public class FakeMediationBehaviour : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000FCC")]
		[CompilerGenerated]
		private struct _003CShowBanner_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4006BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4006BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4006BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FakeMediationBehaviour _003C_003E4__this;

			[Token(Token = "0x4006BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationTokenSource token;

			[Token(Token = "0x4006BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005E83")]
			[Address(RVA = "0x43FCB98", Offset = "0x43F8B98", VA = "0x43FCB98", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005E84")]
			[Address(RVA = "0x43FCF2C", Offset = "0x43F8F2C", VA = "0x43FCF2C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_bannerVideoAd")]
		[SerializeField]
		private FakeBannerAd bannerAd;

		[Token(Token = "0x4006BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_interstitialAd")]
		[SerializeField]
		private FakeInterstitialAd interstitialAd;

		[Token(Token = "0x4006BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_rewardedAd")]
		[SerializeField]
		private FakeRewardedVideoAd rewardedAd;

		[Token(Token = "0x4006BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FakeAppOpenAd appOpenAd;

		[Token(Token = "0x4006BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FakeNativeAd nativeAd;

		[Token(Token = "0x4006BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FakeMrecAd mrecAd;

		[Token(Token = "0x4006BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _prevTimeScale;

		[Token(Token = "0x4006BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CancellationTokenSource _refreshBannerCancellationToken;

		[Token(Token = "0x17000FA7")]
		public FakeMediationCallbacks Callbacks
		{
			[Token(Token = "0x6005E6A")]
			[Address(RVA = "0x43FC2DC", Offset = "0x43F82DC", VA = "0x43FC2DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E6B")]
			[Address(RVA = "0x43FC2E4", Offset = "0x43F82E4", VA = "0x43FC2E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0x43FC2EC", Offset = "0x43F82EC", VA = "0x43FC2EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0x43FC2F0", Offset = "0x43F82F0", VA = "0x43FC2F0")]
		public void CreateBanner()
		{
		}

		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0x43FC330", Offset = "0x43F8330", VA = "0x43FC330")]
		public void ShowBanner()
		{
		}

		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0x43FC3A4", Offset = "0x43F83A4", VA = "0x43FC3A4")]
		[AsyncStateMachine(typeof(_003CShowBanner_003Ed__15))]
		private Task ShowBanner(CancellationTokenSource token)
		{
			return null;
		}

		[Token(Token = "0x6005E70")]
		[Address(RVA = "0x43FC478", Offset = "0x43F8478", VA = "0x43FC478")]
		public void HideBanner()
		{
		}

		[Token(Token = "0x6005E71")]
		[Address(RVA = "0x43FC4AC", Offset = "0x43F84AC", VA = "0x43FC4AC")]
		public void LoadInterstitial()
		{
		}

		[Token(Token = "0x6005E72")]
		[Address(RVA = "0x43FC4EC", Offset = "0x43F84EC", VA = "0x43FC4EC")]
		public void ShowInterstitial()
		{
		}

		[Token(Token = "0x6005E73")]
		[Address(RVA = "0x43FC608", Offset = "0x43F8608", VA = "0x43FC608")]
		public void LoadRewarded()
		{
		}

		[Token(Token = "0x6005E74")]
		[Address(RVA = "0x43FC648", Offset = "0x43F8648", VA = "0x43FC648")]
		public void ShowRewarded(Action<string, bool> onReward)
		{
		}

		[Token(Token = "0x6005E75")]
		[Address(RVA = "0x43FC76C", Offset = "0x43F876C", VA = "0x43FC76C")]
		public void LoadAppOpen()
		{
		}

		[Token(Token = "0x6005E76")]
		[Address(RVA = "0x43FC7AC", Offset = "0x43F87AC", VA = "0x43FC7AC")]
		public void ShowAppOpen()
		{
		}

		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x43FC824", Offset = "0x43F8824", VA = "0x43FC824")]
		public void LoadNativeAd()
		{
		}

		[Token(Token = "0x6005E78")]
		[Address(RVA = "0x43FC864", Offset = "0x43F8864", VA = "0x43FC864")]
		public void ShowNativeAd(string layoutName, float x, float y, float width, float height)
		{
		}

		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x43FC958", Offset = "0x43F8958", VA = "0x43FC958")]
		public void HideNative()
		{
		}

		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x43FC9B8", Offset = "0x43F89B8", VA = "0x43FC9B8")]
		public void CreateMRec()
		{
		}

		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0x43FC9F8", Offset = "0x43F89F8", VA = "0x43FC9F8")]
		public void ShowMrec(float x, float y)
		{
		}

		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x43FCA84", Offset = "0x43F8A84", VA = "0x43FCA84")]
		public void HideMrec()
		{
		}

		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0x43FC5C4", Offset = "0x43F85C4", VA = "0x43FC5C4")]
		private void PauseTime()
		{
		}

		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x43FCA9C", Offset = "0x43F8A9C", VA = "0x43FCA9C")]
		private void ResumeTime()
		{
		}

		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0x43FCAA8", Offset = "0x43F8AA8", VA = "0x43FCAA8")]
		public FakeMediationBehaviour()
		{
		}
	}
}
