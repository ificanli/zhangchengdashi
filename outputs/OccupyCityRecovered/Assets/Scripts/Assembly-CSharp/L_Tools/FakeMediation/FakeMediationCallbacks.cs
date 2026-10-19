using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FCD")]
	public class FakeMediationCallbacks
	{
		[Token(Token = "0x4006BD0")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action m_OnInterstitialAdLoadedEvent;

		[Token(Token = "0x4006BD1")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		private Action m_OnInterstitialAdClickedEvent;

		[Token(Token = "0x4006BD2")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action m_OnInterstitialAdHiddenEvent;

		[Token(Token = "0x4006BD3")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private Action m_OnInterstitialAdRevenuePaidEvent;

		[Token(Token = "0x4006BD4")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		private Action m_OnRewardedAdLoadedEvent;

		[Token(Token = "0x4006BD5")]
		[FieldOffset(Offset = "0x38")]
		[CompilerGenerated]
		private Action m_OnRewardedAdClickedEvent;

		[Token(Token = "0x4006BD6")]
		[FieldOffset(Offset = "0x40")]
		[CompilerGenerated]
		private Action<bool> m_OnRewardedAdHiddenEvent;

		[Token(Token = "0x4006BD7")]
		[FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		private Action m_OnRewardedAdRevenuePaidEvent;

		[Token(Token = "0x4006BD8")]
		[FieldOffset(Offset = "0x50")]
		[CompilerGenerated]
		private Action m_OnAppOpenAdLoadedEvent;

		[Token(Token = "0x4006BD9")]
		[FieldOffset(Offset = "0x58")]
		[CompilerGenerated]
		private Action m_OnAppOpenAdClickedEvent;

		[Token(Token = "0x4006BDA")]
		[FieldOffset(Offset = "0x60")]
		[CompilerGenerated]
		private Action m_OnAppOpenAdHiddenEvent;

		[Token(Token = "0x4006BDB")]
		[FieldOffset(Offset = "0x68")]
		[CompilerGenerated]
		private Action m_OnAppOpenAdRevenuePaidEvent;

		[Token(Token = "0x4006BDC")]
		[FieldOffset(Offset = "0x70")]
		[CompilerGenerated]
		private Action m_OnBannerAdLoadedEvent;

		[Token(Token = "0x4006BDD")]
		[FieldOffset(Offset = "0x78")]
		[CompilerGenerated]
		private Action m_OnBannerAdClickedEvent;

		[Token(Token = "0x4006BDE")]
		[FieldOffset(Offset = "0x80")]
		[CompilerGenerated]
		private Action m_OnBannerAdRevenuePaidEvent;

		[Token(Token = "0x4006BDF")]
		[FieldOffset(Offset = "0x88")]
		[CompilerGenerated]
		private Action m_OnMRecAdLoadedEvent;

		[Token(Token = "0x4006BE0")]
		[FieldOffset(Offset = "0x90")]
		[CompilerGenerated]
		private Action m_OnMRecAdClickedEvent;

		[Token(Token = "0x4006BE1")]
		[FieldOffset(Offset = "0x98")]
		[CompilerGenerated]
		private Action m_OnMRecAdRevenuePaidEvent;

		[Token(Token = "0x4006BE2")]
		[FieldOffset(Offset = "0xA0")]
		[CompilerGenerated]
		private Action m_OnNativeAdLoadedEvent;

		[Token(Token = "0x4006BE3")]
		[FieldOffset(Offset = "0xA8")]
		[CompilerGenerated]
		private Action m_OnNativeAdDisplayedEvent;

		[Token(Token = "0x4006BE4")]
		[FieldOffset(Offset = "0xB0")]
		[CompilerGenerated]
		private Action m_OnNativeAdClickedEvent;

		[Token(Token = "0x4006BE5")]
		[FieldOffset(Offset = "0xB8")]
		[CompilerGenerated]
		private Action m_OnNativeAdRevenuePaidEvent;

		[Token(Token = "0x4006BE6")]
		[FieldOffset(Offset = "0xC0")]
		[CompilerGenerated]
		private Action m_OnNativeAdHiddenEvent;

		[Token(Token = "0x14000016")]
		public event Action OnInterstitialAdLoadedEvent
		{
			[Token(Token = "0x6005E85")]
			[Address(RVA = "0x43FCF94", Offset = "0x43F8F94", VA = "0x43FCF94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E86")]
			[Address(RVA = "0x43FD030", Offset = "0x43F9030", VA = "0x43FD030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action OnInterstitialAdClickedEvent
		{
			[Token(Token = "0x6005E87")]
			[Address(RVA = "0x43FD0CC", Offset = "0x43F90CC", VA = "0x43FD0CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E88")]
			[Address(RVA = "0x43FD168", Offset = "0x43F9168", VA = "0x43FD168")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action OnInterstitialAdHiddenEvent
		{
			[Token(Token = "0x6005E89")]
			[Address(RVA = "0x43FD204", Offset = "0x43F9204", VA = "0x43FD204")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E8A")]
			[Address(RVA = "0x43FD2A0", Offset = "0x43F92A0", VA = "0x43FD2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event Action OnInterstitialAdRevenuePaidEvent
		{
			[Token(Token = "0x6005E8B")]
			[Address(RVA = "0x43FD33C", Offset = "0x43F933C", VA = "0x43FD33C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E8C")]
			[Address(RVA = "0x43FD3D8", Offset = "0x43F93D8", VA = "0x43FD3D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event Action OnRewardedAdLoadedEvent
		{
			[Token(Token = "0x6005E8D")]
			[Address(RVA = "0x43FD474", Offset = "0x43F9474", VA = "0x43FD474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E8E")]
			[Address(RVA = "0x43FD510", Offset = "0x43F9510", VA = "0x43FD510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event Action OnRewardedAdClickedEvent
		{
			[Token(Token = "0x6005E8F")]
			[Address(RVA = "0x43FD5AC", Offset = "0x43F95AC", VA = "0x43FD5AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E90")]
			[Address(RVA = "0x43FD648", Offset = "0x43F9648", VA = "0x43FD648")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event Action<bool> OnRewardedAdHiddenEvent
		{
			[Token(Token = "0x6005E91")]
			[Address(RVA = "0x43FD6E4", Offset = "0x43F96E4", VA = "0x43FD6E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E92")]
			[Address(RVA = "0x43FD794", Offset = "0x43F9794", VA = "0x43FD794")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event Action OnRewardedAdRevenuePaidEvent
		{
			[Token(Token = "0x6005E93")]
			[Address(RVA = "0x43FD844", Offset = "0x43F9844", VA = "0x43FD844")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E94")]
			[Address(RVA = "0x43FD8E0", Offset = "0x43F98E0", VA = "0x43FD8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event Action OnAppOpenAdLoadedEvent
		{
			[Token(Token = "0x6005E95")]
			[Address(RVA = "0x43FD97C", Offset = "0x43F997C", VA = "0x43FD97C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E96")]
			[Address(RVA = "0x43FDA18", Offset = "0x43F9A18", VA = "0x43FDA18")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action OnAppOpenAdClickedEvent
		{
			[Token(Token = "0x6005E97")]
			[Address(RVA = "0x43FDAB4", Offset = "0x43F9AB4", VA = "0x43FDAB4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E98")]
			[Address(RVA = "0x43FDB50", Offset = "0x43F9B50", VA = "0x43FDB50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event Action OnAppOpenAdHiddenEvent
		{
			[Token(Token = "0x6005E99")]
			[Address(RVA = "0x43FDBEC", Offset = "0x43F9BEC", VA = "0x43FDBEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E9A")]
			[Address(RVA = "0x43FDC88", Offset = "0x43F9C88", VA = "0x43FDC88")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event Action OnAppOpenAdRevenuePaidEvent
		{
			[Token(Token = "0x6005E9B")]
			[Address(RVA = "0x43FDD24", Offset = "0x43F9D24", VA = "0x43FDD24")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E9C")]
			[Address(RVA = "0x43FDDC0", Offset = "0x43F9DC0", VA = "0x43FDDC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event Action OnBannerAdLoadedEvent
		{
			[Token(Token = "0x6005E9D")]
			[Address(RVA = "0x43FDE5C", Offset = "0x43F9E5C", VA = "0x43FDE5C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005E9E")]
			[Address(RVA = "0x43FDEF8", Offset = "0x43F9EF8", VA = "0x43FDEF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event Action OnBannerAdClickedEvent
		{
			[Token(Token = "0x6005E9F")]
			[Address(RVA = "0x43FDF94", Offset = "0x43F9F94", VA = "0x43FDF94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EA0")]
			[Address(RVA = "0x43FE030", Offset = "0x43FA030", VA = "0x43FE030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event Action OnBannerAdRevenuePaidEvent
		{
			[Token(Token = "0x6005EA1")]
			[Address(RVA = "0x43FE0CC", Offset = "0x43FA0CC", VA = "0x43FE0CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EA2")]
			[Address(RVA = "0x43FE168", Offset = "0x43FA168", VA = "0x43FE168")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public event Action OnMRecAdLoadedEvent
		{
			[Token(Token = "0x6005EA3")]
			[Address(RVA = "0x43FE204", Offset = "0x43FA204", VA = "0x43FE204")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EA4")]
			[Address(RVA = "0x43FE2A0", Offset = "0x43FA2A0", VA = "0x43FE2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public event Action OnMRecAdClickedEvent
		{
			[Token(Token = "0x6005EA5")]
			[Address(RVA = "0x43FE33C", Offset = "0x43FA33C", VA = "0x43FE33C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EA6")]
			[Address(RVA = "0x43FE3D8", Offset = "0x43FA3D8", VA = "0x43FE3D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000027")]
		public event Action OnMRecAdRevenuePaidEvent
		{
			[Token(Token = "0x6005EA7")]
			[Address(RVA = "0x43FE474", Offset = "0x43FA474", VA = "0x43FE474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EA8")]
			[Address(RVA = "0x43FE510", Offset = "0x43FA510", VA = "0x43FE510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public event Action OnNativeAdLoadedEvent
		{
			[Token(Token = "0x6005EA9")]
			[Address(RVA = "0x43FE5AC", Offset = "0x43FA5AC", VA = "0x43FE5AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EAA")]
			[Address(RVA = "0x43FE648", Offset = "0x43FA648", VA = "0x43FE648")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event Action OnNativeAdDisplayedEvent
		{
			[Token(Token = "0x6005EAB")]
			[Address(RVA = "0x43FE6E4", Offset = "0x43FA6E4", VA = "0x43FE6E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EAC")]
			[Address(RVA = "0x43FE780", Offset = "0x43FA780", VA = "0x43FE780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event Action OnNativeAdClickedEvent
		{
			[Token(Token = "0x6005EAD")]
			[Address(RVA = "0x43FE81C", Offset = "0x43FA81C", VA = "0x43FE81C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EAE")]
			[Address(RVA = "0x43FE8B8", Offset = "0x43FA8B8", VA = "0x43FE8B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event Action OnNativeAdRevenuePaidEvent
		{
			[Token(Token = "0x6005EAF")]
			[Address(RVA = "0x43FE954", Offset = "0x43FA954", VA = "0x43FE954")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EB0")]
			[Address(RVA = "0x43FE9F0", Offset = "0x43FA9F0", VA = "0x43FE9F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event Action OnNativeAdHiddenEvent
		{
			[Token(Token = "0x6005EB1")]
			[Address(RVA = "0x43FEA8C", Offset = "0x43FAA8C", VA = "0x43FEA8C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005EB2")]
			[Address(RVA = "0x43FEB28", Offset = "0x43FAB28", VA = "0x43FEB28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x43FC4D0", Offset = "0x43F84D0", VA = "0x43FC4D0")]
		public void InvokeOnInterstitialAdLoaded()
		{
		}

		[Token(Token = "0x6005EB4")]
		[Address(RVA = "0x43FEBC4", Offset = "0x43FABC4", VA = "0x43FEBC4")]
		public void InvokeOnInterstitialAdClicked()
		{
		}

		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x43FEBE0", Offset = "0x43FABE0", VA = "0x43FEBE0")]
		public void InvokeOnInterstitialAdHidden()
		{
		}

		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x43FC5EC", Offset = "0x43F85EC", VA = "0x43FC5EC")]
		public void InvokeOnInterstitialAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x43FC62C", Offset = "0x43F862C", VA = "0x43FC62C")]
		public void InvokeOnRewardedAdLoaded()
		{
		}

		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x43FEBFC", Offset = "0x43FABFC", VA = "0x43FEBFC")]
		public void InvokeOnRewardedAdClicked()
		{
		}

		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x43FEC18", Offset = "0x43FAC18", VA = "0x43FEC18")]
		public void InvokeOnRewardedAdHidden(bool watched)
		{
		}

		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0x43FEC38", Offset = "0x43FAC38", VA = "0x43FEC38")]
		public void InvokeOnRewardedAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0x43FC790", Offset = "0x43F8790", VA = "0x43FC790")]
		public void InvokeOnAppOpenAdLoaded()
		{
		}

		[Token(Token = "0x6005EBC")]
		[Address(RVA = "0x43FEC54", Offset = "0x43FAC54", VA = "0x43FEC54")]
		public void InvokeOnAppOpenAdClicked()
		{
		}

		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0x43FEC70", Offset = "0x43FAC70", VA = "0x43FEC70")]
		public void InvokeOnAppOpenAdHidden()
		{
		}

		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0x43FC808", Offset = "0x43F8808", VA = "0x43FC808")]
		public void InvokeOnAppOpenAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0x43FC314", Offset = "0x43F8314", VA = "0x43FC314")]
		public void InvokeOnBannerAdLoaded()
		{
		}

		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0x43FEC8C", Offset = "0x43FAC8C", VA = "0x43FEC8C")]
		public void InvokeOnBannerAdClicked()
		{
		}

		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0x43FCF10", Offset = "0x43F8F10", VA = "0x43FCF10")]
		public void InvokeOnBannerAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0x43FC9DC", Offset = "0x43F89DC", VA = "0x43FC9DC")]
		public void InvokeOnMRecAdLoaded()
		{
		}

		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0x43FECA8", Offset = "0x43FACA8", VA = "0x43FECA8")]
		public void InvokeOnMRecAdClicked()
		{
		}

		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0x43FCA68", Offset = "0x43F8A68", VA = "0x43FCA68")]
		public void InvokeOnMRecAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0x43FC848", Offset = "0x43F8848", VA = "0x43FC848")]
		public void InvokeOnNativeAdLoaded()
		{
		}

		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0x43FC920", Offset = "0x43F8920", VA = "0x43FC920")]
		public void InvokeOnNativeAdDisplayed()
		{
		}

		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x43FECC4", Offset = "0x43FACC4", VA = "0x43FECC4")]
		public void InvokeOnNativeAdClicked()
		{
		}

		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0x43FC99C", Offset = "0x43F899C", VA = "0x43FC99C")]
		public void InvokeOnNativeAdHidden()
		{
		}

		[Token(Token = "0x6005EC9")]
		[Address(RVA = "0x43FC93C", Offset = "0x43F893C", VA = "0x43FC93C")]
		public void InvokeOnNativeAdRevenuePaid()
		{
		}

		[Token(Token = "0x6005ECA")]
		[Address(RVA = "0x43FECE0", Offset = "0x43FACE0", VA = "0x43FECE0")]
		public FakeMediationCallbacks()
		{
		}
	}
}
