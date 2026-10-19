using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EB8")]
	internal static class ArtifactPackConfigHelper
	{
		[Token(Token = "0x2000EB9")]
		private struct RewardEntry
		{
			[Token(Token = "0x17000F30")]
			public readonly string Id
			{
				[Token(Token = "0x600594F")]
				[Address(RVA = "0x436BAFC", Offset = "0x4367AFC", VA = "0x436BAFC")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000F31")]
			public readonly int Count
			{
				[Token(Token = "0x6005950")]
				[Address(RVA = "0x436BB04", Offset = "0x4367B04", VA = "0x436BB04")]
				[CompilerGenerated]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600594E")]
			[Address(RVA = "0x436B5D4", Offset = "0x43675D4", VA = "0x436B5D4")]
			public RewardEntry(string id, int count)
			{
			}
		}

		[Token(Token = "0x4006635")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] DesiredArtifactRareLevels;

		[Token(Token = "0x600593E")]
		[Address(RVA = "0x436A2E8", Offset = "0x43662E8", VA = "0x436A2E8")]
		internal static Dictionary<string, int> BuildConfigFromRewardTemplate(string reward)
		{
			return null;
		}

		[Token(Token = "0x600593F")]
		[Address(RVA = "0x436A6C0", Offset = "0x43666C0", VA = "0x436A6C0")]
		internal static Dictionary<string, int> BuildInitialBGroupConfig(string reward, List<GlobalPropInfo> propInfoList, Dictionary<string, GlobalPropInfo> propInfoDic)
		{
			return null;
		}

		[Token(Token = "0x6005940")]
		[Address(RVA = "0x436AAF8", Offset = "0x4366AF8", VA = "0x436AAF8")]
		internal static Dictionary<string, int> BuildRefreshedArtifactConfig(Dictionary<string, int> currentConfig, string reward, List<GlobalPropInfo> propInfoList, Dictionary<string, GlobalPropInfo> propInfoDic)
		{
			return null;
		}

		[Token(Token = "0x6005941")]
		[Address(RVA = "0x436AB7C", Offset = "0x4366B7C", VA = "0x436AB7C")]
		internal static bool NormalizeBGroupConfigInPlace(Dictionary<string, int> currentConfig, string reward, List<GlobalPropInfo> propInfoList, Dictionary<string, GlobalPropInfo> propInfoDic)
		{
			return default;
		}

		[Token(Token = "0x6005942")]
		[Address(RVA = "0x436A738", Offset = "0x4366738", VA = "0x436A738")]
		private static Dictionary<string, int> RebuildArtifactConfigInternal(Dictionary<string, int> currentConfig, string reward, List<GlobalPropInfo> propInfoList, Dictionary<string, GlobalPropInfo> propInfoDic, bool randomizeArtifacts, bool keepCurrentSlotIfMatched)
		{
			return null;
		}

		[Token(Token = "0x6005943")]
		[Address(RVA = "0x436B304", Offset = "0x4367304", VA = "0x436B304")]
		private static int GetSlotCount(List<RewardEntry> currentArtifactEntries, List<RewardEntry> templateArtifactEntries, int slotIndex)
		{
			return default;
		}

		[Token(Token = "0x6005944")]
		[Address(RVA = "0x436A5E0", Offset = "0x43665E0", VA = "0x436A5E0")]
		private static Dictionary<string, int> BuildOrderedDictionary(List<RewardEntry> artifactEntries, List<RewardEntry> extraEntries)
		{
			return null;
		}

		[Token(Token = "0x6005945")]
		[Address(RVA = "0x436B5E0", Offset = "0x43675E0", VA = "0x436B5E0")]
		private static void AddEntries(Dictionary<string, int> result, List<RewardEntry> entries)
		{
		}

		[Token(Token = "0x6005946")]
		[Address(RVA = "0x436B08C", Offset = "0x436708C", VA = "0x436B08C")]
		private static List<RewardEntry> ExtractEntries(Dictionary<string, int> config, Dictionary<string, GlobalPropInfo> propInfoDic, bool isArtifact)
		{
			return null;
		}

		[Token(Token = "0x6005947")]
		[Address(RVA = "0x436B3A4", Offset = "0x43673A4", VA = "0x436B3A4")]
		private static string SelectArtifactId(string desiredRareLevel, string preferredId, string templateId, List<GlobalPropInfo> propInfoList, Dictionary<string, GlobalPropInfo> propInfoDic, HashSet<string> usedArtifactIds, bool randomizeArtifacts)
		{
			return null;
		}

		[Token(Token = "0x6005948")]
		[Address(RVA = "0x436B7BC", Offset = "0x43677BC", VA = "0x436B7BC")]
		private static List<string> CollectCandidateIds(string desiredRareLevel, List<GlobalPropInfo> propInfoList, HashSet<string> usedArtifactIds)
		{
			return null;
		}

		[Token(Token = "0x6005949")]
		[Address(RVA = "0x436B6E8", Offset = "0x43676E8", VA = "0x436B6E8")]
		private static bool IsValidArtifactId(string artifactId, string desiredRareLevel, Dictionary<string, GlobalPropInfo> propInfoDic, HashSet<string> usedArtifactIds)
		{
			return default;
		}

		[Token(Token = "0x600594A")]
		[Address(RVA = "0x436B964", Offset = "0x4367964", VA = "0x436B964")]
		private static bool IsUsableFallback(string artifactId, Dictionary<string, GlobalPropInfo> propInfoDic, HashSet<string> usedArtifactIds)
		{
			return default;
		}

		[Token(Token = "0x600594B")]
		[Address(RVA = "0x436A358", Offset = "0x4366358", VA = "0x436A358")]
		private static void ParseRewardTemplate(string reward, out List<RewardEntry> artifactEntries, out List<RewardEntry> extraEntries)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArtifactPackConfigHelper.ParseRewardTemplate RVA=0x436A358 Token=0x600594B");
}

		[Token(Token = "0x600594C")]
		[Address(RVA = "0x436ADB8", Offset = "0x4366DB8", VA = "0x436ADB8")]
		private static bool HasSameOrderAndValues(Dictionary<string, int> lhs, Dictionary<string, int> rhs)
		{
			return default;
		}
	}
}
