using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BadgeGraph.Demo
{
	[Token(Token = "0x2000E10")]
	public class FromScriptDemo : MonoBehaviour
	{
		[Token(Token = "0x2000E11")]
		private class BadgeConst
		{
			[Token(Token = "0x4006213")]
			public const char SplitSymbol = '/';

			[Token(Token = "0x4006214")]
			public const string Root = "Root";

			[Token(Token = "0x4006215")]
			public const string Event = "Root/Event";

			[Token(Token = "0x4006216")]
			public const string CardEvent = "Root/Event/CardEvent";

			[Token(Token = "0x4006217")]
			public const string AnimalCardEvent = "Root/Event/CardEvent/AnimalCardEvent";

			[Token(Token = "0x4006218")]
			public const string SportCardEvent = "Root/Event/CardEvent/SportCardEvent";

			[Token(Token = "0x4006219")]
			public const string Mail = "Root/Mail";

			[Token(Token = "0x400621A")]
			public const string NotifyMail = "Root/Mail/NotifyMail";

			[Token(Token = "0x400621B")]
			public const string RewardMail = "Root/Mail/RewardMail";

			[Token(Token = "0x400621C")]
			public const string Task = "Root/Task";

			[Token(Token = "0x400621D")]
			public const string BeginnerTask = "Root/Task/BeginnerTask";

			[Token(Token = "0x400621E")]
			public const string DailyTask = "Root/Task/DailyTask";

			[Token(Token = "0x400621F")]
			public const string SpecialTask = "Root/Task/SpecialTask";

			[Token(Token = "0x60056CC")]
			[Address(RVA = "0x43412C4", Offset = "0x433D2C4", VA = "0x43412C4")]
			public BadgeConst()
			{
			}
		}

		[Token(Token = "0x4006212")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_BadgeTreeList;

		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x4340D2C", Offset = "0x433CD2C", VA = "0x4340D2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x4340D78", Offset = "0x433CD78", VA = "0x4340D78")]
		public FromScriptDemo()
		{
		}
	}
}
