using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x200035F")]
	public class BaseEffect
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000360")]
		private struct _00B9_00A7d_00A9_008Fº : IAsyncStateMachine
		{
			[Token(Token = "0x4001A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseEffect _003C_003E4__this;

			[Token(Token = "0x4001A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60058BE")]
			[Address(RVA = "0x717E19C", Offset = "0x717A19C", VA = "0x717E19C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058BF")]
			[Address(RVA = "0x717E420", Offset = "0x717A420", VA = "0x717E420", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000361")]
		private struct j_00BB_00B7i_00AE_00AE : IAsyncStateMachine
		{
			[Token(Token = "0x4001A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseEffect _003C_003E4__this;

			[Token(Token = "0x4001A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x4001A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<GameObject> _003C_003Eu__2;

			[Token(Token = "0x60058C0")]
			[Address(RVA = "0x717E488", Offset = "0x717A488", VA = "0x717E488", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058C1")]
			[Address(RVA = "0x717E984", Offset = "0x717A984", VA = "0x717E984", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000362")]
		private struct ew_0083p_007Eº : IAsyncStateMachine
		{
			[Token(Token = "0x4001A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseEffect _003C_003E4__this;

			[Token(Token = "0x4001A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60058C2")]
			[Address(RVA = "0x717E990", Offset = "0x717A990", VA = "0x717E990", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058C3")]
			[Address(RVA = "0x717EC90", Offset = "0x717AC90", VA = "0x717EC90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000363")]
		private struct _00B3_0083_0094_0086_0083À : IAsyncStateMachine
		{
			[Token(Token = "0x4001A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseEffect _003C_003E4__this;

			[Token(Token = "0x4001A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 pos;

			[Token(Token = "0x4001A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60058C4")]
			[Address(RVA = "0x717EC9C", Offset = "0x717AC9C", VA = "0x717EC9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058C5")]
			[Address(RVA = "0x717EF18", Offset = "0x717AF18", VA = "0x717EF18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000364")]
		private struct _009E_0098_00B1_0089_007Dy : IAsyncStateMachine
		{
			[Token(Token = "0x4001A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BaseEffect _003C_003E4__this;

			[Token(Token = "0x4001A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x60058C6")]
			[Address(RVA = "0x717EF24", Offset = "0x717AF24", VA = "0x717EF24", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60058C7")]
			[Address(RVA = "0x717F0D0", Offset = "0x717B0D0", VA = "0x717F0D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object _008EBÂ_008F_00BB_008B;

		[Token(Token = "0x4001A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int o_008BH_007Eac;

		[Token(Token = "0x4001A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int UID;

		[Token(Token = "0x4001A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectData Config;

		[Token(Token = "0x4001A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Transform m_parent;

		[Token(Token = "0x4001A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Vector3 m_pos;

		[Token(Token = "0x4001A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected Vector3 m_rot;

		[Token(Token = "0x4001A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject gameObject;

		[Token(Token = "0x4001A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool m_isActive;

		[Token(Token = "0x4001A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		protected bool m_IsLoad;

		[Token(Token = "0x4001A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		protected bool m_isDispose;

		[Token(Token = "0x4001A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<BaseEffect> onComplete;

		[Token(Token = "0x4001A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool Q_00B9B_009F_00A2_008E;

		[Token(Token = "0x4001A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetOperationHandle A_0085_007D_0092_00BDr;

		[Token(Token = "0x4001A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int M_0095_00AC_007D_0097_009A;

		[Token(Token = "0x4001A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _008DJi_005Eµ_00AD;

		[Token(Token = "0x4001A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool x_0096_008B_00BF_0084O;

		[Token(Token = "0x6005886")]
		[Address(RVA = "0x717BEA4", Offset = "0x7177EA4", VA = "0x717BEA4")]
		public void D_007Bªy_005Db(Vector3 kS_009DyQ_008C)
		{
		}

		[Token(Token = "0x6005887")]
		[Address(RVA = "0x717BF58", Offset = "0x7177F58", VA = "0x717BF58", Slot = "4")]
		public virtual Task _0090_00B2sÁj_008F()
		{
			return null;
		}

		[Token(Token = "0x6005888")]
		[Address(RVA = "0x717C018", Offset = "0x7178018", VA = "0x717C018", Slot = "5")]
		[AsyncStateMachine(typeof(ew_0083p_007Eº))]
		protected virtual void Play()
		{
		}

		[Token(Token = "0x6005889")]
		[Address(RVA = "0x717C0A8", Offset = "0x71780A8", VA = "0x717C0A8")]
		[AsyncStateMachine(typeof(_00B3_0083_0094_0086_0083À))]
		public void SetWorldPosition(Vector3 kS_009DyQ_008C)
		{
		}

		[Token(Token = "0x600588A")]
		[Address(RVA = "0x717C15C", Offset = "0x717815C", VA = "0x717C15C")]
		protected string _009B_0083X_00A3D_0085()
		{
			return null;
		}

		[Token(Token = "0x600588B")]
		[Address(RVA = "0x717C200", Offset = "0x7178200", VA = "0x717C200", Slot = "6")]
		protected virtual void S_008D_00A0h_0085_0085()
		{
		}

		[Token(Token = "0x600588C")]
		[Address(RVA = "0x717C290", Offset = "0x7178290", VA = "0x717C290", Slot = "7")]
		protected virtual void _005DÀrZ_0082S()
		{
		}

		[Token(Token = "0x600588D")]
		[Address(RVA = "0x717C6FC", Offset = "0x71786FC", VA = "0x717C6FC", Slot = "8")]
		protected virtual void pµÁ_0087_00B0_00A9()
		{
		}

		[Token(Token = "0x600588E")]
		[Address(RVA = "0x717C9C0", Offset = "0x71789C0", VA = "0x717C9C0")]
		public void _0086p_005Bu_0060_0091(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6005890")]
		[Address(RVA = "0x717CAD0", Offset = "0x7178AD0", VA = "0x717CAD0", Slot = "9")]
		[AsyncStateMachine(typeof(_009E_0098_00B1_0089_007Dy))]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6005891")]
		[Address(RVA = "0x717CB60", Offset = "0x7178B60", VA = "0x717CB60", Slot = "10")]
		public virtual void _00A4_0084_0083_0086_00B3_00B8()
		{
		}

		[Token(Token = "0x6005892")]
		[Address(RVA = "0x717C82C", Offset = "0x717882C", VA = "0x717C82C")]
		public void _0086_0085_00AC_00AEh_00A3(string _0089h_00B3JY_007D, int qy_00AC_00B2_0090p)
		{
		}

		[Token(Token = "0x6005893")]
		[Address(RVA = "0x717CC04", Offset = "0x7178C04", VA = "0x717CC04")]
		[CompilerGenerated]
		private bool _00A3_00BCvpn_008B()
		{
			return default;
		}

		[Token(Token = "0x6005894")]
		[Address(RVA = "0x717CC64", Offset = "0x7178C64", VA = "0x717CC64", Slot = "11")]
		protected virtual void _00B4ºY_00BE_005D_0098()
		{
		}

		[Token(Token = "0x6005895")]
		[Address(RVA = "0x717CD80", Offset = "0x7178D80", VA = "0x717CD80")]
		public void _0095_0083a_00A5Ji()
		{
		}

		[Token(Token = "0x6005896")]
		[Address(RVA = "0x717CD8C", Offset = "0x7178D8C", VA = "0x717CD8C")]
		private bool _00A2z_00BF_0081_00A5_00AD()
		{
			return default;
		}

		[Token(Token = "0x6005897")]
		[Address(RVA = "0x717CDEC", Offset = "0x7178DEC", VA = "0x717CDEC", Slot = "12")]
		public virtual void c_0098_00B4_009C_00B0_008D()
		{
		}

		[Token(Token = "0x6005898")]
		[Address(RVA = "0x717CE90", Offset = "0x7178E90", VA = "0x717CE90")]
		public void SetPosition(Vector3 kS_009DyQ_008C)
		{
		}

		[Token(Token = "0x6005899")]
		[Address(RVA = "0x717C3C0", Offset = "0x71783C0", VA = "0x717C3C0")]
		public void _0089_00B3B_00B0c_0093(string _0089h_00B3JY_007D, int qy_00AC_00B2_0090p)
		{
		}

		[Token(Token = "0x600589A")]
		[Address(RVA = "0x717CF54", Offset = "0x7178F54", VA = "0x717CF54")]
		public void _00A4_009E_00AD_0084_008Ad()
		{
		}

		[Token(Token = "0x600589B")]
		[Address(RVA = "0x717CF64", Offset = "0x7178F64", VA = "0x717CF64", Slot = "13")]
		protected virtual void _008E_00A4_0091_00A5M_00B1()
		{
		}

		[Token(Token = "0x600589C")]
		[Address(RVA = "0x717CFF4", Offset = "0x7178FF4", VA = "0x717CFF4")]
		public void Tº_009B_0091n_00A5()
		{
		}

		[Token(Token = "0x600589D")]
		[Address(RVA = "0x717D004", Offset = "0x7179004", VA = "0x717D004")]
		public void _0098_0088ydrk(Vector3 kS_009DyQ_008C)
		{
		}

		[Token(Token = "0x600589E")]
		[Address(RVA = "0x717D0C8", Offset = "0x71790C8", VA = "0x717D0C8")]
		public void Stop()
		{
		}

		[Token(Token = "0x600589F")]
		[Address(RVA = "0x717D0D8", Offset = "0x71790D8", VA = "0x717D0D8", Slot = "14")]
		public virtual void AYmÀm_00B9()
		{
		}

		[Token(Token = "0x60058A0")]
		[Address(RVA = "0x717D17C", Offset = "0x717917C", VA = "0x717D17C")]
		[CompilerGenerated]
		private bool _0060_009Cy_008E_005D_009C()
		{
			return default;
		}

		[Token(Token = "0x60058A1")]
		[Address(RVA = "0x717D19C", Offset = "0x717919C", VA = "0x717D19C", Slot = "15")]
		[AsyncStateMachine(typeof(_00B9_00A7d_00A9_008Fº))]
		public virtual Task Await()
		{
			return null;
		}

		[Token(Token = "0x60058A2")]
		[Address(RVA = "0x717D25C", Offset = "0x717925C", VA = "0x717D25C")]
		private bool _00AEhC_009E_007B_00A0()
		{
			return default;
		}

		[Token(Token = "0x60058A3")]
		[Address(RVA = "0x717D2BC", Offset = "0x71792BC", VA = "0x717D2BC")]
		public BaseEffect(EffectData _009DR_00AD_0096KE, Vector3 kS_009DyQ_008C, Vector3 _0098_00B6z_00A9_009Dº, Transform _0091zp_005Erp, bool f_00AD_0097_0093_008CH)
		{
		}

		[Token(Token = "0x60058A4")]
		[Address(RVA = "0x717D48C", Offset = "0x717948C", VA = "0x717D48C", Slot = "16")]
		public virtual Task W_009C_0099_00B7_00ABh()
		{
			return null;
		}

		[Token(Token = "0x60058A5")]
		[Address(RVA = "0x717D54C", Offset = "0x717954C", VA = "0x717D54C")]
		protected string getEffectFolder()
		{
			return null;
		}

		[Token(Token = "0x60058A6")]
		[Address(RVA = "0x717D5F0", Offset = "0x71795F0", VA = "0x717D5F0")]
		private bool dn_0098PA_00BF()
		{
			return default;
		}

		[Token(Token = "0x60058A7")]
		[Address(RVA = "0x717D610", Offset = "0x7179610", VA = "0x717D610")]
		public void _00B8m_0087v_00AC_0096()
		{
		}

		[Token(Token = "0x60058A8")]
		[Address(RVA = "0x717D61C", Offset = "0x717961C", VA = "0x717D61C", Slot = "17")]
		protected virtual void PUÂW_0082_0098()
		{
		}

		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x717D6AC", Offset = "0x71796AC", VA = "0x717D6AC", Slot = "18")]
		protected virtual void SetComponent()
		{
		}

		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x717D7C8", Offset = "0x71797C8", VA = "0x717D7C8", Slot = "19")]
		protected virtual void _0085_00A4zWSe()
		{
		}

		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x717D858", Offset = "0x7179858", VA = "0x717D858")]
		public void _00A2_0060ªpÂ_00BE(Vector3 kS_009DyQ_008C)
		{
		}

		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x717D91C", Offset = "0x717991C", VA = "0x717D91C", Slot = "20")]
		protected virtual void _00B7_0092_008C_008C_0081_009A()
		{
		}

		[Token(Token = "0x60058AD")]
		[Address(RVA = "0x717D9AC", Offset = "0x71799AC", VA = "0x717D9AC")]
		public void _00B1e_00BF_0099Z_009A(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x717DA40", Offset = "0x7179A40", VA = "0x717DA40")]
		private void M_00B0_00BFiC_0098()
		{
		}

		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x717DACC", Offset = "0x7179ACC", VA = "0x717DACC", Slot = "21")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60058B0")]
		[Address(RVA = "0x717DB74", Offset = "0x7179B74", VA = "0x717DB74")]
		protected string _008B_0098r_0060z_00A9()
		{
			return null;
		}

		[Token(Token = "0x60058B1")]
		[Address(RVA = "0x717DC18", Offset = "0x7179C18", VA = "0x717DC18")]
		public void _0094_00B1czNP()
		{
		}

		[Token(Token = "0x60058B2")]
		[Address(RVA = "0x717DC28", Offset = "0x7179C28", VA = "0x717DC28")]
		public BaseEffect(Transform _0091zp_005Erp)
		{
		}

		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x717DCA4", Offset = "0x7179CA4", VA = "0x717DCA4", Slot = "22")]
		public virtual Task cJDrqE()
		{
			return null;
		}

		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x717DD64", Offset = "0x7179D64", VA = "0x717DD64")]
		public void SetActive(bool _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x60058B5")]
		[Address(RVA = "0x717DDF8", Offset = "0x7179DF8", VA = "0x717DDF8", Slot = "23")]
		public virtual void _008B_00B1_008C_0096Tk()
		{
		}

		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x717DE9C", Offset = "0x7179E9C", VA = "0x717DE9C")]
		public void kÂS_00A1_0083u()
		{
		}

		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x717DEA8", Offset = "0x7179EA8", VA = "0x717DEA8")]
		private bool f_0081_0098_0099_00BC_0080()
		{
			return default;
		}

		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x717DEC8", Offset = "0x7179EC8", VA = "0x717DEC8")]
		protected string j_00B7K_0099_008Fc()
		{
			return null;
		}

		[Token(Token = "0x60058B9")]
		[Address(RVA = "0x717DF6C", Offset = "0x7179F6C", VA = "0x717DF6C")]
		[AsyncStateMachine(typeof(j_00BB_00B7i_00AE_00AE))]
		private void ª_0090WM_0093_00B0()
		{
		}

		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x717DFF8", Offset = "0x7179FF8", VA = "0x717DFF8")]
		private void cp_008D_00A1_005B_0093()
		{
		}

		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x717C554", Offset = "0x7178554", VA = "0x717C554")]
		public void SetOrder(string _0089h_00B3JY_007D, int qy_00AC_00B2_0090p)
		{
		}

		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x717E084", Offset = "0x717A084", VA = "0x717E084")]
		private void _009E_0083_0081n_00B1c()
		{
		}

		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x717E110", Offset = "0x717A110", VA = "0x717E110")]
		private void mT_00B2µ_00AEª()
		{
		}
	}
}
