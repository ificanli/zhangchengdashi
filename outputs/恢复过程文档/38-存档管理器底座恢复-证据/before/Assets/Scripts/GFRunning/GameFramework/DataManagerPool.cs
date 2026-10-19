using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework.GameData;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200035C")]
	public class DataManagerPool
	{
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, DataManagerBase> _00A3_00A3_0094ÁD_0083;

		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x0")]
		private static DataManagerPool _0060_0083_00A4_00A6_0095t;

		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x18")]
		private _00B3_0092_00BF_0080d_0084 i_00A6a_0099_007D_00A3;

		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x20")]
		internal bool E_00BDb_009C_00A3_0080;

		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x8")]
		internal static bool u_0080ÂF_008BÁ;

		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x9")]
		public static bool CanSaveLocalData;

		[Token(Token = "0x170010FC")]
		public static DataManagerPool Instance
		{
			[Token(Token = "0x6005866")]
			[Address(RVA = "0x71723B4", Offset = "0x716E3B4", VA = "0x71723B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010FD")]
		internal Dictionary<Type, DataManagerBase> Fh_0090kE_0091
		{
			[Token(Token = "0x6005869")]
			[Address(RVA = "0x7179184", Offset = "0x7175184", VA = "0x7179184")]
			get
			{
				return _0092Hz_0085_009D_00B9();
			}
		}

		[Token(Token = "0x6005852")]
		[Address(RVA = "0x7176888", Offset = "0x7172888", VA = "0x7176888")]
		internal void _00B6hKM_00B0_0090(List<string> T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6005853")]
		[Address(RVA = "0x7176C64", Offset = "0x7172C64", VA = "0x7176C64")]
		internal void _008AvBfK_00B3(List<string> T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6005854")]
		[Address(RVA = "0x7177040", Offset = "0x7173040", VA = "0x7177040")]
		public void _0091_007C_00B3ZXq()
		{
		}

		[Token(Token = "0x6005855")]
		[Address(RVA = "0x7177408", Offset = "0x7173408", VA = "0x7177408")]
		public void G_00B6i_0060_005DY()
		{
		}

		[Token(Token = "0x6005856")]
		[Address(RVA = "0x71775E0", Offset = "0x71735E0", VA = "0x71775E0")]
		public void _009A_0093_005B_0090Kg()
		{
		}

		[Token(Token = "0x6005857")]
		[Address(RVA = "0x71775FC", Offset = "0x71735FC", VA = "0x71775FC")]
		public void µ_00B2_0082Á_007C_00AB()
		{
		}

		[Token(Token = "0x6005858")]
		[Address(RVA = "0x71779E4", Offset = "0x71739E4", VA = "0x71779E4")]
		internal void _00B7F_00A2QAx()
		{
		}

		[Token(Token = "0x6005859")]
		[Address(RVA = "0x7177B58", Offset = "0x7173B58", VA = "0x7177B58")]
		public void _0083Á_008C_00B3R_00B2()
		{
		}

		[Token(Token = "0x600585A")]
		[Address(RVA = "0x7177D30", Offset = "0x7173D30", VA = "0x7177D30")]
		public bool gÂ_0096_0060_0088j()
		{
			return default;
		}

		[Token(Token = "0x600585B")]
		public T AddModel<T>(T SqR_0089Z_00AD, bool J_0098SX_00AD_00A7 = true) where T : DataManagerBase
		{
			return null;
		}

		[Token(Token = "0x600585C")]
		[Address(RVA = "0x7177DC0", Offset = "0x7173DC0", VA = "0x7177DC0")]
		internal void _00AFf_0085ª_009A_00B4(string _00AE_0092_0097ye_007E, string _0097_0090ki_0082_008E)
		{
		}

		[Token(Token = "0x600585D")]
		[Address(RVA = "0x7177DDC", Offset = "0x7173DDC", VA = "0x7177DDC")]
		public DataManagerPool()
		{
		}

		[Token(Token = "0x600585E")]
		[Address(RVA = "0x7177DEC", Offset = "0x7173DEC", VA = "0x7177DEC")]
		internal void _00B4_00B2z_0087_009D_005D(string _00AE_0092_0097ye_007E, string _0097_0090ki_0082_008E)
		{
		}

		[Token(Token = "0x600585F")]
		[Address(RVA = "0x7177E08", Offset = "0x7173E08", VA = "0x7177E08")]
		public void RTZQqA()
		{
		}

		[Token(Token = "0x6005860")]
		public T GetModel<T>() where T : DataManagerBase
		{
			return null;
		}

		[Token(Token = "0x6005861")]
		[Address(RVA = "0x71783A4", Offset = "0x71743A4", VA = "0x71783A4")]
		public void OnInit()
		{
		}

		[Token(Token = "0x6005862")]
		[Address(RVA = "0x7178788", Offset = "0x7174788", VA = "0x7178788")]
		public void OnRelease()
		{
		}

		[Token(Token = "0x6005863")]
		[Address(RVA = "0x717895C", Offset = "0x717495C", VA = "0x717895C")]
		internal void GN_0093x_008A_007B(List<string> T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6005864")]
		[Address(RVA = "0x7178D38", Offset = "0x7174D38", VA = "0x7178D38")]
		public DataManagerBase d_0088_00A0_0089_00B3v(Type h_00B9_00B8_005E_00BDY)
		{
			return null;
		}

		[Token(Token = "0x6005865")]
		[Address(RVA = "0x7178F80", Offset = "0x7174F80", VA = "0x7178F80")]
		internal void GN_0093x_008A_007B()
		{
		}

		[Token(Token = "0x6005867")]
		[Address(RVA = "0x7177FDC", Offset = "0x7173FDC", VA = "0x7177FDC")]
		public void SaveData()
		{
		}

		[Token(Token = "0x6005868")]
		[Address(RVA = "0x71790F4", Offset = "0x71750F4", VA = "0x71790F4")]
		public bool _0083Ns_0089_00B2O()
		{
			return default;
		}

		[Token(Token = "0x6005869")]
		[Address(RVA = "0x7179184", Offset = "0x7175184", VA = "0x7179184")]
		internal Dictionary<Type, DataManagerBase> _0092Hz_0085_009D_00B9()
		{
			return null;
		}

		[Token(Token = "0x600586A")]
		[Address(RVA = "0x717918C", Offset = "0x717518C", VA = "0x717918C")]
		public void _008BC_00A0sJv()
		{
		}

		[SpecialName]
		[Token(Token = "0x600586B")]
		[Address(RVA = "0x7179554", Offset = "0x7175554", VA = "0x7179554")]
		public static DataManagerPool z_00AE_0082_0093PÁ()
		{
			return null;
		}

		[Token(Token = "0x600586C")]
		[Address(RVA = "0x7179600", Offset = "0x7175600", VA = "0x7179600")]
		internal void HU_00A7G_009At(string _0088_00A7_00B0_00B8Y_0090, string _00BF_00B2KfsF, bool À_00B9_007B_0091_00B1_0096)
		{
		}

		[Token(Token = "0x600586D")]
		[Address(RVA = "0x7177794", Offset = "0x7173794", VA = "0x7177794")]
		private void xhZV_00A0_00B3()
		{
		}

		[Token(Token = "0x600586E")]
		[Address(RVA = "0x7179990", Offset = "0x7175990", VA = "0x7179990")]
		internal bool di_00A5_008B_007CK(string _0088_00A7_00B0_00B8Y_0090, string _00BF_00B2KfsF, List<RevServerGameData> H_00A3_00A6_00A5_00AB_00BC, out string _007B_00BEwy_00A2_00A8)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DataManagerPool.di_00A5_008B_007CK RVA=0x7179990 Token=0x600586E");
}

		[Token(Token = "0x600586F")]
		[Address(RVA = "0x7179BFC", Offset = "0x7175BFC", VA = "0x7179BFC")]
		internal void bºn_00B1pJ(string _0088_00A7_00B0_00B8Y_0090, string _00BF_00B2KfsF, bool À_00B9_007B_0091_00B1_0096)
		{
		}

		[SpecialName]
		[Token(Token = "0x6005870")]
		[Address(RVA = "0x7179FB8", Offset = "0x7175FB8", VA = "0x7179FB8")]
		internal Dictionary<Type, DataManagerBase> E_005E_00B4Km_00A9()
		{
			return null;
		}

		[Token(Token = "0x6005871")]
		[Address(RVA = "0x7179FC0", Offset = "0x7175FC0", VA = "0x7179FC0")]
		public DataManagerBase KF_0099ºDÀ(Type h_00B9_00B8_005E_00BDY)
		{
			return null;
		}

		[Token(Token = "0x6005872")]
		[Address(RVA = "0x717A204", Offset = "0x7176204", VA = "0x717A204")]
		public void SetAutoSaveToServer(bool _00AB_00A4mC_007DR)
		{
		}

		[Token(Token = "0x6005873")]
		[Address(RVA = "0x717A224", Offset = "0x7176224", VA = "0x717A224")]
		public void _007C_0096_005Ds_00BEd()
		{
		}

		[Token(Token = "0x6005874")]
		[Address(RVA = "0x717A5F0", Offset = "0x71765F0", VA = "0x717A5F0")]
		public void PushDataToServer()
		{
		}

		[Token(Token = "0x6005875")]
		[Address(RVA = "0x717A60C", Offset = "0x717660C", VA = "0x717A60C")]
		public DataManagerBase N_00A0_0094F_005B_007F(Type h_00B9_00B8_005E_00BDY)
		{
			return null;
		}

		[Token(Token = "0x6005876")]
		[Address(RVA = "0x7172460", Offset = "0x716E460", VA = "0x7172460")]
		internal void ª_009E_007D_00A1_007C_00AD(string _00AE_0092_0097ye_007E, string _0097_0090ki_0082_008E)
		{
		}

		[Token(Token = "0x6005877")]
		[Address(RVA = "0x7178538", Offset = "0x7174538", VA = "0x7178538")]
		private void _00A3ºFe_0091p()
		{
		}

		[Token(Token = "0x6005878")]
		[Address(RVA = "0x717A84C", Offset = "0x717684C", VA = "0x717A84C")]
		internal void _0092WM_007C_00AB_009B(List<string> T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6005879")]
		[Address(RVA = "0x717AC28", Offset = "0x7176C28", VA = "0x717AC28")]
		internal bool _00AEM_00A1_00B8Y_0086(string _0088_00A7_00B0_00B8Y_0090, string _00BF_00B2KfsF, List<RevServerGameData> H_00A3_00A6_00A5_00AB_00BC, out string _007B_00BEwy_00A2_00A8)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DataManagerPool._00AEM_00A1_00B8Y_0086 RVA=0x717AC28 Token=0x6005879");
}

		[Token(Token = "0x600587A")]
		[Address(RVA = "0x717AE94", Offset = "0x7176E94", VA = "0x717AE94")]
		internal void ejZ_007C_005E_00A7()
		{
		}

		[Token(Token = "0x600587B")]
		[Address(RVA = "0x717B008", Offset = "0x7177008", VA = "0x717B008")]
		public bool IsEnableSaveData()
		{
			return default;
		}

		[Token(Token = "0x600587C")]
		[Address(RVA = "0x71737D0", Offset = "0x716F7D0", VA = "0x71737D0")]
		internal static void _00B9_00A4V_0098_0096G(bool _00AB_00A4mC_007DR)
		{
		}

		[Token(Token = "0x600587D")]
		[Address(RVA = "0x717B098", Offset = "0x7177098", VA = "0x717B098")]
		public void _008C_0082AzeÀ(bool _00AB_00A4mC_007DR)
		{
		}

		[Token(Token = "0x600587F")]
		[Address(RVA = "0x717B104", Offset = "0x7177104", VA = "0x717B104")]
		public DataManagerBase GetModel(Type h_00B9_00B8_005E_00BDY)
		{
			return null;
		}

		[Token(Token = "0x6005880")]
		[Address(RVA = "0x717B344", Offset = "0x7177344", VA = "0x717B344")]
		internal void Gª_00AD_0099_00B3K(List<string> T_0087_007DvBs)
		{
		}

		[Token(Token = "0x6005881")]
		[Address(RVA = "0x717B730", Offset = "0x7177730", VA = "0x717B730")]
		public void MJ_0098v_00AD_009C()
		{
		}

		[Token(Token = "0x6005882")]
		[Address(RVA = "0x717B8C8", Offset = "0x71778C8", VA = "0x717B8C8")]
		private void _0091_00B4_007CE_005E_0080()
		{
		}

		[Token(Token = "0x6005883")]
		[Address(RVA = "0x717BB00", Offset = "0x7177B00", VA = "0x717BB00")]
		internal void _007F_008E_0083y_0087s(string _0088_00A7_00B0_00B8Y_0090, string _00BF_00B2KfsF, bool À_00B9_007B_0091_00B1_0096)
		{
		}
	}
}
