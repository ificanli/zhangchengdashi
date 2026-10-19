using System.ComponentModel;
using Il2CppDummyDll;

namespace Pathfinding.Ionic
{
	[Token(Token = "0x2000018")]
	internal enum ComparisonOperator
	{
		[Token(Token = "0x4000038")]
		[Description(">")]
		GreaterThan = 0,
		[Token(Token = "0x4000039")]
		[Description(">=")]
		GreaterThanOrEqualTo = 1,
		[Token(Token = "0x400003A")]
		[Description("<")]
		LesserThan = 2,
		[Token(Token = "0x400003B")]
		[Description("<=")]
		LesserThanOrEqualTo = 3,
		[Token(Token = "0x400003C")]
		[Description("=")]
		EqualTo = 4,
		[Token(Token = "0x400003D")]
		[Description("!=")]
		NotEqualTo = 5
	}
}
