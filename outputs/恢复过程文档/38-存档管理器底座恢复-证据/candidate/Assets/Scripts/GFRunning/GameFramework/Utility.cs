using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using GameFramework.Obfuscator;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x20003D6")]
	[Confuse]
	public static class Utility
	{
		[Token(Token = "0x20003D7")]
		public static class AssemblyUtility
		{
			[Token(Token = "0x4001CB1")]
			[FieldOffset(Offset = "0x0")]
			private static Dictionary<string, Assembly> _00A2_0090qª_009Bº;

			[Token(Token = "0x6006008")]
			[Address(RVA = "0x71E1B58", Offset = "0x71DDB58", VA = "0x71E1B58")]
			public static Assembly LoadAssembly(string _008DtSh_005Dq)
			{
    Assembly assembly;
    if (!_00A2_0090qª_009Bº.TryGetValue(_008DtSh_005Dq, out assembly))
    {
        assembly = Assembly.Load(_008DtSh_005Dq);
        if (assembly != null)
            _00A2_0090qª_009Bº.Add(_008DtSh_005Dq, assembly);
    }

    return assembly;
}

			[Token(Token = "0x6006009")]
			[Address(RVA = "0x71E1D78", Offset = "0x71DDD78", VA = "0x71E1D78")]
			public static Assembly LoadCSharpAssembly()
			{
    Assembly assembly = LoadAssembly("Assembly-CSharp");
    if (assembly == null)
    {
        UnityEngine.Debug.LogError("加载C#程序集错误");
        return null;
    }

    return assembly;
}

[Token(Token = "0x600600A")]
[Address(RVA = "0x71E1E44", Offset = "0x71DDE44", VA = "0x71E1E44")]
static AssemblyUtility()
{
    _00A2_0090qª_009Bº = new Dictionary<string, Assembly>();
}		}

		[Token(Token = "0x20003D8")]
		public static class Converter
		{
			[Token(Token = "0x4001CB2")]
			private const float s_008B_00A5_00B3hA = 2.54f;

			[Token(Token = "0x4001CB3")]
			private const float L_0060_007ERZp = 50f / 127f;

			[Token(Token = "0x4001CB4")]
			[FieldOffset(Offset = "0x0")]
			private static float a_00BEhjM_00A0;

			[Token(Token = "0x1700116B")]
			public static float ScreenDpi
			{
				[Token(Token = "0x600600B")]
				[Address(RVA = "0x71E1ED0", Offset = "0x71DDED0", VA = "0x71E1ED0")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x600600C")]
				[Address(RVA = "0x71E1F18", Offset = "0x71DDF18", VA = "0x71E1F18")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600600D")]
			[Address(RVA = "0x71E1F6C", Offset = "0x71DDF6C", VA = "0x71E1F6C")]
			public static float GetCentimetersFromPixels(float GgjRjI)
			{
				return default;
			}

			[Token(Token = "0x600600E")]
			[Address(RVA = "0x71E2018", Offset = "0x71DE018", VA = "0x71E2018")]
			public static float GetPixelsFromCentimeters(float GNB_00BEq_00BE)
			{
				return default;
			}

			[Token(Token = "0x600600F")]
			[Address(RVA = "0x71E20C4", Offset = "0x71DE0C4", VA = "0x71E20C4")]
			public static float GetInchesFromPixels(float GgjRjI)
			{
				return default;
			}

			[Token(Token = "0x6006010")]
			[Address(RVA = "0x71E2164", Offset = "0x71DE164", VA = "0x71E2164")]
			public static float GetPixelsFromInches(float _009EQZ_00B3_0097Z)
			{
				return default;
			}

			[Token(Token = "0x6006011")]
			[Address(RVA = "0x71E2204", Offset = "0x71DE204", VA = "0x71E2204")]
			public static byte[] GetBytesFromInt(int _0099UJ_00A2wg)
			{
				return null;
			}

			[Token(Token = "0x6006012")]
			[Address(RVA = "0x71E220C", Offset = "0x71DE20C", VA = "0x71E220C")]
			public static int GetIntFromBytes(byte[] lD_009F_0098_0080_00B0)
			{
				return default;
			}

			[Token(Token = "0x6006013")]
			[Address(RVA = "0x71E2218", Offset = "0x71DE218", VA = "0x71E2218")]
			public static int GetIntFromBytes(byte[] lD_009F_0098_0080_00B0, int _00AFKn_00B1_00A5a)
			{
				return default;
			}

			[Token(Token = "0x6006014")]
			[Address(RVA = "0x71E2220", Offset = "0x71DE220", VA = "0x71E2220")]
			public static string GetStringFromBytes(byte[] lD_009F_0098_0080_00B0)
			{
				return null;
			}

			[Token(Token = "0x6006015")]
			[Address(RVA = "0x71E22A4", Offset = "0x71DE2A4", VA = "0x71E22A4")]
			public static byte[] GetBytesFromString(string _008C_00A8_00A1cf_00A6)
			{
				return null;
			}

			[Token(Token = "0x6006016")]
			[Address(RVA = "0x71E22D4", Offset = "0x71DE2D4", VA = "0x71E22D4")]
			public static string GetString(byte[] _00A3_0092T_007E_00ABc)
			{
				return null;
			}

			[Token(Token = "0x6006017")]
			[Address(RVA = "0x71E22F4", Offset = "0x71DE2F4", VA = "0x71E22F4")]
			public static string GetString(byte[] _00A3_0092T_007E_00ABc, Encoding _0085À_009C_007EK_008B)
			{
				return null;
			}

			[Token(Token = "0x6006018")]
			[Address(RVA = "0x71E2388", Offset = "0x71DE388", VA = "0x71E2388")]
			public static string GetString(byte[] _00A3_0092T_007E_00ABc, int _00AFKn_00B1_00A5a, int _00ACrP_008AEz)
			{
				return null;
			}

			[Token(Token = "0x6006019")]
			[Address(RVA = "0x71E23C0", Offset = "0x71DE3C0", VA = "0x71E23C0")]
			public static string GetString(byte[] _00A3_0092T_007E_00ABc, int _00AFKn_00B1_00A5a, int _00ACrP_008AEz, Encoding _0085À_009C_007EK_008B)
			{
				return null;
			}
		}

		[Token(Token = "0x20003D9")]
		[Confuse]
		internal static class _0088_008F_00A0_007D_00AD_0090
		{
			[Token(Token = "0x4001CB5")]
			private const int r_009E_009E_00ADr_008F = 220;

			[Token(Token = "0x600601A")]
			[Address(RVA = "0x71E245C", Offset = "0x71DE45C", VA = "0x71E245C")]
			public static byte[] GetQuickXorBytes(byte[] lD_009F_0098_0080_00B0, byte[] t_00A9_008BjBt)
			{
				return null;
			}

			[Token(Token = "0x600601B")]
			[Address(RVA = "0x71E2464", Offset = "0x71DE464", VA = "0x71E2464")]
			public static byte[] GetXorBytes(byte[] lD_009F_0098_0080_00B0, byte[] t_00A9_008BjBt, int _00ACrP_008AEz = 0)
			{
				return null;
			}
		}

		[Token(Token = "0x20003DA")]
		public static class Json
		{
			[Token(Token = "0x20003DB")]
			public interface IJsonHelper
			{
				[Token(Token = "0x6006021")]
				string ToJson(object _008EBÂ_008F_00BB_008B);

				[Token(Token = "0x6006022")]
				T ToObject<T>(string º_0086_005Bfbµ);
			}

			[Token(Token = "0x4001CB6")]
			[FieldOffset(Offset = "0x0")]
			private static IJsonHelper _00B4V_009D_00A9_009E_00B8;

			[Token(Token = "0x600601C")]
			[Address(RVA = "0x71E25E8", Offset = "0x71DE5E8", VA = "0x71E25E8")]
			public static void SetJsonHelper(IJsonHelper _00B8m_00A9C_0084n)
			{
			}

			[Token(Token = "0x600601D")]
			[Address(RVA = "0x71E2634", Offset = "0x71DE634", VA = "0x71E2634")]
			public static string ToJson(object _008EBÂ_008F_00BB_008B)
			{
				return null;
			}

			[Token(Token = "0x600601E")]
			[Address(RVA = "0x71E2738", Offset = "0x71DE738", VA = "0x71E2738")]
			public static byte[] ToJsonData(object _008EBÂ_008F_00BB_008B)
			{
				return null;
			}

			[Token(Token = "0x600601F")]
			public static T ToObject<T>(string º_0086_005Bfbµ)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Utility.Json.ToObject RVA= Token=0x600601F");
}

			[Token(Token = "0x6006020")]
			public static T ToObject<T>(byte[] Ec_0087Hfs)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Utility.Json.ToObject RVA= Token=0x6006020");
}
		}

		[Token(Token = "0x20003DC")]
		public static class Nullable
		{
			[Token(Token = "0x6006023")]
			public static bool IsNullable<T>(T h_00B9_00B8_005E_00BDY)
			{
				return default;
			}

			[Token(Token = "0x6006024")]
			public static bool IsNullable<T>(T? h_00B9_00B8_005E_00BDY) where T : struct
			{
				return default;
			}
		}

		[Token(Token = "0x20003DD")]
		public static class Path
		{
			[Token(Token = "0x6006025")]
			[Address(RVA = "0x71E2748", Offset = "0x71DE748", VA = "0x71E2748")]
			public static string GetRegularPath(string P_0084c_007DÀ_00A3)
			{
				return null;
			}

			[Token(Token = "0x6006026")]
			[Address(RVA = "0x71E2760", Offset = "0x71DE760", VA = "0x71E2760")]
			public static string GetCombinePath(params string[] P_0084c_007DÀ_00A3)
			{
				return null;
			}

			[Token(Token = "0x6006027")]
			[Address(RVA = "0x71E283C", Offset = "0x71DE83C", VA = "0x71E283C")]
			public static string GetRemotePath(params string[] P_0084c_007DÀ_00A3)
			{
				return null;
			}

			[Token(Token = "0x6006028")]
			[Address(RVA = "0x71E28D0", Offset = "0x71DE8D0", VA = "0x71E28D0")]
			public static string GetResourceNameWithSuffix(string _007C_007Bx_00AD_0089_00BF)
			{
				return null;
			}

			[Token(Token = "0x6006029")]
			[Address(RVA = "0x71E2974", Offset = "0x71DE974", VA = "0x71E2974")]
			public static string GetResourceNameWithCrc32AndSuffix(string _007C_007Bx_00AD_0089_00BF, int _0085_0097xa_0099_00B7)
			{
				return null;
			}

			[Token(Token = "0x600602A")]
			[Address(RVA = "0x71E2A54", Offset = "0x71DEA54", VA = "0x71E2A54")]
			public static bool RemoveEmptyDirectory(string _0060W_00B6Ârw)
			{
				return default;
			}
		}

		[Token(Token = "0x20003DE")]
		[DontProfile]
		public static class Profiler
		{
			[Token(Token = "0x20003DF")]
			public interface IProfilerHelper
			{
				[Token(Token = "0x600602E")]
				void BeginSample(string _00AE_008C_009AiPJ);

				[Token(Token = "0x600602F")]
				void EndSample();
			}

			[Token(Token = "0x4001CB7")]
			[FieldOffset(Offset = "0x0")]
			private static IProfilerHelper _00A9g_007BT_0088_0080;

			[Token(Token = "0x600602B")]
			[Address(RVA = "0x71E2C34", Offset = "0x71DEC34", VA = "0x71E2C34")]
			public static void SetProfilerHelper(IProfilerHelper µ_00BC_00BExB_00B4)
			{
			}

			[Token(Token = "0x600602C")]
			[Address(RVA = "0x71E2C80", Offset = "0x71DEC80", VA = "0x71E2C80")]
			public static void BeginSample(string _00AE_008C_009AiPJ)
			{
			}

			[Token(Token = "0x600602D")]
			[Address(RVA = "0x71E2D84", Offset = "0x71DED84", VA = "0x71E2D84")]
			public static void EndSample()
			{
			}
		}

		[Token(Token = "0x20003E0")]
		public static class Random
		{
			[Token(Token = "0x4001CB8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly System.Random _00B1_00B2WhjC;

			[Token(Token = "0x6006030")]
			[Address(RVA = "0x71E2E84", Offset = "0x71DEE84", VA = "0x71E2E84")]
			public static int GetRandom()
			{
				return default;
			}

			[Token(Token = "0x6006031")]
			[Address(RVA = "0x71E2EEC", Offset = "0x71DEEEC", VA = "0x71E2EEC")]
			public static int GetRandom(int _009FvruAy)
			{
				return default;
			}

			[Token(Token = "0x6006032")]
			[Address(RVA = "0x71E2F5C", Offset = "0x71DEF5C", VA = "0x71E2F5C")]
			public static int GetRandom(int _008FRK_00A6_008FC, int _009FvruAy)
			{
				return default;
			}

			[Token(Token = "0x6006033")]
			[Address(RVA = "0x71E2FDC", Offset = "0x71DEFDC", VA = "0x71E2FDC")]
			public static double GetRandomDouble()
			{
				return default;
			}

			[Token(Token = "0x6006034")]
			[Address(RVA = "0x71E3044", Offset = "0x71DF044", VA = "0x71E3044")]
			public static void GetRandomBytes(byte[] a_009Cy_00AE_00BDf)
			{
			}
		}

		[Token(Token = "0x20003E1")]
		public static class Text
		{
			[Token(Token = "0x4001CB9")]
			[ThreadStatic]
			private static StringBuilder _005BQ_00A7C_00B8F;

			[Token(Token = "0x6006036")]
			[Address(RVA = "0x71E3124", Offset = "0x71DF124", VA = "0x71E3124")]
			public static string Format(string qkmY_00ADL, object u_0092_009Bh_0095_00A4)
			{
				return null;
			}

			[Token(Token = "0x6006037")]
			[Address(RVA = "0x71E32A4", Offset = "0x71DF2A4", VA = "0x71E32A4")]
			public static string Format(string qkmY_00ADL, object u_0092_009Bh_0095_00A4, object h_005DY_009AX_0090)
			{
				return null;
			}

			[Token(Token = "0x6006038")]
			[Address(RVA = "0x71E33A0", Offset = "0x71DF3A0", VA = "0x71E33A0")]
			public static string Format(string qkmY_00ADL, object u_0092_009Bh_0095_00A4, object h_005DY_009AX_0090, object _00A0K_00A5_00B0JB)
			{
				return null;
			}

			[Token(Token = "0x6006039")]
			[Address(RVA = "0x71E34A4", Offset = "0x71DF4A4", VA = "0x71E34A4")]
			public static string Format(string qkmY_00ADL, params object[] _00BC_00AE_007DW_00A3_0090)
			{
				return null;
			}

			[Token(Token = "0x600603A")]
			[Address(RVA = "0x71E3210", Offset = "0x71DF210", VA = "0x71E3210")]
			private static void _00A9z_00AEn_009FD()
			{
			}

			[Token(Token = "0x600603B")]
			[Address(RVA = "0x71E35B4", Offset = "0x71DF5B4", VA = "0x71E35B4")]
			public static string[] SplitToLines(string _00AD_0092zG_00ABd)
			{
				return null;
			}

			[Token(Token = "0x600603C")]
			public static string GetFullName<T>(string _00AE_008C_009AiPJ)
			{
				return null;
			}

			[Token(Token = "0x600603D")]
			[Address(RVA = "0x71E37C0", Offset = "0x71DF7C0", VA = "0x71E37C0")]
			public static string GetFullName(Type _007BgpR_00A0V, string _00AE_008C_009AiPJ)
			{
				return null;
			}

			[Token(Token = "0x600603E")]
			[Address(RVA = "0x71E3854", Offset = "0x71DF854", VA = "0x71E3854")]
			public static string FieldNameForDisplay(string M_008B_0089ql_00BF)
			{
				return null;
			}

			[Token(Token = "0x600603F")]
			[Address(RVA = "0x71E36D8", Offset = "0x71DF6D8", VA = "0x71E36D8")]
			private static string _00ACk_0095xEJ(string _00AD_0092zG_00ABd, ref int _00BB_00AE_0080_009A_00AC_00A3)
			{
				return null;
			}
		}

		[Token(Token = "0x20003E2")]
		[Confuse]
		public static class Verifier
		{
			[Token(Token = "0x20003E3")]
			[Confuse]
			private class S_007D_0081T_0082_0093 : HashAlgorithm
			{
				[Token(Token = "0x4001CBB")]
				public const uint DefaultPolynomial = 3988292384u;

				[Token(Token = "0x4001CBC")]
				public const uint DefaultSeed = uint.MaxValue;

				[Token(Token = "0x4001CBD")]
				[FieldOffset(Offset = "0x0")]
				private static uint[] _0099Q_00A8_0080_00B2_0088;

				[Token(Token = "0x4001CBE")]
				[FieldOffset(Offset = "0x24")]
				private readonly uint _00AB_009E_009EI_008D_0089;

				[Token(Token = "0x4001CBF")]
				[FieldOffset(Offset = "0x28")]
				private readonly uint[] X_0096_0099_0082_0085_0098;

				[Token(Token = "0x4001CC0")]
				[FieldOffset(Offset = "0x30")]
				private uint HAT_008BI_0089;

				[Token(Token = "0x6006044")]
				[Address(RVA = "0x71E3F84", Offset = "0x71DFF84", VA = "0x71E3F84")]
				private static uint[] s_008F_008C_0091zs(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006045")]
				[Address(RVA = "0x71E406C", Offset = "0x71E006C", VA = "0x71E406C")]
				private static uint _0083Gg_00A0F_00B3(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006046")]
				[Address(RVA = "0x71E40E8", Offset = "0x71E00E8", VA = "0x71E40E8")]
				private static uint[] _0081_009F_00B1_0090_009An(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006047")]
				[Address(RVA = "0x71E4174", Offset = "0x71E0174", VA = "0x71E4174")]
				private static uint _0099_008CAh_009Aw(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006048")]
				[Address(RVA = "0x71E41F0", Offset = "0x71E01F0", VA = "0x71E41F0")]
				private static byte[] _0089y_009D_008BÂz(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x6006049")]
				[Address(RVA = "0x71E4274", Offset = "0x71E0274", VA = "0x71E4274")]
				private static byte[] _008Cº_009Bb_008B_00B1(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600604A")]
				[Address(RVA = "0x71E42F4", Offset = "0x71E02F4", VA = "0x71E42F4")]
				private static uint kV_009Acnv(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600604B")]
				[Address(RVA = "0x71E4370", Offset = "0x71E0370", VA = "0x71E4370")]
				private static uint[] _0084_0080r_0095_009Cª(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x600604C")]
				[Address(RVA = "0x71E43FC", Offset = "0x71E03FC", VA = "0x71E43FC")]
				private static uint j_005E_007Dv_00A3O(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600604D")]
				[Address(RVA = "0x71E4474", Offset = "0x71E0474", VA = "0x71E4474")]
				private static byte[] _00B3V_008F_00BEF_008A(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600604E")]
				[Address(RVA = "0x71E4508", Offset = "0x71E0508", VA = "0x71E4508")]
				private static uint[] j_0094_00AE_0081ÂL(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x600604F")]
				[Address(RVA = "0x71E4594", Offset = "0x71E0594", VA = "0x71E4594")]
				private static uint H_0087e_00BD_00B7_0080(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006050")]
				[Address(RVA = "0x71E4610", Offset = "0x71E0610", VA = "0x71E4610")]
				private static uint[] k_00A8Bgb_0099(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006051")]
				[Address(RVA = "0x71E469C", Offset = "0x71E069C", VA = "0x71E469C")]
				private static uint[] C_009E_0092NJn(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006052")]
				[Address(RVA = "0x71E4728", Offset = "0x71E0728", VA = "0x71E4728")]
				private static uint[] dADt_008DM(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006053")]
				[Address(RVA = "0x71E47A0", Offset = "0x71E07A0", VA = "0x71E47A0")]
				private static uint _009C_0087_00A0_005BmM(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006054")]
				[Address(RVA = "0x71E481C", Offset = "0x71E081C", VA = "0x71E481C")]
				private static uint n_00A6_0092_0085_0083_00A3(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006055")]
				[Address(RVA = "0x71E4888", Offset = "0x71E0888", VA = "0x71E4888")]
				private static byte[] E_00AD_00AC_009Ff_00BD(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x6006056")]
				[Address(RVA = "0x71E491C", Offset = "0x71E091C", VA = "0x71E491C")]
				private static byte[] _0087_00B4oÁBu(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x6006057")]
				[Address(RVA = "0x71E4998", Offset = "0x71E0998", VA = "0x71E4998")]
				private static byte[] Ahnsca(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x6006058")]
				[Address(RVA = "0x71E4A1C", Offset = "0x71E0A1C", VA = "0x71E4A1C")]
				private static uint[] _00A7Nsºm_00BC(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006059")]
				[Address(RVA = "0x71E4AA8", Offset = "0x71E0AA8", VA = "0x71E4AA8")]
				private static byte[] K_009F_0098_007EC_005B(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600605A")]
				[Address(RVA = "0x71E4B2C", Offset = "0x71E0B2C", VA = "0x71E4B2C")]
				private static byte[] i_0088_009C_0092_007F_008C(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600605B")]
				[Address(RVA = "0x71E4BB8", Offset = "0x71E0BB8", VA = "0x71E4BB8", Slot = "16")]
				protected override void HashCore(byte[] _007F_009DGZ_007DG, int µ_00B4_0089_00A7_00BD_0060, int V_007Ey_00A5_0085_008E)
				{
				}

				[Token(Token = "0x600605C")]
				[Address(RVA = "0x71E4BE8", Offset = "0x71E0BE8", VA = "0x71E4BE8")]
				private static uint[] kº_008BqoC(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x600605D")]
				[Address(RVA = "0x71E4C74", Offset = "0x71E0C74", VA = "0x71E4C74")]
				private static uint[] en_007Cg_008FX(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x600605E")]
				[Address(RVA = "0x71E4D00", Offset = "0x71E0D00", VA = "0x71E4D00")]
				private static uint Z_005B_0095w_00A2t(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600605F")]
				[Address(RVA = "0x71E4D7C", Offset = "0x71E0D7C", VA = "0x71E4D7C")]
				private static byte[] _00B6_00B6_00B1JS_00AD(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x6006060")]
				[Address(RVA = "0x71E4DF0", Offset = "0x71E0DF0", VA = "0x71E4DF0")]
				private static uint[] P_00A1_007C_008Fl_00A4(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006061")]
				[Address(RVA = "0x71E4E68", Offset = "0x71E0E68", VA = "0x71E4E68")]
				private static uint _0082_0091_009Cf_00B2t(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006062")]
				[Address(RVA = "0x71E4ED4", Offset = "0x71E0ED4", VA = "0x71E4ED4")]
				private static uint _008B_00AFS_007DqF(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006063")]
				[Address(RVA = "0x71E4F50", Offset = "0x71E0F50", VA = "0x71E4F50")]
				public S_007D_0081T_0082_0093(uint PÁVtfa, uint _0081À_00BC_0097_00A9_00B3)
				{
				}

				[Token(Token = "0x6006064")]
				[Address(RVA = "0x71E4F8C", Offset = "0x71E0F8C", VA = "0x71E4F8C")]
				private static uint[] I_0090GVª_00BE(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006065")]
				[Address(RVA = "0x71E5018", Offset = "0x71E1018", VA = "0x71E5018")]
				private static uint[] _00A5Á_00BE_00B6Âm(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006066")]
				[Address(RVA = "0x71E50A4", Offset = "0x71E10A4", VA = "0x71E50A4")]
				private static uint[] Lat_00A6_00BFR(uint PÁVtfa)
				{
					return null;
				}

				[Token(Token = "0x6006067")]
				[Address(RVA = "0x71E511C", Offset = "0x71E111C", VA = "0x71E511C")]
				private static uint _0093_00A7V_009E_00A5A(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x6006068")]
				[Address(RVA = "0x71E5188", Offset = "0x71E1188", VA = "0x71E5188", Slot = "17")]
				protected override byte[] HashFinal()
				{
					return null;
				}

				[Token(Token = "0x6006069")]
				[Address(RVA = "0x71E51A8", Offset = "0x71E11A8", VA = "0x71E51A8")]
				private static byte[] f_00ABS_0094M_0096(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600606A")]
				[Address(RVA = "0x71E5238", Offset = "0x71E1238", VA = "0x71E5238")]
				private static uint w_0097_00B7JLh(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600606B")]
				[Address(RVA = "0x71E3B7C", Offset = "0x71DFB7C", VA = "0x71E3B7C")]
				public S_007D_0081T_0082_0093()
				{
				}

				[Token(Token = "0x600606C")]
				[Address(RVA = "0x71E52B0", Offset = "0x71E12B0", VA = "0x71E52B0")]
				private static byte[] _008E_007ESiZ_009D(uint µª_009Ey_00BB_00AE)
				{
					return null;
				}

				[Token(Token = "0x600606D")]
				[Address(RVA = "0x71E5338", Offset = "0x71E1338", VA = "0x71E5338")]
				private static uint _00B4_005EBAº_009D(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600606E")]
				[Address(RVA = "0x71E53B4", Offset = "0x71E13B4", VA = "0x71E53B4")]
				private static uint _008D_00A1vs_00B2_009F(uint[] s_00A6_008Ekn_008F, uint _0081À_00BC_0097_00A9_00B3, byte[] lD_009F_0098_0080_00B0, int O_00A6_0091_00BE_007E_0081, int sEOi_0090_00A6)
				{
					return default;
				}

				[Token(Token = "0x600606F")]
				[Address(RVA = "0x71E5430", Offset = "0x71E1430", VA = "0x71E5430", Slot = "18")]
				public override void Initialize()
				{
				}
			}

			[Token(Token = "0x4001CBA")]
			[FieldOffset(Offset = "0x0")]
			private static readonly byte[] _0083C_007FcY_007C;

			[Token(Token = "0x6006040")]
			[Address(RVA = "0x71E3950", Offset = "0x71DF950", VA = "0x71E3950")]
			public static byte[] GetCrc32(byte[] lD_009F_0098_0080_00B0)
			{
				return null;
			}

			[Token(Token = "0x6006041")]
			[Address(RVA = "0x71E3BB8", Offset = "0x71DFBB8", VA = "0x71E3BB8")]
			public static byte[] GetCrc32(string _0084H_007Fp_0060i)
			{
				return null;
			}

			[Token(Token = "0x6006042")]
			[Address(RVA = "0x71E3DF8", Offset = "0x71DFDF8", VA = "0x71E3DF8")]
			public static string GetMD5(byte[] lD_009F_0098_0080_00B0)
			{
				return null;
			}
		}

		[Token(Token = "0x20003E4")]
		public static class Zip
		{
			[Token(Token = "0x20003E5")]
			public interface IZipHelper
			{
				[Token(Token = "0x6006073")]
				byte[] Compress(byte[] lD_009F_0098_0080_00B0);

				[Token(Token = "0x6006074")]
				byte[] Decompress(byte[] lD_009F_0098_0080_00B0);
			}

			[Token(Token = "0x4001CC1")]
			[FieldOffset(Offset = "0x0")]
			private static IZipHelper _0089wOP_008E_0092;

			[Token(Token = "0x6006070")]
			[Address(RVA = "0x71E543C", Offset = "0x71E143C", VA = "0x71E543C")]
			public static void SetZipHelper(IZipHelper ky_008E_00B1_0099p)
			{
			}

			[Token(Token = "0x6006071")]
			[Address(RVA = "0x71E5488", Offset = "0x71E1488", VA = "0x71E5488")]
			public static byte[] Compress(byte[] lD_009F_0098_0080_00B0)
			{
				return null;
			}

			[Token(Token = "0x6006072")]
			[Address(RVA = "0x71E558C", Offset = "0x71E158C", VA = "0x71E558C")]
			public static byte[] Decompress(byte[] lD_009F_0098_0080_00B0)
			{
				return null;
			}
		}
	}
}
