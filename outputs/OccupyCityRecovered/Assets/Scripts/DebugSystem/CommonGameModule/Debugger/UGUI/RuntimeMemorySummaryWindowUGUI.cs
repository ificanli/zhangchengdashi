using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000086")]
	public sealed class RuntimeMemorySummaryWindowUGUI : BaseInformationWindowUGUI
	{
		[Token(Token = "0x2000087")]
		private sealed class Record
		{
			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x10")]
			private readonly string m_Name;

			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x18")]
			private int m_Count;

			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x20")]
			private long m_Size;

			[Token(Token = "0x17000083")]
			public string Name
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x468E6A0", Offset = "0x468A6A0", VA = "0x468E6A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			public int Count
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0x468E6A8", Offset = "0x468A6A8", VA = "0x468E6A8")]
				get
				{
					return default;
				}
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0x468E6B0", Offset = "0x468A6B0", VA = "0x468E6B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public long Size
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x468E6B8", Offset = "0x468A6B8", VA = "0x468E6B8")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000300")]
				[Address(RVA = "0x468E6C0", Offset = "0x468A6C0", VA = "0x468E6C0")]
				set
				{
				}
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x468E5F0", Offset = "0x468A5F0", VA = "0x468E5F0")]
			public Record(string name)
			{
			}
		}

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Record> m_Records;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x38")]
		private DateTime m_SampleTime;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x40")]
		private int m_SampleCount;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x48")]
		private long m_SampleSize;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x468DE38", Offset = "0x4689E38", VA = "0x468DE38")]
		public RuntimeMemorySummaryWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RuntimeMemorySummaryWindowUGUI..ctor RVA=0x468DE38 Token=0x060002F6; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x468DEF4", Offset = "0x4689EF4", VA = "0x468DEF4", Slot = "17")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x468DFC4", Offset = "0x4689FC4", VA = "0x468DFC4", Slot = "20")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x468E224", Offset = "0x468A224", VA = "0x468E224")]
		private void TakeSample()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x468E620", Offset = "0x468A620", VA = "0x468E620")]
		private int RecordComparer(Record a, Record b)
		{
			return default;
		}
	}
}
