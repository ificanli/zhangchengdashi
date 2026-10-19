using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	[Token(Token = "0x2000075")]
	public sealed class AssetOperationHandle : OperationHandleBase, IDisposable, IResCallBackInfo
	{
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		private Action<AssetOperationHandle> p_007EVSds;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x30")]
		private UnityEngine.Object M_005B_008F_005Dh_00BE;

		[Token(Token = "0x1700003D")]
		public UnityEngine.Object AssetObject
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x718B064", Offset = "0x7187064", VA = "0x718B064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public UnityEngine.Object mainObject
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x718D0CC", Offset = "0x71890CC", VA = "0x718D0CC", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x718DBDC", Offset = "0x7189BDC", VA = "0x718DBDC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<AssetOperationHandle> Completed
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x718C5F8", Offset = "0x71885F8", VA = "0x718C5F8")]
			add
			{
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x718C96C", Offset = "0x718896C", VA = "0x718C96C")]
			remove
			{
			}
		}

		[SpecialName]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x718A42C", Offset = "0x718642C", VA = "0x718A42C")]
		public void qºZ_00A5X_00A6(Action<AssetOperationHandle> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x718A564", Offset = "0x7186564", VA = "0x718A564")]
		internal AssetOperationHandle() : base(null)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x718A580", Offset = "0x7186580", VA = "0x718A580", Slot = "15")]
		public GameObject NN_007E_0089_0092Z(bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x718A830", Offset = "0x7186830", VA = "0x718A830")]
		public GameObject _0084e_0091c_00B7_007C(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x718A8F8", Offset = "0x71868F8", VA = "0x718A8F8", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x718A998", Offset = "0x7186998", VA = "0x718A998")]
		public GameObject _00BF_0091_0098xÁu(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x718AA64", Offset = "0x7186A64", VA = "0x718AA64")]
		internal AssetOperationHandle(_00A2_00A1_00B8Hcp k_00ABHJ_0083R) : base(k_00ABHJ_0083R)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x718AAA0", Offset = "0x7186AA0", VA = "0x718AAA0")]
		public GameObject u_0081B_00BC_008E_00AC(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x718AC5C", Offset = "0x7186C5C", VA = "0x718AC5C")]
		public void WaitForAsyncComplete()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x718AC8C", Offset = "0x7186C8C", VA = "0x718AC8C")]
		public InstantiateOperation InstantiateAsync(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x718ADA4", Offset = "0x7186DA4", VA = "0x718ADA4")]
		public void wq_0084_009A_00B4_00BD(Action<AssetOperationHandle> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x718AEDC", Offset = "0x7186EDC", VA = "0x718AEDC")]
		public GameObject _008EÁx_0091_00BB_00BE(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x718AFA8", Offset = "0x7186FA8", VA = "0x718AFA8", Slot = "16")]
		public GameObject _0099_0096_00A7vS_00B6(string _00AEv_009C_0083Qt, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x718AAB4", Offset = "0x7186AB4", VA = "0x718AAB4")]
		private GameObject _00B6Vv_0093_007D_00B7(bool _009FpN_0082_00B7º, Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp, bool _00B4Wµq_00B6q, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x718B38C", Offset = "0x718738C", VA = "0x718B38C")]
		public InstantiateOperation _005DjV_00B6C_00B4()
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x718B548", Offset = "0x7187548", VA = "0x718B548")]
		public void J_0087_00A4_007E_0093_0090()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x718B5E8", Offset = "0x71875E8", VA = "0x718B5E8")]
		public GameObject Instantiate(Transform _0091zp_005Erp, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x718B6B0", Offset = "0x71876B0", VA = "0x718B6B0")]
		public GameObject InstantiateSync(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x718B778", Offset = "0x7187778", VA = "0x718B778")]
		public GameObject Instantiate(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x718B78C", Offset = "0x718778C", VA = "0x718B78C")]
		public GameObject _00B6Jeg_009A_00B6()
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x718B844", Offset = "0x7187844", VA = "0x718B844")]
		public InstantiateOperation InstantiateAsync(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		public TAsset GetAssetObject<TAsset>() where TAsset : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x718B854", Offset = "0x7187854", VA = "0x718B854")]
		public GameObject ed_00ADKt_00BE(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x718B868", Offset = "0x7187868", VA = "0x718B868")]
		public GameObject ª_00BE_00B1_0084Cf(Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x718B924", Offset = "0x7187924", VA = "0x718B924", Slot = "8")]
		internal override void _00B3Cq_009Cwl()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x718B944", Offset = "0x7187944", VA = "0x718B944")]
		public void _0093_00B9_007D_0096X_0094()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x718B974", Offset = "0x7187974", VA = "0x718B974", Slot = "13")]
		public GameObject Instantiate(bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x718BA30", Offset = "0x7187A30", VA = "0x718BA30")]
		public GameObject InstantiateSync(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x718BA44", Offset = "0x7187A44", VA = "0x718BA44")]
		public void _0088_00B1_009Bx_0081d()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x718BAE4", Offset = "0x7187AE4", VA = "0x718BAE4")]
		public GameObject Instantiate(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x718BAFC", Offset = "0x7187AFC", VA = "0x718BAFC")]
		public GameObject _00A4_0091_0081_0060_0081_00A3(Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x718A63C", Offset = "0x718663C", VA = "0x718A63C")]
		private GameObject _00BE_00B4_009D_00AF_007C_0089(bool _009FpN_0082_00B7º, Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp, bool _00B4Wµq_00B6q, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x718C730", Offset = "0x7188730", VA = "0x718C730", Slot = "17")]
		public UnityEngine.Object o_00A6Gm_0083_008C()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x718C7F0", Offset = "0x71887F0", VA = "0x718C7F0")]
		public GameObject InstantiateSync(Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x718C8AC", Offset = "0x71888AC", VA = "0x718C8AC")]
		public InstantiateOperation InstantiateAsync(Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x718C964", Offset = "0x7188964", VA = "0x718C964")]
		public GameObject _00A4_009E_00A3_00B8_0080_009B()
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x718CA68", Offset = "0x7188A68", VA = "0x718CA68")]
		public InstantiateOperation OzNz_00A1o(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x718CB2C", Offset = "0x7188B2C", VA = "0x718CB2C", Slot = "18")]
		public UnityEngine.Object _00B8_00B7_00B4U_00BFV()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x718CBEC", Offset = "0x7188BEC", VA = "0x718CBEC")]
		public void Release()
		{
		}

		[SpecialName]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x718CC8C", Offset = "0x7188C8C", VA = "0x718CC8C")]
		public void NJ_0098_00A2o_007B(Action<AssetOperationHandle> _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x718CD88", Offset = "0x7188D88", VA = "0x718CD88", Slot = "19")]
		public UnityEngine.Object _009Cº_0088_0097sA()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x718CE48", Offset = "0x7188E48", VA = "0x718CE48")]
		public GameObject Instantiate(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x718CF14", Offset = "0x7188F14", VA = "0x718CF14", Slot = "20")]
		public GameObject N_005E_009C_008B_0098_0089(bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x718CFD0", Offset = "0x7188FD0", VA = "0x718CFD0")]
		public void e_00A4_00B6_008AS_0096(Action<AssetOperationHandle> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x718D18C", Offset = "0x718918C", VA = "0x718D18C")]
		public GameObject T_00A7CCM_00A5(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x718D1A0", Offset = "0x71891A0", VA = "0x718D1A0")]
		public GameObject xu_0085_00B8_005B_00A3()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x718D258", Offset = "0x7189258", VA = "0x718D258", Slot = "14")]
		public GameObject Instantiate(string _00AEv_009C_0083Qt, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x718D314", Offset = "0x7189314", VA = "0x718D314")]
		public void _00B1PB_0088_005E_007D(Action<AssetOperationHandle> _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x718D44C", Offset = "0x718944C", VA = "0x718D44C")]
		public InstantiateOperation InstantiateAsync()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x718D500", Offset = "0x7189500", VA = "0x718D500")]
		public GameObject J_00A5v_00B9Á_00AC(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x718D514", Offset = "0x7189514", VA = "0x718D514")]
		public GameObject _00A6_0080_0095_00A0J_00BE(Transform _0091zp_005Erp, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x718D5DC", Offset = "0x71895DC", VA = "0x718D5DC", Slot = "21")]
		public void _008D_009AlgX_0084(UnityEngine.Object _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x718D734", Offset = "0x7189734", VA = "0x718D734")]
		public GameObject W_008D_00AD_00A6b_0085()
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x718D7EC", Offset = "0x71897EC", VA = "0x718D7EC")]
		public InstantiateOperation _00B3_00A0_009F_00AD_0092_007C()
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x718D8A0", Offset = "0x71898A0", VA = "0x718D8A0")]
		public void NFhz_009Cr()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x718D8D0", Offset = "0x71898D0", VA = "0x718D8D0")]
		public GameObject InstantiateSync(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x718AC9C", Offset = "0x7186C9C", VA = "0x718AC9C")]
		private InstantiateOperation IM_00ABEO_00B0(bool _009FpN_0082_00B7º, Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x718D978", Offset = "0x7189978", VA = "0x718D978")]
		public GameObject eÀFÂ_00B1C(Transform _0091zp_005Erp, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x718DA40", Offset = "0x7189A40", VA = "0x718DA40")]
		public GameObject _00B4l_00AC_009BWp(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x718DA54", Offset = "0x7189A54", VA = "0x718DA54")]
		public GameObject InstantiateSync()
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x718DB0C", Offset = "0x7189B0C", VA = "0x718DB0C")]
		public GameObject _00A9_00BErN_009Bw(Transform _0091zp_005Erp, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x718DBD4", Offset = "0x7189BD4", VA = "0x718DBD4")]
		public GameObject Instantiate()
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x718DD30", Offset = "0x7189D30", VA = "0x718DD30")]
		public GameObject RSF_00AErl(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x718DD44", Offset = "0x7189D44", VA = "0x718DD44")]
		public InstantiateOperation InstantiateAsync(Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x718B440", Offset = "0x7187440", VA = "0x718B440")]
		private InstantiateOperation v_009B_008Cx_00BFS(bool _009FpN_0082_00B7º, Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, Transform _0091zp_005Erp, bool _00B4Wµq_00B6q)
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x718DE08", Offset = "0x7189E08", VA = "0x718DE08")]
		public InstantiateOperation f_005Du_007E_008B_005D(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X)
		{
			return null;
		}
	}
}
