using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace GameFramework
{
	[Token(Token = "0x20002FC")]
	public class ResLoadHelper
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002FD")]
		private struct _008F_0091u_009E_00B9R : IAsyncStateMachine
		{
			[Token(Token = "0x4001872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<SpriteAtlas> _003C_003Et__builder;

			[Token(Token = "0x4001874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string uiAtlasName;

			[Token(Token = "0x4001875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<SpriteAtlas> _003C_003Eu__1;

			[Token(Token = "0x6005360")]
			[Address(RVA = "0x713AED0", Offset = "0x7136ED0", VA = "0x713AED0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005361")]
			[Address(RVA = "0x713B230", Offset = "0x7137230", VA = "0x713B230", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Dictionary<string, string> gµ_009D_0096_0081_00A8;

		[Token(Token = "0x4001871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static Dictionary<string, string[]> _00A3h_00A8_0081m_005E;

		[Token(Token = "0x600532A")]
		[Address(RVA = "0x7137168", Offset = "0x7133168", VA = "0x7137168")]
		public static void _0085_0081d_0091_00BBQ(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600532B")]
		[Address(RVA = "0x7137314", Offset = "0x7133314", VA = "0x7137314")]
		public static string _009D_00A7_00A5vÂ_008F(string M_009E_00AD_005B_007CO, AssetBundle n_008A_007B_0081_00B6_00B0)
		{
			return null;
		}

		[Token(Token = "0x600532C")]
		[Address(RVA = "0x7137830", Offset = "0x7133830", VA = "0x7137830")]
		public static void _008C_0060_00B6_0083_005BY(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x600532D")]
		[Address(RVA = "0x713798C", Offset = "0x713398C", VA = "0x713798C")]
		public static void _0086S_005Dy_0086J(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x600532E")]
		[Address(RVA = "0x71379FC", Offset = "0x71339FC", VA = "0x71379FC")]
		public static void _0083H_00B4_009A_00B9_0090(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600532F")]
		[Address(RVA = "0x7137A60", Offset = "0x7133A60", VA = "0x7137A60")]
		public static void _00A1c_0085_008F_00A0g(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x6005330")]
		[Address(RVA = "0x7137C80", Offset = "0x7133C80", VA = "0x7137C80")]
		[AsyncStateMachine(typeof(_008F_0091u_009E_00B9R))]
		public static Task<SpriteAtlas> LoadSpriteAtlasAsync(string _0084RfZSg)
		{
			return null;
		}

		[Token(Token = "0x6005331")]
		[Address(RVA = "0x7137D64", Offset = "0x7133D64", VA = "0x7137D64")]
		public static void Yq_0093H_007E_0081(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005332")]
		[Address(RVA = "0x7137DC8", Offset = "0x7133DC8", VA = "0x7137DC8")]
		public static void LoadMaterial(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005333")]
		[Address(RVA = "0x7137EDC", Offset = "0x7133EDC", VA = "0x7137EDC")]
		public static void X_0087_008Ct_0084_00B8(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005334")]
		[Address(RVA = "0x7137F34", Offset = "0x7133F34", VA = "0x7137F34")]
		public static void _009Fx_0087_00AE_00A6_0099(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005335")]
		[Address(RVA = "0x7137FA4", Offset = "0x7133FA4", VA = "0x7137FA4")]
		public static void _00A0_0089_0091a_0097_0096(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005336")]
		[Address(RVA = "0x7138008", Offset = "0x7134008", VA = "0x7138008")]
		public static ResLoader LoadAsset(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
			return null;
		}

		[Token(Token = "0x6005337")]
		[Address(RVA = "0x71380DC", Offset = "0x71340DC", VA = "0x71380DC")]
		public static void ÁF_005D_005B_00AFÀ(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005338")]
		[Address(RVA = "0x7138134", Offset = "0x7134134", VA = "0x7138134")]
		public static void NzaC_008CX(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005339")]
		[Address(RVA = "0x7138198", Offset = "0x7134198", VA = "0x7138198")]
		public static void LoadSpriteAtlas(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x600533A")]
		[Address(RVA = "0x71382C0", Offset = "0x71342C0", VA = "0x71382C0")]
		public static Task<SpriteAtlas> arK_00A2i_00BD(string _0084RfZSg)
		{
			return null;
		}

		[Token(Token = "0x600533B")]
		[Address(RVA = "0x71383A4", Offset = "0x71343A4", VA = "0x71383A4")]
		public static void _00ACF_009C_008F_0086_00BC(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x600533C")]
		[Address(RVA = "0x71384CC", Offset = "0x71344CC", VA = "0x71384CC")]
		public static void b_0095_00AC_0089_009B_00A8(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600533E")]
		[Address(RVA = "0x713860C", Offset = "0x713460C", VA = "0x713860C")]
		public static void _00A9_00A3bmA_0086(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600533F")]
		[Address(RVA = "0x7137B44", Offset = "0x7133B44", VA = "0x7137B44")]
		public static bool CheckUseRightResLoad()
		{
			return default;
		}

		[Token(Token = "0x6005340")]
		[Address(RVA = "0x7138664", Offset = "0x7134664", VA = "0x7138664")]
		public static void LoadPrefabOri(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005341")]
		[Address(RVA = "0x7138734", Offset = "0x7134734", VA = "0x7138734")]
		public static void _009D_00BDS_007D_0081Â(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x6005342")]
		[Address(RVA = "0x713885C", Offset = "0x713485C", VA = "0x713885C")]
		public static void O_00B1n_009FCp(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005343")]
		[Address(RVA = "0x7138970", Offset = "0x7134970", VA = "0x7138970")]
		public static void LoadPrefab(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005344")]
		[Address(RVA = "0x7138A30", Offset = "0x7134A30", VA = "0x7138A30")]
		public static void LoadTexture(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005345")]
		[Address(RVA = "0x7138B2C", Offset = "0x7134B2C", VA = "0x7138B2C")]
		public static string GetIntactBundleName(string M_009E_00AD_005B_007CO, AssetBundle n_008A_007B_0081_00B6_00B0)
		{
			return null;
		}

		[Token(Token = "0x6005346")]
		[Address(RVA = "0x713904C", Offset = "0x713504C", VA = "0x713904C")]
		public static void xl_00A4r_00B0_0082(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005347")]
		[Address(RVA = "0x71390B0", Offset = "0x71350B0", VA = "0x71390B0")]
		public static void _0098_007Be_00BE_0095O(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x6005348")]
		[Address(RVA = "0x71391D8", Offset = "0x71351D8", VA = "0x71391D8")]
		public static void LoadModelPrefab(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005349")]
		[Address(RVA = "0x71392D4", Offset = "0x71352D4", VA = "0x71392D4")]
		public static void w_00BED_0085_00ADL(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x71393D0", Offset = "0x71353D0", VA = "0x71393D0")]
		public static void B_00A5l_007E_00A1z(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x600534B")]
		[Address(RVA = "0x7139434", Offset = "0x7135434", VA = "0x7139434")]
		public static void I_00A2_00B7_0090xo(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x71371D8", Offset = "0x71331D8", VA = "0x71371D8")]
		public static bool KSF_00A3_0083_0082()
		{
			return default;
		}

		[Token(Token = "0x600534D")]
		[Address(RVA = "0x7139518", Offset = "0x7135518", VA = "0x7139518")]
		public static void LoadAssetNow(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600534E")]
		[Address(RVA = "0x71395E8", Offset = "0x71355E8", VA = "0x71395E8")]
		public static void F_00AD_00BD_009Ap_005D(string _0084RfZSg, Action<SpriteAtlas> _009F_00A4WY_0097_00B1)
		{
		}

		[Token(Token = "0x600534F")]
		[Address(RVA = "0x7139710", Offset = "0x7135710", VA = "0x7139710")]
		public ResLoadHelper()
		{
		}

		[Token(Token = "0x6005350")]
		[Address(RVA = "0x7139718", Offset = "0x7135718", VA = "0x7139718")]
		public static string s_00B4V_0092L_0082(string M_009E_00AD_005B_007CO, AssetBundle n_008A_007B_0081_00B6_00B0)
		{
			return null;
		}

		[Token(Token = "0x6005351")]
		[Address(RVA = "0x7139C08", Offset = "0x7135C08", VA = "0x7139C08")]
		public static void k_007BrI_00A0l(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005352")]
		[Address(RVA = "0x713936C", Offset = "0x713536C", VA = "0x713936C")]
		public static void UL_00A2_005E_0089t(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005353")]
		[Address(RVA = "0x7139C6C", Offset = "0x7135C6C", VA = "0x7139C6C")]
		public static void _00B9g_005EzAE(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x6005354")]
		[Address(RVA = "0x7139D50", Offset = "0x7135D50", VA = "0x7139D50")]
		public static void d_008AE_0087d_00AE(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x6005355")]
		[Address(RVA = "0x7139DB4", Offset = "0x7135DB4", VA = "0x7139DB4")]
		public static void LoadAssetNoExtName(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, params object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005356")]
		[Address(RVA = "0x7139E84", Offset = "0x7135E84", VA = "0x7139E84")]
		public static void _00B6OBµW_009D(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005357")]
		[Address(RVA = "0x7139EE8", Offset = "0x7135EE8", VA = "0x7139EE8")]
		public static void yd_00ADbJ_00A4(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005358")]
		[Address(RVA = "0x7139F40", Offset = "0x7135F40", VA = "0x7139F40")]
		public static void _009DqwE_009E_0095(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6005359")]
		[Address(RVA = "0x7139FA4", Offset = "0x7135FA4", VA = "0x7139FA4")]
		public static string _009C_0090vT_0090_0082(string M_009E_00AD_005B_007CO, AssetBundle n_008A_007B_0081_00B6_00B0)
		{
			return null;
		}

		[Token(Token = "0x600535A")]
		[Address(RVA = "0x713A4DC", Offset = "0x71364DC", VA = "0x713A4DC")]
		public static void _008C_0095_007B_00B4_007B_0084(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600535B")]
		[Address(RVA = "0x713A5AC", Offset = "0x71365AC", VA = "0x713A5AC")]
		public static Task<SpriteAtlas> ªF_005B_008CKD(string _0084RfZSg)
		{
			return null;
		}

		[Token(Token = "0x600535C")]
		[Address(RVA = "0x713A690", Offset = "0x7136690", VA = "0x713A690")]
		public static void _0091_00AD_0084d_008F_0090(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600535D")]
		[Address(RVA = "0x713A78C", Offset = "0x713678C", VA = "0x713A78C")]
		public static void _008Ed_009F_00AB_00B9_0081(string µZºV_0089_00AB, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600535E")]
		[Address(RVA = "0x713A888", Offset = "0x7136888", VA = "0x713A888")]
		public static string _0094G_00AE_00B4_00A9V(string M_009E_00AD_005B_007CO, AssetBundle n_008A_007B_0081_00B6_00B0)
		{
			return null;
		}

		[Token(Token = "0x600535F")]
		[Address(RVA = "0x713ADEC", Offset = "0x7136DEC", VA = "0x713ADEC")]
		public static void LoadScene(string x_008A_00BE_0098_007Ej, [Optional] ResourcesModule.LoadAssetCompleteHandler _0091_00BF_0099sB_007E, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] ResourcesModule.LoadProgressHandler _008E_0086_00BD_0098k_00B9)
		{
		}
	}
}
