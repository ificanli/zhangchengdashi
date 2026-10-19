using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x200029B")]
	public interface ITransform
	{
		[Token(Token = "0x6001083")]
		Vector3 Transform(Vector3 position);

		[Token(Token = "0x6001084")]
		Vector3 InverseTransform(Vector3 position);
	}
}
