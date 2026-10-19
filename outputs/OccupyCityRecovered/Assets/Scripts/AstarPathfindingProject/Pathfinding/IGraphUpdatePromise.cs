using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding
{
	[Token(Token = "0x20000A5")]
	public interface IGraphUpdatePromise
	{
		[Token(Token = "0x1700011F")]
		float Progress
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x4510208", Offset = "0x450C208", VA = "0x4510208", Slot = "0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x4510210", Offset = "0x450C210", VA = "0x4510210", Slot = "1")]
		IEnumerator<JobHandle> Prepare()
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		void Apply(IGraphUpdateContext context);
	}
}
