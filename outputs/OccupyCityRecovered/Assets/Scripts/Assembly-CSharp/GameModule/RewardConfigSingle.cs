using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000591")]
	public class RewardConfigSingle
	{
		[Token(Token = "0x1700017A")]
		public string Num
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x3ED5BD0", Offset = "0x3ED1BD0", VA = "0x3ED5BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x3ED5BD8", Offset = "0x3ED1BD8", VA = "0x3ED5BD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public IGlobalAssetsInfo Info
		{
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x3ED5BE0", Offset = "0x3ED1BE0", VA = "0x3ED5BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x3ED5BE8", Offset = "0x3ED1BE8", VA = "0x3ED5BE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public List<string> MoreArgs
		{
			[Token(Token = "0x6001CDD")]
			[Address(RVA = "0x3ED5BF0", Offset = "0x3ED1BF0", VA = "0x3ED5BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0x3ED5BF8", Offset = "0x3ED1BF8", VA = "0x3ED5BF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x3ED5C00", Offset = "0x3ED1C00", VA = "0x3ED5C00")]
		public RewardConfigSingle(IGlobalAssetsInfo info, string num, [Optional] List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x3ED2AA4", Offset = "0x3ECEAA4", VA = "0x3ED2AA4")]
		public RewardConfigSingle(string infoId, string num, [Optional] List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x3ED4BCC", Offset = "0x3ED0BCC", VA = "0x3ED4BCC")]
		public RewardConfigSingle(string infoId, List<string> argList)
		{
		}

		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x3ED51C8", Offset = "0x3ED11C8", VA = "0x3ED51C8")]
		public bool TryAddNum(string newValue)
		{
			return default;
		}

		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x3ED5804", Offset = "0x3ED1804", VA = "0x3ED5804")]
		public void ScaleNumericNum(float ratio)
		{
		}

		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x3ED5C3C", Offset = "0x3ED1C3C", VA = "0x3ED5C3C")]
		private static int ScaleSignedInt(int value, float ratio)
		{
			return default;
		}

		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x3ED5D70", Offset = "0x3ED1D70", VA = "0x3ED5D70")]
		public void ApplyReward(bool isFirst = true)
		{
		}

		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x3ED538C", Offset = "0x3ED138C", VA = "0x3ED538C")]
		public void ApplyReward(bool isFirst, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x3ED5660", Offset = "0x3ED1660", VA = "0x3ED5660")]
		public void RemoveReward()
		{
		}

		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x3ED5DE4", Offset = "0x3ED1DE4", VA = "0x3ED5DE4")]
		public string GetContent()
		{
			return null;
		}
	}
}
