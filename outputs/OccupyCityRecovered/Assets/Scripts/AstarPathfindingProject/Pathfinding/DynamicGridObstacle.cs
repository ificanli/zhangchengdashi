using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200014A")]
	[Obsolete("Has been renamed to DynamicObstacle")]
	public interface DynamicGridObstacle
	{
		[Token(Token = "0x170001DB")]
		bool enabled
		{
			[Token(Token = "0x6000A8F")]
			get;
			[Token(Token = "0x6000A90")]
			set;
		}

		[Token(Token = "0x170001DC")]
		float updateError
		{
			[Token(Token = "0x6000A91")]
			get;
			[Token(Token = "0x6000A92")]
			set;
		}

		[Token(Token = "0x170001DD")]
		float checkTime
		{
			[Token(Token = "0x6000A93")]
			get;
			[Token(Token = "0x6000A94")]
			set;
		}

		[Token(Token = "0x6000A95")]
		void DoUpdateGraphs();
	}
}
