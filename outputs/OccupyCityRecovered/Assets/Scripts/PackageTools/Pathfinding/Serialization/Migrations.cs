using Il2CppDummyDll;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000009")]
	public struct Migrations
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		internal int finishedMigrations;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x4")]
		internal int allMigrations;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		internal bool ignore;

		[Token(Token = "0x400000C")]
		private const int MIGRATE_TO_BITFIELD = 1073741824;

		[Token(Token = "0x17000003")]
		public bool IsLegacyFormat
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x7838378", Offset = "0x7834378", VA = "0x7838378")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public int LegacyVersion
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x7838440", Offset = "0x7834440", VA = "0x7838440")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x7838138", Offset = "0x7834138", VA = "0x7838138")]
		public Migrations(int value)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Migrations..ctor RVA=0x7838138 Token=0x6000015");
}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7838400", Offset = "0x7834400", VA = "0x7838400")]
		public bool TryMigrateFromLegacyFormat(out int legacyVersion)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Migrations.TryMigrateFromLegacyFormat RVA=0x7838400 Token=0x6000016");
}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7838448", Offset = "0x7834448", VA = "0x7838448")]
		public void MarkMigrationFinished(int flag)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x78384AC", Offset = "0x78344AC", VA = "0x78384AC")]
		public bool AddAndMaybeRunMigration(int flag, bool filter = true)
		{
			return default;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x783853C", Offset = "0x783453C", VA = "0x783853C")]
		public void IgnoreMigrationAttempt()
		{
		}
	}
}
