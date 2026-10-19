using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200035A")]
	public abstract class DataManagerBase
	{
		[Token(Token = "0x4001A21")]
		[FieldOffset(Offset = "0x10")]
		internal bool _007C_007Ev_00A8G_00BB;

		[Token(Token = "0x4001A22")]
		[FieldOffset(Offset = "0x11")]
		internal bool _00B1_009C_00AB_007DRS;

		[Token(Token = "0x4001A23")]
		[FieldOffset(Offset = "0x12")]
		internal bool Rr_00A1_00B8f_008C;

		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x18")]
		internal string s_00B0W_0099w_009C;

		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x20")]
		private bool N_00A4P_0099_00AE_0091;

		[Token(Token = "0x170010FB")]
		public virtual string DataKey
		{
			[Token(Token = "0x6005815")]
			[Address(RVA = "0x7171AE4", Offset = "0x716DAE4", VA = "0x7171AE4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005816")]
		public abstract void OnInit();

		[Token(Token = "0x6005817")]
		public abstract void OnSave();

		[Token(Token = "0x6005818")]
		public abstract void OnRelease();

		[Token(Token = "0x6005819")]
		[Address(RVA = "0x7171B08", Offset = "0x716DB08", VA = "0x7171B08")]
		private bool _008E_00B6F_00B6dB()
		{
			return default;
		}

		[Token(Token = "0x600581A")]
		[Address(RVA = "0x7171E48", Offset = "0x716DE48", VA = "0x7171E48", Slot = "8")]
		protected virtual void SaveLocalData(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x600581B")]
		[Address(RVA = "0x71722B8", Offset = "0x716E2B8", VA = "0x71722B8")]
		private void T_00BD_007BLGZ(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x600581C")]
		[Address(RVA = "0x717284C", Offset = "0x716E84C", VA = "0x717284C", Slot = "9")]
		[Obsolete("请使用UpdataData方法更新数据，并在UpdateDataCallBack中解析收到的数据")]
		protected virtual string ReadLocalData()
		{
			return null;
		}

		[Token(Token = "0x600581D")]
		[Address(RVA = "0x7172DE0", Offset = "0x716EDE0", VA = "0x7172DE0", Slot = "10")]
		public virtual void UpdataData(bool L_008AM_0060_005D_0080 = true)
		{
		}

		[Token(Token = "0x600581E")]
		[Address(RVA = "0x7172F14", Offset = "0x716EF14", VA = "0x7172F14")]
		internal void _009Al_0084DD_0095(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x600581F")]
		[Address(RVA = "0x7173004", Offset = "0x716F004", VA = "0x7173004", Slot = "11")]
		protected virtual void UpdateDataCallBack(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x6005820")]
		[Address(RVA = "0x7173008", Offset = "0x716F008", VA = "0x7173008")]
		internal void _005Duv_0094_009F_009B(long _0081_007Dº_0093u_008D)
		{
		}

		[Token(Token = "0x6005821")]
		[Address(RVA = "0x7173014", Offset = "0x716F014", VA = "0x7173014", Slot = "12")]
		protected virtual void SynServerTime(long _0081_007Dº_0093u_008D)
		{
		}

		[Token(Token = "0x6005822")]
		[Address(RVA = "0x7173018", Offset = "0x716F018", VA = "0x7173018")]
		protected DataManagerBase()
		{
		}
	}
}
