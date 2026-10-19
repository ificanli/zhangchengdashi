using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework.Base
{
	[Token(Token = "0x20004BE")]
	public abstract class IGameStart : MonoBehaviour
	{
		[Token(Token = "0x4001F75")]
		[FieldOffset(Offset = "0x20")]
		private GameStartEntry _00B4_0098p_00BDg_008A;

		[Token(Token = "0x60071A8")]
		[Address(RVA = "0x72EAE70", Offset = "0x72E6E70", VA = "0x72EAE70")]
		internal void _007Dye_0080_00BCa(GameStartEntry _00B4_0098p_00BDg_008A)
		{
			this._00B4_0098p_00BDg_008A = _00B4_0098p_00BDg_008A;
		}

		[Token(Token = "0x60071A9")]
		public abstract void InitPatchManager();

		[Token(Token = "0x60071AA")]
		[Address(RVA = "0x72EAE78", Offset = "0x72E6E78", VA = "0x72EAE78")]
		protected void LoadingUIShow()
		{
			_00B4_0098p_00BDg_008A.O_008AJy_0085_00BF();
		}

		[Token(Token = "0x60071AB")]
		[Address(RVA = "0x72EAE90", Offset = "0x72E6E90", VA = "0x72EAE90")]
		protected void InitConfigOver()
		{
			_00B4_0098p_00BDg_008A.whJq_00B8_00B9();
		}

		[Token(Token = "0x60071AC")]
		[Address(RVA = "0x72EAEB0", Offset = "0x72E6EB0", VA = "0x72EAEB0", Slot = "5")]
		public virtual void InitConfig_newRes()
		{
		}

		[Token(Token = "0x60071AD")]
		[Address(RVA = "0x72EAEB4", Offset = "0x72E6EB4", VA = "0x72EAEB4", Slot = "6")]
		public virtual void InitConfig(ResourcesInfo _0088_00AB_0084E_0082F)
		{
		}

		[Token(Token = "0x60071AE")]
		public abstract void StartGame();

		[Token(Token = "0x60071AF")]
		[Address(RVA = "0x72EAEB8", Offset = "0x72E6EB8", VA = "0x72EAEB8", Slot = "8")]
		public virtual void MnieGameProjectSetting()
		{
		}

		[Token(Token = "0x60071B0")]
		[Address(RVA = "0x72EAEBC", Offset = "0x72E6EBC", VA = "0x72EAEBC", Slot = "9")]
		public virtual void RegisterProcedure()
		{
		}

		[Token(Token = "0x60071B1")]
		[Address(RVA = "0x72EAEC0", Offset = "0x72E6EC0", VA = "0x72EAEC0", Slot = "10")]
		public virtual void RegisterLogicCtr()
		{
		}

		[Token(Token = "0x60071B2")]
		[Address(RVA = "0x72EAEC4", Offset = "0x72E6EC4", VA = "0x72EAEC4", Slot = "11")]
		public virtual void SetLayerCollisionMatrix()
		{
		}

		[Token(Token = "0x60071B3")]
		[Address(RVA = "0x72EAEC8", Offset = "0x72E6EC8", VA = "0x72EAEC8", Slot = "12")]
		public virtual void BeforeGameFrameworkInit()
		{
		}

		[Token(Token = "0x60071B4")]
		[Address(RVA = "0x72EAECC", Offset = "0x72E6ECC", VA = "0x72EAECC", Slot = "13")]
		public virtual void AfterGameFrameworkInit()
		{
		}

		[Token(Token = "0x60071B5")]
		[Address(RVA = "0x72EAED0", Offset = "0x72E6ED0", VA = "0x72EAED0", Slot = "14")]
		public virtual TeamType GetNewResLoadCDNTeamType()
		{
			return default;
		}

		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x72EAED8", Offset = "0x72E6ED8", VA = "0x72EAED8", Slot = "15")]
		public virtual EPlayMode GetNewResLoadAppPlayMode()
		{
			return default;
		}

		[Token(Token = "0x60071B7")]
		[Address(RVA = "0x72EAEE0", Offset = "0x72E6EE0", VA = "0x72EAEE0", Slot = "16")]
		public virtual bool GetIsOverrideConfigInit()
		{
			return default;
		}

		[Token(Token = "0x60071B8")]
		[Address(RVA = "0x72EAEE8", Offset = "0x72E6EE8", VA = "0x72EAEE8", Slot = "17")]
		public virtual void OverrideConfigInit()
		{
		}

		[Token(Token = "0x60071B9")]
		[Address(RVA = "0x72EAEEC", Offset = "0x72E6EEC", VA = "0x72EAEEC")]
		protected IGameStart()
		{
		}
	}
}
