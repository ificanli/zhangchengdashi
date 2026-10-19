using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004D9")]
	public class ResourcesInfo : IResCallBackInfo
	{
		[Token(Token = "0x20004DA")]
		public delegate void OnUnloadedHandler(ResourcesInfo _0094tAsnz);

		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0x10")]
		internal bool _00A3WR_0081_009DQ;

		[Token(Token = "0x4001FD0")]
		[FieldOffset(Offset = "0x18")]
		private string[] _00B4_0088_00B7trÀ;

		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x20")]
		public OnUnloadedHandler onUnloaded;

		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x28")]
		internal AssetBundle _00B4_00BC_00B1eU_009A;

		[Token(Token = "0x4001FD3")]
		[FieldOffset(Offset = "0x30")]
		public string bundleName;

		[Token(Token = "0x4001FD4")]
		[FieldOffset(Offset = "0x38")]
		private UnityEngine.Object c_009AwB_00BD_0095;

		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x40")]
		private Sprite q_00BB_007C_0083_007Ba;

		[Token(Token = "0x4001FD6")]
		[FieldOffset(Offset = "0x48")]
		internal object[] Lf_009Et_0099t;

		[Token(Token = "0x4001FD7")]
		[FieldOffset(Offset = "0x50")]
		private bool _007BÂrGiK;

		[Token(Token = "0x4001FD8")]
		[FieldOffset(Offset = "0x54")]
		private int _00BE_0090_00A6_005Bp_007F;

		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D Ha_00A6W_00AF_00B6;

		[Token(Token = "0x17001251")]
		internal string[] _008BJ_008CÂrl
		{
			[Token(Token = "0x60073C1")]
			[Address(RVA = "0x72F38CC", Offset = "0x72EF8CC", VA = "0x72F38CC")]
			set
			{
				_007D_0098_00B2K_00AB_0087(value);
			}
		}

		[Token(Token = "0x17001252")]
		public bool isReady
		{
			[Token(Token = "0x60073C6")]
			[Address(RVA = "0x72F3BB8", Offset = "0x72EFBB8", VA = "0x72F3BB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60073D5")]
			[Address(RVA = "0x72F48B4", Offset = "0x72F08B4", VA = "0x72F48B4")]
			set
			{
			}
		}

		[Token(Token = "0x17001253")]
		public virtual UnityEngine.Object mainObjectInner
		{
			[Token(Token = "0x60073D3")]
			[Address(RVA = "0x72F45AC", Offset = "0x72F05AC", VA = "0x72F45AC", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001254")]
		public int refCount
		{
			[Token(Token = "0x60073BB")]
			[Address(RVA = "0x72F3560", Offset = "0x72EF560", VA = "0x72F3560")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60073D6")]
			[Address(RVA = "0x72F48C0", Offset = "0x72F08C0", VA = "0x72F48C0")]
			private set
			{
				ª_005Di_00A3_00B7B(value);
			}
		}

		[Token(Token = "0x17001255")]
		public AssetBundle MyAssetBundle
		{
			[Token(Token = "0x60073EC")]
			[Address(RVA = "0x72F54A8", Offset = "0x72F14A8", VA = "0x72F54A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001256")]
		[Obsolete("旧资源加载推荐使用LoadAsset<T>,新资源加载可继续使用")]
		public UnityEngine.Object mainObject
		{
			[Token(Token = "0x60073D2")]
			[Address(RVA = "0x72F31A0", Offset = "0x72EF1A0", VA = "0x72F31A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60073D7")]
			[Address(RVA = "0x72F48C8", Offset = "0x72F08C8", VA = "0x72F48C8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60073B3")]
		[Address(RVA = "0x72F2FDC", Offset = "0x72EEFDC", VA = "0x72F2FDC", Slot = "9")]
		public virtual Sprite _00B4q_0093l_00B7_007F(float _0098_00A7NvnY = 0f, float kG_00AF_00B8i_00B0 = 0f)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x72F31C0", Offset = "0x72EF1C0", VA = "0x72F31C0")]
		public int yCJV_00ABH()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x72F31C8", Offset = "0x72EF1C8", VA = "0x72F31C8")]
		public AssetBundle f_0089_009D_00B6_0084_00A9()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x72F31D0", Offset = "0x72EF1D0", VA = "0x72F31D0")]
		public void j_0082_0089Nz_00B1(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073B7")]
		[Address(RVA = "0x72F31DC", Offset = "0x72EF1DC", VA = "0x72F31DC")]
		private string IZ_0091Z_0082w(string _00AE_008C_009AiPJ)
		{
			return null;
		}

		[Token(Token = "0x60073B8")]
		[Address(RVA = "0x72F333C", Offset = "0x72EF33C", VA = "0x72F333C", Slot = "10")]
		public virtual GameObject RKB_00B9_00B8_0099(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0x72F354C", Offset = "0x72EF54C", VA = "0x72F354C")]
		private void Wv_008AUC_00B4(int _00A3_0092T_007E_00ABc)
		{
		}

		[SpecialName]
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x72F3554", Offset = "0x72EF554", VA = "0x72F3554")]
		public void KB_0088_00B0ºq(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073BC")]
		public T LoadAsset<T>(UnityEngine.Object fM_0082_00B3We, string _00AE_008C_009AiPJ) where T : UnityEngine.Object
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x72F3568", Offset = "0x72EF568", VA = "0x72F3568", Slot = "11")]
		public virtual UnityEngine.Object _00B0_007F_00BF_00A6U_0099()
		{
			return null;
		}

		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x72F3714", Offset = "0x72EF714", VA = "0x72F3714", Slot = "12")]
		public virtual GameObject Instantiate(bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x72F38BC", Offset = "0x72EF8BC", VA = "0x72F38BC")]
		public bool _00B7br_00A2Fy()
		{
			return default;
		}

		[SpecialName]
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x72F38C4", Offset = "0x72EF8C4", VA = "0x72F38C4")]
		private void Z_00AER_00BE_008B_007E(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x72F38CC", Offset = "0x72EF8CC", VA = "0x72F38CC")]
		internal void _007D_0098_00B2K_00AB_0087(string[] _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x72F38D4", Offset = "0x72EF8D4", VA = "0x72F38D4", Slot = "13")]
		public virtual GameObject T_00A7CCM_00A5(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x72F3A38", Offset = "0x72EFA38", VA = "0x72F3A38", Slot = "14")]
		public virtual GameObject _00BF_0091_0098xÁu()
		{
			return null;
		}

		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x72F3A48", Offset = "0x72EFA48", VA = "0x72F3A48")]
		internal void _00BD_0097E_007Dg_00B3()
		{
		}

		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x72F3A58", Offset = "0x72EFA58", VA = "0x72F3A58")]
		private string _0096R_0096q_00A5_009A(string _00AE_008C_009AiPJ)
		{
			return null;
		}

		[Token(Token = "0x60073C7")]
		[Address(RVA = "0x72F3BC0", Offset = "0x72EFBC0", VA = "0x72F3BC0", Slot = "15")]
		public virtual Sprite LoadSprite(float _0098_00A7NvnY = 0f, float kG_00AF_00B8i_00B0 = 0f)
		{
			return null;
		}

		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x72F3D7C", Offset = "0x72EFD7C", VA = "0x72F3D7C")]
		internal void _00B0_0082Á_008AE_009C()
		{
		}

		[SpecialName]
		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x72F3D8C", Offset = "0x72EFD8C", VA = "0x72F3D8C")]
		private void Wq_00B1_009F_00A7_009C(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073CA")]
		[Address(RVA = "0x72F3D94", Offset = "0x72EFD94", VA = "0x72F3D94", Slot = "16")]
		internal virtual void _00A4_0084_0083_0086_00B3_00B8(bool zM_009E_00B1Lu = true)
		{
		}

		[Token(Token = "0x60073CB")]
		public T GetArg<T>(int g_0097mKyÂ)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ResourcesInfo.GetArg RVA= Token=0x60073CB");
}

		[Token(Token = "0x60073CC")]
		[Address(RVA = "0x72F3DD8", Offset = "0x72EFDD8", VA = "0x72F3DD8", Slot = "17")]
		public virtual Texture2D LoadTextureForAtlas(string I_00AF_00B2_00BD_009DÂ)
		{
			return null;
		}

		[Token(Token = "0x60073CD")]
		[Address(RVA = "0x72F4040", Offset = "0x72F0040", VA = "0x72F4040", Slot = "18")]
		public virtual GameObject Instantiate(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073CE")]
		[Address(RVA = "0x72F31B0", Offset = "0x72EF1B0", VA = "0x72F31B0", Slot = "19")]
		public UnityEngine.Object Hºs_0097pJ()
		{
			return null;
		}

		[Token(Token = "0x60073CF")]
		[Address(RVA = "0x72F4240", Offset = "0x72F0240", VA = "0x72F4240", Slot = "20")]
		public virtual GameObject e_00BF_008F_009Eiz(Vector3 _00BB_00AE_0080_009A_00AC_00A3, Quaternion _00A0FnV_00B8X, bool z_0094X_00A2_009C_0083 = true)
		{
			return null;
		}

		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x72F4440", Offset = "0x72F0440", VA = "0x72F4440", Slot = "21")]
		public virtual GameObject _0084_00B0reu_007B(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073D1")]
		[Address(RVA = "0x72F45A4", Offset = "0x72F05A4", VA = "0x72F45A4")]
		public bool AuS_00A7_00AC_00A7()
		{
			return default;
		}

		[Token(Token = "0x60073D4")]
		[Address(RVA = "0x72F4754", Offset = "0x72F0754", VA = "0x72F4754")]
		private string _00B8Wv_00A3_00A4O(string _00AE_008C_009AiPJ)
		{
			return null;
		}

		[Token(Token = "0x60073D6")]
		[Address(RVA = "0x72F48C0", Offset = "0x72F08C0", VA = "0x72F48C0")]
		private void ª_005Di_00A3_00B7B(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073D8")]
		[Address(RVA = "0x72F4994", Offset = "0x72F0994", VA = "0x72F4994", Slot = "23")]
		public virtual GameObject _008BaÀµ_00B0_0080()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073D9")]
		[Address(RVA = "0x72F49A8", Offset = "0x72F09A8", VA = "0x72F49A8", Slot = "24")]
		public virtual UnityEngine.Object FG_00B4bZ_0081()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073DA")]
		[Address(RVA = "0x72F4B50", Offset = "0x72F0B50", VA = "0x72F4B50", Slot = "25")]
		public virtual UnityEngine.Object _0060_0089_00A4kM_0092()
		{
			return null;
		}

		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x72F4CF8", Offset = "0x72F0CF8", VA = "0x72F4CF8", Slot = "26")]
		public virtual GameObject NN_007E_0089_0092Z(bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[Token(Token = "0x60073DC")]
		[Address(RVA = "0x72F4F4C", Offset = "0x72F0F4C", VA = "0x72F4F4C", Slot = "27")]
		internal virtual void c_00B0_009A_008D_00A6_00A8(bool zM_009E_00B1Lu = true)
		{
		}

		[SpecialName]
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0x72F4F94", Offset = "0x72F0F94", VA = "0x72F4F94", Slot = "28")]
		public virtual UnityEngine.Object _0089_0088_0083_00B2_0082_00AB()
		{
			return null;
		}

		[SpecialName]
		[Token(Token = "0x60073DE")]
		[Address(RVA = "0x72F513C", Offset = "0x72F113C", VA = "0x72F513C")]
		public void SRxC_009Ev(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073DF")]
		[Address(RVA = "0x72F5148", Offset = "0x72F1148", VA = "0x72F5148", Slot = "29")]
		public virtual GameObject Instantiate()
		{
			return null;
		}

		[Token(Token = "0x60073E0")]
		[Address(RVA = "0x72F34A0", Offset = "0x72EF4A0", VA = "0x72F34A0")]
		internal void _00BD_0097E_007Dg_00B3(UnityEngine.Object Z_009Aj_009Bqd)
		{
		}

		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x72F5158", Offset = "0x72F1158", VA = "0x72F5158")]
		public ResourcesInfo()
		{
		}

		[SpecialName]
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0x72F5160", Offset = "0x72F1160", VA = "0x72F5160")]
		private void À_00BE_0099nYL(int _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073E3")]
		[Address(RVA = "0x72F5168", Offset = "0x72F1168", VA = "0x72F5168", Slot = "30")]
		public virtual GameObject _007FNy_00BC_007EB()
		{
			return null;
		}

		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x72F5178", Offset = "0x72F1178", VA = "0x72F5178", Slot = "31")]
		internal virtual void jR_0082Q_009Bj(bool zM_009E_00B1Lu = true)
		{
		}

		[Token(Token = "0x60073E5")]
		[Address(RVA = "0x72F51BC", Offset = "0x72F11BC", VA = "0x72F51BC", Slot = "32")]
		public virtual GameObject Instantiate(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[Token(Token = "0x60073E6")]
		[Address(RVA = "0x72F5320", Offset = "0x72F1320", VA = "0x72F5320")]
		internal void DPQ_0099_00A2_00AF()
		{
		}

		[SpecialName]
		[Token(Token = "0x60073E7")]
		[Address(RVA = "0x72F5324", Offset = "0x72F1324", VA = "0x72F5324")]
		public void _00B3e_00ABd_009Ak(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60073E8")]
		[Address(RVA = "0x72F4EA0", Offset = "0x72F0EA0", VA = "0x72F4EA0")]
		internal void _009B_00BC_00B7_005D_0088D(UnityEngine.Object Z_009Aj_009Bqd)
		{
		}

		[Token(Token = "0x60073E9")]
		[Address(RVA = "0x72F5330", Offset = "0x72F1330", VA = "0x72F5330")]
		internal void x_009D_005B_00AFh_00AF()
		{
		}

		[Token(Token = "0x60073EA")]
		[Address(RVA = "0x72F5334", Offset = "0x72F1334", VA = "0x72F5334", Slot = "33")]
		public virtual GameObject VIi_009E_00B3k(string _00B4M_0088_005B_0087_0093, bool z_0094X_00A2_009C_0083)
		{
			return null;
		}

		[Token(Token = "0x60073EB")]
		[Address(RVA = "0x72F5498", Offset = "0x72F1498", VA = "0x72F5498")]
		internal void f_008D_008Ey_00B1_00A5()
		{
		}

		[Token(Token = "0x60073ED")]
		[Address(RVA = "0x72F54B0", Offset = "0x72F14B0", VA = "0x72F54B0", Slot = "34")]
		internal virtual void _00BB_0095BvjH(bool zM_009E_00B1Lu = true)
		{
		}

		[Token(Token = "0x60073EE")]
		public T GetArg<T>()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ResourcesInfo.GetArg RVA= Token=0x60073EE");
}
	}
}
