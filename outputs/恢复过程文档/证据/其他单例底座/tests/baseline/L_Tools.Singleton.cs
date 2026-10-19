using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FB6")]
	public class Singleton<T> where T : new()
	{
		[Token(Token = "0x2000FB7")]
		private class SingletonCreator
		{
			[Token(Token = "0x4006B99")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly T instance;

			[Token(Token = "0x6005E2F")]
			public SingletonCreator()
			{
			}
		}

		[Token(Token = "0x17000FA5")]
		public static T Instance
		{
			[Token(Token = "0x6005E2D")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005E2E")]
		public Singleton()
		{
		}
	}
}
