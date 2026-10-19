using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000462")]
	public class GenealogyInteractCtrl
	{
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x10")]
		private readonly GenealogyTransCtrl _genealogyTransCtrl;

		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x18")]
		private readonly Camera _mainCamera;

		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x20")]
		private Transform _genealogyTrans;

		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x28")]
		private bool _isFingerDown;

		[Token(Token = "0x600156E")]
		[Address(RVA = "0x3E191C8", Offset = "0x3E151C8", VA = "0x3E191C8")]
		public GenealogyInteractCtrl(GenealogyTransCtrl genealogyTransCtrl)
		{
		}

		[Token(Token = "0x600156F")]
		[Address(RVA = "0x3E19240", Offset = "0x3E15240", VA = "0x3E19240")]
		public void UpdateCurrentScaleRatio(float currentScaleRadio)
		{
		}

		[Token(Token = "0x6001570")]
		[Address(RVA = "0x3E1925C", Offset = "0x3E1525C", VA = "0x3E1925C")]
		public bool ToUpdate()
		{
			return default;
		}
	}
}
