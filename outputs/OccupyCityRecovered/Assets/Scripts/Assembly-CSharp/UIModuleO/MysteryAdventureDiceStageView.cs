using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x20009D3")]
	public class MysteryAdventureDiceStageView : MonoBehaviour
	{
		[Token(Token = "0x4004936")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _renderCamera;

		[Token(Token = "0x4004937")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animation _rollAnimation;

		[Token(Token = "0x4004938")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _diceMeshTransform;

		[Token(Token = "0x170008F1")]
		public Camera RenderCamera
		{
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x4118A24", Offset = "0x4114A24", VA = "0x4118A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F2")]
		public Animation RollAnimation
		{
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x4118A2C", Offset = "0x4114A2C", VA = "0x4118A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F3")]
		public Transform DiceMeshTransform
		{
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x4118A34", Offset = "0x4114A34", VA = "0x4118A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003A97")]
		[Address(RVA = "0x4117FDC", Offset = "0x4113FDC", VA = "0x4117FDC")]
		public void EnsureBindings()
		{
		}

		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x4118A3C", Offset = "0x4114A3C", VA = "0x4118A3C")]
		public MysteryAdventureDiceStageView()
		{
		}
	}
}
