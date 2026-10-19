using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200032B")]
	public static class GameFrameEntry
	{
		[Token(Token = "0x200032D")]
		private sealed class _00BDW_009B_00BCC_0094
		{
			[Token(Token = "0x4001974")]
			[FieldOffset(Offset = "0x10")]
			public string GameMenuScene;

			[Token(Token = "0x4001975")]
			[FieldOffset(Offset = "0x18")]
			public string AppName;

			[Token(Token = "0x60055E2")]
			[Address(RVA = "0x715A5D0", Offset = "0x71565D0", VA = "0x715A5D0")]
			public _00BDW_009B_00BCC_0094()
			{
			}

			[Token(Token = "0x60055E3")]
			[Address(RVA = "0x715BD8C", Offset = "0x7157D8C", VA = "0x715BD8C")]
			internal void _00A3_009BDÁ_007Bf()
			{
			}
		}

		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LinkedList<GameFrameModule> y_0086A_0094F_0083;

		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x8")]
		private static bool O_00B8_005D_00A1_008B_005E;

		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x10")]
		public static string CurrAppName;

		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x18")]
		public static string GameMenuSceneName;

		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x20")]
		public static bool IsGoGameMenu;

		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x28")]
		public static Action disposableActions;

		[Token(Token = "0x400196E")]
		private const int _008AQµwY_00A9 = 96;

		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x30")]
		private static int _00A3Z_00A1_00AF_007Fa;

		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x38")]
		private static LinkedListNode<GameFrameModule> _00A1v_005DN_00BBu;

		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x40")]
		private static bool TKMRk_0099;

		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x715A318", Offset = "0x7156318", VA = "0x715A318")]
		public static void PauseGame(bool _0086_0060_0097Cv_007F, bool _008Eºkh_00A7_005E = true)
		{
		}

		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x715A4DC", Offset = "0x71564DC", VA = "0x715A4DC")]
		public static bool IsPauseGame()
		{
			return default;
		}

		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x715A500", Offset = "0x7156500", VA = "0x715A500")]
		public static void StartGame(string Â_005EO_0091W_008D, string cu_0089_00A3_009FN = "")
		{
		}

		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x715A5D8", Offset = "0x71565D8", VA = "0x715A5D8")]
		public static void CommonSettings()
		{
		}

		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x715A82C", Offset = "0x715682C", VA = "0x715A82C")]
		public static void StartOtherEngineGame(int _009Az_007CICB, string _00A3_00A9h_007Fqn)
		{
		}

		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x715A9F4", Offset = "0x71569F4", VA = "0x715A9F4")]
		public static void BackToGameGameMenu()
		{
		}

		[Token(Token = "0x60055CE")]
		[Address(RVA = "0x715AAE8", Offset = "0x7156AE8", VA = "0x715AAE8")]
		public static void EnterHomeUI()
		{
		}

		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x715ABBC", Offset = "0x7156BBC", VA = "0x715ABBC")]
		private static void _0085_0083s_00B9JJ()
		{
		}

		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x715ACEC", Offset = "0x7156CEC", VA = "0x715ACEC")]
		private static bool _0082_0086_007F_007D_00ABF(string Â_005EO_0091W_008D)
		{
			return default;
		}

		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x715AE3C", Offset = "0x7156E3C", VA = "0x715AE3C")]
		public static Queue<GameFrameModule> GetAllModule()
		{
			return null;
		}

		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x715AF54", Offset = "0x7156F54", VA = "0x715AF54")]
		public static void Initialize(GameFrameModule _009D_007FOz_00AFs, Action _00B7_0060_0084VQI, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x715AF7C", Offset = "0x7156F7C", VA = "0x715AF7C")]
		public static void Start()
		{
		}

		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x715B144", Offset = "0x7157144", VA = "0x715B144")]
		public static void ResourcesModuleUpdate(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x715B260", Offset = "0x7157260", VA = "0x715B260")]
		public static void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x715B350", Offset = "0x7157350", VA = "0x715B350")]
		public static void LateUpdate()
		{
		}

		[Token(Token = "0x60055D7")]
		public static void ShutdownModule<T>() where T : class
		{
		}

		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x715B428", Offset = "0x7157428", VA = "0x715B428")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x60055D9")]
		public static T GetModule<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60055DA")]
		public static T HaveModule<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60055DB")]
		private static Type K_0086_009C_0083_0084_0089<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x715B680", Offset = "0x7157680", VA = "0x715B680")]
		private static GameFrameModule K_007E_005E_0098_00ABb(Type kF_00A8_008F_007C_00A5)
		{
			return null;
		}

		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x715B7C8", Offset = "0x71577C8", VA = "0x715B7C8")]
		private static GameFrameModule _00B9X_0081_0093_0095_009B(Type kF_00A8_008F_007C_00A5)
		{
			return null;
		}
	}
}
