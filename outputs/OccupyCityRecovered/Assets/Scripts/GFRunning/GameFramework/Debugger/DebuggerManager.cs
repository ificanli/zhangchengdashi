using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameFramework.Debugger
{
	[Token(Token = "0x20004AB")]
	public sealed class DebuggerManager
	{
		[Token(Token = "0x20004AC")]
		private sealed class _009D_008A_0086_00AE_008A_00BB : IDebuggerWindowGroup, IDebuggerWindow
		{
			[Token(Token = "0x4001F2D")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<KeyValuePair<string, IDebuggerWindow>> X_0060_0081_00AEºY;

			[Token(Token = "0x4001F2E")]
			[FieldOffset(Offset = "0x18")]
			private int _00AEL_0089s_0081_00A6;

			[Token(Token = "0x4001F2F")]
			[FieldOffset(Offset = "0x20")]
			private string[] a_007F_00A1_0089d_008C;

			[Token(Token = "0x1700121B")]
			public int DebuggerWindowCount
			{
				[Token(Token = "0x6007024")]
				[Address(RVA = "0x72AA6C0", Offset = "0x72A66C0", VA = "0x72AA6C0", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700121C")]
			public int SelectedIndex
			{
				[Token(Token = "0x600701D")]
				[Address(RVA = "0x72AA6A8", Offset = "0x72A66A8", VA = "0x72AA6A8", Slot = "5")]
				get
				{
					return default;
				}
				[Token(Token = "0x6007017")]
				[Address(RVA = "0x72AA698", Offset = "0x72A6698", VA = "0x72AA698", Slot = "6")]
				set
				{
				}
			}

			[Token(Token = "0x1700121D")]
			public IDebuggerWindow SelectedWindow
			{
				[Token(Token = "0x600701A")]
				[Address(RVA = "0x72A9A74", Offset = "0x72A5A74", VA = "0x72A9A74", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6006FF5")]
			[Address(RVA = "0x72A7538", Offset = "0x72A3538", VA = "0x72A7538", Slot = "17")]
			public void N_008FaVdT()
			{
			}

			[Token(Token = "0x6006FF6")]
			[Address(RVA = "0x72A950C", Offset = "0x72A550C", VA = "0x72A950C")]
			private void _00B2_0082_00B8_00B6_00B2_0088()
			{
			}

			[Token(Token = "0x6006FF7")]
			[Address(RVA = "0x72A86B8", Offset = "0x72A46B8", VA = "0x72A86B8", Slot = "10")]
			public void RegisterDebuggerWindow(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB)
			{
			}

			[Token(Token = "0x6006FF8")]
			[Address(RVA = "0x72A99C0", Offset = "0x72A59C0", VA = "0x72A99C0", Slot = "13")]
			public void OnEnter()
			{
			}

			[Token(Token = "0x6006FF9")]
			[Address(RVA = "0x72A9AFC", Offset = "0x72A5AFC", VA = "0x72A9AFC", Slot = "14")]
			public void OnLeave()
			{
			}

			[Token(Token = "0x6006FFA")]
			[Address(RVA = "0x72A7AF0", Offset = "0x72A3AF0", VA = "0x72A7AF0", Slot = "18")]
			public void _0092Z_0080Y_0097d(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB)
			{
			}

			[Token(Token = "0x6006FFB")]
			[Address(RVA = "0x72A8C90", Offset = "0x72A4C90", VA = "0x72A8C90")]
			public _009D_008A_0086_00AE_008A_00BB()
			{
			}

			[Token(Token = "0x6006FFC")]
			[Address(RVA = "0x72A9D54", Offset = "0x72A5D54", VA = "0x72A9D54", Slot = "19")]
			public void _00BD_0083_00BFc_00A3_0099(object[] _00BC_00AE_007DW_00A3_0090)
			{
			}

			[Token(Token = "0x6006FFD")]
			[Address(RVA = "0x72A7750", Offset = "0x72A3750", VA = "0x72A7750", Slot = "9")]
			public IDebuggerWindow GetDebuggerWindow(string P_0084c_007DÀ_00A3)
			{
				return null;
			}

			[Token(Token = "0x6006FFE")]
			[Address(RVA = "0x72A9D58", Offset = "0x72A5D58", VA = "0x72A9D58", Slot = "20")]
			public void º_00ABq_00B8_0098_00BB()
			{
			}

			[Token(Token = "0x6006FFF")]
			[Address(RVA = "0x72A8460", Offset = "0x72A4460", VA = "0x72A8460")]
			public bool ÂCr_008Dmm(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x6007000")]
			[Address(RVA = "0x72A9E0C", Offset = "0x72A5E0C", VA = "0x72A9E0C")]
			private bool _0086Cf_00BE_008D_00A8(string _00AE_008C_009AiPJ)
			{
				return default;
			}

			[Token(Token = "0x6007001")]
			[Address(RVA = "0x72A9FD0", Offset = "0x72A5FD0", VA = "0x72A9FD0", Slot = "8")]
			public string[] GetDebuggerWindowNames()
			{
				return null;
			}

			[Token(Token = "0x6007002")]
			[Address(RVA = "0x72A9FD8", Offset = "0x72A5FD8", VA = "0x72A9FD8", Slot = "11")]
			public void Initialize(params object[] _00BC_00AE_007DW_00A3_0090)
			{
			}

			[SpecialName]
			[Token(Token = "0x6007003")]
			[Address(RVA = "0x72A9FDC", Offset = "0x72A5FDC", VA = "0x72A9FDC", Slot = "21")]
			public void _0083_00B9_00A4_007BL_00A1(int _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x6007004")]
			[Address(RVA = "0x72A9FE4", Offset = "0x72A5FE4", VA = "0x72A9FE4", Slot = "22")]
			public void _009C_0083zq_00A9_00AD(object[] _00BC_00AE_007DW_00A3_0090)
			{
			}

			[Token(Token = "0x6007005")]
			[Address(RVA = "0x72A9EAC", Offset = "0x72A5EAC", VA = "0x72A9EAC")]
			public bool _00A2rc_009C_008D_00A5(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x6007006")]
			[Address(RVA = "0x72A9BB0", Offset = "0x72A5BB0", VA = "0x72A9BB0")]
			private void h_00B8_008AÂM_00A1()
			{
			}

			[Token(Token = "0x6007007")]
			[Address(RVA = "0x72AA1C0", Offset = "0x72A61C0", VA = "0x72AA1C0", Slot = "23")]
			public string[] cB_00A0_00A3P_00B7()
			{
				return null;
			}

			[Token(Token = "0x6007008")]
			[Address(RVA = "0x72AA1C8", Offset = "0x72A61C8", VA = "0x72AA1C8", Slot = "24")]
			public void _00B9P_009F_009FdN(object[] _00BC_00AE_007DW_00A3_0090)
			{
			}

			[SpecialName]
			[Token(Token = "0x6007009")]
			[Address(RVA = "0x72AA1CC", Offset = "0x72A61CC", VA = "0x72AA1CC", Slot = "25")]
			public void _00A5J_008F_0095_00A9U(int _00A3_0092T_007E_00ABc)
			{
			}

			[Token(Token = "0x600700A")]
			[Address(RVA = "0x72AA1D4", Offset = "0x72A61D4", VA = "0x72AA1D4", Slot = "26")]
			public void _0088_007CCDH_0085(object[] _00BC_00AE_007DW_00A3_0090)
			{
			}

			[Token(Token = "0x600700B")]
			[Address(RVA = "0x72AA1D8", Offset = "0x72A61D8", VA = "0x72AA1D8", Slot = "27")]
			public void _0087v_009A_00B6Um()
			{
			}

			[Token(Token = "0x600700C")]
			[Address(RVA = "0x72A931C", Offset = "0x72A531C", VA = "0x72A931C")]
			public bool UnregisterDebuggerWindow(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x600700D")]
			[Address(RVA = "0x72AA28C", Offset = "0x72A628C", VA = "0x72AA28C", Slot = "28")]
			public void A_00AFDy_008B_0090()
			{
			}

			[Token(Token = "0x600700E")]
			[Address(RVA = "0x72A90F8", Offset = "0x72A50F8", VA = "0x72A90F8")]
			public bool _00BBS_008F_0084_00B9_00A6(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x600700F")]
			[Address(RVA = "0x72AA4E4", Offset = "0x72A64E4", VA = "0x72AA4E4", Slot = "29")]
			public void _00A7_008E_009E_00ADZ_0097()
			{
			}

			[Token(Token = "0x6007010")]
			[Address(RVA = "0x72A7894", Offset = "0x72A3894", VA = "0x72A7894")]
			public bool SelectDebuggerWindow(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x6007011")]
			[Address(RVA = "0x72A9FE8", Offset = "0x72A5FE8", VA = "0x72A9FE8")]
			private bool _009Cz_00A1_00B8k_0086(string _00AE_008C_009AiPJ)
			{
				return default;
			}

			[SpecialName]
			[Token(Token = "0x6007012")]
			[Address(RVA = "0x72AA4E8", Offset = "0x72A64E8", VA = "0x72AA4E8", Slot = "30")]
			public int ÀZv_00AB_008D_007E()
			{
				return default;
			}

			[Token(Token = "0x6007013")]
			[Address(RVA = "0x72A7F64", Offset = "0x72A3F64", VA = "0x72A7F64")]
			public bool _00BD_0094_00A9_0097_00A5M(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x6007014")]
			[Address(RVA = "0x72AA530", Offset = "0x72A6530", VA = "0x72AA530")]
			private bool _0088y_00A5_0094_00AD_0083(string _00AE_008C_009AiPJ)
			{
				return default;
			}

			[Token(Token = "0x6007015")]
			[Address(RVA = "0x72AA5E0", Offset = "0x72A65E0", VA = "0x72AA5E0", Slot = "31")]
			public void _009AEr_00BCI_00A8()
			{
			}

			[Token(Token = "0x6007016")]
			[Address(RVA = "0x72AA5E4", Offset = "0x72A65E4", VA = "0x72AA5E4", Slot = "32")]
			public void ºmq_005Ez_00A8()
			{
			}

			[Token(Token = "0x6007018")]
			[Address(RVA = "0x72A81C0", Offset = "0x72A41C0", VA = "0x72A81C0", Slot = "15")]
			public void OnUpdate(float _008EJ_0092_009BUc, float rfjÀ_0098L)
			{
			}

			[Token(Token = "0x6007019")]
			[Address(RVA = "0x72A981C", Offset = "0x72A581C", VA = "0x72A981C")]
			private void _00BB_0085S_007E_0083À()
			{
			}

			[SpecialName]
			[Token(Token = "0x600701B")]
			[Address(RVA = "0x72AA6A0", Offset = "0x72A66A0", VA = "0x72AA6A0", Slot = "33")]
			public int _0091_005Bs_009C_00A9_0094()
			{
				return default;
			}

			[Token(Token = "0x600701C")]
			[Address(RVA = "0x72A96B0", Offset = "0x72A56B0", VA = "0x72A96B0")]
			private IDebuggerWindow _0085À_00BB_00AEb_00A8(string _00AE_008C_009AiPJ)
			{
				return null;
			}

			[Token(Token = "0x600701E")]
			[Address(RVA = "0x72AA6B0", Offset = "0x72A66B0", VA = "0x72AA6B0", Slot = "34")]
			public string[] I_00A6D_00AEaJ()
			{
				return null;
			}

			[Token(Token = "0x600701F")]
			[Address(RVA = "0x72A89F8", Offset = "0x72A49F8", VA = "0x72A89F8", Slot = "12")]
			public void Shutdown()
			{
			}

			[Token(Token = "0x6007020")]
			[Address(RVA = "0x72AA09C", Offset = "0x72A609C", VA = "0x72AA09C")]
			public bool _0098Â_00B6_0080_00BDW(string P_0084c_007DÀ_00A3)
			{
				return default;
			}

			[Token(Token = "0x6007021")]
			[Address(RVA = "0x72AA6B8", Offset = "0x72A66B8", VA = "0x72AA6B8", Slot = "16")]
			public void OnDraw()
			{
			}

			[Token(Token = "0x6007022")]
			[Address(RVA = "0x72AA6BC", Offset = "0x72A66BC", VA = "0x72AA6BC", Slot = "35")]
			public void _005B_007DÁ_0093Hµ()
			{
			}

			[Token(Token = "0x6007023")]
			[Address(RVA = "0x72AA340", Offset = "0x72A6340", VA = "0x72AA340")]
			private void yµÀ_00A1rf()
			{
			}
		}

		[Token(Token = "0x4001F2B")]
		[FieldOffset(Offset = "0x10")]
		private readonly _009D_008A_0086_00AE_008A_00BB ÂQ_0098ROµ;

		[Token(Token = "0x4001F2C")]
		[FieldOffset(Offset = "0x18")]
		private bool w_005B_00A0_00ADh_0096;

		[Token(Token = "0x17001219")]
		public bool ActiveWindow
		{
			[Token(Token = "0x6006FCA")]
			[Address(RVA = "0x72A7874", Offset = "0x72A3874", VA = "0x72A7874")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006FDD")]
			[Address(RVA = "0x72A8BF8", Offset = "0x72A4BF8", VA = "0x72A8BF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700121A")]
		public IDebuggerWindowGroup DebuggerWindowRoot
		{
			[Token(Token = "0x6006FC9")]
			[Address(RVA = "0x72A786C", Offset = "0x72A386C", VA = "0x72A786C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x72A7514", Offset = "0x72A3514", VA = "0x72A7514")]
		public void _005BMª_0083_00B0G()
		{
		}

		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x72A7738", Offset = "0x72A3738", VA = "0x72A7738")]
		public IDebuggerWindow k_007C_00BE_007D_009C_0085(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0x72A7858", Offset = "0x72A3858", VA = "0x72A7858")]
		public bool E_00B3gxS_008E()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x72A7860", Offset = "0x72A3860", VA = "0x72A7860")]
		public void _0096_0083_00A9_0097w_00B3(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x72A787C", Offset = "0x72A387C", VA = "0x72A787C")]
		public bool SelectDebuggerWindow(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x72A79B0", Offset = "0x72A39B0", VA = "0x72A79B0")]
		public void Vª_0086_00B0gZ(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x72A7DE8", Offset = "0x72A3DE8", VA = "0x72A7DE8")]
		public void _0060_0085h_00B3_00BF_008C(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0x72A7F28", Offset = "0x72A3F28", VA = "0x72A7F28")]
		public void _00AC_00A0_00A5Koº()
		{
		}

		[Token(Token = "0x6006FCF")]
		[Address(RVA = "0x72A7F4C", Offset = "0x72A3F4C", VA = "0x72A7F4C")]
		public bool _00B8_00BFW_007E_00A5_00BC(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FD0")]
		[Address(RVA = "0x72A8158", Offset = "0x72A4158", VA = "0x72A8158")]
		public IDebuggerWindow GetDebuggerWindow(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x6006FD1")]
		[Address(RVA = "0x72A8170", Offset = "0x72A4170", VA = "0x72A8170")]
		public void O_00BF_00BF_008B_00A4_00A1()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006FD2")]
		[Address(RVA = "0x72A8190", Offset = "0x72A4190", VA = "0x72A8190")]
		public IDebuggerWindowGroup O_0096_007B_00A6_00A9_00A1()
		{
			return null;
		}

		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0x72A8198", Offset = "0x72A4198", VA = "0x72A8198")]
		public void d_00A3_005B_00A5Jr(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x72A8290", Offset = "0x72A4290", VA = "0x72A8290")]
		public void z_008F_00A7gÂ_00A1(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x72A82B8", Offset = "0x72A42B8", VA = "0x72A82B8")]
		public IDebuggerWindowGroup _0083_00A9_0099ÀWF()
		{
			return null;
		}

		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x72A82C0", Offset = "0x72A42C0", VA = "0x72A82C0")]
		public void _00B9_007E_00A4L_008F_0089()
		{
		}

		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0x72A82E0", Offset = "0x72A42E0", VA = "0x72A82E0")]
		public void v_00A2k_008CMc(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FD8")]
		[Address(RVA = "0x72A8420", Offset = "0x72A4420", VA = "0x72A8420")]
		public void R_0083bx_007B_0099(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6006FD9")]
		[Address(RVA = "0x72A8448", Offset = "0x72A4448", VA = "0x72A8448")]
		public bool v_0098_00AB_0080_00B0_009D(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0x72A8578", Offset = "0x72A4578", VA = "0x72A8578")]
		public void _0083v_0098AÂ_009E(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FDB")]
		[Address(RVA = "0x72A89B0", Offset = "0x72A49B0", VA = "0x72A89B0")]
		public void _00A8_0091_0096_0098_0095_0091(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0x72A89D8", Offset = "0x72A49D8", VA = "0x72A89D8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0x72A8C04", Offset = "0x72A4C04", VA = "0x72A8C04")]
		public void _0085_00A4_00AB_009D_0092_008A(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0x72A8C2C", Offset = "0x72A4C2C", VA = "0x72A8C2C")]
		public DebuggerManager()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0x72A8D18", Offset = "0x72A4D18", VA = "0x72A8D18")]
		public void _005B_0096_00ABD_00ACx(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0x72A8D24", Offset = "0x72A4D24", VA = "0x72A8D24")]
		public IDebuggerWindow _0081_008FLd_0092_007F(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0x72A8D3C", Offset = "0x72A4D3C", VA = "0x72A8D3C")]
		public void _005BB_0092_00B9_007B_00BF(bool _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006FE3")]
		[Address(RVA = "0x72A8D48", Offset = "0x72A4D48", VA = "0x72A8D48")]
		public void P_008CPLDP(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0x72A8D54", Offset = "0x72A4D54", VA = "0x72A8D54")]
		public void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0x72A8D7C", Offset = "0x72A4D7C", VA = "0x72A8D7C")]
		public void _0090iÀrqY()
		{
		}

		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0x72A8D9C", Offset = "0x72A4D9C", VA = "0x72A8D9C")]
		public bool z_00B4_005ErD_007C(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FE7")]
		[Address(RVA = "0x72A8DB4", Offset = "0x72A4DB4", VA = "0x72A8DB4")]
		public void L_0091U_00ACT_00BD(float _008EJ_0092_009BUc, float rfjÀ_0098L)
		{
		}

		[SpecialName]
		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0x72A8DDC", Offset = "0x72A4DDC", VA = "0x72A8DDC")]
		public bool Q_0094Z_00AF_00AFr()
		{
			return default;
		}

		[Token(Token = "0x6006FE9")]
		[Address(RVA = "0x72A8DE4", Offset = "0x72A4DE4", VA = "0x72A8DE4")]
		public IDebuggerWindow _007E_008DH_005E_007D_009D(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0x72A8DFC", Offset = "0x72A4DFC", VA = "0x72A8DFC")]
		public bool _00B1_008A_00AFO_0091_00BE()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006FEB")]
		[Address(RVA = "0x72A8E04", Offset = "0x72A4E04", VA = "0x72A8E04")]
		public bool uI_009CWRe()
		{
			return default;
		}

		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0x72A8E0C", Offset = "0x72A4E0C", VA = "0x72A8E0C")]
		public bool _00B7_00B7_0086_008C_007C_009D(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FED")]
		[Address(RVA = "0x72A8E24", Offset = "0x72A4E24", VA = "0x72A8E24")]
		public bool _009C_00B3_0091n_00B3_00AE(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0x72A8E3C", Offset = "0x72A4E3C", VA = "0x72A8E3C")]
		public void d_0089_0084_009C_0084_0095(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0x72A8E48", Offset = "0x72A4E48", VA = "0x72A8E48")]
		public void _00BF_0097_00ABL_007C_0086(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x72A8F88", Offset = "0x72A4F88", VA = "0x72A8F88")]
		public void RegisterDebuggerWindow(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB, params object[] _00BC_00AE_007DW_00A3_0090)
		{
		}

		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x72A90C8", Offset = "0x72A50C8", VA = "0x72A90C8")]
		public bool _0092z_00A9_007Dt_009C(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x72A90E0", Offset = "0x72A50E0", VA = "0x72A90E0")]
		public bool zÀA_00AC_0082_009D(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FF3")]
		[Address(RVA = "0x72A92EC", Offset = "0x72A52EC", VA = "0x72A92EC")]
		public bool _0094_00A7_0081_0093_00ADª(string P_0084c_007DÀ_00A3)
		{
			return default;
		}

		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0x72A9304", Offset = "0x72A5304", VA = "0x72A9304")]
		public bool UnregisterDebuggerWindow(string P_0084c_007DÀ_00A3)
		{
			return default;
		}
	}
}
