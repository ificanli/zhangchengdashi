using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000084")]
	public sealed class RuntimeMemoryInformationWindowUGUI<T> : BaseInformationWindowUGUI where T : UnityEngine.Object
	{
		[Token(Token = "0x2000085")]
		private sealed class Sample
		{
			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x0")]
			private readonly string m_Name;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x0")]
			private readonly string m_Type;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x0")]
			private readonly long m_Size;

			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x0")]
			private bool m_Highlight;

			[Token(Token = "0x1700007F")]
			public string Name
			{
				[Token(Token = "0x60002F1")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			public string Type
			{
				[Token(Token = "0x60002F2")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			public long Size
			{
				[Token(Token = "0x60002F3")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000082")]
			public bool Highlight
			{
				[Token(Token = "0x60002F4")]
				get
				{
					return default;
				}
				[Token(Token = "0x60002F5")]
				set
				{
				}
			}

			[Token(Token = "0x60002F0")]
			public Sample(string name, string type, long size)
			{
			}
		}

		[Token(Token = "0x400023A")]
		private const int ShowSampleCount = 300;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<Sample> m_Samples;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x0")]
		private DateTime m_SampleTime;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x0")]
		private long m_SampleSize;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x0")]
		private long m_DuplicateSampleSize;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x0")]
		private int m_DuplicateSimpleCount;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		private string typeName;

		[Token(Token = "0x60002EB")]
		public RuntimeMemoryInformationWindowUGUI(InformationWindowUGUI windowUgui) : base(windowUgui)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RuntimeMemoryInformationWindowUGUI..ctor RVA=0x5FA805C Token=0x060002EB; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60002EC")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60002ED")]
		protected override void OnRefreshText()
		{
		}

		[Token(Token = "0x60002EE")]
		private void TakeSample()
		{
		}

		[Token(Token = "0x60002EF")]
		private int SampleComparer(Sample a, Sample b)
		{
			return default;
		}
	}
}
