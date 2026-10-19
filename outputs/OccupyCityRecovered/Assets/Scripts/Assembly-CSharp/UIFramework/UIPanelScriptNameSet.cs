using Il2CppDummyDll;
using UnityEngine;

namespace UIFramework
{
	[Token(Token = "0x2000C51")]
	public class UIPanelScriptNameSet : MonoBehaviour
	{
		[Token(Token = "0x400585A")]
		[FieldOffset(Offset = "0x20")]
		[Header("脚本名 例：CongratulationPanel")]
		public string scriptName;

		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x4275B74", Offset = "0x4271B74", VA = "0x4275B74")]
		public UIPanelScriptNameSet()
		{
		}
	}
}
