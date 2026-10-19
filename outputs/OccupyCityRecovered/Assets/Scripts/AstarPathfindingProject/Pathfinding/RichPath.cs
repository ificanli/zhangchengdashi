using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200001F")]
	public class RichPath
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x10")]
		private int currentPart;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<RichPathPart> parts;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		public Seeker seeker;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		public ITransform transform;

		[Token(Token = "0x170000AC")]
		public Vector3 Endpoint
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x4458C28", Offset = "0x4454C28", VA = "0x4458C28")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x4458C34", Offset = "0x4454C34", VA = "0x4458C34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool CompletedAllParts
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x4458C40", Offset = "0x4454C40", VA = "0x4458C40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AE")]
		public bool IsLastPart
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x4458C94", Offset = "0x4454C94", VA = "0x4458C94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x44574B0", Offset = "0x44534B0", VA = "0x44574B0")]
		public RichPath()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4457534", Offset = "0x4453534", VA = "0x4457534")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x44575B0", Offset = "0x44535B0", VA = "0x44575B0")]
		public void Initialize(Seeker seeker, Path path, bool mergePartEndpoints, bool simplificationMode)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4458CEC", Offset = "0x4454CEC", VA = "0x4458CEC")]
		public void NextPart()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4458D48", Offset = "0x4454D48", VA = "0x4458D48")]
		public RichPathPart GetCurrentPart()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4458DCC", Offset = "0x4454DCC", VA = "0x4458DCC")]
		public void GetRemainingPath(List<Vector3> buffer, List<PathPartWithLinkInfo> partsBuffer, Vector3 currentPosition, out bool requiresRepath)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichPath.GetRemainingPath RVA=0x4458DCC Token=0x6000209");
}
	}
}
