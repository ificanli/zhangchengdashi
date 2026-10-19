using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000382")]
	[CreateAssetMenu(fileName = "AddressPathMapping", menuName = "GameFramework/AddressPathMapping")]
	public class AddressPathMapping : ScriptableObject
	{
		[Token(Token = "0x2000383")]
		private sealed class Á_008AL_007F_007CR
		{
			[Token(Token = "0x4001B31")]
			[FieldOffset(Offset = "0x10")]
			public string normalizedAddress;

			[Token(Token = "0x6005AA6")]
			[Address(RVA = "0x71A7928", Offset = "0x71A3928", VA = "0x71A7928")]
			public Á_008AL_007F_007CR()
			{
			}

			[Token(Token = "0x6005AA7")]
			[Address(RVA = "0x71A842C", Offset = "0x71A442C", VA = "0x71A842C")]
			internal bool WB_00A2_00A2_00AB_007F(AddressPathPair m)
			{
				return default;
			}
		}

		[Token(Token = "0x4001B2D")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("地址到路径的映射列表（用于序列化）")]
		public List<AddressPathPair> Mappings;

		[Token(Token = "0x4001B2E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> _addressToPathDict;

		[Token(Token = "0x4001B2F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, string> _pathToAddressDict;

		[Token(Token = "0x4001B30")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialized;

		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x71A5E10", Offset = "0x71A1E10", VA = "0x71A5E10")]
		public Dictionary<string, string> Y_00A0lDh_00A8()
		{
			return null;
		}

		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x71A6170", Offset = "0x71A2170", VA = "0x71A6170")]
		public Dictionary<string, string> K_00AE_0098_005B_00BE_00AC()
		{
			return null;
		}

		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x71A61F4", Offset = "0x71A21F4", VA = "0x71A61F4")]
		private void _007F_00BB_00A6_0092_005B_0081()
		{
		}

		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x71A6538", Offset = "0x71A2538", VA = "0x71A6538")]
		public List<string> _008A_0093_00B2kfq()
		{
			return null;
		}

		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x71A65E0", Offset = "0x71A25E0", VA = "0x71A65E0")]
		private static string º_007EdU_0094d(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x71A6660", Offset = "0x71A2660", VA = "0x71A6660")]
		public void e_0096_0082_00A4_005E_00AE()
		{
		}

		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x71A666C", Offset = "0x71A266C", VA = "0x71A666C")]
		public Dictionary<string, string> GetAddressToPathDictionary()
		{
			return null;
		}

		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x71A66F0", Offset = "0x71A26F0", VA = "0x71A66F0")]
		public List<string> _007B_0095_00BC_00B6_00BF_0080()
		{
			return null;
		}

		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x71A6A70", Offset = "0x71A2A70", VA = "0x71A6A70")]
		public List<string> _008A_005B_0095Yo_005E()
		{
			return null;
		}

		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x71A6B18", Offset = "0x71A2B18", VA = "0x71A6B18")]
		public bool m_00A0P_00B7_00A2_0088(string _005Efc_0089º_0089)
		{
			return default;
		}

		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x71A6BB4", Offset = "0x71A2BB4", VA = "0x71A6BB4")]
		public Dictionary<string, string> HÀU_00BFCe()
		{
			return null;
		}

		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x71A6F10", Offset = "0x71A2F10", VA = "0x71A6F10")]
		public int bD_00A4Z_0093L()
		{
			return default;
		}

		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x71A6F58", Offset = "0x71A2F58", VA = "0x71A6F58")]
		public string _007F_00B0_0090_008Bªi(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x71A700C", Offset = "0x71A300C", VA = "0x71A700C")]
		public int d_00B6j_0096QO()
		{
			return default;
		}

		[Token(Token = "0x6005A7E")]
		[Address(RVA = "0x71A7054", Offset = "0x71A3054", VA = "0x71A7054")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x71A705C", Offset = "0x71A305C", VA = "0x71A705C")]
		public bool ContainsAddress(string _00AFdV_00B0_0099_0082)
		{
			return default;
		}

		[Token(Token = "0x6005A80")]
		[Address(RVA = "0x71A70E8", Offset = "0x71A30E8", VA = "0x71A70E8")]
		public bool _00A2_00AFB_00A2_0085B(string _005Efc_0089º_0089)
		{
			return default;
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x71A64D0", Offset = "0x71A24D0", VA = "0x71A64D0")]
		private static string _00B2d_00A8C_00A8_00B0(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x71A7204", Offset = "0x71A3204", VA = "0x71A7204")]
		public List<string> _00BC_0086_0090_0095_00B7t()
		{
			return null;
		}

		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x71A6798", Offset = "0x71A2798", VA = "0x71A6798")]
		private void _009AM_00B4_00AF_009B_0093()
		{
		}

		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x71A6C38", Offset = "0x71A2C38", VA = "0x71A6C38")]
		private void CQ_0092_00A3_00BCÀ()
		{
		}

		[Token(Token = "0x6005A85")]
		[Address(RVA = "0x71A72AC", Offset = "0x71A32AC", VA = "0x71A72AC")]
		public Dictionary<string, string> XeÂ_0094yi()
		{
			return null;
		}

		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x71A7330", Offset = "0x71A3330", VA = "0x71A7330")]
		private void _00A5cc_00B7sP()
		{
		}

		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x71A733C", Offset = "0x71A333C", VA = "0x71A733C")]
		public Dictionary<string, string> _00A3q_00B6_00A9Mh()
		{
			return null;
		}

		[Token(Token = "0x6005A88")]
		[Address(RVA = "0x71A73C0", Offset = "0x71A33C0", VA = "0x71A73C0")]
		private static string _00B4B_00B6µ_00BD_0088(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x71A7440", Offset = "0x71A3440", VA = "0x71A7440")]
		public List<string> _008A_007DD_0097_00AD_008B()
		{
			return null;
		}

		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x71A74E8", Offset = "0x71A34E8", VA = "0x71A74E8")]
		public bool ContainsPath(string _005Efc_0089º_0089)
		{
			return default;
		}

		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0x71A7584", Offset = "0x71A3584", VA = "0x71A7584")]
		public List<string> GetAllAddresses()
		{
			return null;
		}

		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x71A762C", Offset = "0x71A362C", VA = "0x71A762C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x71A76CC", Offset = "0x71A36CC", VA = "0x71A76CC")]
		public bool V_007Ck_00B7_00A8_00A8(string _005Efc_0089º_0089)
		{
			return default;
		}

		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0x71A7768", Offset = "0x71A3768", VA = "0x71A7768")]
		public void W_00AB_00AD_0090_00AC_0060(string _00AFdV_00B0_0099_0082, string _005Efc_0089º_0089)
		{
		}

		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x71A796C", Offset = "0x71A396C", VA = "0x71A796C")]
		public void _00B2n_00B2_00A6G_008D()
		{
		}

		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x71A7930", Offset = "0x71A3930", VA = "0x71A7930")]
		private static string _007B_00B2_00A6_00BF_0093_00B7(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x71A7974", Offset = "0x71A3974", VA = "0x71A7974")]
		public AddressPathMapping()
		{
		}

		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x71A79F0", Offset = "0x71A39F0", VA = "0x71A79F0")]
		public Dictionary<string, string> Pr_007D_0096z_007F()
		{
			return null;
		}

		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x71A7A74", Offset = "0x71A3A74", VA = "0x71A7A74")]
		public void AddMapping(string _00AFdV_00B0_0099_0082, string _005Efc_0089º_0089)
		{
		}

		[Token(Token = "0x6005A94")]
		[Address(RVA = "0x71A7C34", Offset = "0x71A3C34", VA = "0x71A7C34")]
		public void _00BDd_00A5_0083_009C_00A1()
		{
		}

		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x71A7CD4", Offset = "0x71A3CD4", VA = "0x71A7CD4")]
		public string GetPathByAddress(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x71A7D78", Offset = "0x71A3D78", VA = "0x71A7D78")]
		private static string m_007DÁf_00B1K(string _00AFdV_00B0_0099_0082)
		{
			return null;
		}

		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x71A7DB4", Offset = "0x71A3DB4", VA = "0x71A7DB4")]
		public string _00B6PH_00B7_0089k(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x71A650C", Offset = "0x71A250C", VA = "0x71A650C")]
		private static string N_00AENPP_00A0(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6005A99")]
		[Address(RVA = "0x71A5E94", Offset = "0x71A1E94", VA = "0x71A5E94")]
		private void _007Cj_0091at_00A7()
		{
		}

		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0x71A7E68", Offset = "0x71A3E68", VA = "0x71A7E68")]
		public int GetMappingCount()
		{
			return default;
		}

		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0x71A7EB0", Offset = "0x71A3EB0", VA = "0x71A7EB0")]
		public List<string> GetAllPaths()
		{
			return null;
		}

		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x71A7F58", Offset = "0x71A3F58", VA = "0x71A7F58")]
		private void _00AFµW_00A9_008AR()
		{
		}

		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x71A7F60", Offset = "0x71A3F60", VA = "0x71A7F60")]
		private void i_007Fw_0091mk()
		{
		}

		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x71A7F6C", Offset = "0x71A3F6C", VA = "0x71A7F6C")]
		public string GetAddressByPath(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0x71A8020", Offset = "0x71A4020", VA = "0x71A8020")]
		public void RefreshDictionary()
		{
		}

		[Token(Token = "0x6005AA0")]
		[Address(RVA = "0x71A8028", Offset = "0x71A4028", VA = "0x71A8028")]
		public void _00A3bRg_0096_00A6(string _00AFdV_00B0_0099_0082, string _005Efc_0089º_0089)
		{
		}

		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0x71A81E8", Offset = "0x71A41E8", VA = "0x71A81E8")]
		public int s_00BEÂ_0087uf()
		{
			return default;
		}

		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0x71A8230", Offset = "0x71A4230", VA = "0x71A8230")]
		public List<string> _008CtChp_00AC()
		{
			return null;
		}

		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0x71A82D8", Offset = "0x71A42D8", VA = "0x71A82D8")]
		public void T_00BCx_008EfB()
		{
		}

		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x71A8378", Offset = "0x71A4378", VA = "0x71A8378")]
		public string v_0088O_00A8c_00B9(string _005Efc_0089º_0089)
		{
			return null;
		}

		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x71A7184", Offset = "0x71A3184", VA = "0x71A7184")]
		private static string _008E_0088_00AC_0098qb(string P_0084c_007DÀ_00A3)
		{
			return null;
		}
	}
}
