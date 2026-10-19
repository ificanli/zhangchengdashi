using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D7B")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x4005F94")]
		[FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000E68")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x600533E")]
			[Address(RVA = "0x43132A8", Offset = "0x430F2A8", VA = "0x43132A8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600533F")]
			[Address(RVA = "0x43132B0", Offset = "0x430F2B0", VA = "0x43132B0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6005340")]
		[Address(RVA = "0x43132B8", Offset = "0x430F2B8", VA = "0x43132B8")]
		public LanguageSourceAsset()
		{
		}
	}
}
