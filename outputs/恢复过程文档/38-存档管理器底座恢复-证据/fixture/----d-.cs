using System;
using System.Collections.Generic;
internal class _00B3_0092_00BF_0080d_0084 : IDisposable
{
	private List<_00A5_0091_007FQ_0080_00A6> _0083UV_00A0_00A5_0091;
	private int _0085_00A5ª_0081_00BDl;
	private bool DkwÂ_00A9Z;
	private int Do_00AC_009Co_0093;
	private int _0088_0080_00A3_0096_00B3c;
	private float _00B8_009E_0092_0097O_0098;
	private List<_00B4bv_00B0C_00BE> m_008B_008FX_008Fq;
	public _00B3_0092_00BF_0080d_0084()
	{
    _0083UV_00A0_00A5_0091 = new List<_00A5_0091_007FQ_0080_00A6>();
    DkwÂ_00A9Z = true;
    Do_00AC_009Co_0093 = 3;
    _0088_0080_00A3_0096_00B3c = 8192;
    m_008B_008FX_008Fq = new List<_00B4bv_00B0C_00BE>();
}
	private void Y_00A9cR_0088B(object[] h_00A6_00BB_00B2_0089w)
	{
	}
	internal void _007Dye_0080_00BCa()
	{
    _0083UV_00A0_00A5_0091.Clear();
    _0085_00A5ª_0081_00BDl = UpdateManager.AddHandle(_0090_00A2Y_00B2_00B4_0094);
    GameFramework.MsgDispatcher.AddEventListener("GF_HttpServerErrorCode", Â_0080TU_00BEn);
    GameFramework.MsgDispatcher.AddEventListener("GF_HttpWebRequestError", Y_00A9cR_0088B);
    GameFramework.MsgDispatcher.AddEventListener("GF_HttpServerSuccess", _00A5dWfk_0081);
    UnityEngine.Debug.LogWarning("[Recovery] Save backend registered its original Update/Msg callbacks; callback consumers and MsgDispatcher are unresolved. This does not confirm server storage readiness.");
}
	private void Â_0080TU_00BEn(object[] h_00A6_00BB_00B2_0089w)
	{
	}
	private void _0090_00A2Y_00B2_00B4_0094()
	{
	}
	private void _00A5dWfk_0081(object[] h_00A6_00BB_00B2_0089w)
	{
	}
	public void Dispose()
	{
	}
}
