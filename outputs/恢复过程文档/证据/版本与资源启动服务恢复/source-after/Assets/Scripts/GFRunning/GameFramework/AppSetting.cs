using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GameFramework
{
	[Token(Token = "0x20002D6")]
	public class AppSetting
	{
		[Token(Token = "0x20002D7")]
		private sealed class E_00AEYM_0089_0085 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40017E8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40017E9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40017EA")]
			[FieldOffset(Offset = "0x20")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x170010B3")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60051AF")]
				[Address(RVA = "0x71226E8", Offset = "0x711E6E8", VA = "0x71226E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170010B4")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60051B1")]
				[Address(RVA = "0x7122728", Offset = "0x711E728", VA = "0x7122728", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x7121708", Offset = "0x711D708", VA = "0x7121708")]
			[DebuggerHidden]
			public E_00AEYM_0089_0085(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x7122438", Offset = "0x711E438", VA = "0x7122438", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60051AE")]
			[Address(RVA = "0x712243C", Offset = "0x711E43C", VA = "0x712243C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60051AF")]
			[Address(RVA = "0x71226E8", Offset = "0x711E6E8", VA = "0x71226E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60051B0")]
			[Address(RVA = "0x71226F0", Offset = "0x711E6F0", VA = "0x71226F0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60051B1")]
			[Address(RVA = "0x7122728", Offset = "0x711E728", VA = "0x7122728", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40017BB")]
		public const int BundleOffset = 16;

		[Token(Token = "0x40017BC")]
		public const int GameFrameRate = 60;

		[Token(Token = "0x40017BD")]
		public const string ExtName = ".unity3d";

		[Token(Token = "0x40017BE")]
		public const string FirstPackName = "firstpack.unity3d";

		[Token(Token = "0x40017BF")]
		public const string UIAtlasDir = "UIAtlas/";

		[Token(Token = "0x40017C0")]
		public const string ConfigBundleDir = "Data/Config/";

		[Token(Token = "0x40017C1")]
		public const string NewConfigBundleDir = "Data/MemoryBins/";

		[Token(Token = "0x40017C2")]
		public const string FGUIBundleDir = "FGUI/";

		[Token(Token = "0x40017C3")]
		public const string ABFiles = "ABFiles.txt";

		[Token(Token = "0x40017C4")]
		public const string VersionFile = "Version.txt";

		[Token(Token = "0x40017C5")]
		public const string BusinessModuleDir = "Script/UI/";

		[Token(Token = "0x40017C6")]
		public const string CommonGameModule = "CommonGameModule";

		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsPortrait;

		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x1")]
		public static bool IsBangs;

		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x4")]
		public static float BangsPixel;

		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x8")]
		public static bool isHeightCtrWidthFixedWidth;

		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0xC")]
		public static int GameId;

		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x10")]
		public static string Webgl_dy_RemoteURL;

		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x18")]
		public static string DynamicABFile;

		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x20")]
		public static Dictionary<string, string> DynamicABFileList;

		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x28")]
		private static string _00A5ªj_007DEv;

		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x30")]
		private static string W_00A9RS_009A_00B9;

		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x38")]
		private static bool _00A4KIa_0087W;

		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x39")]
		private static bool ª_009F_00A2_008Bk_0093;

		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0x3A")]
		private static bool _007E_007D_00BD_00B3_00B0_007B;

		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0x3B")]
		private static bool SP_0096_00B1_00BE_00B1;

		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0x3C")]
		private static bool _00A0f_0085YIY;

		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0x3D")]
		private static bool _00A6TV_0099_0084z;

		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0x40")]
		private static MineGameModel xy_00ACµ_0092n;

		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0x48")]
		private static string w_0087_00AC_008E_00A2_00A9;

		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0x50")]
		public static bool IsVersionPackage;

		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0x51")]
		public static bool IsIgnoreSDK;

		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0x54")]
		private static EReleasePlatform xvj_00B2_005Bs;

		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0x58")]
		private static bool _00AC_00B8ÀFuº;

		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0x59")]
		private static bool a_00B2_00B7ÂD_0086;

		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0x60")]
		public static ProjectSetting PSetting;

		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0x68")]
		public static string appBuildTestApkVer;

		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x70")]
		private static EPartnerCompany t_00B2À_005B_0093_00A4;

		[Token(Token = "0x40017E1")]
		public const string BundleResDir = "Assets/GameRes/BundleRes/";

		[Token(Token = "0x40017E2")]
		public const string BundleArtResDir = "Assets/GameRes/ArtRes/";

		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x78")]
		public static string[] BundleArtResFolders;

		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0x80")]
		private static bool ByU_00B4_009F_0091;

		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0x81")]
		private static bool _00B1_009E_007B_0082ix;

		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0x82")]
		private static bool _00A4_0088Wµ_005B_0093;

		[Token(Token = "0x40017E7")]
		[FieldOffset(Offset = "0x83")]
		private static bool ºMxY_0090_008E;

		[Token(Token = "0x17001099")]
		public static string gameCode
		{
			[Token(Token = "0x6005179")]
			[Address(RVA = "0x71209C8", Offset = "0x711C9C8", VA = "0x71209C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600518F")]
			[Address(RVA = "0x71211C8", Offset = "0x711D1C8", VA = "0x71211C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700109A")]
		public static bool UseNewRes
		{
			[Token(Token = "0x6005195")]
			[Address(RVA = "0x7121424", Offset = "0x711D424", VA = "0x7121424")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005165")]
			[Address(RVA = "0x711FB14", Offset = "0x711BB14", VA = "0x711FB14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700109B")]
		public static bool IsSmallPackage
		{
			[Token(Token = "0x600517A")]
			[Address(RVA = "0x7120A20", Offset = "0x711CA20", VA = "0x7120A20")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005185")]
			[Address(RVA = "0x7120EDC", Offset = "0x711CEDC", VA = "0x7120EDC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700109C")]
		public static bool AutoSaveData
		{
			[Token(Token = "0x600519C")]
			[Address(RVA = "0x7121B00", Offset = "0x711DB00", VA = "0x7121B00")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600519F")]
			[Address(RVA = "0x7121E38", Offset = "0x711DE38", VA = "0x7121E38")]
			internal set
			{
				_00A0H_00A1_00A5a_0060(value);
			}
		}

		[Token(Token = "0x1700109D")]
		public static bool UNT
		{
			[Token(Token = "0x6005169")]
			[Address(RVA = "0x712036C", Offset = "0x711C36C", VA = "0x712036C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600517D")]
			[Address(RVA = "0x7120B38", Offset = "0x711CB38", VA = "0x7120B38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700109E")]
		public static bool IsUseMemoryPack
		{
			[Token(Token = "0x6005163")]
			[Address(RVA = "0x711F924", Offset = "0x711B924", VA = "0x711F924")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005160")]
			[Address(RVA = "0x711F768", Offset = "0x711B768", VA = "0x711F768")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700109F")]
		public static bool IsKeWan
		{
			[Token(Token = "0x6005168")]
			[Address(RVA = "0x7120314", Offset = "0x711C314", VA = "0x7120314")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005182")]
			[Address(RVA = "0x7120DC0", Offset = "0x711CDC0", VA = "0x7120DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010A0")]
		public static string MineGameName
		{
			[Token(Token = "0x6005187")]
			[Address(RVA = "0x711FFA8", Offset = "0x711BFA8", VA = "0x711FFA8")]
			get
			{
            if (string.IsNullOrEmpty(_00A5ªj_007DEv))
            {
                string[] parts = UnityEngine.Application.dataPath.Split('/');
                _00A5ªj_007DEv = parts[parts.Length - 2];
            }
            return _00A5ªj_007DEv;
		}
			[Token(Token = "0x600518A")]
			[Address(RVA = "0x7121044", Offset = "0x711D044", VA = "0x7121044")]
			set
			{
            _00A5ªj_007DEv = value;
		}
		}

		[Token(Token = "0x170010A1")]
		public static MineGameModel mineGameModel
		{
			[Token(Token = "0x60051A4")]
			[Address(RVA = "0x7121FA4", Offset = "0x711DFA4", VA = "0x7121FA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600516F")]
			[Address(RVA = "0x71205AC", Offset = "0x711C5AC", VA = "0x71205AC")]
			internal set
			{
				_00A4_00BD_00A0_0084j_00AD(value);
			}
		}

		[Token(Token = "0x170010A2")]
		public static string mineGameModelName
		{
			[Token(Token = "0x6005193")]
			[Address(RVA = "0x7121374", Offset = "0x711D374", VA = "0x7121374")]
			get
			{
				return null;
			}
			[Token(Token = "0x600516D")]
			[Address(RVA = "0x71204F4", Offset = "0x711C4F4", VA = "0x71204F4")]
			internal set
			{
				_0081S_0060_00A3_0096_009E(value);
			}
		}

		[Token(Token = "0x170010A3")]
		public static EReleasePlatform EPlatformType
		{
			[Token(Token = "0x6005196")]
			[Address(RVA = "0x712147C", Offset = "0x711D47C", VA = "0x712147C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60051A3")]
			[Address(RVA = "0x7121F48", Offset = "0x711DF48", VA = "0x7121F48")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010A4")]
		public static bool IsReleaseAB
		{
			[Token(Token = "0x6005175")]
			[Address(RVA = "0x71207C8", Offset = "0x711C7C8", VA = "0x71207C8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600519E")]
			[Address(RVA = "0x7121DD8", Offset = "0x711DDD8", VA = "0x7121DD8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010A5")]
		public static bool IsGameColletion
		{
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x7120F3C", Offset = "0x711CF3C", VA = "0x7120F3C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60051AB")]
			[Address(RVA = "0x71223D8", Offset = "0x711E3D8", VA = "0x71223D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010A6")]
		public static EPartnerCompany EPartnerCompanyType
		{
			[Token(Token = "0x60051A1")]
			[Address(RVA = "0x7121E98", Offset = "0x711DE98", VA = "0x7121E98")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005161")]
			[Address(RVA = "0x711F7C8", Offset = "0x711B7C8", VA = "0x711F7C8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170010A7")]
		public static string PlatformName
		{
			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x711FF58", Offset = "0x711BF58", VA = "0x711FF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010A8")]
		public static string ExportResBaseDir
		{
			[Token(Token = "0x600517F")]
			[Address(RVA = "0x7120BF8", Offset = "0x711CBF8", VA = "0x7120BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010A9")]
		public static string PersistentDataPath
		{
			[Token(Token = "0x6005180")]
			[Address(RVA = "0x7120CA0", Offset = "0x711CCA0", VA = "0x7120CA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AA")]
		public static string DataPath
		{
			[Token(Token = "0x600516B")]
			[Address(RVA = "0x7120424", Offset = "0x711C424", VA = "0x7120424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AB")]
		public static string PersistentDataURL
		{
			[Token(Token = "0x6005181")]
			[Address(RVA = "0x7120D4C", Offset = "0x711CD4C", VA = "0x7120D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AC")]
		public static string StreamingAssetsURL
		{
			[Token(Token = "0x600519A")]
			[Address(RVA = "0x7121788", Offset = "0x711D788", VA = "0x7121788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AD")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x6005190")]
			[Address(RVA = "0x7120154", Offset = "0x711C154", VA = "0x7120154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AE")]
		public static string ABStreamingAssetsPath
		{
			[Token(Token = "0x60051AA")]
			[Address(RVA = "0x71221B4", Offset = "0x711E1B4", VA = "0x71221B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010AF")]
		public static bool IsXYXNativeMode
		{
			[Token(Token = "0x600519B")]
			[Address(RVA = "0x712194C", Offset = "0x711D94C", VA = "0x712194C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170010B0")]
		public static bool IsDYResMode_Web
		{
			[Token(Token = "0x60051A0")]
			[Address(RVA = "0x711FD50", Offset = "0x711BD50", VA = "0x711FD50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170010B1")]
		public static bool IsXYXEnvironment
		{
			[Token(Token = "0x600518E")]
			[Address(RVA = "0x71171F4", Offset = "0x71131F4", VA = "0x71171F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170010B2")]
		public static bool IsTuanJie
		{
			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x7122054", Offset = "0x711E054", VA = "0x7122054")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600517E")]
			[Address(RVA = "0x7120B98", Offset = "0x711CB98", VA = "0x7120B98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[SpecialName]
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x711F4A8", Offset = "0x711B4A8", VA = "0x711F4A8")]
		public static void FZº_00BEV_00B6(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x711F508", Offset = "0x711B508", VA = "0x711F508")]
		public static bool _008B_00A9_0087_00B6_009B_0093()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x711F560", Offset = "0x711B560", VA = "0x711F560")]
		public static string _00B0ºE_008BT_009C()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x711F5B8", Offset = "0x711B5B8", VA = "0x711F5B8")]
		public static bool IL_007En_0083_0088()
		{
			return default;
		}

		[Token(Token = "0x6005162")]
		[Address(RVA = "0x711F824", Offset = "0x711B824", VA = "0x711F824")]
		public static void SetCultureBasedOnSetting()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005166")]
		[Address(RVA = "0x711FB74", Offset = "0x711BB74", VA = "0x711FB74")]
		public static string _008AFOY_00B3_008B()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005167")]
		[Address(RVA = "0x71202B4", Offset = "0x711C2B4", VA = "0x71202B4")]
		public static void U_00B0_00A3E_00A7_008D(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x71203C4", Offset = "0x711C3C4", VA = "0x71203C4")]
		public static void _00AC_0088J_007EKÀ(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x7120494", Offset = "0x711C494", VA = "0x7120494")]
		public static void _0088_00AC_00ACQzL(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600516D")]
		[Address(RVA = "0x71204F4", Offset = "0x711C4F4", VA = "0x71204F4")]
		internal static void _0081S_0060_00A3_0096_009E(string _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x7120550", Offset = "0x711C550", VA = "0x7120550")]
		internal static void _009Blm_00A9bM(string _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600516F")]
		[Address(RVA = "0x71205AC", Offset = "0x711C5AC", VA = "0x71205AC")]
		internal static void _00A4_00BD_00A0_0084j_00AD(MineGameModel _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x7120608", Offset = "0x711C608", VA = "0x7120608")]
		public static string _0084x_0094_00B7D_00A1()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x71206B0", Offset = "0x711C6B0", VA = "0x71206B0")]
		public static bool _00AE_00B2s_00B7SU()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x7120708", Offset = "0x711C708", VA = "0x7120708")]
		public static string _0081_00A3_00A6CbÁ()
		{
			return null;
		}

		[Token(Token = "0x6005173")]
		[Address(RVA = "0x7120760", Offset = "0x711C760", VA = "0x7120760")]
		public AppSetting()
		{
		}

		[SpecialName]
		[Token(Token = "0x6005174")]
		[Address(RVA = "0x7120768", Offset = "0x711C768", VA = "0x7120768")]
		public static void NRvxUÁ(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x7120820", Offset = "0x711C820", VA = "0x7120820")]
		public static bool S_00A6_00B3p_005Bk()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005177")]
		[Address(RVA = "0x7120878", Offset = "0x711C878", VA = "0x7120878")]
		public static string _008BmGTy_00BE()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005178")]
		[Address(RVA = "0x7120920", Offset = "0x711C920", VA = "0x7120920")]
		public static string _005D_0081_00B2R_00B1_00B3()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x7120A78", Offset = "0x711CA78", VA = "0x7120A78")]
		public static void _009D_007FJ_00BFD_00AD(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x7120AD8", Offset = "0x711CAD8", VA = "0x7120AD8")]
		public static void _00ABp_0098_00B9_009ET(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005183")]
		[Address(RVA = "0x7120E20", Offset = "0x711CE20", VA = "0x7120E20")]
		internal static void B_00AE_0088UÂ_0084(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005184")]
		[Address(RVA = "0x7120E80", Offset = "0x711CE80", VA = "0x7120E80")]
		public static void _0082_00AC_00A6q_00B4_00BC(EPartnerCompany _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005188")]
		[Address(RVA = "0x7120F94", Offset = "0x711CF94", VA = "0x7120F94")]
		public static bool _00A4B_005DpKe()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005189")]
		[Address(RVA = "0x7120FEC", Offset = "0x711CFEC", VA = "0x7120FEC")]
		public static bool _00AEVh_00AE_00B6_00BD()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x600518B")]
		[Address(RVA = "0x71210A0", Offset = "0x711D0A0", VA = "0x71210A0")]
		public static string U_00B3_0094P_00A7_00BB()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x7121110", Offset = "0x711D110", VA = "0x7121110")]
		public static bool _00BE_0093_0088_00A3l_00BE()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x7121168", Offset = "0x711D168", VA = "0x7121168")]
		public static void _007EK_007B_00B0_00AE_00A1(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005191")]
		[Address(RVA = "0x71212C4", Offset = "0x711D2C4", VA = "0x71212C4")]
		public static bool _00BC_00A7GY_008Dp()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005192")]
		[Address(RVA = "0x712131C", Offset = "0x711D31C", VA = "0x712131C")]
		public static bool _00A9iªu_00B1_0088()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x71213CC", Offset = "0x711D3CC", VA = "0x71213CC")]
		public static bool _00BD_00B3C_009Dµ_0092()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x71214D4", Offset = "0x711D4D4", VA = "0x71214D4")]
		public static string o_00A9_009E_0083_0086_008F()
		{
			return null;
		}

		[Token(Token = "0x6005198")]
		[Address(RVA = "0x71216B0", Offset = "0x711D6B0", VA = "0x71216B0")]
		[IteratorStateMachine(typeof(E_00AEYM_0089_0085))]
		internal static IEnumerator _00A0_0080_0088_00BBlY()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x7121730", Offset = "0x711D730", VA = "0x7121730")]
		public static EReleasePlatform _00AFUÂ_00A9_008Ba()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x7121B58", Offset = "0x711DB58", VA = "0x7121B58")]
		public static string M_0084y_0086On()
		{
			return null;
		}

		[Token(Token = "0x600519F")]
		[Address(RVA = "0x7121E38", Offset = "0x711DE38", VA = "0x7121E38")]
		internal static void _00A0H_00A1_00A5a_0060(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x7121EF0", Offset = "0x711DEF0", VA = "0x7121EF0")]
		public static EPartnerCompany _0080_00AFC_00A4ll()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x7121FFC", Offset = "0x711DFFC", VA = "0x7121FFC")]
		public static string ÀWy_008AµN()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60051A7")]
		[Address(RVA = "0x71220AC", Offset = "0x711E0AC", VA = "0x71220AC")]
		public static string _0091IW_008FOs()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60051A9")]
		[Address(RVA = "0x7122154", Offset = "0x711E154", VA = "0x7122154")]
		public static void _00B2_005EJ_008Awi(bool _00A3_0092T_007E_00ABc)
		{
		}
	}
}
