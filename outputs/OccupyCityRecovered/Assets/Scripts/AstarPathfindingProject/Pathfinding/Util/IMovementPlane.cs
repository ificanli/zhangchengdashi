using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x2000295")]
	public interface IMovementPlane
	{
		[Token(Token = "0x6001059")]
		Vector2 ToPlane(Vector3 p);

		[Token(Token = "0x600105A")]
		Vector2 ToPlane(Vector3 p, out float elevation);

		[Token(Token = "0x600105B")]
		Vector3 ToWorld(Vector2 p, float elevation = 0f);

		[Token(Token = "0x600105C")]
		SimpleMovementPlane ToSimpleMovementPlane();
	}
}
