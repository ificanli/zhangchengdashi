using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor.Demo
{
	[Token(Token = "0x2000CA1")]
	public abstract class ManagerBase<T> : MonoBehaviour where T : ManagerBase<T>
	{
		[Token(Token = "0x4005AAF")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000E20")]
		public static T Instance
		{
			[Token(Token = "0x6004F3B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F3C")]
		public abstract void Init();

		[Token(Token = "0x6004F3D")]
		protected ManagerBase()
		{
		}
	}
}
