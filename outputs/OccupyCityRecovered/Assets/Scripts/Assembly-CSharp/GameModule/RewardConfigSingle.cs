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
        [Token(Token = "0x400303B")]
        [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
        [CompilerGenerated]
        private string _003CNum_003Ek__BackingField;

        [Token(Token = "0x400303C")]
        [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
        [CompilerGenerated]
        private IGlobalAssetsInfo _003CInfo_003Ek__BackingField;

        [Token(Token = "0x400303D")]
        [Il2CppDummyDll.FieldOffset(Offset = "0x20")]
        [CompilerGenerated]
        private List<string> _003CMoreArgs_003Ek__BackingField;

		[Token(Token = "0x1700017A")]
		public string Num
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x3ED5BD0", Offset = "0x3ED1BD0", VA = "0x3ED5BD0")]
			[CompilerGenerated]
			get
			{
            return _003CNum_003Ek__BackingField;
        }
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x3ED5BD8", Offset = "0x3ED1BD8", VA = "0x3ED5BD8")]
			[CompilerGenerated]
			private set
			{
            _003CNum_003Ek__BackingField = value;
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
            return _003CInfo_003Ek__BackingField;
        }
			[Token(Token = "0x6001CDC")]
			[Address(RVA = "0x3ED5BE8", Offset = "0x3ED1BE8", VA = "0x3ED5BE8")]
			[CompilerGenerated]
			private set
			{
            _003CInfo_003Ek__BackingField = value;
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
            return _003CMoreArgs_003Ek__BackingField;
        }
			[Token(Token = "0x6001CDE")]
			[Address(RVA = "0x3ED5BF8", Offset = "0x3ED1BF8", VA = "0x3ED5BF8")]
			[CompilerGenerated]
			private set
			{
            _003CMoreArgs_003Ek__BackingField = value;
        }
		}

		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x3ED5C00", Offset = "0x3ED1C00", VA = "0x3ED5C00")]
		public RewardConfigSingle(IGlobalAssetsInfo info, string num, [Optional] List<string> moreArgs)
		{
            Num = num;
            Info = info;
            MoreArgs = moreArgs;
        }

		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x3ED2AA4", Offset = "0x3ECEAA4", VA = "0x3ED2AA4")]
		public RewardConfigSingle(string infoId, string num, [Optional] List<string> moreArgs)
		{
            IGlobalAssetsInfo resolved;
            bool found = RewardManager.TryFindAssetsInfo(infoId, out resolved);
            MoreArgs = moreArgs;
            Num = num;
            Info = found ? resolved : null;
        }

		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x3ED4BCC", Offset = "0x3ED0BCC", VA = "0x3ED4BCC")]
		public RewardConfigSingle(string infoId, List<string> argList)
		{
            IGlobalAssetsInfo resolved;
            bool found = RewardManager.TryFindAssetsInfo(infoId, out resolved);
            Info = found ? resolved : null;
            Num = argList[0];
            if (argList.Count >= 2)
                MoreArgs = argList.GetRange(1, argList.Count - 1);
        }

		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x3ED51C8", Offset = "0x3ED11C8", VA = "0x3ED51C8")]
		public bool TryAddNum(string newValue)
		{
            if (MoreArgs != null && MoreArgs.Count != 0) return false;
            int currentInt;
            int addedInt;
            if (int.TryParse(Num, out currentInt) && int.TryParse(newValue, out addedInt))
            {
                Num = unchecked(currentInt + addedInt).ToString();
                return true;
            }
            float currentFloat;
            float addedFloat;
            if (float.TryParse(Num, out currentFloat) && float.TryParse(newValue, out addedFloat))
            {
                Num = (currentFloat + addedFloat).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            return false;
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
            if (value == 0) return 0;
            int magnitude = value < 0 ? unchecked(-value) : value;
            float scaled = (float)magnitude * ratio;
            double rounded = global::System.Math.Round((double)scaled, global::System.MidpointRounding.ToEven);
            int converted;
            // Preserve the original ARM64 FCVTZS saturation and its explicit +Infinity override.
            if (double.IsNaN(rounded)) converted = 0;
            else if (double.IsPositiveInfinity(rounded)) converted = int.MinValue;
            else if (rounded >= 2147483648d) converted = int.MaxValue;
            else if (rounded <= -2147483648d) converted = int.MinValue;
            else converted = (int)rounded;
            return value < 0 ? unchecked(-converted) : converted;
        }

		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x3ED5D70", Offset = "0x3ED1D70", VA = "0x3ED5D70")]
		public void ApplyReward(bool isFirst = true)
		{
            ApplyRewardDispatcher.ApplyReward(Info, isFirst, Num, MoreArgs);
        }

		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x3ED538C", Offset = "0x3ED138C", VA = "0x3ED538C")]
		public void ApplyReward(bool isFirst, CurrencyTransactionSceneType sceneType)
		{
            List<string> arguments = MoreArgs != null && MoreArgs.Count > 0 ? new List<string>(MoreArgs) : new List<string>();
            arguments.Add(((int)sceneType).ToString());
            ApplyRewardDispatcher.ApplyReward(Info, isFirst, Num, arguments);
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
