using System;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002EF")]
	public struct AutoRepathPolicy : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D8F")]
		public const float Sensitivity = 10f;

		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x0")]
		public Pathfinding.AutoRepathPolicy.Mode mode;

		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x1")]
		private byte pathFailures;

		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x4")]
		public float period;

		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x8")]
		private float3 lastDestination;

		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x14")]
		private float lastRepathTime;

		[Token(Token = "0x1700030A")]
		public static AutoRepathPolicy Default
		{
			[Token(Token = "0x60012A8")]
			[Address(RVA = "0x44B2868", Offset = "0x44AE868", VA = "0x44B2868")]
			get
			{
                return new AutoRepathPolicy
                {
                    mode = Pathfinding.AutoRepathPolicy.Mode.Dynamic,
                    period = 2f,
                    lastDestination = new float3(float.PositiveInfinity),
                    lastRepathTime = float.NegativeInfinity
                };
            }
		}

		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x44B2890", Offset = "0x44AE890", VA = "0x44B2890")]
		public AutoRepathPolicy(Pathfinding.AutoRepathPolicy policy)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AutoRepathPolicy..ctor RVA=0x44B2890 Token=0x60012A9");
}

		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x44B28D4", Offset = "0x44AE8D4", VA = "0x44B28D4")]
		public bool ShouldRecalculatePath(float3 position, float radius, float3 destination, float time, bool isPathStale)
		{
			return default;
		}

		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x44B09DC", Offset = "0x44AC9DC", VA = "0x44B09DC")]
		public void OnPathCalculated(bool hadError)
		{
		}

		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x44B2A48", Offset = "0x44AEA48", VA = "0x44B2A48")]
		public void Reset()
		{
		}

		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x44B098C", Offset = "0x44AC98C", VA = "0x44B098C")]
		public void OnScheduledPathRecalculation(float3 destination, float time)
		{
		}
	}
}
