using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace L_Tools.GameTest
{
	[Token(Token = "0x2000FBC")]
	[ModelRegister("ljzs_lt", true, false)]
	[Skip]
	public class LTPlayerPrefsDataManager : DataManagerBase
	{
		[Token(Token = "0x4006BA4")]
		[FieldOffset(Offset = "0x0")]
		public static LTPlayerPrefsDataManager I;

		[Token(Token = "0x4006BA5")]
		[FieldOffset(Offset = "0x28")]
		private string lastSaveData;

		[Token(Token = "0x4006BA6")]
		[FieldOffset(Offset = "0x8")]
		public static bool CanSave;

		[Token(Token = "0x4006BA7")]
		[FieldOffset(Offset = "0x9")]
		private static bool IsUploadEmptyData;

		[Token(Token = "0x4006BA8")]
		[FieldOffset(Offset = "0xA")]
		public static bool isInBattle;

		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x43FB1FC", Offset = "0x43F71FC", VA = "0x43FB1FC", Slot = "5")]
		public override void OnInit()
		{
		}

		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x43FB314", Offset = "0x43F7314", VA = "0x43FB314")]
		public string ReLoadLocalData()
		{
			return null;
		}

		[Token(Token = "0x6005E42")]
		[Address(RVA = "0x43FB334", Offset = "0x43F7334", VA = "0x43FB334", Slot = "11")]
		protected override void UpdateDataCallBack(string str)
		{
		}

		[Token(Token = "0x6005E43")]
		[Address(RVA = "0x43FB5D4", Offset = "0x43F75D4", VA = "0x43FB5D4", Slot = "7")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x43FB5D8", Offset = "0x43F75D8", VA = "0x43FB5D8")]
		public void UploadEmptyData()
		{
		}

		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x43FB6A4", Offset = "0x43F76A4", VA = "0x43FB6A4", Slot = "6")]
		public override void OnSave()
		{
		}

		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x43FB710", Offset = "0x43F7710", VA = "0x43FB710")]
		public void Load()
		{
		}

		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x43FB80C", Offset = "0x43F780C", VA = "0x43FB80C")]
		public void Save(string str)
		{
		}

		[Token(Token = "0x6005E48")]
		[Address(RVA = "0x43FB8AC", Offset = "0x43F78AC", VA = "0x43FB8AC")]
		public LTPlayerPrefsDataManager()
		{
		}
	}
}
