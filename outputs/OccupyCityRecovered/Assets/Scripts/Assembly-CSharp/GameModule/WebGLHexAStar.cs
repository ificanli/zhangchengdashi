using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002B2")]
	internal sealed class WebGLHexAStar
	{
		[Token(Token = "0x4002159")]
		[FieldOffset(Offset = "0x10")]
		private int[] _heapIndex;

		[Token(Token = "0x400215A")]
		[FieldOffset(Offset = "0x18")]
		private int[] _heapCost;

		[Token(Token = "0x400215B")]
		[FieldOffset(Offset = "0x20")]
		private int[] _cameFrom;

		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x28")]
		private int[] _gScore;

		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x30")]
		private int[] _closedStamp;

		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x38")]
		private int _heapCount;

		[Token(Token = "0x400215F")]
		[FieldOffset(Offset = "0x3C")]
		private int _searchStamp;

		[Token(Token = "0x4002160")]
		[FieldOffset(Offset = "0x40")]
		private int[] _pathReverse;

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x3D32208", Offset = "0x3D2E208", VA = "0x3D32208")]
		public bool TryFindNextHex(WebGLHexPathField graph, bool ownerIsEnemy, int startIndex, int targetIndex, out int nextIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexAStar.TryFindNextHex RVA=0x3D32208 Token=0x6000BF9");
}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x3D32D54", Offset = "0x3D2ED54", VA = "0x3D32D54")]
		public int CollectPath(WebGLHexPathField graph, bool ownerIsEnemy, int startIndex, int targetIndex, List<Vector3> result, int maxPoints)
		{
			return default;
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x3D32A54", Offset = "0x3D2EA54", VA = "0x3D32A54")]
		private bool TryResolveNext(int startIndex, int targetIndex, out int nextIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebGLHexAStar.TryResolveNext RVA=0x3D32A54 Token=0x6000BFB");
}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x3D3251C", Offset = "0x3D2E51C", VA = "0x3D3251C")]
		private void EnsureCapacity(int count)
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x3D32670", Offset = "0x3D2E670", VA = "0x3D32670")]
		private void ClearStamps()
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x3D325F8", Offset = "0x3D2E5F8", VA = "0x3D325F8")]
		private void ResetSearchState()
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x3D32818", Offset = "0x3D2E818", VA = "0x3D32818")]
		private void Push(int index, int cost)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x3D328FC", Offset = "0x3D2E8FC", VA = "0x3D328FC")]
		private int Pop()
		{
			return default;
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x3D3304C", Offset = "0x3D2F04C", VA = "0x3D3304C")]
		public WebGLHexAStar()
		{
		}
	}
}
