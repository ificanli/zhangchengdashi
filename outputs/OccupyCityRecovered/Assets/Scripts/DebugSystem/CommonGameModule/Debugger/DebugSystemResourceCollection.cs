using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000012")]
	[CreateAssetMenu(fileName = "DebugSystemResourceCollection", menuName = "CommonGameModule/DebugSystem/DebugSystemResourceCollection")]
	public class DebugSystemResourceCollection : ScriptableObject
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		private static DebugSystemResourceCollection _instance;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		[Header("运行时看属性插件窗口的预制")]
		public GameObject RuntimeInspectorWindow;

		[Token(Token = "0x17000012")]
		public static DebugSystemResourceCollection Instance
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x463609C", Offset = "0x463209C", VA = "0x463609C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4636168", Offset = "0x4632168", VA = "0x4636168")]
		public DebugSystemResourceCollection()
		{
		}
	}
}
