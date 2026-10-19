using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	[Token(Token = "0x200001A")]
	public class TreeDemoSceneController : MonoBehaviour
	{
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		public GPUInstancerTreeManager manager;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x28")]
		public Text GPUIStateText;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x30")]
		public Text FPSCountTextText;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x38")]
		private FPS _fpsCounter;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x73B4500", Offset = "0x73B0500", VA = "0x73B4500")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x73B4550", Offset = "0x73B0550", VA = "0x73B4550")]
		private void Start()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x73B4560", Offset = "0x73B0560", VA = "0x73B4560")]
		private void Update()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x73B45E8", Offset = "0x73B05E8", VA = "0x73B45E8")]
		public void ToggleManager()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x73B4720", Offset = "0x73B0720", VA = "0x73B4720")]
		public TreeDemoSceneController()
		{
		}
	}
}
