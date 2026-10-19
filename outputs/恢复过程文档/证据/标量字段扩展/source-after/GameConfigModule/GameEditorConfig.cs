using Il2CppDummyDll;
using UnityEngine;

namespace GameConfigModule
{
	[Token(Token = "0x2000217")]
	public class GameEditorConfig : ScriptableObject
	{
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool enableTutorial;

		[Token(Token = "0x4001D23")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool enableLockFeature;

		[Token(Token = "0x4001D24")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool enableTutorialDataSave;

		[Token(Token = "0x4001D25")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool enableAutoGeneratePath;

		[Token(Token = "0x4001D26")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool isEnableDebug;

		[Token(Token = "0x4001D27")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool useEmailSignIn;

		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool iapTest;

		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x1F")]
		public bool enableBackgroundDetection;

		[Token(Token = "0x4001D2A")]
		[FieldOffset(Offset = "0x20")]
		public bool CheckNet;

		[Token(Token = "0x4001D2B")]
		[FieldOffset(Offset = "0x21")]
		public bool NewInterstitialABiOSIsB;

		[Token(Token = "0x4001D2C")]
		[FieldOffset(Offset = "0x22")]
		public bool ChainRewards2ABIsOn;

		[Token(Token = "0x4001D2D")]
		[FieldOffset(Offset = "0x23")]
		public bool AbilitiesInAdvanceIsBTest;

		[Token(Token = "0x4001D2E")]
		[FieldOffset(Offset = "0x24")]
		public bool ChestImprove01;

		[Token(Token = "0x4001D2F")]
		[FieldOffset(Offset = "0x25")]
		public bool GameTutorial;

		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x26")]
		public bool ShopImproveV1;

		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("0=A组(Control组), 1=B组, 2=C组")]
		[Range(0f, 2f)]
		public int GamePlayImprove01Variant;

		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x2C")]
		public bool GoldMinePriceV2;

		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x2D")]
		public bool HigherViewV2;

		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("GamePlayImproveV2Variant：0 = Control, 1 = ab_1（少量难度调整）, 2 = ab_2（大量难度调整）")]
		[Range(0f, 2f)]
		public int GamePlayImproveV2Variant;

		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x34")]
		public bool GameCenterIsBTest;

		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x35")]
		public bool NewArtifactsPlay;

		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x36")]
		public bool StarterPackImproveV1ABIsOn;

		[Token(Token = "0x4001D38")]
		[FieldOffset(Offset = "0x37")]
		public bool WeeklyHeroPackImproveV1;

		[Token(Token = "0x170000A7")]
		public bool EnableTutorial
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x4196684", Offset = "0x4192684", VA = "0x4196684")]
			get
			{
				return enableTutorial;
			}
		}

		[Token(Token = "0x170000A8")]
		public bool EnableLockFeature
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x419668C", Offset = "0x419268C", VA = "0x419668C")]
			get
			{
				return enableLockFeature;
			}
		}

		[Token(Token = "0x170000A9")]
		public bool EnableTutorialDataSave
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x4196694", Offset = "0x4192694", VA = "0x4196694")]
			get
			{
				return enableTutorialDataSave;
			}
		}

		[Token(Token = "0x170000AA")]
		public bool EnableAutoGeneratePath
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x419669C", Offset = "0x419269C", VA = "0x419669C")]
			get
			{
				return enableAutoGeneratePath;
			}
		}

		[Token(Token = "0x170000AB")]
		public bool IsEnableDebug
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x41966A4", Offset = "0x41926A4", VA = "0x41966A4")]
			get
			{
				return isEnableDebug;
			}
		}

		[Token(Token = "0x170000AC")]
		public bool IAPTest
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x41966AC", Offset = "0x41926AC", VA = "0x41966AC")]
			get
			{
				return iapTest;
			}
		}

		[Token(Token = "0x170000AD")]
		public bool UseEmailSignIn
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x41966B4", Offset = "0x41926B4", VA = "0x41966B4")]
			get
			{
				return useEmailSignIn;
			}
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x41966BC", Offset = "0x41926BC", VA = "0x41966BC")]
		public GameEditorConfig()
		{
		}
	}
}
