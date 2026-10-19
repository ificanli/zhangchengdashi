using System;
using System.Numerics;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EDB")]
	public class UserAssetData : UserDataBase
	{
		[Token(Token = "0x400670F")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("iid")]
		public string infoId;

		[Token(Token = "0x4006710")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("c")]
		public string count;

		[Token(Token = "0x4006711")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("g")]
		public string get;

		[Token(Token = "0x4006712")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("u")]
		public string use;

		[NonSerialized]
		[Token(Token = "0x4006713")]
		[FieldOffset(Offset = "0x38")]
		public BigInteger B_C;

		[NonSerialized]
		[Token(Token = "0x4006714")]
		[FieldOffset(Offset = "0x48")]
		public BigInteger B_G;

		[NonSerialized]
		[Token(Token = "0x4006715")]
		[FieldOffset(Offset = "0x58")]
		public BigInteger B_U;

		[Token(Token = "0x4006716")]
		[FieldOffset(Offset = "0x68")]
		private GlobalAssetInfo _globalAssetInfo;

		[Token(Token = "0x60059D6")]
		[Address(RVA = "0x4376FDC", Offset = "0x4372FDC", VA = "0x4376FDC")]
		public UserAssetData()
		{
		}

		[Token(Token = "0x60059D7")]
		[Address(RVA = "0x4373E6C", Offset = "0x436FE6C", VA = "0x4373E6C")]
		public void InitBigInt()
		{
		}

		[Token(Token = "0x60059D8")]
		[Address(RVA = "0x436E174", Offset = "0x436A174", VA = "0x436E174")]
		public UserAssetData(GlobalAssetInfo assetInfo)
		{
		}

		[Token(Token = "0x60059D9")]
		[Address(RVA = "0x4376FE4", Offset = "0x4372FE4", VA = "0x4376FE4", Slot = "4")]
		public virtual GlobalInfoBase GetInfo()
		{
			return null;
		}

		[Token(Token = "0x60059DA")]
		public T GetInfo<T>() where T : GlobalInfoBase
		{
			return null;
		}
	}
}
