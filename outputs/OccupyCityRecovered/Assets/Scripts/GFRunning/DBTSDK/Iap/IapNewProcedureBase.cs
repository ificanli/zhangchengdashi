using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C5")]
	public abstract class IapNewProcedureBase : IIap
	{
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, Commodity> _0082_00AC_00A6ª_0099µ;

		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x70")]
		private bool _00AD_00AB_00A2_00A2_0098p;

		[Token(Token = "0x600505B")]
		[Address(RVA = "0x710CA48", Offset = "0x7108A48", VA = "0x710CA48", Slot = "4")]
		public override void InitIap(bool Jc_0089Á_0095_0094 = true, bool _0087_0097ªO_00B0_009E = true)
		{
		}

		[Token(Token = "0x600505C")]
		[Address(RVA = "0x710CF04", Offset = "0x7108F04", VA = "0x710CF04")]
		public bool HaveCommodity(string Ng_00B0_009D_0091_008F)
		{
			return default;
		}

		[Token(Token = "0x600505D")]
		[Address(RVA = "0x710D010", Offset = "0x7109010", VA = "0x710D010")]
		private void _00A7_0093s_00A8_0081p(string Ng_00B0_009D_0091_008F, string _0088_0084_007E_00B2_0099_009C, int p_007F_007C_0089_008D_00A1 = 2, string _007D_00B4B_007En_00B7 = "")
		{
		}

		[Token(Token = "0x600505E")]
		[Address(RVA = "0x710D1F8", Offset = "0x71091F8", VA = "0x710D1F8")]
		private void _0096_00AC_0092Y_00A6_005B(string Ng_00B0_009D_0091_008F)
		{
		}

		[Token(Token = "0x600505F")]
		[Address(RVA = "0x710D390", Offset = "0x7109390", VA = "0x710D390")]
		public bool TryGetCommodity(string Ng_00B0_009D_0091_008F, out Commodity ÁÂ_00A5_008DB_00B9)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IapNewProcedureBase.TryGetCommodity RVA=0x710D390 Token=0x600505F");
}

		[Token(Token = "0x6005060")]
		[Address(RVA = "0x710D420", Offset = "0x7109420", VA = "0x710D420")]
		public void RequestBuyProduct(string Ng_00B0_009D_0091_008F, string k_00AD_00BE_008AHR, string _009E_00AF_0091o_00BB_00A9 = "", bool _0091GDS_005B_00B2 = true, bool F_0084_007Csf_008E = false)
		{
		}

		[Token(Token = "0x6005061")]
		[Address(RVA = "0x710D750", Offset = "0x7109750", VA = "0x710D750")]
		public void RequestBuyProduct(string Ng_00B0_009D_0091_008F, string _009E_00AF_0091o_00BB_00A9 = "", bool _0091GDS_005B_00B2 = true, bool F_0084_007Csf_008E = false)
		{
		}

		[Token(Token = "0x6005062")]
		[Address(RVA = "0x710D42C", Offset = "0x710942C", VA = "0x710D42C")]
		private void S_005EMEeÀ(string Ng_00B0_009D_0091_008F, string k_00AD_00BE_008AHR = "", string _009E_00AF_0091o_00BB_00A9 = "", bool _0091GDS_005B_00B2 = true, bool F_0084_007Csf_008E = false)
		{
		}

		[Token(Token = "0x6005063")]
		[Address(RVA = "0x710DAF4", Offset = "0x7109AF4", VA = "0x710DAF4", Slot = "7")]
		internal override bool SendProductBase(OrderInfo jBu_005D_007Bk)
		{
			return default;
		}

		[Token(Token = "0x6005064")]
		[Address(RVA = "0x710E390", Offset = "0x710A390", VA = "0x710E390")]
		private bool _009F_0082_0060À_005BH(OrderInfo jBu_005D_007Bk, CommdityChannel _00B6u_0093_0089_00A8W)
		{
			return default;
		}

		[Token(Token = "0x6005065")]
		[Address(RVA = "0x710DB9C", Offset = "0x7109B9C", VA = "0x710DB9C")]
		private bool LeX_00AB_009E_0094(string _00B0_009Cf_00AFÂ_00A6, CommdityChannel _00B6u_0093_0089_00A8W, string _00A8AV_00B1W_00B7)
		{
			return default;
		}

		[Token(Token = "0x6005066")]
		[Address(RVA = "0x710DD2C", Offset = "0x7109D2C", VA = "0x710DD2C")]
		private bool _009F_0082_0060À_005BH(string _00B4_007D_009FL_00A0H, string _00A8AV_00B1W_00B7, CommdityChannel _00B6u_0093_0089_00A8W, bool c_005B_0060_009Fmc)
		{
			return default;
		}

		[Token(Token = "0x6005067")]
		[Address(RVA = "0x710E5B0", Offset = "0x710A5B0", VA = "0x710E5B0")]
		private void _009F_0082_0060À_005BH(List<OrderInfo> _009CUz_008D_00B0j, CommdityChannel _00B6u_0093_0089_00A8W)
		{
		}

		[Token(Token = "0x6005068")]
		[Address(RVA = "0x710E678", Offset = "0x710A678", VA = "0x710E678")]
		public void RequestCheckSubscription(string Ng_00B0_009D_0091_008F)
		{
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0x710E9B4", Offset = "0x710A9B4", VA = "0x710E9B4")]
		public void RequestCheckAllSubscription()
		{
		}

		[Token(Token = "0x600506A")]
		[Address(RVA = "0x710EB40", Offset = "0x710AB40", VA = "0x710EB40", Slot = "13")]
		internal override void SubscriptionResultBase(string _00BDNsdÂa, int µm_00BB_00A0_0080k, string _008CIfc_0094_0093)
		{
		}

		[Token(Token = "0x600506B")]
		[Address(RVA = "0x710EFF8", Offset = "0x710AFF8", VA = "0x710EFF8", Slot = "10")]
		internal override void SendFixOrdersProductBase(List<OrderInfo> Z_005EgLE_007C)
		{
		}

		[Token(Token = "0x600506C")]
		[Address(RVA = "0x710F004", Offset = "0x710B004", VA = "0x710F004", Slot = "11")]
		internal override void SendFailedOrdersProductBase(List<OrderInfo> Z_005EgLE_007C)
		{
		}

		[Token(Token = "0x600506D")]
		[Address(RVA = "0x710F010", Offset = "0x710B010", VA = "0x710F010")]
		public void RequestRestoreBuy()
		{
		}

		[Token(Token = "0x600506E")]
		[Address(RVA = "0x710F384", Offset = "0x710B384", VA = "0x710F384", Slot = "12")]
		internal override void SendRestoreOrdersProductBase(List<OrderInfo> Z_005EgLE_007C)
		{
		}

		[Token(Token = "0x600506F")]
		[Address(RVA = "0x710F390", Offset = "0x710B390", VA = "0x710F390", Slot = "18")]
		protected override void ReceiveRefundProduct(string _0098E_00A8_009B_0083Á, int _00BEHAM_0091_0089)
		{
		}

		[Token(Token = "0x6005070")]
		[Address(RVA = "0x710F398", Offset = "0x710B398", VA = "0x710F398", Slot = "17")]
		protected override void InitOver()
		{
		}

		[Token(Token = "0x6005071")]
		[Address(RVA = "0x710F81C", Offset = "0x710B81C", VA = "0x710F81C", Slot = "20")]
		protected virtual void ReceiveConsumableCommodity(CommdityChannel _00B6u_0093_0089_00A8W, params string[] Ng_00B0_009D_0091_008F)
		{
		}

		[Token(Token = "0x6005072")]
		[Address(RVA = "0x710F820", Offset = "0x710B820", VA = "0x710F820", Slot = "21")]
		protected virtual void ReceiveConsumableCommodity(ConsumableState xyJrº_0095)
		{
		}

		[Token(Token = "0x6005073")]
		[Address(RVA = "0x710F824", Offset = "0x710B824", VA = "0x710F824", Slot = "22")]
		protected virtual void ReshNonConsumableState(string Ng_00B0_009D_0091_008F)
		{
		}

		[Token(Token = "0x6005074")]
		[Address(RVA = "0x710F828", Offset = "0x710B828", VA = "0x710F828", Slot = "23")]
		protected virtual void ReshNonConsumableState(string Ng_00B0_009D_0091_008F, int µm_00BB_00A0_0080k)
		{
		}

		[Token(Token = "0x6005075")]
		[Address(RVA = "0x710F82C", Offset = "0x710B82C", VA = "0x710F82C", Slot = "24")]
		protected virtual void ReshNonConsumableState(NonConsumableState µm_00BB_00A0_0080k)
		{
		}

		[Token(Token = "0x6005076")]
		[Address(RVA = "0x710F830", Offset = "0x710B830", VA = "0x710F830")]
		protected IapNewProcedureBase()
		{
		}
	}
}
