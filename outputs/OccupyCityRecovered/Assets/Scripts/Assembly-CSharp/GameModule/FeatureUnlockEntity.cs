using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000497")]
	public class FeatureUnlockEntity : MonoBehaviour
	{
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x20")]
		private bool hadSetFeatureId;

		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x28")]
		public string featureId;

		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x30")]
		private Action<bool> featureStateChangeActive;

		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x3E4F0B4", Offset = "0x3E4B0B4", VA = "0x3E4F0B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x3E4F22C", Offset = "0x3E4B22C", VA = "0x3E4F22C")]
		public bool IsUnlock()
		{
			return default;
		}

		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x3E4F0E8", Offset = "0x3E4B0E8", VA = "0x3E4F0E8")]
		public void SetFeatureId(string featureId)
		{
		}

		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x3E4F310", Offset = "0x3E4B310", VA = "0x3E4F310")]
		public void RegisterFeatureStateChange(Action<bool> action)
		{
		}

		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x3E4F410", Offset = "0x3E4B410", VA = "0x3E4F410")]
		public void UnRegisterFeatureStateChange(Action<bool> action)
		{
		}

		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x3E4F288", Offset = "0x3E4B288", VA = "0x3E4F288")]
		private void FeatureStateChange(object o)
		{
		}

		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x3E4F4B8", Offset = "0x3E4B4B8", VA = "0x3E4F4B8")]
		public FeatureUnlockEntity()
		{
		}
	}
}
