using Il2CppDummyDll;
using UnityEngine;

namespace L_Tools
{
	[Token(Token = "0x2000FB8")]
	public class SingletonComponent<T> : MonoBehaviour where T : Component
	{
		[Token(Token = "0x4006B9A")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4006B9B")]
		[FieldOffset(Offset = "0x0")]
		public static bool isInit;

		[Token(Token = "0x4006B9C")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4006B9D")]
		[FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x17000FA6")]
		public static T Instance
		{
			[Token(Token = "0x6005E31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E32")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005E33")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6005E34")]
		public SingletonComponent()
		{
		}
	}
}
