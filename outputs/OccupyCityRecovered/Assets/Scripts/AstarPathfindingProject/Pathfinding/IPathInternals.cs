using System.Text;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000BA")]
	internal interface IPathInternals
	{
		[Token(Token = "0x1700013B")]
		bool Pooled
		{
			[Token(Token = "0x600062F")]
			get;
			[Token(Token = "0x6000630")]
			set;
		}

		[Token(Token = "0x6000631")]
		void AdvanceState(PathState s);

		[Token(Token = "0x6000632")]
		void OnEnterPool();

		[Token(Token = "0x6000633")]
		void Reset();

		[Token(Token = "0x6000634")]
		void ReturnPath();

		[Token(Token = "0x6000635")]
		void PrepareBase(PathHandler handler);

		[Token(Token = "0x6000636")]
		void Prepare(ref Path.SearchContext ctx);

		[Token(Token = "0x6000637")]
		void Cleanup(ref Path.SearchContext ctx);

		[Token(Token = "0x6000638")]
		void CalculateStep(ref Path.SearchContext ctx, long targetTick);

		[Token(Token = "0x6000639")]
		void DebugString(StringBuilder builder, PathLog logMode);
	}
}
