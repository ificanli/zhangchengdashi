using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009DF")]
	public class MysteryAdventureFaceSlapPanelView : MonoBehaviour
	{
		[Token(Token = "0x4004974")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4004975")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _dontShowToggle;

		[Token(Token = "0x170008FA")]
		public Button CloseButton
		{
			[Token(Token = "0x6003AE0")]
			[Address(RVA = "0x4120550", Offset = "0x411C550", VA = "0x4120550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008FB")]
		public Toggle DontShowToggle
		{
			[Token(Token = "0x6003AE1")]
			[Address(RVA = "0x4120558", Offset = "0x411C558", VA = "0x4120558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x4120560", Offset = "0x411C560", VA = "0x4120560")]
		public MysteryAdventureFaceSlapPanelView()
		{
		}
	}
}
