using Il2CppDummyDll;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002D9")]
	public abstract class RVOObstacle : VersionedMonoBehaviour
	{
		[Token(Token = "0x20002DA")]
		public enum ObstacleVertexWinding
		{
			[Token(Token = "0x4000D37")]
			KeepOut = 0,
			[Token(Token = "0x4000D38")]
			KeepIn = 1
		}

		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x28")]
		public ObstacleVertexWinding obstacleMode;

		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x2C")]
		public RVOLayer layer;

		[Token(Token = "0x170002C1")]
		protected abstract bool ExecuteInEditor
		{
			[Token(Token = "0x60011FD")]
			get;
		}

		[Token(Token = "0x170002C2")]
		protected abstract bool LocalCoordinates
		{
			[Token(Token = "0x60011FE")]
			get;
		}

		[Token(Token = "0x170002C3")]
		protected abstract bool StaticObstacle
		{
			[Token(Token = "0x60011FF")]
			get;
		}

		[Token(Token = "0x170002C4")]
		protected abstract float Height
		{
			[Token(Token = "0x6001200")]
			get;
		}

		[Token(Token = "0x6001201")]
		[Address(RVA = "0x44A7410", Offset = "0x44A3410", VA = "0x44A7410")]
		protected RVOObstacle()
		{
		}
	}
}
