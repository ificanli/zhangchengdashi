using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000231")]
	public class ArtifactAIReleaseManager : ManagerBase<ArtifactAIReleaseManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200023C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__8 : IAsyncStateMachine
		{
			[Token(Token = "0x4001E28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001E29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x4294778", Offset = "0x4290778", VA = "0x4294778", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x429482C", Offset = "0x429082C", VA = "0x429482C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001DF6")]
		private const float TickInterval = 0.5f;

		[Token(Token = "0x4001DF7")]
		private const int ForceReleaseFlipThreshold = 5;

		[Token(Token = "0x4001DF8")]
		private const float ForceReleaseCleak = 0.5f;

		[Token(Token = "0x4001DF9")]
		private const int DefaultUnitCap = 100;

		[Token(Token = "0x4001DFA")]
		private const int LightningChainJumpCount = 3;

		[Token(Token = "0x4001DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _tickAccum;

		[Token(Token = "0x4001DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _releasedThisTick;

		[Token(Token = "0x4001DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _hasLoggedNoChargeWarning;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x428F624", Offset = "0x428B624", VA = "0x428F624", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__8))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x428F6A4", Offset = "0x428B6A4", VA = "0x428F6A4")]
		public void OnTick()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4292584", Offset = "0x428E584", VA = "0x4292584")]
		private static void LogTickData(string propId, ArtifactAIReleaseType type, int openHexCount, int distanceToNext, float cleak, float threshold, ArtifactAIFormulaContext ctx)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x428FC10", Offset = "0x428BC10", VA = "0x428FC10")]
		private static (int, float) ComputeCleak(int openHexCount)
		{
			return default;
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x428FED8", Offset = "0x428BED8", VA = "0x428FED8")]
		private static ArtifactAIReleaseType ParseArtifactType(string type)
		{
			return default;
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x42905A0", Offset = "0x428C5A0", VA = "0x42905A0")]
		private bool CheckGlobalRelease(string propId, GlobalArtifactAIReleaseInfo cfg, ArtifactAIFormulaContext ctx, float threshold, out string detail)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArtifactAIReleaseManager.CheckGlobalRelease RVA=0x42905A0 Token=0x600095A");
}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x4291914", Offset = "0x428D914", VA = "0x4291914")]
		private Vector3? CheckBuildingRelease(string propId, GlobalArtifactAIReleaseInfo cfg, ArtifactAIFormulaContext ctx, float threshold, out string detail)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArtifactAIReleaseManager.CheckBuildingRelease RVA=0x4291914 Token=0x600095B");
}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x4291E68", Offset = "0x428DE68", VA = "0x4291E68")]
		private Vector3? CheckAreaRelease(string propId, GlobalArtifactAIReleaseInfo cfg, ArtifactAIFormulaContext ctx, float threshold, out string detail)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArtifactAIReleaseManager.CheckAreaRelease RVA=0x4291E68 Token=0x600095C");
}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x4290000", Offset = "0x428C000", VA = "0x4290000")]
		private bool CheckSpecialRelease(string propId, GlobalArtifactAIReleaseInfo cfg, ArtifactAIFormulaContext ctx, out string detail)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ArtifactAIReleaseManager.CheckSpecialRelease RVA=0x4290000 Token=0x600095D");
}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x429283C", Offset = "0x428E83C", VA = "0x429283C")]
		private static (Vector3?, float) FindHealTotemBest(ArtifactAIFormulaContext ctx, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x4292B28", Offset = "0x428EB28", VA = "0x4292B28")]
		private static (Vector3?, float) FindWorldTreeBest(ArtifactAIFormulaContext ctx, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x4292E0C", Offset = "0x428EE0C", VA = "0x4292E0C")]
		private static (Vector3?, float) FindLightningBest(ArtifactAIFormulaContext ctx, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x4292FCC", Offset = "0x428EFCC", VA = "0x4292FCC")]
		private static (Vector3?, float) FindTeleportBest(ArtifactAIFormulaContext ctx, GlobalArtifactAIReleaseInfo cfg, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x42932D0", Offset = "0x428F2D0", VA = "0x42932D0")]
		private static (Vector3?, float) FindSacrDaggerBest(ArtifactAIFormulaContext ctx, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x429385C", Offset = "0x428F85C", VA = "0x429385C")]
		private static (Vector3?, float) FindCharmGemBest(ArtifactAIFormulaContext ctx, GlobalArtifactAIReleaseInfo cfg, int radiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x4292230", Offset = "0x428E230", VA = "0x4292230")]
		private Vector3? GetForceReleasePos(string propId, ArtifactAIReleaseType type, GlobalArtifactAIReleaseInfo cfg, ArtifactAIFormulaContext ctx)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x4293A88", Offset = "0x428FA88", VA = "0x4293A88")]
		private static float SimulateLightningChainScore(ArtifactAIFormulaContext.UnitSnapshot start, List<ArtifactAIFormulaContext.UnitSnapshot> enemies, int jumpRadiusHex)
		{
			return default;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x4293D84", Offset = "0x428FD84", VA = "0x4293D84")]
		private static Vector3? GetHighestValueAllyPos(ArtifactAIFormulaContext ctx)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x4293F3C", Offset = "0x428FF3C", VA = "0x4293F3C")]
		private static Vector3? GetHighestValueEnemyPos(ArtifactAIFormulaContext ctx)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x42940F4", Offset = "0x42900F4", VA = "0x42940F4")]
		private static Vector3? GetLowestValueAllyPos(ArtifactAIFormulaContext ctx)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x4292750", Offset = "0x428E750", VA = "0x4292750")]
		private static int GetReleaseRadiusHex(string propId, GlobalArtifactAIReleaseInfo cfg)
		{
			return default;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x4293D48", Offset = "0x428FD48", VA = "0x4293D48")]
		private static int ParsePositiveInt(string value, int defaultValue)
		{
			return default;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x42904E4", Offset = "0x428C4E4", VA = "0x42904E4")]
		private void DoRelease(string propId, Vector3? releasePos, string detail)
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x4294358", Offset = "0x4290358", VA = "0x4294358")]
		public ArtifactAIReleaseManager()
		{
		}
	}
}
