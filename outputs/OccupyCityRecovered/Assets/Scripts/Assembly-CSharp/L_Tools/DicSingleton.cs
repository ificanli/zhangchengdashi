using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FB4")]
	public class DicSingleton<T> where T : new()
	{
		[Token(Token = "0x2000FB5")]
		private class SingletonCreator
		{
			[Token(Token = "0x4006B98")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly T instance;

			[Token(Token = "0x6005E2B")]
			public SingletonCreator()
			{
			}
		}

		[Token(Token = "0x17000FA4")]
		public static T Instance
		{
			[Token(Token = "0x6005E29")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DicSingleton.Instance.get RVA= Token=0x6005E29");
}
		}

		[Token(Token = "0x6005E2A")]
		public DicSingleton()
		{
		}
	}
}
