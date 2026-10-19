using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200060F")]
	public class WorldCupShootStageView : MonoBehaviour
	{
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _renderCamera;

		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootballGameController _gameController;

		[Token(Token = "0x4003255")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FootballShootVfxController _vfxController;

		[Token(Token = "0x4003256")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FootballSightController _sight;

		[Token(Token = "0x4003257")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FootballGoalkeeperController _goalkeeper;

		[Token(Token = "0x4003258")]
		[FieldOffset(Offset = "0x48")]
		private Camera _boundUiCamera;

		[Token(Token = "0x170001C3")]
		public Camera RenderCamera
		{
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x3F0F94C", Offset = "0x3F0B94C", VA = "0x3F0F94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		public FootballGameController GameController
		{
			[Token(Token = "0x6002057")]
			[Address(RVA = "0x3F0F954", Offset = "0x3F0B954", VA = "0x3F0F954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002058")]
		[Address(RVA = "0x3F0E980", Offset = "0x3F0A980", VA = "0x3F0E980")]
		public void BindUiCamera(Camera uiCamera)
		{
		}

		[Token(Token = "0x6002059")]
		[Address(RVA = "0x3F0F95C", Offset = "0x3F0B95C", VA = "0x3F0F95C")]
		public void EnsureCameraStack()
		{
		}

		[Token(Token = "0x600205A")]
		[Address(RVA = "0x3F0EA04", Offset = "0x3F0AA04", VA = "0x3F0EA04")]
		public void ShowStage()
		{
		}

		[Token(Token = "0x600205B")]
		[Address(RVA = "0x3F0E880", Offset = "0x3F0A880", VA = "0x3F0E880")]
		public void ApplyPreGameplayState()
		{
		}

		[Token(Token = "0x600205C")]
		[Address(RVA = "0x3F0E514", Offset = "0x3F0A514", VA = "0x3F0E514")]
		public void SetSightVisible(bool visible)
		{
		}

		[Token(Token = "0x600205D")]
		[Address(RVA = "0x3F0FD68", Offset = "0x3F0BD68", VA = "0x3F0FD68")]
		private void SetGoalkeeperVisible(bool visible)
		{
		}

		[Token(Token = "0x600205E")]
		[Address(RVA = "0x3F0E7C4", Offset = "0x3F0A7C4", VA = "0x3F0E7C4")]
		public void HideStage()
		{
		}

		[Token(Token = "0x600205F")]
		[Address(RVA = "0x3F0FB5C", Offset = "0x3F0BB5C", VA = "0x3F0FB5C")]
		public void ReleaseCameraStack()
		{
		}

		[Token(Token = "0x6002060")]
		[Address(RVA = "0x3F0FCA8", Offset = "0x3F0BCA8", VA = "0x3F0FCA8")]
		private void PrepareRenderCamera()
		{
		}

		[Token(Token = "0x6002061")]
		[Address(RVA = "0x3F0FE24", Offset = "0x3F0BE24", VA = "0x3F0FE24")]
		public WorldCupShootStageView()
		{
		}
	}
}
