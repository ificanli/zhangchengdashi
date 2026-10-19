using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000115")]
	[Obsolete("Has been renamed to RecastNavmeshModifier")]
	public interface RecastMeshObj
	{
		[Token(Token = "0x170001B7")]
		bool enabled
		{
			[Token(Token = "0x6000964")]
			get;
			[Token(Token = "0x6000965")]
			set;
		}

		[Token(Token = "0x170001B8")]
		bool dynamic
		{
			[Token(Token = "0x6000966")]
			get;
			[Token(Token = "0x6000967")]
			set;
		}

		[Token(Token = "0x170001B9")]
		bool solid
		{
			[Token(Token = "0x6000968")]
			get;
			[Token(Token = "0x6000969")]
			set;
		}

		[Token(Token = "0x170001BA")]
		RecastNavmeshModifier.GeometrySource geometrySource
		{
			[Token(Token = "0x600096A")]
			get;
			[Token(Token = "0x600096B")]
			set;
		}

		[Token(Token = "0x170001BB")]
		RecastNavmeshModifier.ScanInclusion includeInScan
		{
			[Token(Token = "0x600096C")]
			get;
			[Token(Token = "0x600096D")]
			set;
		}

		[Token(Token = "0x170001BC")]
		int surfaceID
		{
			[Token(Token = "0x600096E")]
			get;
			[Token(Token = "0x600096F")]
			set;
		}

		[Token(Token = "0x170001BD")]
		RecastNavmeshModifier.Mode mode
		{
			[Token(Token = "0x6000970")]
			get;
			[Token(Token = "0x6000971")]
			set;
		}
	}
}
