using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000172")]
	[ExecuteInEditMode]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/unityreferencehelper.html")]
	public class UnityReferenceHelper : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private string guid;

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x4580C80", Offset = "0x457CC80", VA = "0x4580C80")]
		public string GetGUID()
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4580C88", Offset = "0x457CC88", VA = "0x4580C88")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4580C8C", Offset = "0x457CC8C", VA = "0x4580C8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4580E68", Offset = "0x457CE68", VA = "0x4580E68")]
		public UnityReferenceHelper()
		{
		}
	}
}
