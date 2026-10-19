using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameFramework;
using GameFramework.Fsm;
using GameFramework.Login;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE7")]
	public abstract class LoginProcedureBase : ILoginProcedure, IDisposable
	{
		[Token(Token = "0x4006C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IFsmManager m_FsmManager;

		[Token(Token = "0x4006C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected IFsm<LoginProcedureBase> m_Fsm;

		[Token(Token = "0x4006C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsDefaultTouristLogin;

		[Token(Token = "0x4006C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected float CheckServerContIntervalTimer;

		[Token(Token = "0x4006C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		protected bool IsSucssLogin;

		[Token(Token = "0x4006C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected LoginExt m_loginExt;

		[Token(Token = "0x4006C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int loginstateTimeout;

		[Token(Token = "0x4006C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LoginOutUI m_LoginOutUI;

		[Token(Token = "0x17000FAB")]
		public virtual bool NeedSynData
		{
			[Token(Token = "0x6005F19")]
			[Address(RVA = "0x4401A6C", Offset = "0x43FDA6C", VA = "0x4401A6C", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FAC")]
		public virtual bool AllowOldPlayerBindTourist
		{
			[Token(Token = "0x6005F1A")]
			[Address(RVA = "0x4401A74", Offset = "0x43FDA74", VA = "0x4401A74", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FAD")]
		public SdkLoginType SdkLoginType
		{
			[Token(Token = "0x6005F1B")]
			[Address(RVA = "0x4401A7C", Offset = "0x43FDA7C", VA = "0x4401A7C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F1C")]
			[Address(RVA = "0x4401A84", Offset = "0x43FDA84", VA = "0x4401A84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FAE")]
		public LoginUseInfo useInfo
		{
			[Token(Token = "0x6005F1D")]
			[Address(RVA = "0x4401A8C", Offset = "0x43FDA8C", VA = "0x4401A8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005F1E")]
			[Address(RVA = "0x4401A94", Offset = "0x43FDA94", VA = "0x4401A94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000FAF")]
		public LoginUserData SdkUser
		{
			[Token(Token = "0x6005F1F")]
			[Address(RVA = "0x4401A9C", Offset = "0x43FDA9C", VA = "0x4401A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FB0")]
		public long Uid
		{
			[Token(Token = "0x6005F20")]
			[Address(RVA = "0x4401AB8", Offset = "0x43FDAB8", VA = "0x4401AB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FB1")]
		public LoginUseInfo LastUseInfo
		{
			[Token(Token = "0x6005F21")]
			[Address(RVA = "0x4401AD4", Offset = "0x43FDAD4", VA = "0x4401AD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005F22")]
			[Address(RVA = "0x4401ADC", Offset = "0x43FDADC", VA = "0x4401ADC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000FB2")]
		public long LastUid
		{
			[Token(Token = "0x6005F23")]
			[Address(RVA = "0x4401AE4", Offset = "0x43FDAE4", VA = "0x4401AE4")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6005F24")]
			[Address(RVA = "0x4401AEC", Offset = "0x43FDAEC", VA = "0x4401AEC")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x17000FB3")]
		public bool IsNewDevice
		{
			[Token(Token = "0x6005F25")]
			[Address(RVA = "0x4401AF4", Offset = "0x43FDAF4", VA = "0x4401AF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FB4")]
		public bool IsProxyLogin
		{
			[Token(Token = "0x6005F26")]
			[Address(RVA = "0x4401B10", Offset = "0x43FDB10", VA = "0x4401B10")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F27")]
			[Address(RVA = "0x4401B18", Offset = "0x43FDB18", VA = "0x4401B18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000FB5")]
		public bool UseLoginCache
		{
			[Token(Token = "0x6005F28")]
			[Address(RVA = "0x4401B24", Offset = "0x43FDB24", VA = "0x4401B24")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6005F29")]
			[Address(RVA = "0x4401B2C", Offset = "0x43FDB2C", VA = "0x4401B2C")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x17000FB6")]
		public LoginExt loginServerExt
		{
			[Token(Token = "0x6005F2A")]
			[Address(RVA = "0x4401B38", Offset = "0x43FDB38", VA = "0x4401B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0x4401B40", Offset = "0x43FDB40", VA = "0x4401B40", Slot = "8")]
		public override void Init(string BaseURL, string appVersion = "")
		{
		}

		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0x4402518", Offset = "0x43FE518", VA = "0x4402518")]
		public bool CheckServerConnection()
		{
			return default;
		}

		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0x4402898", Offset = "0x43FE898", VA = "0x4402898")]
		public void Login()
		{
		}

		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0x4402A48", Offset = "0x43FEA48", VA = "0x4402A48")]
		public void ProxyLogin(string userId)
		{
		}

		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0x4402B54", Offset = "0x43FEB54", VA = "0x4402B54")]
		public void CutoverLogin()
		{
		}

		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x4402E38", Offset = "0x43FEE38", VA = "0x4402E38", Slot = "9")]
		public override void loginCallback(int Code, string userInfo)
		{
		}

		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x4402F2C", Offset = "0x43FEF2C", VA = "0x4402F2C")]
		public void LogOut([Optional] ResourceCollection _resourceCollection)
		{
		}

		[Token(Token = "0x6005F32")]
		[Address(RVA = "0x44034A4", Offset = "0x43FF4A4", VA = "0x44034A4")]
		private void SendLoginOutRequest()
		{
		}

		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x4403630", Offset = "0x43FF630", VA = "0x4403630")]
		private void ReceiveLoginOut(object[] parms)
		{
		}

		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x44039FC", Offset = "0x43FF9FC", VA = "0x44039FC")]
		public void GetOtherPlayerData(long uid, params string[] dataKeys)
		{
		}

		[Token(Token = "0x6005F35")]
		[Address(RVA = "0x4403A7C", Offset = "0x43FFA7C", VA = "0x4403A7C")]
		private void ReceiveGetOtherGameData(object[] parms)
		{
		}

		[Token(Token = "0x6005F36")]
		[Address(RVA = "0x4403D18", Offset = "0x43FFD18", VA = "0x4403D18")]
		private void ReceiveUserAttachment(object[] parms)
		{
		}

		[Token(Token = "0x6005F37")]
		[Address(RVA = "0x4403F4C", Offset = "0x43FFF4C", VA = "0x4403F4C")]
		public void UploadUserExt(string Ext)
		{
		}

		[Token(Token = "0x6005F38")]
		[Address(RVA = "0x4404078", Offset = "0x4400078", VA = "0x4404078", Slot = "14")]
		public virtual void LoginFail(LoginFailCode loginFailCode, string ErrorMsg = "")
		{
		}

		[Token(Token = "0x6005F39")]
		[Address(RVA = "0x44040E4", Offset = "0x44000E4", VA = "0x44040E4", Slot = "15")]
		public virtual void LoginComplete(bool IsSucc, string ErrorMsg)
		{
		}

		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x44044B4", Offset = "0x44004B4", VA = "0x44044B4", Slot = "7")]
		public override void LoginInvalid(int ErrorCode)
		{
		}

		[Token(Token = "0x6005F3B")]
		public abstract void SuccessToConnectionServer();

		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x4404578", Offset = "0x4400578", VA = "0x4404578", Slot = "17")]
		public virtual void FailToConnectionServer(LoginFailCode ErrorCode)
		{
		}

		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x440457C", Offset = "0x440057C", VA = "0x440457C", Slot = "18")]
		public virtual void ShowBindConfirmTips()
		{
		}

		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0x4404648", Offset = "0x4400648", VA = "0x4404648", Slot = "19")]
		public virtual void ShowOldUserBindConfirmTips()
		{
		}

		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0x4404714", Offset = "0x4400714", VA = "0x4404714", Slot = "20")]
		protected virtual void ReceiveOtherPlayerData(long uid, Dictionary<string, string> datas)
		{
		}

		[Token(Token = "0x6005F40")]
		[Address(RVA = "0x4404718", Offset = "0x4400718", VA = "0x4404718", Slot = "21")]
		protected virtual void ReceiveUserAttachment(List<ResponseGetAttachement.UserAttachmentInfo> Datas)
		{
		}

		[Token(Token = "0x6005F41")]
		public abstract void LoginSuccess();

		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x440471C", Offset = "0x440071C", VA = "0x440471C", Slot = "11")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x4404914", Offset = "0x4400914", VA = "0x4404914")]
		protected LoginProcedureBase()
		{
		}
	}
}
