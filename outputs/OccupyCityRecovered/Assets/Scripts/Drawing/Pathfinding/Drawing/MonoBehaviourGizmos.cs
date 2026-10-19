using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000053")]
	public abstract class MonoBehaviourGizmos : MonoBehaviour, IDrawGizmos
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x46EFD98", Offset = "0x46EBD98", VA = "0x46EFD98")]
		public MonoBehaviourGizmos()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x46EFDA0", Offset = "0x46EBDA0", VA = "0x46EFDA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x46EFDA4", Offset = "0x46EBDA4", VA = "0x46EFDA4", Slot = "6")]
		public virtual void DrawGizmos()
		{
		}
	}
}
