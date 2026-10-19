using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x200018D")]
	public abstract class ManagerBase<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000092")]
		public static T Instance
		{
			[Token(Token = "0x6000655")]
			get
			{
				if (!_instance)
				{
					_instance = (T)UnityEngine.Object.FindObjectOfType(typeof(T));
					if (_instance == null)
					{
						GameObject managerObject = new GameObject(typeof(T).Name);
						_instance = managerObject.AddComponent<T>();
						CoreModule.GameLauncher launcher = UnityEngine.Object.FindObjectOfType<CoreModule.GameLauncher>();
						if (launcher != null)
						{
							managerObject.transform.SetParent(launcher.transform);
						}
					}
				}
				return _instance;
			}
		}

		[Token(Token = "0x6000656")]
		public abstract UniTask Init();

		[Token(Token = "0x6000657")]
		public T2 CreateSubController<T2>() where T2 : MonoBehaviour
		{
			GameObject controllerObject = new GameObject(typeof(T2).Name);
			T2 controller = controllerObject.AddComponent<T2>();
			controller.transform.SetParent(transform);
			return controller;
		}

		[Token(Token = "0x6000658")]
		protected ManagerBase()
		{
		}
	}
}
