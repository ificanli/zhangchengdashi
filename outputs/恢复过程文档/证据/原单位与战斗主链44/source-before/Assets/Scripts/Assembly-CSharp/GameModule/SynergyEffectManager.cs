using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000458")]
	public class SynergyEffectManager : ManagerBase<SynergyEffectManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000459")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x6001524")]
			[Address(RVA = "0x3E1020C", Offset = "0x3E0C20C", VA = "0x3E1020C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001525")]
			[Address(RVA = "0x3E102C0", Offset = "0x3E0C2C0", VA = "0x3E102C0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool IsUseNewFetter;

		[Token(Token = "0x6001502")]
		[Address(RVA = "0x3E0F400", Offset = "0x3E0B400", VA = "0x3E0F400", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001503")]
		[Address(RVA = "0x3E0F480", Offset = "0x3E0B480", VA = "0x3E0F480")]
		private int GetFetterCount(CardFettersType fetterType, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001504")]
		[Address(RVA = "0x3E0F5F8", Offset = "0x3E0B5F8", VA = "0x3E0F5F8")]
		private int GetAtkWayTypeCount(AtkWayType atkWayType, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001505")]
		[Address(RVA = "0x3E0F6D4", Offset = "0x3E0B6D4", VA = "0x3E0F6D4")]
		private float InternalCalculateProductionSpeed(float originalSpawnTime, bool isEnemy, int fetterCount, int requiredCount)
		{
			return default;
		}

		[Token(Token = "0x6001506")]
		[Address(RVA = "0x3E0F6F0", Offset = "0x3E0B6F0", VA = "0x3E0F6F0")]
		private int InternalCalculateDamage(int originalAttack, bool isEnemy, int fetterCount, int requiredCount)
		{
			// Recovered from ARM64 RVA 0x3E0F6F0; the native method does not read isEnemy.
			if (fetterCount < requiredCount)
				return originalAttack;
			float bonus = (float)originalAttack * 0.5f;
			return unchecked(originalAttack + (int)bonus);
		}

		[Token(Token = "0x6001507")]
		[Address(RVA = "0x3E0F728", Offset = "0x3E0B728", VA = "0x3E0F728")]
		public float HumanFetter2(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001508")]
		[Address(RVA = "0x3E0F770", Offset = "0x3E0B770", VA = "0x3E0F770")]
		public int HumanFetter4(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001509")]
		[Address(RVA = "0x3E0F7C8", Offset = "0x3E0B7C8", VA = "0x3E0F7C8")]
		public int HumanFetter6(int originalOutput, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600150A")]
		[Address(RVA = "0x3E0F824", Offset = "0x3E0B824", VA = "0x3E0F824")]
		public bool HumanFetter6_GoldPerSecond(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600150B")]
		[Address(RVA = "0x3E0F854", Offset = "0x3E0B854", VA = "0x3E0F854")]
		public int HumanFetter2_BuildingHp(int originalHp, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600150C")]
		[Address(RVA = "0x3E0F8AC", Offset = "0x3E0B8AC", VA = "0x3E0F8AC")]
		public int HumanFetter4_DamageReduction(int damage, EntityBase target, bool isEnemy, float checkRange = 1f)
		{
			return default;
		}

		[Token(Token = "0x600150D")]
		[Address(RVA = "0x3E0F9EC", Offset = "0x3E0B9EC", VA = "0x3E0F9EC")]
		public float UndeadFetter2(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600150E")]
		[Address(RVA = "0x3E0FA44", Offset = "0x3E0BA44", VA = "0x3E0FA44")]
		public int UndeadFetter4(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600150F")]
		[Address(RVA = "0x3E0FA9C", Offset = "0x3E0BA9C", VA = "0x3E0FA9C")]
		public bool UndeadFetter6(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001510")]
		[Address(RVA = "0x3E0FAF0", Offset = "0x3E0BAF0", VA = "0x3E0FAF0")]
		public bool UndeadFetter4_Revive(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001511")]
		[Address(RVA = "0x3E0FB38", Offset = "0x3E0BB38", VA = "0x3E0FB38")]
		public bool UndeadFetter6_ExtraSpawn(bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001512")]
		[Address(RVA = "0x3E0FB68", Offset = "0x3E0BB68", VA = "0x3E0FB68")]
		public float OrcsFetter2(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001513")]
		[Address(RVA = "0x3E0FBB0", Offset = "0x3E0BBB0", VA = "0x3E0FBB0")]
		public int OrcsFetter4(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001514")]
		[Address(RVA = "0x3E0FC08", Offset = "0x3E0BC08", VA = "0x3E0FC08")]
		public float OrcsFetter6(float originalVampireObb, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001515")]
		[Address(RVA = "0x3E0FC50", Offset = "0x3E0BC50", VA = "0x3E0FC50")]
		public float OrcsFetter2_MoveSpeed(float originalMoveSpeed, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001516")]
		[Address(RVA = "0x3E0FC98", Offset = "0x3E0BC98", VA = "0x3E0FC98")]
		public bool OrcsFetter4_AttackSpeed(int currentHp, int maxHp, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001517")]
		[Address(RVA = "0x3E0FCFC", Offset = "0x3E0BCFC", VA = "0x3E0FCFC")]
		public int OrcsFetter6_BuildingDamage(int originalDamage, bool isEnemy, bool isBuilding)
		{
			return default;
		}

		[Token(Token = "0x6001518")]
		[Address(RVA = "0x3E0FD58", Offset = "0x3E0BD58", VA = "0x3E0FD58")]
		public float MachineFetter2(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001519")]
		[Address(RVA = "0x3E0FDA0", Offset = "0x3E0BDA0", VA = "0x3E0FDA0")]
		public int MachineFetter4(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600151A")]
		[Address(RVA = "0x3E0FDF0", Offset = "0x3E0BDF0", VA = "0x3E0FDF0")]
		public int MachineFetter6(int originalDamage, bool isEnemy, bool isBuilding)
		{
			return default;
		}

		[Token(Token = "0x600151B")]
		[Address(RVA = "0x3E0FE4C", Offset = "0x3E0BE4C", VA = "0x3E0FE4C")]
		public float MeleeFetter3(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600151C")]
		[Address(RVA = "0x3E0FE88", Offset = "0x3E0BE88", VA = "0x3E0FE88")]
		public int MeleeFetter5(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600151D")]
		[Address(RVA = "0x3E0FED8", Offset = "0x3E0BED8", VA = "0x3E0FED8")]
		public int MeleeFetter7(int originalHp, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600151E")]
		[Address(RVA = "0x3E0FF2C", Offset = "0x3E0BF2C", VA = "0x3E0FF2C")]
		public float RemoteFetter3(float originalSpawnTime, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x600151F")]
		[Address(RVA = "0x3E0FF68", Offset = "0x3E0BF68", VA = "0x3E0FF68")]
		public int RemoteFetter5(int originalAttack, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001520")]
		[Address(RVA = "0x3E0FFB8", Offset = "0x3E0BFB8", VA = "0x3E0FFB8")]
		public float RemoteFetter7(float originalRange, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001521")]
		[Address(RVA = "0x3E0FFF4", Offset = "0x3E0BFF4", VA = "0x3E0FFF4")]
		public float MachineFetter2_Range(float originalRange, bool isEnemy)
		{
			return default;
		}

		[Token(Token = "0x6001522")]
		[Address(RVA = "0x3E1003C", Offset = "0x3E0C03C", VA = "0x3E1003C")]
		public int MachineFetter6_RemoteDamageReduction(int damage, EntityBase target, bool isEnemy, AtkWayType atkWayType)
		{
			return default;
		}

		[Token(Token = "0x6001523")]
		[Address(RVA = "0x3E1016C", Offset = "0x3E0C16C", VA = "0x3E1016C")]
		public SynergyEffectManager()
		{
		}
	}
}
