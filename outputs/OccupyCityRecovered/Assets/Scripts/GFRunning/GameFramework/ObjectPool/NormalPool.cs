using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework.ObjectPool
{
	[Token(Token = "0x2000458")]
	public sealed class NormalPool
	{
		[Token(Token = "0x2000459")]
		private sealed class t_0099M_00A8_0060_00B9
		{
			[Token(Token = "0x4001E21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalPool _003C_003E4__this;

			[Token(Token = "0x4001E22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string objAssetName;

			[Token(Token = "0x4001E23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<GameObject> result;

			[Token(Token = "0x4001E24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _00A9ºY_00AB_0092_00B3 normalObject;

			[Token(Token = "0x4001E25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject target;

			[Token(Token = "0x6006ACB")]
			[Address(RVA = "0x727DBDC", Offset = "0x7279BDC", VA = "0x727DBDC")]
			public t_0099M_00A8_0060_00B9()
			{
			}

			[Token(Token = "0x6006ACC")]
			[Address(RVA = "0x7281A5C", Offset = "0x727DA5C", VA = "0x7281A5C")]
			internal void q_00BD_00A1A_008Cn(AssetOperationHandle resInfo)
			{
			}

			[Token(Token = "0x6006ACD")]
			[Address(RVA = "0x7281B18", Offset = "0x727DB18", VA = "0x7281B18")]
			internal void H_007Eª_00A1N_0099(ResourcesInfo resInfo)
			{
			}

			[Token(Token = "0x6006ACE")]
			[Address(RVA = "0x7281BD4", Offset = "0x727DBD4", VA = "0x7281BD4")]
			internal void _00B6R_0096_0060_0091_008F(AssetOperationHandle aoh)
			{
			}

			[Token(Token = "0x6006ACF")]
			[Address(RVA = "0x7281DA0", Offset = "0x727DDA0", VA = "0x7281DA0")]
			internal void wO_0087r_005D_0087(GameObject objAsset)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200045A")]
		private struct _00AFªa_0084_00A5k : IAsyncStateMachine
		{
			[Token(Token = "0x4001E26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001E27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4001E28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NormalPool _003C_003E4__this;

			[Token(Token = "0x4001E29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objAssetName;

			[Token(Token = "0x4001E2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject _003Ctarget_003E5__2;

			[Token(Token = "0x4001E2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _00A9ºY_00AB_0092_00B3 _003CnormalObject_003E5__3;

			[Token(Token = "0x4001E2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x4001E2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<GameObject> _003C_003Eu__2;

			[Token(Token = "0x6006AD0")]
			[Address(RVA = "0x7281F54", Offset = "0x727DF54", VA = "0x7281F54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6006AD1")]
			[Address(RVA = "0x7282574", Offset = "0x727E574", VA = "0x7282574", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IObjectPool<_00A9ºY_00AB_0092_00B3> _007C_00A8z_007FF_0087;

		[Token(Token = "0x4001E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform B_008E_007F_00AE_008DU;

		[Token(Token = "0x4001E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, AssetOperationHandle> _00A6_00A3q_00B1_00B0µ;

		[Token(Token = "0x4001E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, ResourcesInfo> U_0088_00A7wC_00A3;

		[Token(Token = "0x4001E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _00BE_00AF_00B4_009CQY;

		[Token(Token = "0x4001E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _0090_00A1_008F_0099_00BFw;

		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0x727B70C", Offset = "0x727770C", VA = "0x727B70C")]
		public void _008C_00AB_007CZ_00BC_009B()
		{
		}

		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0x727BB90", Offset = "0x7277B90", VA = "0x727BB90")]
		public void DestroyObjectPool()
		{
		}

		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0x727C014", Offset = "0x7278014", VA = "0x727C014")]
		private void S_0084SF_008Fa(string IKB_0082_00B8_00B4, ResourcesInfo _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AA9")]
		[Address(RVA = "0x727C308", Offset = "0x7278308", VA = "0x727C308")]
		public void _0094_008E_0060_009Cz_008D()
		{
		}

		[Token(Token = "0x6006AAA")]
		[Address(RVA = "0x727C78C", Offset = "0x727878C", VA = "0x727C78C")]
		public void G_00B1J_00BD_0087_008B(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0x727CB00", Offset = "0x7278B00", VA = "0x727CB00")]
		private void _00AE_00BBPKih(string IKB_0082_00B8_00B4, AssetOperationHandle _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0x727CD64", Offset = "0x7278D64", VA = "0x727CD64")]
		public NormalPool()
		{
		}

		[Token(Token = "0x6006AAD")]
		[Address(RVA = "0x727CD6C", Offset = "0x7278D6C", VA = "0x727CD6C")]
		public Task<GameObject> _00B0_00BFq_0086a_00B7(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AAE")]
		[Address(RVA = "0x727CE58", Offset = "0x7278E58", VA = "0x727CE58")]
		public Task<GameObject> _00B8cdG_00BCR(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0x727CF44", Offset = "0x7278F44", VA = "0x727CF44")]
		private void sV_009F_0084_00A8_00BE(string IKB_0082_00B8_00B4, AssetOperationHandle _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0x727D1A4", Offset = "0x72791A4", VA = "0x727D1A4")]
		public void o_00B3f_0085Xh()
		{
		}

		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0x727D628", Offset = "0x7279628", VA = "0x727D628")]
		public void UnSpawn(UnityEngine.Object _008EBÂ_008F_00BB_008B)
		{
		}

		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0x727D6D4", Offset = "0x72796D4", VA = "0x727D6D4")]
		public void _0086U_009F_0095_008AZ(string IKB_0082_00B8_00B4, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0x727E140", Offset = "0x727A140", VA = "0x727E140")]
		public void _00B0_00B3_00A6I_0060l()
		{
		}

		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0x727E5C4", Offset = "0x727A5C4", VA = "0x727E5C4")]
		public Task<GameObject> W_00A3_009Dd_00B7_007C(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x727DE48", Offset = "0x7279E48", VA = "0x727DE48")]
		private void YÁ_007C_0084q_00A6(string IKB_0082_00B8_00B4, ResourcesInfo _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0x727E6B0", Offset = "0x727A6B0", VA = "0x727E6B0")]
		private void x_00B3_0091_00A0p_00B7(string IKB_0082_00B8_00B4, AssetOperationHandle _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0x727E914", Offset = "0x727A914", VA = "0x727E914")]
		public Task<GameObject> hhA_007F_007C_00BB(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0x727EA00", Offset = "0x727AA00", VA = "0x727EA00")]
		public Task<GameObject> _007Dj_00A3_00BB_007D_00BC(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AB9")]
		[Address(RVA = "0x727DBE4", Offset = "0x7279BE4", VA = "0x727DBE4")]
		private void sªFY_0080C(string IKB_0082_00B8_00B4, AssetOperationHandle _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006ABA")]
		[Address(RVA = "0x727EAEC", Offset = "0x727AAEC", VA = "0x727EAEC")]
		public void E_00A2zL_0092x(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006ABB")]
		[Address(RVA = "0x727EE60", Offset = "0x727AE60", VA = "0x727EE60")]
		[AsyncStateMachine(typeof(_00AFªa_0084_00A5k))]
		[Obsolete("异步方法取消，采用回调的方式")]
		public Task<GameObject> Spawn(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006ABC")]
		[Address(RVA = "0x727EF4C", Offset = "0x727AF4C", VA = "0x727EF4C")]
		public void w_00B6U_00A1L_009F(UnityEngine.Object _008EBÂ_008F_00BB_008B)
		{
		}

		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0x727EFF8", Offset = "0x727AFF8", VA = "0x727EFF8")]
		public void Spawn(string IKB_0082_00B8_00B4, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006ABE")]
		[Address(RVA = "0x727F7F4", Offset = "0x727B7F4", VA = "0x727F7F4")]
		public void CreateObjectPool(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006ABF")]
		[Address(RVA = "0x727FB68", Offset = "0x727BB68", VA = "0x727FB68")]
		private void _0094_009C_0091f_007BS(string IKB_0082_00B8_00B4, ResourcesInfo _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AC0")]
		[Address(RVA = "0x727FE60", Offset = "0x727BE60", VA = "0x727FE60")]
		public void _007F_008E_00A2_00BFQf()
		{
		}

		[Token(Token = "0x6006AC1")]
		[Address(RVA = "0x72802E4", Offset = "0x727C2E4", VA = "0x72802E4")]
		public Task<GameObject> E_0095_0093kPb(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AC2")]
		[Address(RVA = "0x72803D0", Offset = "0x727C3D0", VA = "0x72803D0")]
		public void _008A_00A7_007D_00B2ZQ(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006AC3")]
		[Address(RVA = "0x7280744", Offset = "0x727C744", VA = "0x7280744")]
		public void Rr_00AD_0094_0098_00B9(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006AC4")]
		[Address(RVA = "0x7280AB8", Offset = "0x727CAB8", VA = "0x7280AB8")]
		public void XY_00B2ec_00BE(string IKB_0082_00B8_00B4, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AC5")]
		[Address(RVA = "0x727F500", Offset = "0x727B500", VA = "0x727F500")]
		private void _00AD_00BC_00A2Z_00AD_007E(string IKB_0082_00B8_00B4, ResourcesInfo _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006AC6")]
		[Address(RVA = "0x7281000", Offset = "0x727D000", VA = "0x7281000")]
		public Task<GameObject> _008E_0083_0093C_005Dd(string IKB_0082_00B8_00B4)
		{
			return null;
		}

		[Token(Token = "0x6006AC7")]
		[Address(RVA = "0x72810EC", Offset = "0x727D0EC", VA = "0x72810EC")]
		public void _00A8_00B4_005EE_00B8_0098(string b_009E_00B6Tnh, int atl_007CÂ_009E, float _00A1_00B2_007F_007D_008EZ, Transform _008A_00B3_0095_00A5V_007B, bool _00A4_00B0XZ_00A1X = false)
		{
		}

		[Token(Token = "0x6006AC8")]
		[Address(RVA = "0x7281460", Offset = "0x727D460", VA = "0x7281460")]
		public void _007BHÂ_00A5V_00AC(UnityEngine.Object _008EBÂ_008F_00BB_008B)
		{
		}

		[Token(Token = "0x6006AC9")]
		[Address(RVA = "0x728150C", Offset = "0x727D50C", VA = "0x728150C")]
		private void m_0082_0085e_008EZ(string IKB_0082_00B8_00B4, ResourcesInfo _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}

		[Token(Token = "0x6006ACA")]
		[Address(RVA = "0x72817FC", Offset = "0x727D7FC", VA = "0x72817FC")]
		private void _00B4YI_00BC_00BE_0090(string IKB_0082_00B8_00B4, AssetOperationHandle _0060_00BBªrÀ_0095, Action<GameObject> H_009CVRM_005D)
		{
		}
	}
}
