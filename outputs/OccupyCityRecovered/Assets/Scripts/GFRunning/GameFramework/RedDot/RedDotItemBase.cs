using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.RedDot
{
	[Token(Token = "0x200044B")]
	public abstract class RedDotItemBase : MonoBehaviour
	{
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x20")]
		protected int[] redDotTypes;

		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x28")]
		private bool FWanY_007C;

		[Token(Token = "0x60069C0")]
		[Address(RVA = "0x727797C", Offset = "0x727397C", VA = "0x727797C", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60069C1")]
		[Address(RVA = "0x7277A78", Offset = "0x7273A78", VA = "0x7277A78", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x60069C2")]
		[Address(RVA = "0x7277A7C", Offset = "0x7273A7C", VA = "0x7277A7C")]
		public void CheckRedDot()
		{
		}

		[Token(Token = "0x60069C3")]
		[Address(RVA = "0x7277BA8", Offset = "0x7273BA8", VA = "0x7277BA8")]
		internal void _009E_007Ev_008F_007D_00A3(bool _00BC_0094_0095ik_00AB, bool wqVlx_00B3 = false)
		{
		}

		[Token(Token = "0x60069C4")]
		[Address(RVA = "0x7277BF4", Offset = "0x7273BF4", VA = "0x7277BF4")]
		internal int[] _00A7h_009C_005D_008A_00A3()
		{
			return null;
		}

		[Token(Token = "0x60069C5")]
		[Address(RVA = "0x7277BFC", Offset = "0x7273BFC", VA = "0x7277BFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60069C6")]
		protected abstract void SaveRedDotTyoes();

		[Token(Token = "0x60069C7")]
		protected abstract void RefreshRedDot(bool _007Evm_007CF_008C);

		[Token(Token = "0x60069C8")]
		[Address(RVA = "0x7277D7C", Offset = "0x7273D7C", VA = "0x7277D7C")]
		protected RedDotItemBase()
		{
		}
	}
}
