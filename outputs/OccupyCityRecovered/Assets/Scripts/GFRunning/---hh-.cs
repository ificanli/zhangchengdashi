using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007F")]
internal abstract class _0081_0090_00A9hh_00B4
{
	[Token(Token = "0x2000080")]
	public enum EStatus
	{
		[Token(Token = "0x400018D")]
		None = 0,
		[Token(Token = "0x400018E")]
		Succeed = 1,
		[Token(Token = "0x400018F")]
		Failed = 2
	}

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x10")]
	private _0087LLP_0097_00B8 _0098_0060r_00A6_0099e;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x18")]
	private _007DYXCc_008B _00B1º_00ABzlY;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x20")]
	private int Eª_00A1_0093p_008B;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x24")]
	private EStatus _0084xno_0093_00AD;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x28")]
	private string _0080_0095ª_0084_00A3_00B9;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x30")]
	private bool zL_00BE_008CÁ_00B6;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<_00A2_00A1_00B8Hcp> VM_008Agn_008D;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x40")]
	private AssetBundle Xµ_00B9OW_00BD;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x48")]
	private string _0097_0095X_0080gg;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x50")]
	private float _009Ep_009B_005D_008BB;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x58")]
	private ulong _008Aaj_0099_009Bx;

	[Token(Token = "0x1700004C")]
	public _0087LLP_0097_00B8 Impl
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x7193FD4", Offset = "0x718FFD4", VA = "0x7193FD4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x7193FCC", Offset = "0x718FFCC", VA = "0x7193FCC")]
		private set
		{
			_0060_005EJg_00B1_0099(value);
		}
	}

	[Token(Token = "0x1700004D")]
	public _007DYXCc_008B MainBundleInfo
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x7193FE4", Offset = "0x718FFE4", VA = "0x7193FE4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x7193FDC", Offset = "0x718FFDC", VA = "0x7193FDC")]
		private set
		{
			_00B0S_00A3_009D_009FJ(value);
		}
	}

	[Token(Token = "0x1700004E")]
	public int RefCount
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7193FF4", Offset = "0x718FFF4", VA = "0x7193FF4")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7193FEC", Offset = "0x718FFEC", VA = "0x7193FEC")]
		private set
		{
			_0099_0060µu_00B1_00B9(value);
		}
	}

	[Token(Token = "0x1700004F")]
	public EStatus Status
	{
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x7194004", Offset = "0x7190004", VA = "0x7194004")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x7193FFC", Offset = "0x718FFFC", VA = "0x7193FFC")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public string LastError
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x7194014", Offset = "0x7190014", VA = "0x7194014")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x719400C", Offset = "0x719000C", VA = "0x719400C")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public bool IsDestroyed
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x7194028", Offset = "0x7190028", VA = "0x7194028")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x719401C", Offset = "0x719001C", VA = "0x719401C")]
		private set
		{
			_008D_00AEeW_0099Á(value);
		}
	}

	[Token(Token = "0x17000052")]
	public List<_00A2_00A1_00B8Hcp> Providers
	{
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x7194030", Offset = "0x7190030", VA = "0x7194030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	internal AssetBundle JÁ_00B4_0086_0081_0081
	{
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x7194040", Offset = "0x7190040", VA = "0x7194040")]
		get
		{
			return _00A2Hd_005D_00AEe();
		}
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x7194038", Offset = "0x7190038", VA = "0x7194038")]
		set
		{
			ut_00ABµ_0098_0096(value);
		}
	}

	[Token(Token = "0x17000054")]
	internal string iBµF_00B8x
	{
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x7194050", Offset = "0x7190050", VA = "0x7194050")]
		get
		{
			return _00AE_0091iª_009CT();
		}
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x7194048", Offset = "0x7190048", VA = "0x7194048")]
		set
		{
			o_00A0QºP_0089(value);
		}
	}

	[Token(Token = "0x17000055")]
	internal float J_009BC_0091_00A2i
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x7194060", Offset = "0x7190060", VA = "0x7194060")]
		get
		{
			return _0080FDoÁ_0081();
		}
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x7194058", Offset = "0x7190058", VA = "0x7194058")]
		set
		{
			P_007D_007FGos(value);
		}
	}

	[Token(Token = "0x17000056")]
	internal ulong X_00AD_0093F_00B4_005E
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x7194070", Offset = "0x7190070", VA = "0x7194070")]
		get
		{
			return Cxj_00AFpW();
		}
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x7194068", Offset = "0x7190068", VA = "0x7194068")]
		set
		{
			IE_00BD_008DIX(value);
		}
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x7193FCC", Offset = "0x718FFCC", VA = "0x7193FCC")]
	private void _0060_005EJg_00B1_0099(_0087LLP_0097_00B8 _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x7193FDC", Offset = "0x718FFDC", VA = "0x7193FDC")]
	private void _00B0S_00A3_009D_009FJ(_007DYXCc_008B _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x7193FEC", Offset = "0x718FFEC", VA = "0x7193FEC")]
	private void _0099_0060µu_00B1_00B9(int _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x719401C", Offset = "0x719001C", VA = "0x719401C")]
	private void _008D_00AEeW_0099Á(bool _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x7194038", Offset = "0x7190038", VA = "0x7194038")]
	internal void ut_00ABµ_0098_0096(AssetBundle _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x7194040", Offset = "0x7190040", VA = "0x7194040")]
	internal AssetBundle _00A2Hd_005D_00AEe()
	{
		return null;
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x7194048", Offset = "0x7190048", VA = "0x7194048")]
	internal void o_00A0QºP_0089(string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x7194050", Offset = "0x7190050", VA = "0x7194050")]
	internal string _00AE_0091iª_009CT()
	{
		return null;
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x7194058", Offset = "0x7190058", VA = "0x7194058")]
	internal void P_007D_007FGos(float _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x7194060", Offset = "0x7190060", VA = "0x7194060")]
	internal float _0080FDoÁ_0081()
	{
		return default;
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x7194068", Offset = "0x7190068", VA = "0x7194068")]
	internal void IE_00BD_008DIX(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x7194070", Offset = "0x7190070", VA = "0x7194070")]
	internal ulong Cxj_00AFpW()
	{
		return default;
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x71939D4", Offset = "0x718F9D4", VA = "0x71939D4")]
	public _0081_0090_00A9hh_00B4(_0087LLP_0097_00B8 k_0098_00A9_007D_00BBP, _007DYXCc_008B c_008F_00AF_00B4_00B9_007E)
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x7194078", Offset = "0x7190078", VA = "0x7194078")]
	public void AddProvider(_00A2_00A1_00B8Hcp k_00ABHJ_0083R)
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x7194148", Offset = "0x7190148", VA = "0x7194148")]
	public void Reference()
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x7194158", Offset = "0x7190158", VA = "0x7194158")]
	public void Release()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x7192658", Offset = "0x718E658", VA = "0x7192658")]
	public bool IsDone()
	{
		return default;
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x7194168", Offset = "0x7190168", VA = "0x7194168")]
	public bool CanDestroy()
	{
		return default;
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x7194228", Offset = "0x7190228", VA = "0x7194228")]
	public void TryDestroyAllProviders()
	{
	}

	[Token(Token = "0x6000657")]
	public abstract void Update();

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x719227C", Offset = "0x718E27C", VA = "0x719227C", Slot = "5")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6000659")]
	public abstract void WaitForAsyncComplete();
}
