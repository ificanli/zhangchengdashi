using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x200031F")]
	public class AudioManager
	{
		[Token(Token = "0x400193B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager r_009A_008Bn_00BC_0088;

		[Token(Token = "0x400193C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AudioListener e_00B0_00B4_0086u_009F;

		[Token(Token = "0x400193D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject _0090_0087_00AB_0095j_00B4;

		[Token(Token = "0x400193E")]
		private const int ZÂq_005BÀW = 1;

		[Token(Token = "0x400193F")]
		private const int _0093_0081_00AD_00BC_007DÁ = 10000;

		[Token(Token = "0x4001940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, AudioCompositeBase> J_00BF_00B0_0098_009B_00B1;

		[Token(Token = "0x4001941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, AudioData> _00B6_007EhgU_0081;

		[Token(Token = "0x4001942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, float> _007F_0091ZÁP_00AB;

		[Token(Token = "0x4001943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, string> _0095_007C_0087N_00B8_008B;

		[Token(Token = "0x4001944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _00A0QUsyF;

		[Token(Token = "0x4001945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _00A1_008C_0096_0093s_00B9;

		[Token(Token = "0x4001946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Á_0099_0085SHc;

		[Token(Token = "0x170010BF")]
		public static AudioManager Instance
		{
			[Token(Token = "0x60054B5")]
			[Address(RVA = "0x713FE34", Offset = "0x713BE34", VA = "0x713FE34")]
			get
			{
				return null;
			}
		}

		[SpecialName]
		[Token(Token = "0x6005483")]
		[Address(RVA = "0x7148710", Offset = "0x7144710", VA = "0x7148710")]
		public static AudioManager _00BDB_0097_00ADZ_008A()
		{
			return null;
		}

		[Token(Token = "0x6005484")]
		[Address(RVA = "0x7148864", Offset = "0x7144864", VA = "0x7148864")]
		private void _0090s_0096_00B7_009C_007E()
		{
		}

		[Token(Token = "0x6005485")]
		[Address(RVA = "0x7148940", Offset = "0x7144940", VA = "0x7148940")]
		private void _009C_00BE_00B8_00ACl_0099()
		{
		}

		[Token(Token = "0x6005486")]
		[Address(RVA = "0x71489B8", Offset = "0x71449B8", VA = "0x71489B8")]
		private void p_00B7_00BD_00ABT_0099()
		{
		}

		[Token(Token = "0x6005487")]
		[Address(RVA = "0x7148A90", Offset = "0x7144A90", VA = "0x7148A90")]
		public float _0099k_00B9_00BFp_00B3(string fJg_0097Aµ)
		{
			return default;
		}

		[Token(Token = "0x6005488")]
		[Address(RVA = "0x7148C88", Offset = "0x7144C88", VA = "0x7148C88")]
		public void ClearNode()
		{
		}

		[Token(Token = "0x6005489")]
		[Address(RVA = "0x7148D98", Offset = "0x7144D98", VA = "0x7148D98")]
		private void _00B9_008D_0091_009FS_00B4()
		{
		}

		[Token(Token = "0x600548A")]
		[Address(RVA = "0x7148E20", Offset = "0x7144E20", VA = "0x7148E20")]
		private void a_0097kÀhr()
		{
		}

		[Token(Token = "0x600548B")]
		[Address(RVA = "0x7149794", Offset = "0x7145794", VA = "0x7149794")]
		private void _005D_00BB_009C_007D_00B6_007F(int _0086Lji_00A7_00B7)
		{
		}

		[Token(Token = "0x600548C")]
		[Address(RVA = "0x7149824", Offset = "0x7145824", VA = "0x7149824")]
		private void R_0089s_00BDa_0088(int _0086Lji_00A7_00B7, AudioCompositeBase _00ACeTFO_00B0)
		{
		}

		[Token(Token = "0x600548D")]
		[Address(RVA = "0x71478B8", Offset = "0x71438B8", VA = "0x71478B8")]
		public string GetAndroidAudioID(int _00BFYÀb_0098_00B0)
		{
			return null;
		}

		[Token(Token = "0x600548E")]
		[Address(RVA = "0x714989C", Offset = "0x714589C", VA = "0x714989C")]
		private void h_00B1y_00A9mz()
		{
		}

		[Token(Token = "0x600548F")]
		[Address(RVA = "0x714A228", Offset = "0x7146228", VA = "0x714A228")]
		private void _00A3_009F_0098_007Cu_00AE()
		{
		}

		[Token(Token = "0x6005490")]
		[Address(RVA = "0x7147964", Offset = "0x7143964", VA = "0x7147964")]
		public float GetOnceAudioDuration(string fJg_0097Aµ)
		{
			return default;
		}

		[Token(Token = "0x6005491")]
		[Address(RVA = "0x714AB8C", Offset = "0x7146B8C", VA = "0x714AB8C")]
		public void MtbºFK(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005492")]
		[Address(RVA = "0x714AEE8", Offset = "0x7146EE8", VA = "0x714AEE8")]
		private void _00B1VYª_00A4_009B(int _0086Lji_00A7_00B7)
		{
		}

		[Token(Token = "0x6005493")]
		[Address(RVA = "0x714AF78", Offset = "0x7146F78", VA = "0x714AF78")]
		public void SetGameVolume(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005494")]
		[Address(RVA = "0x713FEA8", Offset = "0x713BEA8", VA = "0x713FEA8")]
		public AudioData GetAudioData(int _0086Lji_00A7_00B7)
		{
			return null;
		}

		[Token(Token = "0x6005495")]
		[Address(RVA = "0x714AFA0", Offset = "0x7146FA0", VA = "0x714AFA0")]
		public string _0095Q_00A6_008AS_00B9(int _00BFYÀb_0098_00B0)
		{
			return null;
		}

		[Token(Token = "0x6005496")]
		[Address(RVA = "0x714B04C", Offset = "0x714704C", VA = "0x714B04C")]
		public AudioCompositeBase CreateNode(AudioCompositeType _00A0l_008A_009Be_0085, [Optional] GameObject _00B7_00A8z_00A2X_00BE)
		{
			return null;
		}

		[Token(Token = "0x6005497")]
		[Address(RVA = "0x714B360", Offset = "0x7147360", VA = "0x714B360")]
		private void _00B2_0087P_008F_0081v(int _0086Lji_00A7_00B7, AudioCompositeBase _00ACeTFO_00B0)
		{
		}

		[Token(Token = "0x6005498")]
		[Address(RVA = "0x714ABB4", Offset = "0x7146BB4", VA = "0x714ABB4")]
		public void SetMusicGameVolume(VoiceType B_008A_0095h_005D_00AC, float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005499")]
		[Address(RVA = "0x714AD50", Offset = "0x7146D50", VA = "0x714AD50")]
		public void _0091_007Bp_00B7X_00AD(VoiceType B_008A_0095h_005D_00AC, float _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x714B3D8", Offset = "0x71473D8", VA = "0x714B3D8")]
		public static AudioManager z_00AE_0082_0093PÁ()
		{
			return null;
		}

		[Token(Token = "0x600549B")]
		[Address(RVA = "0x714B44C", Offset = "0x714744C", VA = "0x714B44C")]
		public void _0083_0096Y_00A0_005E_00A3(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600549C")]
		[Address(RVA = "0x714B474", Offset = "0x7147474", VA = "0x714B474")]
		public AudioCompositeBase _00A3_00B9_0084O_00A3_008D(AudioCompositeType _00A0l_008A_009Be_0085, [Optional] GameObject _00B7_00A8z_00A2X_00BE)
		{
			return null;
		}

		[Token(Token = "0x600549D")]
		[Address(RVA = "0x714B788", Offset = "0x7147788", VA = "0x714B788")]
		private void d_00A7_0080_0084WK()
		{
		}

		[Token(Token = "0x600549E")]
		[Address(RVA = "0x7149778", Offset = "0x7145778", VA = "0x7149778")]
		private void B_009D_00BEA_0095s()
		{
		}

		[Token(Token = "0x600549F")]
		[Address(RVA = "0x714B9F8", Offset = "0x71479F8", VA = "0x714B9F8")]
		public void MoveAudioListen(AudioMode _005D_00B6Y_00BC_008Ff)
		{
		}

		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x714BB08", Offset = "0x7147B08", VA = "0x714BB08")]
		public void _0080j_009F_00B1_0081_0060(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60054A1")]
		[Address(RVA = "0x714BB30", Offset = "0x7147B30", VA = "0x714BB30")]
		[Obsolete("已过时，请用InitAudioManager替换")]
		public void InitAudioManager(List<AudioData> y_00AEda_00B6º)
		{
		}

		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x714BEA0", Offset = "0x7147EA0", VA = "0x714BEA0")]
		public string CÀPVs_00BE(int _00BFYÀb_0098_00B0)
		{
			return null;
		}

		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x714BF4C", Offset = "0x7147F4C", VA = "0x714BF4C")]
		private void _0095_00AEpÀo_007F(int _0086Lji_00A7_00B7, AudioCompositeBase _00ACeTFO_00B0)
		{
		}

		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x714BFC4", Offset = "0x7147FC4", VA = "0x714BFC4")]
		public void InitAudioManager()
		{
		}

		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x714C58C", Offset = "0x714858C", VA = "0x714C58C")]
		private void _00B9_00A5_005B_007C_008CX()
		{
		}

		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x714C664", Offset = "0x7148664", VA = "0x714C664")]
		private void h_00A6_007C_0080_00B1q()
		{
		}

		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x714C740", Offset = "0x7148740", VA = "0x714C740")]
		private void L_0082_009CÀ_00BFV()
		{
		}

		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x714C7C8", Offset = "0x71487C8", VA = "0x714C7C8")]
		private void _008F_008B_00AB_008C_009F_0086()
		{
		}

		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x714CD94", Offset = "0x7148D94", VA = "0x714CD94")]
		public AudioCompositeBase h_00BB_008BuEÁ(AudioCompositeType _00A0l_008A_009Be_0085, [Optional] GameObject _00B7_00A8z_00A2X_00BE)
		{
			return null;
		}

		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x714D0A8", Offset = "0x71490A8", VA = "0x714D0A8")]
		private void Io_0091_008Cg_009F()
		{
		}

		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x714D184", Offset = "0x7149184", VA = "0x714D184")]
		private void _00BBQ_00BEB_00AEB()
		{
		}

		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x714BFC8", Offset = "0x7147FC8", VA = "0x714BFC8")]
		private void _0096_008BD_009B_0083S()
		{
		}

		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x7148784", Offset = "0x7144784", VA = "0x7148784")]
		public AudioManager()
		{
		}

		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x714D260", Offset = "0x7149260", VA = "0x714D260")]
		private void Y_005EF_0087_0086f()
		{
		}

		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x714B810", Offset = "0x7147810", VA = "0x714B810")]
		private void _009D_008C_0060Áy_0089()
		{
		}

		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x714D2D8", Offset = "0x71492D8", VA = "0x714D2D8")]
		private void _00B1_007B_008FM_00B4_00B6()
		{
		}

		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x714D3B0", Offset = "0x71493B0", VA = "0x714D3B0")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x714B8EC", Offset = "0x71478EC", VA = "0x714B8EC")]
		public void qµ_007B_00A9_00BB_0096(AudioMode _005D_00B6Y_00BC_008Ff)
		{
		}

		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x714D434", Offset = "0x7149434", VA = "0x714D434")]
		private void Pt_00B0_0097OE(int _0086Lji_00A7_00B7, AudioCompositeBase _00ACeTFO_00B0)
		{
		}

		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x714D4AC", Offset = "0x71494AC", VA = "0x714D4AC")]
		private void º_009Da_0096_00B1µ()
		{
		}

		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x714D588", Offset = "0x7149588", VA = "0x714D588")]
		private void _0095t_00AD_007B_00AF_0060()
		{
		}

		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x714DEF8", Offset = "0x7149EF8", VA = "0x714DEF8")]
		public void VDB_0095µº(List<AudioData> y_00AEda_00B6º)
		{
		}

		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x714E260", Offset = "0x714A260", VA = "0x714E260")]
		public float _00B3ªz_005Db_00A0(string fJg_0097Aµ)
		{
			return default;
		}

		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x714E458", Offset = "0x714A458", VA = "0x714E458")]
		public string j_0085K_009A_0088E(int _00BFYÀb_0098_00B0)
		{
			return null;
		}

		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x714E504", Offset = "0x714A504", VA = "0x714E504")]
		private void _008AX_0095_00A8_007Bn(int _0086Lji_00A7_00B7)
		{
		}

		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x714E594", Offset = "0x714A594", VA = "0x714E594")]
		public void _0097GVOr_00A6(float _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x714A20C", Offset = "0x714620C", VA = "0x714A20C")]
		private void _00BFe_00ABR_0088G()
		{
		}

		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x714E5BC", Offset = "0x714A5BC", VA = "0x714E5BC")]
		public AudioCompositeBase _0085w_009FÀ_00B7_00A1(AudioCompositeType _00A0l_008A_009Be_0085, [Optional] GameObject _00B7_00A8z_00A2X_00BE)
		{
			return null;
		}

		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x714E804", Offset = "0x714A804", VA = "0x714E804")]
		public string z_0088KC_00B0_0086(int _00BFYÀb_0098_00B0)
		{
			return null;
		}

		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x714E8B0", Offset = "0x714A8B0", VA = "0x714E8B0")]
		public void DestroyNode(int _0086Lji_00A7_00B7)
		{
		}
	}
}
