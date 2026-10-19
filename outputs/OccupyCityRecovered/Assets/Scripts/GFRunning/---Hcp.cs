using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

[Token(Token = "0x2000099")]
internal abstract class _00A2_00A1_00B8Hcp
{
	[Token(Token = "0x200009A")]
	public enum EStatus
	{
		[Token(Token = "0x40001EC")]
		None = 0,
		[Token(Token = "0x40001ED")]
		CheckBundle = 1,
		[Token(Token = "0x40001EE")]
		Loading = 2,
		[Token(Token = "0x40001EF")]
		Checking = 3,
		[Token(Token = "0x40001F0")]
		Succeed = 4,
		[Token(Token = "0x40001F1")]
		Failed = 5
	}

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x10")]
	private string u_008F_00B4u_0094_0082;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x18")]
	private _0087LLP_0097_00B8 _0098_0060r_00A6_0099e;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x20")]
	private AssetInfo _009D_00B1_008Cs_00A8_00A5;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x28")]
	private Object _0060I_008Bj_00A1_0089;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x30")]
	private Object[] mN_007CµAn;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x38")]
	private Scene _009EBeb_00B7B;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x40")]
	private string W_00B3_0087o_0085c;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x48")]
	private EStatus _0084xno_0093_00AD;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x50")]
	private string _0080_0095ª_0084_00A3_00B9;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x58")]
	private float J_009FP_00BEfm;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x5C")]
	private int Eª_00A1_0093p_008B;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x60")]
	private bool zL_00BE_008CÁ_00B6;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x68")]
	private _0081_0090_00A9hh_00B4 H_00A6_0092_0096_00B3_00AC;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x70")]
	private _008F_00A9F_0083K_0080 _008B_00B9_007E_00BDh_008A;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x78")]
	private bool _00BD_00B3_00A7e_00AF_008A;

	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<OperationHandleBase> _009B_0089_00B6g_00ADJ;

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x88")]
	private TaskCompletionSource<object> _0096L_009B_0097P_00B2;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x90")]
	public string SpawnScene;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x98")]
	public string SpawnTime;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0xA0")]
	private long K_007C_00B6S_00B4p;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0xA8")]
	private Stopwatch Li_0093mT_00B0;

	[Token(Token = "0x17000057")]
	public string ProviderGUID
	{
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x72C20DC", Offset = "0x72BE0DC", VA = "0x72C20DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x72C20D4", Offset = "0x72BE0D4", VA = "0x72C20D4")]
		private set
		{
			Pq_009C_009DhY(value);
		}
	}

	[Token(Token = "0x17000058")]
	public _0087LLP_0097_00B8 Impl
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x72C20EC", Offset = "0x72BE0EC", VA = "0x72C20EC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x72C20E4", Offset = "0x72BE0E4", VA = "0x72C20E4")]
		private set
		{
			_0060_005EJg_00B1_0099(value);
		}
	}

	[Token(Token = "0x17000059")]
	public AssetInfo MainAssetInfo
	{
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x72C20FC", Offset = "0x72BE0FC", VA = "0x72C20FC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x72C20F4", Offset = "0x72BE0F4", VA = "0x72C20F4")]
		private set
		{
			vq_008Ems_0080(value);
		}
	}

	[Token(Token = "0x1700005A")]
	public Object AssetObject
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x72C210C", Offset = "0x72BE10C", VA = "0x72C210C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x72C2104", Offset = "0x72BE104", VA = "0x72C2104")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public Object[] AllAssetObjects
	{
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x72C211C", Offset = "0x72BE11C", VA = "0x72C211C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x72C2114", Offset = "0x72BE114", VA = "0x72C2114")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public Scene SceneObject
	{
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x72C212C", Offset = "0x72BE12C", VA = "0x72C212C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x72C2124", Offset = "0x72BE124", VA = "0x72C2124")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public string RawFilePath
	{
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x72C213C", Offset = "0x72BE13C", VA = "0x72C213C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x72C2134", Offset = "0x72BE134", VA = "0x72C2134")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public EStatus Status
	{
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x72C214C", Offset = "0x72BE14C", VA = "0x72C214C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x72C2144", Offset = "0x72BE144", VA = "0x72C2144")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public string LastError
	{
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x72C215C", Offset = "0x72BE15C", VA = "0x72C215C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x72C2154", Offset = "0x72BE154", VA = "0x72C2154")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public float Progress
	{
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x72C216C", Offset = "0x72BE16C", VA = "0x72C216C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x72C2164", Offset = "0x72BE164", VA = "0x72C2164")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public int RefCount
	{
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x72C217C", Offset = "0x72BE17C", VA = "0x72C217C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x72C2174", Offset = "0x72BE174", VA = "0x72C2174")]
		private set
		{
			_0099_0060µu_00B1_00B9(value);
		}
	}

	[Token(Token = "0x17000062")]
	public bool IsDestroyed
	{
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x72C2190", Offset = "0x72BE190", VA = "0x72C2190")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x72C2184", Offset = "0x72BE184", VA = "0x72C2184")]
		private set
		{
			_008D_00AEeW_0099Á(value);
		}
	}

	[Token(Token = "0x17000063")]
	public bool IsDone
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x72C2198", Offset = "0x72BE198", VA = "0x72C2198")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000064")]
	protected _0081_0090_00A9hh_00B4 OwnerBundle
	{
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x72C2248", Offset = "0x72BE248", VA = "0x72C2248")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x72C2240", Offset = "0x72BE240", VA = "0x72C2240")]
		private set
		{
			_0081l_00BBx_009B_00AF(value);
		}
	}

	[Token(Token = "0x17000065")]
	protected _008F_00A9F_0083K_0080 DependBundles
	{
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x72C2258", Offset = "0x72BE258", VA = "0x72C2258")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x72C2250", Offset = "0x72BE250", VA = "0x72C2250")]
		private set
		{
			_00A5Y_0092S_00B8G(value);
		}
	}

	[Token(Token = "0x17000066")]
	protected bool IsWaitForAsyncComplete
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x72C226C", Offset = "0x72BE26C", VA = "0x72C226C")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x72C2260", Offset = "0x72BE260", VA = "0x72C2260")]
		private set
		{
			m_00A1_008EHr_009B(value);
		}
	}

	[Token(Token = "0x17000067")]
	public Task Task
	{
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x72C25F0", Offset = "0x72BE5F0", VA = "0x72C25F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000068")]
	public long LoadingTime
	{
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x72C26BC", Offset = "0x72BE6BC", VA = "0x72C26BC")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x72C26B4", Offset = "0x72BE6B4", VA = "0x72C26B4")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x72C20D4", Offset = "0x72BE0D4", VA = "0x72C20D4")]
	private void Pq_009C_009DhY(string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x72C20E4", Offset = "0x72BE0E4", VA = "0x72C20E4")]
	private void _0060_005EJg_00B1_0099(_0087LLP_0097_00B8 _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x72C20F4", Offset = "0x72BE0F4", VA = "0x72C20F4")]
	private void vq_008Ems_0080(AssetInfo _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x72C2174", Offset = "0x72BE174", VA = "0x72C2174")]
	private void _0099_0060µu_00B1_00B9(int _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x72C2184", Offset = "0x72BE184", VA = "0x72C2184")]
	private void _008D_00AEeW_0099Á(bool _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x72C2240", Offset = "0x72BE240", VA = "0x72C2240")]
	private void _0081l_00BBx_009B_00AF(_0081_0090_00A9hh_00B4 _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x72C2250", Offset = "0x72BE250", VA = "0x72C2250")]
	private void _00A5Y_0092S_00B8G(_008F_00A9F_0083K_0080 _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x72C2260", Offset = "0x72BE260", VA = "0x72C2260")]
	private void m_00A1_008EHr_009B(bool _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x72C140C", Offset = "0x72BD40C", VA = "0x72C140C")]
	public _00A2_00A1_00B8Hcp(_0087LLP_0097_00B8 k_0098_00A9_007D_00BBP, string _009F_0093_008B_00AFFÂ, AssetInfo y_0091_00A0K_0096F)
	{
	}

	[Token(Token = "0x6000759")]
	public abstract void Update();

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x72C2274", Offset = "0x72BE274", VA = "0x72C2274")]
	public void Destroy()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x72C22B4", Offset = "0x72BE2B4", VA = "0x72C22B4")]
	public bool CanDestroy()
	{
		return default;
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x72C22E0", Offset = "0x72BE2E0", VA = "0x72C22E0")]
	public bool IsSceneProvider()
	{
		return default;
	}

	[Token(Token = "0x600075D")]
	public T CreateHandle<T>() where T : OperationHandleBase
	{
		return null;
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x72C2364", Offset = "0x72BE364", VA = "0x72C2364")]
	public void ReleaseHandle(OperationHandleBase A_0085_007D_0092_00BDr)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x72C2444", Offset = "0x72BE444", VA = "0x72C2444")]
	public void WaitForAsyncComplete()
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x72C24E0", Offset = "0x72BE4E0", VA = "0x72C24E0")]
	protected void ProcessCacheBundleException()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x72C15A8", Offset = "0x72BD5A8", VA = "0x72C15A8")]
	protected void InvokeCompletion()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x72C26C4", Offset = "0x72BE6C4", VA = "0x72C26C4")]
	[Conditional("DEBUG")]
	public void InitSpawnDebugInfo()
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x72C2748", Offset = "0x72BE748", VA = "0x72C2748")]
	private string _009F_008B_0094K_0092_00A1(float _0091tNz_008B_00B9)
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x72C29D8", Offset = "0x72BE9D8", VA = "0x72C29D8")]
	[Conditional("DEBUG")]
	protected void DebugBeginRecording()
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x72C2A3C", Offset = "0x72BEA3C", VA = "0x72C2A3C")]
	[Conditional("DEBUG")]
	private void _00B2_00AF_0089l_00B1M()
	{
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x72C2A60", Offset = "0x72BEA60", VA = "0x72C2A60")]
	internal DownloadReport k_00B6esZ_009E()
	{
		return default;
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x72C2C50", Offset = "0x72BEC50", VA = "0x72C2C50")]
	internal void _00A9mxh_0080V(List<DebugBundleInfo> _00A4b_005EN_0089_00A5)
	{
	}
}
